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
    internal class Upgrade020 : ModUpgrade<TheDemonMonkey>
    {
        public override string DisplayName => "Further Vision";
        public override string Description => "Makes the shinobi monkey see much longer";
        public override int Path => MIDDLE;

        public override int Tier => 2;

        public override int Cost => 1070;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            towerModel.range += 20;
            attackModel.range += 20;
        }
    }
}
