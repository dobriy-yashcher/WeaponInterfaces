﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponCore.Interfaces;

namespace WeaponCore.Units
{
    public class Soldier
    {
        public List<IWeapon> Inventory { get; set; }

        public Soldier()
        {
            Inventory = new List<IWeapon>();
        }

        public void PickUpItem(IWeapon item)
        {
            Inventory.Add(item);
        }

        public void Fire(IWeapon weapon)
        {
            weapon.SingleShoot();
        }

        public void MultiFire(IAutoShoot weapon)
        {
            weapon.AutoShoot();
        }

        public void HitByKnife(IMleeWeapon weapon)
        {
            weapon.Hit();
        }

        public void Reload(IReloadable item, int countCartridges)
        {
            item.Reload(countCartridges);
        }

        public void ThrowKnife(IThrowable weapon)
        {
            weapon.Throw();
        }
    }
}