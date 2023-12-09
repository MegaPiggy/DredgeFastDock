using HarmonyLib;
using System.Reflection;
using Winch.Core;

namespace FastDock
{
    public static class Main
    {
        public static void Initialize()
        {
            new Harmony("com.megapiggy.fastdock").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
