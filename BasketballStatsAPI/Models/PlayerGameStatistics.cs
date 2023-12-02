namespace BasketballStatsAPI.Models
{
    public class PlayerGameStatistics
    {
        public int PlayerGameStatisticsID { get; set; }
        public int PlayerID { get; set; }
        public int GameID { get; set; }
        public int PointsScored { get; set; }
        public int FieldGoalsMade { get; set; }
        public int FieldGoalsAttempted { get; set; }
        public double FieldGoalPercentage => CalculatePercentage(FieldGoalsMade, FieldGoalsAttempted);
        public int ThreePointersMade { get; set; }
        public int ThreePointersAttempted { get; set; }
        public double ThreePointPercentage => CalculatePercentage(ThreePointersMade, ThreePointersAttempted);
        public int FreeThrowsMade { get; set; }
        public int FreeThrowsAttempted { get; set; }
        public double FreeThrowPercentage => CalculatePercentage(FreeThrowsMade, FreeThrowsAttempted);
        public int Assists { get; set; }
        public int Rebounds { get; set; }
        public int Steals { get; set; }
        public int Blocks { get; set; }
        public int Fouls { get; set; }
        public bool StartedGame { get; set; }


        private double CalculatePercentage(int made, int attempted)
        {
            return attempted == 0 ? 0 : (double)made / attempted * 100;
        }

    }
}
