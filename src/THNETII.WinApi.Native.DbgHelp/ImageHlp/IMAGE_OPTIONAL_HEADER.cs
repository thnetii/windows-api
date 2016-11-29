using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp.IMAGE_DATA_DIRECTORY;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp
{
    /*
    #define IMAGE_NT_OPTIONAL_HDR32_MAGIC      0x10b
    #define IMAGE_NT_OPTIONAL_HDR64_MAGIC      0x20b
    #define IMAGE_ROM_OPTIONAL_HDR_MAGIC       0x107
    */

    public struct IMAGE_OPTIONAL_HEADER_COMMON
    {
        /// <summary>The state of the image file.</summary>
        public short Magic;
        /// <summary>The major version number of the linker.</summary>
        public byte MajorLinkerVersion;
        /// <summary>The minor version number of the linker.</summary>
        public byte MinorLinkerVersion;
        /// <summary>The size of the code section, in bytes, or the sum of all such sections if there are multiple code sections.</summary>
        public int SizeOfCode;
        /// <summary>The size of the initialized data section, in bytes, or the sum of all such sections if there are multiple initialized data sections.</summary>
        public int SizeOfInitializedData;
        /// <summary>The size of the uninitialized data section, in bytes, or the sum of all such sections if there are multiple uninitialized data sections.</summary>
        public int SizeOfUninitializedData;
        /// <summary>A pointer to the entry point function, relative to the image base address. For executable files, this is the starting address. For device drivers, this is the address of the initialization function. The entry point function is optional for DLLs. When no entry point is present, this member is zero.</summary>
        public int AddressOfEntryPoint;
        /// <summary>A pointer to the beginning of the code section, relative to the image base.</summary>
        public int BaseOfCode;
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class IMAGE_ROM_OPTIONAL_HEADER
    {
        public const short IMAGE_ROM_OPTIONAL_HDR_MAGIC = 0x107;

        private IMAGE_OPTIONAL_HEADER_COMMON commonHeader;
        /// <summary>The state of the image file.</summary>
        public short Magic
        {
            get { return commonHeader.Magic; }
            set { commonHeader.Magic = value; }
        }
        /// <summary>The major version number of the linker.</summary>
        public byte MajorLinkerVersion
        {
            get { return commonHeader.MajorLinkerVersion; }
            set { commonHeader.MajorLinkerVersion = value; }
        }
        /// <summary>The minor version number of the linker.</summary>
        public byte MinorLinkerVersion
        {
            get { return commonHeader.MinorLinkerVersion; }
            set { commonHeader.MinorLinkerVersion = value; }
        }
        /// <summary>The size of the code section, in bytes, or the sum of all such sections if there are multiple code sections.</summary>
        public int SizeOfCode
        {
            get { return commonHeader.SizeOfCode; }
            set { commonHeader.SizeOfCode = value; }
        }
        /// <summary>The size of the initialized data section, in bytes, or the sum of all such sections if there are multiple initialized data sections.</summary>
        public int SizeOfInitializedData
        {
            get { return commonHeader.SizeOfInitializedData; }
            set { commonHeader.SizeOfInitializedData = value; }
        }
        /// <summary>The size of the uninitialized data section, in bytes, or the sum of all such sections if there are multiple uninitialized data sections.</summary>
        public int SizeOfUninitializedData
        {
            get { return commonHeader.SizeOfUninitializedData; }
            set { commonHeader.SizeOfUninitializedData = value; }
        }
        /// <summary>A pointer to the entry point function, relative to the image base address. For executable files, this is the starting address. For device drivers, this is the address of the initialization function. The entry point function is optional for DLLs. When no entry point is present, this member is zero.</summary>
        public int AddressOfEntryPoint
        {
            get { return commonHeader.AddressOfEntryPoint; }
            set { commonHeader.AddressOfEntryPoint = value; }
        }
        /// <summary>A pointer to the beginning of the code section, relative to the image base.</summary>
        public int BaseOfCode
        {
            get { return commonHeader.BaseOfCode; }
            set { commonHeader.BaseOfCode = value; }
        }
        public int BaseOfData;
        public int BaseOfBss;
        public int GprMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] CprMask;
        public int GpValue;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// Represents the optional header format.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680339.aspx">IMAGE_OPTIONAL_HEADER structure</a></para>
    /// </remarks>
    /// <seealso cref="IMAGE_DATA_DIRECTORY"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_OPTIONAL_HEADER32
    {
        /// <summary>
        /// The file is an executable image.
        /// </summary>
        public const short IMAGE_NT_OPTIONAL_HDR32_MAGIC = 0x10b;

        private IMAGE_OPTIONAL_HEADER_COMMON commonHeader;
        /// <summary>The state of the image file.</summary>
        public short Magic
        {
            get { return commonHeader.Magic; }
            set { commonHeader.Magic = value; }
        }
        /// <summary>The major version number of the linker.</summary>
        public byte MajorLinkerVersion
        {
            get { return commonHeader.MajorLinkerVersion; }
            set { commonHeader.MajorLinkerVersion = value; }
        }
        /// <summary>The minor version number of the linker.</summary>
        public byte MinorLinkerVersion
        {
            get { return commonHeader.MinorLinkerVersion; }
            set { commonHeader.MinorLinkerVersion = value; }
        }
        /// <summary>The size of the code section, in bytes, or the sum of all such sections if there are multiple code sections.</summary>
        public int SizeOfCode
        {
            get { return commonHeader.SizeOfCode; }
            set { commonHeader.SizeOfCode = value; }
        }
        /// <summary>The size of the initialized data section, in bytes, or the sum of all such sections if there are multiple initialized data sections.</summary>
        public int SizeOfInitializedData
        {
            get { return commonHeader.SizeOfInitializedData; }
            set { commonHeader.SizeOfInitializedData = value; }
        }
        /// <summary>The size of the uninitialized data section, in bytes, or the sum of all such sections if there are multiple uninitialized data sections.</summary>
        public int SizeOfUninitializedData
        {
            get { return commonHeader.SizeOfUninitializedData; }
            set { commonHeader.SizeOfUninitializedData = value; }
        }
        /// <summary>A pointer to the entry point function, relative to the image base address. For executable files, this is the starting address. For device drivers, this is the address of the initialization function. The entry point function is optional for DLLs. When no entry point is present, this member is zero.</summary>
        public int AddressOfEntryPoint
        {
            get { return commonHeader.AddressOfEntryPoint; }
            set { commonHeader.AddressOfEntryPoint = value; }
        }
        /// <summary>A pointer to the beginning of the code section, relative to the image base.</summary>
        public int BaseOfCode
        {
            get { return commonHeader.BaseOfCode; }
            set { commonHeader.BaseOfCode = value; }
        }
        /// <summary>A pointer to the beginning of the data section, relative to the image base.</summary>
        public int BaseOfData;
        /// <summary>
        /// The preferred address of the first byte of the image when it is loaded in memory. This value is a multiple of 64K bytes. The default value for DLLs is 0x10000000. The default value for applications is 0x00400000, except on Windows CE where it is 0x00010000.
        /// </summary>
        public int ImageBase;
        /// <summary>
        /// The alignment of sections loaded in memory, in bytes. This value must be greater than or equal to the <see cref="FileAlignment"/> member. The default value is the page size for the system.
        /// </summary>
        public int SectionAlignment;
        /// <summary>
        /// The alignment of the raw data of sections in the image file, in bytes. The value should be a power of 2 between 512 and 64K (inclusive). The default is 512. If the <see cref="SectionAlignment"/> member is less than the system page size, this member must be the same as <see cref="SectionAlignment"/>.
        /// </summary>
        public int FileAlignment;
        /// <summary>The major version number of the required operating system.</summary>
        public short MajorOperatingSystemVersion;
        /// <summary>The minor version number of the required operating system.</summary>
        public short MinorOperatingSystemVersion;
        /// <summary>The major version number of the image.</summary>
        public short MajorImageVersion;
        /// <summary>The minor version number of the image.</summary>
        public short MinorImageVersion;
        /// <summary>The major version number of the subsystem.</summary>
        public short MajorSubsystemVersion;
        /// <summary>The minor version number of the subsystem.</summary>
        public short MinorSubsystemVersion;
        /// <summary>This member is reserved and must be 0.</summary>
        public int Win32VersionValue;
        /// <summary>The size of the image, in bytes, including all headers. Must be a multiple of <see cref="SectionAlignment"/>.</summary>
        public int SizeOfImage;
        /// <summary>
        /// The combined size of the following items, rounded to a multiple of the value specified in the <see cref="FileAlignment"/> member.
        /// <list type="bullet">
        /// <item><see cref="IMAGE_DOS_HEADER.e_lfanew"/> member of <see cref="IMAGE_DOS_HEADER"/>, </item>
        /// <item>4 byte signature, </item>
        /// <item>size of <see cref="IMAGE_FILE_HEADER"/>, </item>
        /// <item>size of optional header, </item>
        /// <item>size of all section headers.</item>
        /// </list>
        /// </summary>
        public int SizeOfHeaders;
        /// <summary>
        /// The image file checksum. The following files are validated at load time: all drivers, any DLL loaded at boot time, and any DLL loaded into a critical system process.
        /// </summary>
        public int CheckSum;
        /// <summary>The subsystem required to run this image.</summary>
        [MarshalAs(UnmanagedType.I2)]
        public IMAGE_SUBSYSTEM Subsystem;
        /// <summary>The DLL characteristics of the image.</summary>
        [MarshalAs(UnmanagedType.I2)]
        public IMAGE_DLLCHARACTERISTICS DllCharacteristics;
        /// <summary>
        /// The number of bytes to reserve for the stack. Only the memory specified by the <see cref="SizeOfStackCommit"/> member is committed at load time; the rest is made available one page at a time until this reserve size is reached.
        /// </summary>
        public int SizeOfStackReserve;
        /// <summary>
        /// The number of bytes to commit for the stack.
        /// </summary>
        public int SizeOfStackCommit;
        /// <summary>
        /// The number of bytes to reserve for the local heap. Only the memory specified by the <see cref="SizeOfHeapCommit"/> member is committed at load time; the rest is made available one page at a time until this reserve size is reached.
        /// </summary>
        public int SizeOfHeapReserve;
        /// <summary>
        /// The number of bytes to commit for the local heap.
        /// </summary>
        public int SizeOfHeapCommit;
        /// <summary>
        /// This member is obsolete.
        /// </summary>
        [Obsolete]
        public int LoaderFlags;
        /// <summary>
        /// The number of directory entries in the remainder of the optional header. Each entry describes a location and size.
        /// </summary>
        public int NumberOfRvaAndSizes;
        /// <summary>
        /// The data directory instances included in the header.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = IMAGE_NUMBEROF_DIRECTORY_ENTRIES)]
        public IMAGE_DATA_DIRECTORY[] DataDirectory;
    }

    /// <summary>
    /// Represents the optional header format.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680339.aspx">IMAGE_OPTIONAL_HEADER structure</a></para>
    /// </remarks>
    /// <seealso cref="IMAGE_DATA_DIRECTORY"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_OPTIONAL_HEADER64
    {
        public const short IMAGE_NT_OPTIONAL_HDR64_MAGIC = 0x20b;

        private IMAGE_OPTIONAL_HEADER_COMMON commonHeader;
        /// <summary>The state of the image file.</summary>
        public short Magic
        {
            get { return commonHeader.Magic; }
            set { commonHeader.Magic = value; }
        }
        /// <summary>The major version number of the linker.</summary>
        public byte MajorLinkerVersion
        {
            get { return commonHeader.MajorLinkerVersion; }
            set { commonHeader.MajorLinkerVersion = value; }
        }
        /// <summary>The minor version number of the linker.</summary>
        public byte MinorLinkerVersion
        {
            get { return commonHeader.MinorLinkerVersion; }
            set { commonHeader.MinorLinkerVersion = value; }
        }
        /// <summary>The size of the code section, in bytes, or the sum of all such sections if there are multiple code sections.</summary>
        public int SizeOfCode
        {
            get { return commonHeader.SizeOfCode; }
            set { commonHeader.SizeOfCode = value; }
        }
        /// <summary>The size of the initialized data section, in bytes, or the sum of all such sections if there are multiple initialized data sections.</summary>
        public int SizeOfInitializedData
        {
            get { return commonHeader.SizeOfInitializedData; }
            set { commonHeader.SizeOfInitializedData = value; }
        }
        /// <summary>The size of the uninitialized data section, in bytes, or the sum of all such sections if there are multiple uninitialized data sections.</summary>
        public int SizeOfUninitializedData
        {
            get { return commonHeader.SizeOfUninitializedData; }
            set { commonHeader.SizeOfUninitializedData = value; }
        }
        /// <summary>A pointer to the entry point function, relative to the image base address. For executable files, this is the starting address. For device drivers, this is the address of the initialization function. The entry point function is optional for DLLs. When no entry point is present, this member is zero.</summary>
        public int AddressOfEntryPoint
        {
            get { return commonHeader.AddressOfEntryPoint; }
            set { commonHeader.AddressOfEntryPoint = value; }
        }
        /// <summary>A pointer to the beginning of the code section, relative to the image base.</summary>
        public int BaseOfCode
        {
            get { return commonHeader.BaseOfCode; }
            set { commonHeader.BaseOfCode = value; }
        }
        /// <summary>A pointer to the beginning of the data section, relative to the image base.</summary>
        public int BaseOfData;
        /// <summary>
        /// The preferred address of the first byte of the image when it is loaded in memory. This value is a multiple of 64K bytes. The default value for DLLs is 0x10000000. The default value for applications is 0x00400000, except on Windows CE where it is 0x00010000.
        /// </summary>
        public ulong ImageBase;
        /// <summary>
        /// The alignment of sections loaded in memory, in bytes. This value must be greater than or equal to the <see cref="FileAlignment"/> member. The default value is the page size for the system.
        /// </summary>
        public int SectionAlignment;
        /// <summary>
        /// The alignment of the raw data of sections in the image file, in bytes. The value should be a power of 2 between 512 and 64K (inclusive). The default is 512. If the <see cref="SectionAlignment"/> member is less than the system page size, this member must be the same as <see cref="SectionAlignment"/>.
        /// </summary>
        public int FileAlignment;
        /// <summary>The major version number of the required operating system.</summary>
        public short MajorOperatingSystemVersion;
        /// <summary>The minor version number of the required operating system.</summary>
        public short MinorOperatingSystemVersion;
        /// <summary>The major version number of the image.</summary>
        public short MajorImageVersion;
        /// <summary>The minor version number of the image.</summary>
        public short MinorImageVersion;
        /// <summary>The major version number of the subsystem.</summary>
        public short MajorSubsystemVersion;
        /// <summary>The minor version number of the subsystem.</summary>
        public short MinorSubsystemVersion;
        /// <summary>This member is reserved and must be 0.</summary>
        public int Win32VersionValue;
        /// <summary>The size of the image, in bytes, including all headers. Must be a multiple of <see cref="SectionAlignment"/>.</summary>
        public int SizeOfImage;
        /// <summary>
        /// The combined size of the following items, rounded to a multiple of the value specified in the <see cref="FileAlignment"/> member.
        /// <list type="bullet">
        /// <item><see cref="IMAGE_DOS_HEADER.e_lfanew"/> member of <see cref="IMAGE_DOS_HEADER"/>, </item>
        /// <item>4 byte signature, </item>
        /// <item>size of <see cref="IMAGE_FILE_HEADER"/>, </item>
        /// <item>size of optional header, </item>
        /// <item>size of all section headers.</item>
        /// </list>
        /// </summary>
        public int SizeOfHeaders;
        /// <summary>
        /// The image file checksum. The following files are validated at load time: all drivers, any DLL loaded at boot time, and any DLL loaded into a critical system process.
        /// </summary>
        public int CheckSum;
        /// <summary>The subsystem required to run this image.</summary>
        [MarshalAs(UnmanagedType.I2)]
        public IMAGE_SUBSYSTEM Subsystem;
        /// <summary>The DLL characteristics of the image.</summary>
        [MarshalAs(UnmanagedType.I2)]
        public IMAGE_DLLCHARACTERISTICS DllCharacteristics;
        /// <summary>
        /// The number of bytes to reserve for the stack. Only the memory specified by the <see cref="SizeOfStackCommit"/> member is committed at load time; the rest is made available one page at a time until this reserve size is reached.
        /// </summary>
        public ulong SizeOfStackReserve;
        /// <summary>
        /// The number of bytes to commit for the stack.
        /// </summary>
        public ulong SizeOfStackCommit;
        /// <summary>
        /// The number of bytes to reserve for the local heap. Only the memory specified by the <see cref="SizeOfHeapCommit"/> member is committed at load time; the rest is made available one page at a time until this reserve size is reached.
        /// </summary>
        public ulong SizeOfHeapReserve;
        /// <summary>
        /// The number of bytes to commit for the local heap.
        /// </summary>
        public ulong SizeOfHeapCommit;
        /// <summary>
        /// This member is obsolete.
        /// </summary>
        [Obsolete]
        public int LoaderFlags;
        /// <summary>
        /// The number of directory entries in the remainder of the optional header. Each entry describes a location and size.
        /// </summary>
        public int NumberOfRvaAndSizes;
        /// <summary>
        /// The data directory instances included in the header.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = IMAGE_NUMBEROF_DIRECTORY_ENTRIES)]
        public IMAGE_DATA_DIRECTORY[] DataDirectory;
    }
}
