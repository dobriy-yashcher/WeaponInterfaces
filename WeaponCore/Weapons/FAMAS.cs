using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponCore.Interfaces;

namespace WeaponCore.Weapons
{
    public class FAMAS : IWeapon, IAutoShoot
    {
        public int Damage { get; set; }
        public int CurrentAmmoSize { get; set; }
        public int MaxAmmoSize { get; set; }
        public int Condition { get; set; }

        public FAMAS(int startDamage, int ammoSize, int condition)
        {
            Damage = startDamage;
            CurrentAmmoSize = ammoSize;
            MaxAmmoSize = ammoSize;
            Condition = condition;
        }

        public void Reload(int countCartridges)
        {
            if (CurrentAmmoSize + countCartridges <= MaxAmmoSize)
            {
                CurrentAmmoSize += countCartridges;
            }

            else
            {
                CurrentAmmoSize = MaxAmmoSize;
            }

            Console.WriteLine($"The FAMAS is reloaded. Current ammo size: {CurrentAmmoSize}.");
        }

        public void Repair(int countConditionRepaired)
        {
            Condition += countConditionRepaired;

            Console.WriteLine($"FAMAS has repaired by {countConditionRepaired} points.");
        }

        public void SingleShoot()
        {
            if (Condition <= 0)
            {
                Console.WriteLine("FAMAS is broken.");
            }

            else
            {
                if (CurrentAmmoSize <= 0) Console.WriteLine($"FAMAS ammo is empty.");

                else
                {
                    --Condition;
                    --CurrentAmmoSize;
                    Console.WriteLine($"FAMAS shooting with {Damage}.");
                }
            }
        }

        public void AutoShoot()
        {
            if (Condition <= 0)
            {
                Console.WriteLine("FAMAS is broken.");
            }

            else
            {
                if (CurrentAmmoSize <= 0) Console.WriteLine($"FAMAS ammo is empty.");

                else
                {
                    --Condition;
                    Console.WriteLine($"FAMAS shooting full clip with {Damage * CurrentAmmoSize}.");
                    CurrentAmmoSize = 0;
                }
            }
        }

        public void UpgradeAmmo(int countAmmoSizeUpgrade)
        {
            MaxAmmoSize += countAmmoSizeUpgrade;

            Console.WriteLine($"FAMAS max count ammo size has upgrade by {countAmmoSizeUpgrade} points.");
        }

        public void UpgradeDamage(int countDamageUpgrade)
        {
            Damage += countDamageUpgrade;

            Console.WriteLine($"FAMAS damage has upgrade by {countDamageUpgrade} points.");
        }
    }
}
