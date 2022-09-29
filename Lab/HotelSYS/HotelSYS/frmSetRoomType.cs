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
    public partial class frmSetRoomType : Form
    {
        public frmSetRoomType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTypeCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Check for duplicate Type Code

            if (txtTypeCode.Text.Equals("SD"))
            {
                DialogResult dupeTC = MessageBox.Show("Room Type Code already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTypeCode.Focus();
                return;
            }

            //Check values
            if (txtTypeCode.Text.Equals("")) {
                DialogResult nullTC = MessageBox.Show("Type Code must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTypeCode.Focus();
                return;
            }
            if (Convert.ToDouble(txtRate.Text)<=0)
            {
                DialogResult nullRate = MessageBox.Show("Rate must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtRate.Focus();
                return;
            }

            //Display confirmation message
            DialogResult cfm = MessageBox.Show("Room Type has been created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtTypeCode.Clear();
            txtDesc.Clear();
            txtRate.Text = "0.00";
            txtTypeCode.Focus();

        }

        private void frmSetRoomType_Load(object sender, EventArgs e)
        {

        }
    }
}
