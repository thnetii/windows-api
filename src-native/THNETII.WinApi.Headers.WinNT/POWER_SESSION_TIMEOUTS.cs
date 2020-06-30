using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15339
    [StructLayout(LayoutKind.Sequential)]
    public struct POWER_SESSION_TIMEOUTS
    {
        public int InputTimeout;
        public int DisplayTimeout;
    }
}
