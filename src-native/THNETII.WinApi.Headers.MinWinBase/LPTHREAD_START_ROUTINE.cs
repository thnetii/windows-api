using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinBase
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int LPTHREAD_START_ROUTINE(IntPtr lpThreadParameter);
}
