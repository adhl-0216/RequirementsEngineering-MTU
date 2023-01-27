using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    internal class GameResult
    {
        private string _winner;
        private int _homeScore;
        private int _homeRebounds;
        private int _homeAssists;
        private int _awayScore;
        private int _awayRebounds;
        private int _awayAssists;
        private string _gameID;

        public string winner { get => _winner; set => _winner = value; }
        public int homeScore { get => _homeScore; set => _homeScore = value; }
        public int homeRebounds { get => _homeRebounds; set => _homeRebounds = value; }
        public int homeAssists { get => _homeAssists; set => _homeAssists = value; }
        public int awayScore { get => _awayScore; set => _awayScore = value; }
        public int awayRebounds { get => _awayRebounds; set => _awayRebounds = value; }
        public int awayAssists { get => _awayAssists; set => _awayAssists = value; }
        public string gameID { get => _gameID; set => _gameID = value; }

        public GameResult(string winner, int homeScore, int homeRebounds, int homeAssists, int awayScore, int awayRebounds, int awayAssists, string gameID)
        {
            this.winner = winner;
            this.homeScore = homeScore;
            this.homeRebounds = homeRebounds;
            this.homeAssists = homeAssists;
            this.awayScore = awayScore;
            this.awayRebounds = awayRebounds;
            this.awayAssists = awayAssists;
            this.gameID = gameID;
        }

        public void saveGameResult()
        {
            OracleConnection conn = Program.getOracleConnection();
            String sqlInsert = $"INSERT INTO {"GAME_RESULTS"} VALUES('{winner}',{homeScore},{awayScore},{homeRebounds},{awayRebounds},{homeAssists},{awayAssists}, '{gameID}')";
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

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
