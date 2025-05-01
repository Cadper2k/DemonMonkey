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
    internal class Upgrade200 : ModUpgrade<TheDemonMonkey>
    {
        public override string DisplayName => "Sharper Shurikens";
        public override string Description => "Sharper shurikens increase damage and pierce";

        public override int Path => TOP;

        public override int Tier => 2;

        public override int Cost => 820;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.GetDamageModel().damage += 1;
            projectileModel.pierce += 1;
        }
    }
}
