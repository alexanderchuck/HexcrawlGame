using HexcrawlGame.Items;
using HexcrawlGame.PCs;

namespace HexcrawlGame.Scripts
{
    public class AddPartyMembers
    {
        public void PartyMemberCreation()
        {
            BaseCharacter secondPartyMember = new();

            secondPartyMember.Name = Console.ReadLine();
            Console.WriteLine();
            while (string.IsNullOrEmpty(secondPartyMember.Name) || secondPartyMember.Name.Any(char.IsDigit))
            {
                Console.WriteLine("Please enter a valid name.");
                secondPartyMember.Name = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Let's generate some details for " + secondPartyMember.Name + ".");
            Console.WriteLine();

            // Assign random attributes
            var attributeList = secondPartyMember.Attributes.Keys.ToList();
            Random attributeScore = new Random();
            foreach (var attribute in attributeList)
            {
                secondPartyMember.Attributes[attribute] = attributeScore.Next(3, 19);
            }

            // Choose most appropriate class based on attribute scores.
            // Potentially a way to optimize class selection, but it's fine for now.
            if (secondPartyMember.Attributes["Strength"].Value > secondPartyMember.Attributes["Intelligence"].Value && secondPartyMember.Attributes["Strength"].Value > secondPartyMember.Attributes["Wisdom"].Value)
            {
                secondPartyMember.CharacterClass = "Fighter";
            }
            else if (secondPartyMember.Attributes["Intelligence"].Value > secondPartyMember.Attributes["Strength"].Value && secondPartyMember.Attributes["Intelligence"].Value > secondPartyMember.Attributes["Wisdom"].Value)
            {
                secondPartyMember.CharacterClass = "Magic-User";
            }
            else if (secondPartyMember.Attributes["Wisdom"].Value > secondPartyMember.Attributes["Strength"].Value && secondPartyMember.Attributes["Wisdom"].Value > secondPartyMember.Attributes["Intelligence"].Value)
            {
                secondPartyMember.CharacterClass = "Cleric";
            }
            else
            {
                secondPartyMember.CharacterClass = BaseCharacter.classes.Keys.ElementAt(new Random().Next(0, BaseCharacter.classes.Count));
            }

            // Sends the prime requisite value through the GetExperienceBonus function to determine the bonus
            if (secondPartyMember.CharacterClass == "Cleric")
            {
                secondPartyMember.BonusExperience = secondPartyMember.GetExperienceBonus(secondPartyMember.Attributes["Wisdom"].Value);
            }

            if (secondPartyMember.CharacterClass == "Fighter")
            {
                secondPartyMember.BonusExperience = secondPartyMember.GetExperienceBonus(secondPartyMember.Attributes["Strength"].Value);
            }

            if (secondPartyMember.CharacterClass == "Magic-User")
            {
                secondPartyMember.BonusExperience = secondPartyMember.GetExperienceBonus(secondPartyMember.Attributes["Intelligence"].Value);
            }

            // Assign the aligment.
            if (secondPartyMember.CharacterClass == "Cleric")
            {
                secondPartyMember.Alignment = BaseCharacter.alignment.Keys.ElementAt(0);
            }
            else
            {
                secondPartyMember.Alignment = BaseCharacter.alignment.Keys.ElementAt(new Random().Next(0, 2));
            }

            // Determine starting health based on class.
            var FighterHD = Fighter.HDProgression.ToList();
            var ClericHD = Cleric.HDProgression.ToList();
            var MagicUserHD = MagicUser.HDProgression.ToList();

            if (secondPartyMember.CharacterClass == "Fighter")
            {
                secondPartyMember.Health = FighterHD[secondPartyMember.Level - 1].Value;
            }
            else if (secondPartyMember.CharacterClass == "Cleric")
            {
                secondPartyMember.Health = ClericHD[secondPartyMember.Level - 1].Value;
            }
            else if (secondPartyMember.CharacterClass == "Magic-User")
            {
                secondPartyMember.Health = MagicUserHD[secondPartyMember.Level - 1].Value;
            }

            // Determine starting gold based on class.
            var currentGold = new Random().Next(30, 181);
            secondPartyMember.Currency["GP"] = currentGold;

            // Assign starting armor.
            var clericArmor = Cleric.StartingArmor.ToList();
            var fighterArmor = Fighter.StartingArmor.ToList();
            var magicUserArmor = MagicUser.StartingArmor.ToList();
            if (secondPartyMember.CharacterClass == "Magic-User")
            {
                secondPartyMember.EquippedArmor = secondPartyMember.EquippedArmor.Append(magicUserArmor[0].Key).ToArray();
            }
            else if (secondPartyMember.Currency["GP"] > 100)
            {
                secondPartyMember.EquippedArmor = secondPartyMember.EquippedWeapon.Append(fighterArmor[3].Key).ToArray();
                secondPartyMember.Currency["GP"] -= fighterArmor[3].Value;
                if (secondPartyMember.Currency["GP"] > 15)
                {
                    secondPartyMember.EquippedArmor = secondPartyMember.EquippedArmor.Append<string>("Shield").ToArray();
                    secondPartyMember.Currency["GP"] -= 15;
                }
            }
            else if (secondPartyMember.Currency["GP"] > 35)
            {
                secondPartyMember.EquippedArmor = secondPartyMember.EquippedWeapon.Append(fighterArmor[2].Key).ToArray();
                secondPartyMember.Currency["GP"] -= fighterArmor[2].Value;
                if (secondPartyMember.Currency["GP"] > 15)
                {
                    secondPartyMember.EquippedArmor = secondPartyMember.EquippedArmor.Append<string>("Shield").ToArray();
                    secondPartyMember.Currency["GP"] -= 15;
                }
            }
            else if (secondPartyMember.Currency["GP"] > 10)
            {
                secondPartyMember.EquippedArmor = secondPartyMember.EquippedWeapon.Append(fighterArmor[1].Key).ToArray();
                secondPartyMember.Currency["GP"] -= fighterArmor[1].Value;
                if (secondPartyMember.Currency["GP"] > 15)
                {
                    secondPartyMember.EquippedArmor = secondPartyMember.EquippedArmor.Append<string>("Shield").ToArray();
                    secondPartyMember.Currency["GP"] -= 15;
                }
            }

            // Assigns primary character an armor class scored based on equipped armor.
            if (secondPartyMember.EquippedArmor.Contains("Unarmored"))
            {
                secondPartyMember.ArmorClass = 9;
            }
            else if (secondPartyMember.EquippedArmor.Contains("Leather"))
            {
                secondPartyMember.ArmorClass = 7;
            }
            else if (secondPartyMember.EquippedArmor.Contains("Chainmail"))
            {
                secondPartyMember.ArmorClass = 5;
            }
            else if (secondPartyMember.EquippedArmor.Contains("Plate"))
            {
                secondPartyMember.ArmorClass = 3;
            }

            if (secondPartyMember.EquippedArmor.Contains("Shield"))
            {
                secondPartyMember.ArmorClass -= 1;
            }

            // Assign a random starting weapon.
            var weaponsList = WeaponStats.weaponList;

            if (secondPartyMember.CharacterClass == "Magic-User")
            {
                var magicUserWeapons = weaponsList.Where(w => w.Name.Contains("Dagger") || w.Name.Contains("Staff")).ToList();
                var randomWeapon = magicUserWeapons[new Random().Next(0, magicUserWeapons.Count - 1)];
                secondPartyMember.EquippedWeapon = secondPartyMember.EquippedWeapon.Append<string>(randomWeapon.Name).ToArray();
            }

            if (secondPartyMember.CharacterClass == "Cleric")
            {
                var clericWeapons = weaponsList.Where(w => w.HasEdge == false && w.IsRanged == false).ToList();
                var randomWeapon = clericWeapons[new Random().Next(0, clericWeapons.Count - 1)];
                secondPartyMember.EquippedWeapon = secondPartyMember.EquippedWeapon.Append<string>(randomWeapon.Name).ToArray();

                // ADD IN A 25% CHANCE TO RECEIVE A RANGED WEAPON IN ADDITION
                var rangedWeaponChance = new Random().Next(1, 101);
                if (rangedWeaponChance <= 25)
                {
                    var rangedWeapons = weaponsList.Where(w => w.IsRanged == true && w.HasEdge == false && w.Name != "War Hammer").ToList();
                    var randomRangedWeapon = rangedWeapons[new Random().Next(0, rangedWeapons.Count - 1)];
                    secondPartyMember.EquippedWeapon = secondPartyMember.EquippedWeapon.Append<string>(randomRangedWeapon.Name).ToArray();
                }
            }

            if (secondPartyMember.CharacterClass == "Fighter")
            {
                var fighterWeapons = weaponsList.Where(w => !w.Name.Contains("Staff") && w.IsRanged == false).ToList();
                var randomWeapon = fighterWeapons[new Random().Next(0, fighterWeapons.Count - 1)];
                secondPartyMember.EquippedWeapon = secondPartyMember.EquippedWeapon.Append<string>(randomWeapon.Name).ToArray();

                // ADD IN A 25% CHANCE TO RECEIVE A RANGED WEAPON IN ADDITION
                var rangedWeaponChance = new Random().Next(1, 101);
                if (rangedWeaponChance <= 25)
                {
                    var rangedWeapons = weaponsList.Where(w => w.IsRanged == true && w.Name != "Spear" && w.Name != "Dagger").ToList();
                    var randomRangedWeapon = rangedWeapons[new Random().Next(0, rangedWeapons.Count - 1)];
                    secondPartyMember.EquippedWeapon = secondPartyMember.EquippedWeapon.Append<string>(randomRangedWeapon.Name).ToArray();
                }
            }

            // Loop to assign Saving Throw values to player character based on class and level. Uses the SavingThrows dictionary in each class to determine values.
            var fighterSavingThrows = Fighter.SavingThrows.ToList();
            var clericSavingThrows = Cleric.SavingThrows.ToList();
            var magicUserSavingThrows = MagicUser.SavingThrows.ToList();
            if (secondPartyMember.CharacterClass == "Fighter")
            {
                secondPartyMember.SavingThrows["Poison"] = fighterSavingThrows[secondPartyMember.Level - 1].Value[0];
                secondPartyMember.SavingThrows["Wands/Rays"] = fighterSavingThrows[secondPartyMember.Level - 1].Value[1];
                secondPartyMember.SavingThrows["Paralysis/Petrification"] = fighterSavingThrows[secondPartyMember.Level - 1].Value[2];
                secondPartyMember.SavingThrows["Breath"] = fighterSavingThrows[secondPartyMember.Level - 1].Value[3];
                secondPartyMember.SavingThrows["Spells"] = fighterSavingThrows[secondPartyMember.Level - 1].Value[4];
            }
            else if (secondPartyMember.CharacterClass == "Cleric")
            {
                secondPartyMember.SavingThrows["Poison"] = clericSavingThrows[secondPartyMember.Level - 1].Value[0];
                secondPartyMember.SavingThrows["Wands/Rays"] = clericSavingThrows[secondPartyMember.Level - 1].Value[1];
                secondPartyMember.SavingThrows["Paralysis/Petrification"] = clericSavingThrows[secondPartyMember.Level - 1].Value[2];
                secondPartyMember.SavingThrows["Breath"] = clericSavingThrows[secondPartyMember.Level - 1].Value[3];
                secondPartyMember.SavingThrows["Spells"] = clericSavingThrows[secondPartyMember.Level - 1].Value[4];
            }
            else if (secondPartyMember.CharacterClass == "Magic-User")
            {
                secondPartyMember.SavingThrows["Poison"] = magicUserSavingThrows[secondPartyMember.Level - 1].Value[0];
                secondPartyMember.SavingThrows["Wands/Rays"] = magicUserSavingThrows[secondPartyMember.Level - 1].Value[1];
                secondPartyMember.SavingThrows["Paralysis/Petrification"] = magicUserSavingThrows[secondPartyMember.Level - 1].Value[2];
                secondPartyMember.SavingThrows["Breath"] = magicUserSavingThrows[secondPartyMember.Level - 1].Value[3];
                secondPartyMember.SavingThrows["Spells"] = magicUserSavingThrows[secondPartyMember.Level - 1].Value[4];
            }

            // Iterating over a starting items list and adding each item to the player's inventory.
            foreach (var item in Supplies.starterSupplies)
            {
                secondPartyMember.Inventory.Add(item.Name, item.Quantity);
            }

            if (secondPartyMember.CharacterClass == "Cleric")
            {
                var clericStartingItem = Supplies.supplies.FirstOrDefault(item => item.Name == "Wooden Cross");
                if (clericStartingItem != null)
                {
                    secondPartyMember.Inventory.Add(clericStartingItem.Name, null);
                }
            }

            // Randomly generates 5 additional items from the Supplies list and adds them to the player's inventory.
            int supplyNum = 1;
            Random random = new Random();
            while (supplyNum <= 5)
            {
                var randomSupplyNum = random.Next(0, Supplies.supplies.Count);
                var randomSupplyItem = Supplies.supplies[randomSupplyNum];
                secondPartyMember.Inventory.TryAdd(randomSupplyItem.Name, randomSupplyItem.Quantity);
                supplyNum++;
            }

            // Random choose spell to prepare if class is Magic-User or Cleric.

            Console.Write("Name: ");
            Console.WriteLine(secondPartyMember.Name);
            Console.WriteLine();

            Console.Write("Class: ");
            Console.WriteLine(secondPartyMember.CharacterClass);
            Console.WriteLine();

            foreach (var attribute in secondPartyMember.Attributes)
            {
                Console.WriteLine(attribute.Key + ": " + attribute.Value);
            }
            Console.WriteLine();

            Console.Write("Level: ");
            Console.WriteLine(secondPartyMember.Level);
            Console.WriteLine();

            Console.Write("Alignment: ");
            Console.WriteLine(secondPartyMember.Alignment);
            Console.WriteLine();

            Console.Write("Health: ");
            Console.WriteLine(secondPartyMember.Health);
            Console.WriteLine();

            Console.Write("GP: ");
            Console.WriteLine(secondPartyMember.Currency["GP"]);
            Console.WriteLine();

            Console.WriteLine("Weapons: ");
            foreach (var weapon in secondPartyMember.EquippedWeapon)
            {
                Console.WriteLine(weapon);
            }
            Console.WriteLine();

            Console.WriteLine("Armor: ");
            foreach (var armor in secondPartyMember.EquippedArmor)
            {
                Console.WriteLine(armor);
            }
            Console.WriteLine();

            Console.Write("AC: ");
            Console.WriteLine(secondPartyMember.ArmorClass);
            Console.WriteLine();

            Console.WriteLine("Saving Throws: ");
            foreach (var savingThrow in secondPartyMember.SavingThrows)
            {
                Console.WriteLine(savingThrow.Key + ": " + savingThrow.Value);
            }
            Console.WriteLine();

            Console.WriteLine("Inventory: ");
            foreach (var item in secondPartyMember.Inventory)
            {
                if (item.Value > 0) Console.WriteLine(item.Key + ": " + item.Value);
                else Console.WriteLine(item.Key);
            }
            Console.WriteLine();
        }
    }
}
