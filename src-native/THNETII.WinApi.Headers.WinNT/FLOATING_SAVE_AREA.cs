using System.ComponentModel;
using System.Runtime.InteropServices;

using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 7494
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FLOATING_SAVE_AREA
    {
        public int ControlWord;
        public int StatusWord;
        public int TagWord;
        public int ErrorOffset;
        public int ErrorSelector;
        public int DataOffset;
        public int DataSelector;
        public fixed byte RegisterArea[SIZE_OF_80387_REGISTERS];
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Spare0;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8594
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct WOW64_FLOATING_SAVE_AREA
    {
        public int ControlWord;
        public int StatusWord;
        public int TagWord;
        public int ErrorOffset;
        public int ErrorSelector;
        public int DataOffset;
        public int DataSelector;
        public fixed byte RegisterArea[WOW64_SIZE_OF_80387_REGISTERS];
        public int Cr0NpxState;
    }
}
