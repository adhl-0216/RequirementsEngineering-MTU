using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    public partial class frmReschedule : Form
    {
        private static new Form Parent;
        private static List<Game> allGames;
        private static Game selectedGame;
        private static bool selectStatus = true;
        public frmReschedule(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmReschedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void frmReschedule_Load(object sender, EventArgs e)
        {
            refreshDTG();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (selectStatus){ 
                dtgGames.Enabled = false;
                btnSelect.Text = "CANCEL";
                dtpDate.Enabled = true;
                dtpTime.Enabled = true;
                txtVenue.Enabled = true;

                selectStatus = false;
            }else
            {
                dtgGames.Enabled = true;
                btnSelect.Text = "SELECT";
                dtpDate.Enabled = false;
                dtpTime.Enabled = false;
                txtVenue.Enabled = false;

                selectStatus = true;
            }
        }

        private void dtgGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgGames.SelectedRows.Count == 0) return;
            int idx = dtgGames.SelectedRows[0].Index;
            selectedGame = allGames[idx];

            lblGameID.Text = selectedGame.gameID;
            dtpDate.Value = selectedGame.gameDate;
            dtpTime.Value = DateTime.Parse(selectedGame.gameTime.ToString());
            txtVenue.Text = selectedGame.venue;
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            //validation
            if (dtpDate.Value < DateTime.Now)
            {
                MessageBox.Show("Can not reschedule game to a date in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                dtpDate.Focus();
                return;
            }

            foreach (Game game in allGames)
            {
                if (game.gameID != selectedGame.gameID)
                {
                    if (game.gameDate.Equals(dtpDate.Value))
                    {
                        MessageBox.Show($"A game is already scheduled on this date. {dtpDate.Value:dd/MM/yyyy}", "Busy Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            string msg = $"Reschedule Game: [{lblGameID.Text}] \n-Date: {dtpDate.Value.ToString("dd/MM/yyyy")}\n-Time: {dtpTime.Value.ToString("HH:mm")}\n-Venue: {txtVenue.Text}";
            DialogResult rs = MessageBox.Show(msg, "Reschedule Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                selectedGame.gameDate = dtpDate.Value;
                selectedGame.gameTime = dtpTime.Value.TimeOfDay;
                selectedGame.venue = txtVenue.Text;

                selectedGame.sqlUpdateGame();
            }

            refreshDTG();
        }

        private void refreshDTG()
        {
            Game.sqlSelectGame(ref allGames);
            allGames.RemoveAll(game => game.gameDate < DateTime.Now);
            allGames.Sort((x,y) => x.gameDate.CompareTo(y.gameDate));

            dtgGames.Rows.Clear();
            allGames.ForEach(game => dtgGames.Rows.Add(game.gameDate.ToString("dd/MM/yyyy"), game.gameID, game.home.TeamID, game.away.TeamID, game.gameTime, game.venue));
        }
    }
}
