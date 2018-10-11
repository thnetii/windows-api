using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApiNative.ErrorHandling
{
    /// <summary>
    /// Contains the flash status for a window and the number of times the system should flash the window.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/ns-winuser-flashwinfo">FLASHWINFO structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    [SuppressMessage("Design", "CA1051: Do not declare visible instance fields")]
    [SuppressMessage("Performance", "CA1815: Override equals and operator equals on value types")]
    public struct FLASHWINFO
    {
        /// <summary>
        /// The size of the structure, in bytes. Initialize using the static <see cref="SizeOf{T}.Bytes"/> property on <see cref="SizeOf{T}"/>.
        /// </summary>
        public int cbSize;
        /// <summary>
        /// A handle to the window to be flashed. The window can be either opened or minimized.
        /// </summary>
        public IntPtr hwnd;
        /// <summary>
        /// The flash status.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public FLASHWFLAG dwFlags;
        /// <summary>
        /// The number of times to flash the window.
        /// </summary>
        public int uCount;
        /// <summary>
        /// The rate at which the window is to be flashed, in milliseconds. If <see cref="dwTimeout"/> is zero, the function uses the default cursor blink rate.
        /// </summary>
        public int dwTimeout;
    }
}
