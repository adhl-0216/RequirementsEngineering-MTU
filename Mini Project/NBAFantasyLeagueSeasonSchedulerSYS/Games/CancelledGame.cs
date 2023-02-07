using Newtonsoft.Json;

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

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
