using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics.Eventing.Reader;

namespace BasketballStatsAPI.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string OpponentName { get; set; }
        public DateTime GameDate { get; set; }
        public bool IsHomeGame { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public bool IsVictory { get; set; }


        public Game(int gameID, string opponentName, DateTime gameDate, bool isHomeGame, int homeScore, int awayScore, bool isVictory)
        {
            GameID = gameID;
            OpponentName = opponentName;
            GameDate = gameDate;
            IsHomeGame = isHomeGame;
            HomeScore = homeScore;
            AwayScore = awayScore;
            IsVictory = isVictory;
        }


    }
}
