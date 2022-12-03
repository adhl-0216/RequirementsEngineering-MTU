using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Admin
{
    public partial class frmGenerateTeamProfile : Form
    {
        private static new Form Parent;
        public frmGenerateTeamProfile()
        {
            InitializeComponent();
        }
        public frmGenerateTeamProfile(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmGenerateTeamProfile_Load(object sender, EventArgs e)
        {
            String[] teamNames = {
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
        }

        private void frmGenerateTeamProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Parent != null)
            {
                Parent.Show();
            }
        }
    }
}
