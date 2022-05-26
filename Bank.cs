using System;

namespace PlanYourHeist
{
    public class Bank
    {
        public int Difficulty { get; set; }

        public Bank(int diff)
        {
            Difficulty = diff;
        }
    }
}