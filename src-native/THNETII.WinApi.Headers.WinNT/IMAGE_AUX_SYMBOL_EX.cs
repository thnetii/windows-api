using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16978
    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public struct IMAGE_AUX_SYMBOL_EX
    {
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_EX_SYM Sym;
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_EX_FILE File;
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_EX_SECTION Section;
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_EX_CRC CRC;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_AUX_SYMBOL_EX_SYM
    {
        /// <summary>the weak extern default symbol index</summary>
        public int WeakDefaultSymIndex;
        public int WeakSearchType;
        public fixed byte rgbReserved[12];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_AUX_SYMBOL_EX_FILE
    {
        public fixed byte Name[IMAGE_SYMBOL_EX.SizeOf];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_AUX_SYMBOL_EX_SECTION
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
        public fixed byte rgbReserved[2];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_AUX_SYMBOL_EX_CRC
    {
        public int crc;
        public fixed byte rgbReserved[16];
    }
}
