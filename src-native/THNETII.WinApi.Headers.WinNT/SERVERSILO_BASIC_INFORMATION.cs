using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12209
    [StructLayout(LayoutKind.Sequential)]
    public struct SERVERSILO_BASIC_INFORMATION
    {
        public int ServiceSessionId;
        public SERVERSILO_STATE State;
        public int ExitStatus;
    }
}
