using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17548
    [StructLayout(LayoutKind.Explicit, Pack = 8)]
    public struct IMAGE_THUNK_DATA64
    {
        [FieldOffset(0)]
        public long ForwarderString;
        [FieldOffset(0)]
        public long Function;
        [FieldOffset(0)]
        public long Ordinal;
        [FieldOffset(0)]
        public long AddressOfData;
    }
}
