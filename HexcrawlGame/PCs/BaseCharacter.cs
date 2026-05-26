using System;
using System.Collections.Generic;
using System.Text;

namespace HexcrawlGame.PCs
{
    public class BaseCharacter
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        public string Inventory { get; set; }

        // Moved into the class to avoid CS0116. Marked static/readonly so it's shared and immutable.
        public static readonly Dictionary<string, string> classes = new()
        {
            { "Cleric", "Cleric" },
            { "Fighter", "Fighter" },
            { "Magic-User", "Magic-User" }
        };
    }
}
