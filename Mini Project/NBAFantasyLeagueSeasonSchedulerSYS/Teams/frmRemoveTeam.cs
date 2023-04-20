using NBAFantasyLeagueSeasonSchedulerSYS.Games;
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
        private List<Team> allTeams;
        private List<Game> allGames;

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
            //disable buttons if combobox is empty
            if (cboSelectTeam.Items.Count < 1) btnRemoveTeam.Enabled = false;

            //check if schedule has been generated
            Game.sqlSelectAllGames(ref allGames);
            if (allGames.Count > 0)//schedule exists, close window
            {
                MessageBox.Show("Schedule has been generated, unable to remove any team(s).", "Unable To Remove Team", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            if (selectedTeam != null) { 
                //confirmation dialog
                DialogResult dialogResult = MessageBox.Show("Remove " + selectedTeam.TeamName + " from the system ?", "Remove Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( dialogResult == DialogResult.Yes){ //confirm

                    try { deleteTeam(selectedTeam); }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}: {ex.StackTrace}");
                        MessageBox.Show("An error retrieving data has occured. Exiting window.");
                        Close();
                    }
                    MessageBox.Show(selectedTeam.TeamName + " has been removed from the system.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset GUI
                    refreshComboBox();
                    cboSelectTeam.SelectedIndex = -1;
                    dtgTeamDetails.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select a Team to be removed from the system.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void cboSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display team details on datagridview on selection changed
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
            string sqlDelete = "DELETE FROM TEAMS WHERE TEAM_ID=:teamID";
            OracleCommand cmd = new OracleCommand(sqlDelete, conn);
            cmd.Parameters.Add(":teamID", team.TeamID);
            try
            {
                int affected = cmd.ExecuteNonQuery();
                Console.WriteLine(affected + " row(s) affected.");
            }catch (OracleException ex)
            {
                throw ex;
            }
        }

        private void refreshComboBox()
        {
            Team.sqlSelectTeam(ref allTeams);
            cboSelectTeam.Items.Clear();
            foreach (Team team in allTeams)
            {
                if (team.TeamName != null)
                {
                    cboSelectTeam.Items.Add($"[{team.TeamID}] {team.TeamName}");
                }
            }
        }
    }
}
