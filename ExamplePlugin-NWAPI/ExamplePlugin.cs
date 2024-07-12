using HarmonyLib;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;

namespace ExamplePlugin
{
    internal class ExamplePlugin
    {
        public ExamplePlugin() { }

        public Harmony Harmony { get; private set; }

        public static ExamplePlugin Singleton { get; private set; }

        [PluginEntryPoint("Example Plugin", "1.0.0", "萌新天堂服务器插件", "l4kkS41")]
        void LoadPlugin()
        {
            ExamplePlugin.Singleton = this;

            EventManager.RegisterEvents<EventHandlers>(this);

            Harmony = new Harmony("l4kkS41.HarmonyPatch");
            Harmony.PatchAll();

            PluginHandler pluginHandler = PluginHandler.Get(this);

            Log.Info($"{pluginHandler.PluginName} Has Been Loaded Successfully :)");
        }
    }
}