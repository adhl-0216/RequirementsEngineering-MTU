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
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.menuStrip1.Items.OfType<ToolStripMenuItem>().ToList().ForEach(x =>
            {
                x.MouseHover += (obj, arg) => ((ToolStripDropDownItem)obj).ShowDropDown();
            });
        }

        private void manageTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageTeams frmManageTeams = new frmManageTeams(this);   
            frmManageTeams.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin frmAdmin = new frmAdmin(this);
            frmAdmin.Show();
        }

        private void manageGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageGames frmManageGames = new frmManageGames(this);
            frmManageGames.Show();
        }


        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddTeam frmAddTeam = new frmAddTeam();
            frmAddTeam.Show();
        }
    }
}
