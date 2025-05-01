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
    internal class Upgrade003 : ModUpgrade<TheDemonMonkey>
    {

        public override string DisplayName => "Stronger Jutsu";
        public override string Description => "The shinobi monkey puts its practice to work dealing much more damage with the focused energy jutsu";
        public override int Path => BOTTOM;

        public override int Tier => 3;

        public override int Cost => 1500;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon(1);
            var projectileModel = weaponModel.projectile;

            projectileModel.GetDamageModel().damage += 3;
            projectileModel.pierce += 2;
        }
    }
}
