using Synapse.Api.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplosiveSCPS
{
    [PluginInformation(
        Author = "TheVoidNebula",
        Description = "Explode SCPs on their death.",
        LoadPriority = 0,
        Name = "ExplosiveSCPS",
        SynapseMajor = 2,
        SynapseMinor = 6,
        SynapsePatch = 0,
        Version = "1.0"
        )]
    public class Plugin : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section = "ExplosiveSCPS")]
        public static Config Config;
        public override void Load()
        {
            SynapseController.Server.Logger.Info("ExplosiveSCPS loaded!");

            new EventHandlers();
        }

        public override void ReloadConfigs()
        {

        }
    }
}
