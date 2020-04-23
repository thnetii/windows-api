using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11990
    [Flags]
    public enum JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS
    {
        JOBOBJECT_IO_ATTRIBUTION_CONTROL_ENABLE = 0x1,
        JOBOBJECT_IO_ATTRIBUTION_CONTROL_DISABLE = 0x2,
        JOBOBJECT_IO_ATTRIBUTION_CONTROL_VALID_FLAGS = 0x3
    }
}
