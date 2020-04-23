using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17782
    /// <summary>
    /// Each resource data entry describes a leaf node in the resource directory
    /// tree.  It contains an offset, relative to the beginning of the resource
    /// directory of the data for the resource, a size field that gives the number
    /// of bytes of data at that offset, a CodePage that should be used when
    /// decoding code point values within the resource data.  Typically for new
    /// applications the code page would be the unicode code page.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_RESOURCE_DATA_ENTRY
    {
        public int OffsetToData;
        public int Size;
        public int CodePage;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved;
    }
}
