using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory.Specialized;
#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApiNative.ErrorHandling
{
    /// <summary>
    /// Defines the native P/Invoke functions used with error handling.
    /// </summary>
    /// <remarks>
    /// <para>See Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/debug/error-handling-functions">Error Handling Functions</a></para>
    /// </remarks>
    public static class ErrorHandlingFunctions
    {
        #region Beep function
        /// <summary>
        /// Generates simple tones on the speaker. The function is synchronous; it performs an alertable wait and does not return control to its caller until the sound finishes.
        /// </summary>
        /// <param name="dwFreq">The frequency of the sound, in hertz. This parameter must be in the range 37 through 32,767 (<c>0x25</c> through <c>0x7FFF</c>). </param>
        /// <param name="dwDuration">The duration of the sound, in milliseconds.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <c>true</c>.</para>
        /// <para>If the function fails, the return value is <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// A long time ago, all PC computers shared a common 8254 programable interval timer chip for the generation of primitive sounds. The <see cref="Beep"/> function was written specifically to emit a beep on that piece of hardware.
        /// </para>
        /// <para>
        /// On these older systems, muting and volume controls have no effect on Beep; you would still hear the tone. To silence the tone, you used the following commands:
        /// <code>
        /// net stop beep
        /// sc config beep start= disabled
        /// </code>
        /// </para>
        /// <para>
        /// Since then, sound cards have become standard equipment on almost all PC computers. As sound cards became more common, manufacturers began to remove the old timer chip from computers. The chips were also excluded from the design of server computers. The result is that <see cref="Beep"/> did not work on all computers without the chip. This was okay because most developers had moved on to calling the <see cref="MessageBeep"/> function that uses whatever is the default sound device instead of the 8254 chip. 
        /// </para>
        /// <para>
        /// Eventually because of the lack of hardware to communicate with, support for <see cref="Beep"/> was dropped in Windows Vista and Windows XP 64-Bit Edition.
        /// </para>
        /// <para>
        /// In Windows 7, <see cref="Beep"/> was rewritten to pass the beep to the default sound device for the session. This is normally the sound card, except when run under Terminal Services, in which case the beep is rendered on the client.
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/ms679277.aspx">Beep function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="MessageBeep"/>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern bool Beep(
            [In] int dwFreq,
            [In] int dwDuration
            );
        #endregion
        #region CaptureStackBackTrace function
        /// <summary>
        /// Captures a stack back trace by walking up the stack and recording the information for each frame.
        /// </summary>
        /// <param name="FramesToSkip">The number of frames to skip from the start of the back trace.</param>
        /// <param name="FramesToCapture">
        /// The number of frames to be captured. You can capture up to the <see cref="ushort.MaxValue"/> of the <see cref="ushort"/> type frames.
        /// <para><strong>Windows Server 2003 and Windows XP:</strong> The sum of the <paramref name="FramesToSkip"/> and <paramref name="FramesToCapture"/> parameters must be less than <c>63</c>.</para>
        /// </param>
        /// <param name="BackTrace">Receives a pointer to an array of stack frame pointers from the current stack trace.</param>
        /// <param name="BackTraceHash">
        /// A value that can be used to organize hash tables. The value is optional and can be ignored or discarded.
        /// <para>This value is calculated based on the values of the pointers returned in the <paramref name="BackTrace"/> array. Two identical stack traces will generate identical hash values.</para>
        /// </param>
        /// <returns>The number of captured frames.</returns>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/Bb204633.aspx">CaptureStackBackTrace function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern ushort CaptureStackBackTrace(
            [In] int FramesToSkip,
            [In] int FramesToCapture,
            out ArrayOfIntPtr BackTrace,
            [Optional] out int BackTraceHash
            );
        #endregion
        #region FatalAppExit function
        /// <summary>
        /// Displays a message box and terminates the application when the message box is closed. If the system is running with a debug version of Kernel32.dll, the message box gives the user the opportunity to terminate the application or to cancel the message box and return to the application that called <see cref="FatalAppExit"/>.
        /// </summary>
        /// <param name="uAction">This parameter must be <c>0</c> (zero).</param>
        /// <param name="lpMessageText">The string that is displayed in the message box.</param>
        /// <remarks>
        /// An application calls <see cref="FatalAppExit"/> only when it is not capable of terminating any other way. 
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/ms679336.aspx">FatalAppExit function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="FatalExit"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(FatalAppExit) + "W")]
        public static extern void FatalAppExit(
            [In] int uAction,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpMessageText
            );
        #endregion
        #region FlashWindow function
        /// <summary>
        /// <para>Flashes the specified window one time. It does not change the active state of the window.</para>
        /// <para>To flash the window a specified number of times, use the <see cref="FlashWindowEx"/> function.</para>
        /// </summary>
        /// <param name="hWnd">A handle to the window to be flashed. The window can be either open or minimized.</param>
        /// <param name="bInvert">
        /// <para>If this parameter is <c>true</c>, the window is flashed from one state to the other. If it is <c>false</c>, the window is returned to its original state (either active or inactive).</para>
        /// <para>When an application is minimized and this parameter is <c>true</c>, the taskbar window button flashes active/inactive. If it is <c>false</c>, the taskbar window button flashes inactive, meaning that it does not change colors. It flashes, as if it were being redrawn, but it does not provide the visual invert clue to the user.</para>
        /// </param>
        /// <returns>
        /// The return value specifies the window's state before the call to the FlashWindow function. If the window caption was drawn as active before the call, the return value is <c>true</c>. Otherwise, the return value is <c>false</c>.
        /// </returns>
        /// <remarks>
        /// <para>Flashing a window means changing the appearance of its caption bar as if the window were changing from inactive to active status, or vice versa. (An inactive caption bar changes to an active caption bar; an active caption bar changes to an inactive caption bar.)</para>
        /// <para>Typically, a window is flashed to inform the user that the window requires attention but that it does not currently have the keyboard focus.</para>
        /// <para>The <see cref="FlashWindow"/> function flashes the window only once; for repeated flashing, the application should create a system timer.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/nf-winuser-flashwindow">FlashWindow function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(NativeLibraryNames.User32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern bool FlashWindow(
            IntPtr hWnd,
            [MarshalAs(UnmanagedType.Bool)] bool bInvert
            );
        #endregion
        #region FlashWindowEx function
        /// <summary>
        /// Flashes the specified window. It does not change the active state of the window.
        /// </summary>
        /// <param name="pfwi">A <see cref="FLASHWINFO"/> structure.</param>
        /// <returns>The return value specifies the window's state before the call to the <see cref="FlashWindowEx"/> function. If the window caption was drawn as active before the call, the return value is <c>true</c>. Otherwise, the return value is <c>false</c>.</returns>
        /// <remarks>
        /// Typically, you flash a window to inform the user that the window requires attention but does not currently have the keyboard focus. When a window flashes, it appears to change from inactive to active status. An inactive caption bar changes to an active caption bar; an active caption bar changes to an inactive caption bar.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/nf-winuser-flashwindowex">FlashWindowEx function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="FLASHWINFO"/>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(NativeLibraryNames.User32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern bool FlashWindowEx(
            in FLASHWINFO pfwi
            );
        #endregion
    }
}
