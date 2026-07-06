namespace HexcrawlGame.Enemies
{
    public class Bestiary
    {
        public string Name { get; set; }
        public int NumberAppearing { get; set; }
        public int ArmorClass { get; set; }
        public int? MovementRate { get; set; }
        public int[]? HitDice { get; set; }
        public string[]? Alignment { get; set; }
        public string? TreasureType { get; set; }

        public List<Bestiary> bestiary { get; set; } = new List<Bestiary>()
        {
            new Bestiary
            {
                Name = "Androids",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 9,
                MovementRate = 12,
                HitDice = [2],
                Alignment = ["Lawful", "Neutral", "Chaotic"],
                TreasureType = "A2"
            },
            new Bestiary
            {
                Name = "Giant Ants",
                NumberAppearing = new Random().Next(2, 13),
                ArmorClass = 3,
                MovementRate = 18,
                HitDice = [2],
                Alignment = ["Neutral"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Apes",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [4, 1],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Basilisks",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 4,
                MovementRate = 6,
                HitDice = [6, 1],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "F"
            },
            new Bestiary
            {
                Name = "Bats",
                NumberAppearing = new Random().Next(10, 81),
                ArmorClass = 8,
                MovementRate = 12,
                HitDice = null,
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Giant Bats",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 7,
                MovementRate = 15,
                HitDice = [4],
                Alignment = ["Neutral"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Bears",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [5, 5],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Giant Beetles",
                NumberAppearing = new Random().Next(1, 13),
                ArmorClass = 3,
                MovementRate = 9,
                HitDice = [new Random().Next(2, 8)],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Black Pudding",
                NumberAppearing = 1,
                ArmorClass = 7,
                MovementRate = 3,
                HitDice = [10],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Boars",
                NumberAppearing = new Random().Next(1, 13),
                ArmorClass = 7,
                MovementRate = 15,
                HitDice = [1, 2],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Giant Boars",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [7],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Cave Bears",
                NumberAppearing = new Random().Next(1, 3),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [6, 6],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Cavemen",
                NumberAppearing = new Random().Next(2, 13),
                ArmorClass = 9,
                MovementRate = 12,
                HitDice = [2],
                Alignment = ["Neutral"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Centaurs",
                NumberAppearing = new Random().Next(2,9),
                ArmorClass = 6,
                MovementRate = 18,
                HitDice = [4],
                Alignment = ["Lawful", "Neutral"],
                TreasureType = "A1"
            },
            new Bestiary
            {
                Name = "Giant Centipedes",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 3,
                MovementRate = 12,
                HitDice = [3, 1],
                Alignment = ["Neutral"],
                TreasureType = "B"
            },
            new Bestiary
            {
                Name = "Large Centipedes",
                NumberAppearing = new Random().Next(2, 25),
                ArmorClass = 9,
                MovementRate = 6,
                HitDice = null,
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Chimeras",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 4,
                MovementRate = 12,
                HitDice = [9],
                Alignment = ["Chaotic"],
                TreasureType = "F"
            },
            new Bestiary
            {
                Name = "Cockatrices",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [5],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Giant Crabs",
                NumberAppearing = new Random().Next(3, 13),
                ArmorClass = 3,
                MovementRate = 6,
                HitDice = [3],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Crocodiles",
                NumberAppearing = new Random().Next(2, 13),
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [3],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Giant Crocodiles",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 5,
                MovementRate = 9,
                HitDice = [7],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Cyborgs",
                NumberAppearing = new Random().Next(2, 9),
                ArmorClass = 5,
                MovementRate = 9,
                HitDice = [3, 3],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "G"
            },
            new Bestiary
            {
                Name = "Cyclopes",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 2,
                MovementRate = 15,
                HitDice = [16],
                Alignment = ["Neutral"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Brontosaurs",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 5,
                MovementRate = 6,
                HitDice = [32],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Mosasaur",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 5,
                MovementRate = 3,
                HitDice = [14],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Pterodactyls",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 5,
                MovementRate = 3,
                HitDice = [new Random().Next(2, 8)],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Stegosaurs",
                NumberAppearing = new Random().Next(2, 9),
                ArmorClass = 2,
                MovementRate = 6,
                HitDice = [8],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Triceratops",
                NumberAppearing = new Random().Next(2, 9),
                ArmorClass = 2,
                MovementRate = 9,
                HitDice = [16],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Tyrannosaurus Rex",
                NumberAppearing = new Random().Next(1, 3),
                ArmorClass = 5,
                MovementRate = 15,
                HitDice = [20],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Deinonychus",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 5,
                MovementRate = 21,
                HitDice = [4],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Djinni",
                NumberAppearing = 1,
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [7, 1],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Dogs",
                NumberAppearing = new Random().Next(4, 17),
                ArmorClass = 7,
                MovementRate = 15,
                HitDice = [1],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Doppelgangers",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 5,
                MovementRate = 9,
                HitDice = [4],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Dragon Turtles",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 2,
                MovementRate = 3,
                HitDice = [12],
                Alignment = ["Neutral"],
                TreasureType = "H"
            },
            new Bestiary
            {
                Name = "Black Dragon",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 3,
                MovementRate = 15,
                HitDice = [new Random().Next(2, 13)],
                Alignment = ["Chaotic"],
                TreasureType = "H"
            },
            new Bestiary
            {
                Name = "Blue Dragon",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 3,
                MovementRate = 15,
                HitDice = [new Random().Next(2, 15)],
                Alignment = ["Chaotic"],
                TreasureType = "H"
            },
            new Bestiary
            {
                Name = "Golden Dragon",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 3,
                MovementRate = 15,
                HitDice = [new Random().Next(2, 17)],
                Alignment = ["Lawful"],
                TreasureType = "H"
            },
            new Bestiary
            {
                Name = "Green Dragon",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 3,
                MovementRate = 15,
                HitDice = [new Random().Next(2, 14)],
                Alignment = ["Chaotic"],
                TreasureType = "H"
            },
            new Bestiary
            {
                Name = "Red Dragon",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 3,
                MovementRate = 15,
                HitDice = [new Random().Next(2, 16)],
                Alignment = ["Chaotic"],
                TreasureType = "H"
            },
            new Bestiary
            {
                Name = "White Dragon",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 3,
                MovementRate = 15,
                HitDice = [new Random().Next(2, 12)],
                Alignment = ["Chaotic"],
                TreasureType = "H"
            },
            new Bestiary
            {
                Name = "Dryads",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 5,
                MovementRate = 12,
                HitDice = [2],
                Alignment = ["Lawful", "Neutral"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Dwarfs",
                NumberAppearing = new Random().Next(2, 13),
                ArmorClass = 4,
                MovementRate = 9,
                HitDice = [1],
                Alignment = ["Lawful", "Neutral"],
                TreasureType = "G"
            },
            new Bestiary
            {
                Name = "Efreeti",
                NumberAppearing = 1,
                ArmorClass = 4,
                MovementRate = 16,
                HitDice = [10],
                Alignment = ["Chaotic"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Air Elemental",
                NumberAppearing = 1,
                ArmorClass = 3,
                MovementRate = 36,
                HitDice = [new Random().Next(8, 17)],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Earth Elemental",
                NumberAppearing = 1,
                ArmorClass = 3,
                MovementRate = 6,
                HitDice = [new Random().Next(8, 17)],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Fire Elemental",
                NumberAppearing = 1,
                ArmorClass = 3,
                MovementRate = 12,
                HitDice = [new Random().Next(8, 17)],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Water Elemental",
                NumberAppearing = 1,
                ArmorClass = 3,
                MovementRate = 6, // 18 in water
                HitDice = [new Random().Next(8, 17)],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Elves",
                NumberAppearing = new Random().Next(2, 13),
                ArmorClass = 7,
                MovementRate = 12,
                HitDice = [1],
                Alignment = ["Lawful", "Neutral"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Giant Fish",
                NumberAppearing = new Random().Next(2, 13),
                ArmorClass = 5,
                MovementRate = 30, // Only in water
                HitDice = [new Random().Next(4, 10)],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Gargoyles",
                NumberAppearing = new Random().Next(1, 11),
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [4],
                Alignment = ["Chaotic"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Gelatinous Cube",
                NumberAppearing = 1,
                ArmorClass = 8,
                MovementRate = 6,
                HitDice = [4],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Ghouls",
                NumberAppearing = new Random().Next(1, 13),
                ArmorClass = 7,
                MovementRate = 9,
                HitDice = [2],
                Alignment = ["Chaotic"],
                TreasureType = "B"
            },
            new Bestiary
            {
                Name = "Cloud Giant",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 3,
                MovementRate = 15,
                HitDice = [12, 2],
                Alignment = ["Neutral"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Fire Giant",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 3,
                MovementRate = 12,
                HitDice = [11, 3],
                Alignment = ["Chaotic"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Frost Giant",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 4,
                MovementRate = 12,
                HitDice = [10, 1],
                Alignment = ["Chaotic"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Hill Giant",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 4,
                MovementRate = 12,
                HitDice = [8],
                Alignment = ["Chaotic"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Stone Giant",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 2,
                MovementRate = 12,
                HitDice = [9],
                Alignment = ["Neutral"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Storm Giant",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 2,
                MovementRate = 15,
                HitDice = [15],
                Alignment = ["Neutral"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Gnolls",
                NumberAppearing = new Random().Next(2, 11),
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [2],
                Alignment = ["Chaotic"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Gnomes",
                NumberAppearing = new Random().Next(2, 13),
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [1],
                Alignment = ["Lawful", "Neutral"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Goblins",
                NumberAppearing = new Random().Next(2, 21),
                ArmorClass = 7,
                MovementRate = 9,
                HitDice = [1],
                Alignment = ["Chaotic"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Clay Golem",
                NumberAppearing = 1,
                ArmorClass = 2,
                MovementRate = 6,
                HitDice = [12],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Flesh Golem",
                NumberAppearing = 1,
                ArmorClass = 9,
                MovementRate = 9,
                HitDice = [9],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Gorgons",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 3,
                MovementRate = 12,
                HitDice = [8],
                Alignment = ["Chaotic"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Gothrogs",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 3,
                MovementRate = 9,
                HitDice = [10],
                Alignment = ["Chaotic"],
                TreasureType = "F"
            },
            new Bestiary
            {
                Name = "Gray Ooze",
                NumberAppearing = 1,
                ArmorClass = 9,
                MovementRate = 3,
                HitDice = [3],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Green Slime",
                NumberAppearing = 1,
                ArmorClass = 9,
                MovementRate = null,
                HitDice = [3],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Griffons",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 4,
                MovementRate = 16,
                HitDice = [7],
                Alignment = ["Neutral"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Halflings",
                NumberAppearing = new Random().Next(2, 9),
                ArmorClass = 7,
                MovementRate = 9,
                HitDice = [1],
                Alignment = ["Lawful", "Neutral"],
                TreasureType = "B"
            },
            new Bestiary
            {
                Name = "Hippogriffs",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 6,
                MovementRate = 20,
                HitDice = [3, 1],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Hobgoblins",
                NumberAppearing = new Random().Next(2, 13),
                ArmorClass = 5,
                MovementRate = 9,
                HitDice = [1, 1],
                Alignment = ["Chaotic"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Hydras",
                NumberAppearing = new Random().Next(1, 3),
                ArmorClass = 5,
                MovementRate = 12,
                HitDice = [new Random().Next(5, 13)],
                Alignment = ["Neutral"],
                TreasureType = "B"
            },
            new Bestiary
            {
                Name = "Invisible Stalker",
                NumberAppearing = 1,
                ArmorClass = 2,
                MovementRate = 12,
                HitDice = [8],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Juggernaut",
                NumberAppearing = 1,
                ArmorClass = 2,
                MovementRate = 9,
                HitDice = [37],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Kobolds",
                NumberAppearing = new Random().Next(2, 21),
                ArmorClass = 7,
                MovementRate = 6,
                HitDice = null,
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Giant Leeches",
                NumberAppearing = new Random().Next(2, 13),
                ArmorClass = 8,
                MovementRate = 6,
                HitDice = [2],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Lions",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [5, 2],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Spotted Lions",
                NumberAppearing = new Random().Next(2, 9),
                ArmorClass = 5,
                MovementRate = 12,
                HitDice = [6, 2],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Iron Living Statue",
                NumberAppearing = 1,
                ArmorClass = 2,
                MovementRate = 6,
                HitDice = [18],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Stone Living Statue",
                NumberAppearing = 1,
                ArmorClass = 5,
                MovementRate = 6,
                HitDice = [14],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Giant Lizards",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 5,
                MovementRate = 15,
                HitDice = [3, 1],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Large Lizards",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 8,
                MovementRate = 12,
                HitDice = null,
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Lizardmen",
                NumberAppearing = new Random().Next(2, 9),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [2, 1],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Werebears",
                NumberAppearing = new Random().Next(1, 11),
                ArmorClass = 3,
                MovementRate = 9,
                HitDice = [6],
                Alignment = ["Lawful", "Neutral"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Wereboars",
                NumberAppearing = new Random().Next(1, 11),
                ArmorClass = 5,
                MovementRate = 12,
                HitDice = [4, 1],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Weretigers",
                NumberAppearing = new Random().Next(1, 11),
                ArmorClass = 4,
                MovementRate = 12,
                HitDice = [5],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Werewolves",
                NumberAppearing = new Random().Next(1, 11),
                ArmorClass = 6,
                MovementRate = 15,
                HitDice = [4],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Manticoras",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 5,
                MovementRate = 12,
                HitDice = [6, 1],
                Alignment = ["Chaotic"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Mastadons",
                NumberAppearing = new Random().Next(1, 13),
                ArmorClass = 6,
                MovementRate = 15,
                HitDice = [12],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Medusae",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 7,
                MovementRate = 9,
                HitDice = [4],
                Alignment = ["Chaotic"],
                TreasureType = "F"
            },
            new Bestiary
            {
                Name = "Bandits",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 8,
                MovementRate = 12,
                HitDice = [1],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "A1"
            },
            new Bestiary
            {
                Name = "Berserkers",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 9,
                MovementRate = 12,
                HitDice = [1, 1],
                Alignment = ["Neutral"],
                TreasureType = "A1"
            },
            new Bestiary
            {
                Name = "Brigands",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [1],
                Alignment = ["Chaotic"],
                TreasureType = "A1"
            },
            new Bestiary
            {
                Name = "Buccaneers",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 8,
                MovementRate = 12,
                HitDice = [1],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "A3"
            },
            new Bestiary
            {
                Name = "Dervishes",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 8,
                MovementRate = 12,
                HitDice = [1, 1],
                Alignment = ["Lawful"],
                TreasureType = "A2"
            },
            new Bestiary
            {
                Name = "Mercenaries",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [1, 1],
                Alignment = ["Neutral"],
                TreasureType = "A3"
            },
            new Bestiary
            {
                Name = "Nomads",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 8,
                MovementRate = 12,
                HitDice = [1],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "A2"
            },
            new Bestiary
            {
                Name = "Pirates",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 8,
                MovementRate = 12,
                HitDice = [1],
                Alignment = ["Chaotic"],
                TreasureType = "A3"
            },
            new Bestiary
            {
                Name = "Zealots",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 9,
                MovementRate = 12,
                HitDice = [1, 1],
                Alignment = ["Chaotic"],
                TreasureType = "A2"
            },
            new Bestiary
            {
                Name = "Mermen",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 7,
                MovementRate = 15,
                HitDice = [1, 1],
                Alignment = ["Neutral"],
                TreasureType = "A3"
            },
            new Bestiary
            {
                Name = "Minotaurs",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [6],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Mummies",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 4,
                MovementRate = 6,
                HitDice = [5, 1],
                Alignment = ["Chaotic"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Nixies",
                NumberAppearing = new Random().Next(2, 21),
                ArmorClass = 7,
                MovementRate = 12,
                HitDice = [1],
                Alignment = ["Neutral"],
                TreasureType = "B"
            },
            new Bestiary
            {
                Name = "Ochre Jelly",
                NumberAppearing = 1,
                ArmorClass = 9,
                MovementRate = 3,
                HitDice = [5],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Giant Octopi",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 7,
                MovementRate = 9,
                HitDice = [4],
                Alignment = ["Neutral"],
                TreasureType = "A3"
            },
            new Bestiary
            {
                Name = "Ogres",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [4, 1],
                Alignment = ["Chaotic"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Orcs",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 7,
                MovementRate = 9,
                HitDice = [1],
                Alignment = ["Chaotic"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Pegasi",
                NumberAppearing = new Random().Next(1, 13),
                ArmorClass = 6,
                MovementRate = 24,
                HitDice = [2, 2],
                Alignment = ["Lawful", "Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Pixies",
                NumberAppearing = new Random().Next(2, 21),
                ArmorClass = 6,
                MovementRate = 18,
                HitDice = [1],
                Alignment = ["Neutral"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Purple Worms",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [15],
                Alignment = ["Neutral"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Giant Rats",
                NumberAppearing = new Random().Next(2, 13),
                ArmorClass = 7,
                MovementRate = 12,
                HitDice = [10],
                Alignment = ["Neutral"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Robots",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 3,
                MovementRate = 6,
                HitDice = [7],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Young Rocs",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 6,
                MovementRate = 48,
                HitDice = [6],
                Alignment = ["Neutral"],
                TreasureType = "I"
            },
            new Bestiary
            {
                Name = "Adult Rocs",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 5,
                MovementRate = 42,
                HitDice = [12],
                Alignment = ["Neutral"],
                TreasureType = "I"
            },
            new Bestiary
            {
                Name = "Ancient Rocs",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 4,
                MovementRate = 36,
                HitDice = [18],
                Alignment = ["Neutral"],
                TreasureType = "I"
            },
            new Bestiary
            {
                Name = "Sabre Toothed Tigers",
                NumberAppearing = new Random().Next(1, 3),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [7, 2],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Salamanders",
                NumberAppearing = new Random().Next(2, 6),
                ArmorClass = 5,
                MovementRate = 9,
                HitDice = [7, 3],
                Alignment = ["Chaotic"],
                TreasureType = "F"
            },
            new Bestiary
            {
                Name = "Giant Scorpions",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 3,
                MovementRate = 15,
                HitDice = [5, 4],
                Alignment = ["Neutral"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Leviathan",
                NumberAppearing = 1,
                ArmorClass = 4,
                MovementRate = 18,
                HitDice = [45],
                Alignment = ["Neutral"],
                TreasureType = "H"
            },
            new Bestiary
            {
                Name = "Kraken",
                NumberAppearing = 1,
                ArmorClass = 2,
                MovementRate = 18,
                HitDice = [30],
                Alignment = ["Neutral"],
                TreasureType = "G"
            },
            new Bestiary
            {
                Name = "Sea Serpents",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 6,
                MovementRate = 21,
                HitDice = [15],
                Alignment = ["Neutral"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Shadows",
                NumberAppearing = new Random().Next(1, 11),
                ArmorClass = 7,
                MovementRate = 9,
                HitDice = [2, 2],
                Alignment = ["Chaotic"],
                TreasureType = "F"
            },
            new Bestiary
            {
                Name = "Skeletons",
                NumberAppearing = new Random().Next(3, 31),
                ArmorClass = 8,
                MovementRate = 6,
                HitDice = null,
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Giant Snakes",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [7],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Large Snakes",
                NumberAppearing = new Random().Next(2, 17),
                ArmorClass = 8,
                MovementRate = 6,
                HitDice = null,
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Spectres",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 3,
                MovementRate = 15,
                HitDice = [6],
                Alignment = ["Chaotic"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Giant Spiders",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 5,
                MovementRate = 3,
                HitDice = [4, 4],
                Alignment = ["Chaotic"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Large Spiders",
                NumberAppearing = new Random().Next(1, 11),
                ArmorClass = 8,
                MovementRate = 6,
                HitDice = null,
                Alignment = ["Neutral"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Giant Squid",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 7,
                MovementRate = 12,
                HitDice = [6],
                Alignment = ["Neutral"],
                TreasureType = "A3"
            },
            new Bestiary
            {
                Name = "Thulls",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [3],
                Alignment = ["Chaotic"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Tigers",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [5, 4],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Titanotheres",
                NumberAppearing = new Random().Next(1, 13),
                ArmorClass = 7,
                MovementRate = 12,
                HitDice = [12],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Titan",
                NumberAppearing = 1,
                ArmorClass = 2,
                MovementRate = 18,
                HitDice = [21],
                Alignment = ["Lawful", "Neutral", "Chaotic"],
                TreasureType = "A1"
            },
            new Bestiary
            {
                Name = "Giant Toads",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 6,
                MovementRate = 6,
                HitDice = [2, 4],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Treants",
                NumberAppearing = new Random().Next(1, 11),
                ArmorClass = 2,
                MovementRate = 6,
                HitDice = [8],
                Alignment = ["Lawful", "Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Trolls",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 5,
                MovementRate = 12,
                HitDice = [6, 3],
                Alignment = ["Chaotic"],
                TreasureType = "D"
            },
            new Bestiary
            {
                Name = "Unicorns",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 3,
                MovementRate = 24,
                HitDice = [4],
                Alignment = ["Lawful"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Vampires",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 2,
                MovementRate = 12,
                HitDice = [8],
                Alignment = ["Chaotic"],
                TreasureType = "F"
            },
            new Bestiary
            {
                Name = "Giant Weasels",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 6,
                MovementRate = 15,
                HitDice = [2],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Wight Apes",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 6,
                MovementRate = 12,
                HitDice = [5, 2],
                Alignment = ["Neutral"],
                TreasureType = "C"
            },
            new Bestiary
            {
                Name = "Wights",
                NumberAppearing = new Random().Next(1, 13),
                ArmorClass = 6,
                MovementRate = 9,
                HitDice = [3],
                Alignment = ["Chaotic"],
                TreasureType = "B"
            },
            new Bestiary
            {
                Name = "Wolves",
                NumberAppearing = new Random().Next(1, 11),
                ArmorClass = 7,
                MovementRate = 18,
                HitDice = [1],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Giant Wolves",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 6,
                MovementRate = 18,
                HitDice = [2, 2],
                Alignment = ["Chaotic"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Woolly Mammoths",
                NumberAppearing = new Random().Next(1, 13),
                ArmorClass = 5,
                MovementRate = 15,
                HitDice = [13],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Woolly Rhinoceroses",
                NumberAppearing = new Random().Next(1, 5),
                ArmorClass = 5,
                MovementRate = 12,
                HitDice = [10],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Wraiths",
                NumberAppearing = new Random().Next(1, 9),
                ArmorClass = 4,
                MovementRate = 12,
                HitDice = [4],
                Alignment = ["Chaotic"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Wyverns",
                NumberAppearing = new Random().Next(1, 7),
                ArmorClass = 4,
                MovementRate = 24,
                HitDice = [7],
                Alignment = ["Neutral", "Chaotic"],
                TreasureType = "E"
            },
            new Bestiary
            {
                Name = "Yellow Mold",
                NumberAppearing = 1,
                ArmorClass = 9,
                MovementRate = null,
                HitDice = [3],
                Alignment = ["Neutral"],
                TreasureType = null
            },
            new Bestiary
            {
                Name = "Zombies",
                NumberAppearing = new Random().Next(3, 31),
                ArmorClass = 9,
                MovementRate = 6,
                HitDice = [1],
                Alignment = ["Neutral"],
                TreasureType = null
            }
        };
    }
}
