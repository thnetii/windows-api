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
        #region SearchPath function
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
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSetAuto)]
        private static extern int SearchPath(
            [In, MarshalAs(UnmanagedType.LPTStr), Optional] string lpPath,
            [In, MarshalAs(UnmanagedType.LPTStr)] string lpFileName,
            [In, MarshalAs(UnmanagedType.LPTStr), Optional] string lpExtension,
            [In] int nBufferLength,
            [In, Optional, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer,
            [MarshalAs(UnmanagedType.LPTStr), Optional] out string lpFilePart
            );
        #endregion
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
    }
}
