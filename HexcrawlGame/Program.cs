using HexcrawlGame.PCs;
using HexcrawlGame.Environment;
using System.Linq;
using HexcrawlGame.Scripts;

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

PrimaryCharacterCreation newCharacter = new PrimaryCharacterCreation();

newCharacter.CreateCharacter();