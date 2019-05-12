using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18089
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_ARM_RUNTIME_FUNCTION_ENTRY
    {
        public int BeginAddress;
        public int UnwindData;
        private static readonly Bitfield32 FlagBitfield = Bitfield32.SelectBits(0, 2);
        private static readonly Bitfield32 FunctionLengthBitfield = Bitfield32.SelectBits(2, 11);
        private static readonly Bitfield32 RetBitfield = Bitfield32.SelectBits(13, 2);
        private static readonly Bitfield32 HBitfield = Bitfield32.SelectBits(15, 1);
        private static readonly Bitfield32 RegBitfield = Bitfield32.SelectBits(16, 3);
        private static readonly Bitfield32 RBitfield = Bitfield32.SelectBits(19, 1);
        private static readonly Bitfield32 LBitfield = Bitfield32.SelectBits(20, 1);
        private static readonly Bitfield32 CBitfield = Bitfield32.SelectBits(21, 1);
        private static readonly Bitfield32 StackAdjustBitfield = Bitfield32.SelectBits(22, 10);
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
        public int Ret
        {
            get => RetBitfield.Read(UnwindData);
            set => RetBitfield.Write(ref UnwindData, value);
        }
        public bool H
        {
            get => HBitfield.ReadBool(UnwindData);
            set => HBitfield.WriteBool(ref UnwindData, value);
        }
        public int Reg
        {
            get => RegBitfield.Read(UnwindData);
            set => RegBitfield.Write(ref UnwindData, value);
        }
        public bool R
        {
            get => RBitfield.ReadBool(UnwindData);
            set => RBitfield.WriteBool(ref UnwindData, value);
        }
        public bool L
        {
            get => LBitfield.ReadBool(UnwindData);
            set => LBitfield.WriteBool(ref UnwindData, value);
        }
        public bool C
        {
            get => CBitfield.ReadBool(UnwindData);
            set => CBitfield.WriteBool(ref UnwindData, value);
        }
        public int StackAdjust
        {
            get => StackAdjustBitfield.Read(UnwindData);
            set => StackAdjustBitfield.Write(ref UnwindData, value);
        }
    }
}
