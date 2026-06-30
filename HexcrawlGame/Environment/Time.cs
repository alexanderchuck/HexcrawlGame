namespace HexcrawlGame.Environment
{
    public class Time
    {
        public class Seasons
        {
            public string Name { get; set; }
            public int Duration { get; set; }
        }

        public static List<Seasons> seasons { get; set; } = new List<Seasons>()
        {
        new Seasons { Name = "Spring", Duration = 90},
        new Seasons { Name = "Summer", Duration = 90},
        new Seasons { Name = "Fall", Duration = 90},
        new Seasons { Name = "Winter", Duration = 90}
        };
    }
}
