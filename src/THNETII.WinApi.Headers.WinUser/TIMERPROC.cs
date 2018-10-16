using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Headers.WinUser
{
    /// <summary>
    /// An application-defined callback function that processes <see cref="WM_TIMER"/> messages.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/WinUser/nc-winuser-timerproc">TIMERPROC callback function</a></para>
    /// </remarks>
    /// <seealso cref="KillTimer"/>
    /// <seealso cref="SetTimer"/>
    /// <seealso cref="WM_TIMER"/>
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void TIMERPROC(
        IntPtr Arg1,
        uint Arg2,
        IntPtr Arg3,
        int Arg4
        );
}
