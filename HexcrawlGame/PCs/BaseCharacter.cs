using System;
using System.Collections.Generic;
using System.Text;

namespace HexcrawlGame.PCs
{
    public class BaseCharacter
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public Dictionary<string, int?> attributes { get; set; } = new Dictionary<string, int?>()
        {
            { "Strength", null },
            { "Intelligence", null },
            { "Wisdom", null },
            { "Constitution", null },
            { "Dexterity", null },
            { "Charisma", null }
        };
        public int Level { get; set; } = 1;
        public string Alignment { get; set; }
        public int Health { get; set; }
        public int ArmorClass { get; set; }
        public int Experience { get; set; } = 0;
        public string EquippedWeapon { get; set; }
        public string EquippedArmor { get; set; }
        public bool ShieldEquipped { get; set; }
        public Dictionary<string, int> inventory { get; set; } = new Dictionary<string, int>();

        // Moved into the class to avoid CS0116. Marked static/readonly so it's shared and immutable.
        public static readonly Dictionary<string, string> classes = new()
        {
            { "Cleric", "Cleric" },
            { "Fighter", "Fighter" },
            { "Magic-User", "Magic-User" }
        };

        public static readonly Dictionary<string, string> alignment = new()
        {
            {"Lawful", "Lawful"},
            { "Neutral", "Neutral"},
            {"Chaotic", "Chaotic"}
        };
    }
}