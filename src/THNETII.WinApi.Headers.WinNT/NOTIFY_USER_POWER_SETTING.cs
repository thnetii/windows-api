using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15494
    [StructLayout(LayoutKind.Sequential)]
    public struct NOTIFY_USER_POWER_SETTING
    {
        public Guid Guid;
    }
}
