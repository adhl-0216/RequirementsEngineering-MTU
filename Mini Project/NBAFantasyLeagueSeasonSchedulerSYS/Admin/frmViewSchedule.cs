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
    public partial class frmViewSchedule : Form
    {
        private static new Form Parent;
        private static List<Game> allGames;
        private static List<CancelledGame> allCancelledGames;
        private static List<Team> allTeams; 
      
        public frmViewSchedule(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmViewSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                //retrieve data
                Team.sqlSelectTeam(ref allTeams);
                Game.sqlSelectAllGames(ref allGames);
                CancelledGame.sqlSelectCancelledGames(ref allCancelledGames);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}: {ex.StackTrace}");
                MessageBox.Show("An error retrieving data has occured. Exiting window.");
                Close();
            }

            //initialise GUI
            foreach (Game game in allGames)
            {
                dtgScheduledGames.Rows.Add(game.gameDate.ToString("yyyy/MM/dd"), game.gameID, game.home.TeamID, game.away.TeamID, game.gameTime, game.venue);
            }

            if (allCancelledGames != null) {
                foreach (CancelledGame cg in allCancelledGames)
                {
                    dtgCancelledGames.Rows.Add(cg.gameDate.ToString("yyyy/MM/dd"), cg.gameID, cg.home.TeamID, cg.away.TeamID, cg.gameTime, cg.venue, cg.reason);
                }
            }
        }

        private void frmViewSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Parent != null)
            {
                Parent.Show();
            }
        }
    }
}
