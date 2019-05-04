using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static IMAGE_SCN_CHARACTERISTICS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17035
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_RELOCATION
    {
        internal int u;
        public int VirtualAddress
        {
            get => u;
            set => u = value;
        }
        /// <summary>
        /// Set to the real count when <see cref="IMAGE_SCN_LNK_NRELOC_OVFL"/> is set
        /// </summary>
        public int RelocCount
        {
            get => u;
            set => u = value;
        }
        public int SymbolTableIndex;
        public short Type;
    }
}
