using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponCore.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace WeaponCore.Weapons
{
    public class Knife : IMleeWeapon, IThrowable
    {
        public int MleeDamage { get; set; }
        public int ThrowDamage { get; set; }
        public int Condition { get; set; }

        public Knife(int mleeDamage, int throwDmage, int condition)
        {
            MleeDamage = mleeDamage;
            ThrowDamage = throwDmage;
            Condition = condition;
        }

        public void Hit()
        {
            if (Condition <= 0)
            {
                Console.WriteLine("Knife is broken");
            }

            else
            {
                --Condition;
                Console.WriteLine($"Knife hit with {MleeDamage}.");
            }
        }

        public void Repair(int countConditionRepaired)
        {
            Condition += countConditionRepaired;

            Console.WriteLine($"Knife has repaired by {countConditionRepaired} points.");
        }

        public void UpgradeDamage(int countDamageUpgrade)
        {
            MleeDamage += countDamageUpgrade;
            ThrowDamage += countDamageUpgrade;

            Console.WriteLine($"Knife damage has upgrade by {countDamageUpgrade} points.");
        }

        public void Throw()
        {
            if (Condition <= 0)
            {
                Console.WriteLine("Knife is broken");
            }

            else
            {
                --Condition;
                Console.WriteLine($"Knife throw with {ThrowDamage}.");
            }
        }
    }
}
