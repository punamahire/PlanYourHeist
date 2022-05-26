using System;

namespace PlanYourHeist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        public TeamMember(string name, int skillLvl, decimal courageFact)
        {
            Name = name;
            SkillLevel = skillLvl;
            CourageFactor = courageFact;
        }

        public override string ToString()
        {
            return $"{Name} is at {SkillLevel} and {CourageFactor} courage factor.";
        }

    }
}