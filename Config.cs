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

        [Description("Which Roles should allow a explosion on death?")]
        public List<int> ExplosiveRoles = new List<int>()
        {
            0
        };

        [Description("How long after the death should the explosion happen?")]
        public float FuseTime = 0.5f;

        [Description("How many grenades should explode on the death?")]
        public int GrenadeFactor = 3;

        [Description("Should a message be displayed for the dead SCP that just explode?")]
        public bool DeathMessageEnabled = false;

        [Description("The length the Death Message is being shown as a broadcast")]
        public ushort DeathMessageTime = 5;

        [Description("The death messages that is displayed for the dead SCP that just explode")]
        public string DeathMessage = "[ExplosiveSCPS] <color=red>Your death caused a big explosion!</color>";

    }
}
