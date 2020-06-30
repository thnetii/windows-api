using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15864
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_THERMAL_POLICY_EVENT
    {
        public byte Mode;
        public long Processors;
    }
}
