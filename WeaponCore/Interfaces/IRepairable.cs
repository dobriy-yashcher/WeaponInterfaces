namespace WeaponCore.Interfaces
{
    public interface IRepairable
    {
        public int Condition { get; set; }
        public void Repair(int countConditionRepaired);
    }
}