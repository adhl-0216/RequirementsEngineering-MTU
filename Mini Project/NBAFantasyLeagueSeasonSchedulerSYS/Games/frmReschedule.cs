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
    public partial class frmReschedule : Form
    {
        private static new Form Parent;
        public frmReschedule(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmReschedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }
    }
}
