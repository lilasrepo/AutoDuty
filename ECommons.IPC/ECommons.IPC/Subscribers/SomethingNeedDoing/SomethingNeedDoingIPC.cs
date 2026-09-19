using System;

namespace ECommons.IPC.Subscribers.SomethingNeedDoing;

using EzIpcManager;

// gap-fill from NightmareXIV/ECommons.IPC ebb5baa9 (single-file B-dep gap-fill, CLAUDE.md sec 4 step 7)
public sealed class SomethingNeedDoingIPC : IPCBase
{
    public SomethingNeedDoingIPC()
    {
    }

    public SomethingNeedDoingIPC(SafeWrapper wrapper) : base(wrapper)
    {
    }

    public override string InternalName { get; } = "SomethingNeedDoing";

    [EzIPC] public Func<bool> IsAnyMacroRunning { get; private set; }
}
