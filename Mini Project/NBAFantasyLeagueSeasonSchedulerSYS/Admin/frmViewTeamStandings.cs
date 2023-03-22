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
            allTeams.ForEach(team => {
                List<GameResult> teamResults = new List<GameResult>();
                GameResult.sqlSelectResultsByID(team.TeamID, ref teamResults);
                double winRate;
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
                
                winRate = Math.Round(team.TeamWins / totalGames, 2);
                pointsPerGame = Math.Round(pointsPerGame / totalGames, 2);
                opponentPointsPerGame = Math.Round(opponentPointsPerGame / totalGames, 2);
                dgvStandings.Rows.Add(0,team.TeamID, team.TeamWins, team.TeamLoses, winRate, $"{homeWin}-{homeLose}", $"{awayWin}-{awayLose}", pointsPerGame, opponentPointsPerGame);
                
            });
            dgvStandings.Sort(colPCT, System.ComponentModel.ListSortDirection.Descending);
            for (int i = 0; i < dgvStandings.RowCount; i++)
            {
                dgvStandings.Rows[i].Cells[0].Value = i+1;
            }

            int gridHeight = dgvStandings.Rows.GetRowsHeight(DataGridViewElementStates.Displayed) + dgvStandings.ColumnHeadersHeight + 2;
            dgvStandings.Height = gridHeight;
        }

    }
}
