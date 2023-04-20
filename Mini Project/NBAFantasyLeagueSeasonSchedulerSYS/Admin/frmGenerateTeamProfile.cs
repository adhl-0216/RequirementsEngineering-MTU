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
        private static List<Game> teamGames;
        private static List<GameResult> teamResults;

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
            Game.sqlSelectGameByTeamID(selectedTeam.TeamID, ref teamGames);
            GameResult.sqlSelectResultsByID(selectedTeam.TeamID, ref teamResults);

            foreach (GameResult result in teamResults)
            {
                Game game = teamGames.Find(g => g.gameID == result.gameID);
                string homeID = result.gameID.Substring(4,3);
                string awayID = result.gameID.Substring(0,3);
                string opponent = (homeID == selectedTeam.TeamID) ? awayID : homeID ;
                string outcome = "";

                if (selectedTeam.TeamID == homeID)//determine game result for specific team
                {
                    outcome = (result.winner.Equals('H')) ? "W" : "L" ;
                }
                else if (selectedTeam.TeamID == awayID)
                {
                    outcome = (result.winner.Equals('H')) ? "L" : "W";
                }

                string homeFinalStat = $"{result.homeScore} PTS/ {result.homeRebounds} TRB/ {result.homeAssists} AST";
                string awayFinalStat = $"{result.awayScore} PTS/ {result.awayRebounds} TRB/ {result.awayAssists} AST";

                dtgGames.Rows.Add(
                    game.gameDate.ToString("yyyy/MM/dd"), 
                    game.gameID, 
                    awayFinalStat,
                    homeFinalStat,
                    opponent, 
                    outcome,
                    game.gameTime.ToString("h':'mm"), 
                    game.venue
                    );
            }

            int wins = selectedTeam.TeamWins, loses = selectedTeam.TeamLoses;
            lblTeamWins.Text = $"({wins}-{loses})";

        }
    }
}
