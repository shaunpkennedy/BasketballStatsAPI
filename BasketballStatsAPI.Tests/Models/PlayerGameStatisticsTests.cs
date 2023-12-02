using BasketballStatsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballStatsAPI.Tests.Models
{
    [TestClass]
    public class PlayerGameStatisticsTests
    {
        [TestMethod]
        public void Properties_ShouldBeSetCorrectly()
        {
            // Arrange
            var stats = new PlayerGameStatistics
            {
                PlayerGameStatisticsID = 1,
                PlayerID = 2,
                GameID = 3,
                PointsScored = 20,
                FieldGoalsMade = 8,
                FieldGoalsAttempted = 10,
                ThreePointersMade = 2,
                ThreePointersAttempted = 5,
                FreeThrowsMade = 5,
                FreeThrowsAttempted = 7,
                Assists = 4,
                Rebounds = 10,
                Steals = 2,
                Blocks = 1,
                Fouls = 3,
                StartedGame = true
            };

            // Assert
            Assert.AreEqual(1, stats.PlayerGameStatisticsID);
            Assert.AreEqual(2, stats.PlayerID);
            Assert.AreEqual(3, stats.GameID);
            Assert.AreEqual(20, stats.PointsScored);
            Assert.AreEqual(8, stats.FieldGoalsMade);
            Assert.AreEqual(10, stats.FieldGoalsAttempted);
            Assert.AreEqual(2, stats.ThreePointersMade);
            Assert.AreEqual(5, stats.ThreePointersAttempted);
            Assert.AreEqual(5, stats.FreeThrowsMade);
            Assert.AreEqual(7, stats.FreeThrowsAttempted);
            Assert.AreEqual(4, stats.Assists);
            Assert.AreEqual(10, stats.Rebounds);
            Assert.AreEqual(2, stats.Steals);
            Assert.AreEqual(1, stats.Blocks);
            Assert.AreEqual(3, stats.Fouls);
            Assert.IsTrue(stats.StartedGame);
        }

        [TestMethod]
        public void StartedGame_DefaultValue_ShouldBeFalse()
        {
            // Arrange
            var stats = new PlayerGameStatistics();

            // Assert
            Assert.IsFalse(stats.StartedGame);
        }

        [TestMethod]
        public void FieldGoalPercentage_CalculatePercentage_ShouldReturnCorrectValue()
        {
            // Arrange
            int fieldGoalsMade = 8;
            int fieldGoalsAttempted = 10;
            PlayerGameStatistics stats = new PlayerGameStatistics
            {
                FieldGoalsMade = fieldGoalsMade,
                FieldGoalsAttempted = fieldGoalsAttempted
            };

            // Act
            double fieldGoalPercentage = stats.FieldGoalPercentage;

            // Assert
            Assert.AreEqual(80.0, fieldGoalPercentage);
        }

        [TestMethod]
        public void ThreePointPercentage_CalculatePercentage_ShouldReturnCorrectValue()
        {
            // Arrange
            int threePointersMade = 2;
            int threePointersAttempted = 5;
            PlayerGameStatistics stats = new PlayerGameStatistics
            {
                ThreePointersMade = threePointersMade,
                ThreePointersAttempted = threePointersAttempted
            };

            // Act
            double threePointPercentage = stats.ThreePointPercentage;

            // Assert
            Assert.AreEqual(40.0, threePointPercentage);
        }

        [TestMethod]
        public void FreeThrowPercentage_CalculatePercentage_ShouldReturnCorrectValue()
        {
            // Arrange
            int freeThrowsMade = 5;
            int freeThrowsAttempted = 7;
            PlayerGameStatistics stats = new PlayerGameStatistics
            {
                FreeThrowsMade = freeThrowsMade,
                FreeThrowsAttempted = freeThrowsAttempted
            };

            // Act
            double freeThrowPercentage = stats.FreeThrowPercentage;

            // Assert
            Assert.AreEqual(71.42857142857143, freeThrowPercentage, 0.0001);
        }

    }
}
