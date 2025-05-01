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
    internal class Upgrade004 : ModUpgrade<TheDemonMonkey>
    {
        public override string DisplayName => "Demonic Jutsu";
        public override string Description => "Slowly turning demonic...";

        public override int Path => BOTTOM;

        public override int Tier => 4;

        public override int Cost => 14050;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon(1);
            var projectileModel = weaponModel.projectile;

            // multishot
            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 3, 0, 90, null, false, false);

            projectileModel.GetDamageModel().damage += 3;
            projectileModel.pierce += 5;
            weaponModel.rate *= 0.75f;

            projectileModel.GetDamageModel().immuneBloonProperties = 0;
        }
    }
}
