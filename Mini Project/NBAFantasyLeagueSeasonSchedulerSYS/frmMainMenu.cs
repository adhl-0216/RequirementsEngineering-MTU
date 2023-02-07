using NBAFantasyLeagueSeasonSchedulerSYS.Admin;
using NBAFantasyLeagueSeasonSchedulerSYS.Games;
using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
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
