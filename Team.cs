using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    public class Team
    {
        public List<TeamMember> TeamList { get; set; }

        public Team(List<TeamMember> team)
        {
            TeamList = team;
        }

        public void AddMember(TeamMember member)
        {
            TeamList.Add(member);
        }

        public void Description()
        {
            foreach (TeamMember member in TeamList)
            {
                Console.WriteLine(member);
            }

        }
    }
}