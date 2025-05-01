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
    internal class Upgrade005 : ModUpgrade<TheDemonMonkey>
    {
        public override string DisplayName => "The Demon Of The Village Hidden In The Leaves";
        public override string Description => "The darkness has consumed him...";

        public override int Path => BOTTOM;

        public override int Tier => 5;

        public override int Cost => 130500;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon(1);
            var projectileModel = weaponModel.projectile;

            // multishot
            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 15, 0, 90, null, false, false);

            projectileModel.GetDamageModel().damage += 10;
            projectileModel.pierce += 15;
            weaponModel.rate *= 0.60f;

            towerModel.range += 15;
            attackModel.range += 15;
        }
    }
}
