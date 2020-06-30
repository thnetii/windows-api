using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinSmcrd
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 312
    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_T1_REQUEST
    {
        public SCARD_IO_REQUEST ioRequest;
    }
}
