using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17670
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_BOUND_FORWARDER_REF
    {
        public int TimeDateStamp;
        public short OffsetModuleName;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public short Reserved;
    }
}
