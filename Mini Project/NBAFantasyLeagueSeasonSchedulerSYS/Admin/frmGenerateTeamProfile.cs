using NBAFantasyLeagueSeasonSchedulerSYS.Games;
using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Admin
{
    public partial class frmGenerateTeamProfile : Form
    {
        private static new Form Parent;
        private static List<Team> allTeams;
        private static List<Game> allGames;
        private static List<GameResult> allResults;

        public frmGenerateTeamProfile(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmGenerateTeamProfile_Load(object sender, EventArgs e)
        {
            Team.sqlSelectTeam(ref allTeams);
            allTeams.ForEach(team => cboTeams.Items.Add($"[{team.TeamID}] {team.TeamName}"));
        }

        private void frmGenerateTeamProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Parent != null)
            {
                Parent.Show();
            }
        }

        private void cboTeams_SelectedValueChanged(object sender, EventArgs e)
        {
            //display Team details
            Team selectedTeam = allTeams[cboTeams.SelectedIndex];
            txtTeamID.Text = selectedTeam.TeamID;
            txtTeamName.Text = selectedTeam.TeamName;
            txtGM.Text = selectedTeam.Gm;
            txtHeadCoach.Text = selectedTeam.HeadCoach;
            txtAsstCoach.Text = selectedTeam.AsstCoach;
            txtHomeCourt.Text = selectedTeam.HomeCourt;

            //display Game Details
            dtgGames.Rows.Clear();
            Game.sqlSelectGame(ref allGames);
            allGames.RemoveAll(game => !(game.gameID.Contains(selectedTeam.TeamID)));
            GameResult.sqlSelectResults(ref allResults);
            allResults.RemoveAll(results => !(results.gameID.Contains(selectedTeam.TeamID)));
            foreach (GameResult result in allResults)
            {
                Game game = allGames.Find(g => g.gameID.Equals(result.gameID));
                string opponent = (game.home.TeamID == selectedTeam.TeamID) ? game.away.TeamID : game.home.TeamID ;
                string outcome = "L";
                if (game.home.TeamID == selectedTeam.TeamID)
                {
                    if (result.winner.Equals('H')) outcome = "W";
                    if (result.winner.Equals('A')) outcome = "L";
                }else
                {
                    if (result.winner.Equals('H')) outcome = "L";
                    if (result.winner.Equals('A')) outcome = "W";
                }
                string homeFinalStat = $"{result.homeScore} PTS/ {result.homeRebounds} TRB/ {result.homeAssists} AST";
                string awayFinalStat = $"{result.awayScore} PTS/ {result.awayRebounds} TRB/ {result.awayAssists} AST";

                dtgGames.Rows.Add(
                    game.gameDate.ToString("yyyy/MM/dd"), 
                    game.gameID, 
                    opponent, 
                    homeFinalStat,
                    awayFinalStat,
                    outcome,
                    game.gameTime.ToString("h':'mm"), 
                    game.venue
                    );
            }

            int wins = 0, total = dtgGames.RowCount;
            foreach (DataGridViewRow row in dtgGames.Rows)
            {
                if (row.Cells["result"].Value.ToString().Equals("W"))
                {
                    wins++;
                }
            }
            lblTeamWins.Text = $"({wins}-{total})";
        }
    }
}
