using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Teams
{
    public class Team
    {
        private String _teamID;
        private String _teamName;
        private String _gm;
        private String _headCoach;
        private String _asstCoach;
        private String _homeCourt;
        private int _teamWins;
        private int _teamLoses;

        public string teamID { 
            get => _teamID; 
            set
            {
                //ID assigning algorithm
                if (teamName.Length < 3)
                {
                    _teamID = teamName.PadRight(3, '_').ToUpper();
                    return;
                }

                if (value.Contains("Lakers"))
                {
                    _teamID = "LAK";
                    return;
                } 
                if (value.Contains("Oklahoma"))
                {
                    _teamID = "OKC";
                    return;
                }

                string[] teamNameArr = value.Split(' ');
                if (teamNameArr.Length == 4)
                {
                    for (int i = 1; i < teamNameArr.Length; i++)
                    {
                        _teamID += teamNameArr[i].Substring(0, 1).ToUpper();
                    }
                    return;
                }
                else if (teamNameArr.Length == 3)
                {
                    _teamID = teamNameArr[1].Substring(0, 3).ToUpper();
                    return;
                }
                else
                {
                    _teamID = value.Substring(0, 3).ToUpper();
                    return;
                }
            } 
        }
        public string teamName { get => _teamName; set => _teamName = value; }
        public string gm { get => _gm; set => _gm = value; }
        public string headCoach { get => _headCoach; set => _headCoach = value; }
        public string asstCoach { get => _asstCoach; set => _asstCoach = value; }
        public string homeCourt { get => _homeCourt; set => _homeCourt = value; }
        public int teamWins { get => _teamWins; set => _teamWins = value; }
        public int teamLoses { get => _teamLoses; set => _teamLoses = value; }

        public Team(string teamName, string gm, string headCoach, string asstCoach, string homeCourt)
        {
            this.teamName = teamName;
            teamID = teamName;
            this.gm = gm;
            this.headCoach = headCoach;
            this.asstCoach = asstCoach;
            this.homeCourt = homeCourt;
            teamWins = 0;
            teamLoses = 0;
        }

        public void sqlInsertTeam() 
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlInsert = "INSERT INTO TEAMS VALUES(:teamID, :teamName, :gm, :headCoach, :asstCoach, :homeCourt, :teamWins, :teamLoses)";
            OracleCommand cmd = new OracleCommand(sqlInsert, conn);
            cmd.Parameters.Add(":teamID", teamID);
            cmd.Parameters.Add(":teamName", teamName);
            cmd.Parameters.Add(":gm", gm);
            cmd.Parameters.Add(":headCoach", headCoach);
            cmd.Parameters.Add(":asstCoach", asstCoach);
            cmd.Parameters.Add(":homeCourt", homeCourt);
            cmd.Parameters.Add(":teamWins", teamWins);
            cmd.Parameters.Add(":teamLoses", teamLoses);
            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                Console.WriteLine(affectedRows + " row(s) inserted.");
            }
            catch (OracleException ex)
            {
                throw (ex);
            }
        }

        public static void sqlSelectTeam(ref List<Team> allTeams)
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlSelect = "SELECT * FROM TEAMS";
            OracleCommand cmd = new OracleCommand(sqlSelect, conn);

            try
            {
                OracleDataReader dataReader = cmd.ExecuteReader();
                allTeams = new List<Team>();
                while (dataReader.Read())
                {
                    string teamID = dataReader.GetString(0);
                    string teamName = dataReader.GetString(1);
                    string gM = dataReader.GetString(2);
                    string headCoach = dataReader.GetString(3);
                    string asstCoach = dataReader.GetString(4);
                    string homeCourt = dataReader.GetString(5);
                    int teamWins = dataReader.GetInt32(6);
                    int teamLoses = dataReader.GetInt32(7);

                    Team team = new Team(teamName, gM, headCoach, asstCoach, homeCourt);
                    team.teamID = teamID;
                    team.teamWins = teamWins;
                    team.teamLoses = teamLoses;
                    allTeams.Add(team);
                }
            }
            catch (OracleException ex)
            {
                throw ex;
            }
        }

        public void sqlUpdateTeam()
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlUpdate = "UPDATE TEAMS SET TEAM_NAME=:teamName, GENERAL_MANAGER=:gm, HEAD_COACH=:headCoach, ASSISTANT_COACH=:asstCoach, HOME_COURT=:homeCourt, TEAM_WINS=:teamWins, TEAM_LOSES=:teamLoses WHERE TEAM_ID=:teamID";
            OracleCommand cmd = new OracleCommand(sqlUpdate, conn);
            cmd.Parameters.Add(":teamName", teamName);
            cmd.Parameters.Add(":gm", gm);
            cmd.Parameters.Add(":headCoach", headCoach);
            cmd.Parameters.Add(":asstCoach", asstCoach);
            cmd.Parameters.Add(":homeCourt", homeCourt);
            cmd.Parameters.Add(":teamWins", teamWins);
            cmd.Parameters.Add(":teamLoses", teamLoses);
            cmd.Parameters.Add(":teamID", teamID);
            try
            {
                int affected = cmd.ExecuteNonQuery();
                Console.WriteLine(affected + " row(s) updated.");
            }
            catch (OracleException ex)
            {
                throw ex;
            }
        }
    }
}
