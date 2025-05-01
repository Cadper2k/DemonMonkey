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
    internal class Upgrade010 : ModUpgrade<TheDemonMonkey>
    {
        public override string DisplayName => "Sharper Eyes";
        public override string Description => "Through sharpening its eyesight, the shinobi monkey increases its range by alot";
        public override int Path => MIDDLE;

        public override int Tier => 1;

        public override int Cost => 550;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            towerModel.range += 15;
            attackModel.range += 15;
        }
    }
}
