using WeaponCore.Units;
using WeaponCore.Weapons;

var deagle = new Deagle(30, 30, 1);
var famas = new FAMAS(50, 30, 2);
var grenade = new Grenade(55);
var knife = new Knife(15, 15, 1);
var sword = new Sword(30, 1);

var engineer = new Engineer();
var soldier = new Soldier();

soldier.PickUpItem(deagle);
soldier.PickUpItem(famas);
soldier.Fire(deagle);

Console.WriteLine();

soldier.MultiFire(famas);
soldier.MultiFire(famas);
soldier.Reload(famas, 5);
soldier.MultiFire(famas);
soldier.Reload(famas, 15);
soldier.Fire(famas);

Console.WriteLine();

soldier.Throw(knife);
soldier.Hit(sword);

Console.WriteLine();

engineer.Repair(famas, 1);
engineer.UpgradeDamage(famas, 1);
soldier.Fire(famas);
engineer.UpgradeAmmo(famas, 1);
soldier.Reload(famas, 150);