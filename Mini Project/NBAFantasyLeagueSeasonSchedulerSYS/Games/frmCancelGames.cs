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
            allGames = frmMainMenu.AllGames;
            foreach (Game game in allGames)
            {
                dtgGames.Rows.Add(game.GameID, game.Home, game.Away, game.Date.ToString("dd/MM/yyyy"), game.Time, game.Venue);
            }
        }

        private void btnCancelGame_Click(object sender, EventArgs e)
        {
            string reason;
            DataGridViewSelectedRowCollection selectedRows;

            reason = txtReason.Text;
            selectedRows = dtgGames.SelectedRows;
            if (selectedRows.Count > 0 ){
                if (!reason.Equals(""))
                {
                    StringBuilder str = new StringBuilder();
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        str.Append('-');
                        str.AppendLine(row.Cells["gameID"].Value.ToString());
                    }
                    DialogResult cfm = MessageBox.Show("Proceed to cancel selected Game(s)?\n\n" + str, "Confirm Game Cancellation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (cfm == DialogResult.OK)
                    {
                        DialogResult rs = MessageBox.Show("Confirm Reason:\n" + reason, "Reason for Cancellation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (rs == DialogResult.OK)
                        {
                            MessageBox.Show("Selected Game(s) have been cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            foreach (DataGridViewRow row in selectedRows)
                            {
                                dtgGames.Rows.Remove(row);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please provide a valid reason for Game Cancellation", "Reason for Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please select the Game(s) to be cancelled", "No Games Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtgGames_SelectionChanged(object sender, EventArgs e)
        {
/*            DataGridViewSelectedRowCollection selectedRows = dtgGames.SelectedRows;
            StringBuilder str = new StringBuilder();
            foreach (DataGridViewRow row in selectedRows)
            {
                str.AppendLine(row.Cells["gameID"].Value.ToString());
            }
            Debug.WriteLine(str.ToString());*/
        }
    }
}
