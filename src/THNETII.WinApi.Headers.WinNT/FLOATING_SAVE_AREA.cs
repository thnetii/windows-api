using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;
using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 7494
    [StructLayout(LayoutKind.Sequential)]
    public struct FLOATING_SAVE_AREA
    {
        public int ControlWord;
        public int StatusWord;
        public int TagWord;
        public int ErrorOffset;
        public int ErrorSelector;
        public int DataOffset;
        public int DataSelector;
        #region public byte RegisterArea[SIZE_OF_80387_REGISTERS];
        private FieldRegisterArea fieldRegisterArea;
        [StructLayout(LayoutKind.Explicit, Size = sizeof(byte) * SIZE_OF_80387_REGISTERS)]
        private struct FieldRegisterArea { }
        public Span<byte> RegisterArea => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref fieldRegisterArea));
        #endregion

        public int Spare0;
    }
}
