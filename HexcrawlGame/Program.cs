using HexcrawlGame.Environment;
using HexcrawlGame.Items;
using HexcrawlGame.PCs;
using HexcrawlGame.Scripts;
using System.Linq;

// MECHANIC CHECKLIST:
// Character Creation ✔️
// Item Dictionary
// Spell Dictionary
// Combat (Melee/Ranged)
// Combat (Spellcasting)
// Resource Management
// Hirelings
// Movement
// Environmental Effects
// Hex Generation
// Hex Population
// Dungeon Generation
// Dungeon Population


Console.WriteLine("<----------xxx ~*~ xxx---------->");
Console.WriteLine();
Console.WriteLine("Welcome to Hexcrawl Survival!");
Console.WriteLine();
Console.WriteLine("<----------xxx ~*~ xxx---------->");
Console.WriteLine();

//List<Weapons> weaponList = new List<Weapons>
//        {
//            new Weapons
//            {
//                Name = "Battle Axe",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 13),
//                    HasEdge = true
//                }
//            },
//            new Weapons
//            {
//                Name = "Dagger",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = true,
//                    IsRanged = true,
//                    MediumRange = 3
//                }
//            },
//            new Weapons
//            {
//                Name = "Flail",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = false
//                }
//            },
//            new Weapons
//            {
//                Name = "Hand Axe",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = true,
//                    IsRanged = true,
//                    MediumRange = 3
//                }
//            },
//            new Weapons
//            {
//                Name = "Lance",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = true
//                }
//            },
//            new Weapons
//            {
//                Name = "Mace",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = false
//                }
//            },
//            new Weapons
//            {
//                Name = "Morning Star",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = false
//                }
//            },
//            new Weapons
//            {
//                Name = "Polearm",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = true
//                }
//            },
//            new Weapons
//            {
//                Name = "Short Sword",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = true
//                }
//            },
//            new Weapons
//            {
//                Name = "Spear",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = true,
//                    IsRanged = true,
//                    MediumRange = 6
//                }
//            },
//            new Weapons
//            {
//                Name = "Staff",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = false
//                }
//            },
//            new Weapons
//            {
//                Name = "Sword",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = true
//                }
//            },
//            new Weapons
//            {
//                Name = "Greatsword",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 13),
//                    HasEdge = true
//                }
//            },
//            new Weapons
//            {
//                Name = "War Hammer",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = false,
//                    IsRanged = true,
//                    MediumRange = 3
//                }
//            },
//            new Weapons
//            {
//                Name = "Crossbow",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = true,
//                    IsRanged = true,
//                    ShortRange = 6,
//                    MediumRange = 12,
//                    LongRange = 18
//                }
//            },
//            new Weapons
//            {
//                Name = "Longbow",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = true,
//                    IsRanged = true,
//                    ShortRange = 7,
//                    MediumRange = 14,
//                    LongRange = 21
//                }
//            },
//            new Weapons
//            {
//                Name = "Shortbow",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = true,
//                    IsRanged = true,
//                    ShortRange = 5,
//                    MediumRange = 10,
//                    LongRange = 15
//                }
//            },
//            new Weapons
//            {
//                Name = "Sling",
//                WeaponStats = new WeaponStats
//                {
//                    Damage = new Random().Next(2, 7),
//                    HasEdge = false,
//                    IsRanged = true,
//                    ShortRange = 5,
//                    MediumRange = 10,
//                    LongRange = 15
//                }
//            }
//        };

PrimaryCharacterCreation newCharacter = new PrimaryCharacterCreation();

newCharacter.CreateCharacter();