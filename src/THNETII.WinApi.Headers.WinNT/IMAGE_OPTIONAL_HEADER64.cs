using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16489
    /// <summary>
    /// Represents the optional header format.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_optional_header64">IMAGE_OPTIONAL_HEADER64 structure</a></para>
    /// </remarks>
    /// <seealso cref="IMAGE_DATA_DIRECTORY"/>
    /// <seealso href="https://msdn.microsoft.com/b88c7a21-933f-450c-97e8-04cf3c5f9b11">ImageHlp Structures</seealso>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe struct IMAGE_OPTIONAL_HEADER64
    {
        /// <summary>
        /// The state of the image file.
        /// </summary>
        /// <value>
        /// This member can be one of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="IMAGE_NT_OPTIONAL_HDR_MAGIC"/></term><description>The file is an executable image. This value is defined as <see cref="IMAGE_NT_OPTIONAL_HDR32_MAGIC"/> in a 32-bit application and as <see cref="IMAGE_NT_OPTIONAL_HDR64_MAGIC"/> in a 64-bit application.</description></item>
        /// <item><term><see cref="IMAGE_NT_OPTIONAL_HDR32_MAGIC"/><br/><c>0x10b</c></term><description>The file is an executable image.</description></item>
        /// <item><term><see cref="IMAGE_NT_OPTIONAL_HDR64_MAGIC"/><br/><c>0x20b</c></term><description>The file is an executable image.</description></item>
        /// <item><term><see cref="IMAGE_ROM_OPTIONAL_HDR_MAGIC"/><br/><c>0x107</c></term><description>The file is a ROM image.</description></item>
        /// </list>
        /// </value>
        public short Magic;
        /// <summary>
        /// The major version number of the linker.
        /// </summary>
        public byte MajorLinkerVersion;
        /// <summary>
        /// The minor version number of the linker.
        /// </summary>
        public byte MinorLinkerVersion;
        /// <summary>
        /// The version of the linker.
        /// </summary>
        public Version LinkerVersion
        {
            get => new Version(MajorLinkerVersion, MinorLinkerVersion);
            set
            {
                MajorLinkerVersion = (byte)(value?.Major ?? 0);
                MinorLinkerVersion = (byte)(value?.Minor ?? 0);
            }
        }
        /// <summary>
        /// The size of the code section, in bytes, or the sum of all such sections if there are multiple code sections.
        /// </summary>
        public int SizeOfCode;
        /// <summary>
        /// The size of the initialized data section, in bytes, or the sum of all such sections if there are multiple initialized data sections.
        /// </summary>
        public int SizeOfInitializedData;
        /// <summary>
        /// The size of the uninitialized data section, in bytes, or the sum of all such sections if there are multiple uninitialized data sections.
        /// </summary>
        public int SizeOfUninitializedData;
        /// <summary>
        /// A pointer to the entry point function, relative to the image base address. For executable files, this is the starting address. For device drivers, this is the address of the initialization function. The entry point function is optional for DLLs. When no entry point is present, this member is zero.
        /// </summary>
        public int AddressOfEntryPoint;
        /// <summary>
        /// A pointer to the beginning of the code section, relative to the image base.
        /// </summary>
        public int BaseOfCode;
        /// <summary>
        /// A pointer to the beginning of the data section, relative to the image base.
        /// </summary>
        public int BaseOfData;
        /// <summary>
        /// The preferred address of the first byte of the image when it is loaded in memory. This value is a multiple of 64K bytes. The default value for DLLs is 0x10000000. The default value for applications is 0x00400000, except on Windows CE where it is 0x00010000.
        /// </summary>
        public long ImageBase;
        /// <summary>
        /// The alignment of sections loaded in memory, in bytes. This value must be greater than or equal to the <see cref="FileAlignment"/> member. The default value is the page size for the system.
        /// </summary>
        public int SectionAlignment;
        /// <summary>
        /// The alignment of the raw data of sections in the image file, in bytes. The value should be a power of 2 between 512 and 64K (inclusive). The default is 512. If the <see cref="SectionAlignment"/> member is less than the system page size, this member must be the same as <see cref="SectionAlignment"/>.
        /// </summary>
        public int FileAlignment;
        /// <summary>
        /// The major version number of the required operating system.
        /// </summary>
        public short MajorOperatingSystemVersion;
        /// <summary>
        /// The minor version number of the required operating system.
        /// </summary>
        public short MinorOperatingSystemVersion;
        /// <summary>
        /// The version of the required operating system.
        /// </summary>
        public Version OperatingSystemVersion
        {
            get => new Version(MajorOperatingSystemVersion, MinorOperatingSystemVersion);
            set
            {
                MajorOperatingSystemVersion = (short)(value?.Major ?? 0);
                MinorOperatingSystemVersion = (short)(value?.Minor ?? 0);
            }
        }
        /// <summary>
        /// The major version number of the image.
        /// </summary>
        public short MajorImageVersion;
        /// <summary>
        /// The minor version number of the image.
        /// </summary>
        public short MinorImageVersion;
        /// <summary>
        /// The version of the image.
        /// </summary>
        public Version ImageVersion
        {
            get => new Version(MajorImageVersion, MinorImageVersion);
            set
            {
                MajorImageVersion = (short)(value?.Major ?? 0);
                MinorImageVersion = (short)(value?.Minor ?? 0);
            }
        }
        /// <summary>
        /// The major version number of the subsystem.
        /// </summary>
        public short MajorSubsystemVersion;
        /// <summary>
        /// The minor version number of the subsystem.
        /// </summary>
        public short MinorSubsystemVersion;
        /// <summary>
        /// The Version of the subsystem.
        /// </summary>
        public Version SubsystemVersion
        {
            get => new Version(MajorSubsystemVersion, MinorSubsystemVersion);
            set
            {
                MajorSubsystemVersion = (short)(value?.Major ?? 0);
                MinorSubsystemVersion = (short)(value?.Minor ?? 0);
            }
        }
        /// <summary>
        /// This member is reserved and must be 0.
        /// </summary>
        public int Win32VersionValue;
        /// <summary>
        /// The size of the image, in bytes, including all headers. Must be a multiple of <see cref="SectionAlignment"/>.
        /// </summary>
        public int SizeOfImage;
        /// <summary>
        /// The combined size of the following items, rounded to a multiple of the value specified in the <see cref="FileAlignment"/> member.
        /// <list type="bullet">
        /// <item><see cref="IMAGE_DOS_HEADER.e_lfanew"/> member of <see cref="IMAGE_DOS_HEADER"/></item>
        /// <item>4 byte signature</item>
        /// <item>size of <see cref="IMAGE_FILE_HEADER"/></item>
        /// <item>size of optional header</item>
        /// <item>size of all section headers</item>
        /// </list>
        /// </summary>
        public int SizeOfHeaders;
        /// <summary>
        /// The image file checksum. The following files are validated at load time: all drivers, any DLL loaded at boot time, and any DLL loaded into a critical system process.
        /// </summary>
        public int CheckSum;
        /// <summary>
        /// The subsystem required to run this image.
        /// </summary>
        public IMAGE_SUBSYSTEM_TYPE Subsystem;
        /// <summary>
        /// The DLL characteristics of the image.
        /// </summary>
        public IMAGE_DLLCHARACTERISTICS_FLAGS DllCharacteristics;
        /// <summary>
        /// The number of bytes to reserve for the stack. Only the memory specified by the <see cref="SizeOfStackCommit"/> member is committed at load time; the rest is made available one page at a time until this reserve size is reached.
        /// </summary>
        public long SizeOfStackReserve;
        /// <summary>
        /// The number of bytes to commit for the stack.
        /// </summary>
        public long SizeOfStackCommit;
        /// <summary>
        /// The number of bytes to reserve for the local heap. Only the memory specified by the <see cref="SizeOfHeapCommit"/> member is committed at load time; the rest is made available one page at a time until this reserve size is reached.
        /// </summary>
        public long SizeOfHeapReserve;
        /// <summary>
        /// The number of bytes to commit for the local heap.
        /// </summary>
        public long SizeOfHeapCommit;
        /// <summary>
        /// This member is obsolete.
        /// </summary>
        [Obsolete("This member is obsolete.")]
        public int LoaderFlags;
        /// <summary>
        /// The number of directory entries in the remainder of the optional header. Each entry describes a location and size.
        /// </summary>
        public int NumberOfRvaAndSizes;
        #region public fixed IMAGE_DATA_DIRECTORY DataDirectory[IMAGE_NUMBEROF_DIRECTORY_ENTRIES];
        internal fixed byte DataDirectoryField[IMAGE_NUMBEROF_DIRECTORY_ENTRIES * IMAGE_DATA_DIRECTORY.SizeOf];
        /// <summary>
        /// A span of the <see cref="IMAGE_DATA_DIRECTORY"/> structures in the data directory.
        /// </summary>
        public Span<IMAGE_DATA_DIRECTORY> DataDirectory
        {
            get
            {
                fixed (void* ptr = DataDirectoryField)
                {
                    int count = (int)Math.Min(
                        (uint)NumberOfRvaAndSizes,
                        IMAGE_NUMBEROF_DIRECTORY_ENTRIES
                        );
                    return new Span<IMAGE_DATA_DIRECTORY>(ptr, count);
                }
            }
        }
        #endregion
    }
}
