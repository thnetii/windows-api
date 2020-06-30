using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11428
    [StructLayout(LayoutKind.Sequential)]
    public struct WOW64_ARCHITECTURE_INFORMATION
    {
        private static readonly Bitfield32 BitfieldMachine = Bitfield32.LowBits(16);
        private static readonly Bitfield32 BitfieldKernelMode = Bitfield32.Bit(16);
        private static readonly Bitfield32 BitfieldUserMode = Bitfield32.Bit(17);
        private static readonly Bitfield32 BitfieldNative = Bitfield32.Bit(18);
        private static readonly Bitfield32 BitfieldProcess = Bitfield32.Bit(19);
        private static readonly Bitfield32 BitfieldReservedZero0 = Bitfield32.RemainingBits(20);

        private uint field;

        public short Machine
        {
            get => (short)BitfieldMachine.Read(field);
            set => BitfieldMachine.Write(ref field, (uint)value);
        }

        public bool KernelMode
        {
            get => BitfieldKernelMode.ReadBool(field);
            set => BitfieldKernelMode.WriteBool(ref field, value);
        }

        public bool UserMode
        {
            get => BitfieldUserMode.ReadBool(field);
            set => BitfieldUserMode.WriteBool(ref field, value);
        }

        public bool Native
        {
            get => BitfieldNative.ReadBool(field);
            set => BitfieldNative.WriteBool(ref field, value);
        }

        public bool Process
        {
            get => BitfieldProcess.ReadBool(field);
            set => BitfieldProcess.WriteBool(ref field, value);
        }
    }
}
