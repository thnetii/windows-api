using System.ComponentModel;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    using static IMAGE_FILE_MACHINE_TYPE;
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18437
    /// <summary>
    /// This structure defines the new import object.
    /// </summary>
    /// <remarks>
    /// <note>
    /// Note the values of the first two fields,
    /// which must be set as stated in order to differentiate old and new import members.
    /// Following this structure, the linker emits two null-terminated strings used to recreate the
    /// import at the time of use.  The first string is the import's name, the second is the dll's name.
    /// </note>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMPORT_OBJECT_HEADER
    {
        /// <summary>
        /// Must be <see cref="IMAGE_FILE_MACHINE_UNKNOWN"/>
        /// </summary>
        public IMAGE_FILE_MACHINE_TYPE Sig1;
        /// <summary>
        /// Must be <see cref="IMPORT_OBJECT_HDR_SIG2"/>.
        /// </summary>
        public short Sig2;
        public short Version;
        public IMAGE_FILE_MACHINE_TYPE Machine;
        /// <summary>
        /// Time/date stamp
        /// </summary>
        public int TimeDateStamp;
        /// <summary>
        /// particularly useful for incremental links
        /// </summary>
        public int SizeOfData;

        /// <summary>
        /// if grf &amp; IMPORT_OBJECT_ORDINAL
        /// </summary>
        public short Ordinal;
        #region public short Hint;
        public short Hint
        {
            get => Ordinal;
            set => Ordinal = value;
        }
        #endregion

        internal short TypeField;
        private static readonly Bitfield16 TypeBitfield = Bitfield16.SelectBits(0, 2);
        private static readonly Bitfield16 NameTypeBitfield = Bitfield16.SelectBits(2, 3);
        private static readonly Bitfield16 ReservedBitfield = Bitfield16.SelectBits(5, 11);
        public IMPORT_OBJECT_TYPE Type
        {
            get => (IMPORT_OBJECT_TYPE)TypeBitfield.Read(TypeField);
            set => TypeBitfield.Write(ref TypeField, (short)value);
        }
        public IMPORT_OBJECT_NAME_TYPE NameType
        {
            get => (IMPORT_OBJECT_NAME_TYPE)NameTypeBitfield.Read(TypeField);
            set => NameTypeBitfield.Write(ref TypeField, (short)value);
        }
        /// <summary>Reserved. Must be zero.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public short Reserved
        {
            get => ReservedBitfield.Read(TypeField);
            set => ReservedBitfield.Write(ref TypeField, value);
        }
    }
}
