using MelonLoader;
using BTD_Mod_Helper;
using DemonMonkey;

[assembly: MelonInfo(typeof(DemonMonkey.DemonMonkey), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace DemonMonkey;

public class DemonMonkey : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<DemonMonkey>("DemonMonkey loaded!");
    }
}