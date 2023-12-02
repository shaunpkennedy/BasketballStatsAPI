using BasketballStatsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballStatsAPI.Tests.Models
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GameConstructor_WithValidParameters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            int gameID = 1;
            string opponentName = "Opponent Team";
            DateTime gameDate = DateTime.Parse("12/2/2023");
            bool isHomeGame = true;
            int homeScore = 80;
            int awayScore = 75;
            bool isVictory = true;

            // Act
            Game game = new Game(gameID, opponentName, gameDate, isHomeGame, homeScore, awayScore, isVictory);

            // Assert
            Assert.AreEqual(gameID, game.GameID);
            Assert.AreEqual(opponentName, game.OpponentName);
            Assert.AreEqual(gameDate, game.GameDate);
            Assert.AreEqual(isHomeGame, game.IsHomeGame);
            Assert.AreEqual(homeScore, game.HomeScore);
            Assert.AreEqual(awayScore, game.AwayScore);
            Assert.AreEqual(isVictory, game.IsVictory);
        }

        [TestMethod]
        public void GameConstructor_WithDefaultValues_ShouldSetPropertiesCorrectly()
        {
            // Arrange

            // Act
            Game game = new Game(0, null, DateTime.MinValue, false, 0, 0, false);

            // Assert
            Assert.AreEqual(0, game.GameID);
            Assert.IsNull(game.OpponentName);
            Assert.AreEqual(DateTime.MinValue, game.GameDate);
            Assert.IsFalse(game.IsHomeGame);
            Assert.AreEqual(0, game.HomeScore);
            Assert.AreEqual(0, game.AwayScore);
            Assert.IsFalse(game.IsVictory);
        }
    }
}
