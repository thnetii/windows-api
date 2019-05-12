using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18025
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe struct IMAGE_HOT_PATCH_HASHES
    {
        public fixed byte SHA256[32];
        public fixed byte SHA1[20];
    }
}
