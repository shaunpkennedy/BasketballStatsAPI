namespace BasketballStatsAPI.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public int JerseyNumber { get; set; }

        public List<PlayerGameStatistics> PlayerGameStatistics { get; set; } = new List<PlayerGameStatistics>();


        public Player(int playerID, string name, int jerseyNumber)
        {
            PlayerID = playerID;
            Name = name;
            JerseyNumber = jerseyNumber;
        }

    }
}
