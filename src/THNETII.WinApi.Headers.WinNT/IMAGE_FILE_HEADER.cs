using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16349
    /// <summary>
    /// Represents the COFF header format.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_file_header">IMAGE_FILE_HEADER structure</a></para>
    /// </remarks>
    /// <seealso cref="IMAGE_NT_HEADERS"/>
    /// <seealso href="https://msdn.microsoft.com/b88c7a21-933f-450c-97e8-04cf3c5f9b11">ImageHlp Structures</seealso>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_FILE_HEADER
    {
        private static readonly DateTime Epoch = new DateTime(1970, 01, 01, 00, 00, 00, DateTimeKind.Utc);

        /// <summary>
        /// The architecture type of the computer. An image file can only be run on the specified computer or a system that emulates the specified computer.
        /// </summary>
        public IMAGE_FILE_MACHINE_TYPE Machine;
        /// <summary>
        /// The number of sections. This indicates the size of the section table, which immediately follows the headers. Note that the Windows loader limits the number of sections to 96.
        /// </summary>
        public short NumberOfSections;
        #region public int TimeDateStamp;
        internal int TimeDateStampField;
        /// <summary>
        /// This represents the date and time the image was created by the linker.
        /// </summary>
        public DateTime TimeDateStamp
        {
            get => Epoch.AddSeconds(TimeDateStampField);
            set => TimeDateStampField = (int)(value - Epoch).TotalSeconds;
        }
        #endregion
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
        public IMAGE_FILE_CHARACTERISTICS Characteristics;
    }
}
