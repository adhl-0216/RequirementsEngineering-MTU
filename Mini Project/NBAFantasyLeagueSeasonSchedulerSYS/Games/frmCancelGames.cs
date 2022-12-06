using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                dtgGames.Rows.Add(game.GameID, game.Home, game.Away, game.Date.ToShortDateString(), game.Time, game.Venue);
            }
        }

        private void btnCancelGame_Click(object sender, EventArgs e)
        {
            string reason;
            reason = txtReason.Text;
            if (!reason.Equals("")){
                DialogResult cfm = MessageBox.Show("Proceed to cancel selected Game(s)?", "Confirm Game Cancellation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (cfm == DialogResult.OK)
                {
                    DialogResult rs = MessageBox.Show("Confirm Reason:\n" + reason, "Reason for Cancellation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rs == DialogResult.OK)
                    {
                        MessageBox.Show("Selected Game(s) have been cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }else
            {
                MessageBox.Show("Please provide a valid reason for Game Cancellation", "Reason for Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
