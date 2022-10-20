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
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void manageTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTeams frmManageTeams = new frmManageTeams();   
            frmManageTeams.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.ShowDialog();
        }

        private void manageGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageGames frmManageGames = new frmManageGames();
            frmManageGames.ShowDialog();
        }
    }
}
