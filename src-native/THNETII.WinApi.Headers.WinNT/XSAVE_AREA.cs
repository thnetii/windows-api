using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public struct XSAVE_AREA
    {
        public XSAVE_FORMAT LegacyState;
        public XSAVE_AREA_HEADER Header;
    }
}
