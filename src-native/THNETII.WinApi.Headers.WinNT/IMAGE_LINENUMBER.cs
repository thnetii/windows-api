using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct IMAGE_LINENUMBER
    {
        public IMAGE_LINENUMBER_TYPE Type;
        /// <summary>Line number.</summary>
        public short Linenumber;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public struct IMAGE_LINENUMBER_TYPE
    {
        /// <summary>Symbol table index of function name if Linenumber is 0.</summary>
        [FieldOffset(0)]
        public int SymbolTableIndex;
        /// <summary>Virtual address of line number.</summary>
        [FieldOffset(0)]
        public int VirtualAddress;
    }
}
