using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using Newtonsoft.Json;
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
        private string home;
        private string away;
        private DateTime date;
        private TimeSpan time;
        private string venue;
        private int matchupCount;
   
        public string Home { get => home; set => home = value; }
        public string Away { get => away; set => away = value; }
        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public string Venue { get => venue; set => venue = value; }
        public string GameID { get => gameID; set => gameID = value; }
        public int MatchupCount { get => matchupCount; set => matchupCount = value; }

        public Game(Team home, Team away, DateTime dateTime, int matchupCount)
        {
            Home = home.TeamID;
            Away = away.TeamID;
            Date = dateTime.Date;
            Time = dateTime.TimeOfDay;
            Venue = home.HomeCourt;
            MatchupCount = matchupCount;
            setGameId();
        }

        private void setGameId()
        {
            GameID = away + "@" + home + ":" + MatchupCount;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
