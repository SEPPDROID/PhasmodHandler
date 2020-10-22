using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Text;
using System.Runtime.InteropServices;
using MelonLoader;
using DiscordRichPresense;
using Harmony;
using UnityEngine.UI;
using UnityEngine;

namespace Mod
{
    public static class BuildInfo
    {
        public const string Name = "PhasmodHandler"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Mod for handling specific Phasmophobia mods"; // Description for the Mod.  (Set as null if none)
        public const string Author = "seppdroid"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.3"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class Mod : MelonMod
    {
        private const string DiscordAppID = "767737509656002601";
        public static readonly DiscordRpc.RichPresence Presence = new DiscordRpc.RichPresence();

        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            var handlers = new DiscordRpc.EventHandlers();
            DiscordRpc.Initialize(DiscordAppID, ref handlers, false, string.Empty);
            Presence.state = "Starting game...";
            Presence.details = "Playing PhasMODphobia";
            Presence.startTimestamp = default(long);
            Presence.largeImageKey = "phasmod";
            Presence.largeImageText = "Phasmodphobia";
            Presence.smallImageKey = "phasmod";
            Presence.smallImageText = "phasmomod";
            DiscordRpc.UpdatePresence(Presence);

            MelonLogger.Log("[log] Phasmophobia Mod Handler has started");
        }

        public override void OnLevelIsLoading() // Runs when a Scene is Loading or when a Loading Screen is Shown. Currently only runs if the Mod is used in BONEWORKS.
        {
            MelonLogger.Log("[log] Loading level");
        }

        public override void OnLevelWasLoaded(int level) // Runs when a Scene has Loaded.
        {
            if (level == 1)
            {
                Presence.state = "In Main Menu Lobby";
                Presence.details = "Playing PhasMODphobia";
                Presence.largeImageKey = "lobby";
                Presence.largeImageText = "Phasmodphobia";
                Presence.smallImageKey = "phasmod";
                Presence.smallImageText = "phasmomod";
                DiscordRpc.UpdatePresence(Presence);
                MelonLogger.Log("[log] RPC Status changed");

            }
            if (level == 2)
            {
                Presence.state = "In Tanglewood Street";
                Presence.details = "Playing PhasMODphobia";
                Presence.largeImageKey = "tanglewood";
                Presence.largeImageText = "Tanglewood Street House";
                Presence.smallImageKey = "phasmod";
                Presence.smallImageText = "phasmomod";
                DiscordRpc.UpdatePresence(Presence);
                MelonLogger.Log("[log] RPC Status changed");
            }
            if (level == 3)
            {
                Presence.state = "In Asylum";
                Presence.details = "Playing PhasMODphobia";
                Presence.largeImageKey = "asylum";
                Presence.largeImageText = "Asylum";
                Presence.smallImageKey = "phasmod";
                Presence.smallImageText = "phasmomod";
                DiscordRpc.UpdatePresence(Presence);
                MelonLogger.Log("[log] RPC Status changed");
            }
            if (level == 4)
            {
                Presence.state = "In Edgefield Street House";
                Presence.details = "Playing PhasMODphobia";
                Presence.largeImageKey = "streethouse";
                Presence.largeImageText = "Edgefield Street House";
                Presence.smallImageKey = "phasmod";
                Presence.smallImageText = "phasmomod";
                DiscordRpc.UpdatePresence(Presence);
                MelonLogger.Log("[log] RPC Status changed");
            }
            if (level == 5)
            {
                Presence.state = "In Ridgefield Road House";
                Presence.details = "Playing PhasMODphobia";
                Presence.largeImageKey = "ridgefield";
                Presence.largeImageText = "Ridgefield Road House";
                Presence.smallImageKey = "phasmod";
                Presence.smallImageText = "phasmomod";
                DiscordRpc.UpdatePresence(Presence);
                MelonLogger.Log("[log] RPC Status changed");
            }
            if (level == 6)
            {
                Presence.state = "In Brownstone Highschool";
                Presence.details = "Playing PhasMODphobia";
                Presence.largeImageKey = "brownstone";
                Presence.largeImageText = "Brownstone Highschool";
                Presence.smallImageKey = "phasmod";
                Presence.smallImageText = "phasmomod";
                DiscordRpc.UpdatePresence(Presence);
                MelonLogger.Log("[log] RPC Status changed");
            }
            if (level == 7)
            {
                Presence.state = "In Bleasdale Farmhouse";
                Presence.details = "Playing PhasMODphobia";
                Presence.largeImageKey = "bleasdale";
                Presence.largeImageText = "Bleasdale Farmhouse";
                Presence.smallImageKey = "phasmod";
                Presence.smallImageText = "phasmomod";
                DiscordRpc.UpdatePresence(Presence);
                MelonLogger.Log("[log] RPC Status changed");
            }
            if (level == 8)
            {
                Presence.state = "In Grafton Farmhouse";
                Presence.details = "Playing PhasMODphobia";
                Presence.largeImageKey = "grafton";
                Presence.largeImageText = "Grafton Farmhouse";
                Presence.smallImageKey = "phasmod";
                Presence.smallImageText = "phasmomod";
                DiscordRpc.UpdatePresence(Presence);
                MelonLogger.Log("[log] RPC Status changed");
            }
            // else and set an undefined level so you wont be in the main lobby if you play a map above 8? 

            MelonLogger.Log("[log] loadedlevel: " + level.ToString());
        }

        public override void OnLevelWasInitialized(int level) // Runs when a Scene has Initialized.
        {
            MelonLogger.Log("[log] initlevel: " + level.ToString());

        }
        public override void OnUpdate()
        {
            DiscordRpc.RunCallbacks(); // for if we are going to handle invites... 
        }

        

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            DiscordRpc.Shutdown();
            MelonLogger.Log("[log] Phasmophobia closed");
        }
    }
}