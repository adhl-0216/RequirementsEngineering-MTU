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
        private string _homeID;
        private string _awayID;
        private DateTime _gameDate;
        private TimeSpan _gameTime;
        private string _venue;
        private Team _home;
        private Team _away;

        public string gameID { get => _gameID; set => _gameID = value; }
        public string homeID { get => _homeID; set => _homeID = value; }
        public string awayID { get => _awayID; set => _awayID = value; }
        public DateTime gameDate { get => _gameDate.Date ; set => _gameDate = value.Date; }
        public TimeSpan gameTime { get => _gameTime; set => _gameTime = value; }
        public string venue { get => _venue; set => _venue = value; }
        internal Team home { get => _home; set => _home = value; }
        internal Team away { get => _away; set => _away = value; }

        public Game(string GameID, Team Home, Team Away, DateTime GameDate, TimeSpan GameTime)
        {
            gameID = GameID;
            homeID = Home.TeamID;
            awayID = Away.TeamID;
            gameDate = GameDate.Date;
            gameTime= GameTime;
            venue = Home.HomeCourt;
            home = Home;
            away = Away;
        }

        public Game(string GameID, DateTime GameDate)
        {
            gameID = GameID;
            gameDate = GameDate;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void saveGame()
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlInsert = $"INSERT INTO GAMES VALUES ('{gameID}','{homeID}','{awayID}',{gameDate},{gameTime},'{venue}')";
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
    }
}
