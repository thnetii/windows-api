using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18005
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_HOT_PATCH_INFO
    {
        public int Version;
        public int Size;
        public int SequenceNumber;
        public int BaseImageList;
        public int BaseImageCount;
        public int BufferOffset; // V2 and later
    }
}
