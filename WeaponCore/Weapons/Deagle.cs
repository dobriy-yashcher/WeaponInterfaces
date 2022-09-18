using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponCore.Interfaces;

namespace WeaponCore.Weapons
{
    public class Deagle : IWeapon
    {
        public int Damage { get; set; }
        public int CurrentAmmoSize { get; set; }
        public int MaxAmmoSize { get; set; }
        public int Cartridges { get; set; }
        public int Condition { get; set; }

        public Deagle(int startDamage, int ammoSize, int cartridges, int condition)
        {
            Damage = startDamage;
            CurrentAmmoSize = ammoSize;
            MaxAmmoSize = ammoSize;
            Cartridges = cartridges;
            Condition = condition;
        }

        public void Reload(int countCartridges)
        {
            if (CurrentAmmoSize + countCartridges <= MaxAmmoSize)
            {
                CurrentAmmoSize += countCartridges;
                Cartridges -= countCartridges;
            }

            else
            {
                CurrentAmmoSize = MaxAmmoSize;
                Cartridges -= MaxAmmoSize - CurrentAmmoSize;
            }
            
            Console.WriteLine($"The deagle is reloaded. Current ammo size: {CurrentAmmoSize}, ammo left: {Cartridges}.");
        }

        public void Repair(int countConditionRepaired)
        {
            Condition += countConditionRepaired;

            Console.WriteLine($"Deagle has repaired by {countConditionRepaired} points.");
        }

        public void SingleShoot()
        {
            if (Condition <= 0)
            {
                Console.WriteLine("Deagle is broken");
            }

            else
            {
                --Condition;
                Console.WriteLine($"Deagle shooting with {Damage}.");
            }
        }

        public void UpgradeAmmo(int countAmmoSizeUpgrade)
        {
            MaxAmmoSize += countAmmoSizeUpgrade;

            Console.WriteLine($"Deagle max count ammo size has upgrade by {countAmmoSizeUpgrade} points.");
        }

        public void UpgradeDamage(int countDamageUpgrade)
        {
            Damage += countDamageUpgrade;

            Console.WriteLine($"Deagle damage has upgrade by {countDamageUpgrade} points.");
        }
    }
}
