using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
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
    public partial class frmUpdateTeam : Form
    {
        private static new Form Parent;
        private List<Team> allTeams = frmManageTeams.AllTeams;
        private Team selectedTeam;

        public frmUpdateTeam(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmUpdateTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Parent != null)
                Parent.Show();
        }

        private void frmUpdateTeam_Load(object sender, EventArgs e)
        {
            foreach (Team team in allTeams)
            {
                if (team.TeamName != null)
                {
                    cboTeamName.Items.Add(team.TeamName);
                }
            }
        }


        private void cboTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTeamName.SelectedIndex != -1){
                selectedTeam = allTeams[cboTeamName.SelectedIndex];

                txtNewName.Enabled = true;

                txtGM.Text = selectedTeam.Gm;
                txtGM.Enabled = true;

                txtHeadCoach.Text = selectedTeam.HeadCoach;
                txtHeadCoach.Enabled = true;

                txtAsstCoach.Text = selectedTeam.AsstCoach;
                txtAsstCoach.Enabled = true;

                txtHomeCourt.Text = selectedTeam.HomeCourt;
                txtHomeCourt.Enabled = true;
            }
        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
/*            
       input validation
•    All fields must be entered.
•    General Manger must NOT contain numbers.
•    Head Coach must NOT contain numbers.
•    Assistant Coach must NOT contain numbers.
•    All fields must be unique.
*/

            Boolean valid = false;
            Label[] lbls = { lblNewName, lblGM, lblHeadCoach, lblAsstCoach, lblHomeCourt };
            TextBox[] txtBoxes = { txtNewName, txtGM, txtHeadCoach, txtAsstCoach, txtHomeCourt };

            void errorMsg(String msg)
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            while (!valid)
            {
                foreach (TextBox txtBox in txtBoxes)
                {
                    if (txtBox == txtNewName)
                    {
                        continue;
                    }
                    else if (txtBox.Text.Equals(""))
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

            if (valid)
            {
                String successMsg;
                selectedTeam.TeamName = txtNewName.Text;
                selectedTeam.Gm = txtGM.Text;
                selectedTeam.HeadCoach = txtHeadCoach.Text;
                selectedTeam.AsstCoach = txtAsstCoach.Text;
                selectedTeam.HomeCourt = txtHomeCourt.Text;

                successMsg = "Team Updated Successfully! \n\n";
                for (int i = 0; i < txtBoxes.Length; i++)
                {
                    if (txtBoxes[i].Text != "") {
                        successMsg += lbls[i].Text + ": " + txtBoxes[i].Text + "\n";
                    }
                    else { 
                        successMsg += lbls[i].Text + ": " + cboTeamName.Text + "\n";
                    }
                    txtBoxes[i].Clear();
                    txtBoxes[i].Enabled = false;
                }
                MessageBox.Show(successMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTeamName.SelectedIndex = -1;
            }
        }
    }
}
