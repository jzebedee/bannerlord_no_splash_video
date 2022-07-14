using HarmonyLib;
using System;
using TaleWorlds.MountAndBlade;

namespace SkipSplashVideos
{
    public class SubModule : MBSubModuleBase
    {
        private const string HarmonyId = $"{nameof(SkipSplashVideos)}.harmony";

        private readonly Lazy<Harmony> _harmony = new(() => new Harmony(HarmonyId));

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            _harmony.Value.PatchAll();
        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();

            _harmony.Value.UnpatchAll(HarmonyId);
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

        }
    }
}