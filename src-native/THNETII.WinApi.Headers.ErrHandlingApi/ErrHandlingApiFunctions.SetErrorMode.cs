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
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\errhandlingapi.h, line 125
        #region SetErrorMode function
        /// <summary>
        /// Controls whether the system will handle the specified types of serious errors or whether the process will handle them.
        /// </summary>
        /// <param name="uMode">
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
        /// <returns>The return value is the previous state of the error-mode bit flags.</returns>
        /// <remarks>
        /// <para>Each process has an associated error mode that indicates to the system how the application is going to respond to serious errors. A child process inherits the error mode of its parent process. To retrieve the process error mode, use the <see cref="GetErrorMode"/> function.</para>
        /// <para>Because the error mode is set for the entire process, you must ensure that multi-threaded applications do not set different error-mode flags. Doing so can lead to inconsistent error handling.</para>
        /// <para>The system does not make alignment faults visible to an application on all processor architectures. Therefore, specifying <see cref="SEM_NOALIGNMENTFAULTEXCEPT"/> is not an error on such architectures, but the system is free to silently ignore the request.</para>
        /// <para><strong>Windows 7:</strong><br/>Callers should favor <see cref="SetThreadErrorMode"/> over <see cref="SetErrorMode"/> since it is less disruptive to the normal behavior of the system. </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/ms680621.aspx">SetErrorMode function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetErrorMode"/>
        /// <seealso cref="SetThreadErrorMode"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern SYSTEM_ERROR_MODE SetErrorMode(
            SYSTEM_ERROR_MODE uMode
            );
        #endregion
    }
    }
