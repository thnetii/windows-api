using System.Runtime.InteropServices;

namespace THNETII.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct XSAVE_AREA_HEADER
    {
        public ulong Mask;
        public ulong CompactionMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        internal ulong[] Reserved2;
    }
}
