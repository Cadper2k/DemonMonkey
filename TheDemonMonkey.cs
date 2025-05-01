using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;

namespace DemonMonkey
{
    internal class TheDemonMonkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Magic;

        public override string BaseTower => TowerType.NinjaMonkey;

        public override int Cost => 1000;

        public override int TopPathUpgrades => 3;

        public override int MiddlePathUpgrades => 5;

        public override int BottomPathUpgrades => 5;

        public override string Description => "A ruthless shinobi";

        public override string DisplayName => "Shinobi Monkey";

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            // range
            towerModel.range = 50;
            attackModel.range = 50;

            // attack speed
            weaponModel.rate *= 2f;

            // damage + pierce
            projectileModel.pierce = 2;
            projectileModel.GetDamageModel().damage = 3;
        }
    }
}
