using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
