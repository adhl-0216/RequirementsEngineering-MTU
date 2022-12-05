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
    public partial class frmAddTeam : Form
    {
        private static new Form Parent;
        public frmAddTeam(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        public frmAddTeam()
        {
            InitializeComponent();
        }

        private void frmAddTeam_Load(object sender, EventArgs e)
        {

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
            •    All fields must be unique.
            */

            Boolean valid = false;
            String successMsg = "Team Added Successfully! \n\n";
            Label[] lbls = {lblTeamName, lblGM, lblHeadCoach, lblAsstCoach, lblHomeCourt };
            TextBox[] txtBoxes = { txtTeamName, txtGM, txtHeadCoach, txtAsstCoach, txtHomeCourt };

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
                string teamID = "";
                string[] teamNameArr = txtTeamName.Text.Split(' ');
                if (teamNameArr.Length == 4)
                {
                    for (int i = 1; i < teamNameArr.Length; i++)
                    {
                        teamID += teamNameArr[i].Substring(0, 1);
                    }
                }else if (teamNameArr.Length == 3)
                {
                    teamID = teamNameArr[1].Substring(0, 3).ToUpper();
                }else
                {
                    teamID = txtTeamName.Text.Substring(0,3).ToUpper();
                }
                successMsg += "TEAM_ID: " + teamID + "\n";
                for (int i = 0; i < txtBoxes.Length; i++)
                {
                    successMsg += lbls[i].Text + ": "+ txtBoxes[i].Text + "\n";
                    txtBoxes[i].Clear();
                }
                MessageBox.Show(successMsg, "Success", MessageBoxButtons.OK,MessageBoxIcon.Information); 
            }
        }

        private void txtTeamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHomeCourt_Click(object sender, EventArgs e)
        {

        }
    }
}
