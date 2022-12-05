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
        private static String[] teamNames = frmManageTeams.TeamNames;

        public frmUpdateTeam()
        {
            InitializeComponent();
        }

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
            cboTeamName.Items.AddRange(teamNames);
        }



        private void cboTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTeamName.SelectedIndex != -1){
                txtNewName.Enabled = true;
                txtGM.Text = "someone";
                txtGM.Enabled = true;
                txtHeadCoach.Text = "someone";
                txtHeadCoach.Enabled = true;
                txtAsstCoach.Text = "someone";
                txtAsstCoach.Enabled = true;
                txtHomeCourt.Text = "some arena";
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
            String successMsg = "Team Updated Successfully! \n\n";
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
                cboTeamName.SelectedIndex = -1;
                MessageBox.Show(successMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
