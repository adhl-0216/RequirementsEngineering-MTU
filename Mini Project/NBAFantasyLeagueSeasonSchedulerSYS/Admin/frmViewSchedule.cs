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
        public frmViewSchedule()
        {
            InitializeComponent();
        }        
        public frmViewSchedule(Form parent)
        {
            InitializeComponent();
            allTeams = new List<Team>();
            allGames = new List<Game>();
            Parent = parent;
        }

        private void frmViewSchedule_Load(object sender, EventArgs e)
        {
            //retrive data
            Team.retrieveTeams(ref allTeams);
            Game.retrieveGames(ref allGames);
            allCancelledGames = frmMainMenu.AllCancelledGames;

            //init GUI
            foreach (Game game in allGames)
            {
                dtgScheduledGames.Rows.Add(game.gameID, game.home.TeamID, game.away.TeamID, game.gameDate.ToString("yyyy/MM/dd"), game.gameTime, game.venue);
            }

            if (allCancelledGames != null) {
                foreach (CancelledGame cg in allCancelledGames)
                {
                    dtgCancelledGames.Rows.Add(cg.gameID, cg.home.TeamID, cg.away.TeamID, cg.gameDate.ToString("dd/MM/yyyy"), cg.gameTime, cg.venue, cg.Reason);
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
