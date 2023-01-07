using System.Reflection;
using UnityEngine;
using MelonLoader;

namespace SunOrientationFixes
{
    internal sealed class Implementation : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Debug.Log("[SunOrientationFixes] Version " + Assembly.GetExecutingAssembly().GetName().Version);
        }
    }
}

