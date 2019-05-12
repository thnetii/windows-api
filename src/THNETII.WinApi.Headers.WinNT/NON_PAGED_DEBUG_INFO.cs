using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18385
    [StructLayout(LayoutKind.Sequential)]
    public struct NON_PAGED_DEBUG_INFO
    {
        public short Signature;
        public short Flags;
        public int Size;
        public IMAGE_FILE_MACHINE_TYPE Machine;
        public IMAGE_DLLCHARACTERISTICS_FLAGS Characteristics;
        public int TimeDateStamp;
        public int CheckSum;
        public int SizeOfImage;
        public long ImageBase;
    }
}
