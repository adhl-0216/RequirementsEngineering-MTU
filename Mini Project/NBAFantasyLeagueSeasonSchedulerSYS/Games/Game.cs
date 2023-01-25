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
    class Game
    {
        private string gameID;
        private string homeID;
        private Team homeTeam;
        private string awayID;
        private Team awayTeam;
        private DateTime date;
        private TimeSpan time;
        private string venue;
        private int matchupCount;
   
        public string HomeID { get => homeID; set => homeID = value; }
        public string AwayID { get => awayID; set => awayID = value; }
        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public string Venue { get => venue; set => venue = value; }
        public string GameID { get => gameID; set => gameID = value; }
        public int MatchupCount { get => matchupCount; set => matchupCount = value; }
        internal Team HomeTeam { get => homeTeam; set => homeTeam = value; }
        internal Team AwayTeam { get => awayTeam; set => awayTeam = value; }

        public Game(Team home, Team away, DateTime date, TimeSpan time, int matchupCount)
        {
            HomeTeam = home;
            AwayTeam = away;
            HomeID = HomeTeam.TeamID;
            AwayID = AwayTeam.TeamID;
            Date = date.Date;
            Time = time;
            Venue = home.HomeCourt;
            MatchupCount = matchupCount;
            setGameId();
        }

        private void setGameId()
        {
            GameID = awayID + "@" + homeID + ":" + MatchupCount;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
