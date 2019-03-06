using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinUser
{
    /// <summary>
    /// The <see cref="GRAYSTRINGPROC"/> delegate is an application-defined callback function used with the <see cref="GrayString"/> function. It is used to draw a string.
    /// </summary>
    /// <returns>
    /// <para>If it succeeds, the callback function should return <see langword="true"/>.</para>
    /// <para>If the function fails, the return value is <see langword="false"/>.</para>
    /// </returns>
    /// <remarks>
    /// The callback function must draw an image relative to the coordinates (0,0).
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/WinUser/nc-winuser-graystringproc">GRAYSTRINGPROC callback function</a></para>
    /// </remarks>
    /// <seealso cref="GrayString"/>
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool GRAYSTRINGPROC(
        IntPtr Arg1,
        IntPtr Arg2,
        int Arg3
        );
}
