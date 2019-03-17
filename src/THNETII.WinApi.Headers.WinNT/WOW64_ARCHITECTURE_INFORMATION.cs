using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11428
    [StructLayout(LayoutKind.Sequential)]
    public struct WOW64_ARCHITECTURE_INFORMATION
    {
        private static readonly Bitfield32 BitfieldMachine = Bitfield32.DefineLowerBits(16);
        private static readonly Bitfield32 BitfieldKernelMode = Bitfield32.DefineMiddleBits(16, 1);
        private static readonly Bitfield32 BitfieldUserMode = Bitfield32.DefineMiddleBits(17, 1);
        private static readonly Bitfield32 BitfieldNative = Bitfield32.DefineMiddleBits(18, 1);
        private static readonly Bitfield32 BitfieldProcess = Bitfield32.DefineMiddleBits(19, 1);
        private static readonly Bitfield32 BitfieldReservedZero0 = Bitfield32.DefineHigherBits(12);

        private uint field;

        public short Machine
        {
            get => (short)BitfieldMachine.Read(field);
            set => BitfieldMachine.Write(ref field, (uint)value);
        }

        public bool KernelMode
        {
            get => BitfieldKernelMode.Read(field) != 0;
            set => BitfieldKernelMode.Write(ref field, value ? 1U : 0U);
        }

        public bool UserMode
        {
            get => BitfieldUserMode.Read(field) != 0;
            set => BitfieldUserMode.Write(ref field, value ? 1U : 0U);
        }

        public bool Native
        {
            get => BitfieldNative.Read(field) != 0;
            set => BitfieldNative.Write(ref field, value ? 1U : 0U);
        }

        public bool Process
        {
            get => BitfieldProcess.Read(field) != 0;
            set => BitfieldProcess.Write(ref field, value ? 1U : 0U);
        }
    }
}
