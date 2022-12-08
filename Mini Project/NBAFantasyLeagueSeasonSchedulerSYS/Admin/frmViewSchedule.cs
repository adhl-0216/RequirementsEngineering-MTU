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
            Parent = parent;
        }

        private void frmViewSchedule_Load(object sender, EventArgs e)
        {
            //retrive data
            allGames = frmMainMenu.AllGames;
            allCancelledGames = frmMainMenu.AllCancelledGames;
            allTeams = frmMainMenu.AllTeams;
            foreach (Game game in allGames)
            {
                dtgScheduledGames.Rows.Add(game.GameID, game.HomeID, game.AwayID, game.Date.ToString("dd/MM/yyyy"), game.Time, game.Venue);
            }
            Game cg1 = new Game(allTeams[3], allTeams[4], new DateTime(2022, 2, 17), new TimeSpan(21,00,00), 2);
            string reason = "Venue unavailable.";
            dtgCancelledGames.Rows.Add(cg1.GameID, cg1.HomeID, cg1.AwayID, cg1.Date.ToString("dd/MM/yyyy"), cg1.Time, cg1.Venue, reason);
            if (allCancelledGames != null) {
                foreach (CancelledGame cg in allCancelledGames)
                {
                    dtgCancelledGames.Rows.Add(cg.GameID, cg.HomeID, cg.AwayID, cg.Date.ToString("dd/MM/yyyy"), cg.Time, cg.Venue, cg.Reason);
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
