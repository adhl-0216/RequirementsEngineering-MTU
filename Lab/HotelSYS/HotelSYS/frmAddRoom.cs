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
    public partial class frmAddRoom : Form
    {
        public frmAddRoom()
        {
            InitializeComponent();
        }

        private void frmAddRoom_Load(object sender, EventArgs e)
        {
            // Get Room Type from DB

            cboRoomType.Items.Add("SD - Standard Double");
            cboRoomType.Items.Add("SS - Standard Single");
            cboRoomType.Items.Add("DD - Deluxe Double");
      
        }

        private void grpRoom_Enter(object sender, EventArgs e)
        {

        }
    }
}
