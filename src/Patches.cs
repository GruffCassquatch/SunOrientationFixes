using HarmonyLib;
using Il2Cpp;

namespace SunOrientationFixes
{
    [HarmonyPatch(typeof(Weather), "Start")]
    internal static class UpdateRegionRotation
    {
        private static void Postfix(Weather __instance)
        {
            __instance.m_RegionOrientationValues[0].m_RotationDegrees = 260; // Mystery Lake
            __instance.m_RegionOrientationValues[2].m_RotationDegrees = 250; // Pleasant Valley
            __instance.m_RegionOrientationValues[7].m_RotationDegrees = 260; // Broken Railroad
            __instance.m_RegionOrientationValues[8].m_RotationDegrees = 305; // Ravine
            __instance.m_RegionOrientationValues[9].m_RotationDegrees = 250; // Winding River
        }
    }
}
