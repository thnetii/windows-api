using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17560
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public struct IMAGE_THUNK_DATA32
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
