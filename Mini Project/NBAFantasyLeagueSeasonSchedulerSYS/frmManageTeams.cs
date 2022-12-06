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
    public partial class frmManageTeams : Form
    {
        private static new Form Parent;
        public frmManageTeams(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddTeam frmAddTeam = new frmAddTeam(this);
            frmAddTeam.Show();
        }

        private static string[] teamNames = {
                "'95-96 Chicago Bulls",
                "'16-17 Golden State Warriors",
                "'70-71 Milwaukee Bucks",
                "'07-08 Boston Celtics",
                "'08-09 Cleveland Cavaliers",
                "'12-13 Oklahoma City Thunder",
                "'88-89 Detroit Pistons",
                "'86-87 Los Angeles Lakers",
                "'82-83 Philadelphia 76ers",
                "'98-99 San Antonio Spurs"
        };

        private void frmManageTeams_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private static List<Team> allTeams;

        internal static List<Team> AllTeams { get => allTeams; set => allTeams = value; }

        private void frmManageTeams_Load(object sender, EventArgs e)
        {
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
            
            AllTeams = new List<Team> { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10 }; 
        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateTeam frmUpdateTeam = new frmUpdateTeam(this);
            frmUpdateTeam.Show();
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveTeam frmRemoveTeam = new frmRemoveTeam(this);
            frmRemoveTeam.Show();
        }
    }
}
