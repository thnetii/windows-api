using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Define 128-bit 16-byte aligned xmm register type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public struct M128A
    {
        public ulong Low;
        public long High;
    }
}
