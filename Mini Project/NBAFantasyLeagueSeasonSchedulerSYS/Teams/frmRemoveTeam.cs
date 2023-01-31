using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using Oracle.ManagedDataAccess.Client;
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
        private Team selectedTeam;
        private static List<Team> allTeams;

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
            foreach (Team team in allTeams)
            {
                if (team.TeamName != null)
                {
                    cboSelectTeam.Items.Add(team.TeamName);
                }
            }
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            if (selectedTeam != null) { 
                DialogResult dialogResult = MessageBox.Show("Remove " + selectedTeam.TeamName + " from the system ?", "Remove Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( dialogResult == DialogResult.Yes){
                    MessageBox.Show(selectedTeam.TeamName + " has been removed from the system.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboSelectTeam.Items.Remove(cboSelectTeam.SelectedItem);
                    allTeams.Remove(selectedTeam);
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
            if (cboSelectTeam.SelectedIndex != -1) {
                selectedTeam = allTeams[cboSelectTeam.SelectedIndex];
                string[] teamDetails = { selectedTeam.TeamID, selectedTeam.TeamName, selectedTeam.Gm, selectedTeam.HeadCoach, selectedTeam.AsstCoach, selectedTeam.HomeCourt};
                dtgTeamDetails.Rows.Clear();
                dtgTeamDetails.Rows.Add(teamDetails);
            }
        }

        private void retrieveTeams()
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlSelect = "SELECT * FROM TEAMS";
            OracleCommand cmd = new OracleCommand(sqlSelect, conn);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                object[] teamDetails = { };
                int numRows = reader.GetValues(teamDetails);
                Console.WriteLine(teamDetails.ToString());
            }
        }

    }
}
