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
    public partial class frmCancelGames : Form
    {
        private static new Form Parent;
        private static List<Game> allGames;
        public frmCancelGames(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmCancelGames_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void frmCancelGames_Load(object sender, EventArgs e)
        {
            refreshDTG();
        }

        private void btnCancelGame_Click(object sender, EventArgs e)
        {
            int idx = dtgGames.SelectedRows[0].Index;
            Game selectedGame = allGames[idx];

            string reason = txtReason.Text;

            if (!reason.Equals(""))
            {
                DialogResult cfm = MessageBox.Show($"Proceed to cancel selected Game(s)?\n\n[{selectedGame.gameID}]\nReason\n\n{ reason}", "Confirm Game Cancellation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (cfm == DialogResult.OK)
                {
                    selectedGame.sqlDeleteGame(reason);

                    MessageBox.Show("Selected Game has been cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReason.Clear();
                    refreshDTG();
                }
            }
            else
            {
                MessageBox.Show("Please provide a valid reason for Game Cancellation", "Missing Reason for Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void refreshDTG()
        {
            Game.sqlSelectGame(ref allGames);
            allGames.RemoveAll(game => game.gameDate < DateTime.Now);

            dtgGames.Rows.Clear();
            allGames.ForEach(game => dtgGames.Rows.Add(game.gameID, game.home.TeamID, game.away.TeamID, game.gameDate.ToString("dd/MM/yyyy"), game.gameTime, game.venue));
        }
    }
}
