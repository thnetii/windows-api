using System;
using System.Runtime.InteropServices;
using System.Text;

using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16676
    /// <summary>
    /// Represents the image section header format.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_section_header">IMAGE_SECTION_HEADER structure</a></para>
    /// </remarks>
    /// <seealso cref="ImageDirectoryEntryToDataEx"/>
    /// <seealso href="https://msdn.microsoft.com/b88c7a21-933f-450c-97e8-04cf3c5f9b11">ImageHlp Structures</seealso>
    /// <seealso cref="ImageRvaToSection"/>
    /// <seealso cref="ImageRvaToVa"/>
    /// <seealso cref="LOADED_IMAGE"/>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe struct IMAGE_SECTION_HEADER
    {
        #region public fixed char Name[IMAGE_SIZEOF_SHORT_NAME];
        internal fixed byte NameField[IMAGE_SIZEOF_SHORT_NAME];
        internal Span<byte> NameSpan
        {
            get
            {
                fixed (void* ptr = NameField)
                {
                    return new Span<byte>(ptr, IMAGE_SIZEOF_SHORT_NAME);
                }
            }
        }
        /// <summary>
        /// For longer names, this member contains a forward slash (/) followed by an ASCII representation of a decimal number that is an offset into the string table. Executable images do not use a string table and do not support section names longer than eight characters.
        /// </summary>
        public string Name
        {
            get
            {
                fixed (byte* ptr = NameField)
                    return FixedStringBuffer.ToStringZeroTerminated(ptr, IMAGE_SIZEOF_SHORT_NAME, Encoding.UTF8);
            }
            set
            {
                fixed (byte* ptr = NameField)
                    FixedStringBuffer.ToBytesZeroTerminated(value, ptr, IMAGE_SIZEOF_SHORT_NAME, Encoding.UTF8);
            }
        }
        #endregion
        internal int Misc;
        /// <summary>
        /// The file address.
        /// </summary>
        public int PhysicalAddress
        {
            get => Misc;
            set => Misc = value;
        }
        /// <summary>
        /// The total size of the section when loaded into memory, in bytes. If this value is greater than the <see cref="SizeOfRawData"/> member, the section is filled with zeroes. This field is valid only for executable images and should be set to 0 for object files.
        /// </summary>
        public int VirtualSize
        {
            get => Misc;
            set => Misc = value;
        }
        /// <summary>
        /// The address of the first byte of the section when loaded into memory, relative to the image base. For object files, this is the address of the first byte before relocation is applied.
        /// </summary>
        public int VirtualAddress;
        /// <summary>
        /// The size of the initialized data on disk, in bytes. This value must be a multiple of the <see cref="IMAGE_OPTIONAL_HEADER32.FileAlignment"/> member of the <see cref="IMAGE_OPTIONAL_HEADER32"/> or <see cref="IMAGE_OPTIONAL_HEADER64"/> structures. If this value is less than the <see cref="VirtualSize"/> member, the remainder of the section is filled with zeroes. If the section contains only uninitialized data, the member is zero.
        /// </summary>
        public int SizeOfRawData;
        /// <summary>
        /// A file pointer to the first page within the COFF file. This value must be a multiple of the <see cref="IMAGE_OPTIONAL_HEADER32.FileAlignment"/> member of the <see cref="IMAGE_OPTIONAL_HEADER32"/> or <see cref="IMAGE_OPTIONAL_HEADER64"/> structures. If a section contains only uninitialized data, set this member is zero.
        /// </summary>
        public int PointerToRawData;
        /// <summary>
        /// A file pointer to the beginning of the relocation entries for the section. If there are no relocations, this value is zero.
        /// </summary>
        public int PointerToRelocations;
        /// <summary>
        /// A file pointer to the beginning of the line-number entries for the section. If there are no COFF line numbers, this value is zero.
        /// </summary>
        public int PointerToLinenumbers;
        /// <summary>
        /// The number of relocation entries for the section. This value is zero for executable images.
        /// </summary>
        public short NumberOfRelocations;
        /// <summary>
        /// The number of line-number entries for the section.
        /// </summary>
        public short NumberOfLinenumbers;
        /// <summary>
        /// The characteristics of the image.
        /// </summary>
        public IMAGE_SCN_CHARACTERISTICS Characteristics;
    }
}
