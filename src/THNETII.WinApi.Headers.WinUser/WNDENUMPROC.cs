using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Headers.WinUser
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool WNDENUMPROC(
        IntPtr hwnd, IntPtr lParam
        );
}
