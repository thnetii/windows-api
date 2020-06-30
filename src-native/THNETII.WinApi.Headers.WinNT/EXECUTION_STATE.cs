using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15153
    [Flags]
    public enum EXECUTION_STATE : int
    {
        ES_SYSTEM_REQUIRED = WinNTConstants.ES_SYSTEM_REQUIRED,
        ES_DISPLAY_REQUIRED = WinNTConstants.ES_DISPLAY_REQUIRED,
        ES_USER_PRESENT = WinNTConstants.ES_USER_PRESENT,
        ES_AWAYMODE_REQUIRED = WinNTConstants.ES_AWAYMODE_REQUIRED,
        ES_CONTINUOUS = WinNTConstants.ES_CONTINUOUS,
    }
}
