using BepInEx;
using HarmonyLib;

namespace TRInstantSpeedup;

[BepInPlugin(modGUID,modName,modVersion)]
public class Root : BaseUnityPlugin
{
    const string modGUID = "dev.rats159.tfwr.timed_reset_instant_speedup";
    const string modName = "Timed Reset Instant Speedup";
    const string modVersion = "1.0.0";

    public static Root Instance { get; private set; }
    public readonly Harmony harmony = new(modGUID);

    public void Awake()
    {
        Instance = this;
        harmony.PatchAll();
    }
}
