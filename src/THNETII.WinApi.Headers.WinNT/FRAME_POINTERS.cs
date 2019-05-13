using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FRAME_POINTERS
    {
        public ulong MemoryStackFp;
        public ulong BackingStoreFp;
    }
}
