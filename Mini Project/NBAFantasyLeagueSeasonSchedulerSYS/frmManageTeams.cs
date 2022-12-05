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

        public static string[] TeamNames { get => teamNames; set => teamNames = value; }

        private void frmManageTeams_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void frmManageTeams_Load(object sender, EventArgs e)
        {

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
