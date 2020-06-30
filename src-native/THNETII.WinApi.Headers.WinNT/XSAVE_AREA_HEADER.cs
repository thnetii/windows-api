using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2567
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public unsafe struct XSAVE_AREA_HEADER
    {
        public ulong Mask;
        public ulong CompactionMask;
        public fixed ulong Reserved2[6];
    }
}
