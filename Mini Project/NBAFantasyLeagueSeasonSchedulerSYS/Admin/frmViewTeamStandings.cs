using NBAFantasyLeagueSeasonSchedulerSYS.Games;
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

namespace NBAFantasyLeagueSeasonSchedulerSYS.Admin
{
    public partial class frmViewTeamStandings : Form
    {
        private static new Form Parent;
        private static List<Team> allTeams;
        private static List<GameResult> allResults;
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
                double winRate = (double) team.TeamWins / (team.TeamWins + team.TeamLoses);
                winRate = Math.Round(winRate, 2);


                dgvStandings.Rows.Add(team.TeamID, team.TeamWins, team.TeamLoses, winRate);
            });

            
            
            
            
            int gridHeight = dgvStandings.Rows.GetRowsHeight(DataGridViewElementStates.Displayed) + dgvStandings.ColumnHeadersHeight + 2;
            dgvStandings.Height = gridHeight;
        }

    }
}
