using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace HotelSYS
{
    public partial class frmConnect : Form
    {
        OracleConnection conn;

        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                string connStr = File.ReadAllLines(@"C:\Users\T00229173\Desktop\connStr.txt")[0];
                conn = new OracleConnection(connStr);
            }
            if (conn.State == ConnectionState.Open) return;
            conn.Open();
            updateConnectionStatus();
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) return;
            conn.Close();
            updateConnectionStatus();
        }
        
        private void updateConnectionStatus()
        {
            lblConnStatus.Text = "Connection is " + conn.State.ToString().ToUpper();
        }
    }
}
