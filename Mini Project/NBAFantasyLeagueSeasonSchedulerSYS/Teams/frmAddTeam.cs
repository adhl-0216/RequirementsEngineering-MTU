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

            TextBox[] txtBoxes = { txtTeamName, txtGM, txtHeadCoach, txtAsstCoach, txtHomeCourt };

            void errorMsg(String msg)
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (TextBox txtBox in txtBoxes)
            {
                if (txtBox.Text.Equals(""))
                {
                    errorMsg("Field can not be empty!");
                    txtBox.Focus();
                    break;
                }

                if (txtBox.Text.Contains("*[0-9]"))
                {
                    errorMsg("Field can not contain numbers!");
                    txtBox.Focus();
                    break;
                }

                valid = true;
            }

            /*            Console.WriteLine(teamName+GM+headCoach + asstCoach + homeCourt);
            */

            Strinf successMsg = "";
            if (valid) MessageBox.Show("Team Added Successfully!", "Success",MessageBoxButtons.OK);
        }

        private void txtTeamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHomeCourt_Click(object sender, EventArgs e)
        {

        }
    }
}
