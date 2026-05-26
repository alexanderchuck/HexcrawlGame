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
bool? choice = null;
while (choice == null)
{
    Console.WriteLine("Enter 'Y' to start or 'N' to exit.");
    var response = Console.ReadKey(true).Key;
    if (response == ConsoleKey.Y)
    {
        choice = true;
    }
    else if (response == ConsoleKey.N)
    {
        choice = false;
    }
    else Console.WriteLine("Please enter a valid choice.");
}
if (choice == true)
{
    Console.WriteLine("Your story unfolds as you step through the tavern threshold into the cool morning air.");
}
if (choice == false)
{
    Console.WriteLine("Perhaps another time then adventurer. Take care.");
    Environment.Exit(0);
}
Console.WriteLine("The sun is rising over the world of Aldon, as the residents of Saddlebrook go about their morning routines. Before you leave town, let's go over some character details...");
Console.WriteLine("Which class best describes you?");

int num = 1;
foreach (var characterClass in BaseCharacter.classes)
{
    Console.WriteLine(num + ". " + characterClass.Key);
    num += 1;
}