using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSYS
{
    public partial class frmAddRoom : Form
    {
        public frmAddRoom()
        {
            InitializeComponent();
        }

        private void frmAddRoom_Load(object sender, EventArgs e)
        {
            // Get Room Type from DB***

            cboRoomType.Items.Add("SD - Standard Double");
            cboRoomType.Items.Add("SS - Standard Single");
            cboRoomType.Items.Add("DD - Deluxe Double");
      
        }

        private void grpRoom_Enter(object sender, EventArgs e)
        {

        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validate data
            //check if RoomNo is numeric
            string RoomNoAsStr = txtRoomNo.Text;

            if (Regex.IsMatch(RoomNoAsStr, @"^\d+$"))
            {
                MessageBox.Show("RoomNo must be numeric", "Invalid Data Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomNo.Clear();
                txtRoomNo.Focus();
            }

            //set status

            //save data***

            //display confrimation
            MessageBox.Show("Room has been added","Information", MessageBoxButtons.OK ,MessageBoxIcon.Information );

            //reset UI
            cboRoomType.SelectedIndex = -1;
            txtRoomNo.Clear();
            txtRoomNo.Focus();

        }
    }
}
