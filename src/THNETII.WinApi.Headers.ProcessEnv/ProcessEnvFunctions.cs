using System;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.WinApi.Helpers;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.ProcessEnv
{
    using static NativeLibraryNames;
    using static StringMarshal;

    public static class ProcessEnvFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 29
        #region SetEnvironmentStrings function
        /// <summary>
        /// Sets the environment strings of the calling process (both the system and the user environment variables) for the current process.
        /// </summary>
        /// <param name="NewEnvironment">
        /// The environment variable string using the following format:
        /// <code>Var1 Value1 Var2 Value2 Var3 Value3 VarN ValueN</code>
        /// </param>
        /// <returns>Returns <see langword="true"/> on success.</returns>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-setenvironmentstringsw">SetEnvironmentStringsW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentStringsW(
            [In] LPWSTR NewEnvironment
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 36
        #region SetEnvironmentStrings function
        /// <inheritdoc cref="SetEnvironmentStringsW" />
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSetAuto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentStrings(
            [In, MarshalAs(LPTSTR)] string NewEnvironment
            ); 
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 46
        #region GetStdHandle function
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr GetStdHandle(
            [In] int nStdHandle
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 54
        #region SetStdHandle function
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetStdHandle(
            [In] int nStdHandle,
            [In] IntPtr hHandle
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 65
        #region SetStdHandleEx function
        /// <summary>
        /// Sets the handle for the input, output, or error streams.
        /// </summary>
        /// <param name="nStdHandle">An integer indicating the stream for which the handle is being set.</param>
        /// <param name="hHandle">The handle.</param>
        /// <param name="phPrevValue">Receives the previous handle.</param>
        /// <returns>Returns <see langword="true"/> on success.</returns>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-setstdhandleex">SetStdHandleEx function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetStdHandleEx(
            [In] int nStdHandle,
            [In] IntPtr hHandle,
            out IntPtr phPrevValue
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 83
        #region GetCommandLineA function
        /// <summary>
        /// Retrieves the command-line string for the current process.
        /// </summary>
        /// <returns>The command-line string for the current process.</returns>
        /// <remarks>
        /// <para>To convert the command line to an argv style array of strings, call the <see cref="CommandLineToArgv"/> function.</para>
        /// <para>
        /// <note>The name of the executable in the command line that the operating system provides to a process is not necessarily identical to that in the command line that the calling process gives to the <see cref="CreateProcess"/> function. The operating system may prepend a fully qualified path to an executable name that is provided without a fully qualified path.</note>
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-getcommandlinea">GetCommandLineA function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CreateProcess"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/process-and-thread-functions">Process and Thread Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern LPCSTR GetCommandLineA(
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 90
        #region GetCommandLineW function
        /// <summary>
        /// Retrieves the command-line string for the current process.
        /// </summary>
        /// <returns>The command-line string for the current process.</returns>
        /// <remarks>
        /// <para>To convert the command line to an argv style array of strings, call the <see cref="CommandLineToArgv"/> function.</para>
        /// <para>
        /// <note>The name of the executable in the command line that the operating system provides to a process is not necessarily identical to that in the command line that the calling process gives to the <see cref="CreateProcess"/> function. The operating system may prepend a fully qualified path to an executable name that is provided without a fully qualified path.</note>
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-getcommandlinew">GetCommandLineW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CreateProcess"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/process-and-thread-functions">Process and Thread Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern LPCWSTR GetCommandLineW(
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 97
        #region GetCommandLine function
#if NETSTANDARD2_0
        [Obsolete("Use the " + nameof(System) + "." + nameof(Environment) + "." + nameof(Environment.CommandLine) + " property instead.")]
#endif
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSetAuto)]
        [return: MarshalAs(LPTSTR)]
        public static extern string GetCommandLine();
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 103
        #region GetEnvironmentStrings function
        /// <summary>
        /// Retrieves the environment variables for the current process.
        /// </summary>
        /// <returns>
        /// <para>If the function succeeds, the return value is a pointer to the environment block of the current process.</para>
        /// <para>If the function fails, the return value is <see cref="IntPtr.Zero"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// The <see cref="GetEnvironmentStrings"/> function returns a pointer to a block of memory that contains the environment variables of the calling process (both the system and the user environment variables). Each environment block contains the environment variables in the following format:
        /// <code>Var1 Value1 Var2 Value2 Var3 Value3 VarN ValueN</code>
        /// Treat this memory as read-only; do not modify it directly. To add or change an environment variable, use the <see cref="GetEnvironmentVariable"/> and <see cref="SetEnvironmentVariable"/> functions.
        /// </para>
        /// <para>When the block returned by <see cref="GetEnvironmentStrings"/> is no longer needed, it should be freed by calling the <see cref="FreeEnvironmentStrings"/> function.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-getenvironmentstrings">GetEnvironmentStrings function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/environment-variables">Environment Variables</seealso>
        /// <seealso cref="FreeEnvironmentStrings"/>
        /// <seealso cref="GetEnvironmentVariable"/>
        /// <seealso cref="SetEnvironmentVariable"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSetAuto)]
        public static extern LPENVBLOCK GetEnvironmentStrings(
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 112
        #region GetEnvironmentStringsW function
        /// <summary>
        /// Retrieves the environment variables for the current process.
        /// </summary>
        /// <returns>
        /// <para>If the function succeeds, the return value is a pointer to the environment block of the current process.</para>
        /// <para>If the function fails, the return value is <see cref="IntPtr.Zero"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// The <see cref="GetEnvironmentStringsW"/> function returns a pointer to a block of memory that contains the environment variables of the calling process (both the system and the user environment variables). Each environment block contains the environment variables in the following format:
        /// <code>Var1 Value1 Var2 Value2 Var3 Value3 VarN ValueN</code>
        /// Treat this memory as read-only; do not modify it directly. To add or change an environment variable, use the <see cref="GetEnvironmentVariableW"/> and <see cref="SetEnvironmentVariableW"/> functions.
        /// </para>
        /// <para>When the block returned by <see cref="GetEnvironmentStringsW"/> is no longer needed, it should be freed by calling the <see cref="FreeEnvironmentStringsW"/> function.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-getenvironmentstringsw">GetEnvironmentStringsW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/environment-variables">Environment Variables</seealso>
        /// <seealso cref="FreeEnvironmentStringsW"/>
        /// <seealso cref="GetEnvironmentVariableW"/>
        /// <seealso cref="SetEnvironmentVariableW"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern LPENVBLOCKW GetEnvironmentStringsW(
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 124
        #region GetEnvironmentStringsA function
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern LPENVBLOCKA GetEnvironmentStringsA(
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 127
        #region FreeEnvironmentStringsA function
        /// <summary>
        /// Frees a block of environment strings.
        /// </summary>
        /// <param name="penv">TBD</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-freeenvironmentstringsa">FreeEnvironmentStringsA function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/environment-variables">Environment Variables</seealso>
        /// <seealso cref="GetEnvironmentStringsA"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeEnvironmentStringsA(
            [In] LPENVBLOCKA penv
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 134
        #region FreeEnvironmentStringsW function
        /// <summary>
        /// Frees a block of environment strings.
        /// </summary>
        /// <param name="penv">TBD</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-freeenvironmentstringsw">FreeEnvironmentStringsW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/environment-variables">Environment Variables</seealso>
        /// <seealso cref="GetEnvironmentStringsW"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeEnvironmentStringsW(
            [In] LPENVBLOCKW penv
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 141
        #region FreeEnvironmentStrings function
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSetAuto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeEnvironmentStrings(
            [In] LPENVBLOCK penv
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 147
        #region GetEnvironmentVariableA function
        // Not declared, use System.Environment.GetEnvironmentVariable method.
        // Microsoft Docs page: https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-getenvironmentvariablea
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 157
        #region GetEnvironmentVariableW function
        // Not declared, use System.Environment.GetEnvironmentVariable method. 
        // Microsoft Docs page: https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-getenvironmentvariablew
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 167
        #region GetEnvironmentVariable function
        // Not declared, use System.Environment.GetEnvironmentVariable method. 
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 173
        #region SetEnvironmentVariableA function
        // Not declared, use System.Environment.SetEnvironmentVariable method.
        // Microsoft Docs page: https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-setenvironmentvariablea
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 181
        #region SetEnvironmentVariableW function
        // Not declared, use System.Environment.SetEnvironmentVariable method. 
        // Microsoft Docs page: https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-setenvironmentvariablew
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 189
        #region SetEnvironmentVariable function
        // Not declared, use System.Environment.SetEnvironmentVariable method. 
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 195
        #region ExpandEnvironmentStringsA function
        // Not declared, use System.Environment.ExpandEnvironmentVariables method. 
        // Microsoft Docs page: https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-expandenvironmentstringsa
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 205
        #region ExpandEnvironmentStringsA function
        // Not declared, use System.Environment.ExpandEnvironmentVariables method. 
        // Microsoft Docs page: https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-expandenvironmentstringsw
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 215
        #region ExpandEnvironmentStringsA function
        // Not declared, use System.Environment.ExpandEnvironmentVariables method. 
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 221
        #region SetCurrentDirectoryA function
        // Not declared, use System.Environment.CurrentDirectory property. 
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 228
        #region SetCurrentDirectoryW function
        // Not declared, use System.Environment.CurrentDirectory property. 
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 235
        #region SetCurrentDirectory function
        // Not declared, use System.Environment.CurrentDirectory property. 
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 241
        #region GetCurrentDirectoryA function
        // Not declared, use System.Environment.CurrentDirectory property. 
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 250
        #region GetCurrentDirectoryW function
        // Not declared, use System.Environment.CurrentDirectory property. 
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 259
        #region GetCurrentDirectory function
        // Not declared, use System.Environment.CurrentDirectory property. 
        #endregion
        #region SearchPathW function
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern int SearchPathW(
            [In, Optional] LPCWSTR lpPath,
            [In] LPCWSTR lpFileName,
            [In, Optional] LPCWSTR lpExtension,
            [In] int nBufferLength,
            [In, Optional] LPWSTR lpBuffer,
            [Optional] out LPWSTR lpFilePart
            );
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        private static extern int SearchPathW(
            [In, Optional] LPCWSTR lpPath,
            [In] LPCWSTR lpFileName,
            [In, Optional] LPCWSTR lpExtension,
            [In] int nBufferLength,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer,
            [Optional] out LPWSTR lpFilePart
            );
        #endregion
    }
}
