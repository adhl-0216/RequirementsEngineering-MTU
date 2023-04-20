using NBAFantasyLeagueSeasonSchedulerSYS.Games;
using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Admin
{
    public partial class frmViewTeamStandings : Form
    {
        private static new Form Parent;
        private static List<Team> allTeams;
        public frmViewTeamStandings(Form parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void frmViewTeamStandings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Parent != null) Parent.Show();
        }

        private void frmViewTeamStandings_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void refreshDGV()
        {
            Team.sqlSelectTeam(ref allTeams);
            List<teamStanding> allStandings = new List<teamStanding>(); 
            allTeams.ForEach(team => {
                List<GameResult> teamResults = new List<GameResult>();
                try
                {
                    GameResult.sqlSelectResultsByID(team.TeamID, ref teamResults);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{ex.Message}: {ex.StackTrace}");
                    MessageBox.Show("An error retrieving data has occured. Exiting window.");
                    Close();
                }

                int homeWin = 0; int homeLose = 0;
                int awayWin = 0; int awayLose = 0;
                double pointsPerGame = 0;
                double opponentPointsPerGame = 0;
                double totalGames = team.TeamWins + team.TeamLoses;

                foreach (GameResult result in teamResults) {
                    if (result.gameID.Substring(0,3) == team.TeamID)
                    {
                        if (result.winner == 'A')
                        {
                            awayWin += 1;
                        }
                        else
                        {
                            awayLose += 1;
                        }

                        pointsPerGame += result.awayScore;
                        opponentPointsPerGame += result.homeScore;
                    }
                    else if (result.gameID.Substring(4,3) == team.TeamID)
                    {
                        if (result.winner == 'H')
                        {
                            homeWin += 1;
                        }
                        else
                        {
                            homeLose += 1;
                        }

                        pointsPerGame += result.homeScore;
                        opponentPointsPerGame += result.awayScore;
                    }
                };
                
                
                pointsPerGame = Math.Round(pointsPerGame / totalGames, 2);
                opponentPointsPerGame = Math.Round(opponentPointsPerGame / totalGames, 2);
                allStandings.Add(new teamStanding(team.TeamID, team.TeamWins, team.TeamLoses, homeWin, homeLose, awayWin, awayLose, pointsPerGame, opponentPointsPerGame));
                
            });

            allStandings.Sort();
            for (int i = 0; i < allStandings.Count; i++)
            {
                teamStanding team = allStandings[i];
                dgvStandings.Rows.Add(i+1, team.TeamID, team.TeamWins, team.TeamLoses, team.GetWinRate(), $"{team.HomeWin}-{team.HomeLose}", $"{team.AwayWin}-{team.AwayLose}", team.PointsPerGame, team.OpponentPointsPerGame, team.GetPointsDiff());
            }

            int gridHeight = dgvStandings.Rows.GetRowsHeight(DataGridViewElementStates.Displayed) + dgvStandings.ColumnHeadersHeight + 2;
            dgvStandings.Height = gridHeight;
        }
        private class teamStanding : IComparable<teamStanding>
        {
            private string teamID;
            private int teamWins;
            private int teamLoses;
            private int homeWin;
            private int homeLose;
            private int awayWin;
            private int awayLose;
            private double pointsPerGame;
            private double opponentPointsPerGame;

            public string TeamID { get => teamID; set => teamID = value; }
            public int TeamWins { get => teamWins; set => teamWins = value; }
            public int TeamLoses { get => teamLoses; set => teamLoses = value; }
            public int HomeWin { get => homeWin; set => homeWin = value; }
            public int HomeLose { get => homeLose; set => homeLose = value; }
            public int AwayWin { get => awayWin; set => awayWin = value; }
            public int AwayLose { get => awayLose; set => awayLose = value; }
            public double PointsPerGame { get => pointsPerGame; set => pointsPerGame = value; }
            public double OpponentPointsPerGame { get => opponentPointsPerGame; set => opponentPointsPerGame = value; }

            public teamStanding(string teamID, int teamWins, int teamLoses, int homeWin, int homeLose, int awayWin, int awayLose, double pointsPerGame, double opponentPointsPerGame)
            {
                this.TeamID = teamID;
                this.TeamWins = teamWins;
                this.TeamLoses = teamLoses;
                this.HomeWin = homeWin;
                this.HomeLose = homeLose;
                this.AwayWin = awayWin;
                this.AwayLose = awayLose;
                this.PointsPerGame = pointsPerGame;
                this.OpponentPointsPerGame = opponentPointsPerGame;
            }

            public double GetWinRate() => Math.Round((double)TeamWins / (TeamWins + TeamLoses), 2);
            public double GetPointsDiff() => Math.Round(PointsPerGame - OpponentPointsPerGame, 2);

            public int CompareTo(teamStanding other)
            {
                if (other.GetWinRate().CompareTo(this.GetWinRate()) != 0) 
                {
                    return other.GetWinRate().CompareTo(this.GetWinRate());
                }
                else if (other.GetPointsDiff().CompareTo(this.GetPointsDiff()) != 0)
                {
                    return other.GetPointsDiff().CompareTo(this.GetPointsDiff());
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
