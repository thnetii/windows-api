using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
    /// <summary>
    /// Represents the image section header format.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680341.aspx">IMAGE_SECTION_HEADER structure</a></para>
    /// </remarks>
    /// <seealso cref="ImageDirectoryEntryToDataEx"/>
    /// <seealso cref="ImageRvaToSection"/>
    /// <seealso cref="ImageRvaToVa"/>
    /// <seealso cref="LOADED_IMAGE"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_SECTION_HEADER
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const int IMAGE_SIZEOF_SHORT_NAME = 8;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [StructLayout(LayoutKind.Explicit)]
        private struct Union1
        {
            [FieldOffset(0)]
            public int PhysicalAddress;
            [FieldOffset(0)]
            public int VirtualSize;
        }

        /// <summary>
        /// An 8-byte array containing a null-padded UTF-8 string. There is no terminating null character if the string is exactly eight characters long. For longer names, this member contains a forward slash (/) followed by an ASCII representation of a decimal number that is an offset into the string table. Executable images do not use a string table and do not support section names longer than eight characters.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = IMAGE_SIZEOF_SHORT_NAME)]
        public byte[] NameBytes;
        /// <summary>
        /// A UTF-8 string that occupies at most 8 bytes of memory. There is no terminating null character if the string is exactly eight characters long. For longer names, this member contains a forward slash (/) followed by an ASCII representation of a decimal number that is an offset into the string table. Executable images do not use a string table and do not support section names longer than eight characters.
        /// </summary>
        public string Name
        {
            get { return Encoding.UTF8.GetString(NameBytes, 0, NameBytes.Length)?.TrimEnd('\0'); }
            set
            {
                var nameBytesField = NameBytes.Length == IMAGE_SIZEOF_SHORT_NAME ? NameBytes : new byte[IMAGE_SIZEOF_SHORT_NAME];
                if (value == null)
                {
                    NameBytes = nameBytesField;
                    return;
                }
                var nameBytesFull = Encoding.UTF8.GetBytes(value);
                for (int i = 0; i < IMAGE_SIZEOF_SHORT_NAME; i++)
                    nameBytesField[i] = i < (nameBytesFull?.Length ?? 0) ? nameBytesFull[i] : (byte)0;
                NameBytes = nameBytesField;
            }
        }
        private Union1 Misc;
        /// <summary>
        /// The file address.
        /// </summary>
        public int PhysicalAddress
        {
            get { return Misc.PhysicalAddress; }
            set { Misc.PhysicalAddress = value; }
        }
        /// <summary>
        /// The total size of the section when loaded into memory, in bytes. If this value is greater than the SizeOfRawData member, the section is filled with zeroes. This field is valid only for executable images and should be set to 0 for object files.
        /// </summary>
        public int VirtualSize
        {
            get { return Misc.VirtualSize; }
            set { Misc.VirtualSize = value; }
        }
        /// <summary>
        /// The address of the first byte of the section when loaded into memory, relative to the image base. For object files, this is the address of the first byte before relocation is applied.
        /// </summary>
        public int VirtualAddress;
        /// <summary>
        /// The size of the initialized data on disk, in bytes. This value must be a multiple of the <see cref="IMAGE_OPTIONAL_HEADER.FileAlignment"/> member of the <see cref="IMAGE_OPTIONAL_HEADER"/> structure. If this value is less than the <see cref="VirtualSize"/> member, the remainder of the section is filled with zeroes. If the section contains only uninitialized data, the member is zero.
        /// </summary>
        public int SizeOfRawData;
        /// <summary>
        /// A file pointer to the first page within the COFF file. This value must be a multiple of the <see cref="IMAGE_OPTIONAL_HEADER.FileAlignment"/> member of the <see cref="IMAGE_OPTIONAL_HEADER"/> structure. If a section contains only uninitialized data, set this member is zero.
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
        [MarshalAs(UnmanagedType.I4)]
        public IMAGE_SCN_CHARACTERISTICS Characteristics;
    }
}
