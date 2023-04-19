using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    internal class CancelledGame : Game
    {
        private string _reason;
        public string Reason { get => _reason; set => _reason = value; }
        public CancelledGame(Game game, string reason) : base(game.gameID, game.gameDate)
        {
            Reason = reason;
        }

        public static void sqlSelectCancelledGames(ref List<CancelledGame> allCancelledGames)
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlSelect = "SELECT * FROM CANCELLED_GAMES";
            OracleCommand cmd = new OracleCommand(sqlSelect, conn);

            try
            {
                OracleDataReader dataReader = cmd.ExecuteReader();
                allCancelledGames = new List<CancelledGame>(10);
                while (dataReader.Read())
                {
                    string gameID = dataReader.GetString(0);
                    DateTime gameDateTime = dataReader.GetDateTime(3);
                    string reason = dataReader.GetString(5);

                    CancelledGame cGame = new CancelledGame(new Game(gameID, gameDateTime.Date), reason);
                    cGame.gameTime = gameDateTime.TimeOfDay;

                    allCancelledGames.Add(cGame);
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
