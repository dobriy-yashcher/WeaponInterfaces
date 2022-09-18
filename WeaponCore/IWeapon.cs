namespace WeaponCore
{
    public interface IWeapon : IReload, IRepairible, IUpgradeble
    {
        int Damage { get; set; }

        void SingleShoot();

        void ShowInfo();
    }
}