using Synapse.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplosiveSCPS
{
    public class Config : AbstractConfigSection
    {
        [Description("Should ExplosiveSCPS be enabled?")]
        public bool IsEnabled = true;

        [Description("Should SCP-049 explode on their death?")]
        public bool SCP049Explosion = false;

        [Description("Should SCP-049-2 instances explode on their death?")]
        public bool SCP0492Explosion = false;

        [Description("Should SCP-096 explode on their death?")]
        public bool SCP096Explosion = false;

        [Description("Should SCP-106 explode on their death?")]
        public bool SCP106Explosion = false;

        [Description("Should SCP-173 explode on their death?")]
        public bool SCP173Explosion = true;

        [Description("Should SCP-939-53 explode on their death?")]
        public bool SCP93953Explosion = false;

        [Description("Should SCP-939-89 explode on their death?")]
        public bool SCP93989Explosion = false;

        [Description("How long after the death should the explosion happen?")]
        public float FuseTime = 0.5f;

        [Description("How many grenades should explode on the death?")]
        public int GrenadeFactor = 3;

        [Description("Should a message be displayed for the dead SCP that just explode?")]
        public bool DeathMessageEnabled = false;

        [Description("The time the Death Message is being shown as a broadcast")]
        public ushort DeathMessageTime = 5;

        [Description("The death messages that is displayed for the dead SCP that just explode")]
        public string DeathMessage = "[ExplosiveSCPS] <color=red>Your death caused a big explosion!</color>";

    }
}
