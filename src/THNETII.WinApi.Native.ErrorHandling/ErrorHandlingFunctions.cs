using System;
using System.Runtime.InteropServices;
using System.Text;

using static Microsoft.Win32.WinApi.Diagnostics.ErrorHandling.ErrorHandlingFunctions.FORMAT_MESSAGE_FLAG;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

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
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = nameof(FatalAppExit) + "W")]
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
        #region FormatMessage function
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public enum FORMAT_MESSAGE_FLAG : int
        {
            /// <summary>The function allocates a buffer large enough to hold the formatted message.</summary>
            FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100,
            /// <summary>
            /// The values to be inserted into the formatted message are passed as an array.
            /// This flag must be specified to format messages with inserts when using the CLR.
            /// </summary>
            FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000,
            /// <summary>
            /// A module handle containing the message-table resource(s) to search is specified as the source of the formatted message.
            /// If the source handle is specified as <see cref="IntPtr.Zero"/>, the current process's application image file will be searched. This flag cannot be used with <see cref="FORMAT_MESSAGE_FROM_STRING"/>.
            /// <para>If the module has no message table resource, the system fails with <see cref="ERROR_RESOURCE_TYPE_NOT_FOUND"/>.</para>
            /// </summary>
            FORMAT_MESSAGE_FROM_HMODULE = 0x00000800,
            /// <summary>The source parameter is a pointer to a null-terminated string that contains a message definition. The message definition may contain insert sequences, just as the message text in a message table resource may. This flag cannot be used with <see cref="FORMAT_MESSAGE_FROM_HMODULE"/> or <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/>.</summary>
            FORMAT_MESSAGE_FROM_STRING = 0x00000400,
            /// <summary>
            /// The system message-table resource(s) should be searched for the requested message. If this flag is specified with <see cref="FORMAT_MESSAGE_FROM_HMODULE"/>, the system searches the system message table if the message is not found in the module specified by the source parameter. This flag cannot be used with <see cref="FORMAT_MESSAGE_FROM_STRING"/>.
            /// <para>If this flag is specified, an application can pass the result of the <see cref="Marshal.GetLastWin32Error"/> function to retrieve the message text for a system-defined error.</para>
            /// </summary>
            FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000,
            /// <summary>Insert sequences in the message definition are to be ignored and passed through to the output buffer unchanged. This flag is useful for fetching a message for later formatting. If this flag is set, the <em>Arguments</em> parameter for text formatting is ignored.</summary>
            FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200,
            /// <summary>The system ignores regular line breaks in the message definition text. The system stores hard-coded line breaks in the message definition text into the output buffer. The system generates no new line breaks.</summary>
            FORMAT_MESSAGE_MAX_WIDTH_MASK = 0x000000FF
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function. It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s) for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier. The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">
        /// <para>For this particular overload of this function, the <paramref name="dwFlags"/> parameter must not specify the <see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/> flag. If the <paramref name="Arguments"/> parameter is not <c>null</c>, the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag must be specified in the <paramref name="dwFlags"/> parameter.</para>
        /// <para>The formatting options, and how to interpret the <paramref name="lpSource"/> parameter. The low-order byte of <paramref name="dwFlags"/> specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.</para>
        /// <para>The low-order byte of <paramref name="dwFlags"/> can specify the maximum width of a formatted output line. If the low-order byte is <c>0</c> (zero), there are no output line width restrictions. The function stores line breaks that are in the message definition text into the output buffer. <see cref="FORMAT_MESSAGE_MAX_WIDTH_MASK"/> causes the function to ignore regular line breaks in the message definition text. The function stores hard-coded line breaks in the message definition text into the output buffer. The function generates no new line breaks.</para>
        /// <para>If the low-order byte is a nonzero value other than <see cref="FORMAT_MESSAGE_MAX_WIDTH_MASK"/>, it specifies the maximum number of characters in an output line. The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the %n escape sequence.</para>
        /// </param>
        /// <param name="lpSource">
        /// <para>The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="dwFlags"/> parameter.</para>
        /// <para>If the <see cref="FORMAT_MESSAGE_FROM_HMODULE"/> is specified in the <paramref name="dwFlags"/> parameter, the <paramref name="lpSource"/> parameter specifies a handle to the module that contains the message table to search.</para>
        /// <para>If the <see cref="FORMAT_MESSAGE_FROM_STRING"/> is specified in the <paramref name="dwFlags"/> parameter, the <paramref name="lpSource"/> parameter specifies a Pointer to a string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.</para>
        /// <para>If neither of these flags is set in <paramref name="dwFlags"/>, then <paramref name="lpSource"/> is ignored.</para>
        /// </param>
        /// <param name="dwMessageId">The message identifier for the requested message. This parameter is ignored if <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</param>
        /// <param name="dwLanguageId">
        /// <para>The <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a> for the requested message. This parameter is ignored if <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</para>
        /// <para>
        /// If you pass a specific <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a> in this parameter, <see cref="FormatMessage(FORMAT_MESSAGE_FLAG, IntPtr, int, int, StringBuilder, int, IntPtr)"/> will return a message for that <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a> only. If the function cannot find a message for that <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, it sets Last-Error to <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>. If you pass in zero, <see cref="FormatMessage(FORMAT_MESSAGE_FLAG, IntPtr, int, int, StringBuilder, int, IntPtr)"/> looks for a message for <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>s in the following order:
        /// <list type="number">
        /// <item>Language neutral.</item> <item>Thread <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, based on the thread's locale value.</item> <item>User default <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, based on the user's default locale value.</item> <item>System default <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, based on the system default locale value.</item> <item>US English.</item>
        /// </list>
        /// </para>
        /// <para>If <see cref="FormatMessage(FORMAT_MESSAGE_FLAG, IntPtr, int, int, StringBuilder, int, IntPtr)"/> does not locate a message for any of the preceding <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>s, it returns any language message string that is present. If that fails, it returns <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>.</para>
        /// </param>
        /// <param name="lpBuffer">A buffer that receives the null-terminated string that specifies the formatted message.</param>
        /// <param name="nSize">Specifies the size of the output buffer, in characters.</param>
        /// <param name="Arguments">
        /// A pointer to an array of values that are used as insert values in the formatted message. A %1 in the format string indicates the first value in the Arguments array; a %2 indicates the second argument; and so on.
        /// <para>The interpretation of each value depends on the formatting information associated with the insert in the message definition. The default is to treat each value as a pointer to a null-terminated string.</para>
        /// <para>To use this parameter, specify the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag in <paramref name="dwFlags"/>. If you do not want to use this parameter, specify the <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/> flag in the <paramref name="dwFlags"/> parameter.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is the number of characters stored in the output buffer, excluding the terminating null character.
        /// If the function fails, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// Consult the <a href="https://msdn.microsoft.com/en-us/library/ms679351.aspx">FormatMessage function</a> MSDN documentation page for additional remarks on this function.
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps | Windows Store Apps]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps | Windows Store Apps]</para>
        /// <para><strong>Minimum supported phone:</strong> Windows Phone 8</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/ms679351.aspx">FormatMessage function</a></para>
        /// </remarks>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = nameof(FormatMessage) + "W")]
        public static extern int FormatMessage(
            [In, MarshalAs(UnmanagedType.I4)] FORMAT_MESSAGE_FLAG dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer,
            [In] int nSize,
            [In, Optional] IntPtr Arguments
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
            [In, MarshalAs(UnmanagedType.U4)] uint uType
            );
        #endregion
    }
}
