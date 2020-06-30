using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17588
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_TLS_DIRECTORY64
    {
        public long StartAddressOfRawData;
        public long EndAddressOfRawData;
        public long AddressOfIndex;         // PDWORD
        public long AddressOfCallBacks;     // PIMAGE_TLS_CALLBACK *;
        public int SizeOfZeroFill;
        public int Characteristics;
        private static readonly Bitfield32 Reserved0Bitfield = Bitfield32.LowBits(20);
        private static readonly Bitfield32 AlignmentBitfield = Bitfield32.SelectBits(20, 4);
        private static readonly Bitfield32 Reserved1Bitfield = Bitfield32.SelectBits(24, 8);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved0
        {
            get => Reserved0Bitfield.Read(Characteristics);
            set => Reserved0Bitfield.Write(ref Characteristics, value);
        }
        public int Alignment
        {
            get => AlignmentBitfield.Read(Characteristics);
            set => AlignmentBitfield.Write(ref Characteristics, value);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved1
        {
            get => Reserved1Bitfield.Read(Characteristics);
            set => Reserved1Bitfield.Write(ref Characteristics, value);
        }
    }
}
