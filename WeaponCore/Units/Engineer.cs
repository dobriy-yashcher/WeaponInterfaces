using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
