using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Win32.WinApi.Diagnostics.ApplicationRecovertRestart
{
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
        /// <param name="hProcess">A handle to the process. This handle must have the PROCESS_VM_READ access right.</param>
        /// <param name="pwzCommandline">A buffer that receives the restart command line specified by the application when it called the <see cref="RegisterApplicationRestart"/> function. The maximum size of the command line, in characters, is <see cref="RESTART_MAX_CMD_LINE"/>. Can be <c>null</c> if <paramref name="pcchSize"/> is zero.</param>
        /// <param name="pcchSize"></param>
        /// <param name="pdwFlags"></param>
        /// <returns></returns>
        /// <remarks>
        /// <para><strong>Minimum supported client:</strong> Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documenation page: <a href="https://msdn.microsoft.com/en-us/library/aa373344.aspx">GetApplicationRestartSettings function</a></para>
        /// </remarks>
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Error)]
        public static extern int GetApplicationRestartSettings(
            [In] IntPtr hProcess,
            [Optional] StringBuilder pwzCommandline,
            ref int pcchSize,
            [Optional] out int pdwFlags
            );
        #endregion
    }
}
