using System;

namespace BankHeist2{

    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int SkillLevel { get; set; }
        public double PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system, decrease security {SkillLevel} points.");
            if (bank.SecurityGuardScore <= 0)
            Console.WriteLine($"{Name} has overtaken the security guard.");
        }
        }
    }
