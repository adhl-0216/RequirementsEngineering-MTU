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

            cboSelectTeam.Items.AddRange(teamNames);

            Teams_File teams = new Teams_File();
            teams.Rows.Add()
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
                }
            }else
            {
                MessageBox.Show("Please select a Team to be removed from the system.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            String teamDetails;
            String gm = "Jerry Krause";
            String hCoach = "Phil Jackson";
            String aCoach = "Jim Cleamons";
            int teamPts = 15;
            selectedTeam = cboSelectTeam.Text;
            teamDetails = String.Format("Name: {0} \nGM: {1} \nHead Coach: {2} \nAssistant Coach: {3} \nRecord: {4} - {5}", selectedTeam, gm, hCoach, aCoach, teamPts, 27 - teamPts);
        }
    }
}
