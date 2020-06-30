using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17888
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER
    {
        public int EpilogueCount;
        public byte EpilogueByteCount;
        public byte BranchDescriptorElementSize;
        public short BranchDescriptorCount;
        // BYTE    BranchDescriptors[...];
        // BYTE    BranchDescriptorBitMap[...];

    }
}
