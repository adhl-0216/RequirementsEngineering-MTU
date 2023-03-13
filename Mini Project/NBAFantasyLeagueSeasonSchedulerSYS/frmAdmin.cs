using NBAFantasyLeagueSeasonSchedulerSYS.Admin;
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
    public partial class frmAdmin : Form
    {
        private static new Form Parent;
        public frmAdmin(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnTeamProfs_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenerateTeamProfile frmGenerateTeamProfile = new frmGenerateTeamProfile(this);
            frmGenerateTeamProfile.Show();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewSchedule frmViewSchedule = new frmViewSchedule(this);
            frmViewSchedule.Show();
        }

        private void btnTeamStandings_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewTeamStandings frmViewTeamStandings = new frmViewTeamStandings(this);
            frmViewTeamStandings.Show();
        }
    }
}
