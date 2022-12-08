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
        private static DataGridViewRow selectedGame;
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
            allGames = frmMainMenu.AllGames;
            foreach (Game game in allGames)
            {
                dtgGames.Rows.Add(game.GameID, game.HomeID, game.AwayID, game.Date.ToString("dd/MM/yyyy"), game.Time, game.Venue);
            }
            selectedGame = dtgGames.SelectedRows[0];
            lblGameID.Text = selectedGame.Cells["gameID"].Value.ToString();
            dtpDate.Value = DateTime.Parse(selectedGame.Cells["date"].Value.ToString());
            dtpTime.Value = DateTime.Parse(selectedGame.Cells["time"].Value.ToString());
            txtVenue.Text = selectedGame.Cells["venue"].Value.ToString();
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
            selectedGame = dtgGames.SelectedRows[0];
            lblGameID.Text = selectedGame.Cells["gameID"].Value.ToString();
            dtpDate.Value = DateTime.ParseExact(selectedGame.Cells["date"].Value.ToString(), "dd/MM/yyyy", null);
            dtpTime.Value = DateTime.Parse(selectedGame.Cells["time"].Value.ToString());
            txtVenue.Text = selectedGame.Cells["venue"].Value.ToString();
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            string format;
            string msg;
            DialogResult rs;
            format = "Reschedule Game: {0} \n-Date: {1}\n-Time: {2}\n-Venue: {3}";
            object[] args = { lblGameID.Text, dtpDate.Value.ToString("dd/MM/yyyy"), dtpTime.Value.ToString("HH:mm"), txtVenue.Text};
            msg = String.Format(format, args);
            rs = MessageBox.Show(msg,"Reschedule Game",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                selectedGame.Cells["date"].Value = dtpDate.Value.ToString("dd/MM/yyyy");
                selectedGame.Cells["time"].Value = dtpTime.Value.ToString("HH:mm");
                selectedGame.Cells["venue"].Value = txtVenue.Text;
            }
        }
    }
}
