using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
    /// <summary>
    /// Represents the COFF symbols header.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms680301.aspx">IMAGE_COFF_SYMBOLS_HEADER structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_COFF_SYMBOLS_HEADER
    {
        /// <summary>The number of symbols.</summary>
        public int NumberOfSymbols;
        /// <summary>The virtual address of the first symbol.</summary>
        public int LvaToFirstSymbol;
        /// <summary>The number of line-number entries.</summary>
        public int NumberOfLinenumbers;
        /// <summary>The virtual address of the first line-number entry.</summary>
        public int LvaToFirstLinenumber;
        /// <summary>The relative virtual address of the first byte of code.</summary>
        public int RvaToFirstByteOfCode;
        /// <summary>The relative virtual address of the last byte of code.</summary>
        public int RvaToLastByteOfCode;
        /// <summary>The relative virtual address of the first byte of data.</summary>
        public int RvaToFirstByteOfData;
        /// <summary>The relative virtual address of the last byte of data.</summary>
        public int RvaToLastByteOfData;
    }
}
