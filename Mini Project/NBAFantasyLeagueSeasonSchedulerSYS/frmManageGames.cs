using NBAFantasyLeagueSeasonSchedulerSYS.Games;
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
    public partial class frmManageGames : Form
    {
        private static new Form Parent;
        public frmManageGames(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmManageGames_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void btnScheduleGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSchedule frmSchedule = new frmSchedule(this);
            frmSchedule.Show();
        }

        private void btnRescheduleGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReschedule frmReschedule = new frmReschedule(this);
            frmReschedule.Show();
        }

        private void btnCancelGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelGames frmCancelGames = new frmCancelGames(this);
            frmCancelGames.Show();
        }

        private void btnLogGameRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogGameResults frmLogGameResults = new frmLogGameResults(this);
            frmLogGameResults.Show();
        }
    }
}
