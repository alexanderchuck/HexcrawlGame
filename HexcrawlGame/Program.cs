using HexcrawlGame.PCs;

Console.WriteLine("Welcome to Hexcrawl Survival!");
Console.WriteLine("What is your name?");
string? playerName = Console.ReadLine();
while (string.IsNullOrEmpty(playerName))
{
    Console.WriteLine("Please enter a valid name.");
    playerName = Console.ReadLine();
}
Console.WriteLine("Hello, " + playerName + ". Are you ready to start your adventure?");
bool? confirmStart = null;
while (confirmStart == null)
{
    Console.WriteLine("Enter 'Y' to start or 'N' to exit.");
    var response = Console.ReadKey(true).Key;
    if (response == ConsoleKey.Y)
    {
        confirmStart = true;
    }
    else if (response == ConsoleKey.N)
    {
        confirmStart = false;
    }
    else Console.WriteLine("Please enter a valid choice.");
}
if (confirmStart == true)
{
    Console.WriteLine("Your story unfolds as you step through the tavern threshold into the cool morning air.");
}
if (confirmStart == false)
{
    Console.WriteLine("Perhaps another time then adventurer. Take care.");
    Environment.Exit(0);
}
Console.WriteLine("The sun is rising over the world of Aldon, as the residents of Saddlebrook go about their morning routines. Before you leave town, let's go over some character details...");
Console.WriteLine("Which class best describes you?");
bool? chosenClass = null;

var classList = BaseCharacter.classes.ToList();
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
        Console.WriteLine("So you are a " + classList[0].Value + "? Ah, yes. That sounds familiar!");
    }
    else if (response == ConsoleKey.D2 || response == ConsoleKey.NumPad2)
    {
        chosenClass = true;
        Console.WriteLine("So you are a " + classList[1].Value + "? Ah, yes. That sounds familiar!");
    }
    else if (response == ConsoleKey.D3 || response == ConsoleKey.NumPad3)
    {
        chosenClass = true;
        Console.WriteLine("So you are a " + classList[2].Value + "? Ah, yes. That sounds familiar!");
    }
    else
    {
        Console.WriteLine("Please enter a valid choice.");
    }
}
Console.WriteLine("Are you sure this the class you want?");
bool? confirmClass = null;
while (confirmClass == null)
{
    Console.WriteLine("Enter 'Y' to confirm or 'N' to choose again.");
    var response = Console.ReadKey(true).Key;
    if (response == ConsoleKey.Y)
    {
        confirmClass = true;
    }
    else if (response == ConsoleKey.N)
    {
        confirmClass = false;
        chosenClass = null; // Reset chosen class to allow re-selection
    }
    else Console.WriteLine("Please enter a valid choice.");
}