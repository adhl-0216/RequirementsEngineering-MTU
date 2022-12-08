using NBAFantasyLeagueSeasonSchedulerSYS.Admin;
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

namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    public partial class frmMainMenu : Form
    {
        private static frmManageTeams frmManageTeams;
        private static frmManageGames frmManageGames;
        private static frmAdmin frmAdmin;
        private static List<Team> allTeams = new List<Team>(10);
        private static List<Game> allGames = new List<Game>();
        private static List<CancelledGame> allCancelledGames = new List<CancelledGame>();
        internal static List<Team> AllTeams { get => allTeams; set => allTeams = value; }
        internal static List<Game> AllGames { get => allGames; set => allGames = value; }
        internal static List<CancelledGame> AllCancelledGames { get => allCancelledGames; set => allCancelledGames = value; }

        public frmMainMenu()
        {
            InitializeComponent();
        }
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.mnuMainMenu.Items.OfType<ToolStripMenuItem>().ToList().ForEach(x =>
            {
                x.MouseHover += (obj, arg) => ((ToolStripDropDownItem)obj).ShowDropDown();
            });
            //dummy Team data

            Team t1 = new Team("'95-96 Chicago Bulls", "Jerry Krause", "Phil Jackson", "Jim Cleamons", "United Centre, 1901 W Madison St, Chicago, IL 60612, United States");

            Team t2 = new Team("'16-17 Golden State Warriors", "Bob Myers", "Steve Kerr", "Mike Brown", "Oracle Arena");

            Team t3 = new Team("'70-71 Milwaukee Bucks", "Ray Patterson", "Larry Costello", "Tom Nissalke", "Milwaukee Arena");

            Team t4 = new Team("'07-08 Boston Celtics", "Danny Ainge", "Doc Rivers", "Tom Thibodeau", "TD Banknorth Garden");

            Team t5 = new Team("'08-09 Cleveland Cavaliers", "Danny Ferry", "Mike Brown", "Michael Malone", "Quicken Loans Arena");

            Team t6 = new Team("'12-13 Oklahoma City Thunder", "Sam Presti", "Scott Brooks", "Maurice Cheeks", "Chesapeake Energy Arena");

            Team t7 = new Team("'88-89 Detroit Pistons", "Jack McCloskey", "Chuck Daly", "Brendan Malone", "The Palace of Auburn Hills");

            Team t8 = new Team("'86-87 Los Angeles Lakers", "Jerry West", "Pat Riley", "Bill Bertka", "The Forum");

            Team t9 = new Team("'82-83 Philadelphia 76ers", "Pat Williams", "Billy Cunningham", "Jack Mcmahon", "The Spectrum");

            Team t10 = new Team("'98-99 San Antonio Spurs", "Gregg Popovich", "Gregg Popovich", "Mike Budenholzer", "Alamodome");

            AllTeams.AddRange(new Team[]{ t1, t2, t3, t4, t5, t6, t7, t8, t9, t10});

            //temp Game data

            Game g1 = new Game(t1, t2, new DateTime(2022, 1, 1), new TimeSpan(20, 0 ,0), 1);
            Game g2 = new Game(t2, t1, new DateTime(2022, 1, 2), new TimeSpan(20, 0, 0), 2);
            Game g3 = new Game(t1, t2, new DateTime(2022, 1, 3), new TimeSpan(20, 0, 0), 3);
            Game g4 = new Game(t2, t3, new DateTime(2022, 1, 4), new TimeSpan(20, 0, 0), 1);
            Game g5 = new Game(t3, t2, new DateTime(2022, 1, 5), new TimeSpan(20, 0, 0), 2);
            Game g6 = new Game(t2, t3, new DateTime(2022, 1, 6), new TimeSpan(20, 0, 0), 3);

            AllGames = new List<Game> { g1, g2, g3, g4, g5, g6 };
        }

        //modules
        private void manageTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageTeams = new frmManageTeams(this);
            frmManageTeams.Show();
        }
        private void manageGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageGames = new frmManageGames(this);
            frmManageGames.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin = new frmAdmin(this);
            frmAdmin.Show();
        }


        // functional components
        // Teams
        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageTeams = new frmManageTeams(this);
            frmAddTeam frmAddTeam = new frmAddTeam(frmManageTeams);
            frmAddTeam.Show();
        }

        private void updateTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageTeams = new frmManageTeams(this);
            frmUpdateTeam frmUpdateTeam = new frmUpdateTeam(frmManageTeams);
            frmUpdateTeam.Show();
        }

        private void removeTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageTeams = new frmManageTeams(this);
            frmRemoveTeam frmRemoveTeam = new frmRemoveTeam(frmManageTeams);
            frmRemoveTeam.Show();
        }

        //Manage Games
        private void scheduleGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageGames frmManageGames = new frmManageGames(this);
            frmSchedule frmSchedule = new frmSchedule(frmManageGames);
            frmSchedule.Show();
        }

        private void rescheduleGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageGames frmManageGames = new frmManageGames(this);
            frmReschedule frmReschedule = new frmReschedule(frmManageGames);
            frmReschedule.Show();
        }

        private void cancelGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageGames frmManageGames = new frmManageGames(this);
            frmCancelGames frmCancelGames = new frmCancelGames(frmManageGames);
            frmCancelGames.Show();
        }

        private void logGameResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageGames frmManageGames = new frmManageGames(this);
            frmLogGameResults frmLogGameResults = new frmLogGameResults(frmManageGames);
            frmLogGameResults.Show();
        }

        //Admin
        private void generateTeamProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin = new frmAdmin(this);
            frmGenerateTeamProfile frmGenerateTeamProfile = new frmGenerateTeamProfile(frmAdmin);
            frmGenerateTeamProfile.Show();
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin = new frmAdmin(this);
            frmViewSchedule frmViewSchedule = new frmViewSchedule(frmAdmin);
            frmViewSchedule.Show();
        }
    }
}
