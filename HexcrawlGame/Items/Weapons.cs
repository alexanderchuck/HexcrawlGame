using System;
using System.Collections.Generic;
using System.Text;

namespace HexcrawlGame.Items
{
    public class WeaponStats
    {
        public int Damage { get; set; }
        public bool HasEdge { get; set; }
        public bool IsRanged { get; set; }
        public int ShortRange { get; set; }
        public int MediumRange { get; set; }
        public int LongRange { get; set; }

        public static readonly Dictionary<string, WeaponStats> weapons = new()
    {
        { "Battle Axe", 
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 13),
                    HasEdge = true 
                } 
        },
        { "Dagger",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true,
                    IsRanged = true,
                    MediumRange = 3 
                } 
        },
        { "Flail",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = false 
                } 
        },
        { "Hand Axe",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true,
                    IsRanged = true,
                    MediumRange = 3 
                } 
        },
        { "Lance",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true 
                } 
        },
        { "Mace",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = false 
                } 
        },
        { "Morning Star",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = false 
                } 
        },
        { "Polearm",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true 
                } 
        },
        { "Short Sword",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true 
                } 
        },
        { "Spear",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true,
                    IsRanged = true,
                    MediumRange = 6 
                } 
        },
        { "Staff",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = false 
                } 
        },
        { "Sword",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true 
                } 
        },
        { "Greatsword",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 13),
                    HasEdge = true 
                } 
        },
        { "War Hammer",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = false,
                    IsRanged = true,
                    MediumRange = 3 
                } 
        },
        { "Crossbow",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true,
                    IsRanged = true,
                    ShortRange = 6,
                    MediumRange = 12,
                    LongRange = 18 
                } 
        },
        { "Longbow",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true,
                    IsRanged = true,
                    ShortRange = 7,
                    MediumRange = 14,
                    LongRange = 21 
                } 
        },
        { "Shortbow",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true,
                    IsRanged = true,
                    ShortRange = 5,
                    MediumRange = 10,
                    LongRange = 15 
                } 
        },
        { "Sling",
                new WeaponStats 
                {
                    Damage = new Random().Next(2, 7),
                    HasEdge = true,
                    IsRanged = true,
                    ShortRange = 5,
                    MediumRange = 10,
                    LongRange = 15 
                } 
        }
    };


    }
}
