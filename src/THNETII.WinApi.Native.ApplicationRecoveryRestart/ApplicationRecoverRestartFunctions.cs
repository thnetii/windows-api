using Microsoft.Win32.WinApi.WinError;
using System;
using System.Runtime.InteropServices;
using System.Text;

using static Microsoft.Win32.WinApi.WinError.HRESULT;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

namespace Microsoft.Win32.WinApi.Diagnostics.ApplicationRecovertRestart
{
    /// <summary>
    /// Application Recovery and Restart defined functions.
    /// </summary>
    public static class ApplicationRecoverRestartFunctions
    {
        #region ApplicationRecoveryCallback callback function
        /// <summary>
        /// Application-defined callback function used to save data and application state information in the event the application encounters an unhandled exception or becomes unresponsive. 
        /// </summary>
        /// <param name="pvParameter">Context information specified when you called the <see cref="RegisterApplicationRecoveryCallback"/> function to register for recovery.</param>
        /// <returns>The return value is not used and should be 0.</returns>
        /// <remarks>
        /// <para>You specify the callback when calling the <see cref="RegisterApplicationRecoveryCallback"/> function. </para>
        /// <para>The recovery process must call the <see cref="ApplicationRecoveryInProgress"/> function within the specified ping interval to indicate that recovery is still progressing.</para>
        /// <para>When you complete the recovery process, call the <see cref="ApplicationRecoveryFinished"/> function.</para>
        /// <para>If an unhandled exception occurs, you should assume an untrustable and unstable state and do just enough to allow recovery. Loading a DLL or creating a thread could potentially cause deadlocks and should be avoided. It should be okay to allocate resource, if available.</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/aa373202.aspx">ApplicationRecoveryCallback callback function</a></para>
        /// </remarks>
        /// <seealso cref="ApplicationRecoveryFinished"/>
        /// <seealso cref="ApplicationRecoveryInProgress"/>
        /// <seealso cref="RegisterApplicationRecoveryCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate int ApplicationRecoveryCallback(
            IntPtr pvParameter
            );
        #endregion
        #region ApplicationRecoveryFinished function
        /// <summary>
        /// Indicates that the calling application has completed its data recovery.
        /// </summary>
        /// <param name="bSuccess">Specify <c>true</c> to indicate that the data was successfully recovered; otherwise, <c>false</c>.</param>
        /// <remarks>
        /// This should be the last call that you make in your callback because your application terminates as soon as this function is called.
        /// <para><strong>Minimum supported client:</strong> Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/ms679277.aspx">ApplicationRecoveryFinished function</a></para>
        /// </remarks>
        /// <seealso cref="ApplicationRecoveryInProgress"/>
        /// <seealso cref="RegisterApplicationRecoveryCallback"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern void ApplicationRecoveryFinished(
            [In, MarshalAs(UnmanagedType.Bool)] bool bSuccess
            );
        #endregion
        #region ApplicationRecoveryInProgress function
        /// <summary>Indicates that the calling application is continuing to recover data.</summary>
        /// <param name="pbCanceled">Indicates whether the user has canceled the recovery process. Set by WER if the user clicks the Cancel button.</param>
        /// <returns>
        /// This function returns <see cref="S_OK"/> on success or one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term> <description>Description</description></listheader>
        /// <item><term><see cref="E_FAIL"/></term> <description>You can call this function only after Windows Error Reporting has called your recovery callback function.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <para>The application must call this function within the interval specified when calling the <see cref="RegisterApplicationRecoveryCallback"/> function. If the application fails to call this function within the specified interval, WER terminates the application. The recovery process can continue as long as this function is being called.</para>
        /// <para>If the user cancels the recovery process, the application should terminate. </para>
        /// <para>To indicate that the recovery process has been completed, call the <see cref="ApplicationRecoveryFinished"/> function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/aa373329.aspx">ApplicationRecoveryInProgress function</a></para>
        /// </remarks>
        /// <seealso cref="ApplicationRecoveryFinished"/>
        /// <seealso cref="RegisterApplicationRecoveryCallback"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Error)]
        public static extern int ApplicationRecoveryInProgress(
            [MarshalAs(UnmanagedType.Bool)] out bool pbCanceled
            );
        #endregion
        #region GetApplicationRecoveryCallback function
        /// <summary>
        /// Retrieves a pointer to the callback routine registered for the specified process. The address returned is in the virtual address space of the process.
        /// </summary>
        /// <param name="hProcess">A handle to the process. This handle must have the PROCESS_VM_READ access right.</param>
        /// <param name="pRecoveryCallback">A pointer to the recovery callback function. For more information, see <see cref="ApplicationRecoveryCallback"/>.</param>
        /// <param name="ppvParameter">A pointer to the callback parameter.</param>
        /// <param name="pdwPingInterval">The recovery ping interval, in 100-nanosecond intervals.</param>
        /// <param name="pdwFlags">Reserved for future use.</param>
        /// <returns>
        /// This function returns <see cref="S_OK"/> on success or one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term> <description>Description</description></listheader>
        /// <item><term><see cref="S_FALSE"/></term> <description>The application did not register for recovery.</description></item>
        /// <item><term><see cref="E_INVALIDARG"/></term> <description>One or more parameters are not valid.</description></item>
        /// </list>
        /// </returns>
        /// <seealso cref="RegisterApplicationRecoveryCallback"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Error)]
        public static extern int GetApplicationRecoveryCallback(
            [In] IntPtr hProcess,
            out ApplicationRecoveryCallback pRecoveryCallback,
            out IntPtr ppvParameter,
            out int pdwPingInterval,
            out int pdwFlags
            );
        #endregion
        #region GetApplicationRestartSettings function
        /// <summary>
        /// Max length of commandline in characters (including the trailing null-termination character that can be registered for restart)
        /// </summary>
        public const int RESTART_MAX_CMD_LINE = 1024;

        /// <summary>Retrieves the restart information registered for the specified process.</summary>
        /// <param name="hProcess">A handle to the process. This handle must have the <see cref="PROCESS_VM_READ"/> access right.</param>
        /// <param name="pwzCommandline">A buffer that receives the restart command line specified by the application when it called the <see cref="RegisterApplicationRestart"/> function. The maximum size of the command line, in characters, is <see cref="RESTART_MAX_CMD_LINE"/>. Can be <c>null</c> if <paramref name="pcchSize"/> is zero.</param>
        /// <param name="pcchSize">
        /// <para>On input, specifies the size of the <paramref name="pwzCommandline"/> buffer, in characters. </para>
        /// <para>If the buffer is not large enough to receive the command line, the function fails with <c>HRESULT_FROM_WIN32(<see cref="ERROR_INSUFFICIENT_BUFFER"/>)</c> and sets this parameter to the required buffer size, in characters.</para>
        /// <para>On output, specifies the size of the buffer that was used.</para>
        /// <para>To determine the required buffer size, set <paramref name="pwzCommandline"/> to <c>null</c> and this parameter to zero. The size includes one for the null-terminator character. Note that the function returns <see cref="S_OK"/>, not <c>HRESULT_FROM_WIN32(<see cref="ERROR_INSUFFICIENT_BUFFER"/>)</c> in this case.</para>
        /// </param>
        /// <param name="pdwFlags"></param>
        /// <returns></returns>
        /// <remarks>
        /// <para><strong>Minimum supported client:</strong> Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/aa373344.aspx">GetApplicationRestartSettings function</a></para>
        /// </remarks>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Error)]
        public static extern HRESULT GetApplicationRestartSettings(
            [In] IntPtr hProcess,
            [Optional] StringBuilder pwzCommandline,
            ref int pcchSize,
            [Optional] out int pdwFlags
            );
        #endregion
        #region RegisterApplicationRecoveryCallback function
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const int RECOVERY_DEFAULT_PING_INTERVAL = 5000;
        public const int RECOVERY_MAX_PING_INTERVAL = (5 * 60 * 1000);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// Registers the active instance of an application for recovery.
        /// </summary>
        /// <param name="pRecoveryCallback">A recovery callback function. For more information, see <see cref="ApplicationRecoveryCallback"/>.</param>
        /// <param name="pvParameter">A pointer to a variable to be passed to the callback function. Can be <see cref="IntPtr.Zero"/>.</param>
        /// <param name="dwPingInterval">
        /// <para>The recovery ping interval, in milliseconds. By default, the interval is 5 seconds (<see cref="RECOVERY_DEFAULT_PING_INTERVAL"/>). The maximum interval is 5 minutes. If you specify zero, the default interval is used. </para>
        /// <para>You must call the <see cref="ApplicationRecoveryInProgress"/> function within the specified interval to indicate to ARR that you are still actively recovering; otherwise, WER terminates recovery. Typically, you perform recovery in a loop with each iteration lasting no longer than the ping interval. Each iteration performs a block of recovery work followed by a call to <see cref="ApplicationRecoveryInProgress"/>. Since you also use <see cref="ApplicationRecoveryInProgress"/> to determine if the user wants to cancel recovery, you should consider a smaller interval, so you do not perform a lot of work unnecessarily.</para>
        /// </param>
        /// <param name="dwFlags">Reserved for future use. Set to zero.</param>
        /// <returns>
        /// This function returns <see cref="S_OK"/> on success or one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term> <description>Description</description></listheader>
        /// <item><term><see cref="E_FAIL"/></term> <description>Internal error; the registration failed.</description></item>
        /// <item><term><see cref="E_INVALIDARG"/></term> <description>The ping interval cannot be more than five minutes.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <para>If the application encounters an unhandled exception or becomes unresponsive, Windows Error Reporting (WER) calls the specified recovery callback. You should use the callback to save data and state information. You can use the information if you also call the <see cref="RegisterApplicationRestart"/> function to request that WER restart the application.</para>
        /// <para>WER will not call your recovery callback if an installer wants to update a component of your application. To save data and state information in the update case, you should handle the <see cref="WM_QUERYENDSESSION"/> and <see cref="WM_ENDSESSION"/> messages. For details, see each message. The timeout for responding to these messages is five seconds. Most of the available recovery time is in the <see cref="WM_CLOSE"/> message for which you have 30 seconds.</para>
        /// <para>A console application that can be updated uses the CTRL_C_EVENT notification to initiate recovery (for details, see the HandlerRoutine callback function). The timeout for the handler to complete is 30 seconds.</para>
        /// <para>Applications should consider saving data and state information on a periodic bases to shorten the amount of time required for recovery.</para>
        /// <para><strong>Minimum supported client:</strong> Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/aa373345.aspx">RegisterApplicationRecoveryCallback function</a></para>
        /// </remarks>
        /// <seealso cref="ApplicationRecoveryCallback"/>
        /// <seealso cref="ApplicationRecoveryInProgress"/>
        /// <seealso cref="RegisterApplicationRestart"/>
        /// <seealso cref="UnregisterApplicationRecoveryCallback"/>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Error)]
        public static extern HRESULT RegisterApplicationRecoveryCallback(
            [In, MarshalAs(UnmanagedType.FunctionPtr)] ApplicationRecoveryCallback pRecoveryCallback,
            [In, Optional] IntPtr pvParameter,
            [In] int dwPingInterval,
            [In] int dwFlags
            );
        #endregion
        #region RegisterApplicationRestart function
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        [Flags]
        public enum RESTART_FLAG : int
        {
            /// <summary>Do not restart the process if it terminates due to an unhandled exception.</summary>
            RESTART_NO_CRASH = 1,
            /// <summary>Do not restart the process if it terminates due to the application not responding.</summary>
            RESTART_NO_HANG = 2,
            /// <summary>Do not restart the process if it terminates due to the installation of an update.</summary>
            RESTART_NO_PATCH = 4,
            /// <summary>Do not restart the process if the computer is restarted as the result of an update.</summary>
            RESTART_NO_REBOOT = 8
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// Registers the active instance of an application for restart.
        /// </summary>
        /// <param name="pwzCommandline">
        /// <para>A Unicode string that specifies the command-line arguments for the application when it is restarted. The maximum size of the command line that you can specify is <see cref="RESTART_MAX_CMD_LINE"/> characters. Do not include the name of the executable in the command line; this function adds it for you. </para>
        /// <para>If this parameter is <c>null</c> or an empty string, the previously registered command line is removed. If the argument contains spaces, use quotes around the argument.</para>
        /// </param>
        /// <param name="dwFlags">This parameter can be 0 or one or more of the values defined in the <see cref="RESTART_FLAG"/> enumeration .</param>
        /// <returns></returns>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Error)]
        public static extern HRESULT RegisterApplicationRestart(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string pwzCommandline,
            [In, MarshalAs(UnmanagedType.I4)] RESTART_FLAG dwFlags
            );
        #endregion
    }
}
