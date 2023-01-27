using NBAFantasyLeagueSeasonSchedulerSYS.Games;
using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Admin
{
    public partial class frmGenerateTeamProfile : Form
    {
        private static new Form Parent;
        private static List<Team> allTeams;
        private static List<Game> allGames;
        public frmGenerateTeamProfile()
        {
            InitializeComponent();
        }
        public frmGenerateTeamProfile(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmGenerateTeamProfile_Load(object sender, EventArgs e)
        {
            allTeams = frmMainMenu.AllTeams;
            allGames = frmMainMenu.AllGames;
            foreach (Team team in allTeams)
            {
                cboTeams.Items.Add(team.TeamName);
            }
        }

        private void frmGenerateTeamProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Parent != null)
            {
                Parent.Show();
            }
        }

        private void cboTeams_SelectedValueChanged(object sender, EventArgs e)
        {
            //display Team details
            Team selectedTeam = allTeams[cboTeams.SelectedIndex];
            txtTeamID.Text = selectedTeam.TeamID;
            txtTeamName.Text = selectedTeam.TeamName;
            txtGM.Text = selectedTeam.Gm;
            txtHeadCoach.Text = selectedTeam.HeadCoach;
            txtAsstCoach.Text = selectedTeam.AsstCoach;
            txtHomeCourt.Text = selectedTeam.HomeCourt;
            selectedTeam.TeamWins = new int[]{ ((int)new Random().Next(0,27)), 27 };

            //display Game Details
            dtgGames.Rows.Clear();
            foreach (Game game in allGames)
            {
                if (game.homeID == selectedTeam.TeamID || game.awayID == selectedTeam.TeamID)
                {
                    var idx = dtgGames.Rows.Add();
                    dtgGames.Rows[idx].Cells["gameID"].Value = game.gameID;
                    string opponent = "";
                    if (game.homeID == selectedTeam.TeamID)
                    {
                        opponent = allTeams.Find(x => x.TeamID == game.awayID).TeamName;
                    }
                    else if (game.awayID == selectedTeam.TeamID)
                    {
                        opponent = allTeams.Find(x => x.TeamID == game.homeID).TeamName;
                    }
                    dtgGames.Rows[idx].Cells["opponent"].Value = opponent;
                    dtgGames.Rows[idx].Cells["date"].Value = game.gameDate.ToString("dd/MM/yyyy");
                    dtgGames.Rows[idx].Cells["time"].Value = game.gameTime.ToString("h':'mm");
                    dtgGames.Rows[idx].Cells["venue"].Value = game.venue;
                    dtgGames.Rows[idx].Cells["result"].Value = (new Random().Next(0,2)==1)?"W":"L";
                }
            }
            int wins = 0, total;
            foreach (DataGridViewRow row in dtgGames.Rows)
            {
                if (row.Cells["result"].Value.ToString().Equals("W"))
                {
                    wins++;
                }
            }
            total = dtgGames.RowCount;
            lblTeamWins.Text = string.Format("({0}-{1})", wins, total);
        }
    }
}
