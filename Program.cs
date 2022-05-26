using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            List<TeamMember> teamList = new List<TeamMember>();

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

            // TeamMember member = new TeamMember(name, skillLvl, courageFact);
            // Console.WriteLine(member);
        }
    }

}
