// Turushkin Sergey, 320P, "WeaponInterfaces"

using WeaponCore.Interfaces;

namespace WeaponCore.Units
{
    public class Engineer
    {
        public void Repair(IRepairable item, int countConditionRepaired)
        {
            item.Repair(countConditionRepaired);
        }

        public void UpgradeDamage(IUpgradable item, int countDamageUpgrade)
        {
            item.UpgradeDamage(countDamageUpgrade);
        }
        
        public void UpgradeAmmo(IUpgradable item, int countAmmoSizeUpgrade)
        {
            item.UpgradeAmmo(countAmmoSizeUpgrade);
        }
    }
}
