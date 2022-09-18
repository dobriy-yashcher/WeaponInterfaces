// Turushkin Sergey, 320P, "WeaponInterfaces"

namespace WeaponCore.Interfaces
{
    public interface IWeapon : IReloadable, IRepairable, IUpgradable
    {
        public int Damage { get; set; }

        public void SingleShoot();
    }
}