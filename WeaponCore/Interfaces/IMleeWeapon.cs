using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponCore.Interfaces
{
    public interface IMleeWeapon : IRepairable, IUpgradable
    {
        public int MleeDamage { get; set; }
        public void Hit();
    }
}
