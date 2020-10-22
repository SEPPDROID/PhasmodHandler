# PhasmodHandler
A MelonLoader Mod for phasmophobia, that's intention was to be a mod handler you can use to make mods more easy. + Discord Rich presence.

_Jump to the [Install section](#How-to-install)._

##### I do not have time to finish this (or the knowledge for that matter), so here it is for everybody to enjoy!

I was prepairing for the beta branch to be pushed to master. That is because making MONO mods is a piece of cake. But Phasmophobia is changing to the IL2CPP scripting 
engine and that wil make it a bit harder. Andthus did this project started, but will never see an full release by me...

## What it should have done:

- Create and invite people with your code in discord. (injecting the invite code to the LobbyManager)
- Be part of a Modified MelonLoader install called Phasmodloader with all the changes to handle specific IL2CPP Phasmophobia mods
- Handle rich presence for other mods.
- Show the level picture in blue when you are in a dead state (discord RPC)

## What it can do:

- Show you in what level you are in PhasMODphobia. (im trying not to use their name)
- nothing else, i completely stripped it from the other functions

I should've called it "Phasmophobia Rich presence"

### Q: Can i use your code for my project?
A: Yes, just keep the original credits in the "DiscordRpc" file. They belong to [Slaynash](https://github.com/Slaynash)
```csharp
/// <summary>
/// Credit to https://github.com/Slaynash
/// </summary>
```
### Q: Can i push changes to your project?
A: Ofcourse, actually; YES! Please. 
Im in no way a good c# programmer. Im a hobby-programmer so your work will always be better then mine. Contributing is always cool 😎

# How to install
* If you haven't done so already, install MelonLoader by downloading and running [MelonLoader.Installer.exe](https://github.com/HerpDerpinstine/MelonLoader/releases/latest/download/MelonLoader.Installer.exe).
* Download the latest version of ["PhasmodHandlerMod.rar"](https://github.com/SEPPDROID/PhasmodHandler/releases/download/1.1.0/PhasmodHandlerMod.rar) from the [releases page](https://github.com/SEPPDROID/PhasmodHandler/releases/latest).
* Extract and move PhasmodHandler.dll into the "Mods" folder & the PhasmodHandler folder into your TLD install directory.

### Alternative install:
* Download the latest version of ["PhasmodLoader.rar"](https://github.com/SEPPDROID/PhasmodHandler/releases/download/1.1.0/PhasmodLoader.rar) from from the [releases page](https://github.com/SEPPDROID/PhasmodHandler/releases/latest) and extract all the files to you TLD install directory.

> (**Tip:** TLD Install directory can be found by rightclicking Phasmophobia in steam then going to Properties and clicking on browse local files)


## Notes:
#### PhasmodLoader 1.1.0

Phasmodloader 1.1.0 is based on MelonLoader version 0.2.7.2. Actually the one i uncluded in the release tab is basically the same as the original, i completely stripped all the functions from my original modified MelonLoader install. And the discordRPC function has been made into a mod. So i would just recommend installing the mod + MelonLoader and not the PhasmodLoader. Since MelonLoader will be updated and PhasmodLoader not...
> ##### Please note that the RPC mod does not work out of the box on the MONO version of phasmophobia. It will look for the dll in the Managed folder instead of the TLD. An easy fix would be copying the "PhasmodLoader" folder to "Managed" 
All credits go to [HerpDerpinstine](https://github.com/HerpDerpinstine/MelonLoader) and "Java Gang" (as far as i can remember). They did outstanding and a amazing job with MelonLoader.

#### Some pictures:

![Captures_discord_rpc](https://downloads.diodematrix.com/u/seppdroid/pictures/phasmod/Capture.JPG)
![Captures_discord_rpc](https://downloads.diodematrix.com/u/seppdroid/pictures/phasmod/Capture2.JPG)
![Captures_discord_rpc](https://downloads.diodematrix.com/u/seppdroid/pictures/phasmod/Capture3.JPG)
![Captures_discord_rpc](https://downloads.diodematrix.com/u/seppdroid/pictures/phasmod/Capture4.JPG)
