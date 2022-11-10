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

        private void frmManageTeams_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void frmManageTeams_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {

        }
    }
}
