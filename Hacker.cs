using System;

namespace BankHeist2{

    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system, decrease security {SkillLevel} points.");
            if (bank.AlarmScore <= 0)
            Console.WriteLine($"{Name} has disabled the alarm system.");
        }
    }
}