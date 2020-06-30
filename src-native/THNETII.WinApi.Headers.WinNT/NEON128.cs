using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NEON128
    {
        public ulong Low;
        public long High;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct ARM64_NT_NEON128
    {
        [FieldOffset(0)]
        public NEON128 Neon128;
        [FieldOffset(0)]
        public fixed double D[2];
        [FieldOffset(0)]
        public fixed float S[4];
        [FieldOffset(0)]
        public fixed short H[8];
        [FieldOffset(0)]
        public fixed byte B[16];
    }
}
