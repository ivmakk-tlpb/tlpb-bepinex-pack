using BepInEx;
using BepInEx.Unity.IL2CPP;

namespace LoadCheck;

[BepInPlugin(PluginGuid, "LoadCheck", "1.0.0")]
public class Plugin : BasePlugin
{
    public const string PluginGuid = "com.ivmakk.thelastplagueblight.loadcheck";

    public override void Load()
    {
        Log.LogInfo("LoadCheck loaded");
    }
}
