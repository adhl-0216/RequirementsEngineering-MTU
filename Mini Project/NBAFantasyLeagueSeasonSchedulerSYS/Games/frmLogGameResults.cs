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
        private string winner;
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

            GameResult newGameResult = new GameResult(
                winner,
                Int32.Parse(txtHomePTS.Text), Int32.Parse(txtHomeTRB.Text), Int32.Parse(txtHomeAST.Text),
                Int32.Parse(txtAwayPTS.Text), Int32.Parse(txtAwayTRB.Text), Int32.Parse(txtAwayAST.Text),
                selectedGame.Cells["gameID"].Value.ToString()
            );

            string msg = $"[{newGameResult.gameID}]" +
                $"\n{selectedGame.Cells["home"].Value}: {newGameResult.homeScore} PTS/ {newGameResult.homeRebounds} TRB/ {newGameResult.homeAssists} AST" +
                $"\n{selectedGame.Cells["away"].Value}: {newGameResult.awayScore} PTS/ {newGameResult.awayRebounds} TRB/ {newGameResult.awayAssists} AST" +
                $"\n\nWINNER: {newGameResult.winner}";

            DialogResult response = MessageBox.Show(msg,"Confirm Game Results", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response == DialogResult.OK)
            {
                newGameResult.saveGameResult();
            }
            
            { 
                MessageBox.Show($"Game Results for [{newGameResult.gameID}] has succesfully been saved to Game Results File.", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                dtgGames.Enabled = true;
                btnSelect.Text = "SELECT";
                lblHome.Text = "HOME";
                lblHome.Font = default;
                lblHome.ForeColor = default;
                lblAway.Text = "AWAY";
                lblAway.ForeColor = default;
                lblAway.Font = default;
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Enabled = false;
                    textBox.Clear();
                }
                btnConfirm.Enabled = false;
                selectStatus = true;
                dtgGames.Rows.Remove(dtgGames.SelectedRows[0]);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtHomePTS, txtHomeTRB, txtHomeAST, txtAwayPTS, txtAwayTRB, txtAwayAST };
            if (selectStatus)
            {
                dtgGames.Enabled = false;
                btnSelect.Text = "CANCEL";
                lblHome.Text = selectedGame.Cells["home"].Value.ToString();
                lblAway.Text = selectedGame.Cells["away"].Value.ToString();
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
                lblHome.Text = "HOME";
                lblHome.ForeColor = Color.Black;
                lblAway.Text = "AWAY";
                lblAway.ForeColor = Color.Black;
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

        private void checkWinner(object sender, EventArgs e)
        {
            //check if input is empty
            if (txtHomePTS.Text.Equals("")) return;

            if (txtAwayPTS.Text.Equals("")) return;
            //check if input contains letters
            if (txtHomePTS.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Please enter whole numbers only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtHomePTS.Clear();
                return;
            }
   
            if (txtAwayPTS.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Please enter whole numbers only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAwayPTS.Clear();
                return;
            }

            if (int.Parse(txtHomePTS.Text.Trim()) == int.Parse(txtAwayPTS.Text.Trim()))
            {
                MessageBox.Show("An NBA Game can not result in a draw.", "Impossible Situation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (int.Parse(txtHomePTS.Text.Trim()) > int.Parse(txtAwayPTS.Text.Trim()))
            {
                lblHome.ForeColor = Color.Blue;
                lblHome.Font = new Font(lblHome.Font, FontStyle.Bold);
                lblAway.ForeColor = default;
                lblAway.Font = default;
                winner = lblHome.Text;
            }
            else
            {
                lblAway.ForeColor = Color.Blue;
                lblAway.Font = new Font(lblHome.Font, FontStyle.Bold);
                lblHome.ForeColor = default;
                lblHome.Font = default;
                winner = lblAway.Text;
            }
        }
    }
}