# ExplosiveSCPs
Explode SCPs on their death.!

[![forthebadge](https://forthebadge.com/images/badges/built-with-love.svg)](https://forthebadge.com)[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)[![forthebadge](https://forthebadge.com/images/badges/you-didnt-ask-for-this.svg)](https://forthebadge.com)

## Features
* Decide which Roles explode on their death
* Decide how strong the explosion is
* Decide when the explosion happens

## Installation
1. [Install Synapse](https://github.com/SynapseSL/Synapse/wiki#hosting-guides)
2. Place the ExplosiveSCPS.dll file that you can download [here](https://github.com/TheVoidNebula/ExplosiveSCPS/releases) in your plugin directory
3. Restart/Start your server.


## Config
Name  | Type | Default | Description
------------ | ------------ | ------------- | ------------ 
`IsEnabled` | Boolean | true | Is this plugin enabled?
`ExplosiveRoles` | List<Int> | 0 | Which roles should explode on their death?
`FuseTime` | float | 0.5f | How long after the death should the explosion happen?
`GrenadeFactor` | int | 3 | How many grenades should explode on the death?
`DeathMessageEnabled` | bool | false | Should a message be displayed for the dead SCP that just explode?
`DeathMessageTime` | ushort | 5 | The length the Death Message is being shown as a broadcast
`DeathMessage` | string | [ExplosiveSCPS] Your death caused a big explosion! | The death messages that is displayed for the dead SCP that just explode

## Config.yml
```yml
[ExplosiveSCPS]
{
# Should ExplosiveSCPS be enabled?
isEnabled: true
# Should SCP-049 explode on their death?
explosiveRoles:
- 0
# How long after the death should the explosion happen?
fuseTime: 0.5
# How many grenades should explode on the death?
grenadeFactor: 3
# Should a message be displayed for the dead SCP that just explode?
deathMessageEnabled: false
# The length the Death Message is being shown as a broadcast
deathMessageTime: 5
# The death messages that is displayed for the dead SCP that just explode
deathMessage: '::lcb::ExplosiveSCPS::rcb:: <color=red>Your death caused a big explosion!</color>'
}
```
