namespace BankHeist2
{
    public interface IRobber
    {
        string Name { get; set; }
        string Specialty { get; set; }
        int SkillLevel { get; set; }
        double PercentageCut { get; set; }
        void PerformSkill(Bank bank);

        // override string ToString()
        // {
            
        // }

    }
}