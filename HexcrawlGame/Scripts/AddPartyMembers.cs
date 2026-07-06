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

        }
    }
}
