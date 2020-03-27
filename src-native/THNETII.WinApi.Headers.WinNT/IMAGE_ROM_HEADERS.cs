using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16548
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_ROM_HEADERS
    {
        public IMAGE_FILE_HEADER FileHeader;
        public IMAGE_ROM_OPTIONAL_HEADER OptionalHeader;
    }
}
