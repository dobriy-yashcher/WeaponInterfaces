namespace WeaponCore.Interfaces
{
    public interface IReloadable
    {
        public int CurrentAmmoSize { get; set; }
        public int MaxAmmoSize { get; set; }
        public void Reload(int countCartridges);
    }
}