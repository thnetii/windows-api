using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18421
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_ARCHITECTURE_HEADER
    {
        internal int Attributes;
        private static readonly Bitfield32 AmaskValueBitfield = Bitfield32.Bit(0);
        private static readonly Bitfield32 MustBeZeroBitfield1 = Bitfield32.SelectBits(1, 7);
        private static readonly Bitfield32 AmaskShiftBitfield = Bitfield32.SelectBits(8, 8);
        private static readonly Bitfield32 MustBeZeroBitfield2 = Bitfield32.RemainingBits(16);
        /// <summary>
        /// <para><see langword="true"/> -> code section depends on mask bit</para>
        /// <para><see langword="false"/> -> new instruction depends on mask bit</para>
        /// </summary>
        public bool AmaskValue
        {
            get => AmaskValueBitfield.ReadBool(Attributes);
            set => AmaskValueBitfield.WriteBool(ref Attributes, value);
        }
        /// <summary>
        /// Amask bit in question for this fixup
        /// </summary>
        public int AmaskShift
        {
            get => AmaskShiftBitfield.Read(Attributes);
            set => AmaskShiftBitfield.Write(ref Attributes, value);
        }
        /// <summary>
        /// RVA into .arch section to array of <see cref="IMAGE_ARCHITECTURE_ENTRY"/>'s
        /// </summary>
        public int FirstEntryRVA;
    }
}
