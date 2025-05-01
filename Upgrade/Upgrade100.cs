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
    internal class Upgrade100 : ModUpgrade<TheDemonMonkey>
    {
        public override string DisplayName => "Thinner Shurikens";
        public override string Description => "Thinner shurikens weights less making them much more easy to throw in rapid succesion and they are able to pierces through more enemys";

        public override int Path => TOP;

        public override int Tier => 1;

        public override int Cost => 765;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.rate -= 0.5f;
            projectileModel.pierce += 1;
        }
    }
}
