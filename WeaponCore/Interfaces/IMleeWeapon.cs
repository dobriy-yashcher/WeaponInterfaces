// Turushkin Sergey, 320P, "WeaponInterfaces"

namespace WeaponCore.Interfaces
{
    public interface IMleeWeapon : IRepairable, IUpgradebleDamage
    {
        public int MleeDamage { get; set; }
        public void Hit();
    }
}
