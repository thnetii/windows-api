using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15327
    [StructLayout(LayoutKind.Sequential)]
    public struct POWER_USER_PRESENCE
    {
        public POWER_USER_PRESENCE_TYPE UserPresence;
    }
}
