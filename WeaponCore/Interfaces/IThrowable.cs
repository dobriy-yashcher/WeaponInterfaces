﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponCore.Interfaces
{
    public interface IThrowable
    {
        public int ThrowDamage { get; set; }

        public void Throw();
    }
}