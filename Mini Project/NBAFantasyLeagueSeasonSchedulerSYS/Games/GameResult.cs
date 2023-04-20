﻿using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
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
        private char _winner;
        private int _homeScore;
        private int _homeRebounds;
        private int _homeAssists;
        private int _awayScore;
        private int _awayRebounds;
        private int _awayAssists;
        private string _gameID;

        public char winner { get => _winner; set => _winner = value; }
        public int homeScore { get => _homeScore; set => _homeScore = value; }
        public int homeRebounds { get => _homeRebounds; set => _homeRebounds = value; }
        public int homeAssists { get => _homeAssists; set => _homeAssists = value; }
        public int awayScore { get => _awayScore; set => _awayScore = value; }
        public int awayRebounds { get => _awayRebounds; set => _awayRebounds = value; }
        public int awayAssists { get => _awayAssists; set => _awayAssists = value; }
        public string gameID { get => _gameID; set => _gameID = value; }

        public GameResult(char winner, int homeScore, int homeRebounds, int homeAssists, int awayScore, int awayRebounds, int awayAssists, string gameID)
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

        public static void sqlSelectResultsByID( string teamID,ref List<GameResult> teamResults)
        {
            //get connection
            OracleConnection conn = Program.getOracleConnection();
            //select game results which GAME_ID consists of teamID
            string sqlSelect = "SELECT * FROM GAME_RESULTS WHERE GAME_ID LIKE :teamID";
            OracleCommand cmd = new OracleCommand(sqlSelect, conn);
            cmd.Parameters.Add(":teamID", $"%{teamID}%");
            //initialise List
            teamResults = new List<GameResult>();

            try
            {
                OracleDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    char winner = dataReader.GetString(0)[0];

                    int homeScore = dataReader.GetInt16(1);
                    int awayScore = dataReader.GetInt16(2);                    
                    int homeTRB = dataReader.GetInt16(3);
                    int awayTRB = dataReader.GetInt16(4);                    
                    int homeAST = dataReader.GetInt16(5);
                    int awayAST = dataReader.GetInt16(6);

                    string gameID = dataReader.GetString(7);

                    teamResults.Add(new GameResult(winner, homeScore, homeTRB, homeAST, awayScore, awayTRB, awayAST, gameID));
                }
            }
            catch (OracleException ex)
            {
                throw(ex);
            }
        }

        public void sqlInsertResult()
        {
            OracleConnection conn = Program.getOracleConnection();
            //insert game results
            string sqlInsert = $"INSERT INTO GAME_RESULTS VALUES(:winner, :homeScore, :awayScore, :homeRebounds, :awayRebounds, :homeAssists, :awayAssists, :gameID)";
            OracleCommand cmd = new OracleCommand(sqlInsert, conn);
            cmd.Parameters.Add(":winner", winner);
            cmd.Parameters.Add(":homeScore", homeScore);
            cmd.Parameters.Add(":awayScore", awayScore);
            cmd.Parameters.Add(":homeRebounds", homeRebounds);
            cmd.Parameters.Add(":awayRebounds", awayRebounds);
            cmd.Parameters.Add(":homeAssists", homeAssists);
            cmd.Parameters.Add(":awayAssists", awayAssists);
            cmd.Parameters.Add(":gameID", gameID);
            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                Console.WriteLine(affectedRows + " row(s) inserted.");
            }
            catch (OracleException ex)
            {
                throw(ex);
            }
        }
    }
}
