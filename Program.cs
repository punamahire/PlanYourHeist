using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("----------------");

            List<TeamMember> teamList = new List<TeamMember>();

            Random r = new Random();
            int randomNum= r.Next(-10, 11);

            Bank thisBank = new Bank(100 + randomNum);
            int totalSkillLevel = 0;

            Console.Write("Enter a team member's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter a team member's skill level: ");
            string skill = Console.ReadLine();
            int skillLvl = int.Parse(skill);
            totalSkillLevel += skillLvl;

            Console.Write("Enter a tem member's courage factor: ");
            string courage = Console.ReadLine();
            decimal courageFact = decimal.Parse(courage);

            while (courageFact < 0 || courageFact > 2)
            {
                Console.Write("Enter a tem member's courage factor: ");
                courage = Console.ReadLine();
                courageFact = decimal.Parse(courage);
            }

            TeamMember firstMember = new TeamMember(name, skillLvl, courageFact);
            teamList.Add(firstMember);

            while(true)
            {
                Console.Write("Enter a team member's name: ");
                name = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                else
                {

                    Console.Write("Enter a team member's skill level: ");
                    skillLvl = int.Parse(Console.ReadLine());
                    totalSkillLevel += skillLvl;

                    Console.Write("Enter a tem member's courage factor: ");
                    courageFact = decimal.Parse(Console.ReadLine());

                    while (courageFact < 0 || courageFact > 2)
                    {
                        Console.Write("Enter a tem member's courage factor: ");
                        courageFact = decimal.Parse(Console.ReadLine());
                    }

                    TeamMember thisMember = new TeamMember(name, skillLvl, courageFact);
                    teamList.Add(thisMember);
                }
            }

            Team team = new Team(teamList);
            team.Description();

            Console.WriteLine($"The team's combined skill level is: {totalSkillLevel}.");
            Console.WriteLine($"The bank's difficulty level is: {thisBank.Difficulty}.");

            if (totalSkillLevel >= thisBank.Difficulty)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Heist failed!");
            }

            // TeamMember member = new TeamMember(name, skillLvl, courageFact);
            // Console.WriteLine(member);
        }
    }

}
