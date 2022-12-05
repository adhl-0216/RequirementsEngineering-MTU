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
    public partial class frmCancelGames : Form
    {
        private static new Form Parent;
        public frmCancelGames(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmCancelGames_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }
    }
}
