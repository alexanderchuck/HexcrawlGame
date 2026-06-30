namespace HexcrawlGame.PCs
{
    public class BaseCharacter
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public Dictionary<string, int?> Attributes { get; set; } = new Dictionary<string, int?>()
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
        public Dictionary<string, int> Currency { get; set; } = new Dictionary<string, int>()
        {
            { "GP", 0 },
            { "SP", 0 },
            { "CP", 0 }
        };
        public string[] EquippedWeapon { get; set; } = Array.Empty<string>();
        public string[] EquippedArmor { get; set; } = Array.Empty<string>();
        public int ArmorClass { get; set; }
        public int Experience { get; set; } = 0;
        public double BonusExperience { get; set; }
        public Dictionary<string, int?> SavingThrows { get; set; } = new Dictionary<string, int?>()
        {
            { "Poison", null },
            { "Wands/Rays", null },
            { "Paralysis/Petrification", null },
            { "Breath", null },
            { "Spells", null }
        };
        public Dictionary<string, int?> Inventory { get; set; } = new Dictionary<string, int?>();

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
            {"Neutral", "Neutral"},
            {"Chaotic", "Chaotic"}
        };

        public double GetExperienceBonus(int bonus) => bonus switch
        {
            >= 3 and <= 5 => -.2,
            >= 6 and <= 8 => -.1,
            >= 9 and <= 12 => 0,
            >= 13 and <= 15 => .05,
            >= 16 and <= 18 => .1,
        };

        public object[]? PreparedSpells { get; set; }
    }
}