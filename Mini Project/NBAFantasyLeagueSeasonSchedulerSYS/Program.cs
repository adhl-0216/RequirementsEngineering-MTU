using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            OracleConnection conn = new OracleConnection(File.ReadAllLines(@"C:\Users\T00229173\Source\Repos\mtu-adhl\RequirementsEngineering-MTU\.gitignore")[364]);
            conn.Open();
            MessageBox.Show(conn.State.ToString(), "Connection State");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainMenu());
        }
    }
}
