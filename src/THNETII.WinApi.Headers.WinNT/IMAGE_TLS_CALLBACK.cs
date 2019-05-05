using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17577
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void IMAGE_TLS_CALLBACK(IntPtr DllHandle, int Reason,
        IntPtr Reserved);
}
