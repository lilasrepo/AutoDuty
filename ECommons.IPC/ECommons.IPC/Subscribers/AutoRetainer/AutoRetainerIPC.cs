using ECommons.EzIpcManager;
using System;
using static ECommons.IPC.Subscribers.AutoRetainer.AutoRetainerIPC.Delegates;

namespace ECommons.IPC.Subscribers.AutoRetainer;

public sealed class AutoRetainerIPC : IPCBase
{
    public AutoRetainerIPC()
    {
    }

    public AutoRetainerIPC(SafeWrapper wrapper) : base(wrapper)
    {
    }

    public static class Delegates
    {
        public delegate bool? AreAnyEnabledVesselsNotDeployed(ulong contentId);
        public delegate bool? AreAnyEnabledVesselsReady(ulong contentId);
    }

    public override string InternalName { get; } = "AutoRetainer";

    [EzIPC("AutoRetainer.GC.EnqueueInitiation", false)] public Action EnqueueInitiation { get; private set; }
    [EzIPC("PluginState.AbortAllTasks")] public Action AbortAllTasks { get; private set; }
    [EzIPC("PluginState.DisableAllFunctions")] public Action DisableAllFunctions { get; private set; }
    [EzIPC("PluginState.EnableMultiMode")] public Action EnableMultiMode { get; private set; }
    // gap-fill 2026-08-30: upstream AutoDuty now calls EnableSingleMultiMode; the vendored
    // ECommons.IPC predates it. Copied verbatim from the Splatoon donor tree. EzIPC binds
    // lazily, so an AutoRetainer without this channel simply leaves it unbound.
    [EzIPC("PluginState.EnableSingleMultiMode")] public Action<MultiModeType?> EnableSingleMultiMode { get; private set; }
    [EzIPC("PluginState.IsBusy")] public Func<bool> IsBusy { get; private set; }
    [EzIPC("PluginState.GetInventoryFreeSlotCount")] public Func<int> GetInventoryFreeSlotCount { get; private set; }
    [EzIPC("PluginState.EnqueueHET")] public Action<bool, bool> EnqueueHET { get; private set; }
    [EzIPC("PluginState.IsItemProtected")] public Func<uint, bool> IsItemProtected { get; private set; }
    [EzIPC("PluginState.GetMultiModeStatus")] public Func<bool> GetMultiModeStatus { get; private set; }
    [EzIPC("PluginState.GetClosestRetainerVentureSecondsRemaining")] public Func<ulong, long?> GetClosestRetainerVentureSecondsRemaining { get; private set; }
    [EzIPC("PluginState.AreAnyRetainersAvailableForCurrentChara")] public Func<bool> AreAnyRetainersAvailableForCurrentChara { get; private set; }
    [EzIPC("PluginState.AreAnyEnabledVesselsNotDeployed")] public Func<ulong, bool?> AreAnyEnabledVesselsNotDeployed { get; private set; }
    [EzIPC("PluginState.AreAnyEnabledVesselsReady")] public Func<ulong, bool?> AreAnyEnabledVesselsReady { get; private set; }
}