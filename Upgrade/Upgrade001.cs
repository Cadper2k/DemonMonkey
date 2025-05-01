using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonMonkey.Upgrade
{
    internal class Upgrade001 : ModUpgrade<TheDemonMonkey>
    {
        public override string DisplayName => "Harder Throws";
        public override string Description => "Throwing the shurikens harder makes them deal more damage and be able to pop lead";

        public override int Path => BOTTOM;

        public override int Tier => 1;

        public override int Cost => 560;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.GetDamageModel().damage += 1;

            projectileModel.GetDamageModel().immuneBloonProperties = 0;
        }
    }
}
