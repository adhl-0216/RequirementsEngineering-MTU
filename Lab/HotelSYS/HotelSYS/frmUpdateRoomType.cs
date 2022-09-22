using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSYS
{
    public partial class frmUpdateRoomType : Form
    {
        public frmUpdateRoomType()
        {
            InitializeComponent();
        }

        private void frmUpdateRoomType_Load(object sender, EventArgs e)
        {
            // retrieve room types
            cboRoomTypes.Items.Add("SD - Standard Double");
            cboRoomTypes.Items.Add("SS - Standard Single");
            cboRoomTypes.Items.Add("DD - Deluxe Double");
        }

        private void cboRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboRoomTypes.SelectedIndex == -1) return;

            //get room type details and load on UI
            grpRoomType.Visible = true;

            txtDesc.Text = "Standard Double";
            txtRate.Text = "80.00";

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //validate data

            //Update data in DB
            //NOT DOING THIS NOW

            //Display confirmation message

            if (txtDesc.Text.Equals(""))
            {
                DialogResult nullTC = MessageBox.Show("Description must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDesc.Focus();
                return;
            }

            if (Convert.ToDouble(txtRate.Text) <= 0)
            {
                DialogResult nullRate = MessageBox.Show("Rate must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtRate.Focus();
                return;
            }

            DialogResult cfm = MessageBox.Show("Room Type has been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            grpRoomType.Visible = false;
            cboRoomTypes.SelectedIndex = -1;
        }
    }
}
