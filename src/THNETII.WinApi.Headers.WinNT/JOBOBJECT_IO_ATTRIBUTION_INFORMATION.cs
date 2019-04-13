using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12005
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_IO_ATTRIBUTION_INFORMATION
    {
        public JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS ControlFlags;

        public JOBOBJECT_IO_ATTRIBUTION_STATS ReadStats;
        public JOBOBJECT_IO_ATTRIBUTION_STATS WriteStats;
    }
}
