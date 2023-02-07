using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    public class Game
    {
        private string _gameID;
        private DateTime _gameDate;
        private TimeSpan _gameTime;
        private string _venue;
        private Team _home;
        private Team _away;

        public string gameID { get => _gameID; set => _gameID = value; }
        public DateTime gameDate { get => _gameDate.Date ; set => _gameDate = value.Date; }
        public TimeSpan gameTime { get => _gameTime; set => _gameTime = value; }
        public string venue { get => _venue; set => _venue = value; }
        internal Team home { get => _home; set => _home = value; }
        internal Team away { get => _away; set => _away = value; }

        public Game(string GameID, DateTime GameDate)
        {
            List<Team> allTeams = new List<Team>(10);
            Team.retrieveTeams(ref allTeams);
            
            gameID = GameID;
            home = allTeams.Find(team => team.TeamID == GameID.Substring(4,3));
            away = allTeams.Find(team => team.TeamID == GameID.Substring(0,3));
            gameDate = GameDate;
            gameTime = new TimeSpan(20,0,0);
            venue = home.HomeCourt;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void saveGame()
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlInsert = $"INSERT INTO GAMES VALUES ('{gameID}','{home.TeamID}','{away.TeamID}',{gameDate},{gameTime},'{venue}')";
            OracleCommand cmd = new OracleCommand(sqlInsert, conn);

            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} row(s) are inserted.");
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        public static void retrieveGames(ref List<Game> allGames)
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlSelectGames = "SELECT * FROM GAMES";
            OracleCommand cmd = new OracleCommand(sqlSelectGames, conn);

            try
            {
                OracleDataReader dataReader = cmd.ExecuteReader();
                allGames = new List<Game>(10);
                while (dataReader.Read())
                {
                    string gameID = dataReader.GetString(0);
                    //string homeID = dataReader.GetString(1);
                    //string awayID = dataReader.GetString(2);
                    DateTime gameDate = dataReader.GetDateTime(3);

                    //allGames.Add(new Game(gameID, homeID, awayID, gameDate, gameTime));
                    allGames.Add(new Game(gameID, gameDate));
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
