using Synapse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (Plugin.Config.IsEnabled)
            {
                switch (ev.Victim.RoleType)
                {
                    case RoleType.Scp049 when Plugin.Config.SCP049Explosion:
                    case RoleType.Scp0492 when Plugin.Config.SCP0492Explosion:
                    case RoleType.Scp096 when Plugin.Config.SCP096Explosion:
                    case RoleType.Scp106 when Plugin.Config.SCP106Explosion:
                    case RoleType.Scp173 when Plugin.Config.SCP173Explosion:
                    case RoleType.Scp93953 when Plugin.Config.SCP93953Explosion:
                    case RoleType.Scp93989 when Plugin.Config.SCP93989Explosion:
                        for (int i = 0; i < Plugin.Config.GrenadeFactor; i++)
                            Synapse.Api.Map.Get.SpawnGrenade(ev.Victim.Position, Vector3.zero, Plugin.Config.FuseTime, Synapse.Api.Enum.GrenadeType.Grenade, ev.Victim);
                        if (Plugin.Config.DeathMessageEnabled)
                            ev.Victim.SendBroadcast(Plugin.Config.DeathMessageTime, Plugin.Config.DeathMessage);
                        break;
                }
            }
        }
    }
}
