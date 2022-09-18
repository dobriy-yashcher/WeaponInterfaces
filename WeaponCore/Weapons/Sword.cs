// Turushkin Sergey, 320P, "WeaponInterfaces"

using WeaponCore.Interfaces;

namespace WeaponCore.Weapons
{
    public class Sword : IMleeWeapon
    {
        public int MleeDamage { get; set; }
        public int Condition { get; set; }

        public Sword(int mleeDamage, int condition)
        {
            MleeDamage = mleeDamage;
            Condition = condition;
        }

        public void Hit()
        {
            if (Condition <= 0)
            {
                Console.WriteLine("Sword is broken.");
            }

            else
            {
                --Condition;
                Console.WriteLine($"Sword hit with {MleeDamage}.");
            }
        }

        public void Repair(int countConditionRepaired)
        {
            Condition += countConditionRepaired;

            Console.WriteLine($"Sword has repaired by {countConditionRepaired} points.");
        }

        public void UpgradeDamage(int countDamageUpgrade)
        {
            MleeDamage += countDamageUpgrade;

            Console.WriteLine($"Sword damage has upgrade by {countDamageUpgrade} points.");
        }
    }
}
