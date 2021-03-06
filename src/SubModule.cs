using HarmonyLib;
using System;
using System.Reflection;
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

            _harmony.Value.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}