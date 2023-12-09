using HarmonyLib;

namespace FastDock
{
    [HarmonyPatch(typeof(DockPOIHandler), nameof(DockPOIHandler.OnPressBegin))]
    internal static class DockPOIHandlerPatch
    {
        public static void Postfix()
        {
            GameManager.Instance.Player.Controller._autoMoveSpeed = 3f;
            GameManager.Instance.Player.Controller._lookSpeed = 3f;
        }
    }
}
