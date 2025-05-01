using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonMonkey.Upgrade
{
    internal class Upgrade002 : ModUpgrade<TheDemonMonkey>
    {
        public override string DisplayName => "Mini Chakra";
        public override string Description => "The shinobi monkey gathers a little bit of chakra and is now able to shoot energy balls";
        public override int Path => BOTTOM;

        public override int Tier => 2;

        public override int Cost => 1250;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("WizardMonkey-200").GetWeapon().Duplicate());

            
        }
    }
}
