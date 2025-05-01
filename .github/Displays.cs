using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonMonkey.github
{
    internal class DemonMonkeyDisplay : ModTowerDisplay<TheDemonMonkey>
    {
        public override string BaseDisplay => Generic2dDisplay;


        public override bool UseForTower(params int[] tiers) => tiers[0] > -1;


        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, "TheDemonMonkeyDisplay");
        }



    }
}
