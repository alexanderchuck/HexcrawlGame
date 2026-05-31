using HexcrawlGame.PCs;
using HexcrawlGame.Environment;

Console.WriteLine("<----------xxx ~*~ xxx---------->");
Console.WriteLine();
Console.WriteLine("Welcome to Hexcrawl Survival!");
Console.WriteLine();
Console.WriteLine("<----------xxx ~*~ xxx---------->");
Console.WriteLine();

// Player character construction and setup
BaseCharacter primaryCharacter = new BaseCharacter();

Console.WriteLine("What is your name?");
Console.WriteLine();

// Assings a string value to the Name property via user input.
primaryCharacter.Name = Console.ReadLine();
while (string.IsNullOrEmpty(primaryCharacter.Name))
{
    Console.WriteLine("Please enter a valid name.");
    primaryCharacter.Name = Console.ReadLine();
}
Console.WriteLine();

Console.WriteLine("Hello, " + primaryCharacter.Name + ". Are you ready to start your adventure?");
Console.WriteLine();

// Loop to confirm player is ready to start the game. Exits if player is not ready.
bool? confirmStart = null;
while (confirmStart == null)
{
    Console.WriteLine("Enter 'Y' to start or 'N' to exit.");
    Console.WriteLine();
    var response = Console.ReadKey(true).Key;
    if (response == ConsoleKey.Y)
    {
        confirmStart = true;
    }
    else if (response == ConsoleKey.N)
    {
        confirmStart = false;
    }
    else
    {
        Console.WriteLine("Please enter a valid choice.");
        Console.WriteLine();
    }
}
if (confirmStart == true)
{
    Console.WriteLine("Your story unfolds as you step through the tavern threshold into the cool morning air.");
    Console.WriteLine();
}
if (confirmStart == false)
{
    Console.WriteLine("Perhaps another time then adventurer. Take care.");
    Environment.Exit(0);
}

// Setting the scene for character creation
Console.WriteLine("The world of Aldon appears to be waking up, as the residents of Saddlebrook begin to go about their morning routines. " +
    "Before you leave town, let's go over some character details...");
Console.WriteLine();

// Attribute generation for player character. Simulating rolling 3d6 down the line.
Console.WriteLine("First, we'll need to determine your attribute scores. There are six attributes in total: Strength, Intelligence, Wisdom, Constitution, Dexterity and Charisma. " +
    "Each attribute has a possible score range of 3-18, with Strength, Intelligence and Wisdom being prime requisites for some of the classes we'll get to next.");
Console.WriteLine();

// Loop to assign random attribute scores to each attribute in the attributes dictionary.
// Scores are generated using Random.Next() with a range of 3-19 (exclusive upper bound).
var attributeList = primaryCharacter.attributes.Keys.ToList();
Random attributeScore = new Random();
foreach (var attribute in attributeList)
{
    Console.WriteLine(attribute + ": " + (primaryCharacter.attributes[attribute] = attributeScore.Next(3, 19)));
}
Console.WriteLine();

// Explanation of classes and prime requisites for player character.
Console.WriteLine("When choosing your class, keep in mind that Fighters rely on Strength as their prime requisite, Magic-Users rely on Intelligence and Clerics rely on Wisdom."
    + "While this does not affect in-game class performance, prime requisites determine whether a bonus or penalty is applied to experience points earned.");
Console.WriteLine();

Console.WriteLine("Which class best describes you?");
Console.WriteLine();

// Loop to allow player to choose a class from the list of available classes. Exits loop once a valid class is chosen and confirmed by the player.
// Convert the classes dictionary to a list in order to target values by index for display and selection purposes.
// This allows us to maintain the original dictionary structure while providing a user-friendly interface for class selection.
bool? chosenClass = null;
var classList = BaseCharacter.classes.ToList();
while (chosenClass == null)
{ 
    int num = 1;
    foreach (var characterClass in BaseCharacter.classes)
    {
        Console.WriteLine(num + ". " + characterClass.Key);
        num++;
    }
    var response = Console.ReadKey(true).Key;
    if (response == ConsoleKey.D1 || response == ConsoleKey.NumPad1)
    {
        chosenClass = true;
        Console.WriteLine();
        Console.WriteLine("So you are a " + classList[0].Value + "? Ah, yes. That sounds familiar!");
        Console.WriteLine();
        primaryCharacter.CharacterClass = classList[0].Value;
    }
    else if (response == ConsoleKey.D2 || response == ConsoleKey.NumPad2)
    {
        chosenClass = true;
        Console.WriteLine();
        Console.WriteLine("So you are a " + classList[1].Value + "? Ah, yes. That sounds familiar!");
        Console.WriteLine();
        primaryCharacter.CharacterClass = classList[1].Value;
    }
    else if (response == ConsoleKey.D3 || response == ConsoleKey.NumPad3)
    {
        chosenClass = true;
        Console.WriteLine();
        Console.WriteLine("So you are a " + classList[2].Value + "? Ah, yes. That sounds familiar!");
        Console.WriteLine();
        primaryCharacter.CharacterClass = classList[2].Value;
    }
    else
    {
        Console.WriteLine("Please enter a valid choice.");
        Console.WriteLine();
    }

    Console.WriteLine("Are you sure this the class you want?");
    Console.WriteLine();

    // Loop to confirm chosen class. Exits loop once player confirms or denies their class choice.
    bool? confirmClass = null;
    while (confirmClass == null)
    {
        Console.WriteLine("Enter 'Y' to confirm or 'N' to choose again.");
        Console.WriteLine();
        var confirmResponse = Console.ReadKey(true).Key;
        if (confirmResponse == ConsoleKey.Y)
        {
            confirmClass = true;
        }
        else if (confirmResponse == ConsoleKey.N)
        {
            confirmClass = false;
            chosenClass = null; // Reset chosen class to allow re-selection
            primaryCharacter.CharacterClass = string.Empty; // Reset primary player class
        }
        else
        {
            Console.WriteLine("Please enter a valid choice.");
            Console.WriteLine();
        }
        
    }
}

Console.WriteLine("Alright then. The world can always use another Level " + primaryCharacter.Level + " " + primaryCharacter.CharacterClass + "!");
Console.WriteLine();

Console.WriteLine("How would you describe your alignment?");
Console.WriteLine();

// Loop to allow player to choose an alignment from the list of available alignments. Exits loop once a valid alignment is chosen.
bool? chosenAlignment = null;
var alignmentList = BaseCharacter.alignment.Keys.ToList();
while (chosenAlignment == null)
{
    int num = 1;
    foreach (var alignment in alignmentList)
    {
        Console.WriteLine(num + "." + alignment);
        num++;
    }
    var response = Console.ReadKey(true).Key;
    if (response == ConsoleKey.D1 || response == ConsoleKey.NumPad1)
    {
        chosenAlignment = true;
        Console.WriteLine();
        Console.WriteLine("Interesting. " + alignmentList[0] + " is it?");
        Console.WriteLine();
        primaryCharacter.Alignment = alignmentList[0];
    }
    else if (response == ConsoleKey.D2 || response == ConsoleKey.NumPad2)
    {
        chosenAlignment = true;
        Console.WriteLine();
        Console.WriteLine("Interesting. " + alignmentList[1] + " is it?");
        Console.WriteLine();
        primaryCharacter.Alignment = alignmentList[1];
    }
    else if (response == ConsoleKey.D3 || response == ConsoleKey.NumPad3)
    {
        chosenAlignment = true;
        Console.WriteLine();
        Console.WriteLine("Interesting. " + alignmentList[2] + " is it?");
        Console.WriteLine();
        primaryCharacter.Alignment = alignmentList[2];
    }
    else
    {
        Console.WriteLine("Please enter a valid choice.");
        Console.WriteLine();
    }
}

// Loop to confirm chosen alignment. Exits loop once player confirms or denies their alignment choice.
bool? confirmAlignment = null;
while (confirmAlignment == null)
{
    Console.WriteLine("Are you sure this the alignment you want?");
    Console.WriteLine();
    Console.WriteLine("Enter 'Y' to confirm or 'N' to choose again.");
    Console.WriteLine();
    var confirmResponse = Console.ReadKey(true).Key;
    if (confirmResponse == ConsoleKey.Y)
    {
        confirmAlignment = true;
    }
    else if (confirmResponse == ConsoleKey.N)
    {
        confirmAlignment = false;
        chosenAlignment = null; // Reset chosen alignment to allow re-selection
        primaryCharacter.Alignment = string.Empty; // Reset primary player alignment
    }
    else
    {
        Console.WriteLine("Please enter a valid choice.");
        Console.WriteLine();
    }
}

Console.WriteLine("We'll have to wait and see how a " + primaryCharacter.Alignment + " alignment affects the world around you.");
Console.WriteLine();

// Explanation of health and how it's determined for player character.
Console.WriteLine("Next, let's find out your starting health. This is done by rolling a number of predetermined six-sided dice " +
    "based on your current level.");
Console.WriteLine();

// Loop to determine starting health for player character based on class and level. Uses the HDProgression dictionary in each class to determine health.
var fighterHD = Fighter.HDProgression.ToList();
var clericHD = Cleric.HDProgression.ToList();
var magicUserHD = MagicUser.HDProgression.ToList();
if (primaryCharacter.CharacterClass == "Fighter")
{
    Console.WriteLine("As a Fighter, we'll roll 1d6 + 2. Your starting health is...");
    Console.WriteLine();

    primaryCharacter.Health = fighterHD[primaryCharacter.Level - 1].Value;
    Console.WriteLine("HP: " + primaryCharacter.Health);
}
else if (primaryCharacter.CharacterClass == "Cleric")
{
    Console.WriteLine("As a Cleric, we'll roll 1d6. Your starting health is...");
    Console.WriteLine();

    primaryCharacter.Health = clericHD[primaryCharacter.Level - 1].Value;
    Console.WriteLine("HP: " + primaryCharacter.Health);
}
else if (primaryCharacter.CharacterClass == "Magic-User")
{
    Console.WriteLine("As a Magic-User, we'll roll 1d6. Your starting health is...");
    Console.WriteLine();

    primaryCharacter.Health = magicUserHD[primaryCharacter.Level - 1].Value;
    Console.WriteLine("HP: " + primaryCharacter.Health);
}

