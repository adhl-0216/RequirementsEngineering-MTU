using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

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
        
        public static void sqlSelectAllGames(ref List<Game> allGames)
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlSelectGames = "SELECT * FROM GAMES";
            OracleCommand cmd = new OracleCommand(sqlSelectGames, conn);

            try
            {
                OracleDataReader dataReader = cmd.ExecuteReader();
                allGames = new List<Game>();
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
                throw ex;
            }
        }

        public static void sqlSelectGameByTeamID(string teamID, ref List<Game> teamGames)
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlSelectGames = "SELECT * FROM GAMES WHERE GAME_ID LIKE :teamID";
            OracleCommand cmd = new OracleCommand(sqlSelectGames, conn);
            cmd.Parameters.Add(":teamID", $"%{teamID}%");
            teamGames = new List<Game>();
            try
            {
                OracleDataReader dataReader = cmd.ExecuteReader();
                teamGames = new List<Game>();
                while (dataReader.Read())
                {
                    string gameID = dataReader.GetString(0);
                    DateTime gameDateTime = dataReader.GetDateTime(3);
                    char recorded = dataReader.GetString(5)[0];

                    Game game = new Game(gameID, gameDateTime);
                    game.gameTime = gameDateTime.TimeOfDay;
                    game.recorded = recorded;

                    teamGames.Add(game);
                }
            }
            catch (OracleException ex)
            {
                throw ex;
            }
        }

        public void sqlInsertGame()
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlInsert = $"INSERT INTO GAMES VALUES VALUES ( :gameID, :homeID, :awayID, :gameDateTime, :venue, :recorded )";
            OracleCommand cmd = new OracleCommand(sqlInsert, conn);
            cmd.Parameters.Add(":gameID", gameID);
            cmd.Parameters.Add(":homeID", home.TeamID);
            cmd.Parameters.Add(":awayID", away.TeamID);
            DateTime gameDateTime = new DateTime(gameDate.Year, gameDate.Month, gameDate.Day, gameTime.Hours, gameTime.Minutes, gameTime.Seconds);
            cmd.Parameters.Add(":gameDateTime", gameDateTime);
            cmd.Parameters.Add(":venue", venue);
            cmd.Parameters.Add(":recorded", recorded);

            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} row(s) inserted.");
            }
            catch (OracleException ex)
            {
                throw ex;
            }
        }

        public void sqlUpdateGame()
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlUpdate = "UPDATE GAMES " +
                "SET GAME_DATETIME=:gameDateTime," +
                "VENUE=:venue" +
                "WHERE GAME_ID=:gameID";
            OracleCommand cmd = new OracleCommand(sqlUpdate, conn);
            DateTime gameDateTime = new DateTime(gameDate.Year, gameDate.Month, gameDate.Day, gameTime.Hours, gameTime.Minutes, gameTime.Seconds);
            cmd.Parameters.Add(":gameDateTime", gameDateTime);
            cmd.Parameters.Add(":gameID", gameID);
            cmd.Parameters.Add(":venue", venue);
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

        public void sqlDeleteGame(string reason)
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlDel = "DELETE FROM GAMES WHERE GAME_ID=:gameID"; //delete game from GAMES
            OracleCommand del = new OracleCommand(sqlDel, conn);
            del.Parameters.Add(":gameID", gameID);
            try
            {
                int affectedRows = del.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} row(s) deleted.");
            }
            catch (OracleException ex)
            {
                throw ex;
            }

            string sqlInsert = "INSERT INTO CANCELLED_GAMES VALUES ( :gameID, :homeID, :awayID, :gameDateTime, :venue, :reason )"; //insert new entry to CANCELLED_GAMES
            OracleCommand cmd = new OracleCommand(sqlInsert, conn);
            cmd.Parameters.Add(":gameID", gameID);
            cmd.Parameters.Add(":homeID", home.TeamID);
            cmd.Parameters.Add(":awayID", away.TeamID);
            DateTime gameDateTime = new DateTime(gameDate.Year, gameDate.Month, gameDate.Day, gameTime.Hours, gameTime.Minutes, gameTime.Seconds);
            cmd.Parameters.Add(":gameDateTime", gameDateTime);
            cmd.Parameters.Add(":venue", venue);
            cmd.Parameters.Add(":reason", reason);

            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} row(s) inserted.");
            }
            catch (OracleException ex)
            {
                throw ex;
            }
        }

        public void gameRecorded()
        {
            OracleConnection conn = Program.getOracleConnection();
            //set RECORDED column to Y for the specified GAME_ID
            string sqlUpdate = $"UPDATE GAMES SET RECORDED='Y' WHERE GAME_ID=:gameID";
            OracleCommand cmd = new OracleCommand(sqlUpdate, conn);
            cmd.Parameters.Add(":gameID", gameID);

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