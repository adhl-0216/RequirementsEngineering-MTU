using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Teams
{
    class Team
    {
        private String _teamID;
        private String _teamName;
        private String _gm;
        private String _headCoach;
        private String _asstCoach;
        private String _homeCourt;
        private int[] _teamWins;

        public string TeamID { 
            get => _teamID; 
            set
            {
                string[] teamNameArr = value.Split(' ');
                if (teamNameArr.Length == 4)
                {
                    for (int i = 1; i < teamNameArr.Length; i++)
                    {
                        _teamID += teamNameArr[i].Substring(0, 1);
                    }
                }
                else if (teamNameArr.Length == 3)
                {
                    _teamID = teamNameArr[1].Substring(0, 3).ToUpper();
                }
                else
                {
                    _teamID = value.Substring(0, 3).ToUpper();
                }
            } 
        }
        public string TeamName { get => _teamName; set => _teamName = value; }
        public string Gm { get => _gm; set => _gm = value; }
        public string HeadCoach { get => _headCoach; set => _headCoach = value; }
        public string AsstCoach { get => _asstCoach; set => _asstCoach = value; }
        public string HomeCourt { get => _homeCourt; set => _homeCourt = value; }
        public int[] TeamWins { get => _teamWins; set => _teamWins = value; }

        public Team(string teamName, string gm, string headCoach, string asstCoach, string homeCourt)
        {
            TeamName = teamName;
            TeamID = teamName;
            Gm = gm;
            HeadCoach = headCoach;
            AsstCoach = asstCoach;
            HomeCourt = homeCourt;
            TeamWins = new int[]{0, 0};
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void addTeam()
        {
            OracleConnection conn = Program.getOracleConnection();
            String sqlInsert = $"INSERT INTO TEAMS VALUES('{TeamID}','{TeamName.Replace("'","''")}','{Gm}','{HeadCoach}','{AsstCoach}','{HomeCourt}',{TeamWins[0]})";
            OracleCommand cmd = new OracleCommand(sqlInsert, conn);
            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                Console.WriteLine(affectedRows + " row(s) are affected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
        }
    }
}
