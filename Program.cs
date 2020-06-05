using System;
using System.Collections.Generic;

namespace BankHeist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker member1 = new Hacker() { Name = "Joe Bob", SkillLevel = 50, PercentageCut = 20 };
            Hacker member2 = new Hacker() { Name = "John Jako", SkillLevel = 40, PercentageCut = 20 };
            Muscle member3 = new Muscle() { Name = "Amy Doe", SkillLevel = 45, PercentageCut = 20 };
            Muscle member4 = new Muscle() { Name = "Billy Bam", SkillLevel = 35, PercentageCut = 20 };
            LockSpecialist member5 = new LockSpecialist() { Name = "Sam Gibgib", SkillLevel = 25, PercentageCut = 20 };
            LockSpecialist member6 = new LockSpecialist() { Name = "Adam Dude ", SkillLevel = 48, PercentageCut = 20 };

            List<IRobber> roledex = new List<IRobber>()
            {
                member1,
                member2,
                member3,
                member4,
                member5,
                member6

            };

            bool isRunning = true;
            while (isRunning == true)
            {
                Console.WriteLine(roledex.Count);
                Console.Write("Enter Name New Crew member: ");
                string newMember = Console.ReadLine();
                if (newMember == "") { isRunning = false; break; };
                Console.WriteLine("Possible Specialties");
                Console.WriteLine(@"
            1. Hacker(Disables Alarms)
            2. Muscle(Disarms Guards)
            3. Lock Specialist(Cracks Vault)");
                int specialtyNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter Members Skill Level 1-100:  ");
                int skillLevel = int.Parse(Console.ReadLine());
                Console.Write("Enter Members Percentage Cut:  ");
                double payCut = double.Parse(Console.ReadLine());

                switch (specialtyNumber)
                {
                    case 1:
                        roledex.Add(new Hacker() { Name = newMember, SkillLevel = skillLevel, PercentageCut = payCut });
                        break;
                    case 2:
                        roledex.Add(new Muscle() { Name = newMember, SkillLevel = skillLevel, PercentageCut = payCut });
                        break;
                    case 3:
                        roledex.Add(new LockSpecialist() { Name = newMember, SkillLevel = skillLevel, PercentageCut = payCut });
                        break;
                }
            }

        }
    }
}