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

            Temp tempObj = new Temp
            {
                Name = "Twitter"
            };

            Temp tempObj2 = new Temp("Facebook");
            Console.WriteLine(tempObj.Name);
            Console.WriteLine(tempObj2.Name);

            List<TeamMember> teamList = new List<TeamMember>();

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

            Console.WriteLine();
            Console.Write("Enter the number of trial runs: ");
            string inputTrials = Console.ReadLine();
            int trialRuns = 0;
            bool success = int.TryParse(inputTrials, out trialRuns);
            //int trialRuns = int.Parse(inputTrials);

            Console.Write("Enter the bank's difficulty level: ");
            string inputDiffLvl = Console.ReadLine();
            int diffLevel = 0;
            bool parsed = int.TryParse(inputDiffLvl, out diffLevel);

            Console.WriteLine();

            int index = 0;
            int successRuns = 0;
            int failedRuns = 0;
            while(index < trialRuns)
            {
                Random r = new Random();
                int randomNum= r.Next(-10, 11);
                Bank thisBank = new Bank(diffLevel + randomNum);

                Console.WriteLine($"The team's combined skill level is: {totalSkillLevel}.");
                Console.WriteLine($"The bank's difficulty level is: {thisBank.Difficulty}.");

                if (totalSkillLevel >= thisBank.Difficulty)
                {
                    Console.WriteLine("Success!");
                    successRuns++;
                }
                else
                {
                    Console.WriteLine("Heist failed!");
                    failedRuns++;
                }
                index++;
            }

            // TeamMember member = new TeamMember(name, skillLvl, courageFact);
            // Console.WriteLine(member);

            Console.WriteLine();
            Console.WriteLine($"Number of successful runs: {successRuns}");
            Console.WriteLine($"Number of failed runs: {failedRuns}");
        }
    }

}
