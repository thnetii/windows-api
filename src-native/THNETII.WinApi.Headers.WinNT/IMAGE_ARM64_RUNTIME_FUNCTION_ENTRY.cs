using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18107
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY
    {
        public int BeginAddress;
        public int UnwindData;
        private static readonly Bitfield32 FlagBitfield = Bitfield32.SelectBits(0, 2);
        private static readonly Bitfield32 FunctionLengthBitfield = Bitfield32.SelectBits(2, 11);
        private static readonly Bitfield32 RegFBitfield = Bitfield32.SelectBits(13, 3);
        private static readonly Bitfield32 RegIBitfield = Bitfield32.SelectBits(16, 4);
        private static readonly Bitfield32 HBitfield = Bitfield32.SelectBits(20, 1);
        private static readonly Bitfield32 CRBitfield = Bitfield32.SelectBits(21, 2);
        private static readonly Bitfield32 FrameSizeBitfield = Bitfield32.SelectBits(23, 9);
        public int Flag
        {
            get => FlagBitfield.Read(UnwindData);
            set => FlagBitfield.Write(ref UnwindData, value);
        }
        public int FunctionLength
        {
            get => FunctionLengthBitfield.Read(UnwindData);
            set => FunctionLengthBitfield.Write(ref UnwindData, value);
        }
        public int RegF
        {
            get => RegFBitfield.Read(UnwindData);
            set => RegFBitfield.Write(ref UnwindData, value);
        }
        public int RegI
        {
            get => RegIBitfield.Read(UnwindData);
            set => RegIBitfield.Write(ref UnwindData, value);
        }
        public bool H
        {
            get => HBitfield.ReadBool(UnwindData);
            set => HBitfield.WriteBool(ref UnwindData, value);
        }
        public int CR
        {
            get => CRBitfield.Read(UnwindData);
            set => CRBitfield.Write(ref UnwindData, value);
        }
        public int FrameSize
        {
            get => FrameSizeBitfield.Read(UnwindData);
            set => FrameSizeBitfield.Write(ref UnwindData, value);
        }
    }
}
