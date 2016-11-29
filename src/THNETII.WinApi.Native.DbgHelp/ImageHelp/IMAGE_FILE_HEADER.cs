using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
    /// <summary>
    /// Represents the COFF header format.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680313.aspx">IMAGE_FILE_HEADER structure</a></para>
    /// </remarks>
    /// <seealso cref="IMAGE_NT_HEADERS32"/>
    /// <seealso cref="IMAGE_NT_HEADERS64"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_FILE_HEADER
    {
        /// <summary>
        /// The architecture type of the computer. An image file can only be run on the specified computer or a system that emulates the specified computer.
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public IMAGE_FILE_MACHINE Machine;
        /// <summary>
        /// The number of sections. This indicates the size of the section table, which immediately follows the headers. Note that the Windows loader limits the number of sections to 96.
        /// </summary>
        public short NumberOfSections;
        /// <summary>
        /// The low 32 bits of the time stamp of the image. This represents the date and time the image was created by the linker. The value is represented in the number of seconds elapsed since midnight (00:00:00), January 1, 1970, Universal Coordinated Time, according to the system clock.
        /// </summary>
        public int TimeDateStamp;
        /// <summary>
        /// The offset of the symbol table, in bytes, or zero if no COFF symbol table exists.
        /// </summary>
        public int PointerToSymbolTable;
        /// <summary>
        /// The number of symbols in the symbol table.
        /// </summary>
        public int NumberOfSymbols;
        /// <summary>
        /// The size of the optional header, in bytes. This value should be 0 for object files.
        /// </summary>
        public short SizeOfOptionalHeader;
        /// <summary>
        /// The characteristics of the image.
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public IMAGE_FILE_CHARACTERISTICS Characteristics;
    }
}
