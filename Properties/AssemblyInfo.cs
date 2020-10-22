using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(Mod.BuildInfo.Description)]
[assembly: AssemblyDescription(Mod.BuildInfo.Description)]
[assembly: AssemblyCompany(Mod.BuildInfo.Company)]
[assembly: AssemblyProduct(Mod.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + Mod.BuildInfo.Author)]
[assembly: AssemblyTrademark(Mod.BuildInfo.Company)]
[assembly: AssemblyVersion(Mod.BuildInfo.Version)]
[assembly: AssemblyFileVersion(Mod.BuildInfo.Version)]
[assembly: MelonInfo(typeof(Mod.Mod), Mod.BuildInfo.Name, Mod.BuildInfo.Version, Mod.BuildInfo.Author, Mod.BuildInfo.DownloadLink)]


// Create and Setup a MelonGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonGameAttribute is found or any of the Values for any MelonGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonMame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Kinetic Games", "Phasmophobia")]