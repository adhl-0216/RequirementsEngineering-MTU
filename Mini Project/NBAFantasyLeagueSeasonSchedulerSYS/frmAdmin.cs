﻿using System;
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
    public partial class frmAdmin : Form
    {
        private static new Form Parent;
        public frmAdmin(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }
    }
}
