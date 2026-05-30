using HexcrawlGame.PCs;
using HexcrawlGame.Environment;

Console.WriteLine("<----------xxx ~*~ xxx---------->");
Console.WriteLine();
Console.WriteLine("Welcome to Hexcrawl Survival!");
Console.WriteLine();
Console.WriteLine("<----------xxx ~*~ xxx---------->");
Console.WriteLine();

BaseCharacter primaryCharacter = new BaseCharacter();

Console.WriteLine("What is your name?");
Console.WriteLine();
primaryCharacter.Name = Console.ReadLine();
while (string.IsNullOrEmpty(primaryCharacter.Name))
{
    Console.WriteLine("Please enter a valid name.");
    primaryCharacter.Name = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Hello, " + primaryCharacter.Name + ". Are you ready to start your adventure?");
Console.WriteLine();
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

Console.WriteLine("The world of Aldon appears to be waking up, as the residents of Saddlebrook begin to go about their morning routines. Before you leave town, let's go over some character details...");
Console.WriteLine();

Console.WriteLine("Which class best describes you?");
Console.WriteLine();

bool? chosenClass = null;
var classList = BaseCharacter.classes.ToList();
var primaryPlayerClass = string.Empty;
while (chosenClass == null)
{ 
    int num = 1;
    foreach (var characterClass in BaseCharacter.classes)
    {
        Console.WriteLine(num + ". " + characterClass.Key);
        num += 1;
    }
    var response = Console.ReadKey(true).Key;
    if (response == ConsoleKey.D1 || response == ConsoleKey.NumPad1)
    {
        chosenClass = true;
        Console.WriteLine();
        Console.WriteLine("So you are a " + classList[0].Value + "? Ah, yes. That sounds familiar!");
        Console.WriteLine();
        primaryPlayerClass = classList[0].Value;
    }
    else if (response == ConsoleKey.D2 || response == ConsoleKey.NumPad2)
    {
        chosenClass = true;
        Console.WriteLine();
        Console.WriteLine("So you are a " + classList[1].Value + "? Ah, yes. That sounds familiar!");
        Console.WriteLine();
        primaryPlayerClass = classList[1].Value;
    }
    else if (response == ConsoleKey.D3 || response == ConsoleKey.NumPad3)
    {
        chosenClass = true;
        Console.WriteLine();
        Console.WriteLine("So you are a " + classList[2].Value + "? Ah, yes. That sounds familiar!");
        Console.WriteLine();
        primaryPlayerClass = classList[2].Value;
    }
    else
    {
        Console.WriteLine("Please enter a valid choice.");
        Console.WriteLine();
    }
    Console.WriteLine("Are you sure this the class you want?");
    Console.WriteLine();
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
            primaryPlayerClass = string.Empty; // Reset primary player class
        }
        else
        {
            Console.WriteLine("Please enter a valid choice.");
            Console.WriteLine();
        }
        
    }
}
primaryCharacter.CharacterClass = primaryPlayerClass;

Console.WriteLine("Alright then. The world can always use one more " + primaryCharacter.CharacterClass + "!");
Console.WriteLine();