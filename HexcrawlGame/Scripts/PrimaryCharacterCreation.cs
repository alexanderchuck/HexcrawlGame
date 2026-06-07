using HexcrawlGame.Items;
using HexcrawlGame.PCs;
using System;
using System.Collections.Generic;
using System.Text;

namespace HexcrawlGame.Scripts
{
    public class PrimaryCharacterCreation
    {
        public void CreateCharacter()
        {
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
                return;
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

                Console.WriteLine("Are you sure this is the class you want?");
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

            // Loop to allow player to choose an alignment from the list of available alignments. Exits loop once a valid alignment is chosen.
            bool? chosenAlignment = null;
            var alignmentList = BaseCharacter.alignment.Keys.ToList();
            while (chosenAlignment == null && primaryCharacter.CharacterClass != "Cleric")
            {
                Console.WriteLine("How would you describe your alignment?");
                Console.WriteLine();
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

            if (primaryCharacter.CharacterClass == "Cleric")
            {
                primaryCharacter.Alignment = alignmentList[0];
                Console.WriteLine("Clerics are bound to a " + primaryCharacter.Alignment + " way of life.");
                Console.WriteLine();
            }

            // Loop to confirm chosen alignment. Exits loop once player confirms or denies their alignment choice.
            bool? confirmAlignment = null;
            while (confirmAlignment == null && primaryCharacter.CharacterClass != "Cleric")
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
                Console.WriteLine();
            }
            else if (primaryCharacter.CharacterClass == "Cleric")
            {
                Console.WriteLine("As a Cleric, we'll roll 1d6. Your starting health is...");
                Console.WriteLine();

                primaryCharacter.Health = clericHD[primaryCharacter.Level - 1].Value;
                Console.WriteLine("HP: " + primaryCharacter.Health);
                Console.WriteLine();
            }
            else if (primaryCharacter.CharacterClass == "Magic-User")
            {
                Console.WriteLine("As a Magic-User, we'll roll 1d6. Your starting health is...");
                Console.WriteLine();

                primaryCharacter.Health = magicUserHD[primaryCharacter.Level - 1].Value;
                Console.WriteLine("HP: " + primaryCharacter.Health);
                Console.WriteLine();
            }

            // Generates 3d6 * 10 starting gold pieces for the player character.
            Console.WriteLine("Now it's time to count the money in your coin purse.");
            Console.WriteLine();
            var currentGold = new Random().Next(30, 181);
            primaryCharacter.currency["GP"] = currentGold;
            Console.WriteLine("You upturn the leather pouch and find " + currentGold + " gold pieces.");
            Console.WriteLine("That coin isn't going to spend itself. Let's buy some gear!");
            Console.WriteLine();

            Console.WriteLine("Weapons and armor are essential for Clerics and Fighters, but alas, Magic-Users have traded security for a menagerie of arcane tricks." +
                "Which piece of armor would you like to purchase?");
            Console.WriteLine();

            // Looping over and displaying items available in the appropriate Character Class starting armor dictionary.
            // Depending on starting gold, armor can be purchased and appended to the EquippedArmor array.
            // If there is enough gold leftover, users will have the option to buy a shield that is also appended.
            bool? chosenArmor = null;
            var clericArmor = Cleric.StartingArmor.ToList();
            var fighterArmor = Fighter.StartingArmor.ToList();
            var magicUserArmor = MagicUser.StartingArmor.ToList();
            while (chosenArmor == null && primaryCharacter.CharacterClass != "Magic-User")
            {
                int num = 1;
                if (primaryCharacter.CharacterClass == "Cleric")
                {
                    foreach (var armor in clericArmor)
                    {
                        Console.WriteLine(num + ". " + armor);
                        num++;
                    }
                    var response = Console.ReadKey(true).Key;
                    if (response == ConsoleKey.D1 || response == ConsoleKey.NumPad1)
                    {
                        chosenArmor = true;
                        primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>(clericArmor[0].Key).ToArray();
                        Console.WriteLine();
                    }
                    else if (response == ConsoleKey.D2 || response == ConsoleKey.NumPad2)
                    {
                        if (primaryCharacter.currency["GP"] >= clericArmor[1].Value)
                        {
                            chosenArmor = true;
                            primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>(clericArmor[1].Key).ToArray();
                            primaryCharacter.currency["GP"] -= clericArmor[1].Value;
                            Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                            Console.WriteLine();
                            if (primaryCharacter.currency["GP"] >= 15)
                            {
                                Console.WriteLine("Would you like to purchase a shield for 15 GP?");
                                Console.WriteLine();
                                Console.WriteLine("Press 'Y' if yes or 'N' if not.");
                                Console.WriteLine();
                                var purchaseShieldResponse = Console.ReadKey(true).Key;
                                if (purchaseShieldResponse == ConsoleKey.Y)
                                {
                                    primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>("Shield").ToArray();
                                    primaryCharacter.currency["GP"] -= 15;
                                    Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                                    Console.WriteLine();
                                }
                                else if (purchaseShieldResponse == ConsoleKey.N)
                                {
                                    break;
                                }
                            }
                        }
                        else Console.WriteLine("You don't have quite enough coin for this purchase.");
                        Console.WriteLine();
                    }
                    else if (response == ConsoleKey.D3 || response == ConsoleKey.NumPad3)
                    {
                        if (primaryCharacter.currency["GP"] >= clericArmor[2].Value)
                        {
                            chosenArmor = true;
                            primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>(clericArmor[2].Key).ToArray();
                            primaryCharacter.currency["GP"] -= clericArmor[2].Value;
                            Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                            Console.WriteLine();
                            if (primaryCharacter.currency["GP"] >= 15)
                            {
                                Console.WriteLine("Would you like to purchase a shield for 15 GP?");
                                Console.WriteLine();
                                Console.WriteLine("Press 'Y' if yes or 'N' if not.");
                                Console.WriteLine();
                                var purchaseShieldResponse = Console.ReadKey(true).Key;
                                if (purchaseShieldResponse == ConsoleKey.Y)
                                {
                                    primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>("Shield").ToArray();
                                    primaryCharacter.currency["GP"] -= 15;
                                    Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                                    Console.WriteLine();
                                }
                                else if (purchaseShieldResponse == ConsoleKey.N)
                                {
                                    break;
                                }
                            }
                        }
                        else Console.WriteLine("You don't have quite enough coin for this purchase.");
                        Console.WriteLine();
                    }
                    else if (response == ConsoleKey.D4 || response == ConsoleKey.NumPad3)
                    {
                        if (primaryCharacter.currency["GP"] >= clericArmor[3].Value)
                        {
                            chosenArmor = true;
                            primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>(clericArmor[3].Key).ToArray();
                            primaryCharacter.currency["GP"] -= clericArmor[3].Value;
                            Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                            Console.WriteLine();
                            if (primaryCharacter.currency["GP"] >= 15)
                            {
                                Console.WriteLine("Would you like to purchase a shield for 15 GP?");
                                Console.WriteLine();
                                Console.WriteLine("Press 'Y' if yes or 'N' if not.");
                                Console.WriteLine();
                                var purchaseShieldResponse = Console.ReadKey(true).Key;
                                if (purchaseShieldResponse == ConsoleKey.Y)
                                {
                                    primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>("Shield").ToArray();
                                    primaryCharacter.currency["GP"] -= 15;
                                    Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                                    Console.WriteLine();
                                }
                                else if (purchaseShieldResponse == ConsoleKey.N)
                                {
                                    break;
                                }
                            }
                        }
                        else Console.WriteLine("You don't have quite enough coin for this purchase.");
                        Console.WriteLine();
                    }

                    else Console.WriteLine("Please enter a valid choice.");
                }

                if (primaryCharacter.CharacterClass == "Fighter")
                {
                    foreach (var armor in fighterArmor)
                    {
                        Console.WriteLine(num + ". " + armor);
                        num++;
                    }
                    var response = Console.ReadKey(true).Key;
                    if (response == ConsoleKey.D1 || response == ConsoleKey.NumPad1)
                    {
                        chosenArmor = true;
                        primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>(fighterArmor[0].Key).ToArray();
                        Console.WriteLine();
                    }
                    else if (response == ConsoleKey.D2 || response == ConsoleKey.NumPad2)
                    {
                        if (primaryCharacter.currency["GP"] >= fighterArmor[1].Value)
                        {
                            chosenArmor = true;
                            primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>(fighterArmor[1].Key).ToArray();
                            primaryCharacter.currency["GP"] -= fighterArmor[1].Value;
                            Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                            Console.WriteLine();
                            if (primaryCharacter.currency["GP"] >= 15)
                            {
                                Console.WriteLine("Would you like to purchase a shield for 15 GP?");
                                Console.WriteLine();
                                Console.WriteLine("Press 'Y' if yes or 'N' if not.");
                                Console.WriteLine();
                                var purchaseShieldResponse = Console.ReadKey(true).Key;
                                if (purchaseShieldResponse == ConsoleKey.Y)
                                {
                                    primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>("Shield").ToArray();
                                    primaryCharacter.currency["GP"] -= 15;
                                    Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                                    Console.WriteLine();
                                }
                                else if (purchaseShieldResponse == ConsoleKey.N)
                                {
                                    break;
                                }
                            }
                        }
                        else Console.WriteLine("You don't have quite enough coin for this purchase.");
                        Console.WriteLine();
                    }
                    else if (response == ConsoleKey.D3 || response == ConsoleKey.NumPad3)
                    {
                        if (primaryCharacter.currency["GP"] >= fighterArmor[2].Value)
                        {
                            chosenArmor = true;
                            primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>(fighterArmor[2].Key).ToArray();
                            primaryCharacter.currency["GP"] -= fighterArmor[2].Value;
                            Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                            Console.WriteLine();
                            if (primaryCharacter.currency["GP"] >= 15)
                            {
                                Console.WriteLine("Would you like to purchase a shield for 15 GP?");
                                Console.WriteLine();
                                Console.WriteLine("Press 'Y' if yes or 'N' if not.");
                                Console.WriteLine();
                                var purchaseShieldResponse = Console.ReadKey(true).Key;
                                if (purchaseShieldResponse == ConsoleKey.Y)
                                {
                                    primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>("Shield").ToArray();
                                    primaryCharacter.currency["GP"] -= 15;
                                    Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                                    Console.WriteLine();
                                }
                                else if (purchaseShieldResponse == ConsoleKey.N)
                                {
                                    break;
                                }
                            }
                        }
                        else Console.WriteLine("You don't have quite enough coin for this purchase.");
                        Console.WriteLine();
                    }
                    else if (response == ConsoleKey.D4 || response == ConsoleKey.NumPad4)
                    {
                        if (primaryCharacter.currency["GP"] >= fighterArmor[3].Value)
                        {
                            chosenArmor = true;
                            primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>(fighterArmor[3].Key).ToArray();
                            primaryCharacter.currency["GP"] -= fighterArmor[3].Value;
                            Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                            Console.WriteLine();
                            if (primaryCharacter.currency["GP"] >= 15)
                            {
                                Console.WriteLine("Would you like to purchase a shield for 15 GP?");
                                Console.WriteLine();
                                Console.WriteLine("Press 'Y' if yes or 'N' if not.");
                                Console.WriteLine();
                                var purchaseShieldResponse = Console.ReadKey(true).Key;
                                if (purchaseShieldResponse == ConsoleKey.Y)
                                {
                                    primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>("Shield").ToArray();
                                    primaryCharacter.currency["GP"] -= 15;
                                    Console.WriteLine("You have " + primaryCharacter.currency["GP"] + " GP left.");
                                    Console.WriteLine();
                                }
                                else if (purchaseShieldResponse == ConsoleKey.N)
                                {
                                    break;
                                }
                            }
                        }
                        else Console.WriteLine("You don't have quite enough coin for this purchase.");
                        Console.WriteLine();
                    }
                    else Console.WriteLine("Please enter a valid choice.");
                }
            }
            if (primaryCharacter.CharacterClass == "Magic-User")
            {
                primaryCharacter.EquippedArmor = primaryCharacter.EquippedArmor.Append<string>(magicUserArmor[0].Key).ToArray();
                Console.WriteLine("Unfortunately, you must remain unarmored throughout your travels.");
                Console.WriteLine();
            }

            if (primaryCharacter.CharacterClass != "Magic-User")
            {
                Console.WriteLine("You have the following armor equipped:");
                foreach (var item in primaryCharacter.EquippedArmor)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Combat in Aldon will be unavoidable, so it's for the best that we go over a few core concepts. " +
                "First up is Armor Class (AC). This value affects the probability of a combatant dealing damage to you." +
                "There is another facet to dealing damage that we'll touch on later, but for now remember that a lower AC" +
                "represents a lower chance to be hit in combat, with AC 2 being the lowest possible value.");
            Console.WriteLine();

            Console.WriteLine("An unarmored character has an AC of 9.");
            Console.WriteLine("A character wearing leather has an AC of 7");
            Console.WriteLine("A character wearing chainmail has an AC of 5.");
            Console.WriteLine("A character wearing plate has an AC of 3.");
            Console.WriteLine("And any character with a shield equipped reduces their AC by 1 additional point.");
            Console.WriteLine();

            // Assigns primary character an armor class scored based on equipped armor.
            if (primaryCharacter.EquippedArmor.Contains("Unarmored"))
            {
                primaryCharacter.ArmorClass = 9;
            }
            else if (primaryCharacter.EquippedArmor.Contains("Leather"))
            {
                primaryCharacter.ArmorClass = 7;
            }
            else if (primaryCharacter.EquippedArmor.Contains("Chainmail"))
            {
                primaryCharacter.ArmorClass = 5;
            }
            else if (primaryCharacter.EquippedArmor.Contains("Plate"))
            {
                primaryCharacter.ArmorClass = 3;
            }

            if (primaryCharacter.EquippedArmor.Contains("Shield"))
            {
                primaryCharacter.ArmorClass -= 1;
            }

            Console.WriteLine("That would put your AC right... around... " + primaryCharacter.ArmorClass + ".");
            Console.WriteLine();

            //Player receives random weapon from equippable options based on chosen class.
            Console.WriteLine("In the spirit of old-school gaming, let's provide you with a random starting weapon." +
                "The only two rules to remember about weaponry being that clerics are prohibited from wielding edged/piercing weapons" +
                "and Magic-Users are limited to daggers and staves.");
            Console.WriteLine();

            var weaponsList = WeaponStats.weapons.ToList();

            if (primaryCharacter.CharacterClass == "Magic-User")
            {
                var magicUserWeapons = weaponsList.Where(w => w.Key.Contains("Dagger") || w.Key.Contains("Staff")).ToList();
                var randomWeapon = magicUserWeapons[new Random().Next(0, magicUserWeapons.Count - 1)];
                primaryCharacter.EquippedWeapon = primaryCharacter.EquippedWeapon.Append<string>(randomWeapon.Key).ToArray();
            }

            if (primaryCharacter.CharacterClass == "Cleric")
            {
                var clericWeapons = weaponsList.Where(w => w.Value.HasEdge == false && w.Value.IsRanged == false).ToList();
                var randomWeapon = clericWeapons[new Random().Next(0, clericWeapons.Count - 1)];
                primaryCharacter.EquippedWeapon = primaryCharacter.EquippedWeapon.Append<string>(randomWeapon.Key).ToArray();

                // ADD IN A 25% CHANCE TO RECEIVE A RANGED WEAPON IN ADDITION
                var rangedWeaponChance = new Random().Next(1, 101);
                if (rangedWeaponChance <= 25)
                {
                    var rangedWeapons = weaponsList.Where(w => w.Value.IsRanged == true && w.Value.HasEdge == false && w.Key != "War Hammer").ToList();
                    var randomRangedWeapon = rangedWeapons[new Random().Next(0, rangedWeapons.Count - 1)];
                    primaryCharacter.EquippedWeapon = primaryCharacter.EquippedWeapon.Append<string>(randomRangedWeapon.Key).ToArray();
                }
            }

            if (primaryCharacter.CharacterClass == "Fighter")
            {
                var fighterWeapons = weaponsList.Where(w => !w.Key.Contains("Staff") && w.Value.IsRanged == false).ToList();
                var randomWeapon = fighterWeapons[new Random().Next(0, fighterWeapons.Count - 1)];
                primaryCharacter.EquippedWeapon = primaryCharacter.EquippedWeapon.Append<string>(randomWeapon.Key).ToArray();

                // ADD IN A 25% CHANCE TO RECEIVE A RANGED WEAPON IN ADDITION
                var rangedWeaponChance = new Random().Next(1, 101);
                if (rangedWeaponChance <= 25)
                {
                    var rangedWeapons = weaponsList.Where(w => w.Value.IsRanged == true && w.Key != "Spear" && w.Key != "Dagger").ToList();
                    var randomRangedWeapon = rangedWeapons[new Random().Next(0, rangedWeapons.Count - 1)];
                    primaryCharacter.EquippedWeapon = primaryCharacter.EquippedWeapon.Append<string>(randomRangedWeapon.Key).ToArray();
                }
            }

            Console.WriteLine("You have a the following weapons equipped:");
            foreach (var item in primaryCharacter.EquippedWeapon)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Next step is to go over your Saving Throw values. These are representative of your character's " +
                "ability to withstand certain spells and environmental effects. In certain situations a 20-sided die is " +
                "rolled and if it equals or exceeds the value of your relative Saving Throw, the effects will be resisted.");
            Console.WriteLine();

            // Loop to assign Saving Throw values to player character based on class and level. Uses the SavingThrows dictionary in each class to determine values.
            var fighterSavingThrows = Fighter.SavingThrows.ToList();
            var clericSavingThrows = Cleric.SavingThrows.ToList();
            var magicUserSavingThrows = MagicUser.SavingThrows.ToList();
            if (primaryCharacter.CharacterClass == "Fighter")
            {
                primaryCharacter.savingThrows["Poison"] = fighterSavingThrows[primaryCharacter.Level - 1].Value[0];
                primaryCharacter.savingThrows["Wands/Rays"] = fighterSavingThrows[primaryCharacter.Level - 1].Value[1];
                primaryCharacter.savingThrows["Paralysis/Petrification"] = fighterSavingThrows[primaryCharacter.Level - 1].Value[2];
                primaryCharacter.savingThrows["Breath"] = fighterSavingThrows[primaryCharacter.Level - 1].Value[3];
                primaryCharacter.savingThrows["Spells"] = fighterSavingThrows[primaryCharacter.Level - 1].Value[4];
            }
            else if (primaryCharacter.CharacterClass == "Cleric")
            {
                primaryCharacter.savingThrows["Poison"] = clericSavingThrows[primaryCharacter.Level - 1].Value[0];
                primaryCharacter.savingThrows["Wands/Rays"] = clericSavingThrows[primaryCharacter.Level - 1].Value[1];
                primaryCharacter.savingThrows["Paralysis/Petrification"] = clericSavingThrows[primaryCharacter.Level - 1].Value[2];
                primaryCharacter.savingThrows["Breath"] = clericSavingThrows[primaryCharacter.Level - 1].Value[3];
                primaryCharacter.savingThrows["Spells"] = clericSavingThrows[primaryCharacter.Level - 1].Value[4];
            }
            else if (primaryCharacter.CharacterClass == "Magic-User")
            {
                primaryCharacter.savingThrows["Poison"] = magicUserSavingThrows[primaryCharacter.Level - 1].Value[0];
                primaryCharacter.savingThrows["Wands/Rays"] = magicUserSavingThrows[primaryCharacter.Level - 1].Value[1];
                primaryCharacter.savingThrows["Paralysis/Petrification"] = magicUserSavingThrows[primaryCharacter.Level - 1].Value[2];
                primaryCharacter.savingThrows["Breath"] = magicUserSavingThrows[primaryCharacter.Level - 1].Value[3];
                primaryCharacter.savingThrows["Spells"] = magicUserSavingThrows[primaryCharacter.Level - 1].Value[4];
            }

            Console.WriteLine("Your Saving Throw values are as follows:");
            foreach (var savingThrow in primaryCharacter.savingThrows)
            {
                Console.WriteLine(savingThrow.Key + ": " + savingThrow.Value);
            }
            Console.WriteLine();

            //Console.WriteLine("")

            Console.ReadKey();
        }
    }
}
