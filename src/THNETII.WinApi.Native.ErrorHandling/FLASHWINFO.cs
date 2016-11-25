using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Diagnostics.ErrorHandling.ErrorHandlingFunctions;

namespace Microsoft.Win32.WinApi.Diagnostics.ErrorHandling
{
    /// <summary>
    /// Contains the flash status for a window and the number of times the system should flash the window.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms679348.aspx">FLASHWINFO structure</a></para>
    /// </remarks>
    /// <seealso cref="FlashWindowEx"/>
    [StructLayout(LayoutKind.Sequential)]
    public class FLASHWINFO
    {
        /// <summary>
        /// The size in bytes that an instance of this type will occupy in native memory.
        /// </summary>
        public static readonly int SizeOf =
#if (NET20 || NET35 || NET40 || NET45 || NETSTANDARD1_1)
            Marshal.SizeOf(typeof(FLASHWINFO))
#else
            Marshal.SizeOf<FLASHWINFO>() 
#endif
            ;

        /// <summary>
        /// The size of the structure, in bytes.
        /// </summary>
        public int cbSize = SizeOf;

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
