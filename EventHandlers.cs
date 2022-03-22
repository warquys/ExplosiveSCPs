using Synapse;
using UnityEngine;

namespace ExplosiveSCPS
{
    public class EventHandlers
    {
        public EventHandlers()
        {
            Server.Get.Events.Player.PlayerDeathEvent += OnDeath;
        }

        public void OnDeath(Synapse.Api.Events.SynapseEventArguments.PlayerDeathEventArgs ev)
        {
            if (Plugin.Config.IsEnabled && Plugin.Config.ExplosiveRoles.Contains(ev.Victim.RoleID))
            {
                for (int i = 0; i < Plugin.Config.GrenadeFactor; i++)
                    Synapse.Api.Map.Get.SpawnGrenade(ev.Victim.Position, Vector3.zero, Plugin.Config.FuseTime, Synapse.Api.Enum.GrenadeType.Grenade, ev.Victim);
                if (Plugin.Config.DeathMessageEnabled)
                    ev.Victim.SendBroadcast(Plugin.Config.DeathMessageTime, Plugin.PluginTranslation.ActiveTranslation.DeathMessage);
            }
        }
    }
}
