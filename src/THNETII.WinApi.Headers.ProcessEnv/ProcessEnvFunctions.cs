using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.ProcessEnv
{
    using static NativeLibraryNames;

    public static class ProcessEnvFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\processenv.h, line 29
        #region SetEnvironmentStringsW function
        /// <summary>
        /// Sets the environment strings of the calling process (both the system and the user environment variables) for the current process.
        /// </summary>
        /// <param name="NewEnvironment">
        /// The environment variable string using the following format:
        /// <code>Var1 Value1 Var2 Value2 Var3 Value3 VarN ValueN</code>
        /// </param>
        /// <returns>Returns <see langword="true"/> on success.</returns>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/processenv/nf-processenv-setenvironmentstringsw">SetEnvironmentStrings function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        [SuppressMessage("Globalization", "CA2101: Specify marshaling for P/Invoke string arguments")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentStrings(
            [In, MarshalAs(UnmanagedType.LPTStr)] string NewEnvironment
            );
        #endregion
    }
}
