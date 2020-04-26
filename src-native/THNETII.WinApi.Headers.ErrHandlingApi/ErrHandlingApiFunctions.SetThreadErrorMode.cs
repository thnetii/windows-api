using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinBase;

#if NETSTANDARD1_3 || NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.ErrHandlingApi
{
    using static SYSTEM_ERROR_MODE;

    partial class ErrHandlingApiFunctions
    {
        #region SetThreadErrorMode function
        /// <summary>
        /// Controls whether the system will handle the specified types of serious errors or whether the calling thread will handle them. 
        /// </summary>
        /// <param name="dwNewMode">
        /// The process error mode. This parameter can be one or more of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><c>0</c> (zero)<br/><c>default(<see cref="SYSTEM_ERROR_MODE"/>)</c></term><description>Use the system default, which is to display all error dialog boxes.</description></item>
        /// <item><term><see cref="SEM_FAILCRITICALERRORS"/></term><description><para>The system does not display the critical-error-handler message box. Instead, the system sends the error to the calling process.</para>Best practice is that all applications call the process-wide <see cref="SetErrorMode"/> function with a parameter of <see cref="SEM_FAILCRITICALERRORS"/> at startup. This is to prevent error mode dialogs from hanging the application.<para></para></description></item>
        /// <item><term><see cref="SEM_NOALIGNMENTFAULTEXCEPT"/></term><description><para>The system automatically fixes memory alignment faults and makes them invisible to the application. It does this for the calling process and any descendant processes. This feature is only supported by certain processor architectures. For more information, see the Remarks section. </para>After this value is set for a process, subsequent attempts to clear the value are ignored.<para></para></description></item>
        /// <item><term><see cref="SEM_NOGPFAULTERRORBOX"/></term><description>The system does not display the Windows Error Reporting dialog.</description></item>
        /// <item><term><see cref="SEM_NOOPENFILEERRORBOX"/></term><description>The <see cref="OpenFile"/> function does not display a message box when it fails to find a file. Instead, the error is returned to the caller. This error mode overrides the <see cref="OF_PROMPT"/> flag.</description></item>
        /// </list>
        /// </param>
        /// <param name="lpOldMode">If the function succeeds, this parameter is set to the thread's previous error mode.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// Each process has an associated error mode that indicates to the system how the application is going to respond to serious errors. A thread inherits the error mode of the process in which it is running. To retrieve the process error mode, use the <see cref="GetErrorMode"/> function. To retrieve the error mode of the calling thread, use the <see cref="GetThreadErrorMode"/> function.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 7 [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2008 R2 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winuser/nf-winuser-setlasterrorex">SetLastErrorEx function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetThreadErrorMode"/>
        /// <seealso cref="SetErrorMode"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadErrorMode(
            [In] SYSTEM_ERROR_MODE dwNewMode,
            out SYSTEM_ERROR_MODE lpOldMode
            );
        #endregion
    }
}
