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

        public string TeamID { 
            get => _teamID; 
            set
            {

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
                        _teamID += teamNameArr[i].Substring(0, 1);
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
        public string TeamName { get => _teamName; set => _teamName = value; }
        public string Gm { get => _gm; set => _gm = value; }
        public string HeadCoach { get => _headCoach; set => _headCoach = value; }
        public string AsstCoach { get => _asstCoach; set => _asstCoach = value; }
        public string HomeCourt { get => _homeCourt; set => _homeCourt = value; }
        public int TeamWins { get => _teamWins; set => _teamWins = value; }
        public int TeamLoses { get => _teamLoses; set => _teamLoses = value; }

        public Team(string teamName, string gm, string headCoach, string asstCoach, string homeCourt)
        {
            TeamName = teamName;
            TeamID = teamName;
            Gm = gm;
            HeadCoach = headCoach;
            AsstCoach = asstCoach;
            HomeCourt = homeCourt;
            TeamWins = 0;
            TeamLoses = 0;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void sqlInsertTeam() 
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlInsert = $"INSERT INTO TEAMS VALUES(:p0, :p1, :p2, :p3, :p4, :p5, :p6, :p7)";
            OracleCommand cmd = new OracleCommand(sqlInsert, conn);
            cmd.Parameters.AddRange(new Object[] { TeamID, TeamName.Replace("'", "''"), Gm, HeadCoach, AsstCoach, HomeCourt, TeamWins, TeamLoses});
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
                allTeams = new List<Team>(10);
                while (dataReader.Read())
                {
                    string teamName = dataReader.GetString(1);
                    string gM = dataReader.GetString(2);
                    string headCoach = dataReader.GetString(3);
                    string asstCoach = dataReader.GetString(4);
                    string homeCourt = dataReader.GetString(5);
                    int teamWins = dataReader.GetInt32(6);
                    int teamLoses = dataReader.GetInt32(7);

                    Team team = new Team(teamName, gM, headCoach, asstCoach, homeCourt);
                    team.TeamWins = teamWins;
                    team.TeamLoses = teamLoses;
                    allTeams.Add(team);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void sqlUpdateTeam()
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlUpdate = $"UPDATE TEAMS SET TEAM_NAME=:p0, GENERAL_MANAGER=:p1, HEAD_COACH=:p2, ASSISTANT_COACH=:p3, HOME_COURT=:p4, TEAM_WINS=:p5, TEAM_LOSES=:p6 WHERE TEAM_ID=:p7";
            OracleCommand cmd = new OracleCommand(sqlUpdate, conn);
            cmd.Parameters.AddRange(new Object[] { TeamName.Replace("'", "''"), Gm, HeadCoach, AsstCoach, HomeCourt, TeamWins, TeamLoses, TeamID});

            try
            {
                int affected = cmd.ExecuteNonQuery();
                Console.WriteLine(affected + " row(s) updated.");
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
