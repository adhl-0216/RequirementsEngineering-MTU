using System;
using System.Collections.Generic;
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
            if (dtgGames.Rows.Count < 1)//disable inputs if datagridview is empty
            {
                btnCancelGame.Enabled = false;
                txtReason.Enabled = false;
            }
        }

        private void btnCancelGame_Click(object sender, EventArgs e)
        {
            //set selected game
            Game selectedGame = allGames.Find(game => game.gameID.Equals(dtgGames.SelectedRows[0].Cells["gameID"].Value));
            string reason = txtReason.Text;

            if (!reason.Equals(""))//reason cannot be empty
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
            Game.sqlSelectAllGames(ref allGames);
            allGames.RemoveAll(game => game.gameDate < DateTime.Now.AddDays(-1) || game.recorded.Equals('Y'));

            dtgGames.Rows.Clear();
            allGames.ForEach(game => dtgGames.Rows.Add(game.gameDate.ToString("yyyy/MM/dd"), game.gameID, game.home.teamID, game.away.teamID, game.gameTime, game.venue));
        }
    }
}
