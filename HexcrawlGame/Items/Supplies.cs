namespace HexcrawlGame.Items
{
    public class Supplies
    {
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public int Price { get; set; }

        public static List<Supplies> supplies { get; set; } = new List<Supplies>()
        {
            new Supplies { Name = "Bunch of Belladona", Price = 10 },
            new Supplies { Name = "Candles", Quantity = 12, Price = 2 },
            new Supplies { Name = "Traveling Cloak", Price = 3 },
            new Supplies { Name = "Silver Cross", Price = 40 },
            new Supplies { Name = "Wooden Cross", Price = 5 },
            new Supplies { Name = "Crowbar", Price = 5 },
            new Supplies { Name = "String of Garlic", Price = 5 },
            new Supplies { Name = "Hammer", Price = 3 },
            new Supplies { Name = "Holy Water Flask", Price = 25 },
            new Supplies { Name = "Iron Spikes", Quantity = 6, Price = 1 },
            new Supplies { Name = "Lantern", Price = 10 },
            new Supplies { Name = "Small Silver Mirror", Price = 20 },
            new Supplies { Name = "Steel Mirror", Price = 5 },
            new Supplies { Name = "Oil Flask", Price = 2 },
            new Supplies { Name = "Rations, week", Price = 7 },
            new Supplies { Name = "50ft Rope", Price = 2 },
            new Supplies { Name = "Large Sack", Price = 2 },
            new Supplies { Name = "Shovel", Price = 5 },
            new Supplies { Name = "Wooden Stakes", Quantity = 2, Price = 1 },
            new Supplies { Name = "Tinderbox", Price = 2 },
            new Supplies { Name = "Torches", Quantity = 6, Price = 1 },
            new Supplies { Name = "Wine Flask", Price = 2 },
            new Supplies { Name = "Bunch of Wolvesbane", Price = 10 }
        };

        public static List<Supplies> starterSupplies { get; set; } = new List<Supplies>()
        {
            new Supplies { Name = "Leather Backpack", Price = 4 },
            new Supplies { Name = "Small Sack", Price = 2 },
            new Supplies { Name = "10ft Pole", Price = 1 },
            new Supplies { Name = "Iron Rations, week", Price = 15 },
            new Supplies { Name = "Waterskin", Price = 1 },

        };

        public static List<Supplies> missiles { get; set; } = new List<Supplies>()
        {
            new Supplies { Name = "Silver Arrow", Quantity = 1, Price = 5 },
            new Supplies { Name = "Silver Bolt", Quantity = 1, Price = 5 },
            new Supplies { Name = "Arrows", Quantity = 20, Price = 5 },
            new Supplies { Name = "Arrows, Quiver", Quantity = 20, Price = 10 },
            new Supplies { Name = "Bolts", Quantity = 30, Price = 5 },
            new Supplies { Name = "Bolts, Case", Quantity = 30, Price = 10 },
        };
    };

    // Missiles
    // Livestock & Transportation
}
