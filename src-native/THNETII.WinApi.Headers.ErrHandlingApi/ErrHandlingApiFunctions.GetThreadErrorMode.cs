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
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\errhandlingapi.h, line 250
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
        public static extern SYSTEM_ERROR_MODE GetThreadErrorMode();
        #endregion
    }
}
