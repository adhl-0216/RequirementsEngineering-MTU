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
    public partial class frmAddTeam : Form
    {
        private static new Form Parent;
        public frmAddTeam(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        public frmAddTeam()
        {
            InitializeComponent();
        }

        private void frmAddTeam_Load(object sender, EventArgs e)
        {

        }

        private void frmAddTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }
    }
}
