using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum VER_FLAGS : int
    {
        VER_SERVER_NT = WinNTConstants.VER_SERVER_NT,
        VER_WORKSTATION_NT = WinNTConstants.VER_WORKSTATION_NT,
    }
}
