namespace WeaponCore.Interfaces
{
    public interface IUpgradable : IUpgradebleDamage, IUpgradebleAmmo { }
    
    public interface IUpgradebleDamage
    {
        public void UpgradeDamage(int countDamageUpgrade);
    }
    
    public interface IUpgradebleAmmo
    {
        public void UpgradeAmmo(int countAmmoSizeUpgrade);
    }
}