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
    internal class Upgrade400 : ModUpgrade<TheDemonMonkey>
    {

        public override string DisplayName => "More Shurikens";
        public override string Description => "Makes the shinobi monkey shoot 7 more shurikens at the same time";

        public override int Path => TOP;

        public override int Tier => 4;

        public override int Cost => 13570;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 7, 0, 45, null, false, false);

            projectileModel.GetDamageModel().damage += 2;
        }
    }
}
