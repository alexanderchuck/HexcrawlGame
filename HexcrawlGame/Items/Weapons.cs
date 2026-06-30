namespace HexcrawlGame.Items
{
    public class WeaponStats
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public bool HasEdge { get; set; }
        public bool IsRanged { get; set; }
        public int ShortRange { get; set; }
        public int MediumRange { get; set; }
        public int LongRange { get; set; }

        public static List<WeaponStats> weaponList = new List<WeaponStats>
        {
            new WeaponStats
            {
                Name = "Battle Axe",
                Damage = new Random().Next(2, 13),
                HasEdge = true
            },
            new WeaponStats
            {
                Name = "Dagger",
                Damage = new Random().Next(2, 7),
                HasEdge = true,
                IsRanged = true,
                MediumRange = 3
            },
            new WeaponStats
            {
                Name = "Flail",
                Damage = new Random().Next(2, 7),
                HasEdge = false
            },
            new WeaponStats
            {
                Name = "Hand Axe",
                Damage = new Random().Next(2, 7),
                HasEdge = true,
                IsRanged = true,
                MediumRange = 3
            },
            new WeaponStats
            {
                Name = "Lance",
                Damage = new Random().Next(2, 7),
                HasEdge = true
            },
            new WeaponStats
            {
                Name = "Mace",
                Damage = new Random().Next(2, 7),
                HasEdge = false
            },
            new WeaponStats
            {
                Name = "Morning Star",
                Damage = new Random().Next(2, 7),
                HasEdge = false
            },
            new WeaponStats
            {
                Name = "Polearm",
                Damage = new Random().Next(2, 7),
                HasEdge = true
            },
            new WeaponStats
            {
                Name = "Short Sword",
                Damage = new Random().Next(2, 7),
                HasEdge = true
            },
            new WeaponStats
            {
                Name = "Spear",
                Damage = new Random().Next(2, 7),
                HasEdge = true,
                IsRanged = true,
                MediumRange = 6
            },
            new WeaponStats
            {
                Name = "Staff",
                Damage = new Random().Next(2, 7),
                HasEdge = false
            },
            new WeaponStats
            {
                Name = "Sword",
                Damage = new Random().Next(2, 7),
                HasEdge = true
            },
            new WeaponStats
            {
                Name = "Greatsword",
                Damage = new Random().Next(2, 13),
                HasEdge = true
            },
            new WeaponStats
            {
                Name = "War Hammer",
                Damage = new Random().Next(2, 7),
                HasEdge = false,
                IsRanged = true,
                MediumRange = 3
            },
            new WeaponStats
            {
                Name = "Crossbow",
                Damage = new Random().Next(2, 7),
                HasEdge = true,
                IsRanged = true,
                ShortRange = 6,
                MediumRange = 12,
                LongRange = 18
            },
            new WeaponStats
            {
                Name = "Longbow",
                Damage = new Random().Next(2, 7),
                HasEdge = true,
                IsRanged = true,
                ShortRange = 7,
                MediumRange = 14,
                LongRange = 21
            },
            new WeaponStats
            {
                Name = "Shortbow",
                Damage = new Random().Next(2, 7),
                HasEdge = true,
                IsRanged = true,
                ShortRange = 5,
                MediumRange = 10,
                LongRange = 15
            },
            new WeaponStats
            {
                Name = "Sling",
                Damage = new Random().Next(2, 7),
                HasEdge = false,
                IsRanged = true,
                ShortRange = 5,
                MediumRange = 10,
                LongRange = 15
            }
        };
    };


    //    public class WeaponStats
    //    {
    //        public int Damage { get; set; }
    //        public bool HasEdge { get; set; }
    //        public bool IsRanged { get; set; }
    //        public int ShortRange { get; set; }
    //        public int MediumRange { get; set; }
    //        public int LongRange { get; set; }

    //        public static readonly Dictionary<string, WeaponStats> weapons = new()
    //            {
    //                { "Battle Axe",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 13),
    //                            HasEdge = true
    //                        }
    //                },
    //                { "Dagger",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = true,
    //                            IsRanged = true,
    //                            MediumRange = 3
    //                        }
    //                },
    //                { "Flail",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = false
    //                        }
    //                },
    //                { "Hand Axe",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = true,
    //                            IsRanged = true,
    //                            MediumRange = 3
    //                        }
    //                },
    //                { "Lance",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = true
    //                        }
    //                },
    //                { "Mace",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = false
    //                        }
    //                },
    //                { "Morning Star",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = false
    //                        }
    //                },
    //                { "Polearm",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = true
    //                        }
    //                },
    //                { "Short Sword",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = true
    //                        }
    //                },
    //                { "Spear",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = true,
    //                            IsRanged = true,
    //                            MediumRange = 6
    //                        }
    //                },
    //                { "Staff",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = false
    //                        }
    //                },
    //                { "Sword",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = true
    //                        }
    //                },
    //                { "Greatsword",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 13),
    //                            HasEdge = true
    //                        }
    //                },
    //                { "War Hammer",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = false,
    //                            IsRanged = true,
    //                            MediumRange = 3
    //                        }
    //                },
    //                { "Crossbow",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = true,
    //                            IsRanged = true,
    //                            ShortRange = 6,
    //                            MediumRange = 12,
    //                            LongRange = 18
    //                        }
    //                },
    //                { "Longbow",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = true,
    //                            IsRanged = true,
    //                            ShortRange = 7,
    //                            MediumRange = 14,
    //                            LongRange = 21
    //                        }
    //                },
    //                { "Shortbow",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = true,
    //                            IsRanged = true,
    //                            ShortRange = 5,
    //                            MediumRange = 10,
    //                            LongRange = 15
    //                        }
    //                },
    //                { "Sling",
    //                        new WeaponStats
    //                        {
    //                            Damage = new Random().Next(2, 7),
    //                            HasEdge = false,
    //                            IsRanged = true,
    //                            ShortRange = 5,
    //                            MediumRange = 10,
    //                            LongRange = 15
    //                        }
    //                }
    //            };


    //    }
}
