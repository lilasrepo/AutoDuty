// TODO(api12): Dalamud.Plugin.VersionInfo namespace + IDalamudVersionInfo + Svc.PluginInterface.GetDalamudVersion() are API15-only.
// AutoDuty uses this only to detect staging Dalamud builds; for TC client we always return false.
using System;

namespace AutoDuty.Helpers
{
    internal static class DalamudHelper
    {
        public static bool IsOnStaging() => false;
    }
}
