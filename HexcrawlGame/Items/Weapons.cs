using System;
using System.Collections.Generic;
using System.Text;

namespace HexcrawlGame.Items
{
    public class WeaponStats
    {
        public int Damage { get; set; }
        public bool HasEdge { get; set; }

        public static readonly Dictionary<string, WeaponStats> weapons = new()
    {
        { "Battle Axe", new WeaponStats { Damage = new Random().Next(2, 13), HasEdge = true } },
        { "Dagger", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = true } },
        { "Flail", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = false } },
        { "Hand Axe", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = true } },
        { "Lance", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = true } },
        { "Mace", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = false } },
        { "Morning Star", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = false } },
        { "Polearm", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = true } },
        { "Short Sword", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = true } },
        { "Spear", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = true } },
        { "Staff", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = false } },
        { "Sword", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = true } },
        { "Greatsword", new WeaponStats { Damage = new Random().Next(2, 13), HasEdge = true } },
        { "War Hammer", new WeaponStats { Damage = new Random().Next(2, 7), HasEdge = false } },
    };

    }
}
