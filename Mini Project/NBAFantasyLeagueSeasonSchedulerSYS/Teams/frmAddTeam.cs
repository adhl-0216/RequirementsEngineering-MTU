using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    public partial class frmAddTeam : Form
    {
        private static new Form Parent;
        private static List<Team> allTeams;
        public frmAddTeam(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmAddTeam_Load(object sender, EventArgs e)
        {
            checkTeamFull();
        }

        private void frmAddTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Parent!=null)
                Parent.Show();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            /*            
            input validation
            •    All fields must be entered.
            •    General Manger must NOT contain numbers.
            •    Head Coach must NOT contain numbers.
            •    Assistant Coach must NOT contain numbers.
            */

            Boolean valid = false;
            Label[] lbls = {lblTeamName, lblGM, lblHeadCoach, lblAsstCoach, lblHomeCourt};
            TextBox[] txtBoxes = {txtTeamName, txtGM, txtHeadCoach, txtAsstCoach, txtHomeCourt};

            void errorMsg(String msg)
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            while (!valid)
            {
                foreach (TextBox txtBox in txtBoxes)
                {
                    if (txtBox.Text.Equals(""))
                    {
                        errorMsg("Field can not be empty!");
                        txtBox.Focus();
                        return;
                    }
                    else if (txtBox == txtGM || txtBox == txtHeadCoach || txtBox == txtAsstCoach)
                    {
                        if (txtBox.Text.Any(char.IsDigit))
                        {
                            errorMsg("Field can not contain numbers!");
                            txtBox.Clear();
                            txtBox.Focus();
                            return;
                        }
                    }
                }

                valid = true;
            }

            if (valid) {
                Team newTeam = new Team(txtTeamName.Text, txtGM.Text, txtHeadCoach.Text, txtAsstCoach.Text, txtHomeCourt.Text);
                if (allTeams.Any(team => team.TeamID.Equals(newTeam.TeamID))) 
                {
                    MessageBox.Show("Team Name is invalid.", "Invalid Team Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTeamName.Clear();
                    txtTeamName.Focus();
                    return;
                }
                try
                {
                    newTeam.sqlInsertTeam();
                }catch (OracleException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                string successMsg = "Team Added Successfully! \n\n";
                for (int i = 0; i < txtBoxes.Length; i++)
                {
                    successMsg += lbls[i].Text + ": " + txtBoxes[i].Text + "\n";
                    //reset GUI

                    txtBoxes[i].Clear();
                }
                MessageBox.Show(successMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkTeamFull();
            }
        }

        private void checkTeamFull()
        {
            Team.sqlSelectTeam(ref allTeams);
            string msg = "Only a maximum of 10 Teams are allowed!\nTo amend Team Details, go to [Manage Teams] > [Update Team].\nTo remove a team, go to [Manage Teams] > [Remove Team].";
            if (allTeams.Count == 10)
            {
                MessageBox.Show(msg, "Team List Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }
    }
}