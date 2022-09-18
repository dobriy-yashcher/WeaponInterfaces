namespace WeaponCore.Interfaces
{
    public interface IUpgradable
    {
        public void UpgradeDamage(int countDamageUpgrade);
        public void UpgradeAmmo(int countAmmoSizeUpgrade);
    }
}