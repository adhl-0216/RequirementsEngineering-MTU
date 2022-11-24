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
                "'71-72 Los Angeles Lakers",
                "'08-09 Cleveland Cavaliers",
                "'12-13 Oklahoma City Thunder"
            };

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
                    cboSelectTeam.SelectedIndex = -1;
                    cboSelectTeam.Items.Remove(cboSelectTeam.SelectedItem);
                }
            }else
            {
                MessageBox.Show("Please select a Team to be removed from the system.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            /*            else
                        {
                            MessageBox.Show(selectedTeam + " an error has occured.", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                        }
            */
        }

        private void cboSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeam = cboSelectTeam.Text;
        }
    }
}
