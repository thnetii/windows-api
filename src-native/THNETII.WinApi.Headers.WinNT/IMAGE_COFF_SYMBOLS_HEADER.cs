using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18283
    /// <summary>
    /// Represents the COFF symbols header.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_coff_symbols_header">IMAGE_COFF_SYMBOLS_HEADER structure</a></para>
    /// </remarks>
    /// <seealso href="https://msdn.microsoft.com/b88c7a21-933f-450c-97e8-04cf3c5f9b11">ImageHlp Structures</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_COFF_SYMBOLS_HEADER
    {
        /// <summary>
        /// The number of symbols.
        /// </summary>
        public int NumberOfSymbols;
        /// <summary>
        /// The virtual address of the first symbol.
        /// </summary>
        public int LvaToFirstSymbol;
        /// <summary>
        /// The number of line-number entries.
        /// </summary>
        public int NumberOfLinenumbers;
        /// <summary>
        /// The virtual address of the first line-number entry.
        /// </summary>
        public int LvaToFirstLinenumber;
        /// <summary>
        /// The relative virtual address of the first byte of code.
        /// </summary>
        public int RvaToFirstByteOfCode;
        /// <summary>
        /// The relative virtual address of the last byte of code.
        /// </summary>
        public int RvaToLastByteOfCode;
        /// <summary>
        /// The relative virtual address of the first byte of data.
        /// </summary>
        public int RvaToFirstByteOfData;
        /// <summary>
        /// The relative virtual address of the last byte of data.
        /// </summary>
        public int RvaToLastByteOfData;
    }
}
