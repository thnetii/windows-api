using Microsoft.Win32.WinApi.WinError;
using System;
using System.Runtime.InteropServices;
using System.Text;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.WinError.HRESULT;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Declares the Network Management Functions.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370675.aspx">Network Management Functions</a></para>
    /// </remarks>
    public static class NetworkManagementFunctions
    {
        #region GetNetScheduleAccountInformation function
        /// <summary>
        /// The <see cref="GetNetScheduleAccountInformation"/> function retrieves the AT Service account name. 
        /// </summary>
        /// <param name="pwszServerName">A string for the name of the computer whose account information is being retrieved.</param>
        /// <param name="ccAccount">The number of characters, including the NULL terminator, allocated for <paramref name="wszAccount"/>. The maximum allowed length for this value is the maximum domain name length plus the maximum user name length plus 2, expressed as <c><see cref="DNLEN"/> + <see cref="UNLEN"/> + 2</c>. (The last two characters are the "\" character and the NULL terminator.)</param>
        /// <param name="wszAccount">A string buffer that receives the account information.</param>
        /// <returns>The return value is an <see cref="HRESULT"/>. A value of <see cref="S_OK"/> indicates the function succeeded, and the account information is returned in <paramref name="wszAccount"/>. A value of <see cref="S_FALSE"/> indicates the function succeeded, and the account is the Local System account (no information will be returned in <paramref name="wszAccount"/>). Any other return values indicate an error condition.</returns>
        /// <remarks>
        /// <para><strong>Minimum supported client</strong>: Windows Vista, Windows XP with SP1 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows 7</para>
        /// <para><strong>End of server support</strong>: Windows Server 2008</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370264.aspx">GetNetScheduleAccountInformation function</a></para>
        /// </remarks>
        /// <seealso cref="SetNetScheduleAccountInformation"/>
        [Obsolete("GetNetScheduleAccountInformation is no longer available for use as of Windows 8. Instead, use the Task Scheduler 2.0 Interfaces.")]
        [DllImport("Mstask.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Error)]
        public static extern HRESULT GetNetScheduleAccountInformation(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszServerName,
            [In] int ccAccount,
            [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder wszAccount
            );
        #endregion
        #region NetAccessAdd function
        // This function is not supported.
        #endregion
        #region NetAccessCheck function
        // This function is not supported.
        #endregion
        #region NetAccessDel function
        // This function is not supported.
        #endregion
        #region NetAccessEnum function
        // This function is not supported.
        #endregion
        #region NetAccessGetInfo function
        // This function is not supported.
        #endregion
        #region NetAccessGetUserPerms function
        // This function is not supported.
        #endregion
        #region NetAccessSetInfo function
        // This function is not supported.
        #endregion
        #region NetAddAlternateComputerName function
        /// <summary>
        /// The <see cref="NetAddAlternateComputerName"/> function adds an alternate name for the specified computer.
        /// </summary>
        /// <param name="Server">A string that specifies the name of the computer on which to execute this function. If this parameter is <c>null</c> or omitted, the local computer is used.</param>
        /// <param name="AlternateName">A string that specifies the alternate name to add. This name must be in the form of a fully qualified DNS name.</param>
        /// <param name="DomainAccount">
        /// <para>A string that specifies the domain account to use for accessing the machine account object for the computer specified in the <paramref name="Server"/> parameter in Active Directory. If this parameter is <c>null</c>, then the credentials of the user executing this routine are used.</para>
        /// <para>This parameter is not used if the server to execute this function is not joined to a domain. </para>
        /// </param>
        /// <param name="DomainAccountPassword">
        /// <para>A string that specifies the password matching the domain account passed in the <paramref name="DomainAccount"/> parameter. If this parameter is <c>null</c>, then the credentials of the user executing this routine are used. </para>
        /// <para>This parameter is ignored if the <paramref name="DomainAccount"/> parameter is <c>null</c>. This parameter is not used if the server to execute this function is not joined to a domain. </para>
        /// </param>
        /// <param name="Reserved">Reserved for future use. This parameter should be <c>0</c> (zero).</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="NERR_Success"/>.<br/>
        /// If the function fails, the return value can be one of the following error codes from the <see cref="Win32ErrorCode"/> enumeration.
        /// <list type="table">
        /// <listheader><term>Return code</term> <description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term> <description>Access is denied. This error is returned if the caller was not a member of the Administrators local group on the target computer.</description>
        /// <term><see cref="ERROR_INVALID_NAME"/></term> <description>A name parameter is incorrect. This error is returned if the <paramref name="AlternateName"/> parameter does not contain valid name.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term> <description>A parameter is incorrect. This error is returned if the <paramref name="DomainAccount"/> parameter does not contain a valid domain. This error is also returned if the <paramref name="DomainAccount"/> parameter is not <c>null</c> and the <paramref name="DomainAccountPassword"/> parameter is not <c>null</c> but does not contain a Unicode string.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term> <description>Not enough memory is available to process this command.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term> <description>The request is not supported. This error is returned if the target computer specified in the <paramref name="Server"/> parameter on which this function executes is running on Windows 2000 and earlier. </description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term> <description>The Workstation service has not been started.</description>
        /// <term><see cref="RPC_S_CALL_IN_PROGRESS"/></term> <description>A remote procedure call is already in progress for this thread.</description>
        /// <term><see cref="RPC_S_PROTSEQ_NOT_SUPPORTED"/></term> <description>The remote procedure call protocol sequence is not supported.</description>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetAddAlternateComputerName"/> function is supported on Windows XP and later. </para>
        /// <para>The <see cref="NetAddAlternateComputerName"/> function is used to set secondary network names for computers. The primary name is the name used for authentication and maps to the machine account name.</para>
        /// <para>The <see cref="NetAddAlternateComputerName"/> function requires that the caller is a member of the Administrators local group on the target computer.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dd877206.aspx">NetAddAlternateComputerName function</a></para>
        /// </remarks>
        /// <seealso cref="NetEnumerateComputerNames"/>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetRemoveAlternateComputerName"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetSetPrimaryComputerName"/>
        /// <seealso cref="NetUnjoinDomain"/>
        /// <seealso cref="SetComputerNameEx"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetAddAlternateComputerName(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string Server,
            [In, MarshalAs(UnmanagedType.LPWStr)] string AlternateName,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string DomainAccount,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string DomainAccountPassword,
            [In] uint Reserved
            );
        #endregion
        #region NetAlertRaise function
        /// <summary>
        /// <para>The <see cref="NetAlertRaise"/> function notifies all registered clients when a particular event occurs.</para>
        /// <para>To simplify sending an alert message, you can call the extended function <see cref="NetAlertRaiseEx"/> instead. <see cref="NetAlertRaiseEx"/> does not require that you specify a <see cref="STD_ALERT"/> structure.</para>
        /// </summary>
        /// <param name="AlertEventName">A string that specifies the alert class (type of alert) to raise. This parameter can be one of the following predefined values, or a user-defined alert class for network applications. The event name for an alert can be any text string. </param>
        /// <param name="Buffer">A pointer to the data to send to the clients listening for the interrupting message. The data should begin with a fixed-length <see cref="STD_ALERT"/> structure followed by additional message data in one <see cref="ADMIN_OTHER_INFO"/>, <see cref="ERRLOG_OTHER_INFO"/>, <see cref="PRINT_OTHER_INFO"/>, or <see cref="USER_OTHER_INFO"/> structure. Finally, the buffer should include any required variable-length information.</param>
        /// <param name="BufferSize">The size, in bytes, of the message buffer.</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="NERR_Success"/>.<br/>
        /// If the function fails, the return value is a system error code and a can be one of the following error codes.
        /// <list type="list">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="AlertEventName"/> parameter is <c>null</c> or an empty string, the <paramref name="Buffer"/> parameter is <c>null</c>, or the <paramref name="BufferSize"/> parameter is less than the size of the <see cref="STD_ALERT"/> structure plus the fixed size for the additional message data structure. </description>
        /// <term><see cref="Win32ErrorCode.ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned on Windows Vista and later since the Alerter service is not supported.</description>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to successfully execute the <see cref="NetAlertRaise"/> function.</para>
        /// <para>The alerter service must be running on the client computer when you call the <see cref="NetAlertRaise"/> function, or the function fails with <see cref="ERROR_FILE_NOT_FOUND"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows XP</para>
        /// <para><strong>End of server support</strong>: Windows Server 2003</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370297.aspx">NetAlertRaise function</a></para>
        /// </remarks>
        /// <seealso cref="ADMIN_OTHER_INFO"/>
        /// <seealso cref="ERRLOG_OTHER_INFO"/>
        /// <seealso cref="NetAlertRaiseEx"/>
        /// <seealso cref="PRINT_OTHER_INFO"/>
        /// <seealso cref="STD_ALERT"/>
        /// <seealso cref="USER_OTHER_INFO"/>
        [Obsolete("This function is not supported as of Windows Vista because the alerter service is not supported.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetAlertRaise(
            [In, MarshalAs(UnmanagedType.LPWStr)] string AlertEventName,
            [In] NetApiAlertBufferHandle Buffer,
            [In] int BufferSize
            );
        #endregion
        #region NetAlertRaiseEx function
        /// <summary>
        /// The <see cref="NetAlertRaiseEx"/> function notifies all registered clients when a particular event occurs. You can call this extended function to simplify the sending of an alert message because <see cref="NetAlertRaiseEx"/> does not require that you specify a <see cref="STD_ALERT"/> structure.
        /// </summary>
        /// <param name="AlertEventName">A string that specifies the alert class (type of alert) to raise.</param>
        /// <param name="VariableInfo">A pointer to the data to send to the clients listening for the interrupting message. The data should consist of one <see cref="ADMIN_OTHER_INFO"/>, <see cref="ERRLOG_OTHER_INFO"/>, <see cref="PRINT_OTHER_INFO"/>, or <see cref="USER_OTHER_INFO"/> structure followed by any required variable-length information.</param>
        /// <param name="VariableInfoSize">The number of bytes of variable information in the buffer pointed to by the <paramref name="VariableInfo"/> parameter.</param>
        /// <param name="ServiceName">A string that specifies the name of the service raising the interrupting message.</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="NERR_Success"/>.<br/>
        /// If the function fails, the return value is a system error code and a can be one of the following error codes.
        /// <list type="list">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="AlertEventName"/> parameter is <c>null</c> or an empty string, the <paramref name="VariableInfo"/> parameter is <c>null</c>, or the <paramref name="VariableInfoSize"/> parameter is greater than 512 minus the size of the <see cref="STD_ALERT"/> structure. </description>
        /// <term><see cref="Win32ErrorCode.ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned on Windows Vista and later since the Alerter service is not supported.</description>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to successfully execute the <see cref="NetAlertRaiseEx"/> function.</para>
        /// <para>The alerter service must be running on the client computer when you call the <see cref="NetAlertRaiseEx"/> function, or the function fails with <see cref="ERROR_FILE_NOT_FOUND"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows XP</para>
        /// <para><strong>End of server support</strong>: Windows Server 2003</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370298.aspx">NetAlertRaiseEx function</a></para>
        /// </remarks>
        /// <seealso cref="NetAlertRaise"/>
        /// <seealso cref="ADMIN_OTHER_INFO"/>
        /// <seealso cref="ERRLOG_OTHER_INFO"/>
        /// <seealso cref="PRINT_OTHER_INFO"/>
        /// <seealso cref="STD_ALERT"/>
        /// <seealso cref="USER_OTHER_INFO"/>
        [Obsolete("This function is not supported as of Windows Vista because the alerter service is not supported.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetAlertRaiseEx(
            [In, MarshalAs(UnmanagedType.LPWStr)] string AlertEventName,
            [In] NetApiAlertOtherInfoBufferHandle VariableInfo,
            [In] int VariableInfoSize,
            [In, MarshalAs(UnmanagedType.LPWStr)] string ServiceName
            );
        #endregion
        #region NetApiBufferAllocate function
        /// <summary>
        /// The <see cref="NetApiBufferAllocate"/> function allocates memory from the heap. Use this function only when compatibility with the <see cref="NetApiBufferFree"/> function is required. Otherwise, use one of the other memory management functions.
        /// </summary>
        /// <param name="ByteCount">Number of bytes to be allocated.</param>
        /// <param name="Buffer">Receives a pointer to the allocated buffer.</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="NERR_Success"/>.<br/>
        /// If the function fails, the return value is a system error code from the <see cref="Win32ErrorCode"/> enumeration.
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to successfully execute the ApiBuffer functions.</para>
        /// <para>For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370676.aspx">Network Management Function Buffers</a> and <a href="https://msdn.microsoft.com/en-us/library/aa370677.aspx">Network Management Function Buffer Lengths</a>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370302.aspx">NetApiBufferAllocate function</a></para>
        /// </remarks>
        /// <seealso cref="NetApiBufferFree"/>
        /// <seealso cref="NetApiBufferReallocate"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetApiBufferAllocate(
            [In] int ByteCount,
            out IntPtr Buffer
            );
        #endregion
        #region NetApiBufferFree function
        /// <summary>
        /// The <see cref="NetApiBufferFree"/> function frees the memory that the <see cref="NetApiBufferAllocate"/> function allocates. Applications should also call <see cref="NetApiBufferFree"/> to free the memory that other network management functions use internally to return information.
        /// </summary>
        /// <param name="Buffer">A pointer to a buffer returned previously by another network management function or memory allocated by calling the <see cref="NetApiBufferAllocate"/> function.</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="NERR_Success"/>.<br/>
        /// If the function fails, the return value is a system error code from the <see cref="Win32ErrorCode"/> enumeration.
        /// </returns>
        /// <remarks>
        /// <para>
        /// The NetApiBufferFree function is used to free memory used by network management functions. This function is used in two cases:
        /// <list type="bullet">
        /// <item>To free memory explicitly allocated by calls in an application to the <see cref="NetApiBufferAllocate"/> function when the memory is no longer needed.</item>
        /// <item>To free memory allocated internally by calls in an application to remotable network management functions that return information to the caller. The RPC run-time library internally allocates the buffer containing the return information. </item>
        /// </list>
        /// </para>
        /// <para>Many network management functions retrieve information and return this information as a buffer that may contain a complex structure, an array of structures, or an array of nested structures. These functions use the RPC run-time library to internally allocate the buffer containing the return information, whether the call is to a local computer or a remote server. For example, the <see cref="NetServerEnum"/> function retrieves a lists of servers and returns this information as an array of structures pointed to by the <em>bufptr</em> parameter. When the function is successful, memory is allocated internally by the <see cref="NetServerEnum"/> function to store the array of structures returned in the <em>bufptr</em> parameter to the application. When this array of structures is no longer needed, the <see cref="NetApiBufferFree"/> function should be called by the application with the <paramref name="Buffer"/> parameter set to the <em>bufptr</em> parameter returned by <see cref="NetServerEnum"/> to free this internal memory used. In these cases, the <see cref="NetApiBufferFree"/> function frees all of the internal memory allocated for the buffer including memory for nested structures, pointers to strings, and other data.</para>
        /// <para>No special group membership is required to successfully execute the <see cref="NetApiBufferFree"/> function or any of the other <a href="https://msdn.microsoft.com/en-us/library/aa370245.aspx">ApiBuffer functions</a>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370304.aspx">NetApiBufferFree function</a></para>
        /// </remarks>
        /// <seealso cref="NetApiBufferAllocate"/>
        /// <seealso cref="NetApiBufferReallocate"/>
        /// <seealso cref="NetApiBufferSize"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetApiBufferFree(
            [In] IntPtr Buffer
            );
        #endregion
        #region NetApiBufferReallocate function
        /// <summary>
        /// The <see cref="NetApiBufferReallocate"/> function changes the size of a buffer allocated by a previous call to the <see cref="NetApiBufferAllocate"/> function.
        /// </summary>
        /// <param name="OldBuffer">Pointer to the buffer returned by a call to the <see cref="NetApiBufferAllocate"/> function.</param>
        /// <param name="NewByteCount">Specifies the new size of the buffer, in bytes.</param>
        /// <param name="NewBuffer">Receives the pointer to the reallocated buffer.</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="NERR_Success"/>.<br/>
        /// If the function fails, the return value is a system error code from the <see cref="Win32ErrorCode"/> enumeration.
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to successfully execute the ApiBuffer functions.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370306.aspx">NetApiBufferReallocate function</a></para>
        /// </remarks>
        /// <seealso cref="NetApiBufferAllocate"/>
        /// <seealso cref="NetApiBufferFree"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetApiBufferReallocate(
            [In] IntPtr OldBuffer,
            [In] int NewByteCount,
            out IntPtr NewBuffer
            );
        #endregion
        #region NetApiBufferSize function
        /// <summary>
        /// The <see cref="NetApiBufferSize"/> function returns the size, in bytes, of a buffer allocated by a call to the <see cref="NetApiBufferAllocate"/> function.
        /// </summary>
        /// <param name="Buffer">Pointer to a buffer returned by the <see cref="NetApiBufferAllocate"/> function.</param>
        /// <param name="ByteCount">Receives the size of the buffer, in bytes.</param>
        /// <returns>
        /// If the function succeeds, the return value is <see cref="NERR_Success"/>.<br/>
        /// If the function fails, the return value is a system error code from the <see cref="Win32ErrorCode"/> enumeration.
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to successfully execute the ApiBuffer functions.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370307.aspx">NetApiBufferSize function</a></para>
        /// </remarks>
        /// <seealso cref="NetApiBufferAllocate"/>
        /// <seealso cref="NetApiBufferFree"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetApiBufferSize(
            [In] IntPtr Buffer,
            out int ByteCount
            );
        #endregion
        #region NetAuditClear function
        // The NetAuditClear function is obsolete. It is included for compatibility with 16-bit versions of Windows. Other applications should use event logging. ( https://msdn.microsoft.com/en-us/library/aa363652.aspx )
        #endregion
        #region NetAuditRead function
        // The NetAuditRead function is obsolete. It is included for compatibility with 16-bit versions of Windows. Other applications should use event logging. ( https://msdn.microsoft.com/en-us/library/aa363652.aspx )
        #endregion
        #region NetAuditWrite function
        // The NetAuditWrite function is obsolete. It is included for compatibility with 16-bit versions of Windows. Other applications should use event logging. ( https://msdn.microsoft.com/en-us/library/aa363652.aspx )
        #endregion
        #region NetConfigGet
        // The NetConfigGet function is obsolete. It is included for compatibility with 16-bit versions of Windows. Other applications should use the registry. ( https://msdn.microsoft.com/en-us/library/ms724871.aspx )
        #endregion
        #region NetConfigGetAll
        // The NetConfigGetAll function is obsolete. It is included for compatibility with 16-bit versions of Windows. Other applications should use the registry. ( https://msdn.microsoft.com/en-us/library/ms724871.aspx )
        #endregion
        #region NetConfigSet
        // The NetConfigSet function is obsolete. It is included for compatibility with 16-bit versions of Windows. Other applications should use the registry. ( https://msdn.microsoft.com/en-us/library/ms724871.aspx )
        #endregion
    }
}
