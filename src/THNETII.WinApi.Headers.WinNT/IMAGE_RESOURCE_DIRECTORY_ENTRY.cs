using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17728
    /// <summary>
    /// Each directory contains the 32-bit Name of the entry and an offset,
    /// relative to the beginning of the resource directory of the data associated
    /// with this directory entry.  If the name of the entry is an actual text
    /// string instead of an integer Id, then the high order bit of the name field
    /// is set to one and the low order 31-bits are an offset, relative to the
    /// beginning of the resource directory of the string, which is of type
    /// <see cref="IMAGE_RESOURCE_DIRECTORY_STRING"/>.  Otherwise the high bit is clear and the
    /// low-order 16-bits are the integer Id that identify this resource directory
    /// entry. If the directory entry is yet another resource directory (i.e. a
    /// subdirectory), then the high order bit of the offset field will be
    /// set to indicate this.  Otherwise the high bit is clear and the offset
    /// field points to a resource data entry.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public struct IMAGE_RESOURCE_DIRECTORY_ENTRY
    {
        private static readonly Bitfield32 NameOffsetBitfield = Bitfield32.LowBits(31);
        private static readonly Bitfield32 NameIsStringBitfield = Bitfield32.Bit(31);
        [FieldOffset(0)]
        public int Name;
        public int NameOffset
        {
            get => NameOffsetBitfield.Read(Name);
            set => NameOffsetBitfield.Write(ref Name, value);
        }
        public bool NameIsString
        {
            get => NameIsStringBitfield.ReadBool(Name);
            set => NameIsStringBitfield.WriteBool(ref Name, value);
        }
        [FieldOffset(0)]
        public short Id;
        private static readonly Bitfield32 OffsetToDirectoryBitfield = Bitfield32.LowBits(31);
        private static readonly Bitfield32 DataIsDirectoryBitfield = Bitfield32.Bit(31);
        [FieldOffset(sizeof(int))]
        public int OffsetToData;
        public int OffsetToDirectory
        {
            get => OffsetToDirectoryBitfield.Read(OffsetToData);
            set => OffsetToDirectoryBitfield.Write(ref OffsetToData, value);
        }
        public bool DataIsDirectory
        {
            get => DataIsDirectoryBitfield.ReadBool(OffsetToData);
            set => DataIsDirectoryBitfield.WriteBool(ref OffsetToData, value);
        }
    }
}
