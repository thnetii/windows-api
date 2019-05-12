using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17804
    /// <summary>
    /// Code Integrity in loadconfig (CI)
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_LOAD_CONFIG_CODE_INTEGRITY
    {
        /// <summary>Flags to indicate if CI information is available, etc.</summary>
        public short Flags;
        /// <summary><c>0xFFFF</c> means not available</summary>
        public short Catalog;
        public int CatalogOffset;
        /// <summary>Additional bitmask to be defined later</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved;
    }
}
