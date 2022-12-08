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
    public partial class frmLogGameResults : Form
    {
        private static new Form Parent;
        private static List<Game> allGames;
        private static DataGridViewRow selectedGame;
        private static bool selectStatus = true;
        public frmLogGameResults(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmLogGameResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void frmLogGameResults_Load(object sender, EventArgs e)
        {
            allGames = frmMainMenu.AllGames;
            foreach (Game game in allGames)
            {
                dtgGames.Rows.Add(game.GameID, game.HomeID, game.AwayID, game.Date.ToString("dd/MM/yyyy"), game.Time, game.Venue);
            }
            selectedGame = dtgGames.SelectedRows[0];
            lblGameID.Text = selectedGame.Cells["gameID"].Value.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string winnerName = null;
            DialogResult rs;
            string msg;
            TextBox[] textBoxes = { txtHomePTS, txtHomeTRB, txtHomeAST, txtAwayPTS, txtAwayTRB, txtAwayAST };
            //input validation
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text.Equals(""))
                {
                    MessageBox.Show("No value entered", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox.Focus();
                    return;
                }
                else if (textBox.Text.Any(char.IsLetter))
                {
                    textBox.Clear();
                    MessageBox.Show("Please enter whole numbers only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox.Focus();
                    return;
                }
            }

            if (grpWinner.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked) == null)
            {
                MessageBox.Show("Please select the Winner of the Game", "No Winner Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                grpWinner.Focus();
                return;
            }
            else
            {
                string winner = grpWinner.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Tag.ToString();
                if (winner.Equals("H"))
                {
                    winnerName = selectedGame.Cells["home"].Value.ToString();
                }
                else if (winner.Equals("A"))
                {
                    winnerName = selectedGame.Cells["away"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("An Unknown Error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            object[] args = { 
                selectedGame.Cells["home"].Value, txtHomePTS.Text, txtHomeTRB.Text, txtHomeAST.Text,
                selectedGame.Cells["away"].Value, txtAwayPTS.Text, txtAwayTRB.Text, txtAwayAST.Text,
                winnerName
            };
            msg = string.Format("{0}: {1} PTS / {2} TRB / {3} AST\n" +
                "{4}: {5} PTS / {6} TRB / {7} AST\n" +
                "WINNER: {8}", args);
            
            rs = MessageBox.Show(msg,"Confirm Game Results", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                MessageBox.Show("Game Results for [" + selectedGame.Cells["gameID"].Value + "] has succesfully been saved to Game Results File.", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                dtgGames.Enabled = true;
                btnSelect.Text = "SELECT";
                rdHome.Text = "HOME";
                rdHome.Checked = false;
                rdAway.Text = "AWAY";
                rdAway.Checked = false;
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Enabled = false;
                    textBox.Clear();
                }
                btnConfirm.Enabled = false;
                selectStatus = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtHomePTS, txtHomeTRB, txtHomeAST, txtAwayPTS, txtAwayTRB, txtAwayAST };
            if (selectStatus)
            {
                dtgGames.Enabled = false;
                btnSelect.Text = "CANCEL";
                rdHome.Text = selectedGame.Cells["home"].Value.ToString();
                rdAway.Text = selectedGame.Cells["away"].Value.ToString();
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Enabled = true;
                }
                btnConfirm.Enabled = true;
                selectStatus = false;
            }
            else
            {
                dtgGames.Enabled = true;
                btnSelect.Text = "SELECT";
                rdHome.Text = "HOME";
                rdHome.Checked = false;
                rdAway.Text = "AWAY";
                rdAway.Checked = false;
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Enabled = false;
                    textBox.Clear();
                }
                btnConfirm.Enabled = false;
                selectStatus = true;
            }
        }

        private void dtgGames_SelectionChanged(object sender, EventArgs e)
        {
            selectedGame = dtgGames.SelectedRows[0];
            lblGameID.Text = selectedGame.Cells["gameID"].Value.ToString();
        }

        private void txtHomePTS_Leave(object sender, EventArgs e)
        {
            if (!txtHomePTS.Text.Equals("") && txtHomePTS.Text.Any(char.IsDigit) &&
                !txtAwayPTS.Text.Equals("") && txtAwayPTS.Text.Any(char.IsDigit))
            {
                if (int.Parse(txtHomePTS.Text) > int.Parse(txtAwayPTS.Text))
                {
                    rdHome.Checked = true;
                }
                else
                {
                    rdAway.Checked = true;
                }
            }
        }

        private void txtAwayPTS_Leave(object sender, EventArgs e)
        {
            if (!txtHomePTS.Text.Equals("") && txtHomePTS.Text.Any(char.IsDigit) && 
                !txtAwayPTS.Text.Equals("") && txtAwayPTS.Text.Any(char.IsDigit))
            {
                if (int.Parse(txtHomePTS.Text) > int.Parse(txtAwayPTS.Text))
                {
                    rdHome.Checked = true;
                }
                else
                {
                    rdAway.Checked = true;
                }
            }
        }
    }
}
