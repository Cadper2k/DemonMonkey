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
    internal class Upgrade030 : ModUpgrade<TheDemonMonkey>
    {

        public override string DisplayName => "Rookie Sharingan";
        public override string Description => "The shinobi uses the power of the sharingan to shoot faster and see further";
        public override int Path => MIDDLE;

        public override int Tier => 3;

        public override int Cost => 2250;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.rate *= 0.5f;

            towerModel.range += 5;
            attackModel.range += 5;
        }
    }
}
