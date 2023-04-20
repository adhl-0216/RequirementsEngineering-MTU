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
            allTeams.ForEach(team => cboTeams.Items.Add($"[{team.teamID}] {team.teamName}"));
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
            txtTeamID.Text = selectedTeam.teamID;
            txtTeamName.Text = selectedTeam.teamName;
            txtGM.Text = selectedTeam.gm;
            txtHeadCoach.Text = selectedTeam.headCoach;
            txtAsstCoach.Text = selectedTeam.asstCoach;
            txtHomeCourt.Text = selectedTeam.homeCourt;

            //display Game Details
            dtgGames.Rows.Clear();
            Game.sqlSelectGameByTeamID(selectedTeam.teamID, ref teamGames);
            GameResult.sqlSelectResultsByID(selectedTeam.teamID, ref teamResults);

            foreach (GameResult result in teamResults)
            {
                Game game = teamGames.Find(g => g.gameID == result.gameID);
                string homeID = result.gameID.Substring(4,3);
                string awayID = result.gameID.Substring(0,3);
                string opponent = (homeID == selectedTeam.teamID) ? awayID : homeID ;
                string outcome = "";

                if (selectedTeam.teamID == homeID)//determine game result for specific team
                {
                    outcome = (result.winner.Equals('H')) ? "W" : "L" ;
                }
                else if (selectedTeam.teamID == awayID)
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

            int wins = selectedTeam.teamWins, loses = selectedTeam.teamLoses;
            lblTeamWins.Text = $"({wins}-{loses})";

        }
    }
}
