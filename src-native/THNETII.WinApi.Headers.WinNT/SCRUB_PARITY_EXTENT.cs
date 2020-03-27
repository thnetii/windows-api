using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13268
    [StructLayout(LayoutKind.Sequential)]
    public struct SCRUB_PARITY_EXTENT
    {
        public long Offset;

        public ulong Length;
    }
}
