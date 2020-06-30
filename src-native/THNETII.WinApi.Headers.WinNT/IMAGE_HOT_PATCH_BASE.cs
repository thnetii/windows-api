using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18014
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_HOT_PATCH_BASE
    {
        public int SequenceNumber;
        public int Flags;
        public int OriginalTimeDateStamp;
        public int OriginalCheckSum;
        public int CodeIntegrityInfo;
        public int CodeIntegritySize;
        public int PatchTable;
        public int BufferOffset; // V2 and later
    }
}
