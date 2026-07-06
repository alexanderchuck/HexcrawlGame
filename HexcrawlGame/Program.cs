using HexcrawlGame.Scripts;

// MECHANIC CHECKLIST:

// Persistent Game Data (SQL Server)

// Main Menu

// Pause Menu

// Character Creation ✔️

// Item List ✔️

// Spell List ✔️

// Bestiary ✔️

// Party Formation
// -> Array of PCs

// New Day Protocol

// Spell Preparation Function

// Marching Order

// Hirelings

// Combat (Melee/Ranged)

// Combat (Spellcasting)

// Resource Management

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