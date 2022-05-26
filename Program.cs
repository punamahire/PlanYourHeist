using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.Write("Enter a team member's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter a team member's skill level: ");
            string skill = Console.ReadLine();
            int skillLvl = int.Parse(skill);

            Console.Write("Enter a tem member's courage factor: ");
            string courage = Console.ReadLine();
            decimal courageFact = decimal.Parse(courage);

            while (courageFact < 0 || courageFact > 2)
            {
                Console.Write("Enter a tem member's courage factor: ");
                courage = Console.ReadLine();
                courageFact = decimal.Parse(courage);
            }

            TeamMember member = new TeamMember(name, skillLvl, courageFact);
            Console.WriteLine(member);
        }
    }

}
