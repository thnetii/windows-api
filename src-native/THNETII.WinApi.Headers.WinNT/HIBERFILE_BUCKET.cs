using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16127
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct HIBERFILE_BUCKET
    {
        public ulong MaxPhysicalMemory;
        public fixed int PhysicalMemoryPercent[HIBERFILE_TYPE_MAX];
    }
}
