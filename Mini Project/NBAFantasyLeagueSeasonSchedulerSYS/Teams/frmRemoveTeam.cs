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
    public partial class frmRemoveTeam : Form
    {
        private static new Form Parent;
        private String selectedTeam;
        private string[] teamNames = frmManageTeams.TeamNames;

        public frmRemoveTeam()
        {
            InitializeComponent();
        }
        public frmRemoveTeam(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmRemoveTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Parent != null)
                Parent.Show();
        }

        private void frmRemoveTeam_Load(object sender, EventArgs e)
        {
            cboSelectTeam.Items.AddRange(teamNames);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            if (selectedTeam != null) { 
                DialogResult dialogResult = MessageBox.Show("Remove " + selectedTeam + " from the system ?", "Remove Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( dialogResult == DialogResult.Yes){
                    MessageBox.Show(selectedTeam + " has been removed from the system.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboSelectTeam.Items.Remove(cboSelectTeam.SelectedItem);
                    cboSelectTeam.SelectedIndex = -1;
                    dtgTeamDetails.Rows.Clear();
                }
            }else
            {
                MessageBox.Show("Please select a Team to be removed from the system.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gm = "Jerry Krause";
            string hCoach = "Phil Jackson";
            string aCoach = "Jim Cleamons";
            selectedTeam = cboSelectTeam.Text;
            string[] teamDetails = { "CHI", selectedTeam, gm, hCoach, aCoach, "arena"};
            dtgTeamDetails.Rows.Add(teamDetails);
        }

        private void dataTeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
