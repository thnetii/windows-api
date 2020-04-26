using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinBase;

#if NETSTANDARD1_3 || NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.ErrHandlingApi
{
    partial class ErrHandlingApiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\errhandlingapi.h, line 107
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
        public static extern SYSTEM_ERROR_MODE GetErrorMode();
        #endregion
    }
}
