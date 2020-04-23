using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1352
    [Obsolete("DEPRECATED, use GEO_ENUMNAMEPROC instead")]
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool GEO_ENUMPROC(int geoid);
}
