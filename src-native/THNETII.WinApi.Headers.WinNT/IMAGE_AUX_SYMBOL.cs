using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16936
    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public struct IMAGE_AUX_SYMBOL
    {
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_SYM Sym;
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_FILE File;
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_SECTION Section;
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_CRC CRC;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct IMAGE_AUX_SYMBOL_SYM
    {
        /// <summary>struct, union, or enum tag index</summary>
        public int TagIndex;
        public IMAGE_AUX_SYMBOL_SYM_MISC Misc;
        public IMAGE_AUX_SYMBOL_SYM_FCNARY FcnAry;
        /// <summary>tv index</summary>
        public short TvIndex;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public struct IMAGE_AUX_SYMBOL_SYM_MISC
    {
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_SYM_MISC_LNSZ LnSz;
        [FieldOffset(0)]
        public int TotalSize;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct IMAGE_AUX_SYMBOL_SYM_MISC_LNSZ
    {
        /// <summary>declaration line number</summary>
        public short LineNumber;
        /// <summary>size of struct, union, or enum</summary>
        public short Size;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public struct IMAGE_AUX_SYMBOL_SYM_FCNARY
    {
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_SYM_FCNARY_FUNCTION Function;
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_SYM_FCNARY_ARRAY Array;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct IMAGE_AUX_SYMBOL_SYM_FCNARY_FUNCTION
    {
        public int PointerToLinenumber;
        public int PointerToNextFunction;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_AUX_SYMBOL_SYM_FCNARY_ARRAY
    {
        public fixed short Dimension[4];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_AUX_SYMBOL_FILE
    {
        public fixed byte Name[IMAGE_SIZEOF_SYMBOL];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct IMAGE_AUX_SYMBOL_SECTION
    {
        /// <summary>section length</summary>
        public int Length;
        /// <summary>number of relocation entries</summary>
        public short NumberOfRelocations;
        /// <summary>number of line numbers</summary>
        public short NumberOfLinenumbers;
        /// <summary>checksum for communal</summary>
        public int CheckSum;
        /// <summary>section number to associate with</summary>
        public short Number;
        /// <summary>communal selection type</summary>
        public byte Selection;
        public byte bReserved;
        /// <summary>high bits of the section number</summary>
        public short HighNumber;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_AUX_SYMBOL_CRC
    {
        public int crc;
        public fixed byte rgbReserved[14];
    }
}
