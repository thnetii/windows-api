using System;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.InteropServices.NativeMemory.Specialized;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.WinBase
{
    using static CallingConvention;
    using static FORMAT_MESSAGE_FLAGS;
    using static WinError.WinErrorConstants;

    public static class WinBaseFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 116
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
        public static ushort CaptureStackBackTrace(
            int FramesToSkip,
            int FramesToCapture,
            out ArrayOfIntPtr BackTrace,
            out int BackTraceHash
            ) => WinNT.WinNTFunctions.RtlCaptureStackBackTrace(FramesToSkip, FramesToCapture, out BackTrace, out BackTraceHash);
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 1350
        #region FatalExit function
        /// <summary>
        /// Transfers execution control to the debugger. The behavior of the debugger thereafter is specific to the type of debugger used.
        /// </summary>
        /// <param name="ExitCode">The error code associated with the exit.</param>
        /// <remarks>
        /// An application should only use <see cref="FatalExit"/> for debugging purposes. It should not call the function in a retail version of the application because doing so will terminate the application.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winbase/nf-winbase-fatalexit">FatalExit function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="M:THNETII.WinApi.Native.ErrHandlingApi.ErrHandlingApiFunctions.FatalAppExit(System.Int32,System.String)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi)]
        public static extern void FatalExit(
            int ExitCode
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinBase.h, line 2382
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
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/WinBase/nf-winbase-formatmessagew">FormatMessageW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        public static int FormatMessage(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            StringBuilder lpBuffer,
            int nSize,
            IntPtr Arguments
            ) => FormatMessageW(dwFlags, lpSource, dwMessageId, dwLanguageId, lpBuffer, nSize, Arguments);
        /// <inheritdoc cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, StringBuilder, int, IntPtr)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, EntryPoint = nameof(FormatMessageA), SetLastError = true)]
        public static extern int FormatMessageA(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer,
            int nSize,
            IntPtr Arguments
            );
        /// <inheritdoc cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, StringBuilder, int, IntPtr)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, EntryPoint = nameof(FormatMessageW), SetLastError = true)]
        public static extern int FormatMessageW(
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
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/WinBase/nf-winbase-formatmessagew">FormatMessageW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        public static int FormatMessage(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            string lpSource,
            int dwMessageId,
            int dwLanguageId,
            StringBuilder lpBuffer,
            int nSize,
            IntPtr Arguments
            ) => FormatMessageW(dwFlags, lpSource, dwMessageId, dwLanguageId, lpBuffer, nSize, Arguments);
        /// <inheritdoc cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, StringBuilder, int, IntPtr)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, EntryPoint = nameof(FormatMessageA), SetLastError = true)]
        public static extern int FormatMessageA(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            [MarshalAs(UnmanagedType.LPStr)] string lpSource,
            int dwMessageId,
            int dwLanguageId,
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer,
            int nSize,
            IntPtr Arguments
            );
        /// <inheritdoc cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, StringBuilder, int, IntPtr)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, EntryPoint = nameof(FormatMessageW), SetLastError = true)]
        public static extern int FormatMessageW(
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
        /// <para>The function allocates a buffer using the <see cref="LocalAlloc"/> function.</para>
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
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/WinBase/nf-winbase-formatmessagew">FormatMessageW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        public static int FormatMessage(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            out WideStringPtr lpBuffer,
            int nSize,
            IntPtr Arguments
            ) => FormatMessageW(dwFlags, lpSource, dwMessageId, dwLanguageId, out lpBuffer, nSize, Arguments);
        ///// <inheritdoc cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, out WideStringPtr, int, IntPtr)"/>
        //[DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, EntryPoint = nameof(FormatMessageA), SetLastError = true)]
        //public static extern int FormatMessageA(
        //    FORMAT_MESSAGE_OPTIONS dwFlags,
        //    IntPtr lpSource,
        //    int dwMessageId,
        //    int dwLanguageId,
        //    out AnsiStringPtr lpBuffer,
        //    int nSize,
        //    IntPtr Arguments
        //    );
        /// <inheritdoc cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, IntPtr, int, int, out WideStringPtr, int, IntPtr)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, EntryPoint = nameof(FormatMessageW), SetLastError = true)]
        public static extern int FormatMessageW(
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
        /// <para>The function allocates a buffer using the <see cref="LocalAlloc"/> function.</para>
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
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/WinBase/nf-winbase-formatmessagew">FormatMessageW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        public static int FormatMessage(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            string lpSource,
            int dwMessageId,
            int dwLanguageId,
            out WideStringPtr lpBuffer,
            int nSize,
            IntPtr Arguments
            ) => FormatMessageW(dwFlags, lpSource, dwMessageId, dwLanguageId, out lpBuffer, nSize, Arguments);
        ///// <inheritdoc cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, out WideStringPtr, int, IntPtr)"/>
        //[DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, EntryPoint = nameof(FormatMessageA), SetLastError = true)]
        //public static extern int FormatMessageA(
        //    FORMAT_MESSAGE_OPTIONS dwFlags,
        //    [MarshalAs(UnmanagedType.LPStr)] string lpSource,
        //    int dwMessageId,
        //    int dwLanguageId,
        //    out AnsiStringPtr lpBuffer,
        //    int nSize,
        //    IntPtr Arguments
        //    );
        /// <inheritdoc cref="FormatMessage(FORMAT_MESSAGE_OPTIONS, string, int, int, out WideStringPtr, int, IntPtr)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, EntryPoint = nameof(FormatMessageW), SetLastError = true)]
        public static extern int FormatMessageW(
            FORMAT_MESSAGE_OPTIONS dwFlags,
            [MarshalAs(UnmanagedType.LPWStr)] string lpSource,
            int dwMessageId,
            int dwLanguageId,
            out WideStringPtr lpBuffer,
            int nSize,
            IntPtr Arguments
            );
        #endregion
    }
}
