using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonMonkey.Upgrade
{
    internal class Upgrade500 : ModUpgrade<TheDemonMonkey>
    {
        public override string DisplayName => "Too Many Shurikens";
        public override string Description => "It's pretty obvious what this does";

        public override int Path => TOP;

        public override int Tier => 5;

        public override int Cost => 105000;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 50, 0, 360, null, false, false);

            projectileModel.GetDamageModel().damage += 2;
        }
    }
}
