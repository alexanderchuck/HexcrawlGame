namespace HexcrawlGame.Spells
{
    public class ClericSpells
    {
        public string Name { get; set; }
        public int SpellLevel { get; set; }

        public static List<ClericSpells> firstLevelClericSpells = new List<ClericSpells>()
    {
        new ClericSpells { Name = "Cure Light Wounds", SpellLevel = 1 },
        new ClericSpells { Name = "Detect Evil", SpellLevel = 1 },
        new ClericSpells { Name = "Detect Magic", SpellLevel = 1 },
        new ClericSpells { Name = "Light", SpellLevel = 1 },
        new ClericSpells { Name = "Protection from Evil", SpellLevel = 1 },
        new ClericSpells { Name = "Purify Food and Drink", SpellLevel = 1 },
    };
        public static List<ClericSpells> secondLevelClericSpells = new List<ClericSpells>()
    {
        new ClericSpells { Name = "Bless", SpellLevel = 2 },
        new ClericSpells { Name = "Continuous Light", SpellLevel = 2 },
        new ClericSpells { Name = "Find Traps", SpellLevel = 2 },
        new ClericSpells { Name = "Hold Person", SpellLevel = 2 },
        new ClericSpells { Name = "Remove Disease", SpellLevel = 2 },
        new ClericSpells { Name = "Speak with Animals", SpellLevel = 2 },
    };
        public static List<ClericSpells> thirdLevelClericSpells = new List<ClericSpells>()
    {
        new ClericSpells { Name = "Circle of Protection from Evil", SpellLevel = 3 },
        new ClericSpells { Name = "Cure Serious Wounds", SpellLevel = 3 },
        new ClericSpells { Name = "Enervate Dead", SpellLevel = 3 },
        new ClericSpells { Name = "Locate Object", SpellLevel = 3 },
        new ClericSpells { Name = "Remove Curse", SpellLevel = 3 },
        new ClericSpells { Name = "Speak with Dead", SpellLevel = 3 },
    };
        public static List<ClericSpells> fourthLevelClericSpells = new List<ClericSpells>()
    {
        new ClericSpells { Name = "Control Water", SpellLevel = 4 },
        new ClericSpells { Name = "Create Food and Drink", SpellLevel = 4 },
        new ClericSpells { Name = "Cure Critical Wounds", SpellLevel = 4 },
        new ClericSpells { Name = "Hold Monster", SpellLevel = 4 },
        new ClericSpells { Name = "Neutralize Poison", SpellLevel = 4 },
        new ClericSpells { Name = "Speak with Plants", SpellLevel = 4 },
    };
        public static List<ClericSpells> fifthLevelClericSpells = new List<ClericSpells>()
    {
        new ClericSpells { Name = "Commune", SpellLevel = 5 },
        new ClericSpells { Name = "Dispel Evil", SpellLevel = 5 },
        new ClericSpells { Name = "Insect Plague", SpellLevel = 5 },
        new ClericSpells { Name = "Quest", SpellLevel = 5 },
        new ClericSpells { Name = "Raise Dead", SpellLevel = 5 },
        new ClericSpells { Name = "True Seeing", SpellLevel = 5 },
    };

    }
}
