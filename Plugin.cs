using Synapse.Api.Plugin;

namespace ExplosiveSCPS
{
    [PluginInformation(
        Author = "TheVoidNebula, update by VT",
        Description = "Explode SCPs on their death.",
        LoadPriority = 0,
        Name = "ExplosiveSCPS",
        SynapseMajor = 2,
        SynapseMinor = 6,
        SynapsePatch = 0,
        Version = "v1.2.0"
        )]
    public class Plugin : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section = "ExplosiveSCPS")]
        public static Config Config;

        [SynapseTranslation]
        public static Synapse.Translation.SynapseTranslation<PluginTranslation> PluginTranslation;

        public override void Load()
        {
            SynapseController.Server.Logger.Info("ExplosiveSCPS loaded!");

            PluginTranslation.AddTranslation(new PluginTranslation());

            PluginTranslation.AddTranslation(new PluginTranslation
            {
                DeathMessage = "[ExplosiveSCPS] <color=red>Dein Tod verursachte eine Grosse Explosion!</ color>"

            }, "GERMAN");

            PluginTranslation.AddTranslation(new PluginTranslation
            {
                DeathMessage = "[ExplosiveSCPS] <color=red>Votre mort a provoqué une grosse explosion !</color>"

            }, "FRENCH");

            //Feel free to ask me or create a PR in order to add more languages

            new EventHandlers();
        }
    }
}
