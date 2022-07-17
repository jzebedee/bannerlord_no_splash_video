using HarmonyLib;

namespace SkipSplashVideos
{
    //TaleWorlds.MountAndBlade.Module.SetInitialModuleScreenAsRootScreen() : void @0600261E
    //// Token: 0x0600261E RID: 9758 RVA: 0x00091AB0 File Offset: 0x0008FCB0
    [HarmonyPatch(typeof(TaleWorlds.MountAndBlade.Module), nameof(TaleWorlds.MountAndBlade.Module.SetInitialModuleScreenAsRootScreen))]
    public class SkipSplashVideosPatch
    {
        static void Prefix(ref bool ____splashScreenPlayed)
        {
            ____splashScreenPlayed = true;
        }
    }
}
