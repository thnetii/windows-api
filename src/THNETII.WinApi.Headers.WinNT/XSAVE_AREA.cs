using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public struct XSAVE_AREA
    {
        public XSAVE_FORMAT LegacyState;
        public XSAVE_AREA_HEADER Header;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PXSAVE_AREA : IIntPtr<XSAVE_AREA>
    {
        public PXSAVE_AREA(IntPtr ptr) : this() => Pointer = ptr;
        public IntPtr Pointer { get; }
    }
}
