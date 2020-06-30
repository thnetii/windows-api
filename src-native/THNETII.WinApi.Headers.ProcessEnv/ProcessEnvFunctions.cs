using System;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.WinApi.Native.WinError;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.ProcessEnv
{
    using static NativeLibraryNames;
    using static WinErrorConstants;

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
#if !NETSTANDARD1_3
        /// <inheritdoc cref="SetEnvironmentStringsW" />
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentStrings(
            [In, MarshalAs(UnmanagedType.LPTStr)] string NewEnvironment
            ); 
#endif // !NETSTANDARD1_3
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
#if !NETSTANDARD1_3
        [Obsolete("Use the " + nameof(System) + "." + nameof(Environment) + "." + nameof(Environment.CommandLine) + " property instead.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.LPTStr)]
        public static extern string GetCommandLine();
#endif // !NETSTANDARD1_3
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
        /// Treat this memory as read-only; do not modify it directly. To add or change an environment variable, use the <see cref="GetEnvironmentVariable(LPCTSTR, LPTSTR, int)"/> and <see cref="SetEnvironmentVariable(LPCTSTR, LPCTSTR)"/> functions.
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
        /// <seealso cref="GetEnvironmentVariable(LPCTSTR, LPTSTR, int)"/>
        /// <seealso cref="SetEnvironmentVariable(LPCTSTR, LPCTSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
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
        /// Treat this memory as read-only; do not modify it directly. To add or change an environment variable, use the <see cref="GetEnvironmentVariableW(LPCWSTR, LPWSTR, int)"/> and <see cref="SetEnvironmentVariableW(LPCWSTR, LPCWSTR)"/> functions.
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
        /// <seealso cref="GetEnvironmentVariableW(LPCWSTR, LPWSTR, int)"/>
        /// <seealso cref="SetEnvironmentVariableW(LPCWSTR, LPCWSTR)"/>
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
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeEnvironmentStrings(
            [In] LPENVBLOCK penv
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 147
        #region GetEnvironmentVariableA function
        /// <inheritdoc cref="GetEnvironmentVariableW(LPCWSTR, LPWSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariableA) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetEnvironmentVariableA(
            [In, Optional] LPCSTR lpName,
            [Optional] LPSTR lpBuffer,
            [In] int nSize
            );

        /// <inheritdoc cref="GetEnvironmentVariableA(LPCSTR, LPSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariableA) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        public static int GetEnvironmentVariableA(
            LPCSTR lpName,
            StringBuilder lpBuffer
            ) =>
            GetEnvironmentVariableA(lpName, lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetEnvironmentVariableA(LPCSTR, LPSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariableA) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetEnvironmentVariableA(
            [In, Optional] LPCSTR lpName,
            [Out, MarshalAs(UnmanagedType.LPStr), Optional] StringBuilder lpBuffer,
            [In] int nSize
            );

        /// <inheritdoc cref="GetEnvironmentVariableA(LPCSTR, LPSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariableA) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        public static int GetEnvironmentVariableA(
            string lpName,
            StringBuilder lpBuffer
            ) =>
            GetEnvironmentVariableA(lpName, lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetEnvironmentVariableA(LPCSTR, LPSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariableA) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetEnvironmentVariableA(
            [In, Optional, MarshalAs(UnmanagedType.LPStr)] string lpName,
            [Out, MarshalAs(UnmanagedType.LPStr), Optional] StringBuilder lpBuffer,
            [In] int nSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 157
        #region GetEnvironmentVariableW function
        /// <summary>
        /// Retrieves the contents of the specified variable from the environment block of the calling process.
        /// </summary>
        /// <param name="lpName">The name of the environment variable.</param>
        /// <param name="lpBuffer">A buffer that receives the contents of the specified environment variable as a null-terminated string. An environment variable has a maximum size limit of 32,767 characters, including the null-terminating character.</param>
        /// <param name="nSize">The size of the buffer pointed to by the <paramref name="lpBuffer"/> parameter, including the null-terminating character, in characters.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is the number of characters stored in the buffer pointed to by <paramref name="lpBuffer"/>, not including the terminating null character.</para>
        /// <para>If <paramref name="lpBuffer"/> is not large enough to hold the data, the return value is the buffer size, in characters, required to hold the string and its terminating null character and the contents of <paramref name="lpBuffer"/> are undefined.</para>
        /// <para>If the function fails, the return value is zero. If the specified environment variable was not found in the environment block, <see cref="GetLastError"/> returns <see cref="ERROR_ENVVAR_NOT_FOUND"/>.</para>
        /// </returns>
        /// <remarks>
        /// This function can retrieve either a system environment variable or a user environment variable.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-getenvironmentvariablew">GetEnvironmentVariableW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/environment-variables">Environment Variables</seealso>
        /// <seealso cref="GetEnvironmentStrings"/>
        /// <seealso cref="SetEnvironmentVariable(LPCTSTR, LPCTSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariableW) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetEnvironmentVariableW(
            [In, Optional] LPCWSTR lpName,
            [Optional] LPWSTR lpBuffer,
            [In] int nSize
            );

        /// <inheritdoc cref="GetEnvironmentVariableW(LPCWSTR, LPWSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariableW) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        public static int GetEnvironmentVariableW(
            LPCWSTR lpName,
            StringBuilder lpBuffer
            ) =>
            GetEnvironmentVariableW(lpName, lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetEnvironmentVariableW(LPCWSTR, LPWSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariableW) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int GetEnvironmentVariableW(
            [In, Optional] LPCWSTR lpName,
            [Out, MarshalAs(UnmanagedType.LPWStr), Optional] StringBuilder lpBuffer,
            [In] int nSize
            );

        /// <inheritdoc cref="GetEnvironmentVariableW(LPCWSTR, LPWSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariableW) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        public static int GetEnvironmentVariableW(
            string lpName,
            StringBuilder lpBuffer
            ) =>
            GetEnvironmentVariableW(lpName, lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetEnvironmentVariableW(LPCWSTR, LPWSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariableW) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int GetEnvironmentVariableW(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string lpName,
            [Out, MarshalAs(UnmanagedType.LPWStr), Optional] StringBuilder lpBuffer,
            [In] int nSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 167
        #region GetEnvironmentVariable function
        /// <inheritdoc cref="GetEnvironmentVariableW(LPCWSTR, LPWSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariable) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetEnvironmentVariable(
            [In, Optional] LPCTSTR lpName,
            [Optional] LPTSTR lpBuffer,
            [In] int nSize
            );
#if !NETSTANDARD1_3

        /// <inheritdoc cref="GetEnvironmentVariable(LPCTSTR, LPTSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariable) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        public static int GetEnvironmentVariable(
            LPCTSTR lpName,
            StringBuilder lpBuffer
            ) =>
            GetEnvironmentVariable(lpName, lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetEnvironmentVariable(LPCTSTR, LPTSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariable) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetEnvironmentVariable(
            [In, Optional] LPCTSTR lpName,
            [Out, MarshalAs(UnmanagedType.LPTStr), Optional] StringBuilder lpBuffer,
            [In] int nSize
            );

        /// <inheritdoc cref="GetEnvironmentVariable(LPCTSTR, LPTSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariable) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        public static int GetEnvironmentVariable(
            string lpName,
            StringBuilder lpBuffer
            ) =>
            GetEnvironmentVariable(lpName, lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetEnvironmentVariable(LPCTSTR, LPTSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetEnvironmentVariable) + ". Instead the static System.Environment.GetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetEnvironmentVariable(
            [In, Optional, MarshalAs(UnmanagedType.LPTStr)] string lpName,
            [Out, MarshalAs(UnmanagedType.LPTStr), Optional] StringBuilder lpBuffer,
            [In] int nSize
            );
#endif
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 173
        #region SetEnvironmentVariableA function
        /// <inheritdoc cref="SetEnvironmentVariableW(LPCWSTR, LPCWSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetEnvironmentVariableA) + ". Instead the static System.Environment.SetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariableA(
            [In] LPCSTR lpName,
            [In, Optional] LPCSTR lpValue
            );

        /// <inheritdoc cref="SetEnvironmentVariableA(LPCSTR, LPCSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetEnvironmentVariableA) + ". Instead the static System.Environment.SetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariableA(
            [In, MarshalAs(UnmanagedType.LPStr)] string lpName,
            [In, Optional, MarshalAs(UnmanagedType.LPStr)] string lpValue
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 181
        #region SetEnvironmentVariableW function
        /// <summary>
        /// Sets the contents of the specified environment variable for the current process.
        /// </summary>
        /// <param name="lpName">The name of the environment variable. The operating system creates the environment variable if it does not exist and <paramref name="lpValue"/> is not <see langword="null"/>.</param>
        /// <param name="lpValue">
        /// <para>The contents of the environment variable. The maximum size of a user-defined environment variable is 32,767 characters. For more information, see <a href="Environment Variables">Environment Variables</a>.</para>
        /// <para><strong>Windows Server 2003 and Windows XP</strong>: The total size of the environment block for a process may not exceed 32,767 characters.</para>
        /// <para>If this parameter is <see langword="null"/>, the variable is deleted from the current process's environment.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// This function has no effect on the system environment variables or the environment variables of other processes.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-setenvironmentvariablew">SetEnvironmentVariableW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/environment-variables">Environment Variables</seealso>
        /// <seealso cref="GetEnvironmentVariable(LPCTSTR, LPTSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetEnvironmentVariableW) + ". Instead the static System.Environment.SetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariableW(
            [In] LPCWSTR lpName,
            [In, Optional] LPCWSTR lpValue
            );

        /// <inheritdoc cref="SetEnvironmentVariableW(LPCWSTR, LPCWSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetEnvironmentVariableW) + ". Instead the static System.Environment.SetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariableW(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpName,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string lpValue
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 189
        #region SetEnvironmentVariable function
        /// <inheritdoc cref="SetEnvironmentVariableW(LPCWSTR, LPCWSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetEnvironmentVariable) + ". Instead the static System.Environment.SetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariable(
            [In] LPCTSTR lpName,
            [In, Optional] LPCTSTR lpValue
            );
#if !NETSTANDARD1_3
        /// <inheritdoc cref="SetEnvironmentVariable(LPCTSTR, LPCTSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetEnvironmentVariable) + ". Instead the static System.Environment.SetEnvironmentVariable method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariable(
            [In, MarshalAs(UnmanagedType.LPTStr)] string lpName,
            [In, Optional, MarshalAs(UnmanagedType.LPTStr)] string lpValue
            );
#endif
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 195
        #region ExpandEnvironmentStringsA function
        /// <inheritdoc cref="ExpandEnvironmentStringsW(LPCWSTR, LPWSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(ExpandEnvironmentStrings) + ". Instead the static System.Environment.ExpandEnvironmentVariables method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int ExpandEnvironmentStringsA(
            [In] LPCSTR lpSrc,
            [Optional] LPSTR lpDst,
            [In] int nSize
            );

        /// <inheritdoc cref="ExpandEnvironmentStringsA(LPCSTR, LPSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(ExpandEnvironmentStrings) + ". Instead the static System.Environment.ExpandEnvironmentVariables method should be used.")]
        public static int ExpandEnvironmentStringsA(
            string lpSrc,
            StringBuilder lpDst
            ) =>
            ExpandEnvironmentStringsA(lpSrc, lpDst, lpDst?.Capacity ?? 0);

        /// <inheritdoc cref="ExpandEnvironmentStringsA(LPCSTR, LPSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(ExpandEnvironmentStrings) + ". Instead the static System.Environment.ExpandEnvironmentVariables method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int ExpandEnvironmentStringsA(
            [In, MarshalAs(UnmanagedType.LPStr)] string lpSrc,
            [Out, Optional, MarshalAs(UnmanagedType.LPStr)] StringBuilder lpDst,
            [In] int nSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 205
        #region ExpandEnvironmentStringsW function
        /// <summary>
        /// Expands environment-variable strings and replaces them with the values defined for the current user.
        /// <para>To specify the environment block for a particular user or the system, use the <see cref="ExpandEnvironmentStringsForUser"/> function.</para>
        /// </summary>
        /// <param name="lpSrc">
        /// <para>A buffer that contains one or more environment-variable strings in the form: <em>%variableName%</em>. For each such reference, the <em>%variableName%</em> portion is replaced with the current value of that environment variable.</para>
        /// <para>Case is ignored when looking up the environment-variable name. If the name is not found, the <em>%variableName%</em> portion is left unexpanded.</para>
        /// <para>Note that this function does not support all the features that Cmd.exe supports. For example, it does not support <em>%variableName:str1=str2%</em> or <em>%variableName:~offset,length%</em>.</para>
        /// </param>
        /// <param name="lpDst">A buffer that receives the result of expanding the environment variable strings in the <paramref name="lpSrc"/> buffer. Note that this buffer cannot be the same as the <paramref name="lpSrc"/> buffer.</param>
        /// <param name="nSize">The maximum number of characters that can be stored in the buffer pointed to by the <paramref name="lpDst"/> parameter, including the terminating null-character.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is the number of characters stored in the destination buffer, including the terminating null character. If the destination buffer is too small to hold the expanded string, the return value is the required buffer size, in characters.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The size of the <paramref name="lpSrc"/> and <paramref name="lpDst"/> buffers is limited to 32K.</para>
        /// <para>To replace folder names in a fully qualified path with their associated environment-variable strings, use the <see cref="PathUnExpandEnvStrings"/> function.</para>
        /// <para>To retrieve the list of environment variables for a process, use the <see cref="GetEnvironmentStrings"/> function.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-expandenvironmentstringsw">ExpandEnvironmentStringsW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/environment-variables">Environment Variables</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-information-functions">System Information Functions</seealso>
        [Obsolete(".NET Applications should not call " + nameof(ExpandEnvironmentStrings) + ". Instead the static System.Environment.ExpandEnvironmentVariables method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int ExpandEnvironmentStringsW(
            [In] LPCWSTR lpSrc,
            [Optional] LPWSTR lpDst,
            [In] int nSize
            );

        /// <inheritdoc cref="ExpandEnvironmentStringsW(LPCWSTR, LPWSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(ExpandEnvironmentStrings) + ". Instead the static System.Environment.ExpandEnvironmentVariables method should be used.")]
        public static int ExpandEnvironmentStringsW(
            string lpSrc,
            StringBuilder lpDst
            ) =>
            ExpandEnvironmentStringsW(lpSrc, lpDst, lpDst?.Capacity ?? 0);

        /// <inheritdoc cref="ExpandEnvironmentStringsW(LPCWSTR, LPWSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(ExpandEnvironmentStrings) + ". Instead the static System.Environment.ExpandEnvironmentVariables method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int ExpandEnvironmentStringsW(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpSrc,
            [Out, Optional, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpDst,
            [In] int nSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 215
        #region ExpandEnvironmentStrings function
        /// <inheritdoc cref="ExpandEnvironmentStringsW(LPCWSTR, LPWSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(ExpandEnvironmentStrings) + ". Instead the static System.Environment.ExpandEnvironmentVariables method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int ExpandEnvironmentStrings(
            [In] LPCTSTR lpSrc,
            [Optional] LPTSTR lpDst,
            [In] int nSize
            );

#if !NETSTANDARD1_3
        /// <inheritdoc cref="ExpandEnvironmentStrings(LPCTSTR, LPTSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(ExpandEnvironmentStrings) + ". Instead the static System.Environment.ExpandEnvironmentVariables method should be used.")]
        public static int ExpandEnvironmentStrings(
            string lpSrc,
            StringBuilder lpDst
            ) =>
            ExpandEnvironmentStrings(lpSrc, lpDst, lpDst?.Capacity ?? 0);

        /// <inheritdoc cref="ExpandEnvironmentStrings(LPCTSTR, LPTSTR, int)"/>
        [Obsolete(".NET Applications should not call " + nameof(ExpandEnvironmentStrings) + ". Instead the static System.Environment.ExpandEnvironmentVariables method should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int ExpandEnvironmentStrings(
            [In, MarshalAs(UnmanagedType.LPTStr)] string lpSrc,
            [Out, Optional, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpDst,
            [In] int nSize
            );
#endif
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 221
        #region SetCurrentDirectoryA function
        /// <inheritdoc cref="SetCurrentDirectoryW(LPWSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectoryA(
            [In] LPSTR lpPathName
            );

        /// <inheritdoc cref="SetCurrentDirectoryA(LPSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectoryA(
            [In, MarshalAs(UnmanagedType.LPStr)] string lpPathName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 228
        #region SetCurrentDirectoryW function
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [Obsolete(".NET Applications should not call " + nameof(SetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectoryW(
            [In] LPWSTR lpPathName
            );

        /// <inheritdoc cref="SetCurrentDirectoryW(LPWSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectoryW(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpPathName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 235
        #region SetCurrentDirectory function
        /// <inheritdoc cref="SetCurrentDirectoryW(LPWSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectory(
            [In] LPTSTR lpPathName
            );

#if !NETSTANDARD1_3
        /// <inheritdoc cref="SetCurrentDirectory(LPTSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(SetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectory(
            [In, MarshalAs(UnmanagedType.LPTStr)] string lpPathName
            );
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 241
        #region GetCurrentDirectoryA function
        /// <inheritdoc cref="GetCurrentDirectoryW(int, LPWSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetCurrentDirectoryA(
            [In] int nBufferLength,
            [Optional] LPSTR lpBuffer
            );

        /// <inheritdoc cref="GetCurrentDirectoryA(int, LPSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        public static int GetCurrentDirectoryA(
            StringBuilder lpBuffer
            ) =>
            GetCurrentDirectoryA(lpBuffer?.Capacity ?? 0, lpBuffer);

        /// <inheritdoc cref="GetCurrentDirectoryA(int, LPSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetCurrentDirectoryA(
            [In] int nBufferLength,
            [Out, Optional, MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 250
        #region GetCurrentDirectoryW function
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [Obsolete(".NET Applications should not call " + nameof(GetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetCurrentDirectoryW(
            [In] int nBufferLength,
            [Optional] LPWSTR lpBuffer
            );

        /// <inheritdoc cref="GetCurrentDirectoryW(int, LPWSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        public static int GetCurrentDirectoryW(
            StringBuilder lpBuffer
            ) =>
            GetCurrentDirectoryW(lpBuffer?.Capacity ?? 0, lpBuffer);

        /// <inheritdoc cref="GetCurrentDirectoryW(int, LPWSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int GetCurrentDirectoryW(
            [In] int nBufferLength,
            [Out, Optional, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 259
        #region GetCurrentDirectory function
        /// <inheritdoc cref="GetCurrentDirectoryW(int, LPWSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern bool GetCurrentDirectory(
            [In] int nBufferLength,
            [Optional] LPTSTR lpBuffer
            );

#if !NETSTANDARD1_3
        /// <inheritdoc cref="GetCurrentDirectory(int, LPTSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        public static int GetCurrentDirectory(
            StringBuilder lpBuffer
            ) =>
            GetCurrentDirectory(lpBuffer?.Capacity ?? 0, lpBuffer);

        /// <inheritdoc cref="GetCurrentDirectory(int, LPTSTR)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetCurrentDirectory) + ". Instead the static System.Environment.CurrentDirectory property should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetCurrentDirectory(
            [In] int nBufferLength,
            [Out, Optional, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer
            );
#endif
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 271
        #region SearchPathW function
        /// <summary>
        /// Searches for a specified file in a specified path.
        /// </summary>
        /// <param name="lpPath">
        /// <para>The path to be searched for the file.</para>
        /// <para>
        /// If this parameter is <see langword="null"/>, the function searches
        /// for a matching file using a registry-dependent system search path.
        /// For more information, see the Remarks section.
        /// </para>
        /// </param>
        /// <param name="lpFileName">The name of the file for which to search.</param>
        /// <param name="lpExtension">
        /// <para>The extension to be added to the file name when searching for the file. The first character of the file name extension must be a period (.). The extension is added only if the specified file name does not end with an extension.</para>
        /// <para>If a file name extension is not required or if the file name contains an extension, this parameter can be <see langword="null"/>.</para>
        /// </param>
        /// <param name="nBufferLength">
        /// The size of the buffer that receives the valid path and file name (including the terminating null character), in <see cref="char"/>s.
        /// </param>
        /// <param name="lpBuffer">A writable buffer to receive the path and file name of the file found.</param>
        /// <param name="lpFilePart">Receives the address (within <paramref name="lpBuffer"/>) of the last component of the valid path and file name, which is the address of the character immediately following the final backslash in the path.</param>
        /// <returns>
        /// If the function succeeds, the value returned is the length, in <see cref="char"/>s, of the string that is copied to the buffer, not including the terminating null character. If the return value is greater than <paramref name="nBufferLength"/>, the value returned is the size of the buffer that is required to hold the path, including the terminating null character.
        /// <para>If the function fails, the return value is <c>0</c> (zero). To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// If the <paramref name="lpPath"/> parameter is <see langword="null"/>, <see cref="SearchPathW(LPCWSTR, LPCWSTR, LPCWSTR, int, LPWSTR, out LPWSTR)"/> searches for a matching file based on the current value of the following registry value:
        /// <code>HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\SafeProcessSearchMode</code>
        /// When the value of this <strong>REG_DWORD</strong> registry value is set to 1, <see cref="SearchPathW(LPCWSTR, LPCWSTR, LPCWSTR, int, LPWSTR, out LPWSTR)"/> first searches the folders that are specified in the system path, and then searches the current working folder. When the value of this registry value is set to <c>0</c> (zero), the computer first searches the current working folder, and then searches the folders that are specified in the system path. The system default value for this registry key is <c>0</c> (zero).
        /// </para>
        /// <para>The search mode used by the <see cref="SearchPathW(LPCWSTR, LPCWSTR, LPCWSTR, int, LPWSTR, out LPWSTR)"/> function can also be set per-process by calling the <see cref="SetSearchPathMode"/> function.</para>
        /// <para>The <see cref="SearchPathW(LPCWSTR, LPCWSTR, LPCWSTR, int, LPWSTR, out LPWSTR)"/> function is not recommended as a method of locating a .dll file if the intended use of the output is in a call to the <see cref="LoadLibrary"/> function. This can result in locating the wrong .dll file because the search order of the <see cref="SearchPathW(LPCWSTR, LPCWSTR, LPCWSTR, int, LPWSTR, out LPWSTR)"/> function differs from the search order used by the <see cref="LoadLibrary"/> function. If you need to locate and load a .dll file, use the <see cref="LoadLibrary"/> function.</para>
        /// <para>
        /// <note>Starting with Windows 10, version 1607, for the unicode version of this function (<see cref="SearchPathW(LPCWSTR, LPCWSTR, LPCWSTR, int, LPWSTR, out LPWSTR)"/>), you can opt-in to remove the <see cref="MAX_PATH"/> limitation. See the "Maximum Path Length Limitation" section of <a href="https://docs.microsoft.com/windows/desktop/FileIO/naming-a-file">Naming Files, Paths, and Namespaces</a> for details.</note>
        /// </para>
        /// <para>
        /// In Windows 8 and Windows Server 2012, this function is supported by the following technologies.
        /// <list type="table">
        /// <listheader><term>Technology</term><description>Supported</description></listheader>
        /// <item><term>Server Message Block (SMB) 3.0 protocol </term><description>Yes</description></item>
        /// <item><term>SMB 3.0 Transparent Failover (TFO) </term><description>Yes</description></item>
        /// <item><term>SMB 3.0 with Scale-out File Shares (SO) </term><description>Yes</description></item>
        /// <item><term>Cluster Shared Volume File System (CsvFS) </term><description>Yes</description></item>
        /// <item><term>Resilient File System (ReFS) </term><description>Yes</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-searchpathw">SearchPathW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/FileIO/file-management-functions">File Management Functions</seealso>
        /// <seealso cref="FindFirstFile"/>
        /// <seealso cref="FindNextFile"/>
        /// <seealso cref="GetSystemDirectory"/>
        /// <seealso cref="GetWindowsDirectory"/>
        /// <seealso cref="SetSearchPathMode"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern int SearchPathW(
            [In, Optional] LPCWSTR lpPath,
            [In] LPCWSTR lpFileName,
            [In, Optional] LPCWSTR lpExtension,
            [In] int nBufferLength,
            [In, Optional] LPWSTR lpBuffer,
            [Optional] out LPWSTR lpFilePart
            );
        /// <inheritdoc cref="SearchPathW(LPCWSTR, LPCWSTR, LPCWSTR, int, LPWSTR, out LPWSTR)"/>
        public static int SearchPathW(
            [In, Optional] LPCWSTR lpPath,
            [In] LPCWSTR lpFileName,
            [In, Optional] LPCWSTR lpExtension,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer,
            [Optional] out LPCWSTR lpFilePart
            ) =>
            SearchPathW(
                lpPath,
                lpFileName,
                lpExtension,
                lpBuffer?.Capacity ?? 0,
                lpBuffer,
                out lpFilePart);
        /// <inheritdoc cref="SearchPathW(LPCWSTR, LPCWSTR, LPCWSTR, int, LPWSTR, out LPWSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        private static extern int SearchPathW(
            [In, Optional] LPCWSTR lpPath,
            [In] LPCWSTR lpFileName,
            [In, Optional] LPCWSTR lpExtension,
            [In] int nBufferLength,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer,
            [Optional] out LPCWSTR lpFilePart
            );
        /// <inheritdoc cref="SearchPathW(LPCWSTR, LPCWSTR, LPCWSTR, int, LPWSTR, out LPWSTR)"/>
        public static int SearchPathW(
            [In, MarshalAs(UnmanagedType.LPWStr), Optional] string lpPath,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
            [In, MarshalAs(UnmanagedType.LPWStr), Optional] string lpExtension,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer,
            [MarshalAs(UnmanagedType.LPWStr), Optional] out string lpFilePart
            ) =>
            SearchPathW(
                lpPath,
                lpFileName,
                lpExtension,
                lpBuffer?.Capacity ?? 0,
                lpBuffer,
                out lpFilePart
                );
        /// <inheritdoc cref="SearchPathW(LPCWSTR, LPCWSTR, LPCWSTR, int, LPWSTR, out LPWSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        private static extern int SearchPathW(
            [In, MarshalAs(UnmanagedType.LPWStr), Optional] string lpPath,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
            [In, MarshalAs(UnmanagedType.LPWStr), Optional] string lpExtension,
            [In] int nBufferLength,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer,
            [MarshalAs(UnmanagedType.LPWStr), Optional] out string lpFilePart
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 284
        #region SearchPath function
#if !NETSTANDARD1_3
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        public static int SearchPath(
            [In, Optional] string lpPath,
            [In] string lpFileName,
            [In, Optional] string lpExtension,
            [In, Optional] StringBuilder lpBuffer,
            [Optional] out string lpFilePart
            ) =>
            SearchPath(
                lpPath,
                lpFileName,
                lpExtension,
                lpBuffer?.Capacity ?? 0,
                lpBuffer,
                out lpFilePart
                );
        /// <inheritdoc cref="SearchPath(string, string, string, StringBuilder, out string)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        private static extern int SearchPath(
            [In, MarshalAs(UnmanagedType.LPTStr), Optional] string lpPath,
            [In, MarshalAs(UnmanagedType.LPTStr)] string lpFileName,
            [In, MarshalAs(UnmanagedType.LPTStr), Optional] string lpExtension,
            [In] int nBufferLength,
            [In, Optional, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer,
            [MarshalAs(UnmanagedType.LPTStr), Optional] out string lpFilePart
            );
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 290
        #region SearchPathA function
        /// <summary>
        /// Searches for a specified file in a specified path.
        /// </summary>
        /// <param name="lpPath">
        /// <para>The path to be searched for the file.</para>
        /// <para>
        /// If this parameter is <see langword="null"/>, the function searches
        /// for a matching file using a registry-dependent system search path.
        /// For more information, see the Remarks section.
        /// </para>
        /// </param>
        /// <param name="lpFileName">The name of the file for which to search.</param>
        /// <param name="lpExtension">
        /// <para>The extension to be added to the file name when searching for the file. The first character of the file name extension must be a period (.). The extension is added only if the specified file name does not end with an extension.</para>
        /// <para>If a file name extension is not required or if the file name contains an extension, this parameter can be <see langword="null"/>.</para>
        /// </param>
        /// <param name="nBufferLength">
        /// The size of the buffer that receives the valid path and file name (including the terminating null character), in <see cref="byte"/>s.
        /// </param>
        /// <param name="lpBuffer">A writable buffer to receive the path and file name of the file found.</param>
        /// <param name="lpFilePart">Receives the address (within <paramref name="lpBuffer"/>) of the last component of the valid path and file name, which is the address of the character immediately following the final backslash in the path.</param>
        /// <returns>
        /// If the function succeeds, the value returned is the length, in <see cref="byte"/>s, of the string that is copied to the buffer, not including the terminating null character. If the return value is greater than <paramref name="nBufferLength"/>, the value returned is the size of the buffer that is required to hold the path, including the terminating null character.
        /// <para>If the function fails, the return value is <c>0</c> (zero). To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// If the <paramref name="lpPath"/> parameter is <see langword="null"/>, <see cref="SearchPathA(LPCSTR, LPCSTR, LPCSTR, int, LPSTR, out LPSTR)"/> searches for a matching file based on the current value of the following registry value:
        /// <code>HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\SafeProcessSearchMode</code>
        /// When the value of this <strong>REG_DWORD</strong> registry value is set to 1, <see cref="SearchPathA(LPCSTR, LPCSTR, LPCSTR, int, LPSTR, out LPSTR)"/> first searches the folders that are specified in the system path, and then searches the current working folder. When the value of this registry value is set to <c>0</c> (zero), the computer first searches the current working folder, and then searches the folders that are specified in the system path. The system default value for this registry key is <c>0</c> (zero).
        /// </para>
        /// <para>The search mode used by the <see cref="SearchPathA(LPCSTR, LPCSTR, LPCSTR, int, LPSTR, out LPSTR)"/> function can also be set per-process by calling the <see cref="SetSearchPathMode"/> function.</para>
        /// <para>The <see cref="SearchPathA(LPCSTR, LPCSTR, LPCSTR, int, LPSTR, out LPSTR)"/> function is not recommended as a method of locating a .dll file if the intended use of the output is in a call to the <see cref="LoadLibrary"/> function. This can result in locating the wrong .dll file because the search order of the <see cref="SearchPathA(LPCSTR, LPCSTR, LPCSTR, int, LPSTR, out LPSTR)"/> function differs from the search order used by the <see cref="LoadLibrary"/> function. If you need to locate and load a .dll file, use the <see cref="LoadLibrary"/> function.</para>
        /// <para>
        /// <note>Starting with Windows 10, version 1607, for the unicode version of this function (<see cref="SearchPathA(LPCSTR, LPCSTR, LPCSTR, int, LPSTR, out LPSTR)"/>), you can opt-in to remove the <see cref="MAX_PATH"/> limitation. See the "Maximum Path Length Limitation" section of <a href="https://docs.microsoft.com/windows/desktop/FileIO/naming-a-file">Naming Files, Paths, and Namespaces</a> for details.</note>
        /// </para>
        /// <para>
        /// In Windows 8 and Windows Server 2012, this function is supported by the following technologies.
        /// <list type="table">
        /// <listheader><term>Technology</term><description>Supported</description></listheader>
        /// <item><term>Server Message Block (SMB) 3.0 protocol </term><description>Yes</description></item>
        /// <item><term>SMB 3.0 Transparent Failover (TFO) </term><description>Yes</description></item>
        /// <item><term>SMB 3.0 with Scale-out File Shares (SO) </term><description>Yes</description></item>
        /// <item><term>Cluster Shared Volume File System (CsvFS) </term><description>Yes</description></item>
        /// <item><term>Resilient File System (ReFS) </term><description>Yes</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-searchpatha">SearchPathA function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/FileIO/file-management-functions">File Management Functions</seealso>
        /// <seealso cref="FindFirstFile"/>
        /// <seealso cref="FindNextFile"/>
        /// <seealso cref="GetSystemDirectory"/>
        /// <seealso cref="GetWindowsDirectory"/>
        /// <seealso cref="SetSearchPathMode"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern int SearchPathA(
            [In, Optional] LPCSTR lpPath,
            [In] LPCSTR lpFileName,
            [In, Optional] LPCSTR lpExtension,
            [In] int nBufferLength,
            [In, Optional] LPSTR lpBuffer,
            [Optional] out LPSTR lpFilePart
            );
        /// <inheritdoc cref="SearchPathA(LPCSTR, LPCSTR, LPCSTR, int, LPSTR, out LPSTR)"/>
        public static int SearchPathA(
            [In, Optional] LPCSTR lpPath,
            [In] LPCSTR lpFileName,
            [In, Optional] LPCSTR lpExtension,
            [In, Optional, MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer,
            [Optional] out LPCSTR lpFilePart
            ) =>
            SearchPathA(
                lpPath,
                lpFileName,
                lpExtension,
                lpBuffer?.Capacity ?? 0,
                lpBuffer,
                out lpFilePart);
        /// <inheritdoc cref="SearchPathA(LPCSTR, LPCSTR, LPCSTR, int, LPSTR, out LPSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        private static extern int SearchPathA(
            [In, Optional] LPCSTR lpPath,
            [In] LPCSTR lpFileName,
            [In, Optional] LPCSTR lpExtension,
            [In] int nBufferLength,
            [In, Optional, MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer,
            [Optional] out LPCSTR lpFilePart
            );
        /// <inheritdoc cref="SearchPathA(LPCSTR, LPCSTR, LPCSTR, int, LPSTR, out LPSTR)"/>
        public static int SearchPathA(
            [In, MarshalAs(UnmanagedType.LPStr), Optional] string lpPath,
            [In, MarshalAs(UnmanagedType.LPStr)] string lpFileName,
            [In, MarshalAs(UnmanagedType.LPStr), Optional] string lpExtension,
            [In, Optional, MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer,
            [MarshalAs(UnmanagedType.LPStr), Optional] out string lpFilePart
            ) =>
            SearchPathA(
                lpPath,
                lpFileName,
                lpExtension,
                lpBuffer?.Capacity ?? 0,
                lpBuffer,
                out lpFilePart
                );
        /// <inheritdoc cref="SearchPathA(LPCSTR, LPCSTR, LPCSTR, int, LPSTR, out LPSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        private static extern int SearchPathA(
            [In, MarshalAs(UnmanagedType.LPStr), Optional] string lpPath,
            [In, MarshalAs(UnmanagedType.LPStr)] string lpFileName,
            [In, MarshalAs(UnmanagedType.LPStr), Optional] string lpExtension,
            [In] int nBufferLength,
            [In, Optional, MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer,
            [MarshalAs(UnmanagedType.LPStr), Optional] out string lpFilePart
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 305
        #region NeedCurrentDirectoryForExePathA function
        /// <summary>
        /// Determines whether the current directory should be included in the search path for the specified executable.
        /// </summary>
        /// <param name="ExeName">The name of the executable file.</param>
        /// <returns>
        /// If the current directory should be part of the search path, the return value is <see langword="true"/>. Otherwise, the return value is <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// <para>This function should only be called in instances where the caller must explicitly resolve a relative executable name to an absolute name. If <see cref="CreateProcess"/> is called with a relative executable name, it will automatically search for the executable, calling this function to determine the search path.</para>
        /// <para>Most system functions perform their own path resolution, therefore, this function should only be called if you are attempting to resolve a search path for the specified executable based on the current directory.</para>
        /// <para>The value of the <c>NoDefaultCurrentDirectoryInExePath</c> environment variable determines the value this function returns. However, you should call this function rather than checking the environment variable directly, as the registry location of this environment variable can change.</para>
        /// <para>If the value of the <paramref name="ExeName"/> parameter contains a backslash, this function will always return <see langword="true"/>. If it does not contain a backslash, the existence of the <c>NoDefaultCurrentDirectoryInExePath</c> environment variable is checked, and not its value.</para>
        /// <para>An example of an instance when this function should be called instead of relying on the default search path resolution algorithm in <see cref="CreateProcess"/> is the "cmd.exe" executable. It calls this function to determine the command search path because it does its own path resolution before calling <see cref="CreateProcess"/>. If this function returns <see langword="true"/>, cmd.exe uses the path ".;%PATH%" for the executable search. If it returns <see langword="false"/>, cmd.exe uses the path "%PATH%" for the search.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows Vista [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-needcurrentdirectoryforexepatha">NeedCurrentDirectoryForExePathA function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CreateProcess"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/process-and-thread-functions">Process and Thread Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool NeedCurrentDirectoryForExePathA(
            [In] LPCSTR ExeName
            );
        /// <inheritdoc cref="NeedCurrentDirectoryForExePathA(LPCSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool NeedCurrentDirectoryForExePathA(
            [In, MarshalAs(UnmanagedType.LPStr)] string ExeName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 312
        #region NeedCurrentDirectoryForExePathW function
        /// <inheritdoc cref="NeedCurrentDirectoryForExePathA(LPCSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool NeedCurrentDirectoryForExePathW(
            [In] LPCWSTR ExeName
            );
        /// <inheritdoc cref="NeedCurrentDirectoryForExePathA(LPCSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool NeedCurrentDirectoryForExePathW(
            [In, MarshalAs(UnmanagedType.LPWStr)] string ExeName
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 319
        #region NeedCurrentDirectoryForExePath function
#if !NETSTANDARD1_3
        /// <inheritdoc cref="NeedCurrentDirectoryForExePathA(LPCSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool NeedCurrentDirectoryForExePath(
            [In] LPCTSTR ExeName
            );
        /// <inheritdoc cref="NeedCurrentDirectoryForExePathA(LPCSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool NeedCurrentDirectoryForExePath(
            [In, MarshalAs(UnmanagedType.LPTStr)] string ExeName
            );
#endif // !NETSTANDARD1_3
        #endregion
    }
}
