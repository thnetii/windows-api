using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using static Microsoft.Win32.WinApi.Diagnostics.ErrorHandling.SystemErrorCodes;

namespace Microsoft.Win32.WinApi.Diagnostics.ErrorHandling
{
    /// <summary>
    /// The functions that are used with error handling.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms679321.aspx">Error Handling Functions</a></para>
    /// </remarks>
    public static class ErrorHandlingFunctions
    {
        #region Beep function
        /// <summary>
        /// Generates simple tones on the speaker. The function is synchronous; it performs an alertable wait and does not return control to its caller until the sound finishes.
        /// </summary>
        /// <param name="dwFreq">The frequency of the sound, in hertz. This parameter must be in the range 37 through 32,767 (<c>0x25</c> through <c>0x7FFF</c>). </param>
        /// <param name="dwDuration">The duration of the sound, in milliseconds. </param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>A long time ago, all PC computers shared a common 8254 programable interval timer chip for the generation of primitive sounds. The <see cref="Beep"/> function was written specifically to emit a beep on that piece of hardware. </para>
        /// <para>On these older systems, muting and volume controls have no effect on Beep; you would still hear the tone. To silence the tone, you used the following commands:<pre>net stop beep</pre><pre>sc config beep start= disabled</pre></para>
        /// <para>Since then, sound cards have become standard equipment on almost all PC computers. As sound cards became more common, manufacturers began to remove the old timer chip from computers. The chips were also excluded from the design of server computers. The result is that <see cref="Beep"/> did not work on all computers without the chip. This was okay because most developers had moved on to calling the <see cref="MessageBeep"/> function that uses whatever is the default sound device instead of the 8254 chip. </para>
        /// <para>Eventually because of the lack of hardware to communicate with, support for <see cref="Beep"/> was dropped in Windows Vista and Windows XP 64-Bit Edition.</para>
        /// <para>In Windows 7, <see cref="Beep"/> was rewritten to pass the beep to the default sound device for the session. This is normally the sound card, except when run under Terminal Services, in which case the beep is rendered on the client.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/ms679277.aspx">Beep function</a></para>
        /// </remarks>
        /// <seealso cref="MessageBeep"/>
        [Obsolete("Use the .NET System.Console.Beep(int, int) method instead.")]
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
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
        /// <para>The number of frames to be captured. You can capture up to <see cref="ushort.MaxValue"/> frames.</para>
        /// <para><strong>Windows Server 2003 and Windows XP:</strong> The sum of the <paramref name="FramesToSkip"/> and <paramref name="FramesToCapture"/> parameters must be less than 63.</para>
        /// </param>
        /// <param name="BackTrace">An array of pointers captured from the current stack trace.</param>
        /// <param name="BackTraceHash">
        /// A value that can be used to organize hash tables.
        /// <para>This value is calculated based on the values of the pointers returned in the <paramref name="BackTrace"/> array. Two identical stack traces will generate identical hash values.</para>
        /// </param>
        /// <returns>The number of captured frames.</returns>
        /// <remarks>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/bb204633.aspx">CaptureStackBackTrace function</a></para>
        /// </remarks>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.U2)]
        public static extern ushort CaptureStackBackTrace(
            [In] int FramesToSkip,
            [In] int FramesToCapture,
            out IntPtr BackTrace,
            [Optional] out int BackTraceHash
            );
        #endregion
        #region FatalAppExit function
        /// <summary>
        /// Displays a message box and terminates the application when the message box is closed. If the system is running with a debug version of Kernel32.dll, the message box gives the user the opportunity to terminate the application or to cancel the message box and return to the application that called <see cref="FatalAppExit"/>.
        /// </summary>
        /// <param name="uAction">This parameter must be zero.</param>
        /// <param name="lpMessageText">The null-terminated string that is displayed in the message box.</param>
        /// <remarks>
        /// An application calls FatalAppExit only when it is not capable of terminating any other way. 
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/ms679336.aspx">FatalAppExit function</a></para>
        /// </remarks>
        /// <seealso cref="FatalExit"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern void FatalAppExit(
            [In] int uAction,
            [In, MarshalAs(UnmanagedType.LPTStr)] string lpMessageText
            );
        #endregion
        #region FlashWindow function
        /// <summary>
        /// <para>Flashes the specified window one time. It does not change the active state of the window.</para>
        /// <para>To flash the window a specified number of times, use the <see cref="FlashWindowEx"/> function.</para>
        /// </summary>
        /// <param name="hWnd">A handle to the window to be flashed. The window can be either open or minimized.</param>
        /// <param name="bInvert">
        /// <para>If this parameter is <c>true</c>, the window is flashed from one state to the other. If it is <c>false</c>, the window is returned to its original state (either active or inactive). </para>
        /// <para>When an application is minimized and this parameter is <c>true</c>, the taskbar window button flashes active/inactive. If it is <c>false</c>, the taskbar window button flashes inactive, meaning that it does not change colors. It flashes, as if it were being redrawn, but it does not provide the visual invert clue to the user.</para>
        /// </param>
        /// <returns>The return value specifies the window's state before the call to the <see cref="FlashWindow"/> function. If the window caption was drawn as active before the call, the return value is <c>true</c>. Otherwise, the return value is <c>false</c>.</returns>
        /// <remarks>
        /// <para>Flashing a window means changing the appearance of its caption bar as if the window were changing from inactive to active status, or vice versa. (An inactive caption bar changes to an active caption bar; an active caption bar changes to an inactive caption bar.)</para>
        /// <para>Typically, a window is flashed to inform the user that the window requires attention but that it does not currently have the keyboard focus.</para>
        /// <para>The <see cref="FlashWindow"/> function flashes the window only once; for repeated flashing, the application should create a system timer.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/ms679346.aspx">FlashWindow function</a></para>
        /// </remarks>
        [DllImport("User32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlashWindow(
            [In] IntPtr hWnd,
            [In, MarshalAs(UnmanagedType.Bool)] bool bInvert
            );
        #endregion
        #region FlashWindowEx function
        /// <summary>
        /// Flashes the specified window. It does not change the active state of the window.
        /// </summary>
        /// <param name="pfwi">A reference to a <see cref="FLASHWINFO"/> instance.</param>
        /// <returns>The return value specifies the window's state before the call to the <see cref="FlashWindowEx"/> function. If the window caption was drawn as active before the call, the return value is <c>true</c>. Otherwise, the return value is <c>false</c>.</returns>
        /// <remarks>
        /// Typically, you flash a window to inform the user that the window requires attention but does not currently have the keyboard focus. When a window flashes, it appears to change from inactive to active status. An inactive caption bar changes to an active caption bar; an active caption bar changes to an inactive caption bar.
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/ms679347.aspx">FlashWindowEx function</a></para>
        /// </remarks>
        /// <seealso cref="FLASHWINFO"/>
        [DllImport("User32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlashWindowEx(
            [In, MarshalAs(UnmanagedType.LPStruct)] FLASHWINFO pfwi
            );
        #endregion
        #region MessageBeep function
        /// <summary>
        /// Plays a waveform sound. The waveform sound for each sound type is identified by an entry in the registry.
        /// </summary>
        /// <param name="uType">
        /// <para>The sound to be played. The sounds are set by the user through the Sound control panel application, and then stored in the registry.</para>
        /// <para>Specify <c>(MessageBoxIcon)-1</c> for a simple beep. If the sound card is not available, the sound is generated using the speaker.</para>
        /// <para><see cref="MessageBoxIcon.None"/>: The sound specified as the Windows Default Beep sound.</para>
        /// <para><see cref="MessageBoxIcon.Asterisk"/>, <see cref="MessageBoxIcon.Information"/>: The sound specified as the Windows Asterisk sound.</para>
        /// <para><see cref="MessageBoxIcon.Error"/>, <see cref="MessageBoxIcon.Stop"/>: The sound specified as the Windows Critical Stop sound.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>After queuing the sound, the <see cref="MessageBeep"/> function returns control to the calling function and plays the sound asynchronously.</para>
        /// <para>If it cannot play the specified alert sound, <see cref="MessageBeep"/> attempts to play the system default sound. If it cannot play the system default sound, the function produces a standard beep sound through the computer speaker.</para>
        /// <para>The user can disable the warning beep by using the Sound control panel application.</para>
        /// <para><note>To send a beep to a remote client, use the <see cref="Beep"/> function. The <see cref="Beep"/> function is redirected to the client, whereas <see cref="MessageBeep"/> is not.</note></para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/ms680356.aspx">MessageBeep function</a></para>
        /// </remarks>
        /// <seealso cref="Beep"/>
        /// <seealso cref="FlashWindow"/>
        [DllImport("User32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MessageBeep(
            [In, MarshalAs(UnmanagedType.U4)] MessageBoxIcon uType
            );
        #endregion
    }
}
