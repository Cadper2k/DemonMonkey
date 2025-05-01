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
    internal class Upgrade040 : ModUpgrade<TheDemonMonkey>
    {

        public override string DisplayName => "Advanced Sharingan";
        public override string Description => "The shinobi has reached the physical limit of how long range your body can handle and shoots 2x speed, the shurikens now gets thrown out so fast that they can melt led bloons";

        public override int Path => MIDDLE;

        public override int Tier => 4;

        public override int Cost => 10000;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.rate *= 0.5f;

            towerModel.range += 5;
            attackModel.range += 5;

            projectileModel.GetDamageModel().immuneBloonProperties = 0;
        }
    }
}
