// Turushkin Sergey, 320P, "WeaponInterfaces"

using WeaponCore.Interfaces;

namespace WeaponCore.Weapons
{
    public class Grenade : IThrowable
    {
        public int ThrowDamage { get; set; }

        public Grenade(int throwDamage)
        {
            ThrowDamage = throwDamage;
        }

        public void Throw()
        {
            Console.WriteLine($"Knife throw with {ThrowDamage}.");
        }
    }
}
