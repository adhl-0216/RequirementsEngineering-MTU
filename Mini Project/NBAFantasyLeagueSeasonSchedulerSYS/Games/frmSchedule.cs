using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    public partial class frmSchedule : Form
    {
        private static new Form Parent;
        public frmSchedule(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            dtgTeamDetails.Columns.Add("teamID", "ID");
            dtgTeamDetails.Columns.Add("teamName", "NAME");
            dtgTeamDetails.Columns.Add("gm", "MANAGER");
            dtgTeamDetails.Columns.Add("headCoach", "HEAD COACH");
            dtgTeamDetails.Columns.Add("asstCoach", "ASSISTANT COACH");
            dtgTeamDetails.Columns.Add("homeCourt", "HOME COURT");
            for (int i = 0; i < 10; i++)
            {
            }
        }
    }
}
