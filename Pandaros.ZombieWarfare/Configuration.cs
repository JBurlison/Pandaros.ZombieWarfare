using Pandaros.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandaros.ZombieWarfare
{
    [ModLoader.ModManager]
    internal class Configuration
    {
        public static CSModConfiguration ConfigurationBase { get; set; } = new CSModConfiguration(GameLoader.NAMESPACE);

        public static bool TeleportPadsRequireMachinists
        {
            get => GetorDefault(nameof(TeleportPadsRequireMachinists), false);
            private set => SetValue(nameof(TeleportPadsRequireMachinists), value);
        }

        public static bool HasSetting(string setting)
        {
            return Configuration.HasSetting(setting);
        }


        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, GameLoader.NAMESPACE + ".Configuration.AfterSelectedWorld")]
        [ModLoader.ModCallbackDependsOn(GameLoader.NAMESPACE + ".AfterSelectedWorld")]
        public static void AfterSelectedWorld()
        {
        }

        public static T GetorDefault<T>(string key, T defaultVal)
        {
            return ConfigurationBase.GetorDefault(key, defaultVal);
        }

        public static void SetValue<T>(string key, T val)
        {
            ConfigurationBase.SetValue(key, val);
        }
    }
}
