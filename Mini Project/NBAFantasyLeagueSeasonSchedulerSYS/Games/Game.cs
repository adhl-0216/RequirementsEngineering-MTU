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
        private char _recorded;

        public string gameID { get => _gameID; set => _gameID = value; }
        public DateTime gameDate { get => _gameDate.Date ; set => _gameDate = value.Date; }
        public TimeSpan gameTime { get => _gameTime; set => _gameTime = value; }
        public string venue { get => _venue; set => _venue = value; }
        internal Team home { get => _home; set => _home = value; }
        internal Team away { get => _away; set => _away = value; }
        public char recorded { get => _recorded; set => _recorded = value; }

        public Game(string GameID, DateTime GameDate)
        {
            List<Team> allTeams = new List<Team>(10);
            Team.sqlSelectTeam(ref allTeams);
            
            gameID = GameID;
            home = allTeams.Find(team => team.TeamID == GameID.Substring(4,3));
            away = allTeams.Find(team => team.TeamID == GameID.Substring(0,3));
            gameDate = GameDate.Date;
            gameTime = new TimeSpan(20, 0, 0);
            venue = home.HomeCourt;
            recorded = 'N';
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        
        public static void sqlSelectGame(ref List<Game> allGames)
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
                    DateTime gameDateTime = dataReader.GetDateTime(3);
                    char recorded = dataReader.GetString(5)[0];

                    Game game = new Game(gameID, gameDateTime);
                    game.gameTime = gameDateTime.TimeOfDay;
                    game.recorded = recorded;

                    allGames.Add(game);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void sqlInsertGame()
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlInsert = $"INSERT INTO GAMES VALUES ('{gameID}','{home.TeamID}','{away.TeamID}',TIMESTAMP'{gameDate.ToString("yyyy-MM-dd")} {gameTime}','{venue}','{recorded}')";
            OracleCommand cmd = new OracleCommand(sqlInsert, conn);

            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} row(s) inserted.");
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        public void sqlUpdateGame()
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlUpdate = $"UPDATE GAMES " +
                $"SET GAME_DATETIME=TIMESTAMP'{gameDate.ToString("yyyy-MM-dd")} {gameTime}'," +
                $"VENUE='{venue}'" +
                $"WHERE GAME_ID='{gameID}'";
            OracleCommand cmd = new OracleCommand(sqlUpdate, conn);

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

        public void sqlDeleteGame(string reason)
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlDel = $"DELETE FROM GAMES WHERE GAME_ID='{gameID}'";
            OracleCommand cmd = new OracleCommand(sqlDel, conn);

            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} row(s) deleted.");
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }

            string sqlInsert = $"INSERT INTO CANCELLED_GAMES VALUES ('{gameID}','{home.TeamID}','{away.TeamID}',TIMESTAMP'{gameDate.ToString("yyyy-MM-dd")} {gameTime}','{venue}','{reason}')";
            cmd.CommandText = sqlInsert;
            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} row(s) inserted.");
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        public void sqlGameRecorded()
        {
            recorded = 'Y';
            OracleConnection conn = Program.getOracleConnection();
            string sqlUpdate = $"UPDATE GAMES " +
                $"SET RECORDED='{recorded}'" +
                $"WHERE GAME_ID='{gameID}'";
            OracleCommand cmd = new OracleCommand(sqlUpdate, conn);

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
