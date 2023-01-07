using MelonLoader;
using System.Reflection;


[assembly: AssemblyTitle(BuildInfo.ModName)]
[assembly: AssemblyCopyright($"Created by ModAuthor")]

[assembly: AssemblyVersion(BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(BuildInfo.ModVersion)]
[assembly: MelonInfo(typeof(SunOrientationFixes.Implementation), BuildInfo.ModName, BuildInfo.ModVersion, BuildInfo.ModAuthor)]

[assembly: MelonGame("Hinterland", "TheLongDark")]

internal static class BuildInfo
{
	internal const string ModName = "SunOrientationFixes";
	internal const string ModAuthor = "GruffCassquatch";
	internal const string ModVersion = "2.0.0";
}