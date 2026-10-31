using MelonLoader;
using DooDesch.Weapons;

[assembly: MelonInfo(typeof(TeddyBatPlus.Core), "TeddyBatPlus", DooDesch.ModVersion.Current, "DooDesch", null)]
[assembly: MelonGame("ReLUGames", "MIMESIS")]

namespace TeddyBatPlus
{
    public sealed class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            WeaponPreferences.Initialize();
            MelonLogger.Msg("TeddyBatPlus initialized for item 1100. Gameplay follows the host.");
        }
        public override void OnUpdate()
        {
            DooDesch.HostSettings.Update();
            WeaponDisplay.Update();
            WeaponReloadAnimation.Update();
        }
    }
}
