using System;

namespace BankHeist2{

    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int SkillLevel { get; set; }
        public double PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is picking the lock system, decrease security {SkillLevel} points.");
            if (bank.VaultScore <= 0)
            Console.WriteLine($"{Name} has disabled the vault system.");
        }
        }
    }
