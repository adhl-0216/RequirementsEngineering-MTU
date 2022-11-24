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
    public partial class frmUpdateTeam : Form
    {
        private static new Form Parent;
        public frmUpdateTeam()
        {
            InitializeComponent();
        }

        public frmUpdateTeam(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmUpdateTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Parent != null)
                Parent.Show();
        }

        private void frmUpdateTeam_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {

        }

        private void cboTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
