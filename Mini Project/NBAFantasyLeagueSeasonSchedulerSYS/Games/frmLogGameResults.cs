using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
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
        private static List<Team> allTeams;
        private static List<Game> allGames;
        private static Game selectedGame;
        private char winner;

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
            refreshDTG();
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

            GameResult gameResult = new GameResult(
                winner,
                Int32.Parse(txtHomePTS.Text), Int32.Parse(txtHomeTRB.Text), Int32.Parse(txtHomeAST.Text),
                Int32.Parse(txtAwayPTS.Text), Int32.Parse(txtAwayTRB.Text), Int32.Parse(txtAwayAST.Text),
                selectedGame.gameID
            );

            string msg = $"[{gameResult.gameID}]" +
                $"\n\n{selectedGame.home.TeamID}: {gameResult.homeScore} PTS/ {gameResult.homeRebounds} TRB/ {gameResult.homeAssists} AST" +
                $"\n{selectedGame.away.TeamID}: {gameResult.awayScore} PTS/ {gameResult.awayRebounds} TRB/ {gameResult.awayAssists} AST" +
                $"\n\nWINNER: {((gameResult.winner == 'H') ? selectedGame.home.TeamID : selectedGame.away.TeamID)}";

            DialogResult response = MessageBox.Show(msg,"Confirm Game Results", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response == DialogResult.OK)
            {
                gameResult.sqlInsertResult();
                selectedGame.gameRecorded();

                MessageBox.Show($"Game Results for [{gameResult.gameID}] has succesfully been saved to Game Results File.", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                refreshDTG();
                enableInputs(false);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (btnSelect.Text.Equals("SELECT")){
                enableInputs();
                return;
            }     
            
            if (btnSelect.Text.Equals("CANCEL")){
                enableInputs(false);
                return;
            }
        }

        private void dtgGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgGames.SelectedRows.Count == 0) return;
            selectedGame = allGames.Find(game => game.gameID.Equals(dtgGames.SelectedRows[0].Cells["gameID"].Value));
            lblGameID.Text = selectedGame.gameID;
            lblHome.Text = selectedGame.home.TeamID;
            lblAway.Text = selectedGame.away.TeamID;
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

            Team.sqlSelectTeam(ref allTeams);
            Team home = allTeams.Find(team => team.TeamID.Equals(selectedGame.home.TeamID));
            Team away = allTeams.Find(team => team.TeamID.Equals(selectedGame.away.TeamID));

            if (int.Parse(txtHomePTS.Text.Trim()) > int.Parse(txtAwayPTS.Text.Trim()))
            {
                lblHome.ForeColor = Color.Blue;
                lblHome.Font = new Font(lblHome.Font, FontStyle.Bold);
                lblAway.ForeColor = default;
                lblAway.Font = default;
                winner = 'H';
                home.TeamWins += 1;
                away.TeamLoses += 1;
                home.sqlUpdateTeam();
                away.sqlUpdateTeam();


            }
            else
            {
                lblAway.ForeColor = Color.Blue;
                lblAway.Font = new Font(lblHome.Font, FontStyle.Bold);
                lblHome.ForeColor = default;
                lblHome.Font = default;
                winner = 'A';
                home.TeamWins += 1;
                away.TeamLoses += 1;
                away.sqlUpdateTeam();
                home.sqlUpdateTeam();
            }
        }

        private void refreshDTG()
        {
            Game.sqlSelectAllGames(ref allGames);
            allGames.RemoveAll(game => game.recorded.Equals('Y') || game.gameDate > DateTime.Now);
            allGames.Sort((x, y) => x.gameDate.CompareTo(y.gameDate));

            dtgGames.Rows.Clear();
            allGames.ForEach(game => dtgGames.Rows.Add(game.gameDate.ToString("yyyy/MM/dd"), game.gameID, game.home.TeamID, game.away.TeamID,  game.gameTime, game.venue));
        }

        private void enableInputs(bool enable = true)
        {
            TextBox[] textBoxes = { txtHomePTS, txtHomeTRB, txtHomeAST, txtAwayPTS, txtAwayTRB, txtAwayAST };
            btnSelect.Text = (enable) ? "CANCEL" : "SELECT";
            dtgGames.Enabled = !enable;
            lblHome.ForeColor = default;
            lblHome.Font = default;
            lblAway.ForeColor = default;
            lblAway.Font = default;
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Enabled = enable;
                textBox.Clear();
            }
            btnConfirm.Enabled = enable;
        }
    }
}