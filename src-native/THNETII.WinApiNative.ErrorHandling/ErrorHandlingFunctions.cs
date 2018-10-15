using System;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.InteropServices.NativeMemory.Specialized;
#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApiNative.ErrorHandling
{
    using static FORMAT_MESSAGE_FLAGS;
    using static WindowsProtocols.WindowsErrorCodes.Constants.WinErrorConstants;

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
        #region FormatMessage function
        /// <summary>
        /// Formats a message string. The function requires a message definition as input.
        /// It can come from a message table resource in an already-loaded module.
        /// Or the caller can ask the function to search the system's message table resource(s) for the message definition.
        /// The function finds the message definition in a message table resource based on a message identifier and a language identifier.
        /// The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">
        /// <para>
        /// The formatting options, and how to interpret the <paramref name="lpSource"/> parameter.
        /// The <see cref="FORMAT_MESSAGE_OPTIONS.Width"/> property specifies how the function handles line breaks in the output buffer. It can also specify the maximum width of a formatted output line.
        /// </para>
        /// <para>
        /// The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the <c>%n</c> escape sequence.
        /// </para>
        /// </param>
        /// <param name="lpSource">
        /// The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="dwFlags"/> parameter.
        /// <list type="table">
        /// <listheader><term><c><paramref name="dwFlags"/></c></term><description>Meaning</description></listheader>
        /// <item><term><c><see cref="FORMAT_MESSAGE_FROM_HMODULE"/></c></term><description>A handle to the module that contains the message table to search.</description></item>
        /// <item><term><c><see cref="FORMAT_MESSAGE_FROM_STRING"/></c></term><description>Pointer to a string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.</description></item>
        /// </list>
        /// If neither of these flags is set in <paramref name="dwFlags"/>, then <paramref name="lpSource"/> is ignored.
        /// </param>
        /// <param name="dwMessageId">The message identifier for the requested message. This parameter is ignored if<paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</param>
        /// <param name="dwLanguageId">
        /// <para>The language identifier for the requested message. This parameter is ignored if <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</para>
        /// <para>
        /// If you pass a specific LCID in this parameter, <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, StringBuilder, int, IntPtr)"/> will return a message for that LCID only.
        /// If the function cannot find a message for that LCID, it sets Last-Error to <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>.
        /// If you pass in <c>0</c> (zero), <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, StringBuilder, int, IntPtr)"/> looks for a message for LCIDs in the following order:
        /// <list type="number">
        /// <item><term>Language neutral</term></item>
        /// <item><term>Thread LCID, based on the thread's locale value</term></item>
        /// <item><term>User default LCID, based on the user's default locale value</term></item>
        /// <item><term>System default LCID, based on the system default locale value</term></item>
        /// <item><term>US English</term></item>
        /// </list>
        /// </para>
        /// <para>
        /// If <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, StringBuilder, int, IntPtr)"/> does not locate a message for any of the preceding LCIDs,
        /// it returns any language message string that is present. If that fails, it returns <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>. 
        /// </para>
        /// </param>
        /// <param name="lpBuffer">
        /// A buffer that receives the the string that specifies the formatted message.
        /// <para><strong>DO NOT</strong> use this overload with the <see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/> flag set in <paramref name="dwFlags"/>!</para>
        /// </param>
        /// <param name="nSize">Specifies the <see cref="StringBuilder.Capacity"/> of <paramref name="lpBuffer"/>.</param>
        /// <param name="Arguments">
        /// <para>A pointer to an array of values that are used as insert values in the formatted message. A <c>%1</c> in the format string indicates the first value in the Arguments array; a <c>%2</c> indicates the second argument; and so on.</para>
        /// <para>The interpretation of each value depends on the formatting information associated with the insert in the message definition. The default is to treat each value as a pointer to a null-terminated unicode string.</para>
        /// <para><strong>DO NOT</strong> use this parameter if the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag is not set in <paramref name="dwFlags"/>!</para>
        /// <para>The default value of <see cref="IntPtr.Zero"/> can be used to indicate no insert arguments. This should be used when the <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/> flag is set in <paramref name="dwFlags"/></para>
        /// </param>
        /// <returns>
        /// <para>
        /// If the function succeeds, the return value is the number of characters stored in the output buffer, excluding the terminating null character.
        /// </para>
        /// <para>If the function fails, the return value is <c>0</c> (zero). To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// Within the message text, several escape sequences are supported for dynamically formatting the message. These escape sequences and their meanings are shown in the following tables. All escape sequences start with the percent character (%).
        /// <list type="table">
        /// <listheader><term>Escape sequence</term><description>Meaning</description></listheader>
        /// <item><term><c>%0</c></term><description>Terminates a message text line without a trailing new line character. This escape sequence can be used to build up long lines or to terminate the message itself without a trailing new line character. It is useful for prompt messages.</description></item>
        /// <item>
        /// <term><c>%n!<em>format string</em>!</c></term>
        /// <description>
        /// <para>Identifies an insert. The value of <em>n</em> can be in the range from 1 through 99. The format string (which must be surrounded by exclamation marks) is optional and defaults to <c>!s!</c> if not specified. For more information, see <a href="http://go.microsoft.com/fwlink/p/?linkid=83949">Format Specification Fields</a>.</para>
        /// <para>The format string can include a width and precision specifier for strings and a width specifier for integers. Use an asterisk (<c>*</c>) to specify the width and precision. For example, <c>%1!.*s!</c> or <c>%1!*u!</c>.</para>
        /// <para>If you do not use the width and precision specifiers, the insert numbers correspond directly to the input arguments. For example, if the source string is <c>"%1 %2 %1"</c> and the input arguments are <c>"Bill"</c> and <c>"Bob"</c>, the formatted output string is <c>"Bill Bob Bill"</c>.</para>
        /// <para>However, if you use a width and precision specifier, the insert numbers do not correspond directly to the input arguments. For example, the insert numbers for the previous example could change to <c>"%1!*.*s! %4 %5!*s!"</c>.</para>
        /// <para>The next insert number is <c>n + 2</c> if the previous format string contained one asterisk and is <c>n + 3</c> if two asterisks were specified.</para>
        /// <para>If you want to repeat <c>"Bill"</c>, as in the previous example, the arguments must include <c>"Bill"</c> twice. For example, if the source string is <c>"%1!*.*s! %4 %5!*s!"</c>, the arguments could be, <c>4</c>, <c>2</c>, <c>"Bill"</c>, <c>"Bob"</c>, <c>6</c>, <c>"Bill"</c> (if using the <see cref="FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag). The formatted string would then be <c>"  Bi Bob   Bill"</c>.</para>
        /// <para>Repeating insert numbers when the source string contains width and precision specifiers may not yield the intended results. If you replaced <c>%5</c> with <c>%1</c>, the function would try to print a string at address 6 (likely resulting in an access violation).</para>
        /// <para>Floating-point format specifiers—<c>e</c>, <c>E</c>, <c>f</c>, and <c>g</c>—are not supported. The workaround is to pre-format floating-point number using the regular <see cref="double.ToString()"/> method and then insert that string.</para>
        /// <para>Inserts that use the <c>I64</c> prefix are treated as two 32-bit arguments.</para>
        /// </description>
        /// </item>
        /// </list>
        /// </para>
        /// <para>
        /// Any other nondigit character following a percent character is formatted in the output message without the percent character. Following are some examples.
        /// <list type="table">
        /// <listheader><term>Format string</term><description>Resulting output</description></listheader>
        /// <item><term><c>%%</c></term><description>A single percent sign.</description></item>
        /// <item><term><c>%<em>space</em></c></term><description>A single space. This format string can be used to ensure the appropriate number of trailing spaces in a message text line.</description></item>
        /// <item><term><c>%.</c></term><description>A single period. This format string can be used to include a single period at the beginning of a line without terminating the message text definition.</description></item>
        /// <item><term><c>%!</c></term><description>A single exclamation point. This format string can be used to include an exclamation point immediately after an insert without its being mistaken for the beginning of a format string.</description></item>
        /// <item><term><c>%n</c></term><description>A hard line break when the format string occurs at the end of a line. This format string is useful when <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, StringBuilder, int, IntPtr)"/> is supplying regular line breaks so the message fits in a certain width.</description></item>
        /// <item><term><c>%r</c></term><description>A hard carriage return without a trailing newline character.</description></item>
        /// <item><term><c>%t</c></term><description>A single tab.</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// <strong>Security Remarks</strong><br/>
        /// If this function is called without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>, the <paramref name="Arguments"/> parameter must contain enough parameters to satisfy all insertion sequences in the message string, and they must be of the correct type. Therefore, do not use untrusted or unknown message strings with inserts enabled because they can contain more insertion sequences than <paramref name="Arguments"/> provides, or those that may be of the wrong type. In particular, it is unsafe to take an arbitrary system error code returned from an API and use <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/> without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>. 
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/nf-winuser-formatmessagew">FormatMessageW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(FormatMessage) + "W", SetLastError = true)]
        public static extern int FormatMessage(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer,
            int nSize,
            IntPtr Arguments
            );
        /// <summary>
        /// Formats a message string. The function requires a message definition as input.
        /// It can come from a message table resource in an already-loaded module.
        /// Or the caller can ask the function to search the system's message table resource(s) for the message definition.
        /// The function finds the message definition in a message table resource based on a message identifier and a language identifier.
        /// The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">
        /// <para>
        /// The formatting options, and how to interpret the <paramref name="lpSource"/> parameter.
        /// The <see cref="FORMAT_MESSAGE_OPTIONS.Width"/> property specifies how the function handles line breaks in the output buffer. It can also specify the maximum width of a formatted output line.
        /// </para>
        /// <para>
        /// The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the <c>%n</c> escape sequence.
        /// </para>
        /// </param>
        /// <param name="lpSource">
        /// <para>A string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.</para>
        /// <para>Only use this overload if the <see cref="FORMAT_MESSAGE_FROM_STRING"/> flag is set in <paramref name="dwFlags"/>. Otherwise, set this parameter to <c>null</c>.</para>
        /// </param>
        /// <param name="dwMessageId">The message identifier for the requested message. This parameter is ignored if<paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</param>
        /// <param name="dwLanguageId">
        /// <para>The language identifier for the requested message. This parameter is ignored if <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</para>
        /// <para>
        /// If you pass a specific LCID in this parameter, <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, StringBuilder, int, IntPtr)"/> will return a message for that LCID only.
        /// If the function cannot find a message for that LCID, it sets Last-Error to <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>.
        /// If you pass in <c>0</c> (zero), <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, StringBuilder, int, IntPtr)"/> looks for a message for LCIDs in the following order:
        /// <list type="number">
        /// <item><term>Language neutral</term></item>
        /// <item><term>Thread LCID, based on the thread's locale value</term></item>
        /// <item><term>User default LCID, based on the user's default locale value</term></item>
        /// <item><term>System default LCID, based on the system default locale value</term></item>
        /// <item><term>US English</term></item>
        /// </list>
        /// </para>
        /// <para>
        /// If <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, StringBuilder, int, IntPtr)"/> does not locate a message for any of the preceding LCIDs,
        /// it returns any language message string that is present. If that fails, it returns <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>. 
        /// </para>
        /// </param>
        /// <param name="lpBuffer">
        /// A buffer that receives the the string that specifies the formatted message.
        /// <para><strong>DO NOT</strong> use this overload with the <see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/> flag set in <paramref name="dwFlags"/>!</para>
        /// </param>
        /// <param name="nSize">Specifies the <see cref="StringBuilder.Capacity"/> of <paramref name="lpBuffer"/>.</param>
        /// <param name="Arguments">
        /// <para>A pointer to an array of values that are used as insert values in the formatted message. A <c>%1</c> in the format string indicates the first value in the Arguments array; a <c>%2</c> indicates the second argument; and so on.</para>
        /// <para>The interpretation of each value depends on the formatting information associated with the insert in the message definition. The default is to treat each value as a pointer to a null-terminated unicode string.</para>
        /// <para><strong>DO NOT</strong> use this parameter if the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag is not set in <paramref name="dwFlags"/>!</para>
        /// <para>The default value of <see cref="IntPtr.Zero"/> can be used to indicate no insert arguments. This should be used when the <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/> flag is set in <paramref name="dwFlags"/></para>
        /// </param>
        /// <returns>
        /// <para>
        /// If the function succeeds, the return value is the number of characters stored in the output buffer, excluding the terminating null character.
        /// </para>
        /// <para>If the function fails, the return value is <c>0</c> (zero). To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// Within the message text, several escape sequences are supported for dynamically formatting the message. These escape sequences and their meanings are shown in the following tables. All escape sequences start with the percent character (%).
        /// <list type="table">
        /// <listheader><term>Escape sequence</term><description>Meaning</description></listheader>
        /// <item><term><c>%0</c></term><description>Terminates a message text line without a trailing new line character. This escape sequence can be used to build up long lines or to terminate the message itself without a trailing new line character. It is useful for prompt messages.</description></item>
        /// <item>
        /// <term><c>%n!<em>format string</em>!</c></term>
        /// <description>
        /// <para>Identifies an insert. The value of <em>n</em> can be in the range from 1 through 99. The format string (which must be surrounded by exclamation marks) is optional and defaults to <c>!s!</c> if not specified. For more information, see <a href="http://go.microsoft.com/fwlink/p/?linkid=83949">Format Specification Fields</a>.</para>
        /// <para>The format string can include a width and precision specifier for strings and a width specifier for integers. Use an asterisk (<c>*</c>) to specify the width and precision. For example, <c>%1!.*s!</c> or <c>%1!*u!</c>.</para>
        /// <para>If you do not use the width and precision specifiers, the insert numbers correspond directly to the input arguments. For example, if the source string is <c>"%1 %2 %1"</c> and the input arguments are <c>"Bill"</c> and <c>"Bob"</c>, the formatted output string is <c>"Bill Bob Bill"</c>.</para>
        /// <para>However, if you use a width and precision specifier, the insert numbers do not correspond directly to the input arguments. For example, the insert numbers for the previous example could change to <c>"%1!*.*s! %4 %5!*s!"</c>.</para>
        /// <para>The next insert number is <c>n + 2</c> if the previous format string contained one asterisk and is <c>n + 3</c> if two asterisks were specified.</para>
        /// <para>If you want to repeat <c>"Bill"</c>, as in the previous example, the arguments must include <c>"Bill"</c> twice. For example, if the source string is <c>"%1!*.*s! %4 %5!*s!"</c>, the arguments could be, <c>4</c>, <c>2</c>, <c>"Bill"</c>, <c>"Bob"</c>, <c>6</c>, <c>"Bill"</c> (if using the <see cref="FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag). The formatted string would then be <c>"  Bi Bob   Bill"</c>.</para>
        /// <para>Repeating insert numbers when the source string contains width and precision specifiers may not yield the intended results. If you replaced <c>%5</c> with <c>%1</c>, the function would try to print a string at address 6 (likely resulting in an access violation).</para>
        /// <para>Floating-point format specifiers—<c>e</c>, <c>E</c>, <c>f</c>, and <c>g</c>—are not supported. The workaround is to pre-format floating-point number using the regular <see cref="double.ToString()"/> method and then insert that string.</para>
        /// <para>Inserts that use the <c>I64</c> prefix are treated as two 32-bit arguments.</para>
        /// </description>
        /// </item>
        /// </list>
        /// </para>
        /// <para>
        /// Any other nondigit character following a percent character is formatted in the output message without the percent character. Following are some examples.
        /// <list type="table">
        /// <listheader><term>Format string</term><description>Resulting output</description></listheader>
        /// <item><term><c>%%</c></term><description>A single percent sign.</description></item>
        /// <item><term><c>%<em>space</em></c></term><description>A single space. This format string can be used to ensure the appropriate number of trailing spaces in a message text line.</description></item>
        /// <item><term><c>%.</c></term><description>A single period. This format string can be used to include a single period at the beginning of a line without terminating the message text definition.</description></item>
        /// <item><term><c>%!</c></term><description>A single exclamation point. This format string can be used to include an exclamation point immediately after an insert without its being mistaken for the beginning of a format string.</description></item>
        /// <item><term><c>%n</c></term><description>A hard line break when the format string occurs at the end of a line. This format string is useful when <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, StringBuilder, int, IntPtr)"/> is supplying regular line breaks so the message fits in a certain width.</description></item>
        /// <item><term><c>%r</c></term><description>A hard carriage return without a trailing newline character.</description></item>
        /// <item><term><c>%t</c></term><description>A single tab.</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// <strong>Security Remarks</strong><br/>
        /// If this function is called without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>, the <paramref name="Arguments"/> parameter must contain enough parameters to satisfy all insertion sequences in the message string, and they must be of the correct type. Therefore, do not use untrusted or unknown message strings with inserts enabled because they can contain more insertion sequences than <paramref name="Arguments"/> provides, or those that may be of the wrong type. In particular, it is unsafe to take an arbitrary system error code returned from an API and use <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/> without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>. 
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/nf-winuser-formatmessagew">FormatMessageW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(FormatMessage) + "W", SetLastError = true)]
        public static extern int FormatMessage(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            [MarshalAs(UnmanagedType.LPWStr)] string lpSource,
            int dwMessageId,
            int dwLanguageId,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer,
            int nSize,
            IntPtr Arguments
            );
        /// <summary>
        /// Formats a message string. The function requires a message definition as input.
        /// It can come from a message table resource in an already-loaded module.
        /// Or the caller can ask the function to search the system's message table resource(s) for the message definition.
        /// The function finds the message definition in a message table resource based on a message identifier and a language identifier.
        /// The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">
        /// <para>
        /// The formatting options, and how to interpret the <paramref name="lpSource"/> parameter.
        /// The <see cref="FORMAT_MESSAGE_OPTIONS.Width"/> property specifies how the function handles line breaks in the output buffer. It can also specify the maximum width of a formatted output line.
        /// </para>
        /// <para>
        /// The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the <c>%n</c> escape sequence.
        /// </para>
        /// </param>
        /// <param name="lpSource">
        /// The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="dwFlags"/> parameter.
        /// <list type="table">
        /// <listheader><term><c><paramref name="dwFlags"/></c></term><description>Meaning</description></listheader>
        /// <item><term><c><see cref="FORMAT_MESSAGE_FROM_HMODULE"/></c></term><description>A handle to the module that contains the message table to search.</description></item>
        /// <item><term><c><see cref="FORMAT_MESSAGE_FROM_STRING"/></c></term><description>Pointer to a string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.</description></item>
        /// </list>
        /// If neither of these flags is set in <paramref name="dwFlags"/>, then <paramref name="lpSource"/> is ignored.
        /// </param>
        /// <param name="dwMessageId">The message identifier for the requested message. This parameter is ignored if<paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</param>
        /// <param name="dwLanguageId">
        /// <para>The language identifier for the requested message. This parameter is ignored if <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</para>
        /// <para>
        /// If you pass a specific LCID in this parameter, <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, out WideStringPtr, int, IntPtr)"/> will return a message for that LCID only.
        /// If the function cannot find a message for that LCID, it sets Last-Error to <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>.
        /// If you pass in <c>0</c> (zero), <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, out WideStringPtr, int, IntPtr)"/> looks for a message for LCIDs in the following order:
        /// <list type="number">
        /// <item><term>Language neutral</term></item>
        /// <item><term>Thread LCID, based on the thread's locale value</term></item>
        /// <item><term>User default LCID, based on the user's default locale value</term></item>
        /// <item><term>System default LCID, based on the system default locale value</term></item>
        /// <item><term>US English</term></item>
        /// </list>
        /// </para>
        /// <para>
        /// If <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, out WideStringPtr, int, IntPtr)"/> does not locate a message for any of the preceding LCIDs,
        /// it returns any language message string that is present. If that fails, it returns <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>. 
        /// </para>
        /// </param>
        /// <param name="lpBuffer">
        /// Receives a buffer to the null-terminated string that specifies the formatted message. <strong>ONLY</strong> use this overload if <see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/> is included in <paramref name="dwFlags"/>.
        /// <para>The function allocates a buffer using the <see cref="M:THNETII.WinApiNative.MemoryManagement.MemoryManagementFunctions.LocalAlloc"/> function.</para>
        /// <para>This buffer cannot be larger than 64K bytes.</para>
        /// </param>
        /// <param name="nSize">
        /// <para>Specifies the minimum number of characters to allocate for the output buffer to return in <paramref name="lpBuffer"/>.</para>
        /// <para>The output buffer cannot be larger than 64K bytes.</para>
        /// </param>
        /// <param name="Arguments">
        /// <para>A pointer to an array of values that are used as insert values in the formatted message. A <c>%1</c> in the format string indicates the first value in the Arguments array; a <c>%2</c> indicates the second argument; and so on.</para>
        /// <para>The interpretation of each value depends on the formatting information associated with the insert in the message definition. The default is to treat each value as a pointer to a null-terminated unicode string.</para>
        /// <para><strong>DO NOT</strong> use this parameter if the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag is not set in <paramref name="dwFlags"/>!</para>
        /// <para>The default value of <see cref="IntPtr.Zero"/> can be used to indicate no insert arguments. This should be used when the <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/> flag is set in <paramref name="dwFlags"/></para>
        /// </param>
        /// <returns>
        /// <para>
        /// If the function succeeds, the return value is the number of characters stored in the output buffer, excluding the terminating null character.
        /// </para>
        /// <para>If the function fails, the return value is <c>0</c> (zero). To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// Within the message text, several escape sequences are supported for dynamically formatting the message. These escape sequences and their meanings are shown in the following tables. All escape sequences start with the percent character (%).
        /// <list type="table">
        /// <listheader><term>Escape sequence</term><description>Meaning</description></listheader>
        /// <item><term><c>%0</c></term><description>Terminates a message text line without a trailing new line character. This escape sequence can be used to build up long lines or to terminate the message itself without a trailing new line character. It is useful for prompt messages.</description></item>
        /// <item>
        /// <term><c>%n!<em>format string</em>!</c></term>
        /// <description>
        /// <para>Identifies an insert. The value of <em>n</em> can be in the range from 1 through 99. The format string (which must be surrounded by exclamation marks) is optional and defaults to <c>!s!</c> if not specified. For more information, see <a href="http://go.microsoft.com/fwlink/p/?linkid=83949">Format Specification Fields</a>.</para>
        /// <para>The format string can include a width and precision specifier for strings and a width specifier for integers. Use an asterisk (<c>*</c>) to specify the width and precision. For example, <c>%1!.*s!</c> or <c>%1!*u!</c>.</para>
        /// <para>If you do not use the width and precision specifiers, the insert numbers correspond directly to the input arguments. For example, if the source string is <c>"%1 %2 %1"</c> and the input arguments are <c>"Bill"</c> and <c>"Bob"</c>, the formatted output string is <c>"Bill Bob Bill"</c>.</para>
        /// <para>However, if you use a width and precision specifier, the insert numbers do not correspond directly to the input arguments. For example, the insert numbers for the previous example could change to <c>"%1!*.*s! %4 %5!*s!"</c>.</para>
        /// <para>The next insert number is <c>n + 2</c> if the previous format string contained one asterisk and is <c>n + 3</c> if two asterisks were specified.</para>
        /// <para>If you want to repeat <c>"Bill"</c>, as in the previous example, the arguments must include <c>"Bill"</c> twice. For example, if the source string is <c>"%1!*.*s! %4 %5!*s!"</c>, the arguments could be, <c>4</c>, <c>2</c>, <c>"Bill"</c>, <c>"Bob"</c>, <c>6</c>, <c>"Bill"</c> (if using the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag). The formatted string would then be <c>"  Bi Bob   Bill"</c>.</para>
        /// <para>Repeating insert numbers when the source string contains width and precision specifiers may not yield the intended results. If you replaced <c>%5</c> with <c>%1</c>, the function would try to print a string at address 6 (likely resulting in an access violation).</para>
        /// <para>Floating-point format specifiers—<c>e</c>, <c>E</c>, <c>f</c>, and <c>g</c>—are not supported. The workaround is to pre-format floating-point number using the regular <see cref="double.ToString()"/> method and then insert that string.</para>
        /// <para>Inserts that use the <c>I64</c> prefix are treated as two 32-bit arguments.</para>
        /// </description>
        /// </item>
        /// </list>
        /// </para>
        /// <para>
        /// Any other nondigit character following a percent character is formatted in the output message without the percent character. Following are some examples.
        /// <list type="table">
        /// <listheader><term>Format string</term><description>Resulting output</description></listheader>
        /// <item><term><c>%%</c></term><description>A single percent sign.</description></item>
        /// <item><term><c>%<em>space</em></c></term><description>A single space. This format string can be used to ensure the appropriate number of trailing spaces in a message text line.</description></item>
        /// <item><term><c>%.</c></term><description>A single period. This format string can be used to include a single period at the beginning of a line without terminating the message text definition.</description></item>
        /// <item><term><c>%!</c></term><description>A single exclamation point. This format string can be used to include an exclamation point immediately after an insert without its being mistaken for the beginning of a format string.</description></item>
        /// <item><term><c>%n</c></term><description>A hard line break when the format string occurs at the end of a line. This format string is useful when <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, out WideStringPtr, int, IntPtr)"/> is supplying regular line breaks so the message fits in a certain width.</description></item>
        /// <item><term><c>%r</c></term><description>A hard carriage return without a trailing newline character.</description></item>
        /// <item><term><c>%t</c></term><description>A single tab.</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// <strong>Security Remarks</strong><br/>
        /// If this function is called without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>, the <paramref name="Arguments"/> parameter must contain enough parameters to satisfy all insertion sequences in the message string, and they must be of the correct type. Therefore, do not use untrusted or unknown message strings with inserts enabled because they can contain more insertion sequences than <paramref name="Arguments"/> provides, or those that may be of the wrong type. In particular, it is unsafe to take an arbitrary system error code returned from an API and use <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/> without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>. 
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/nf-winuser-formatmessagew">FormatMessageW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(FormatMessage) + "W", SetLastError = true)]
        public static extern int FormatMessage(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            out WideStringPtr lpBuffer,
            int nSize,
            IntPtr Arguments
            );
        /// <summary>
        /// Formats a message string. The function requires a message definition as input.
        /// It can come from a message table resource in an already-loaded module.
        /// Or the caller can ask the function to search the system's message table resource(s) for the message definition.
        /// The function finds the message definition in a message table resource based on a message identifier and a language identifier.
        /// The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
        /// </summary>
        /// <param name="dwFlags">
        /// <para>
        /// The formatting options, and how to interpret the <paramref name="lpSource"/> parameter.
        /// The <see cref="FORMAT_MESSAGE_OPTIONS.Width"/> property specifies how the function handles line breaks in the output buffer. It can also specify the maximum width of a formatted output line.
        /// </para>
        /// <para>
        /// The function ignores regular line breaks in the message definition text. The function never splits a string delimited by white space across a line break. The function stores hard-coded line breaks in the message definition text into the output buffer. Hard-coded line breaks are coded with the <c>%n</c> escape sequence.
        /// </para>
        /// </param>
        /// <param name="lpSource">
        /// <para>A string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.</para>
        /// <para>Only use this overload if the <see cref="FORMAT_MESSAGE_FROM_STRING"/> flag is set in <paramref name="dwFlags"/>. Otherwise, set this parameter to <c>null</c>.</para>
        /// </param>
        /// <param name="dwMessageId">The message identifier for the requested message. This parameter is ignored if<paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</param>
        /// <param name="dwLanguageId">
        /// <para>The language identifier for the requested message. This parameter is ignored if <paramref name="dwFlags"/> includes <see cref="FORMAT_MESSAGE_FROM_STRING"/>.</para>
        /// <para>
        /// If you pass a specific LCID in this parameter, <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, out WideStringPtr, int, IntPtr)"/> will return a message for that LCID only.
        /// If the function cannot find a message for that LCID, it sets Last-Error to <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>.
        /// If you pass in <c>0</c> (zero), <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, out WideStringPtr, int, IntPtr)"/> looks for a message for LCIDs in the following order:
        /// <list type="number">
        /// <item><term>Language neutral</term></item>
        /// <item><term>Thread LCID, based on the thread's locale value</term></item>
        /// <item><term>User default LCID, based on the user's default locale value</term></item>
        /// <item><term>System default LCID, based on the system default locale value</term></item>
        /// <item><term>US English</term></item>
        /// </list>
        /// </para>
        /// <para>
        /// If <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, StringBuilder, int, IntPtr)"/> does not locate a message for any of the preceding LCIDs,
        /// it returns any language message string that is present. If that fails, it returns <see cref="ERROR_RESOURCE_LANG_NOT_FOUND"/>. 
        /// </para>
        /// </param>
        /// <param name="lpBuffer">
        /// Receives a buffer to the null-terminated string that specifies the formatted message. <strong>ONLY</strong> use this overload if <see cref="FORMAT_MESSAGE_ALLOCATE_BUFFER"/> is included in <paramref name="dwFlags"/>.
        /// <para>The function allocates a buffer using the <see cref="M:THNETII.WinApiNative.MemoryManagement.MemoryManagementFunctions.LocalAlloc"/> function.</para>
        /// <para>This buffer cannot be larger than 64K bytes.</para>
        /// </param>
        /// <param name="nSize">
        /// <para>Specifies the minimum number of characters to allocate for the output buffer to return in <paramref name="lpBuffer"/>.</para>
        /// <para>The output buffer cannot be larger than 64K bytes.</para>
        /// </param>
        /// <param name="Arguments">
        /// <para>A pointer to an array of values that are used as insert values in the formatted message. A <c>%1</c> in the format string indicates the first value in the Arguments array; a <c>%2</c> indicates the second argument; and so on.</para>
        /// <para>The interpretation of each value depends on the formatting information associated with the insert in the message definition. The default is to treat each value as a pointer to a null-terminated unicode string.</para>
        /// <para><strong>DO NOT</strong> use this parameter if the <see cref="FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag is not set in <paramref name="dwFlags"/>!</para>
        /// <para>The default value of <see cref="IntPtr.Zero"/> can be used to indicate no insert arguments. This should be used when the <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/> flag is set in <paramref name="dwFlags"/></para>
        /// </param>
        /// <returns>
        /// <para>
        /// If the function succeeds, the return value is the number of characters stored in the output buffer, excluding the terminating null character.
        /// </para>
        /// <para>If the function fails, the return value is <c>0</c> (zero). To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// Within the message text, several escape sequences are supported for dynamically formatting the message. These escape sequences and their meanings are shown in the following tables. All escape sequences start with the percent character (%).
        /// <list type="table">
        /// <listheader><term>Escape sequence</term><description>Meaning</description></listheader>
        /// <item><term><c>%0</c></term><description>Terminates a message text line without a trailing new line character. This escape sequence can be used to build up long lines or to terminate the message itself without a trailing new line character. It is useful for prompt messages.</description></item>
        /// <item>
        /// <term><c>%n!<em>format string</em>!</c></term>
        /// <description>
        /// <para>Identifies an insert. The value of <em>n</em> can be in the range from 1 through 99. The format string (which must be surrounded by exclamation marks) is optional and defaults to <c>!s!</c> if not specified. For more information, see <a href="http://go.microsoft.com/fwlink/p/?linkid=83949">Format Specification Fields</a>.</para>
        /// <para>The format string can include a width and precision specifier for strings and a width specifier for integers. Use an asterisk (<c>*</c>) to specify the width and precision. For example, <c>%1!.*s!</c> or <c>%1!*u!</c>.</para>
        /// <para>If you do not use the width and precision specifiers, the insert numbers correspond directly to the input arguments. For example, if the source string is <c>"%1 %2 %1"</c> and the input arguments are <c>"Bill"</c> and <c>"Bob"</c>, the formatted output string is <c>"Bill Bob Bill"</c>.</para>
        /// <para>However, if you use a width and precision specifier, the insert numbers do not correspond directly to the input arguments. For example, the insert numbers for the previous example could change to <c>"%1!*.*s! %4 %5!*s!"</c>.</para>
        /// <para>The next insert number is <c>n + 2</c> if the previous format string contained one asterisk and is <c>n + 3</c> if two asterisks were specified.</para>
        /// <para>If you want to repeat <c>"Bill"</c>, as in the previous example, the arguments must include <c>"Bill"</c> twice. For example, if the source string is <c>"%1!*.*s! %4 %5!*s!"</c>, the arguments could be, <c>4</c>, <c>2</c>, <c>"Bill"</c>, <c>"Bob"</c>, <c>6</c>, <c>"Bill"</c> (if using the <see cref="FORMAT_MESSAGE_FLAGS.FORMAT_MESSAGE_ARGUMENT_ARRAY"/> flag). The formatted string would then be <c>"  Bi Bob   Bill"</c>.</para>
        /// <para>Repeating insert numbers when the source string contains width and precision specifiers may not yield the intended results. If you replaced <c>%5</c> with <c>%1</c>, the function would try to print a string at address 6 (likely resulting in an access violation).</para>
        /// <para>Floating-point format specifiers—<c>e</c>, <c>E</c>, <c>f</c>, and <c>g</c>—are not supported. The workaround is to pre-format floating-point number using the regular <see cref="double.ToString()"/> method and then insert that string.</para>
        /// <para>Inserts that use the <c>I64</c> prefix are treated as two 32-bit arguments.</para>
        /// </description>
        /// </item>
        /// </list>
        /// </para>
        /// <para>
        /// Any other nondigit character following a percent character is formatted in the output message without the percent character. Following are some examples.
        /// <list type="table">
        /// <listheader><term>Format string</term><description>Resulting output</description></listheader>
        /// <item><term><c>%%</c></term><description>A single percent sign.</description></item>
        /// <item><term><c>%<em>space</em></c></term><description>A single space. This format string can be used to ensure the appropriate number of trailing spaces in a message text line.</description></item>
        /// <item><term><c>%.</c></term><description>A single period. This format string can be used to include a single period at the beginning of a line without terminating the message text definition.</description></item>
        /// <item><term><c>%!</c></term><description>A single exclamation point. This format string can be used to include an exclamation point immediately after an insert without its being mistaken for the beginning of a format string.</description></item>
        /// <item><term><c>%n</c></term><description>A hard line break when the format string occurs at the end of a line. This format string is useful when <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, out WideStringPtr, int, IntPtr)"/> is supplying regular line breaks so the message fits in a certain width.</description></item>
        /// <item><term><c>%r</c></term><description>A hard carriage return without a trailing newline character.</description></item>
        /// <item><term><c>%t</c></term><description>A single tab.</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// <strong>Security Remarks</strong><br/>
        /// If this function is called without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>, the <paramref name="Arguments"/> parameter must contain enough parameters to satisfy all insertion sequences in the message string, and they must be of the correct type. Therefore, do not use untrusted or unknown message strings with inserts enabled because they can contain more insertion sequences than <paramref name="Arguments"/> provides, or those that may be of the wrong type. In particular, it is unsafe to take an arbitrary system error code returned from an API and use <see cref="FORMAT_MESSAGE_FROM_SYSTEM"/> without <see cref="FORMAT_MESSAGE_IGNORE_INSERTS"/>. 
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/nf-winuser-formatmessagew">FormatMessageW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(FormatMessage) + "W", SetLastError = true)]
        public static extern int FormatMessage(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            [MarshalAs(UnmanagedType.LPWStr)] string lpSource,
            int dwMessageId,
            int dwLanguageId,
            out WideStringPtr lpBuffer,
            int nSize,
            IntPtr Arguments
            );
        #endregion
        #region GetErrorMode function
        /// <summary>
        /// Retrieves the error mode for the current process.
        /// </summary>
        /// <returns>The process error mode.</returns>
        /// <remarks>
        /// <para>Each process has an associated error mode that indicates to the system how the application is going to respond to serious errors. A child process inherits the error mode of its parent process.</para>
        /// <para>To change the error mode for the process, use the <see cref="SetErrorMode"/> function.</para>
        /// <para>
        /// <strong>Windows 7:</strong><br/>
        /// Callers should favor <see cref="SetThreadErrorMode"/> over <see cref="SetErrorMode"/> since it is less disruptive to the normal behavior of the system. <see cref="GetThreadErrorMode"/> is the call function that corresponds to <see cref="GetErrorMode"/>.
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows Vista [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2008 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/ms679355.aspx">GetErrorMode function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SetErrorMode"/>
        /// <seealso cref="GetThreadErrorMode"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern SystemErrorMode GetErrorMode();
        #endregion
        #region GetLastError function
        /// <summary>
        /// Retrieves the calling thread's last-error code value. The last-error code is maintained on a per-thread basis. Multiple threads do not overwrite each other's last-error code.
        /// </summary>
        /// <returns>
        /// <para>The return value is the calling thread's last-error code.</para>
        /// <para>The Return Value section of the documentation for each function that sets the last-error code notes the conditions under which the function sets the last-error code. Most functions that set the thread's last-error code set it when they fail. However, some functions also set the last-error code when they succeed. If the function is not documented to set the last-error code, the value returned by this function is simply the most recent last-error code to have been set; some functions set the last-error code to <c>0</c> (zero) on success and others do not.</para>
        /// </returns>
        /// <remarks>
        /// <para>Functions executed by the calling thread set this value by calling the <see cref="SetLastError"/> function. You should call the <see cref="GetLastError"/> function immediately when a function's return value indicates that such a call will return useful data. That is because some functions call <see cref="SetLastError"/> with a zero when they succeed, wiping out the error code set by the most recently failed function.</para>
        /// <para>To obtain an error string for system error codes, use the <see cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, StringBuilder, int, IntPtr)"/> function. For a complete list of error codes provided by the operating system, see <a href="https://msdn.microsoft.com/en-us/library/ms681381.aspx">System Error Codes</a>.</para>
        /// <para>The error codes returned by a function are not part of the Windows API specification and can vary by operating system or device driver. For this reason, we cannot provide the complete list of error codes that can be returned by each function. There are also many functions whose documentation does not include even a partial list of error codes that can be returned.</para>
        /// <para>Error codes are 32-bit values (bit 31 is the most significant bit). Bit 29 is reserved for application-defined error codes; no system error code has this bit set. If you are defining an error code for your application, set this bit to one. That indicates that the error code has been defined by an application, and ensures that your error code does not conflict with any error codes defined by the system.</para>
        /// <para>To convert a system error into an <see cref="T:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT"/> value, use the <see cref="M:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT.FromWin32(System.Int32)"/> function.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported phone:</strong></term><description>Windows Phone 8</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/ms679360.aspx">GetLastError function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, StringBuilder, int, IntPtr)"/>
        /// <seealso cref="M:THNETII.WindowsProtocols.WindowsErrorCodes.HRESULT.FromWin32(System.Int32)"/>
        /// <seealso cref="SetLastError"/>
        /// <seealso cref="SetLastErrorEx"/>
        [Obsolete(".NET Applications should not call " + nameof(GetLastError) + ". Instead the static System.Runtime.InteropServices.Marshal.GetLastWin32Error() method should be used.")]
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetLastError();
        #endregion
        #region GetThreadErrorMode function
        /// <summary>
        /// Retrieves the error mode for the calling thread.
        /// </summary>
        /// <returns>The process error mode for the calling thread.</returns>
        /// <remarks>
        /// A thread inherits the error mode of the process in which it is running. To change the error mode for the thread, use the <see cref="SetThreadErrorMode"/> function. 
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 7 [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2008 R2 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/Dd553629.aspx">GetThreadErrorMode function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetErrorMode"/>
        /// <seealso cref="SetThreadErrorMode"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern SystemErrorMode GetThreadErrorMode();
        #endregion
    }
}
