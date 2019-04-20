using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15843
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_IDLESTATE_EVENT
    {
        public int NewState;
        public int OldState;
        public long Processors;
    }
}
