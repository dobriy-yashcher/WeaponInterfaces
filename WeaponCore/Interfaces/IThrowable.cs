// Turushkin Sergey, 320P, "WeaponInterfaces"

namespace WeaponCore.Interfaces
{
    public interface IThrowable
    {
        public int ThrowDamage { get; set; }

        public void Throw();
    }
}
