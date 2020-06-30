using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_BASE_RELOCATION
    {
        public int VirtualAddress;
        public int SizeOfBlock;
        // public short TypeOffset;
    }
}
