using BasketballStatsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballStatsAPI.Tests.Models
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void PlayerConstructor_WithValidParameters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            int playerID = 1;
            string name = "Eddie Vedder";
            int jerseyNumber = 13;

            // Act
            Player player = new Player(playerID, name, jerseyNumber);

            // Assert
            Assert.AreEqual(playerID, player.PlayerID);
            Assert.AreEqual(name, player.Name);
            Assert.AreEqual(jerseyNumber, player.JerseyNumber);
        }

        [TestMethod]
        public void PlayerConstructor_WithDefaultValues_ShouldSetPropertiesCorrectly()
        {
            // Act
            Player player = new Player(0, null, 0);

            // Assert
            Assert.AreEqual(0, player.PlayerID);
            Assert.IsNull(player.Name);
            Assert.AreEqual(0, player.JerseyNumber);
        }

        [TestMethod]
        public void PlayerConstructor_WithPlayerGameStatistics_ShouldInitializeList()
        {
            // Arrange
            int playerID = 1;
            string name = "Eddie Vedder";
            int jerseyNumber = 13;

            // Act
            Player player = new Player(playerID, name, jerseyNumber);

            // Assert
            Assert.IsNotNull(player.PlayerGameStatistics);
            Assert.AreEqual(0, player.PlayerGameStatistics.Count);
        }
    }
}
