using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16921
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe struct IMAGE_AUX_SYMBOL_TOKEN_DEF
    {
        /// <summary>IMAGE_AUX_SYMBOL_TYPE</summary>
        public byte bAuxType;
        /// <summary>Must be 0</summary>
        public byte bReserved;
        public int SymbolTableIndex;
        /// <summary>Must be 0</summary>
        public fixed byte rgbReserved[12];
    }
}
