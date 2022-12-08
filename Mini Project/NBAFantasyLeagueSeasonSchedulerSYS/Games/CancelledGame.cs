using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    internal class CancelledGame : Game
    {
        private string _reason;
        public string Reason { get => _reason; set => _reason = value; }
        public CancelledGame(Game game, string reason) : base(game.HomeTeam, game.AwayTeam, game.Date, game.Time, game.MatchupCount)
        {
            Reason = reason;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
