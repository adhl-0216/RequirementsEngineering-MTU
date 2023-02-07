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
            refreshComboBox();
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            if (selectedTeam != null) { 
                DialogResult dialogResult = MessageBox.Show("Remove " + selectedTeam.TeamName + " from the system ?", "Remove Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( dialogResult == DialogResult.Yes){
                    deleteTeam(selectedTeam);
                    MessageBox.Show(selectedTeam.TeamName + " has been removed from the system.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshComboBox();

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

        private void deleteTeam(Team team)
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlDelete = $"DELETE FROM TEAMS WHERE TEAM_ID='{team.TeamID}'";
            OracleCommand cmd = new OracleCommand(sqlDelete, conn);

            try
            {
                int affected = cmd.ExecuteNonQuery();
                Console.WriteLine(affected + " row(s) affected.");
            }catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void refreshComboBox()
        {
            Team.retrieveTeams(ref allTeams);
            cboSelectTeam.Items.Clear();
            foreach (Team team in allTeams)
            {
                if (team.TeamName != null)
                {
                    cboSelectTeam.Items.Add(team.TeamName);
                }
            }
        }
    }
}
