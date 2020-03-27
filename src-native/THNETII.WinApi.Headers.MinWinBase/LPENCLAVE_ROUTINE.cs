using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinBase
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int LPENCLAVE_ROUTINE(IntPtr lpThreadParameter);
}
