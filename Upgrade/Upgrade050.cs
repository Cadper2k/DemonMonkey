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
    internal class Upgrade050 : ModUpgrade<TheDemonMonkey>
    {

        public override string DisplayName => "Kekkei Genkai";
        public override string Description => "Kekkei genkai (literally meaning: Bloodline Limit) are DNA anomalies that allow their wielders to use unique techniques. A kekkei genkai's name describes both the anomaly and the resulting technique. Most kekkei genkai are passed down between generations of a clan, an exception being Hashirama Senju's Wood Release. Likewise, most individuals with kekkei genkai only inherit one kekkei genkai, however this is not always the case.";

        public override int Path => MIDDLE;

        public override int Tier => 5;

        public override int Cost => 125000;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.rate *= 0.1f;
            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 2, 0, 5, null, false, false);
        }
    }
}
