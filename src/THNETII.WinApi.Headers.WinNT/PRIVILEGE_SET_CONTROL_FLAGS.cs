using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10331
    /// <summary>
    /// Privilege Set Control flags
    /// </summary>
    [Flags]
    public enum PRIVILEGE_SET_CONTROL_FLAGS
    {
        PRIVILEGE_SET_ALL_NECESSARY = WinNTConstants.PRIVILEGE_SET_ALL_NECESSARY,
    }
}
