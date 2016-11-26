using System;
using System.Runtime.InteropServices;
using System.Text;

using static Microsoft.Win32.WinApi.Diagnostics.ErrorHandling.ErrorHandlingFunctions.FORMAT_MESSAGE_FLAG;
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
        #region FormatMessage function
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        [Flags]
        public enum FORMAT_MESSAGE_FLAG : int
        {
            FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100,
            FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000,
            FORMAT_MESSAGE_FROM_HMODULE = 0x00000800,
            FORMAT_MESSAGE_FROM_STRING = 0x00000400,
            FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000,
            FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200,
            FORMAT_MESSAGE_MAX_WIDTH_MASK = 0x000000FF
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function.
        /// It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s)
        /// for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier.
        /// The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">
        /// <para>
        /// The formatting options, and how to interpret the <paramref name="lpSource"/> parameter. The low-order byte of <paramref name="dwFlags"/> specifies how
        /// the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.
        /// </para>
        /// <para>This parameter can be one or more of the following values.</para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> (<c>0x00002000</c>): <br/> This flag must alway be passed to this function from managed memory, if the 
        /// <paramref name="Arguments"/> parameter is specified and not equal to <see cref="IntPtr.Zero"/>.
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_FROM_HMODULE"/> (<c>0x00000800</c>): <br/> The <paramref name="lpSource"/> parameter is a module handle containing the message-table
        /// resource(s) to search. If this <paramref name="lpSource"/> handle is <see cref="IntPtr.Zero"/>, the current process's application image file will be
        /// searched. This flag cannot be used with <see cref="FORMAT_MESSAGE_FROM_STRING"/>.<br/> If the module has no message table resource, the function fails
        /// with <see cref="ERROR_RESOURCE_TYPE_NOT_FOUND"/>.
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_FROM_STRING"/> (<c>0x00000400</c>): <br/> The <paramref name="lpSource"/> parameter is a pointer to a null-terminated string that
        /// contains a message definition. The message definition may contain insert sequences, just as the message text in a message table resource may. This flag
        /// cannot be used with <see cref="FORMAT_MESSAGE_FROM_HMODULE"/> or <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/>.
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/> (<c>0x00001000</c>): <br/> The function should search the system message-table resource(s) for the requested message.
        /// If this flag is specified with <see cref="FORMAT_MESSAGE_FROM_HMODULE"/>, the function searches the system message table if the message is not found in
        /// the module specified by <paramref name="lpSource"/>. This flag cannot be used with <see cref="FORMAT_MESSAGE_FROM_STRING"/>.<br/> If this flag is specified,
        /// an application can pass the result of the <see cref="Marshal.GetLastWin32Error"/> function to retrieve the message text for a system-defined error.
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/> (<c>0x00000200</c>): <br/> Insert sequences in the message definition are to be ignored and passed through
        /// to the output buffer unchanged. This flag is useful for fetching a message for later formatting. If this flag is set, the <paramref name="Arguments"/>
        /// parameter is ignored.
        /// </para>
        /// <para>If the format string contains inserts, the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> must be specified when calling this function.</para>
        /// <para>
        /// The low-order byte of <paramref name="dwFlags"/> can specify the maximum width of a formatted output line. The following are possible values of the
        /// low-order byte.
        /// </para>
        /// <para>
        /// <c>0</c> (zero): <br/> There are no output line width restrictions. The function stores line breaks that are in the message definition text into the
        /// output buffer.
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_MAX_WIDTH_MASK"/> (<c>0x000000FF</c>): <br/> The function ignores regular line breaks in the message definition text. The
        /// function stores hard-coded line breaks in the message definition text into the output buffer. The function generates no new line breaks.
        /// </para>
        /// <para>
        /// If the low-order byte is a nonzero value other than <see cref="FORMAT_MESSAGE_MAX_WIDTH_MASK"/>, it specifies the maximum number of characters in an
        /// output line. The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across
        /// a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the
        /// <c>%n</c> escape sequence.
        /// </para>
        /// </param>
        /// <param name="lpSource">
        /// <para>The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="dwFlags"/> parameter.</para>
        /// <para>
        /// <paramref name="dwFlags"/> parameter has flag <see cref="FORMAT_MESSAGE_FROM_HMODULE"/> (<c>0x00000800</c>): <br/> A handle to the module that contains
        /// the message table to search.
        /// </para>
        /// <para>
        /// <paramref name="dwFlags"/> parameter has flag <see cref="FORMAT_MESSAGE_FROM_STRING"/> (<c>0x00000400</c>): <br/> Pointer to a string that consists of
        /// unformatted message text. It will be scanned for inserts and formatted accordingly.
        /// </para>
        /// <para>If neither of these flags is set in <paramref name="dwFlags"/>, then <paramref name="lpSource"/> is ignored.</para>
        /// </param>
        /// <param name="dwMessageId">
        /// The message identifier for the requested message. This parameter is ignored if <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.
        /// </param>
        /// <param name="dwLanguageId">
        /// <para>
        /// The <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a> for the requested message. This parameter is ignored if
        /// <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.
        /// </para>
        /// <para>
        /// If you pass a specific <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a> in this parameter,
        /// <see cref="FormatMessage(FORMAT_MESSAGE_FLAG, IntPtr, int, int, StringBuilder, int, IntPtr[])"/> will return a message for that
        /// <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a> only. If the function cannot find a message for that
        /// <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, it sets Last-Error to
        /// <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>. If you pass in zero, 
        /// <see cref="FormatMessage(FORMAT_MESSAGE_FLAG, IntPtr, int, int, StringBuilder, int, IntPtr[])"/> looks for a message for 
        /// <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>s in the following order:
        /// <list type="number">
        /// <item>Language neutral;</item>
        /// <item>Thread <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, based on the thread's locale value;</item>
        /// <item>User default <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, based on the user's default locale value;</item>
        /// <item>System default <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, based on the system default locale value;</item>
        /// <item>US English.</item>
        /// </list>
        /// </para>
        /// <para>
        /// If <see cref="FormatMessage(FORMAT_MESSAGE_FLAG, IntPtr, int, int, StringBuilder, int, IntPtr[])"/> does not locate a message for any of the preceding
        /// <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>s, it returns any language message string that is present.
        /// If that fails, it returns <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>.
        /// </para>
        /// </param>
        /// <param name="lpBuffer">
        /// <para>A reference to a buffer that receives the null-terminated string that specifies the formatted message.</para>
        /// <para>This buffer cannot be larger than 64K bytes.</para>
        /// </param>
        /// <param name="nSize">
        /// <para>Specifies the size of the output buffer, in characters.</para>
        /// <para>This buffer cannot be larger than 64K bytes.</para>
        /// </param>
        /// <param name="Arguments">
        /// <para>
        /// An array of values that are used as insert values in the formatted message. A %1 in the format string indicates the first value in the Arguments array;
        /// a %2 indicates the second argument; and so on.
        /// </para>
        /// <para>
        /// The interpretation of each value depends on the formatting information associated with the insert in the message definition. The default is to treat
        /// each value as a pointer to a null-terminated string.
        /// </para>
        /// <para>
        /// Specify the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag and pass an array of pointer values; those values are input to the message formatted as the
        /// insert values. Each insert must have a corresponding element in the array.
        /// </para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is the number of characters stored in the output buffer, excluding the terminating null character.</para>
        /// <para>If the function fails, the return value is 0 (zero). To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// Within the message text, several escape sequences are supported for dynamically formatting the message. These escape sequences and their meanings are
        /// shown in the following tables. All escape sequences start with the percent character (%).
        /// </para>
        /// <para>
        /// <strong>Escape sequence:</strong> <c>%0</c>. <strong>Meaning:</strong> Terminates a message text line without a trailing new line character. This escape
        /// sequence can be used to build up long lines or to terminate the message itself without a trailing new line character. It is useful for prompt messages.
        /// </para>
        /// <para>
        /// <strong>Escape sequence:</strong> <c>%n!format string!</c>. <strong>Meaning:</strong> Identifies an insert. The value of <em>n</em> can be in the range
        /// from 1 through 99. The format string (which must be surrounded by exclamation marks) is optional and defaults to <c>!s!</c> if not specified. For more
        /// information, see <a href="http://go.microsoft.com/fwlink/p/?linkid=83949">Format Specification Fields</a>. <br/>
        /// The format string can include a width and precision specifier for strings and a width specifier for integers. Use an asterisk (*) to specify the width
        /// and precision. For example, <c>%1!*.*s!</c> or <c>%1!*u!</c>. <br/>
        /// If you do not use the width and precision specifiers, the insert numbers correspond directly to the input arguments. For example, if the source string
        /// is <c>"%1 %2 %1"</c> and the input arguments are <c>"Bill"</c> and <c>"Bob"</c>, the formatted output string is <c>"Bill Bob Bill"</c>. <br/>
        /// However, if you use a width and precision specifier, the insert numbers do not correspond directly to the input arguments. For example, the insert
        /// numbers for the previous example could change to <c>"%1!*.*s! %4 %5!*s!"</c>. <br/>
        /// The insert numbers depend on whether you use an arguments array (<see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/>). The next insert number is <c><em>n</em>+2</c>
        /// if the previous format string contained one asterisk and is <c><em>n</em>+3</c> if two asterisks were specified. <br/>
        /// If you want to repeat <c>"Bill"</c>, as in the previous example, the arguments must include <c>"Bill"</c> twice. For example, if the source string is
        /// <c>"%1!*.*s! %4 %5!*s!"</c>, the arguments could be, 4, 2, Bill, Bob, 6, Bill (if using the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag). The
        /// formatted string would then be <c>"  Bi Bob   Bill"</c>. <br/>
        /// Repeating insert numbers when the source string contains width and precision specifiers may not yield the intended results. If you replaced <c>%5</c>
        /// with <c>%1</c>, the function would try to print a string at address 6 (likely resulting in an access violation). <br/>
        /// Floating-point format specifiers — e, E, f, and g — are not supported. The workaround is to use the <see cref="StringCchPrintf"/> function to format
        /// the floating-point number into a temporary buffer, then use that buffer as the insert string. <br/>
        /// Inserts that use the <c>I64</c> prefix are treated as two 32-bit arguments. They must be used before subsequent arguments are used. Note that it may
        /// be easier for you to use <see cref="StringCchPrintf"/> instead of this prefix.
        /// </para>
        /// <para>
        /// Any other nondigit character following a percent character is formatted in the output message without the percent character. Following are some examples.
        /// <list type="table">
        /// <listheader><term>Format string</term> <description>Resulting output</description></listheader>
        /// <item><term><c>%%</c></term> <description>A single percent sign.</description></item>
        /// <item><term><c>%<em>space</em></c></term> <description>A single space. This format string can be used to ensure the appropriate number of trailing spaces in a message text line.</description></item>
        /// <item><term><c>%.</c></term> <description>A single period. This format string can be used to include a single period at the beginning of a line without terminating the message text definition.</description></item>
        /// <item><term><c>%!</c></term> <description>A single exclamation point. This format string can be used to include an exclamation point immediately after an insert without its being mistaken for the beginning of a format string.</description></item>
        /// <item><term><c>%n</c></term> <description>A hard line break when the format string occurs at the end of a line. This format string is useful when <see cref="FormatMessage"/> is supplying regular line breaks so the message fits in a certain width.</description></item>
        /// <item><term><c>%r</c></term> <description>A hard carriage return without a trailing newline character.</description></item>
        /// <item><term><c>%t</c></term> <description>A single tab.</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// <strong>Security Remarks</strong><br/>
        /// If this function is called without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>, the <paramref name="Arguments"/> parameter must contain enough
        /// parameters to satisfy all insertion sequences in the message string, and they must be of the correct type. Therefore, do not use untrusted or
        /// unknown message strings with inserts enabled because they can contain more insertion sequences than <paramref name="Arguments"/> provides, or
        /// those that may be of the wrong type. In particular, it is unsafe to take an arbitrary system error code returned from an API and use
        /// <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/> without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>.
        /// </para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para><strong>Minimum supported phone:</strong> Windows Phone 8</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/ms679351.aspx">FormatMessage function</a></para>
        /// </remarks>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int FormatMessage(
            [In, MarshalAs(UnmanagedType.I4)] FORMAT_MESSAGE_FLAG dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            [Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer,
            [In] int nSize,
            [In, Optional, MarshalAs(UnmanagedType.LPArray)] IntPtr[] Arguments
            );

        /// <summary>
        /// Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function.
        /// It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s)
        /// for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier.
        /// The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">
        /// <para>
        /// The formatting options, and how to interpret the <paramref name="lpSource"/> parameter. The low-order byte of <paramref name="dwFlags"/> specifies how
        /// the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.
        /// </para>
        /// <para>This parameter can be one or more of the following values.</para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/> (<c>0x00000100</c>): <br/> The function allocates a buffer large enough to hold the formatted message,
        /// and places a pointer to the allocated buffer at the address specified by <paramref name="lpBuffer"/>. 
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> (<c>0x00002000</c>): <br/> This flag must alway be passed to this function from managed memory, if the 
        /// <paramref name="Arguments"/> parameter is specified and not equal to <see cref="IntPtr.Zero"/>.
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_FROM_HMODULE"/> (<c>0x00000800</c>): <br/> The <paramref name="lpSource"/> parameter is a module handle containing the message-table
        /// resource(s) to search. If this <paramref name="lpSource"/> handle is <see cref="IntPtr.Zero"/>, the current process's application image file will be
        /// searched. This flag cannot be used with <see cref="FORMAT_MESSAGE_FROM_STRING"/>.<br/> If the module has no message table resource, the function fails
        /// with <see cref="ERROR_RESOURCE_TYPE_NOT_FOUND"/>.
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_FROM_STRING"/> (<c>0x00000400</c>): <br/> The <paramref name="lpSource"/> parameter is a pointer to a null-terminated string that
        /// contains a message definition. The message definition may contain insert sequences, just as the message text in a message table resource may. This flag
        /// cannot be used with <see cref="FORMAT_MESSAGE_FROM_HMODULE"/> or <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/>.
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/> (<c>0x00001000</c>): <br/> The function should search the system message-table resource(s) for the requested message.
        /// If this flag is specified with <see cref="FORMAT_MESSAGE_FROM_HMODULE"/>, the function searches the system message table if the message is not found in
        /// the module specified by <paramref name="lpSource"/>. This flag cannot be used with <see cref="FORMAT_MESSAGE_FROM_STRING"/>.<br/> If this flag is specified,
        /// an application can pass the result of the <see cref="Marshal.GetLastWin32Error"/> function to retrieve the message text for a system-defined error.
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/> (<c>0x00000200</c>): <br/> Insert sequences in the message definition are to be ignored and passed through
        /// to the output buffer unchanged. This flag is useful for fetching a message for later formatting. If this flag is set, the <paramref name="Arguments"/>
        /// parameter is ignored.
        /// </para>
        /// <para>If the format string contains inserts, the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> must be specified when calling this function.</para>
        /// <para>
        /// The low-order byte of <paramref name="dwFlags"/> can specify the maximum width of a formatted output line. The following are possible values of the
        /// low-order byte.
        /// </para>
        /// <para>
        /// <c>0</c> (zero): <br/> There are no output line width restrictions. The function stores line breaks that are in the message definition text into the
        /// output buffer.
        /// </para>
        /// <para>
        /// <see cref="FORMAT_MESSAGE_MAX_WIDTH_MASK"/> (<c>0x000000FF</c>): <br/> The function ignores regular line breaks in the message definition text. The
        /// function stores hard-coded line breaks in the message definition text into the output buffer. The function generates no new line breaks.
        /// </para>
        /// <para>
        /// If the low-order byte is a nonzero value other than <see cref="FORMAT_MESSAGE_MAX_WIDTH_MASK"/>, it specifies the maximum number of characters in an
        /// output line. The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across
        /// a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the
        /// <c>%n</c> escape sequence.
        /// </para>
        /// </param>
        /// <param name="lpSource">
        /// <para>The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="dwFlags"/> parameter.</para>
        /// <para>
        /// <paramref name="dwFlags"/> parameter has flag <see cref="FORMAT_MESSAGE_FROM_HMODULE"/> (<c>0x00000800</c>): <br/> A handle to the module that contains
        /// the message table to search.
        /// </para>
        /// <para>
        /// <paramref name="dwFlags"/> parameter has flag <see cref="FORMAT_MESSAGE_FROM_STRING"/> (<c>0x00000400</c>): <br/> Pointer to a string that consists of
        /// unformatted message text. It will be scanned for inserts and formatted accordingly.
        /// </para>
        /// <para>If neither of these flags is set in <paramref name="dwFlags"/>, then <paramref name="lpSource"/> is ignored.</para>
        /// </param>
        /// <param name="dwMessageId">
        /// The message identifier for the requested message. This parameter is ignored if <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.
        /// </param>
        /// <param name="dwLanguageId">
        /// <para>
        /// The <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a> for the requested message. This parameter is ignored if
        /// <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.
        /// </para>
        /// <para>
        /// If you pass a specific <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a> in this parameter,
        /// <see cref="FormatMessage(FORMAT_MESSAGE_FLAG, IntPtr, int, int, StringBuilder, int, IntPtr[])"/> will return a message for that
        /// <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a> only. If the function cannot find a message for that
        /// <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, it sets Last-Error to
        /// <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>. If you pass in zero, 
        /// <see cref="FormatMessage(FORMAT_MESSAGE_FLAG, IntPtr, int, int, StringBuilder, int, IntPtr[])"/> looks for a message for 
        /// <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>s in the following order:
        /// <list type="number">
        /// <item>Language neutral;</item>
        /// <item>Thread <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, based on the thread's locale value;</item>
        /// <item>User default <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, based on the user's default locale value;</item>
        /// <item>System default <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>, based on the system default locale value;</item>
        /// <item>US English.</item>
        /// </list>
        /// </para>
        /// <para>
        /// If <see cref="FormatMessage(FORMAT_MESSAGE_FLAG, IntPtr, int, int, StringBuilder, int, IntPtr[])"/> does not locate a message for any of the preceding
        /// <a href="https://msdn.microsoft.com/en-us/library/dd318691.aspx">language identifier</a>s, it returns any language message string that is present.
        /// If that fails, it returns <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>.
        /// </para>
        /// </param>
        /// <param name="lpBuffer">
        /// <para>A reference to a buffer that receives the null-terminated string that specifies the formatted message.</para>
        /// <para>This buffer cannot be larger than 64K bytes.</para>
        /// </param>
        /// <param name="nSize">
        /// <para>Specifies the size of the output buffer, in characters.</para>
        /// <para>This buffer cannot be larger than 64K bytes.</para>
        /// </param>
        /// <param name="Arguments">
        /// <para>
        /// An array of values that are used as insert values in the formatted message. A %1 in the format string indicates the first value in the Arguments array;
        /// a %2 indicates the second argument; and so on.
        /// </para>
        /// <para>
        /// The interpretation of each value depends on the formatting information associated with the insert in the message definition. The default is to treat
        /// each value as a pointer to a null-terminated string.
        /// </para>
        /// <para>
        /// Specify the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag and pass an array of pointer values; those values are input to the message formatted as the
        /// insert values. Each insert must have a corresponding element in the array.
        /// </para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is the number of characters stored in the output buffer, excluding the terminating null character.</para>
        /// <para>If the function fails, the return value is 0 (zero). To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// Within the message text, several escape sequences are supported for dynamically formatting the message. These escape sequences and their meanings are
        /// shown in the following tables. All escape sequences start with the percent character (%).
        /// </para>
        /// <para>
        /// <strong>Escape sequence:</strong> <c>%0</c>. <strong>Meaning:</strong> Terminates a message text line without a trailing new line character. This escape
        /// sequence can be used to build up long lines or to terminate the message itself without a trailing new line character. It is useful for prompt messages.
        /// </para>
        /// <para>
        /// <strong>Escape sequence:</strong> <c>%n!format string!</c>. <strong>Meaning:</strong> Identifies an insert. The value of <em>n</em> can be in the range
        /// from 1 through 99. The format string (which must be surrounded by exclamation marks) is optional and defaults to <c>!s!</c> if not specified. For more
        /// information, see <a href="http://go.microsoft.com/fwlink/p/?linkid=83949">Format Specification Fields</a>. <br/>
        /// The format string can include a width and precision specifier for strings and a width specifier for integers. Use an asterisk (*) to specify the width
        /// and precision. For example, <c>%1!*.*s!</c> or <c>%1!*u!</c>. <br/>
        /// If you do not use the width and precision specifiers, the insert numbers correspond directly to the input arguments. For example, if the source string
        /// is <c>"%1 %2 %1"</c> and the input arguments are <c>"Bill"</c> and <c>"Bob"</c>, the formatted output string is <c>"Bill Bob Bill"</c>. <br/>
        /// However, if you use a width and precision specifier, the insert numbers do not correspond directly to the input arguments. For example, the insert
        /// numbers for the previous example could change to <c>"%1!*.*s! %4 %5!*s!"</c>. <br/>
        /// The insert numbers depend on whether you use an arguments array (<see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/>). The next insert number is <c><em>n</em>+2</c>
        /// if the previous format string contained one asterisk and is <c><em>n</em>+3</c> if two asterisks were specified. <br/>
        /// If you want to repeat <c>"Bill"</c>, as in the previous example, the arguments must include <c>"Bill"</c> twice. For example, if the source string is
        /// <c>"%1!*.*s! %4 %5!*s!"</c>, the arguments could be, 4, 2, Bill, Bob, 6, Bill (if using the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag). The
        /// formatted string would then be <c>"  Bi Bob   Bill"</c>. <br/>
        /// Repeating insert numbers when the source string contains width and precision specifiers may not yield the intended results. If you replaced <c>%5</c>
        /// with <c>%1</c>, the function would try to print a string at address 6 (likely resulting in an access violation). <br/>
        /// Floating-point format specifiers — e, E, f, and g — are not supported. The workaround is to use the <see cref="StringCchPrintf"/> function to format
        /// the floating-point number into a temporary buffer, then use that buffer as the insert string. <br/>
        /// Inserts that use the <c>I64</c> prefix are treated as two 32-bit arguments. They must be used before subsequent arguments are used. Note that it may
        /// be easier for you to use <see cref="StringCchPrintf"/> instead of this prefix.
        /// </para>
        /// <para>
        /// Any other nondigit character following a percent character is formatted in the output message without the percent character. Following are some examples.
        /// <list type="table">
        /// <listheader><term>Format string</term> <description>Resulting output</description></listheader>
        /// <item><term><c>%%</c></term> <description>A single percent sign.</description></item>
        /// <item><term><c>%<em>space</em></c></term> <description>A single space. This format string can be used to ensure the appropriate number of trailing spaces in a message text line.</description></item>
        /// <item><term><c>%.</c></term> <description>A single period. This format string can be used to include a single period at the beginning of a line without terminating the message text definition.</description></item>
        /// <item><term><c>%!</c></term> <description>A single exclamation point. This format string can be used to include an exclamation point immediately after an insert without its being mistaken for the beginning of a format string.</description></item>
        /// <item><term><c>%n</c></term> <description>A hard line break when the format string occurs at the end of a line. This format string is useful when <see cref="FormatMessage"/> is supplying regular line breaks so the message fits in a certain width.</description></item>
        /// <item><term><c>%r</c></term> <description>A hard carriage return without a trailing newline character.</description></item>
        /// <item><term><c>%t</c></term> <description>A single tab.</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// <strong>Security Remarks</strong><br/>
        /// If this function is called without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>, the <paramref name="Arguments"/> parameter must contain enough
        /// parameters to satisfy all insertion sequences in the message string, and they must be of the correct type. Therefore, do not use untrusted or
        /// unknown message strings with inserts enabled because they can contain more insertion sequences than <paramref name="Arguments"/> provides, or
        /// those that may be of the wrong type. In particular, it is unsafe to take an arbitrary system error code returned from an API and use
        /// <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/> without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>.
        /// </para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para><strong>Minimum supported phone:</strong> Windows Phone 8</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/ms679351.aspx">FormatMessage function</a></para>
        /// </remarks>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int FormatMessage(
            [In, MarshalAs(UnmanagedType.I4), DefaultParameterValue(FORMAT_MESSAGE_ALLOCATE_BUFFER)] FORMAT_MESSAGE_FLAG dwFlags,
            [In, Optional] IntPtr lpSource,
            [In] int dwMessageId,
            [In] int dwLanguageId,
            out IntPtr lpBuffer,
            [In] int nSize,
            [In, Optional, MarshalAs(UnmanagedType.LPArray)] IntPtr[] Arguments
            );
        #endregion
    }
}
