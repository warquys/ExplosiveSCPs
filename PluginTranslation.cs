using Synapse.Translation;
using System.ComponentModel;

namespace ExplosiveSCPS
{
    public class PluginTranslation : IPluginTranslation
    {
        [Description("The death messages that is displayed for the dead SCP that just explode")]
        public string DeathMessage = "[ExplosiveSCPS] <color=red>Your death caused a big explosion!</color>";
    }
}
