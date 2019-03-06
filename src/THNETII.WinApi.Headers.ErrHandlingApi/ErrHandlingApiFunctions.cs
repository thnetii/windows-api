using System;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.WinApi.Native.WinBase;

#if NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.ErrHandlingApi
{
    using static SYSTEM_ERROR_MODE;
    using static WinBaseFunctions;

    public static class ErrHandlingApiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\errhandlingapi.h, line 82
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
        /// <seealso cref="M:THNETII.WinApi.Native.WinUser.WinUserFunctions.SetLastErrorEx(System.Int32,THNETII.WinApi.Native.WinUser.SLE_TYPE)"/>
        [Obsolete(".NET Applications should not call " + nameof(GetLastError) + ". Instead the static System.Runtime.InteropServices.Marshal.GetLastWin32Error() method should be used.")]
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetLastError();
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\errhandlingapi.h, line 96
        #region SetLastError function
        /// <summary>
        /// Sets the last-error code for the calling thread.
        /// </summary>
        /// <param name="dwErrCode">The last-error code for the thread.</param>
        /// <remarks>
        /// <para>The last-error code is kept in thread local storage so that multiple threads do not overwrite each other's values.</para>
        /// <para>Most functions call <see cref="SetLastError"/> or <see cref="M:THNETII.WinApi.Native.WinUser.WinUserFunctions.SetLastErrorEx(System.Int32,THNETII.WinApi.Native.WinUser.SLE_TYPE)"/> only when they fail. However, some system functions call <see cref="SetLastError"/> or <see cref="M:THNETII.WinApi.Native.WinUser.WinUserFunctions.SetLastErrorEx(System.Int32,THNETII.WinApi.Native.WinUser.SLE_TYPE)"/> under conditions of success; those cases are noted in each function's documentation.</para>
        /// <para>Applications can optionally retrieve the value set by this function by using the <see cref="Marshal.GetLastWin32Error"/> function immediately after a function fails.</para>
        /// <para>Error codes are 32-bit values (bit 31 is the most significant bit). Bit 29 is reserved for application-defined error codes; no system error code has this bit set. If you are defining an error code for your application, set this bit to indicate that the error code has been defined by your application and to ensure that your error code does not conflict with any system-defined error codes.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://msdn.microsoft.com/en-us/library/ms680627.aspx">SetLastError function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="Marshal.GetLastWin32Error"/>
        /// <seealso cref="M:THNETII.WinApi.Native.WinUser.WinUserFunctions.SetLastErrorEx(System.Int32,THNETII.WinApi.Native.WinUser.SLE_TYPE)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern void SetLastError(
            [In] int dwErrCode
            );
        #endregion
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
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\errhandlingapi.h, line 222
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
        public static void FatalAppExit(
            int uAction,
            string lpMessageText
            ) => FatalAppExitW(uAction, lpMessageText);
        /// <inheritdoc cref="FatalAppExit"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(FatalAppExitA))]
        public static extern void FatalAppExitA(
            [In] int uAction,
            [In, MarshalAs(UnmanagedType.LPStr)] string lpMessageText
            );
        /// <inheritdoc cref="FatalAppExit"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(FatalAppExitW))]
        public static extern void FatalAppExitW(
            [In] int uAction,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpMessageText
            );
        #endregion
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
