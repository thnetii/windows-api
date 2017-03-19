using Microsoft.Win32.WinApi.WinError;
using System;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.JOB_FLAGS;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.GROUP_INFO_PARMNUM;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LG_INCLUDE_FLAG;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LOCALGROUP_INFO_PARMNUM;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NETSETUP_NAME_TYPE;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NETSETUP_OPTIONS;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NETSETUP_PROVISION_FLAGS;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NET_VALIDATE_PASSWORD_TYPE;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.SV_TYPE_FLAGS;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.SVTI2_FLAGS;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.USER_FLAGS;
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
        #region NetCreateProvisioningPackage function
        /// <summary>
        /// The <see cref="NetCreateProvisioningPackage"/> function creates a provisioning package that provisions a computer account for later use in an offline domain join operation. The package may also contain information about certificates and policies to add to the machine during provisioning.
        /// </summary>
        /// <param name="pProvisioningParams">A <see cref="NETSETUP_PROVISIONING_PARAMS"/> structure that contains information about the provisioning package.</param>
        /// <param name="pPackageBinData">
        /// A pointer that will receive the package required by <see cref="NetRequestOfflineDomainJoin"/> function to complete an offline domain join, if the <see cref="NetProvisionComputerAccount"/> function completes successfully. The data is returned as an opaque binary buffer which may be passed to <see cref="NetRequestOfflineDomainJoin"/> function. 
        /// <para>Specifying this parameter requires <paramref name="pPackageTextData"/> to be omitted or set to <see cref="IntPtr.Zero"/>.</para>
        /// </param>
        /// <param name="pdwPackageBinDataSize">A variable that receives the size, in bytes, of the buffer returned in the <paramref name="pPackageBinData"/> parameter.</param>
        /// <param name="pPackageTextData">A pointer value that must be omitted or set to <see cref="IntPtr.Zero"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access is denied. This error is returned if the caller does not have sufficient privileges to complete the operation. </description>
        /// <term><see cref="ERROR_INVALID_DOMAIN_ROLE"/></term><description>This operation is only allowed for the Primary Domain Controller of the domain. This error is returned if a domain controller name was specified in the <see cref="NETSETUP_PROVISIONING_PARAMS.lpDcName"/> of the <see cref="NETSETUP_PROVISIONING_PARAMS"/> struct pointed to by the <paramref name="pProvisioningParams"/> parameter, but the computer specified could not be validated as a domain controller for the target domain specified in the <see cref="NETSETUP_PROVISIONING_PARAMS.lpDomain"/> of the <see cref="NETSETUP_PROVISIONING_PARAMS"/>.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is also returned if both the <paramref name="pProvisioningParams"/> parameter is <c>null</c>. This error is also returned if the <see cref="NETSETUP_PROVISIONING_PARAMS.lpDomain"/> or <see cref="NETSETUP_PROVISIONING_PARAMS.lpMachineName"/> member of the <see cref="NETSETUP_PROVISIONING_PARAMS"/> struct pointed to by the <paramref name="pProvisioningParams"/> parameter is <c>null</c>. </description>
        /// <term><see cref="ERROR_NO_SUCH_DOMAIN"/></term><description>The specified domain did not exist.</description>
        /// <term><see cref="Win32ErrorCode.ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if the <see cref="NETSETUP_PROVISIONING_PARAMS.lpMachineAccountOU"/> member was specified in the <see cref="NETSETUP_PROVISIONING_PARAMS"/> struct pointed to by the <paramref name="pProvisioningParams"/> parameter and the domain controller is running on an earlier versions of Windows that does not support this parameter.</description>
        /// <term><see cref="NERR_DS8DCRequired"/></term><description>The specified domain controller does not meet the version requirement for this operation.</description>
        /// <term><see cref="NERR_LDAPCapableDCRequired"/></term><description>This operation requires a domain controller which supports LDAP.</description>
        /// <term><see cref="NERR_UserExists"/></term><description>The account already exists in the domain and the <see cref="NETSETUP_PROVISION_REUSE_ACCOUNT"/> bit was not specified in the <see cref="NETSETUP_PROVISIONING_PARAMS.dwProvisionOptions"/> member of the <see cref="NETSETUP_PROVISIONING_PARAMS"/> struct pointed to by the <paramref name="pProvisioningParams"/> parameter.</description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term><description>The Workstation service has not been started.</description>
        /// <term><see cref="RPC_S_CALL_IN_PROGRESS"/></term><description>A remote procedure call is already in progress for this thread.</description>
        /// <term><see cref="RPC_S_PROTSEQ_NOT_SUPPORTED"/></term><description>The remote procedure call protocol sequence is not supported.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetCreateProvisioningPackage"/> function is supported on Windows 8 and Windows Server 2012 for offline join operations. For Windows 7, use the <see cref="NetProvisionComputerAccount"/> function.</para>
        /// <para>The <see cref="NetCreateProvisioningPackage"/> function is used to provision a computer account for later use in an offline domain join operation using the <see cref="NetRequestProvisioningPackageInstall"/> function.</para>
        /// <para>
        /// The offline domain join scenario uses two functions: 
        /// <list type="bullet">
        /// <item><see cref="NetCreateProvisioningPackage"/> is a provisioning function that is first called to perform the network operations necessary to create and configure the computer object in Active Directory. The output from the <see cref="NetCreateProvisioningPackage"/> is a package used for the next step. </item>
        /// <item><see cref="NetRequestProvisioningPackageInstall"/>, an image initialization function, is called to inject the output from the <see cref="NetCreateProvisioningPackage"/> provisioning function into a Windows operating system image for use during pre-installation and post-installation</item>
        /// </list>
        /// </para>
        /// <para>
        /// Changes to Windows initialization code will detect this saved state and affect the local-only portion of domain join.<br/>
        /// When the <paramref name="pPackageBinData"/> and <paramref name="pdwPackageBinDataSize"/> out parameters are used, set the <paramref name="pPackageTextData"/> out pointer to <see cref="IntPtr.Zero"/>.
        /// </para>
        /// <para>
        /// The <paramref name="pProvisioningParams"/> parameter specifies data to include in the provisioning package. The package includes information relevant to the domain join, and it can also include information about policies and certificates to install on the machine. The provisioning package can be used in four ways:
        /// <list type="bullet">
        /// <item>Domain join</item>
        /// <item>Domain join and installation of certificates</item>
        /// <item>Domain join and installation of policies</item>
        /// <item>Domain join and installation of certificates and policies</item>
        /// </list>
        /// </para>
        /// <para>The <see cref="NetCreateProvisioningPackage"/> function creates or reuses the machine account in the domain, collects all necessary metadata and returns it in a package. The package can be consumed by the offline domain join request operation supplying all the necessary input to complete the domain join during first boot without any network operations (local state updates only). </para>
        /// <para><note type="security">The package returned by the <see cref="NetCreateProvisioningPackage"/> function contains very sensitive data. It should be treated just as securely as a plaintext password. The package contains the machine account password and other information about the domain, including the domain name, the name of a domain controller, and the security ID (SID) of the domain. If the package is being transported physically or over the network, care must be taken to transport it securely. The design makes no provisions for securing this data. This problem exists today with unattended setup answer files which can carry a number of secrets including domain user passwords. The caller must secure the package. Solutions to this problem are varied. As an example, a pre-exchanged key could be used to encrypt a session between the consumer and provisioning entity enabling a secure transfer of the package.</note></para>
        /// <para>The package returned in the <paramref name="pPackageBinData"/> parameter by the <see cref="NetCreateProvisioningPackage"/> function is versioned to allow interoperability and serviceability scenarios between different versions of Windows (such as joining a client, provisioning a machine, and using a domain controller). A package created on Windows 8 or Windows Server 2012 can be used Windows 7 or Windows Server 2008 R2, however only domain join information will take effect (certificates and policies are not supported). The offline join scenario currently does not limit the lifetime of the package returned by the <see cref="NetCreateProvisioningPackage"/> function.</para>
        /// <para>
        /// For offline domain joins, the access check performed depends on the configuration of the domain. Computer account creation is enabled using three methods:
        /// <list type="bullet">
        /// <item>Domain administrators have rights to create computer accounts.</item>
        /// <item>The SD on a container can delegate the rights to create computer accounts.</item>
        /// <item>By default, authenticated users may create computer accounts by privilege. Authenticated users are limited to creating a limited number of accounts that is specified as a quota on the domain (the default value is 10). For more information, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152785">ms-DS-MachineAccountQuota</a> attribute in the Active Directory schema.</item>
        /// </list>
        /// </para>
        /// <para>The <see cref="NetCreateProvisioningPackage"/> function works only with a writable domain controller and does not function against a read-only domain controller. Once provisioning is done against a writable domain controller and the account is replicated to a read-only domain controller, the other portions of the offline domain join operation do not require access to a domain controller.</para>
        /// <para>If the <see cref="NetCreateProvisioningPackage"/> function is successful, the pointer in the <paramref name="pPackageBinData"/> parameter is returned with the serialized data for use in an offline join operation. </para>
        /// <para>All phases of the provisioning process append to a NetSetup.log file on the local computer. The provisoning process can include up to three different computers: the computer where the provisioning package is created, the computer that requests the installation of the package, and the computer where the package is installed. There will be <c>NetSetup.log</c> file information stored on all three computers according to the operation performed. Reviewing the contents of these files is the most common means of troubleshooting online and offline provisioning errors. Provisioning operations undertaken by admins are logged to the <c>NetSetup.log</c> file in the <c>%WINDIR%\Debug</c>. Provisioning operations performed by non-admins are logged to the <c>NetSetup.log</c> file in the <c>%USERPROFILE%\Debug</c> folder.</para>
        /// <para>For more information on offline domain join operations, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152786">Offline Domain Join Step-by-Step Guide</a>.</para>
        /// <para>Joining (and unjoining) a computer to a domain using <see cref="NetJoinDomain"/> and <see cref="NetUnjoinDomain"/> is performed only by a member of the Administrators local group on the target computer. Note that the domain administrator can set additional requirements for joining the domain using delegation and assignment of privileges.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 8 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2012 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/hh706770.aspx">NetCreateProvisioningPackage function</a></para>
        /// </remarks>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetRequestOfflineDomainJoin"/>
        /// <seealso cref="NetRequestProvisioningPackageInstall"/>
        /// <seealso cref="NetUnjoinDomain"/>
        /// <seealso cref="NETSETUP_PROVISIONING_PARAMS"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetCreateProvisioningPackage(
            [In, MarshalAs(UnmanagedType.LPStruct)] NETSETUP_PROVISIONING_PARAMS pProvisioningParams,
            out NetRequestOfflineDomainJoinBinDataBuffer pPackageBinData,
            out int pdwPackageBinDataSize,
            [Optional] IntPtr pPackageTextData
            );
        /// <summary>
        /// The <see cref="NetCreateProvisioningPackage"/> function creates a provisioning package that provisions a computer account for later use in an offline domain join operation. The package may also contain information about certificates and policies to add to the machine during provisioning.
        /// </summary>
        /// <param name="pProvisioningParams">A <see cref="NETSETUP_PROVISIONING_PARAMS"/> structure that contains information about the provisioning package.</param>
        /// <param name="pPackageBinData">A pointer value that must be omitted or set to <see cref="IntPtr.Zero"/>.</param>
        /// <param name="pdwPackageBinDataSize">A pointer value that must be omitted or set to <see cref="IntPtr.Zero"/>.</param>
        /// <param name="pPackageTextData">
        /// A variable that will receive the package required by <see cref="NetRequestOfflineDomainJoin"/> function to complete an offline domain join, if the <see cref="NetProvisionComputerAccount"/> function completes successfully. The data is returned in string form for embedding in an unattended setup answer file. 
        /// <para>Specifying this parameter requires <paramref name="pPackageBinData"/> and <paramref name="pdwPackageBinDataSize"/> to be omitted or set to <see cref="IntPtr.Zero"/>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access is denied. This error is returned if the caller does not have sufficient privileges to complete the operation. </description>
        /// <term><see cref="ERROR_INVALID_DOMAIN_ROLE"/></term><description>This operation is only allowed for the Primary Domain Controller of the domain. This error is returned if a domain controller name was specified in the <see cref="NETSETUP_PROVISIONING_PARAMS.lpDcName"/> of the <see cref="NETSETUP_PROVISIONING_PARAMS"/> struct pointed to by the <paramref name="pProvisioningParams"/> parameter, but the computer specified could not be validated as a domain controller for the target domain specified in the <see cref="NETSETUP_PROVISIONING_PARAMS.lpDomain"/> of the <see cref="NETSETUP_PROVISIONING_PARAMS"/>.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is also returned if both the <paramref name="pProvisioningParams"/> parameter is <c>null</c>. This error is also returned if the <see cref="NETSETUP_PROVISIONING_PARAMS.lpDomain"/> or <see cref="NETSETUP_PROVISIONING_PARAMS.lpMachineName"/> member of the <see cref="NETSETUP_PROVISIONING_PARAMS"/> struct pointed to by the <paramref name="pProvisioningParams"/> parameter is <c>null</c>. </description>
        /// <term><see cref="ERROR_NO_SUCH_DOMAIN"/></term><description>The specified domain did not exist.</description>
        /// <term><see cref="Win32ErrorCode.ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if the <see cref="NETSETUP_PROVISIONING_PARAMS.lpMachineAccountOU"/> member was specified in the <see cref="NETSETUP_PROVISIONING_PARAMS"/> struct pointed to by the <paramref name="pProvisioningParams"/> parameter and the domain controller is running on an earlier versions of Windows that does not support this parameter.</description>
        /// <term><see cref="NERR_DS8DCRequired"/></term><description>The specified domain controller does not meet the version requirement for this operation.</description>
        /// <term><see cref="NERR_LDAPCapableDCRequired"/></term><description>This operation requires a domain controller which supports LDAP.</description>
        /// <term><see cref="NERR_UserExists"/></term><description>The account already exists in the domain and the <see cref="NETSETUP_PROVISION_REUSE_ACCOUNT"/> bit was not specified in the <see cref="NETSETUP_PROVISIONING_PARAMS.dwProvisionOptions"/> member of the <see cref="NETSETUP_PROVISIONING_PARAMS"/> struct pointed to by the <paramref name="pProvisioningParams"/> parameter.</description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term><description>The Workstation service has not been started.</description>
        /// <term><see cref="RPC_S_CALL_IN_PROGRESS"/></term><description>A remote procedure call is already in progress for this thread.</description>
        /// <term><see cref="RPC_S_PROTSEQ_NOT_SUPPORTED"/></term><description>The remote procedure call protocol sequence is not supported.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetCreateProvisioningPackage"/> function is supported on Windows 8 and Windows Server 2012 for offline join operations. For Windows 7, use the <see cref="NetProvisionComputerAccount"/> function.</para>
        /// <para>The <see cref="NetCreateProvisioningPackage"/> function is used to provision a computer account for later use in an offline domain join operation using the <see cref="NetRequestProvisioningPackageInstall"/> function.</para>
        /// <para>
        /// The offline domain join scenario uses two functions: 
        /// <list type="bullet">
        /// <item><see cref="NetCreateProvisioningPackage"/> is a provisioning function that is first called to perform the network operations necessary to create and configure the computer object in Active Directory. The output from the <see cref="NetCreateProvisioningPackage"/> is a package used for the next step. </item>
        /// <item><see cref="NetRequestProvisioningPackageInstall"/>, an image initialization function, is called to inject the output from the <see cref="NetCreateProvisioningPackage"/> provisioning function into a Windows operating system image for use during pre-installation and post-installation</item>
        /// </list>
        /// </para>
        /// <para>
        /// Changes to Windows initialization code will detect this saved state and affect the local-only portion of domain join.<br/>
        /// When <paramref name="pPackageTextData"/> is used, set the <paramref name="pPackageBinData"/> and <paramref name="pdwPackageBinDataSize"/> pointers to <see cref="IntPtr.Zero"/> or omit them.
        /// </para>
        /// <para>
        /// The <paramref name="pProvisioningParams"/> parameter specifies data to include in the provisioning package. The package includes information relevant to the domain join, and it can also include information about policies and certificates to install on the machine. The provisioning package can be used in four ways:
        /// <list type="bullet">
        /// <item>Domain join</item>
        /// <item>Domain join and installation of certificates</item>
        /// <item>Domain join and installation of policies</item>
        /// <item>Domain join and installation of certificates and policies</item>
        /// </list>
        /// </para>
        /// <para>The <see cref="NetCreateProvisioningPackage"/> function creates or reuses the machine account in the domain, collects all necessary metadata and returns it in a package. The package can be consumed by the offline domain join request operation supplying all the necessary input to complete the domain join during first boot without any network operations (local state updates only). </para>
        /// <para><note type="security">The package returned by the <see cref="NetCreateProvisioningPackage"/> function contains very sensitive data. It should be treated just as securely as a plaintext password. The package contains the machine account password and other information about the domain, including the domain name, the name of a domain controller, and the security ID (SID) of the domain. If the package is being transported physically or over the network, care must be taken to transport it securely. The design makes no provisions for securing this data. This problem exists today with unattended setup answer files which can carry a number of secrets including domain user passwords. The caller must secure the package. Solutions to this problem are varied. As an example, a pre-exchanged key could be used to encrypt a session between the consumer and provisioning entity enabling a secure transfer of the package.</note></para>
        /// <para>
        /// For offline domain joins, the access check performed depends on the configuration of the domain. Computer account creation is enabled using three methods:
        /// <list type="bullet">
        /// <item>Domain administrators have rights to create computer accounts.</item>
        /// <item>The SD on a container can delegate the rights to create computer accounts.</item>
        /// <item>By default, authenticated users may create computer accounts by privilege. Authenticated users are limited to creating a limited number of accounts that is specified as a quota on the domain (the default value is 10). For more information, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152785">ms-DS-MachineAccountQuota</a> attribute in the Active Directory schema.</item>
        /// </list>
        /// </para>
        /// <para>The <see cref="NetCreateProvisioningPackage"/> function works only with a writable domain controller and does not function against a read-only domain controller. Once provisioning is done against a writable domain controller and the account is replicated to a read-only domain controller, the other portions of the offline domain join operation do not require access to a domain controller.</para>
        /// <para>If the <see cref="NetCreateProvisioningPackage"/> function is successful, the <paramref name="pPackageTextData"/> parameter is returned with the serialized data for use in an offline join operation. </para>
        /// <para>All phases of the provisioning process append to a NetSetup.log file on the local computer. The provisoning process can include up to three different computers: the computer where the provisioning package is created, the computer that requests the installation of the package, and the computer where the package is installed. There will be <c>NetSetup.log</c> file information stored on all three computers according to the operation performed. Reviewing the contents of these files is the most common means of troubleshooting online and offline provisioning errors. Provisioning operations undertaken by admins are logged to the <c>NetSetup.log</c> file in the <c>%WINDIR%\Debug</c>. Provisioning operations performed by non-admins are logged to the <c>NetSetup.log</c> file in the <c>%USERPROFILE%\Debug</c> folder.</para>
        /// <para>For more information on offline domain join operations, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152786">Offline Domain Join Step-by-Step Guide</a>.</para>
        /// <para>Joining (and unjoining) a computer to a domain using <see cref="NetJoinDomain"/> and <see cref="NetUnjoinDomain"/> is performed only by a member of the Administrators local group on the target computer. Note that the domain administrator can set additional requirements for joining the domain using delegation and assignment of privileges.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 8 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2012 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/hh706770.aspx">NetCreateProvisioningPackage function</a></para>
        /// </remarks>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetRequestOfflineDomainJoin"/>
        /// <seealso cref="NetRequestProvisioningPackageInstall"/>
        /// <seealso cref="NetUnjoinDomain"/>
        /// <seealso cref="NETSETUP_PROVISIONING_PARAMS"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetCreateProvisioningPackage(
            [In, MarshalAs(UnmanagedType.LPStruct)] NETSETUP_PROVISIONING_PARAMS pProvisioningParams,
            [Optional] IntPtr pPackageBinData,
            [Optional] IntPtr pdwPackageBinDataSize,
            out WideStringZeroTerminatedAnySafeHandle pPackageTextData
            );
        #endregion
        #region NetEnumerateComputerNames function
        /// <summary>
        /// The <see cref="NetEnumerateComputerNames"/> function enumerates names for the specified computer.
        /// </summary>
        /// <param name="Server">A string that specifies the name of the computer on which to execute this function. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="NameType">The type of the name queried.</param>
        /// <param name="Reserved">Reserved for future use. This parameter should be <c>0</c> (zero).</param>
        /// <param name="EntryCount">An <see cref="int"/> variable that receives the number of names returned in the buffer pointed to by the <paramref name="ComputerNames"/> parameter if the function succeeds.</param>
        /// <param name="ComputerNames">
        /// A variable that receives a Net API Buffer Handle containing the computer names that match the computer type name specified in the <paramref name="NameType"/> parameter. 
        /// <para>When the application no longer needs this buffer, the memory should be released back to the system by wrapping the handle in a <c>using</c> block, or by calling the <see cref="SafeHandle.Dispose()"/> method directly.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access is denied. This error is returned if the caller was not a member of the Administrators local group on the target computer.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. </description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Not enough memory is available to process this command.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if the target computer specified in the <paramref name="Server"/> parameter on which this function executes is running on Windows 2000 and earlier. </description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term><description>The Workstation service has not been started.</description>
        /// <term><see cref="RPC_S_CALL_IN_PROGRESS"/></term><description>A remote procedure call is already in progress for this thread.</description>
        /// <term><see cref="RPC_S_PROTSEQ_NOT_SUPPORTED"/></term><description>The remote procedure call protocol sequence is not supported.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetEnumerateComputerNames"/> function is supported on Windows Vista and later. </para>
        /// <para>The <see cref="NetEnumerateComputerNames"/> function is used to request the names a computer currently has configured. </para>
        /// <para>The <see cref="NetEnumerateComputerNames"/> function requires that the caller is a member of the Administrators local group on the target computer.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 8 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2012 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dd877207.aspx">NetEnumerateComputerNames function</a></para>
        /// </remarks>
        /// <seealso cref="NetAddAlternateComputerName"/>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetRemoveAlternateComputerName"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetSetPrimaryComputerName"/>
        /// <seealso cref="NetUnjoinDomain"/>
        /// <seealso cref="SetComputerNameEx"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetEnumerateComputerNames(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string Server,
            [In] NET_COMPUTER_NAME_TYPE NameType,
            [In] int Reserved,
            out int EntryCount,
            out NetApiWideStringZeroTerminatedArrayBufferHandle ComputerNames
            );
        #endregion
        #region NetErrorLogClear
        // The NetErrorLogClear function is obsolete. It is included for compatibility with 16-bit versions of Windows. Other applications should use event logging. ( https://msdn.microsoft.com/en-us/library/aa363652.aspx )
        #endregion
        #region NetErrorLogRead
        // The NetErrorLogRead function is obsolete. It is included for compatibility with 16-bit versions of Windows. Other applications should use event logging. ( https://msdn.microsoft.com/en-us/library/aa363652.aspx )
        #endregion
        #region NetErrorLogWrite
        // The NetErrorLogWrite function is obsolete. It is included for compatibility with 16-bit versions of Windows. Other applications should use event logging. ( https://msdn.microsoft.com/en-us/library/aa363652.aspx )
        #endregion
        #region NetFreeAadJoinInformation function
        /// <summary>
        /// Frees the memory allocated for the specified <see cref="DSREG_JOIN_INFO"/> structure, which contains join information for a tenant and which you retrieved by calling the <see cref="NetGetAadJoinInformation"/> function.
        /// </summary>
        /// <param name="pJoinInfo">Pointer to the <see cref="DSREG_JOIN_INFO"/> structure for which you want to free the memory. </param>
        /// <remarks>
        /// <para><strong>Minimum supported client</strong>: Windows 10 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2016 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/mt481426.aspx">NetFreeAadJoinInformation function</a></para>
        /// </remarks>
        /// <seealso cref="NetGetAadJoinInformation"/>
        /// <seealso cref="DSREG_JOIN_INFO"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern void NetFreeAadJoinInformation(
            [In, Optional] IntPtr pJoinInfo
            );
        #endregion
        #region NetGetAadJoinInformation function
        /// <summary>
        /// Retrieves the join information for the specified tenant. This function examines the join information for Microsoft Azure Active Directory and the work account that the current user added.
        /// </summary>
        /// <param name="pcszTenantId">
        /// <para>The tenant identifier for the joined account. If the device is not joined to Azure Active Directory (Azure AD), and the user currently logged into Windows added no Azure AD work accounts for the specified tenant, the buffer that the <paramref name="ppJoinInfo"/> parameter points to is set to <c>null</c>.</para>
        /// <para>
        /// If the specified tenant ID is <c>null</c> or empty, <paramref name="ppJoinInfo"/> is set to the default join account information, or <c>null</c> if the device is not joined to Azure AD and the current user added no Azure AD work accounts. The default join account is one of the following:
        /// <list type="bullet">
        /// <item>The Azure AD account, if the device is joined to Azure AD. </item>
        /// <item>The Azure AD work account that the current user added, if the device is not joined to Azure AD, but the current user added a single Azure AD work account. </item>
        /// <item>Any of the Azure AD work accounts that the current user added, if the device is not joined to Azure AD, but the current user added multiple Azure AD work accounts. The algorithm for selecting one of the work accounts is not specified.</item>
        /// </list>
        /// </para>
        /// </param>
        /// <param name="ppJoinInfo">The join information for the tenant that the <paramref name="pcszTenantId"/> parameter specifies. If this parameter receives <c>null</c>, the device is not joined to Azure AD and the current user added no Azure AD work accounts.</param>
        /// <returns>If this function succeeds, it returns <see cref="S_OK"/>. Otherwise, it returns an <see cref="HRESULT"/> error code.</returns>
        /// <remarks>
        /// <para><strong>Minimum supported client</strong>: Windows 10 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2016 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/mt481427.aspx">NetGetAadJoinInformation function</a></para>
        /// </remarks>
        /// <seealso cref="NetFreeAadJoinInformation"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Error)]
        public static extern HRESULT NetGetAadJoinInformation(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string pcszTenantId,
            out NetAadJoinInformationBuffer ppJoinInfo
            );
        #endregion
        #region NetGetAnyDCName function
        /// <summary>
        /// <para>The <see cref="NetGetAnyDCName"/> function returns the name of any domain controller (DC) for a domain that is directly trusted by the specified server.</para>
        /// <para>Applications that support DNS-style names should call the <see cref="DsGetDcName"/> function. This function can locate any DC in any domain, whether or not the domain is directly trusted by the specified server.</para>
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. For more information, see the Remarks section. </param>
        /// <param name="domainname">A string that specifies the name of the domain. If this parameter is <c>null</c>, the name of the domain controller for the primary domain is used. For more information, see the Remarks section.</param>
        /// <param name="bufptr">A variable to a buffer that receives a string that specifies the server name of a domain controller for the domain. The server name is prefixed by \\. This buffer is allocated by the system and must be freed by wrapping the returned handle in a <c>using</c> block, or by calling the <see cref="SafeHandle.Dispose()"/> method directly.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_NO_LOGON_SERVERS"/></term><description>No domain controllers could be found.</description>
        /// <term><see cref="ERROR_NO_SUCH_DOMAIN"/></term><description>The specified domain is not a trusted domain.</description>
        /// <term><see cref="ERROR_NO_TRUST_LSA_SECRET"/></term><description>The client side of the trust relationship is broken.</description>
        /// <term><see cref="ERROR_NO_TRUST_SAM_ACCOUNT"/></term><description>The server side of the trust relationship is broken or the password is broken.</description>
        /// <term><see cref="ERROR_DOMAIN_TRUST_INCONSISTENT"/></term><description>The server that responded is not a proper domain controller of the specified domain.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to successfully execute the <see cref="NetGetAnyDCName"/> function.</para>
        /// <para>If <paramref name="servername"/> specifies a stand-alone workstation or a stand-alone server, no <paramref name="domainname"/> is valid.</para>
        /// <para>If <paramref name="servername"/> specifies a workstation that is a member of a domain, or a server that is a member of a domain, the <paramref name="domainname"/> must be in the same domain as <paramref name="servername"/>.</para>
        /// <para>If <paramref name="servername"/> specifies a domain controller, the <paramref name="domainname"/> must be one of the domains trusted by the domain for which the server is a controller. The domain controller that this call finds has been operational at least once during this call.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370419.aspx">NetGetAnyDCName function</a></para>
        /// </remarks>
        /// <seealso cref="DsGetDcName"/>
        /// <seealso cref="NetGetDCName"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGetAnyDCName(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string domainname,
            out NetApiWideStringZeroTerminatedBufferHandle bufptr
            );
        #endregion
        #region NetGetDCName function
        /// <summary>
        /// <para>The <see cref="NetGetDCName"/> function returns the name of the primary domain controller (PDC). It does not return the name of the backup domain controller (BDC) for the specified domain. Also, you cannot remote this function to a non-PDC server.</para>
        /// <para>Applications that support DNS-style names should call the <see cref="DsGetDcName"/> function. Domain controllers in this type of environment have a multi-master directory replication relationship. Therefore, it may be advantageous for your application to use a DC that is not the PDC. You can call the <see cref="DsGetDcName"/> function to locate any DC in the domain; <see cref="NetGetDCName"/> returns only the name of the PDC.</para>
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. For more information, see the Remarks section. </param>
        /// <param name="domainname">A string that specifies the name of the domain. If this parameter is <c>null</c>, the name of the domain controller for the primary domain is used. For more information, see the Remarks section.</param>
        /// <param name="bufptr">A variable to a buffer that receives a string that specifies the server name of a domain controller for the domain. The server name is prefixed by \\. This buffer is allocated by the system and must be freed by wrapping the returned handle in a <c>using</c> block, or by calling the <see cref="SafeHandle.Dispose()"/> method directly.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="NERR_DCNotFound"/></term><description>Could not find the domain controller for the domain specified in the <paramref name="domainname"/> parameter.</description>
        /// <term><see cref="ERROR_BAD_NETPATH"/></term><description>The network path was not found. This error is returned if the computer specified in the <paramref name="servername"/> parameter could not be found.</description>
        /// <term><see cref="ERROR_INVALID_NAME"/></term><description>The name syntax is incorrect. This error is returned if the name specified in the <paramref name="servername"/> parameter contains illegal characters. </description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. </description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// No special group membership is required to successfully execute the <see cref="NetGetDCName"/> function.
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370420.aspx">NetGetDCName function</a></para>
        /// </remarks>
        /// <seealso cref="DsGetDcName"/>
        /// <seealso cref="NetGetAnyDCName"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGetDCName(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string domainname,
            out NetApiWideStringZeroTerminatedBufferHandle bufptr
            );
        #endregion
        #region NetGetDisplayInformationIndex function
        /// <summary>
        /// The <see cref="NetGetDisplayInformationIndex"/> function returns the index of the first display information entry whose name begins with a specified string or whose name alphabetically follows the string. You can use this function to determine a starting index for subsequent calls to the <see cref="NetQueryDisplayInformation"/> function.
        /// </summary>
        /// <param name="ServerName">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="Level">
        /// Specifies the level of accounts to query. This parameter can be one of the following values. 
        /// <list type="bullet">
        /// <term>1</term> - <description>Query all local and global (normal) user accounts.</description>
        /// <term>2</term> - <description>Query all workstation and server user accounts.</description>
        /// <term>3</term> - <description>Query all global groups.</description>
        /// </list>
        /// </param>
        /// <param name="Prefix">A string that specifies the prefix for which to search.</param>
        /// <param name="Index">An <see cref="int"/> variable that receives the index of the requested entry.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the <paramref name="Level"/> parameter is invalid.</description>
        /// <term><see cref="ERROR_NO_MORE_ITEMS"/></term><description>There were no more items on which to operate.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits all authenticated users and members of the <a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">"Pre-Windows 2000 compatible access"</a> group to view the information. If you call this function on a member server or workstation, all authenticated users can view the information. For information about anonymous access and restricting anonymous access on these platforms, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The function only returns information to which the caller has Read access. The caller must have List Contents access to the Domain object, and Enumerate Entire SAM Domain access on the SAM Server object located in the System container.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370421.aspx">NetGetDisplayInformationIndex function</a></para>
        /// </remarks>
        /// <seealso cref="NetQueryDisplayInformation"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGetDisplayInformationIndex(
            [In, MarshalAs(UnmanagedType.LPWStr)] string ServerName,
            [In] int Level,
            [In, MarshalAs(UnmanagedType.LPWStr)] string Prefix,
            out int Index
            );
        #endregion
        #region NetGetJoinableOUs function
        /// <summary>
        /// The <see cref="NetGetJoinableOUs"/> function retrieves a list of organizational units (OUs) in which a computer account can be created.
        /// </summary>
        /// <param name="lpServer">A string that specifies the DNS or NetBIOS name of the computer on which to call the function. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="lpDomain">A string that specifies the name of the domain for which to retrieve the list of OUs that can be joined.</param>
        /// <param name="lpAccount">A string that specifies the account name to use when connecting to the domain controller. The string must specify either a domain NetBIOS name and user account (for example, "REDMOND\user") or the user principal name (UPN) of the user in the form of an Internet-style login name (for example, "someone@example.com"). If this parameter is <c>null</c>, the caller's context is used.</param>
        /// <param name="lpPassword">If the <paramref name="lpAccount"/> parameter specifies an account name, this parameter must point to the password to use when connecting to the domain controller. Otherwise, this parameter must be <c>null</c>.</param>
        /// <param name="OUCount">Receives the count of OUs returned in the list of joinable OUs.</param>
        /// <param name="OUs">A variable that receives a handle for the list of joinable OUs. This array is allocated by the system and must be freed by wrapping the handle in a <c>using</c> block, or by calling the <see cref="SafeHandle.Dispose()"/> method directly.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Not enough storage is available to process this command.</description>
        /// <term><see cref="NERR_DefaultJoinRequired"/></term><description>The destination domain controller does not support creating computer accounts in OUs.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to successfully execute the <see cref="NetGetJoinableOUs"/> function.</para>
        /// <para>For more information about organizational units, see <a href="https://msdn.microsoft.com/en-us/library/ms677281.aspx">Managing Users</a> in the Active Directory documentation.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370422.aspx">NetGetJoinableOUs function</a></para>
        /// </remarks>
        /// <seealso cref="NetGetJoinInformation"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGetJoinableOUs(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpServer,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpDomain,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpAccount,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpPassword,
            out int OUCount,
            out NetApiWideStringZeroTerminatedArrayBufferHandle OUs
            );
        #endregion
        #region NetGetJoinInformation function
        /// <summary>
        /// The <see cref="NetGetJoinInformation"/> function retrieves join status information for the specified computer.
        /// </summary>
        /// <param name="lpServer">A string that specifies the DNS or NetBIOS name of the computer on which to call the function. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="lpNameBuffer">A variable that receives the NetBIOS name of the domain or workgroup to which the computer is joined. This buffer is allocated by the system and must be freed by wrapping the handle in a <c>using</c> block, or by calling the <see cref="SafeHandle.Dispose()"/> method directly.</param>
        /// <param name="BufferType">Receives the join status of the specified computer.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Not enough storage is available to process this command.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// No special group membership is required to successfully execute the <see cref="NetGetJoinInformation"/> function.
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370423.aspx">NetGetJoinInformation function</a></para>
        /// </remarks>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGetJoinInformation(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpServer,
            out NetApiWideStringZeroTerminatedBufferHandle lpNameBuffer,
            out NETSETUP_JOIN_STATUS BufferType
            );
        #endregion
        #region NetGroupAdd function
        /// <summary>
        /// The <see cref="NetGroupAdd"/> function creates a global group in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="bullet">
        /// <term><c></c> (zero)</term> - <description>Specifies a global group name. The <paramref name="buf"/> parameter contains a reference to a <see cref="GROUP_INFO_0"/> structure.</description>
        /// <term><c>1</c></term> - <description>Specifies a global group name and a comment. The <paramref name="buf"/> parameter contains a reference to a <see cref="GROUP_INFO_1"/> structure.</description>
        /// <term><c>2</c></term> - <description>Specifies detailed information about the global group. The <paramref name="buf"/> parameter contains a reference to a <see cref="GROUP_INFO_2"/> structure. Note that on Windows XP and later, it is recommended that you use <see cref="GROUP_INFO_3"/> instead.</description>
        /// <term><c>3</c></term> - <description>Specifies detailed information about the global group. The <paramref name="buf"/> parameter contains a reference to a <see cref="GROUP_INFO_3"/> structure. <br/><strong>Windows 2000</strong>: This level is not supported.</description>
        /// </list>
        /// </param>
        /// <param name="buf">An object instance that contains the data. The type of the object must relate to the information level value specified in the <paramref name="level"/> parameter.</param>
        /// <param name="parm_err">A variable that receives the index of the first member of the global group information structure in error when <see cref="ERROR_INVALID_PARAMETER"/> is returned.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_GroupExists"/></term><description>The global group already exists.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the level parameter is invalid.</description>
        /// <term><see cref="NERR_SpeGroupOp"/></term><description>The operation is not allowed on certain special groups. These groups include user groups, admin groups, local groups, and guest groups.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the user container is used to perform the access check for this function. The caller must be able to create child objects of the group class. Typically, callers must also have write access to the entire object for calls to this function to succeed.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370424.aspx">NetGroupAdd function</a></para>
        /// </remarks>
        /// <seealso cref="GROUP_INFO_0"/>
        /// <seealso cref="NetGroupAddUser"/>
        /// <seealso cref="NetGroupDel"/>
        /// <seealso cref="NetGroupSetInfo"/>
        /// <seealso cref="NetGroupDelUser"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGroupAdd(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, DefaultParameterValue(0)] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object buf,
            out GROUP_INFO_PARMNUM parm_err
            );
        #endregion
        #region NetGroupAddUser function
        /// <summary>
        /// The <see cref="NetGroupAddUser"/> function gives an existing user account membership in an existing global group in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="GroupName">A string that specifies the name of the global group in which the user is to be given membership. For more information, see the Remarks section.</param>
        /// <param name="username">A string that specifies the name of the user to be given membership in the global group. For more information, see the Remarks section.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_SpeGroupOp"/></term><description>The operation is not allowed on certain special groups. These groups include user groups, admin groups, local groups, and guest groups.</description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user name could not be found.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The global group name could not be found.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Group object is used to perform the access check for this function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370425.aspx">NetGroupAddUser function</a></para>
        /// </remarks>
        /// <seealso cref="NetGroupAdd"/>
        /// <seealso cref="NetGroupDel"/>
        /// <seealso cref="NetGroupDelUser"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGroupAddUser(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string GroupName,
            [In, MarshalAs(UnmanagedType.LPWStr)] string username
            );
        #endregion
        #region NetGroupDel function
        /// <summary>
        /// The <see cref="NetGroupDel"/> function deletes a global group from the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="groupname">A string that specifies the name of the global group account to delete. For more information, see the Remarks section.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_SpeGroupOp"/></term><description>The operation is not allowed on certain special groups. These groups include user groups, admin groups, local groups, and guest groups.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The global group name could not be found.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Group object is used to perform the access check for this function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370426.aspx">NetGroupDel function</a></para>
        /// </remarks>
        /// <seealso cref="NetGroupAdd"/>
        /// <seealso cref="NetGroupDelUser"/>
        /// <seealso cref="NetGroupAddUser"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGroupDel(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname
            );
        #endregion
        #region NetGroupDelUser function
        /// <summary>
        /// The <see cref="NetGroupDelUser"/> function removes a user from a particular global group in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="GroupName">A string that specifies the name of the global group from which the user should be removed. For more information, see the Remarks section.</param>
        /// <param name="Username">A string that specifies the name of the user to remove from the global group. For more information, see the Remarks section.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_SpeGroupOp"/></term><description>The operation is not allowed on certain special groups. These groups include user groups, admin groups, local groups, and guest groups.</description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user name could not be found.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The global group name could not be found.</description>
        /// <term><see cref="NERR_UserNotInGroup"/></term><description>The user does not belong to this global group.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Group object is used to perform the access check for this function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370427.aspx">NetGroupDelUser function</a></para>
        /// </remarks>
        /// <seealso cref="NetGroupAddUser"/>
        /// <seealso cref="NetGroupDel"/>
        /// <seealso cref="NetGroupAdd"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGroupDelUser(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string GroupName,
            [In, MarshalAs(UnmanagedType.LPWStr)] string Username
            );
        #endregion
        #region NetGroupEnum function
        /// <summary>
        /// <para>The <see cref="NetGroupEnum"/> function retrieves information about each global group in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.</para>
        /// <para>The <see cref="NetQueryDisplayInformation"/> function provides an efficient mechanism for enumerating global groups. When possible, it is recommended that you use <see cref="NetQueryDisplayInformation"/> instead of the <see cref="NetGroupEnum"/> function.</para>
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Return the global group name. The <paramref name="bufptr"/> parameter receives an array of <see cref="GROUP_INFO_0"/> structures.</description>
        /// <term><c>1</c></term> <description>Return the global group name and a comment. The <paramref name="bufptr"/> parameter receives an array of <see cref="GROUP_INFO_1"/> structures.</description>
        /// <term><c>2</c></term> <description>Return detailed information about the global group. The <paramref name="bufptr"/> parameter receives an array of <see cref="GROUP_INFO_2"/> structures. Note that on Windows XP and later, it is recommended that you use <see cref="GROUP_INFO_3"/> instead.</description>
        /// <term><c>3</c></term> <description>Return detailed information about the global group. The <paramref name="bufptr"/> parameter receives an array of <see cref="GROUP_INFO_3"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable that receives a buffer containing the global group information structure. The format of this data depends on the value of the <paramref name="level"/> parameter. </para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <param name="prefmaxlen">Specifies the preferred maximum length of the returned data, in bytes. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required to hold the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="entriesread">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="totalentries">A variable that receives the total number of entries that could have been enumerated from the current resume position. The total number of entries is only a hint. For more information about determining the exact number of entries, see the Remarks section.</param>
        /// <param name="resume_handle">Reference to a pointer variable that contains a resume handle that is used to continue the global group enumeration. The handle should be zero on the first call and left unchanged for subsequent calls. If this parameter is omitted, no resume handle is stored.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The function only returns information to which the caller has Read access. The caller must have List Contents access to the Domain object, and Enumerate Entire SAM Domain access on the SAM Server object located in the System container. </para>
        /// <para>To determine the exact total number of groups, you must enumerate the entire tree, which can be a costly operation. To enumerate the entire tree, use the <paramref name="resume_handle"/> parameter to continue the enumeration for consecutive calls, and use the <paramref name="entriesread"/> parameter to accumulate the total number of groups. If your application is communicating with a domain controller, you should consider using the <a href="https://msdn.microsoft.com/en-us/library/aa772203.aspx">ADSI LDAP Provider</a> to retrieve this type of data more efficiently. The ADSI LDAP Provider implements a set of ADSI objects that support various ADSI interfaces. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa772235.aspx">ADSI Service Providers</a>.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370428.aspx">NetGroupEnum function</a></para>
        /// </remarks>
        /// <seealso cref="GROUP_INFO_0"/>
        /// <seealso cref="GROUP_INFO_1"/>
        /// <seealso cref="GROUP_INFO_3"/>
        /// <seealso cref="NetQueryDisplayInformation"/>
        /// <seealso cref="NetGroupGetInfo"/>
        /// <seealso cref="NetGroupGetUsers"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGroupEnum(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            out GroupInfoArrayNetApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries,
            [Optional] ref IntPtr resume_handle
            );
        #endregion
        #region NetGroupGetInfo function
        /// <summary>
        /// The <see cref="NetGroupGetInfo"/> function retrieves information about a particular global group in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="groupname">A string that specifies the name of the global group for which to retrieve information. For more information, see the Remarks section.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Return the global group name. The <paramref name="bufptr"/> parameter receives a <see cref="GROUP_INFO_0"/> structure.</description>
        /// <term><c>1</c></term> <description>Return the global group name and a comment. The <paramref name="bufptr"/> parameter receives a <see cref="GROUP_INFO_1"/> structure.</description>
        /// <term><c>2</c></term> <description>Return detailed information about the global group. The <paramref name="bufptr"/> parameter receives a <see cref="GROUP_INFO_2"/> structure. Note that on Windows XP and later, it is recommended that you use <see cref="GROUP_INFO_3"/> instead.</description>
        /// <term><c>3</c></term> <description>Return detailed information about the global group. The <paramref name="bufptr"/> parameter receives a <see cref="GROUP_INFO_3"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable that receives a buffer containing the global group information structure. The format of this data depends on the value of the <paramref name="level"/> parameter. </para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The global group name could not be found.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Group object is used to perform the access check for this function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370429.aspx">NetGroupGetInfo function</a></para>
        /// </remarks>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGroupGetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname,
            [In] int level,
            out GroupInfoNetApiBufferHandle bufptr
            );
        #endregion
        #region NetGroupGetUsers function
        /// <summary>
        /// The <see cref="NetGroupGetUsers"/> function retrieves a list of the members in a particular global group in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="groupname">A string that specifies the name of the global group for which to retrieve information. For more information, see the Remarks section.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Return the global group's member names. The <paramref name="bufptr"/> parameter receives an array of <see cref="GROUP_USERS_INFO_0"/> structures.</description>
        /// <term><c>1</c></term> <description>Return the global group's member names and attributes. The <paramref name="bufptr"/> parameter receives an array of <see cref="GROUP_USERS_INFO_1"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable that receives a buffer containing the returned data. The format of this data depends on the value of the <paramref name="level"/> parameter. </para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <param name="prefmaxlen">Specifies the preferred maximum length of the returned data, in bytes. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required to hold the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="entriesread">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="totalentries">A variable that receives the total number of entries that could have been enumerated from the current resume position. The total number of entries is only a hint. For more information about determining the exact number of entries, see the Remarks section.</param>
        /// <param name="resume_handle">Reference to a pointer variable that contains a resume handle that is used to continue the global group enumeration. The handle should be zero on the first call and left unchanged for subsequent calls. If this parameter is omitted, no resume handle is stored.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The system call level is not correct. This error is returned if the <paramref name="level"/> parameter was specified as a value other than <c>0</c> (zero) or <c>1</c>. </description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory was available to complete the operation.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The global group name specified in the <paramref name="groupname"/> parameter could not be found.</description>
        /// <term><see cref="NERR_InternalError"/></term><description>An internal error occurred.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Group object is used to perform the access check for this function.</para>
        /// <para>To grant one user membership in an existing global group, you can call the <see cref="NetGroupAddUser"/> function. To remove a user from a global group, call the <see cref="NetGroupDelUser"/> function. For information about replacing the membership of a global group, see <see cref="NetGroupSetUsers"/>.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370430.aspx">NetGroupGetUsers function</a></para>
        /// </remarks>
        /// <seealso cref="GROUP_USERS_INFO_0"/>
        /// <seealso cref="GROUP_USERS_INFO_1"/>
        /// <seealso cref="NetGroupSetUsers"/>
        /// <seealso cref="NetUserGetGroups"/>
        /// <seealso cref="NetGroupAddUser"/>
        /// <seealso cref="NetGroupDelUser"/>
        /// <seealso cref="NetQueryDisplayInformation"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGroupGetUsers(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname,
            [In] int level,
            out GroupUsersInfoArrayNetApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries,
            [Optional] ref IntPtr resume_handle
            );
        #endregion
        #region NetGroupSetInfo function
        /// <summary>
        /// The <see cref="NetGroupSetInfo"/> function sets the parameters of a global group in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="groupname">A string that specifies the name of the global group for which to set information. For more information, see the Remarks section.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c></c></term> <description>Specifies a global group name. The <paramref name="buf"/> parameter is a <see cref="GROUP_INFO_0"/> structure.</description>
        /// <term><c></c></term> <description>Specifies a global group name and a comment. The <paramref name="buf"/> parameter is a <see cref="GROUP_INFO_1"/> structure.</description>
        /// <term><c></c></term> <description>Specifies detailed information about the global group. The <paramref name="buf"/> parameter is a <see cref="GROUP_INFO_2"/> structure. Note that on Windows XP and later, it is recommended that you use <see cref="GROUP_INFO_3"/> instead.</description>
        /// <term><c></c></term> <description>Specifies detailed information about the global group. The <paramref name="buf"/> parameter is a <see cref="GROUP_INFO_3"/> structure.</description>
        /// <term><c></c></term> <description>Specifies a comment only about the global group. The <paramref name="buf"/> parameter is a <see cref="GROUP_INFO_1002"/> structure.</description>
        /// <term><c></c></term> <description>Specifies global group attributes. The <paramref name="buf"/> parameter is a <see cref="GROUP_INFO_1005"/> structure.</description>
        /// </list>
        /// For more information, see the Remarks section.
        /// </param>
        /// <param name="buf">The format of this data depends on the value of the <paramref name="level"/> parameter.</param>
        /// <param name="parm_err">A variable that receives the index of the first member of the group information structure in error following an <see cref="ERROR_INVALID_PARAMETER"/> error code. If this parameter is omitted, the index is not returned on error.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>One of the function parameters is invalid. For more information, see the Remarks section.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The global group name could not be found.</description>
        /// <term><see cref="NERR_SpeGroupOp"/></term><description>The operation is not allowed on certain special groups. These groups include user groups, admin groups, local groups, and guest groups.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Group object is used to perform the access check for this function. Typically, callers must have write access to the entire object for calls to this function to succeed.</para>
        /// <para>The correct way to set the new name of a global group is to call the <see cref="NetGroupSetInfo"/> function, using a <see cref="GROUP_INFO_0"/> structure. Specify the new value in the <see cref="GROUP_INFO_0.grpi0_name"/> member. If you use a different information level, the new name value is ignored.</para>
        /// <para>
        /// If the <see cref="NetGroupSetInfo"/> function returns <see cref="ERROR_INVALID_PARAMETER"/>, you can use the <paramref name="parm_err"/> parameter to indicate the first member of the group information structure that is invalid. (A group information structure begins with <strong>GROUP_INFO_</strong> and its format is specified by the <paramref name="level"/> parameter.) The following table lists the values that can be returned in the <paramref name="parm_err"/> parameter and the corresponding structure member that is in error. (The prefix <var>grpi*_</var> indicates that the member can begin with multiple prefixes, for example, <var>grpi1_</var> or <var>grpi2_</var>.)
        /// <list type="table">
        /// <listheader><term>Value</term><description>Member</description></listheader>
        /// <term><see cref="GROUP_NAME_PARMNUM"/></term><description><var>grpi*_name</var></description>
        /// <term><see cref="GROUP_COMMENT_PARMNUM"/></term><description><var>grpi*_comment</var></description>
        /// <term><see cref="GROUP_ATTRIBUTES_PARMNUM"/></term><description><var>grpi*_attributes</var></description>
        /// </list>
        /// </para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370431.aspx">NetGroupSetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="GROUP_INFO_0"/>
        /// <seealso cref="GROUP_INFO_1"/>
        /// <seealso cref="GROUP_INFO_3"/>
        /// <seealso cref="GROUP_INFO_1002"/>
        /// <seealso cref="GROUP_INFO_1005"/>
        /// <seealso cref="NetGroupGetInfo"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGroupSetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object buf,
            [Optional] out GROUP_INFO_PARMNUM parm_err
            );
        #endregion
        #region NetGroupSetUsers function
        /// <summary>
        /// The <see cref="NetGroupSetUsers"/> function sets the membership for the specified global group. Each user you specify is enrolled as a member of the global group. Users you do not specify, but who are currently members of the global group, will have their membership revoked.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="groupname">A string that specifies the name of the global group of interest. For more information, see the Remarks section.</param>
        /// <param name="level">
        /// The information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>The <paramref name="buf"/> parameter is an array of <see cref="GROUP_USERS_INFO_0"/> structures that specify user names.</description>
        /// <term><c>1</c></term> <description>The <paramref name="buf"/> parameter is an array of <see cref="GROUP_USERS_INFO_1"/> structures that specify user names and the attributes of the group.</description>
        /// </list>
        /// </param>
        /// <param name="buf">An array of objects containing the data.</param>
        /// <param name="totalentries">The number of entries in the array specified by the <paramref name="buf"/> parameter.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The system call level is not correct. This error is returned if the <paramref name="level"/> parameter was specified as a value other than <c>0</c> (zero) or <c>1</c>. </description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter passed was not valid. This error is returned if the <paramref name="totalentries"/> parameter was not valid. </description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory was available to complete the operation.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The global group name could not be found.</description>
        /// <term><see cref="NERR_InternalError"/></term><description>An internal error occurred.</description>
        /// <term><see cref="NERR_SpeGroupOp"/></term><description>The operation is not allowed on certain special groups. These groups include user groups, admin groups, local groups, and guest groups.</description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user name could not be found.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Group object is used to perform the access check for this function.</para>
        /// <para>
        /// You can replace the global group membership with an entirely new list of members by calling the <see cref="NetGroupSetUsers"/> function. The typical sequence of steps to perform this follows.
        /// <list type="number">
        /// <item>Call the <see cref="NetGroupGetUsers"/> function to retrieve the current membership list.</item>
        /// <item>Modify the returned membership list to reflect the new membership.</item>
        /// <item>Call the <see cref="NetGroupSetUsers"/> function to replace the old membership list with the new membership list.</item>
        /// </list>
        /// </para>
        /// <para>To grant one user membership in an existing global group, you can call the <see cref="NetGroupAddUser"/> function. To remove a user from a global group, call the <see cref="NetGroupDelUser"/> function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370432.aspx">NetGroupSetUsers function</a></para>
        /// </remarks>
        /// <seealso cref="GROUP_USERS_INFO_0"/>
        /// <seealso cref="GROUP_USERS_INFO_1"/>
        /// <seealso cref="NetGroupGetUsers"/>
        /// <seealso cref="NetUserGetGroups"/>
        /// <seealso cref="NetUserSetGroups"/>
        /// <seealso cref="NetGroupAddUser"/>
        /// <seealso cref="NetGroupDelUser"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetGroupSetUsers(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPArray)] object[] buf,
            [In] int totalentries
            );
        #endregion
        #region NetJoinDomain function
        /// <summary>
        /// The <see cref="NetJoinDomain"/> function joins a computer to a workgroup or domain.
        /// </summary>
        /// <param name="lpServer">A string that specifies the DNS or NetBIOS name of the computer on which to execute the domain join operation. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="lpDomain">
        /// <para>A string that specifies the name of the domain or workgroup to join. </para>
        /// <para>Optionally, you can specify the preferred domain controller to perform the join operation. In this instance, the string must be of the form <var>DomainName\MachineName</var>, where <var>DomainName</var> is the name of the domain to join, and <var>MachineName</var> is the name of the domain controller to perform the join.</para>
        /// </param>
        /// <param name="lpAccountOU">Optionally specifies a string that contains the RFC 1779 format name of the organizational unit (OU) for the computer account. If you specify this parameter, the string must contain a full path, for example, <c>OU=testOU,DC=domain,DC=Domain,DC=com</c>. Otherwise, this parameter must be <c>null</c>.</param>
        /// <param name="lpAccount">A string that specifies the account name to use when connecting to the domain controller. The string must specify either a domain NetBIOS name and user account (for example, <c>REDMOND\user</c>) or the user principal name (UPN) of the user in the form of an Internet-style login name (for example, <c>"someone@example.com"</c>). If this parameter is <c>null</c>, the caller's context is used.</param>
        /// <param name="lpPassword">
        /// <para>If the <paramref name="lpAccount"/> parameter specifies an account name, this parameter must be the password to use when connecting to the domain controller. Otherwise, this parameter must be <c>null</c>. </para>
        /// <para>You can specify a local machine account password rather than a user password for unsecured joins. For more information, see the description of the <see cref="NETSETUP_MACHINE_PWD_PASSED"/> flag.</para>
        /// </param>
        /// <param name="fJoinOptions">A set of bit flags defining the join options.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access is denied. This error is returned if the caller was not a member of the Administrators local group on the target computer.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="lpDomain"/> parameter is <c>null</c>.</description>
        /// <term><see cref="ERROR_NO_SUCH_DOMAIN"/></term><description>The specified domain did not exist.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if the computer specified in the <paramref name="lpServer"/> parameter does not support some of the options passed in the <paramref name="fJoinOptions"/> parameter.</description>
        /// <term><see cref="NERR_InvalidWorkgroupName"/></term><description>The specified workgroup name is not valid.</description>
        /// <term><see cref="NERR_SetupAlreadyJoined"/></term><description>The computer is already joined to a domain.</description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term><description>The Workstation service has not been started.</description>
        /// <term><see cref="RPC_S_CALL_IN_PROGRESS"/></term><description>A remote procedure call is already in progress for this thread.</description>
        /// <term><see cref="RPC_S_PROTSEQ_NOT_SUPPORTED"/></term><description>The remote procedure call protocol sequence is not supported.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Joining (and unjoining) a computer to a domain or workgroup can be performed only by a member of the Administrators local group on the target computer. Note that the domain administrator can set additional requirements for joining the domain using delegation and assignment of privileges.</para>
        /// <para>If you call the <see cref="NetJoinDomain"/> function remotely, you must supply credentials because you cannot delegate credentials under these circumstances.</para>
        /// <para>Different processes, or different threads of the same process, should not call the <see cref="NetJoinDomain"/> function at the same time. This situation can leave the computer in an inconsistent state.</para>
        /// <para>If you encounter a problem during a join operation, you should not delete a computer account and immediately follow the deletion with another join attempt. This can lead to replication-related problems that are difficult to investigate. When you delete a computer account, wait until the change has replicated to all domain controllers before attempting another join operation.</para>
        /// <para>A system reboot is required after calling the <see cref="NetJoinDomain"/> function for the operation to complete.</para>
        /// <para><strong>Windows Server 2003 and Windows XP</strong>: When a call to the <see cref="NetJoinDomain"/> function precedes a call to the <see cref="NetRenameMachineInDomain"/> function, you should defer the update of the SPN and DnsHostName properties on the computer object until the rename operation. This is because the join operation can fail in certain situations. An example of such a situation is when the SPN that is derived from the current computer name is not valid in the new domain that the computer is joining, but the SPN derived from the new name that the computer will have after the rename operation is valid in the new domain. In this situation, the call to <see cref="NetJoinDomain"/> fails unless you defer the update of the two properties until the rename operation by specifying the <see cref="NETSETUP_DEFER_SPN_SET"/> flag in the <paramref name="fJoinOptions"/> parameter when you call <see cref="NetJoinDomain"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370433.aspx">NetJoinDomain function</a></para>
        /// </remarks>
        /// <seealso cref="NetAddAlternateComputerName"/>
        /// <seealso cref="NetCreateProvisioningPackage"/>
        /// <seealso cref="NetEnumerateComputerNames"/>
        /// <seealso cref="NetProvisionComputerAccount"/>
        /// <seealso cref="NetRemoveAlternateComputerName"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetRequestOfflineDomainJoin"/>
        /// <seealso cref="NetRequestProvisioningPackageInstall"/>
        /// <seealso cref="NetSetPrimaryComputerName"/>
        /// <seealso cref="NetUnjoinDomain"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetJoinDomain(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpServer,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpDomain,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpAccountOU,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpAccount,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpPassword,
            [In, MarshalAs(UnmanagedType.I4)] NETSETUP_OPTIONS fJoinOptions
            );
        #endregion
        #region NetLocalGroupAdd function
        /// <summary>
        /// The <see cref="NetLocalGroupAdd"/> function creates a local group in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// The information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>A local group name. The <paramref name="buf"/> parameter contains a <see cref="LOCALGROUP_INFO_0"/> structure.</description>
        /// <term>1</term> <description>A local group name and a comment to associate with the group. The <paramref name="buf"/> parameter contains a <see cref="LOCALGROUP_INFO_1"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="buf">The local group information structure. The format of this data depends on the value of the level parameter.</param>
        /// <param name="parm_error">A variable that receives the index of the first member of the local group information structure to cause the <see cref="ERROR_INVALID_PARAMETER"/> error. If this parameter is omitted, the index is not returned on error. For more information, see the Remarks section for the <see cref="NetLocalGroupSetInfo"/> function.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The caller does not have the appropriate access to complete the operation.</description>
        /// <term><see cref="ERROR_ALIAS_EXISTS"/></term><description>The specified local group already exists. This error is returned if the group name member in the structure pointed to by the <paramref name="buf"/> parameter is already in use as an alias.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>A <paramref name="level"/> parameter is invalid. </description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if one or more of the members in the structure pointed to by the <paramref name="buf"/> parameter is invalid. </description>
        /// <term><see cref="NERR_GroupExists"/></term><description>The group name exists. This error is returned if the group name member in the structure pointed to by the <paramref name="buf"/> parameter is already in use as a group name.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_UserExists"/></term><description>The user name exists. This error is returned if the group name member in the structure in the <paramref name="buf"/> parameter is already in use as a user name.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the user container is used to perform the access check for this function. The caller must be able to create child objects of the group class.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>
        /// If the <see cref="NetLocalGroupAdd"/> function returns <see cref="ERROR_INVALID_PARAMETER"/>, on return the <paramref name="parm_error"/> parameter indicates the first member of the local group information structure that is invalid. The format of the local group information structure is specified in the <paramref name="level"/> parameter. An instance of the local group information structure is passed in <paramref name="buf"/> parameter. The following table lists the values that can be returned in the <paramref name="parm_error"/> parameter and the corresponding structure member that is in error. 
        /// <list type="table">
        /// <listheader><term>Value</term><description>Member</description></listheader>
        /// <term><see cref="LOCALGROUP_NAME_PARMNUM"/></term><description><para>If the <paramref name="level"/> parameter was <c>0</c> (zero), the <see cref="LOCALGROUP_INFO_0.lgrpi0_name"/> member of the <see cref="LOCALGROUP_INFO_0"/> structure was invalid.</para><para>If the <paramref name="level"/> parameter was <c>1</c>, the <see cref="LOCALGROUP_INFO_1.lgrpi1_name"/> member of the <see cref="LOCALGROUP_INFO_1"/> structure was invalid. </para></description>
        /// <term><see cref="LOCALGROUP_COMMENT_PARMNUM"/></term><description>If the <paramref name="level"/> parameter was <c>1</c>, the <see cref="LOCALGROUP_INFO_1.lgrpi1_comment"/> member of the <see cref="LOCALGROUP_INFO_1"/> structure was invalid. </description>
        /// </list>
        /// </para>
        /// <para>When making requests to a domain controller and Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same results as the network management local group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370434.aspx">NetLocalGroupAdd function</a></para>
        /// </remarks>
        /// <seealso cref="LOCALGROUP_INFO_0"/>
        /// <seealso cref="LOCALGROUP_INFO_1"/>
        /// <seealso cref="NetLocalGroupDel"/>
        /// <seealso cref="NetLocalGroupSetInfo"/>
        /// <seealso cref="NetLocalGroupAddMembers"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetLocalGroupAdd(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object buf,
            [Optional] out LOCALGROUP_INFO_PARMNUM parm_error
            );
        #endregion
        #region NetLocalGroupAddMember
        // The NetLocalGroupAddMember function is obsolete. You should use the NetLocalGroupAddMembers function instead.
        #endregion
        #region NetLocalGroupAddMembers function
        /// <summary>
        /// The <see cref="NetLocalGroupAddMembers"/> function adds membership of one or more existing user accounts or global group accounts to an existing local group. The function does not change the membership status of users or global groups that are currently members of the local group.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="groupname">A string that specifies the name of the local group to which the specified users or global groups will be added. For more information, see the Remarks section.</param>
        /// <param name="level">
        /// The information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Specifies the security identifier (SID) of the new local group member. The <paramref name="buf"/> parameter contains an array of <see cref="LOCALGROUP_MEMBERS_INFO_0"/> structures.</description>
        /// <term>3</term> <description>Specifies the domain and name of the new local group member. The <paramref name="buf"/> parameter contains an array of <see cref="LOCALGROUP_MEMBERS_INFO_3"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="buf">An array that contains the data for the new local group members. The format of this data depends on the value of the <paramref name="level"/> parameter.</param>
        /// <param name="totalentries">Specifies the number of entries in the array specified by the <paramref name="buf"/> parameter.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The local group specified by the groupname parameter does not exist.</description>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The caller does not have the appropriate access to complete the operation.</description>
        /// <term><see cref="ERROR_NO_SUCH_MEMBER"/></term><description>One or more of the members specified do not exist. Therefore, no new members were added.</description>
        /// <term><see cref="ERROR_MEMBER_IN_ALIAS"/></term><description>One or more of the members specified were already members of the local group. No new members were added.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>One or more of the members cannot be added because their account type is invalid. No new members were added.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the LocalGroup object is used to perform the access check for this function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370436.aspx">NetLocalGroupAddMembers function</a></para>
        /// </remarks>
        /// <seealso cref="LOCALGROUP_MEMBERS_INFO_0"/>
        /// <seealso cref="LOCALGROUP_MEMBERS_INFO_3"/>
        /// <seealso cref="NetLocalGroupDelMembers"/>
        /// <seealso cref="NetLocalGroupGetMembers"/>
        /// <seealso cref="NetLocalGroupAdd"/>
        /// <seealso cref="NetLocalGroupDel"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetLocalGroupAddMembers(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPArray)] object[] buf,
            [In] int totalentries
            );
        #endregion
        #region NetLocalGroupDel function
        /// <summary>
        /// The <see cref="NetLocalGroupDel"/> function deletes a local group account and all its members from the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="groupname">A string that specifies the name of the local group account to delete. For more information, see the Remarks section.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The caller does not have the appropriate access to complete the operation.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The local group specified by the <paramref name="groupname"/> parameter does not exist.</description>
        /// <term><see cref="ERROR_NO_SUCH_ALIAS"/></term><description>The specified local group does not exist.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the LocalGroup object is used to perform the access check for this function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370437.aspx">NetLocalGroupDel function</a></para>
        /// </remarks>
        /// <seealso cref="NetLocalGroupAdd"/>
        /// <seealso cref="NetLocalGroupDelMembers"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetLocalGroupDel(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname
            );
        #endregion
        #region NetLocalGroupDelMember
        // The NetLocalGroupDelMember function is obsolete. You should use the NetLocalGroupDelMembers function instead.
        #endregion
        #region NetLocalGroupDelMembers function
        /// <summary>
        /// The <see cref="NetLocalGroupDelMembers"/> function removes one or more members from an existing local group. Local group members can be users or global groups.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="groupname">A string that specifies the name of the local group from which the specified users or global groups will be removed. For more information, see the Remarks section.</param>
        /// <param name="level">
        /// The information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Specifies the security identifier (SID) of the local group member to remove. The <paramref name="buf"/> parameter contains an array of <see cref="LOCALGROUP_MEMBERS_INFO_0"/> structures.</description>
        /// <term>3</term> <description>Specifies the domain and name of the local group member to remove. The <paramref name="buf"/> parameter contains an array of <see cref="LOCALGROUP_MEMBERS_INFO_3"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="buf">An array that contains the data for the local group members to be removed. The format of this data depends on the value of the <paramref name="level"/> parameter.</param>
        /// <param name="totalentries">Specifies the number of entries in the array specified by the <paramref name="buf"/> parameter.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The local group specified by the <paramref name="groupname"/> parameter does not exist.</description>
        /// <term><see cref="ERROR_NO_SUCH_MEMBER"/></term><description>One or more of the members specified do not exist. Therefore, no members were deleted.</description>
        /// <term><see cref="ERROR_MEMBER_IN_ALIAS"/></term><description>One or more of the members specified were already members of the local group. No members were deleted.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the LocalGroup object is used to perform the access check for this function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370439.aspx">NetLocalGroupDelMembers function</a></para>
        /// </remarks>
        /// <seealso cref="LOCALGROUP_MEMBERS_INFO_0"/>
        /// <seealso cref="LOCALGROUP_MEMBERS_INFO_3"/>
        /// <seealso cref="NetLocalGroupAddMembers"/>
        /// <seealso cref="NetLocalGroupDel"/>
        /// <seealso cref="NetLocalGroupGetMembers"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetLocalGroupDelMembers(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPArray)] object[] buf,
            [In] int totalentries
            );
        #endregion
        #region NetLocalGroupEnum function
        /// <summary>
        /// The <see cref="NetLocalGroupEnum"/> function returns information about each local group account on the specified server.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Return local group names. The <paramref name="bufptr"/> parameter receives a handle to an array of <see cref="LOCALGROUP_INFO_0"/> structures.</description>
        /// <term><c>1</c></term> <description>Return local group names and the comment associated with each group. The <paramref name="bufptr"/> parameter receives a handle to an array of <see cref="LOCALGROUP_INFO_1"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable that receives a buffer containing the local group information structure. The format of this data depends on the value of the <paramref name="level"/> parameter. </para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <param name="prefmaxlen">Specifies the preferred maximum length of the returned data, in bytes. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required to hold the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="entriesread">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="totalentries">A variable that receives the total number of entries that could have been enumerated from the current resume position. The total number of entries is only a hint. For more information about determining the exact number of entries, see the Remarks section.</param>
        /// <param name="resumehandle">Reference to a pointer variable that contains a resume handle that is used to continue the global group enumeration. The handle should be zero on the first call and left unchanged for subsequent calls. If this parameter is omitted, no resume handle is stored.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_BufTooSmall"/></term><description>The return buffer is too small.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The function only returns information to which the caller has Read access. The caller must have List Contents access to the Domain object, and Enumerate Entire SAM Domain access on the SAM Server object located in the System container. </para>
        /// <para>To determine the exact total number of local groups, you must enumerate the entire tree, which can be a costly operation. To enumerate the entire tree, use the resumehandle parameter to continue the enumeration for consecutive calls, and use the entriesread parameter to accumulate the total number of local groups. If your application is communicating with a domain controller, you should consider using the <a href="https://msdn.microsoft.com/en-us/library/aa772203.aspx">ADSI LDAP Provider</a> to retrieve this type of data more efficiently. The ADSI LDAP Provider implements a set of ADSI objects that support various ADSI interfaces. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa772235.aspx">ADSI Service Providers</a>.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370440.aspx">NetLocalGroupEnum function</a></para>
        /// </remarks>
        /// <seealso cref="LOCALGROUP_INFO_0"/>
        /// <seealso cref="LOCALGROUP_INFO_1"/>
        /// <seealso cref="NetQueryDisplayInformation"/>
        /// <seealso cref="NetLocalGroupGetInfo"/>
        /// <seealso cref="NetLocalGroupGetMembers"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetLocalGroupEnum(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            out LocalGroupInfoArrayNetApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries,
            [Optional] ref IntPtr resumehandle
            );
        #endregion
        #region NetLocalGroupGetInfo function
        /// <summary>
        /// The <see cref="NetLocalGroupGetInfo"/> function retrieves information about a particular local group account on a server.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="groupname">A string that specifies the name of the local group account for which the information will be retrieved. For more information, see the Remarks section.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be the following value. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>1</c></term> <description>Return local group name and the comment associated with the local group. The <paramref name="bufptr"/> parameter receives a handle to a <see cref="LOCALGROUP_INFO_1"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable that receives a buffer containing the local group information structure. The format of this data depends on the value of the <paramref name="level"/> parameter. </para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The specified local group does not exist.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the LocalGroup object is used to perform the access check for this function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370441.aspx">NetLocalGroupGetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="LOCALGROUP_INFO_1"/>
        /// <seealso cref="NetQueryDisplayInformation"/>
        /// <seealso cref="NetLocalGroupEnum"/>
        /// <seealso cref="NetLocalGroupGetMembers"/>
        /// <seealso cref="NetLocalGroupSetInfo"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetLocalGroupGetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname,
            [In] int level,
            out LocalGroupInfoNetApiBufferHandle bufptr
            );
        #endregion
        #region NetLocalGroupGetMembers function
        /// <summary>
        /// The <see cref="NetLocalGroupGetMembers"/> function retrieves a list of the members of a particular local group in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory. Local group members can be users or global groups.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="localgroupname">A string that specifies the name of the local group whose members are to be listed. For more information, see the Remarks section.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be the following value. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Return the security identifier (SID) associated with the local group member. The <paramref name="bufptr"/> parameter points to an array of <see cref="LOCALGROUP_MEMBERS_INFO_0"/> structures.</description>
        /// <term><c>1</c></term> <description>Return the SID and account information associated with the local group member. The <paramref name="bufptr"/> parameter points to an array of <see cref="LOCALGROUP_MEMBERS_INFO_1"/> structures.</description>
        /// <term><c>2</c></term> <description>Return the SID, account information, and the domain name associated with the local group member. The <paramref name="bufptr"/> parameter points to an array of <see cref="LOCALGROUP_MEMBERS_INFO_2"/> structures.</description>
        /// <term><c>3</c></term> <description>Return the account and domain names of the local group member. The <paramref name="bufptr"/> parameter points to an array of <see cref="LOCALGROUP_MEMBERS_INFO_3"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable that receives a buffer containing the local group information structure. The format of this data depends on the value of the <paramref name="level"/> parameter. </para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <param name="prefmaxlen">Specifies the preferred maximum length of the returned data, in bytes. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required to hold the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="entriesread">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="totalentries">A variable that receives the total number of entries that could have been enumerated from the current resume position. The total number of entries is only a hint. For more information about determining the exact number of entries, see the Remarks section.</param>
        /// <param name="resumehandle">Reference to a pointer variable that contains a resume handle that is used to continue the global group enumeration. The handle should be zero on the first call and left unchanged for subsequent calls. If this parameter is omitted, no resume handle is stored.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// <term><see cref="ERROR_NO_SUCH_ALIAS"/></term><description>The specified local group does not exist.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the LocalGroup object is used to perform the access check for this function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para>If this function returns <see cref="ERROR_MORE_DATA"/>, then it must be repeatedly called until <see cref="ERROR_SUCCESS"/> or <see cref="NERR_Success"/> is returned. Failure to do so can result in an RPC connection leak.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370601.aspx">NetLocalGroupGetMembers function</a></para>
        /// </remarks>
        /// <seealso cref="LOCALGROUP_MEMBERS_INFO_0"/>
        /// <seealso cref="LOCALGROUP_MEMBERS_INFO_1"/>
        /// <seealso cref="LOCALGROUP_MEMBERS_INFO_2"/>
        /// <seealso cref="LOCALGROUP_MEMBERS_INFO_3"/>
        /// <seealso cref="NetLocalGroupSetMembers"/>
        /// <seealso cref="NetLocalGroupGetInfo"/>
        /// <seealso cref="NetLocalGroupEnum"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetLocalGroupGetMembers(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string localgroupname,
            [In] int level,
            out LocalGroupMembersInfoArrayNetApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries,
            [Optional] ref IntPtr resumehandle
            );
        #endregion
        #region NetLocalGroupSetInfo function
        /// <summary>
        /// The <see cref="NetLocalGroupSetInfo"/> function changes the name of an existing local group. The function also associates a comment with a local group.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="groupname">A string that specifies the name of the local group account to modify. For more information, see the Remarks section.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be the following value. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Specifies the local group name. The <paramref name="buf"/> parameter contains a <see cref="LOCALGROUP_INFO_0"/> structure. Use this level to change the name of an existing local group.</description>
        /// <term><c>1</c></term> <description>Specifies the local group name and a comment to associate with the group. The <paramref name="buf"/> parameter contains a <see cref="LOCALGROUP_INFO_1"/> structure.</description>
        /// <term><c>1002</c></term> <description>Specifies a comment to associate with the local group. The <paramref name="buf"/> parameter contains a <see cref="LOCALGROUP_INFO_1002"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="buf">The data for the local group information. The format of this data depends on the value of the <paramref name="level"/> parameter.</param>
        /// <param name="parm_error">A variable that receives the index of the first member of the local group information structure to cause the <see cref="ERROR_INVALID_PARAMETER"/> error. If this parameter is omitted, the index is not returned on error. For more information, see the Remarks section.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>One of the function parameters is invalid. For more information, see the Remarks section.</description>
        /// <term><see cref="ERROR_NO_SUCH_ALIAS"/></term><description>The specified local group does not exist.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the LocalGroup object is used to perform the access check for this function. Typically, callers must have write access to the entire object for calls to this function to succeed.</para>
        /// <para>To specify the new name of an existing local group, call <see cref="NetLocalGroupSetInfo"/> with <see cref="LOCALGROUP_INFO_0"/> and specify a value using the <see cref="LOCALGROUP_INFO_0.lgrpi0_name"/> member. If you call the <see cref="NetLocalGroupSetInfo"/> function with a different level and specify a new value using the <strong>lgrpi*_name</strong> member, that value will be ignored.</para>
        /// <para>
        /// If the <see cref="NetLocalGroupSetInfo"/> function returns <see cref="ERROR_INVALID_PARAMETER"/>, you can use the <paramref name="parm_error"/> parameter to indicate the first member of the local group information structure that is invalid. (A local group information structure begins with <strong>LOCALGROUP_INFO_</strong> and its format is specified by the <paramref name="level"/> parameter.) The following table lists the values that can be returned in the <paramref name="parm_error"/> parameter and the corresponding structure member that is in error. (The prefix <var>lgrpi*_</var> indicates that the member can begin with multiple prefixes, for example, <var>lgrpi0_</var> or <var>lgrpi1_</var>.)
        /// <list type="table">
        /// <listheader><term>Value</term><description>Member</description></listheader>
        /// <term><see cref="LOCALGROUP_NAME_PARMNUM"/></term><description><var>lgrpi*_name</var></description>
        /// <term><see cref="LOCALGROUP_COMMENT_PARMNUM"/></term><description><var>lgrpi*_comment</var></description>
        /// </list>
        /// </para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370602.aspx">NetLocalGroupSetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="LOCALGROUP_INFO_0"/>
        /// <seealso cref="LOCALGROUP_INFO_1"/>
        /// <seealso cref="LOCALGROUP_INFO_1002"/>
        /// <seealso cref="NetLocalGroupGetInfo"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetLocalGroupSetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object buf,
            [Optional] out LOCALGROUP_INFO_PARMNUM parm_error
            );
        #endregion
        #region NetLocalGroupSetMembers function
        /// <summary>
        /// The <see cref="NetLocalGroupSetMembers"/> function sets the membership for the specified local group. Each user or global group specified is made a member of the local group. Users or global groups that are not specified but who are currently members of the local group will have their membership revoked.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="groupname">A string that specifies the name of the local group in which the specified users or global groups should be granted membership. For more information, see the Remarks section.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be the following value. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Specifies the security identifier (SID) associated with a local group member. The <paramref name="buf"/> parameter points to an array of <see cref="LOCALGROUP_MEMBERS_INFO_0"/> structures.</description>
        /// <term><c>3</c></term> <description>Specifies the account and domain names of the local group member. The <paramref name="buf"/> parameter points to an array of <see cref="LOCALGROUP_MEMBERS_INFO_3"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="buf">An array that contains the member information. The format of this data depends on the value of the <paramref name="level"/> parameter.</param>
        /// <param name="totalentries">Specifies a value that contains the total number of entries in the array specified by the <paramref name="buf"/> parameter.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The group specified by the <paramref name="groupname"/> parameter does not exist.</description>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_NO_SUCH_MEMBER"/></term><description>One or more of the members doesn't exist. The local group membership was not changed.</description>
        /// <term><see cref="ERROR_INVALID_MEMBER"/></term><description>One or more of the members cannot be added because it has an invalid account type. The local group membership was not changed.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the LocalGroup object is used to perform the access check for this function.</para>
        /// <para>
        /// You can replace the local group membership with an entirely new list of members by calling the <see cref="NetLocalGroupSetMembers"/> function. The typical sequence of steps to perform this follows.
        /// <list type="number">
        /// <item>Call the <see cref="NetLocalGroupGetMembers"/> function to retrieve the current membership list.</item>
        /// <item>Modify the returned membership list to reflect the new membership.</item>
        /// <item>Call the <see cref="NetLocalGroupSetMembers"/> function to replace the old membership list with the new membership list.</item>
        /// </list>
        /// </para>
        /// <para>To add one or more existing user accounts or global group accounts to an existing local group, you can call the <see cref="NetLocalGroupAddMembers"/> function. To remove one or more members from an existing local group, call the <see cref="NetLocalGroupDelMembers"/> function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management group functions. For more information, see <see cref="IADsGroup"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370604.aspx">NetLocalGroupSetMembers function</a></para>
        /// </remarks>
        /// <seealso cref="LOCALGROUP_MEMBERS_INFO_0"/>
        /// <seealso cref="LOCALGROUP_MEMBERS_INFO_3"/>
        /// <seealso cref="NetLocalGroupGetMembers"/>
        /// <seealso cref="NetLocalGroupAddMembers"/>
        /// <seealso cref="NetLocalGroupDelMembers"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetLocalGroupSetMembers(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string groupname,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPArray)] object[] buf,
            [In] int totalentries
            );
        #endregion
        #region NetMessageBufferSend function
        /// <summary>
        /// The <see cref="NetMessageBufferSend"/> function sends a buffer of information to a registered message alias.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="msgname">A string that specifies the message alias to which the message buffer should be sent.</param>
        /// <param name="fromname">A string specifying who the message is from. If this parameter is <c>null</c>, the message is sent from the local computer name.</param>
        /// <param name="buf">A buffer that contains the message text.</param>
        /// <param name="buflen">Specifies a value that contains the length, in bytes, of the message text pointed to by the <paramref name="buf"/> parameter.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The caller does not have the appropriate access to complete the operation.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>This request is not supported. This error is returned on Windows Vista and later.</description>
        /// <term><see cref="NERR_NameNotFound"/></term><description>The user name could not be found.</description>
        /// <term><see cref="NERR_NetworkError"/></term><description>A general failure occurred in the network hardware.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows XP</para>
        /// <para><strong>End of server support</strong>: Windows Server 2003</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370605.aspx">NetMessageBufferSend function</a></para>
        /// </remarks>
        /// <seealso cref="NetMessageNameAdd"/>
        /// <seealso cref="NetMessageNameDel"/>
        /// <seealso cref="NetMessageNameEnum"/>
        /// <seealso cref="NetMessageNameGetInfo"/>
        [Obsolete("This function is not supported as of Windows Vista because the messenger service is not supported.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetMessageBufferSend(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string msgname,
            [In, MarshalAs(UnmanagedType.LPWStr)] string fromname,
            [In, MarshalAs(UnmanagedType.LPWStr)] string buf,
            [In] int buflen
            );
        #endregion
        #region NetMessageNameAdd function
        /// <summary>
        /// The <see cref="NetMessageNameAdd"/> function registers a message alias in the message name table. The function requires that the messenger service be started.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="msgname">A string that specifies the message alias to add. The string cannot be more than 15 characters long.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The caller does not have the appropriate access to complete the operation.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>This request is not supported. This error is returned on Windows Vista and later.</description>
        /// <term><see cref="NERR_AlreadyExists"/></term><description>The message alias already exists on this computer. For more information, see the Remarks section.</description>
        /// <term><see cref="NERR_DuplicateName"/></term><description>The name specified is already in use as a message alias on the network.</description>
        /// <term><see cref="NERR_NetworkError"/></term><description>A general failure occurred in the network hardware.</description>
        /// <term><see cref="NERR_TooManyNames"/></term><description>The maximum number of message aliases has been exceeded.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators local group can successfully execute the <see cref="NetMessageNameAdd"/> function on a remote server.</para>
        /// <para>The forward action flag is no longer a parameter to the LAN Manager 2.x <see cref="NetMessageNameAdd"/> function because message forwarding is no longer supported. If the <see cref="NetMessageNameAdd"/> function detects that a forwarded version of <paramref name="msgname"/> exists on the network, the function will fail with error <see cref="NERR_AlreadyExists"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows XP</para>
        /// <para><strong>End of server support</strong>: Windows Server 2003</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370606.aspx">NetMessageNameAdd function</a></para>
        /// </remarks>
        /// <seealso cref="NetMessageNameDel"/>
        [Obsolete("This function is not supported as of Windows Vista because the messenger service is not supported.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetMessageNameAdd(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string msgname
            );
        #endregion
        #region NetMessageNameDel function
        /// <summary>
        /// The <see cref="NetMessageNameDel"/> function deletes a message alias in the message name table. The function requires that the messenger service be started.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="msgname">A string that specifies the message alias to delete. The string cannot be more than 15 characters long.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The caller does not have the appropriate access to complete the operation.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>This request is not supported. This error is returned on Windows Vista and later.</description>
        /// <term><see cref="NERR_DelComputerName"/></term><description>A message alias that is also a computer name cannot be deleted.</description>
        /// <term><see cref="NERR_IncompleteDel"/></term><description>The message alias was not successfully deleted from all networks.</description>
        /// <term><see cref="NERR_NameInUse"/></term><description>The message alias is currently in use. Try again later.</description>
        /// <term><see cref="NERR_NotLocalName"/></term><description>The message alias is not on the local computer.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators local group can successfully execute the <see cref="NetMessageNameDel"/> function on a remote server.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows XP</para>
        /// <para><strong>End of server support</strong>: Windows Server 2003</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370607.aspx">NetMessageNameDel function</a></para>
        /// </remarks>
        /// <seealso cref="NetMessageNameAdd"/>
        [Obsolete("This function is not supported as of Windows Vista because the messenger service is not supported.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetMessageNameDel(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string msgname
            );
        #endregion
        #region NetMessageNameEnum function
        /// <summary>
        /// The <see cref="NetMessageNameEnum"/> function lists the message aliases that receive messages on a specified computer. The function requires that the messenger service be started.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be the following value. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Return message aliases. The <paramref name="bufptr"/> parameter receives an array of <see cref="MSG_INFO_0"/> structures.</description>
        /// <term><c>1</c></term> <description>Return message aliases. The <paramref name="bufptr"/> parameter receives an array of <see cref="MSG_INFO_1"/> structures. This level exists only for compatibility. Message forwarding is not supported.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable that receives the data. The format of this data depends on the value of the <paramref name="level"/> parameter. </para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <param name="prefmaxlen">Specifies the preferred maximum length of the returned data, in bytes. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required to hold the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="entriesread">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="totalentries">A variable that receives the total number of entries that could have been enumerated from the current resume position. The total number of entries is only a hint. For more information about determining the exact number of entries, see the Remarks section.</param>
        /// <param name="resume_handle">Reference to a pointer variable that contains a resume handle that is used to continue an existing message alias search. The handle should be zero on the first call and left unchanged for subsequent calls. If this parameter is omitted, no resume handle is stored.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the <paramref name="level"/> parameter is invalid.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect.</description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>This request is not supported. This error is returned on Windows Vista and later.</description>
        /// <term><see cref="NERR_BufTooSmall"/></term><description>The supplied buffer is too small.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators local group can successfully execute the <see cref="NetMessageNameEnum"/> function on a remote server.</para>
        /// <para>To retrieve information about a particular message alias in the message name table, you can call the <see cref="NetMessageNameGetInfo"/> function.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows XP</para>
        /// <para><strong>End of server support</strong>: Windows Server 2003</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370608.aspx">NetMessageNameEnum function</a></para>
        /// </remarks>
        /// <seealso cref="MSG_INFO_0"/>
        /// <seealso cref="MSG_INFO_1"/>
        /// <seealso cref="NetMessageNameGetInfo"/>
        [Obsolete("This function is not supported as of Windows Vista because the messenger service is not supported.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetMessageNameEnum(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            out MsgInfoNetArrayApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries,
            [Optional] ref IntPtr resume_handle
            );
        #endregion
        #region NetMessageNameGetInfo function
        /// <summary>
        /// The <see cref="NetMessageNameGetInfo"/> function retrieves information about a particular message alias in the message name table. The function requires that the messenger service be started.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="msgname">A string that specifies the message alias for which to return information.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be the following value. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> <description>Return the message alias. The <paramref name="bufptr"/> parameter receives a <see cref="MSG_INFO_0"/> structure.</description>
        /// <term><c>1</c></term> <description>Return the message alias. The <paramref name="bufptr"/> parameter receives a <see cref="MSG_INFO_1"/> structure. This level exists only for compatibility. Message forwarding is not supported.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable that receives the data. The format of this data depends on the value of the <paramref name="level"/> parameter. </para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the <paramref name="level"/> parameter is invalid.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>This request is not supported. This error is returned on Windows Vista and later.</description>
        /// <term><see cref="NERR_NotLocalName"/></term><description>The message alias is not on the local computer.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators local group can successfully execute the <see cref="NetMessageNameGetInfo"/> function on a remote server.</para>
        /// <para>To list all the message aliases in a message name table, you can call the <see cref="NetMessageNameEnum"/> function.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows XP</para>
        /// <para><strong>End of server support</strong>: Windows Server 2003</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370609.aspx">NetMessageNameGetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="MSG_INFO_0"/>
        /// <seealso cref="MSG_INFO_1"/>
        /// <seealso cref="NetMessageNameEnum"/>
        [Obsolete("This function is not supported as of Windows Vista because the messenger service is not supported.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetMessageNameGetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string msgname,
            [In] int level,
            out MsgInfoNetApiBufferHandle bufptr
            );
        #endregion
        #region NetProvisionComputerAccount function
        /// <summary>
        /// The <see cref="NetProvisionComputerAccount"/> function provisions a computer account for later use in an offline domain join operation. 
        /// </summary>
        /// <param name="lpDomain">A string that specifies the name of the domain where the computer account is created. </param>
        /// <param name="lpMachineName">A string that specifies the short name of the machine from which the computer account attribute sAMAccountName is derived by appending a '$'. This parameter must contain a valid DNS or NetBIOS machine name.</param>
        /// <param name="lpMachineAccountOU">
        /// <para>An optional string that contains the RFC 1779 format name of the organizational unit (OU) where the computer account will be created. If you specify this parameter, the string must contain a full path, for example, OU=testOU,DC=domain,DC=Domain,DC=com. Otherwise, this parameter must be <c>null</c>.</para>
        /// <para>If this parameter is <c>null</c>, the well known computer object container will be used as published in the domain.</para>
        /// </param>
        /// <param name="lpDcName">An optional string that contains the name of the domain controller to target.</param>
        /// <param name="dwOptions">A set of bit flags that define provisioning options.</param>
        /// <param name="pProvisionBinData">
        /// <para>A variable that will receive the opaque binary blob of serialized metadata required by <see cref="NetRequestOfflineDomainJoin"/> function to complete an offline domain join, if the <see cref="NetProvisionComputerAccount"/> function completes successfully. The data is returned as an opaque binary buffer which may be passed to <see cref="NetRequestOfflineDomainJoin"/> function. </para>
        /// <para>Providing this parameter requires <paramref name="pProvisionTextData"/> to be set to <see cref="IntPtr.Zero"/>.</para>
        /// </param>
        /// <param name="pdwProvisionBinDataSize">A variable that receives the size, in bytes, of the buffer returned in the <paramref name="pProvisionBinData"/> parameter. </param>
        /// <param name="pProvisionTextData">The parameter must be omitted, or be set to <see cref="IntPtr.Zero"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access is denied. This error is returned if the caller does not have sufficient privileges to complete the operation. </description>
        /// <term><see cref="ERROR_INVALID_DOMAIN_ROLE"/></term><description>This operation is only allowed for the Primary Domain Controller of the domain. This error is returned if a domain controller name was specified in the <paramref name="lpDcName"/> parameter, but the computer specified could not be validated as a domain controller for the target domain specified in the <paramref name="lpDomain"/> parameter.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="lpDomain"/> or <paramref name="lpMachineName"/> parameter is <c>null</c>.</description>
        /// <term><see cref="ERROR_NO_SUCH_DOMAIN"/></term><description>The specified domain did not exist.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if the <paramref name="lpMachineAccountOU"/> parameter was specified and the domain controller is running on an earlier versions of Windows that does not support this parameter.</description>
        /// <term><see cref="NERR_DS8DCRequired"/></term><description>The specified domain controller does not meet the version requirement for this operation.</description>
        /// <term><see cref="NERR_LDAPCapableDCRequired"/></term><description>This operation requires a domain controller which supports LDAP.</description>
        /// <term><see cref="NERR_UserExists"/></term><description>The account already exists in the domain and the <see cref="NETSETUP_PROVISION_REUSE_ACCOUNT"/> bit was not specified in the <paramref name="dwOptions"/> parameter.</description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term><description>The Workstation service has not been started.</description>
        /// <term><see cref="RPC_S_CALL_IN_PROGRESS"/></term><description>A remote procedure call is already in progress for this thread.</description>
        /// <term><see cref="RPC_S_PROTSEQ_NOT_SUPPORTED"/></term><description>The remote procedure call protocol sequence is not supported.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetProvisionComputerAccount"/> function is supported on Windows 7 and Windows Server 2008 R2 for offline join operations. On Windows 8 or Windows Server 2008 R2 or later, it is recommended that the <see cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> function be used instead of the <see cref="NetProvisionComputerAccount"/> function.</para>
        /// <para>
        /// The <see cref="NetProvisionComputerAccount"/> function is used to provision a computer account for later use in an offline domain join operation using the <see cref="NetRequestOfflineDomainJoin"/> function. The offline domain join scenario uses these functions as follows: 
        /// <list type="bullet">
        /// <item><see cref="NetProvisionComputerAccount"/> is a provisioning function that is first called to perform the network operations necessary to create and configure the computer object in Active Directory. The output from the <see cref="NetProvisionComputerAccount"/> is an opaque binary blob of serialized metadata used for the next step. </item>
        /// <item><see cref="NetRequestOfflineDomainJoin"/>, an image initialization function, is then called to inject the output from the <see cref="NetProvisionComputerAccount"/> provisioning function into a Windows operating system image to be used during installation. </item>
        /// </list>
        /// </para>
        /// <para>Changes to Windows initialization code will detect this saved state and affect the local only portion of domain join.<br/> The <see cref="NetProvisionComputerAccount"/> function will create or reuse the machine account in the domain, collect all necessary metadata and return it in an opaque versioned binary blob or as text for embedding in an unattended setup answer file.The opaque binary blob can be consumed by the offline domain join request operation supplying all the necessary input to complete the domain join during first boot without any network operations(local state updates only). </para>
        /// <para><note type="security">The blob returned by the <see cref="NetProvisionComputerAccount"/> function contains very sensitive data. It should be treated just as securely as a plaintext password. The blob contains the machine account password and other information about the domain, including the domain name, the name of a domain controller, and the security ID (SID) of the domain. If the blob is being transported physically or over the network, care must be taken to transport it securely. The design makes no provisions for securing this data. This problem exists today with unattended setup answer files which can carry a number of secrets including domain user passwords. The caller must secure the blob and the unattended setup files. Solutions to this problem are varied. As an example, a pre-exchanged key could be used to encrypt a session between the consumer and provisioning entity enabling a secure transfer of the opaque blob. </note></para>
        /// <para>The opaque blob returned in the <paramref name="pProvisionBinData"/> parameter by the <see cref="NetProvisionComputerAccount"/> function is versioned to allow interoperability and serviceability scenarios between different versions of Windows (joining client, provisioning machine, and domain controller). The offline join scenario currently does not limit the lifetime of the blob returned by the <see cref="NetProvisionComputerAccount"/> function. </para>
        /// <para>
        /// For offline domain joins, the access check performed depends on the configuration of the domain. Computer account creation is enabled using three methods:
        /// <list type="bullet">
        /// <item>Domain administrators have rights to create computer accounts.</item>
        /// <item>The SD on a container can delegate the rights to create computer accounts.</item>
        /// <item>By default, authenticated users may create computer accounts by privilege. Authenticated users are limited to creating a limited number of accounts that is specified as a quota on the domain (the default value is 10). For more information, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152785">ms-DS-MachineAccountQuota</a> attribute in the Active Directory schema.</item>
        /// </list>
        /// </para>
        /// <para>The <see cref="NetProvisionComputerAccount"/> function works only with a writable domain controller and does not function against a read-only domain controller. Once provisioning is done against a writable domain controller and the account is replicated to a read-only domain controller, then the other portions of offline domain join operation do not require access to a domain controller.</para>
        /// <para>If the <see cref="NetProvisionComputerAccount"/> function is successful, the handle in the <paramref name="pProvisionBinData"/> parameter is returned with the serialized data for use in an offline join operation.</para>
        /// <para>For more information on offline domain join operations, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152786">Offline Domain Join Step-by-Step Guide</a>.</para>
        /// <para>Joining (and unjoining) a computer to a domain using <see cref="NetJoinDomain"/> and <see cref="NetUnjoinDomain"/> can be performed only by a member of the Administrators local group on the target computer. Note that the domain administrator can set additional requirements for joining the domain using delegation and assignment of privileges.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 7 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 R2 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dd815228.aspx">NetProvisionComputerAccount function</a></para>
        /// </remarks>
        /// <seealso cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetRequestOfflineDomainJoin"/>
        /// <seealso cref="NetUnjoinDomain"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetProvisionComputerAccount(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpDomain,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpMachineName,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string lpMachineAccountOU,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string lpDcName,
            [In, MarshalAs(UnmanagedType.I4)] NETSETUP_PROVISION_FLAGS dwOptions,
            out NetRequestOfflineDomainJoinBinDataBuffer pProvisionBinData,
            out int pdwProvisionBinDataSize,
            [Optional] IntPtr pProvisionTextData
            );
        /// <summary>
        /// The <see cref="NetProvisionComputerAccount"/> function provisions a computer account for later use in an offline domain join operation. 
        /// </summary>
        /// <param name="lpDomain">A string that specifies the name of the domain where the computer account is created. </param>
        /// <param name="lpMachineName">A string that specifies the short name of the machine from which the computer account attribute sAMAccountName is derived by appending a '$'. This parameter must contain a valid DNS or NetBIOS machine name.</param>
        /// <param name="lpMachineAccountOU">
        /// <para>An optional string that contains the RFC 1779 format name of the organizational unit (OU) where the computer account will be created. If you specify this parameter, the string must contain a full path, for example, OU=testOU,DC=domain,DC=Domain,DC=com. Otherwise, this parameter must be <c>null</c>.</para>
        /// <para>If this parameter is <c>null</c>, the well known computer object container will be used as published in the domain.</para>
        /// </param>
        /// <param name="lpDcName">An optional string that contains the name of the domain controller to target.</param>
        /// <param name="dwOptions">A set of bit flags that define provisioning options.</param>
        /// <param name="pProvisionBinData">This parameter must be omitted, or be set to <see cref="IntPtr.Zero"/>.</param>
        /// <param name="pdwProvisionBinDataSize">This parameter must be omitted, or be set to <see cref="IntPtr.Zero"/>.</param>
        /// <param name="pProvisionTextData">
        /// <para>A variable that will receive the opaque binary blob of serialized metadata required by <see cref="NetRequestOfflineDomainJoin"/> function to complete an offline domain join, if the <see cref="NetProvisionComputerAccount"/> function completes successfully. The data is returned in string form for embedding in an unattended setup answer file.</para>
        /// <para>Providing this parameter requires the <paramref name="pProvisionBinData"/> and <paramref name="pdwProvisionBinDataSize"/> parameters to be omitted or to be set to <see cref="IntPtr.Zero"/>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access is denied. This error is returned if the caller does not have sufficient privileges to complete the operation. </description>
        /// <term><see cref="ERROR_INVALID_DOMAIN_ROLE"/></term><description>This operation is only allowed for the Primary Domain Controller of the domain. This error is returned if a domain controller name was specified in the <paramref name="lpDcName"/> parameter, but the computer specified could not be validated as a domain controller for the target domain specified in the <paramref name="lpDomain"/> parameter.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="lpDomain"/> or <paramref name="lpMachineName"/> parameter is <c>null</c>.</description>
        /// <term><see cref="ERROR_NO_SUCH_DOMAIN"/></term><description>The specified domain did not exist.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if the <paramref name="lpMachineAccountOU"/> parameter was specified and the domain controller is running on an earlier versions of Windows that does not support this parameter.</description>
        /// <term><see cref="NERR_DS8DCRequired"/></term><description>The specified domain controller does not meet the version requirement for this operation.</description>
        /// <term><see cref="NERR_LDAPCapableDCRequired"/></term><description>This operation requires a domain controller which supports LDAP.</description>
        /// <term><see cref="NERR_UserExists"/></term><description>The account already exists in the domain and the <see cref="NETSETUP_PROVISION_REUSE_ACCOUNT"/> bit was not specified in the <paramref name="dwOptions"/> parameter.</description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term><description>The Workstation service has not been started.</description>
        /// <term><see cref="RPC_S_CALL_IN_PROGRESS"/></term><description>A remote procedure call is already in progress for this thread.</description>
        /// <term><see cref="RPC_S_PROTSEQ_NOT_SUPPORTED"/></term><description>The remote procedure call protocol sequence is not supported.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetProvisionComputerAccount"/> function is supported on Windows 7 and Windows Server 2008 R2 for offline join operations. On Windows 8 or Windows Server 2008 R2 or later, it is recommended that the <see cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> function be used instead of the <see cref="NetProvisionComputerAccount"/> function.</para>
        /// <para>
        /// The <see cref="NetProvisionComputerAccount"/> function is used to provision a computer account for later use in an offline domain join operation using the <see cref="NetRequestOfflineDomainJoin"/> function. The offline domain join scenario uses these functions as follows: 
        /// <list type="bullet">
        /// <item><see cref="NetProvisionComputerAccount"/> is a provisioning function that is first called to perform the network operations necessary to create and configure the computer object in Active Directory. The output from the <see cref="NetProvisionComputerAccount"/> is an opaque binary blob of serialized metadata used for the next step. </item>
        /// <item><see cref="NetRequestOfflineDomainJoin"/>, an image initialization function, is then called to inject the output from the <see cref="NetProvisionComputerAccount"/> provisioning function into a Windows operating system image to be used during installation. </item>
        /// </list>
        /// </para>
        /// <para>Changes to Windows initialization code will detect this saved state and affect the local only portion of domain join.<br/> The <see cref="NetProvisionComputerAccount"/> function will create or reuse the machine account in the domain, collect all necessary metadata and return it in an opaque versioned binary blob or as text for embedding in an unattended setup answer file.The opaque binary blob can be consumed by the offline domain join request operation supplying all the necessary input to complete the domain join during first boot without any network operations(local state updates only). </para>
        /// <para><note type="security">The blob returned by the <see cref="NetProvisionComputerAccount"/> function contains very sensitive data. It should be treated just as securely as a plaintext password. The blob contains the machine account password and other information about the domain, including the domain name, the name of a domain controller, and the security ID (SID) of the domain. If the blob is being transported physically or over the network, care must be taken to transport it securely. The design makes no provisions for securing this data. This problem exists today with unattended setup answer files which can carry a number of secrets including domain user passwords. The caller must secure the blob and the unattended setup files. Solutions to this problem are varied. As an example, a pre-exchanged key could be used to encrypt a session between the consumer and provisioning entity enabling a secure transfer of the opaque blob. </note></para>
        /// <para>The opaque blob returned in the <paramref name="pProvisionBinData"/> parameter by the <see cref="NetProvisionComputerAccount"/> function is versioned to allow interoperability and serviceability scenarios between different versions of Windows (joining client, provisioning machine, and domain controller). The offline join scenario currently does not limit the lifetime of the blob returned by the <see cref="NetProvisionComputerAccount"/> function. </para>
        /// <para>
        /// For offline domain joins, the access check performed depends on the configuration of the domain. Computer account creation is enabled using three methods:
        /// <list type="bullet">
        /// <item>Domain administrators have rights to create computer accounts.</item>
        /// <item>The SD on a container can delegate the rights to create computer accounts.</item>
        /// <item>By default, authenticated users may create computer accounts by privilege. Authenticated users are limited to creating a limited number of accounts that is specified as a quota on the domain (the default value is 10). For more information, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152785">ms-DS-MachineAccountQuota</a> attribute in the Active Directory schema.</item>
        /// </list>
        /// </para>
        /// <para>The <see cref="NetProvisionComputerAccount"/> function works only with a writable domain controller and does not function against a read-only domain controller. Once provisioning is done against a writable domain controller and the account is replicated to a read-only domain controller, then the other portions of offline domain join operation do not require access to a domain controller.</para>
        /// <para>If the <see cref="NetProvisionComputerAccount"/> function is successful, the handle in the <paramref name="pProvisionTextData"/> parameter is returned with the serialized data for use as text in an unattended setup file. </para>
        /// <para>For more information on offline domain join operations, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152786">Offline Domain Join Step-by-Step Guide</a>.</para>
        /// <para>Joining (and unjoining) a computer to a domain using <see cref="NetJoinDomain"/> and <see cref="NetUnjoinDomain"/> can be performed only by a member of the Administrators local group on the target computer. Note that the domain administrator can set additional requirements for joining the domain using delegation and assignment of privileges.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 7 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 R2 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dd815228.aspx">NetProvisionComputerAccount function</a></para>
        /// </remarks>
        /// <seealso cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, IntPtr, IntPtr, out WideStringZeroTerminatedAnySafeHandle)"/>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetRequestOfflineDomainJoin"/>
        /// <seealso cref="NetUnjoinDomain"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetProvisionComputerAccount(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpDomain,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpMachineName,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string lpMachineAccountOU,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string lpDcName,
            [In, MarshalAs(UnmanagedType.I4)] NETSETUP_PROVISION_FLAGS dwOptions,
            [Optional] IntPtr pProvisionBinData,
            [Optional] IntPtr pdwProvisionBinDataSize,
            out WideStringZeroTerminatedAnySafeHandle pProvisionTextData
            );
        #endregion
        #region NetQueryDisplayInformation function
        /// <summary>
        /// The <see cref="NetQueryDisplayInformation"/> function returns user account, computer, or group account information. Call this function to quickly enumerate account information for display in user interfaces.
        /// </summary>
        /// <param name="ServerName">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="Level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>1</c></term> - <description>Return user account information. The <paramref name="SortedBuffer"/> parameter receives an array of <see cref="NET_DISPLAY_USER"/> structures.</description>
        /// <term><c>2</c></term> - <description>Return individual computer information. The <paramref name="SortedBuffer"/> parameter receives an array of <see cref="NET_DISPLAY_MACHINE"/> structures.</description>
        /// <term><c>3</c></term> - <description>Return group account information. The <paramref name="SortedBuffer"/> parameter receives an array of <see cref="NET_DISPLAY_GROUP"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="Index">Specifies the index of the first entry for which to retrieve information. Specify zero to retrieve account information beginning with the first display information entry. For more information, see the Remarks section.</param>
        /// <param name="EntriesRequested">Specifies the maximum number of entries for which to retrieve information. On Windows 2000 and later, each call to <see cref="NetQueryDisplayInformation"/> returns a maximum of 100 objects.</param>
        /// <param name="PreferredMaximumLength">Specifies the preferred maximum size, in bytes, of the system-allocated buffer returned in the <paramref name="SortedBuffer"/> parameter. It is recommended that you set this parameter to <see cref="MAX_PREFERRED_LENGTH"/>.</param>
        /// <param name="ReturnedEntryCount">A variable that receives the number of entries in the array returned in the <paramref name="SortedBuffer"/> parameter. If this parameter is zero, there are no entries with an index as large as that specified. Entries may be returned when the function's return value is either <see cref="NERR_Success"/> or <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="SortedBuffer">
        /// <para>A variable that receives a pointer to a system-allocated buffer that specifies a sorted list of the requested information. The format of this data depends on the value of the <paramref name="Level"/> parameter.</para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The <paramref name="Level"/> parameter specifies an invalid value.</description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. That is, the last entry returned in the <paramref name="SortedBuffer"/> parameter is not the last entry available. To retrieve additional entries, call <see cref="NetQueryDisplayInformation"/> again with the <paramref name="Index"/> parameter set to the value returned in the <strong>next_index</strong> member of the last entry in <paramref name="SortedBuffer"/>. Note that you should not use the value of the <strong>next_index</strong> member for any purpose except to retrieve more data with additional calls to <see cref="NetQueryDisplayInformation"/>.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876aspx">Access Control Model</a>.</para>
        /// <para>The <see cref="NetQueryDisplayInformation"/> function only returns information to which the caller has Read access. The caller must have List Contents access to the Domain object, and Enumerate Entire SAM Domain access on the SAM Server object located in the System container.</para>
        /// <para>The <see cref="NetQueryDisplayInformation"/> and <see cref="NetGetDisplayInformationIndex"/> functions provide an efficient mechanism for enumerating user and group accounts. When possible, use these functions instead of the <see cref="NetUserEnum"/> function or the <see cref="NetGroupEnum"/> function.</para>
        /// <para>To enumerate trusting domains or member computer accounts, call <see cref="NetUserEnum"/>, specifying the appropriate filter value to obtain the account information you require. To enumerate trusted domains, call the <see cref="LsaEnumerateTrustedDomains"/> or <see cref="LsaEnumerateTrustedDomainsEx"/> function.</para>
        /// <para>The number of entries returned by this function depends on the security descriptor located on the root domain object. The API will return either the first 100 entries or the entire set of entries in the domain, depending on the access privileges of the user. The ACE used to control this behavior is "SAM-Enumerate-Entire-Domain", and is granted to Authenticated Users by default. Administrators can modify this setting to allow users to enumerate the entire domain.</para>
        /// <para>Each call to <see cref="NetQueryDisplayInformation"/> returns a maximum of 100 objects. Calling the <see cref="NetQueryDisplayInformation"/> function to enumerate domain account information can be costly in terms of performance. If you are programming for Active Directory, you may be able to use methods on the <see cref="IDirectorySearch"/> interface to make paged queries against the domain. For more information, see <see cref="IDirectorySearch.SetSearchPreference"/> and <see cref="IDirectorySearch.ExecuteSearch"/>. To enumerate trusted domains, call the <see cref="LsaEnumerateTrustedDomainsEx"/> function.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370610.aspx">NetQueryDisplayInformation function</a></para>
        /// </remarks>
        /// <seealso cref="LsaEnumerateTrustedDomains"/>
        /// <seealso cref="LsaEnumerateTrustedDomainsEx"/>
        /// <seealso cref="NET_DISPLAY_GROUP"/>
        /// <seealso cref="NET_DISPLAY_MACHINE"/>
        /// <seealso cref="NET_DISPLAY_USER"/>
        /// <seealso cref="NetGetDisplayInformationIndex"/>
        /// <seealso cref="NetUserEnum"/>
        /// <seealso cref="NetGroupEnum"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetQueryDisplayInformation(
            [In, MarshalAs(UnmanagedType.LPWStr)] string ServerName,
            [In] int Level,
            [In] int Index,
            [In] int EntriesRequested,
            [In] int PreferredMaximumLength,
            out int ReturnedEntryCount,
            out NetDisplayArrayNetApiBufferHandle SortedBuffer
            );
        #endregion
        #region NetRemoveAlternateComputerName function
        /// <summary>
        /// The <see cref="NetRemoveAlternateComputerName"/> function removes an alternate name for the specified computer.
        /// </summary>
        /// <param name="Server">A string that specifies the name of the computer on which to execute this function. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="AlternateName">A string that specifies the alternate name to remove. This name must be in the form of a fully qualified DNS name.</param>
        /// <param name="DomainAccount">
        /// <para>A string that specifies the domain account to use for accessing the machine account object for the computer specified in the <paramref name="Server"/> parameter in Active Directory. If this parameter is <c>null</c>, then the credentials of the user executing this routine are used. </para>
        /// <para>This parameter is not used if the server to execute this function is not joined to a domain. </para>
        /// </param>
        /// <param name="DomainAccountPassword">
        /// <para>A string that specifies the password matching the domain account passed in the <paramref name="DomainAccount"/> parameter. If this parameter is <c>null</c>, then the credentials of the user executing this routine are used. </para>
        /// <para>This parameter is ignored if the <paramref name="DomainAccount"/> parameter is <c>null</c>. This parameter is not used if the server to execute this function is not joined to a domain. </para>
        /// </param>
        /// <param name="Reserved">Reserved for future use. This parameter should be <c>0</c> (zero).</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access is denied. This error is returned if the caller does not have sufficient privileges to complete the operation. </description>
        /// <term><see cref="ERROR_INVALID_NAME"/></term><description>A name parameter is incorrect. This error is returned if the <paramref name="AlternateName"/> parameter does not contain valid name.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="DomainAccount"/> parameter does not contain a valid domain. This error is also returned if the <paramref name="DomainAccount"/> parameter is not <c>null</c> and the <paramref name="DomainAccountPassword"/> parameter is not <c>null</c> but does not contain a Unicode string.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Not enough memory is available to process this command.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if the target computer specified in the <paramref name="Server"/> parameter on which this function executes is running on Windows 2000 and earlier. </description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term><description>The Workstation service has not been started.</description>
        /// <term><see cref="RPC_S_CALL_IN_PROGRESS"/></term><description>A remote procedure call is already in progress for this thread.</description>
        /// <term><see cref="RPC_S_PROTSEQ_NOT_SUPPORTED"/></term><description>The remote procedure call protocol sequence is not supported.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetRemoveAlternateComputerName"/> function is supported on Windows XP and later. </para>
        /// <para>The <see cref="NetRemoveAlternateComputerName"/> function is used to remove secondary computer names configured for the target computer.</para>
        /// <para>The <see cref="NetRemoveAlternateComputerName"/> function requires that the caller is a member of the Administrators local group on the target computer.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dd877215.aspx">NetRemoveAlternateComputerName function</a></para>
        /// </remarks>
        /// <seealso cref="NetAddAlternateComputerName"/>
        /// <seealso cref="NetEnumerateComputerNames"/>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetSetPrimaryComputerName"/>
        /// <seealso cref="NetUnjoinDomain"/>
        /// <seealso cref="SetComputerNameEx"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetRemoveAlternateComputerName(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string Server,
            [In, MarshalAs(UnmanagedType.LPWStr)] string AlternateName,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string DomainAccount,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string DomainAccountPassword,
            [In] int Reserved
            );
        #endregion
        #region NetRemoteComputerSupports function
        /// <summary>
        /// The <see cref="NetRemoteComputerSupports"/> function queries the redirector to retrieve the optional features the remote system supports. Features include Unicode, Remote Procedure Call (RPC), and Remote Administration Protocol support. The function establishes a network connection if one does not exist.
        /// </summary>
        /// <param name="UncServerName">A string that specifies the name of the remote server to query. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="OptionsWanted">Specifies a value that contains a set of bit flags indicating the features of interest.</param>
        /// <param name="OptionsSupported">
        /// <para>A variable that receives a set of bit flags. The flags indicate which features specified by the OptionsWanted parameter are implemented on the computer specified by the UncServerName parameter. (All other bits are set to zero.) </para>
        /// <para>The value of this parameter is valid only when the <see cref="NetRemoteComputerSupports"/> function returns <see cref="NERR_Success"/>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Not enough memory is available to process this command.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// No special group membership is required to successfully execute the <see cref="NetRemoteComputerSupports"/> function.
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370611.aspx">NetRemoteComputerSupports function</a></para>
        /// </remarks>
        /// <seealso cref="NetServerGetInfo"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetRemoteComputerSupports(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string UncServerName,
            [In, MarshalAs(UnmanagedType.I4)] SUPPORTS_OPTIONS OptionsWanted,
            out SUPPORTS_OPTIONS OptionsSupported
            );
        #endregion
        #region NetRemoteTOD function
        /// <summary>
        /// The <see cref="NetRemoteTOD"/> function returns the time of day information from a specified server.
        /// </summary>
        /// <param name="UncServerName">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="BufferPtr">A variable that receives the <see cref="TIME_OF_DAY_INFO"/> information structure. This buffer is allocated by the system and should be wrapped in a <c>using</c> block to ensure that the buffer is freed. Otherwise, make sure the application calls the <see cref="SafeHandle.Dispose()"/> method directly, when the handle is no longer needed.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>If the function fails, the return value can be one of the following error codes or one of the system error codes.</para>
        /// </returns>
        /// <remarks>
        /// No special group membership is required to successfully execute the <see cref="NetRemoteTOD"/> function.
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370612.aspx">NetRemoteTOD function</a></para>
        /// </remarks>
        /// <seealso cref="TIME_OF_DAY_INFO"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetRemoteTOD(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string UncServerName,
            out TimeOfDayInfoNetApiBufferHandle BufferPtr
            );
        #endregion
        #region NetRenameMachineInDomain function
        /// <summary>
        /// The <see cref="NetRenameMachineInDomain"/> function changes the name of a computer in a domain.
        /// </summary>
        /// <param name="lpServer">A string that specifies the DNS or NetBIOS name of the computer on which to call the function. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="lpNewMachineName">A string that specifies the new name of the computer. If specified, the local computer name is changed as well. If this parameter is <c>null</c>, the function assumes you have already called the <see cref="SetComputerNameEx"/> function.</param>
        /// <param name="lpAccount">A string that specifies an account name to use when connecting to the domain controller. If this parameter is <c>null</c>, the caller's context is used.</param>
        /// <param name="lpPassword">If the <paramref name="lpAccount"/> parameter specifies an account name, this parameter must specify the password to use when connecting to the domain controller. Otherwise, this parameter must be <c>null</c>.</param>
        /// <param name="fRenameOptions">The rename options. If this parameter is <see cref="NETSETUP_ACCT_CREATE"/>, the function renames the account in the domain.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access is denied. This error is returned if the account name passed in the <paramref name="lpAccount"/> parameter did not have sufficient access rights for the operation. </description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect.</description>
        /// <term><see cref="NERR_SetupNotJoined"/></term><description>The computer is not currently joined to a domain.</description>
        /// <term><see cref="NERR_SetupDomainController"/></term><description>This computer is a domain controller and cannot be unjoined from a domain.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Renaming a domain computer can be performed only by a user that is a member of the Administrators local group on the target computer and that also is a member of the Administrators group on the domain or has the Account Operator privilege on the domain. If you call the <see cref="NetRenameMachineInDomain"/> function remotely, you must supply credentials because you cannot delegate credentials under these circumstances.</para>
        /// <para>Different processes, or different threads of the same process, should not call the <see cref="NetRenameMachineInDomain"/> function at the same time. This situation can leave the computer in an inconsistent state.</para>
        /// <para>A system reboot is required after calling the <see cref="NetRenameMachineInDomain"/> function for the operation to complete.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370613.aspx">NetRenameMachineInDomain function</a></para>
        /// </remarks>
        /// <seealso cref="NetAddAlternateComputerName"/>
        /// <seealso cref="NetEnumerateComputerNames"/>
        /// <seealso cref="NetRemoveAlternateComputerName"/>
        /// <seealso cref="NetSetPrimaryComputerName"/>
        /// <seealso cref="SetComputerNameEx"/>
        /// <seealso cref="NetUnjoinDomain"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetRenameMachineInDomain(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpServer,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpNewMachineName,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpAccount,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpPassword,
            [In, MarshalAs(UnmanagedType.I4)] NETSETUP_OPTIONS fRenameOptions
            );
        #endregion
        #region NetRequestOfflineDomainJoin function
        /// <summary>
        /// The <see cref="NetRequestOfflineDomainJoin"/> function executes locally on a machine to modify a Windows operating system image mounted on a volume. The registry is loaded from the image and provisioning blob data is written where it can be retrieved during the completion phase of an offline domain join operation. 
        /// </summary>
        /// <param name="pProvisionBinData">
        /// <para>A buffer required to initialize the registry of a Windows operating system image to process the final local state change during the completion phase of the offline domain join operation.</para>
        /// <para>The opaque binary blob of serialized metadata passed in the <var>pProvisionBinData</var> parameter is returned by the <see cref="NetProvisionComputerAccount(string, string, string, string, NETSETUP_PROVISION_FLAGS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> function. </para>
        /// </param>
        /// <param name="cbProvisionBinDataSize">The size, in bytes, of the buffer pointed to by the <paramref name="pProvisionBinData"/> parameter. </param>
        /// <param name="dwOptions">
        /// <para>A set of bit flags that define options for this function.</para>
        /// <para><see cref="NETSETUP_PROVISION_ONLINE_CALLER"/> - This flag is required if the <paramref name="lpWindowsPath"/> parameter references the currently running Windows operating system directory rather than an offline Windows operating system image mounted on an accessible volume. If this flag is specified, the <see cref="NetRequestOfflineDomainJoin"/> function must be invoked by a member of the local Administrators group.</para>
        /// </param>
        /// <param name="lpWindowsPath">
        /// <para>A string that specifies the path to a Windows operating system image under which the registry hives are located. This image must be offline and not currently booted unless the <paramref name="dwOptions"/> parameter contains <see cref="NETSETUP_PROVISION_ONLINE_CALLER"/> in which case the locally running operating system directory is allowed. </para>
        /// <para>This path could be a UNC path on a remote server.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access is denied. This error is returned if the caller does not have sufficient privileges to complete the operation. </description>
        /// <term><see cref="ERROR_ELEVATION_REQUIRED"/></term><description>The requested operation requires elevation.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="pProvisionBinData"/>, <paramref name="cbProvisionBinDataSize"/>, or <paramref name="lpWindowsPath"/> parameters are <c>null</c>. This error is also returned if the buffer pointed to by the <var>pProvisionBinData</var> parameter does not contain valid data in the blob for the domain, machine account name, or machine account password. This error is also returned if the string specified by <paramref name="lpWindowsPath"/> parameter does not specify the path to a Windows operating system image.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if the specified server does not support this operation. For example, if the <paramref name="lpWindowsPath"/> parameter references a Windows installation configured as a domain controller.</description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term><description>The Workstation service has not been started.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetRequestOfflineDomainJoin"/> function is supported on Windows 7 for offline domain join operations. </para>
        /// <para>
        /// The <see cref="NetRequestOfflineDomainJoin"/> function is used locally on a machine to modify a Windows operating system image mounted on a volume. The registry is loaded for the image and provisioning blob data is written where it can be retrieved during the completion phase of an offline domain join operation. The offline domain join scenario uses these functions as follows:
        /// <list type="bullet">
        /// <item><see cref="NetProvisionComputerAccount(string, string, string, string, NETSETUP_PROVISION_FLAGS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> is a provisioning function that is first called to perform the network operations necessary to create and configure the computer object in Active Directory. The output from the <see cref="NetProvisionComputerAccount"/> is an opaque binary blob of serialized metadata used for the next step.</item>
        /// <item><see cref="NetRequestOfflineDomainJoin"/> , an image initialization function, is then called to inject the output from the <see cref="NetProvisionComputerAccount(string, string, string, string, NETSETUP_PROVISION_FLAGS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> provisioning function into a Windows operating system image to be used during installation. Changes to Windows initialization code will detect this saved state and affect the local only portion of domain join.</item>
        /// </list>
        /// </para>
        /// <para>The <see cref="NetProvisionComputerAccount(string, string, string, string, NETSETUP_PROVISION_FLAGS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> function will create or reuse the machine account in the domain, collect all necessary metadata and return it in an opaque versioned binary blob or as text for embedding in an unattended setup answer file. The opaque binary blob can be consumed by the offline domain join request operation supplying all the necessary input to complete the domain join during first boot without any network operations (local state updates only). Note that the blob contains machine account password material essentially in the clear. The design makes no provisions for securing this data. This problem exists today with unattended setup answer files which can carry a number of secrets including domain user passwords. The caller must secure the blob and the unattended setup files. Solutions to this problem are varied. As an example, a pre-exchanged key could be used to encrypt a session between the consumer and provisioning entity enabling a secure transfer of the opaque blob . </para>
        /// <para>The opaque blob returned in the <paramref name="pProvisionBinData"/> parameter by the <see cref="NetProvisionComputerAccount(string, string, string, string, NETSETUP_PROVISION_FLAGS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> function is versioned to allow interoperability and serviceability scenarios between different versions of Windows (joining client, provisioning machine, and domain controller). The offline join scenario currently does not limit the lifetime of the blob returned by the <see cref="NetProvisionComputerAccount(string, string, string, string, NETSETUP_PROVISION_FLAGS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> function. </para>
        /// <para>For more information on offline domain join operations, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152786">Offline Domain Join Step-by-Step Guide</a>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 7 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: None supported [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dd815229.aspx">NetRequestOfflineDomainJoin function</a></para>
        /// </remarks>
        /// <seealso cref="NetCreateProvisioningPackage"/>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetProvisionComputerAccount"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetRequestProvisioningPackageInstall"/>
        /// <seealso cref="NetUnjoinDomain"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetRequestOfflineDomainJoin(
            [In, MarshalAs(UnmanagedType.LPArray)] byte[] pProvisionBinData,
            [In] int cbProvisionBinDataSize,
            [In, MarshalAs(UnmanagedType.I4)] NETSETUP_PROVISION_FLAGS dwOptions,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpWindowsPath
            );
        #endregion
        #region NetRequestProvisioningPackageInstall function
        /// <summary>
        /// The <see cref="NetRequestProvisioningPackageInstall"/> function executes locally on a machine to modify a Windows operating system image mounted on a volume. The registry is loaded from the image and provisioning package data is written where it can be retrieved during the completion phase of an offline domain join operation. 
        /// </summary>
        /// <param name="pProvisionBinData">
        /// <para>A buffer required to initialize the registry of a Windows operating system image to process the final local state change during the completion phase of the offline domain join operation. </para>
        /// <para>The opaque binary blob of serialized metadata passed in the <paramref name="pProvisionBinData"/> parameter is returned by the <see cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> function. </para>
        /// </param>
        /// <param name="dwPackageBinDataSize">The size, in bytes, of the buffer pointed to by the <paramref name="pProvisionBinData"/> parameter. </param>
        /// <param name="dwProvisionOptions">
        /// <para>A set of bit flags that define options for this function.</para>
        /// <para><see cref="NETSETUP_PROVISION_ONLINE_CALLER"/> - This flag is required if the <paramref name="lpWindowsPath"/> parameter references the currently running Windows operating system directory rather than an offline Windows operating system image mounted on an accessible volume. If this flag is specified, the <see cref="NetRequestProvisioningPackageInstall"/> function must be invoked by a member of the local Administrators group.</para>
        /// </param>
        /// <param name="lpWindowsPath">
        /// <para>A string that specifies the path to a Windows operating system image under which the registry hives are located. This image must be offline and not currently booted unless the <paramref name="dwOptions"/> parameter contains <see cref="NETSETUP_PROVISION_ONLINE_CALLER"/> in which case the locally running operating system directory is allowed. </para>
        /// <para>This path could be a UNC path on a remote server.</para>
        /// </param>
        /// <param name="pvReserved">Reserved for future use.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes or one of the system error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="NERR_NoOfflineJoinInfo"/></term><description>The offline join completion information was not found.</description>
        /// <term><see cref="NERR_BadOfflineJoinInfo"/></term><description>The offline join completion information was bad.</description>
        /// <term><see cref="NERR_CantCreateJoinInfo"/></term><description>Unable to create offline join information. Please ensure you have access to the specified path location and permissions to modify its contents. Running as an elevated administrator may be required.</description>
        /// <term><see cref="NERR_BadDomainJoinInfo"/></term><description>The domain join info being saved was incomplete or bad.</description>
        /// <term><see cref="NERR_JoinPerformedMustRestart"/></term><description>Offline join operation successfully completed but a restart is needed.</description>
        /// <term><see cref="NERR_NoJoinPending"/></term><description>There was no offline join operation pending.</description>
        /// <term><see cref="NERR_ValuesNotSet"/></term><description>Unable to set one or more requested machine or domain name values on the local computer.</description>
        /// <term><see cref="NERR_CantVerifyHostname"/></term><description>Could not verify the current machine's hostname against the saved value in the join completion information.</description>
        /// <term><see cref="NERR_CantLoadOfflineHive"/></term><description>Unable to load the specified offline registry hive. Please ensure you have access to the specified path location and permissions to modify its contents. Running as an elevated administrator may be required.</description>
        /// <term><see cref="NERR_ConnectionInsecure"/></term><description>The minimum session security requirements for this operation were not met.</description>
        /// <term><see cref="NERR_ProvisioningBlobUnsupported"/></term><description>Computer account provisioning blob version is not supported.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetRequestProvisioningPackageInstall"/> function is supported on Windows 8 for offline domain join operations. For Windows 7, use <see cref="NetRequestOfflineDomainJoin"/>.</para>
        /// <para>
        /// The offline domain join scenario uses two functions: 
        /// <list type="bullet">
        /// <item><see cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> is a provisioning function that is first called to perform the network operations necessary to create and configure the computer object in Active Directory. The output from the <see cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> is a package used for the next step.</item>
        /// <item><see cref="NetRequestProvisioningPackageInstall"/>, an image initialization function, is called to inject the output from the <see cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> provisioning function into a Windows operating system image for use during installation. </item>
        /// </list>
        /// </para>
        /// <para>Changes to Windows initialization code will detect this saved state and affect the local-only portion of domain join and install any certificate and policy information that may have been present in the package.<br/> The <see cref="NetCreateProvisioningPackage"/> function will create or reuse the machine account in the domain, collect all necessary metadata and return it in a package.The package can be consumed by the offline domain join request operation supplying all the necessary input to complete the domain join during first boot without any network operations (local state updates only). </para>
        /// <para><note type="security">The package created by the <see cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> function contains very sensitive data. It should be treated just as securely as a plaintext password. The package contains the machine account password and other information about the domain, including the domain name, the name of a domain controller, and the security ID (SID) of the domain. If the package is being transported physically or over the network, care must be taken to transport it securely. The design makes no provisions for securing this data. This problem exists today with unattended setup answer files which can carry a number of secrets including domain user passwords. The caller must secure the package. Solutions to this problem are varied. As an example, a pre-exchanged key could be used to encrypt a session between the consumer and provisioning entity enabling a secure transfer of the package. </note></para>
        /// <para>The package returned in the <var>pPackageBinData</var> parameter by the <see cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/> function is versioned to allow interoperability and serviceability scenarios between different versions of Windows (such as joining a client, provisioning a machine, and using a domain controller). The offline join scenario currently does not limit the lifetime of the package returned by the <see cref="NetCreateProvisioningPackage"/> function.</para>
        /// <para>All phases of the provisioning process append to a <var>NetSetup.log</var> file on the local computer. The provisoning process can include up to three different computers: the computer where the provisioning package is created, the computer that requests the installation of the package, and the computer where the package is installed. There will be <var>NetSetup.log</var> file information stored on all three computers according to the operation performed. Reviewing the contents of these files is the most common means of troubleshooting online and offline provisioning errors. Provisioning operations undertaken by admins are logged to the <var>NetSetup.log</var> file in the <var>%WINDIR%\Debug</var>. Provisioning operations performed by non-admins are logged to the NetSetup.log file in the <var>%USERPROFILE%\Debug</var> folder.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 8 [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2012 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/hh706771.aspx">NetRequestProvisioningPackageInstall function</a></para>
        /// </remarks>
        /// <seealso cref="NetCreateProvisioningPackage(NETSETUP_PROVISIONING_PARAMS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetProvisionComputerAccount(string, string, string, string, NETSETUP_PROVISION_FLAGS, out NetRequestOfflineDomainJoinBinDataBuffer, out int, IntPtr)"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetRequestOfflineDomainJoin"/>
        /// <seealso cref="NetUnjoinDomain"/>
        /// <seealso cref="NETSETUP_PROVISIONING_PARAMS"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetRequestProvisioningPackageInstall(
            [In, MarshalAs(UnmanagedType.LPArray)] byte[] pProvisionBinData,
            [In] int dwPackageBinDataSize,
            [In, MarshalAs(UnmanagedType.I4)] NETSETUP_PROVISION_FLAGS dwProvisionOptions,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpWindowsPath,
            [In] IntPtr pvReserved
            );
        #endregion
        #region NetScheduleJobAdd function
        /// <summary>
        /// The <see cref="NetScheduleJobAdd"/> function submits a job to run at a specified future time and date. This function requires that the schedule service be started on the computer to which the job is submitted. 
        /// </summary>
        /// <param name="Servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="Buffer">An <see cref="AT_INFO"/> structure describing the job to submit.</param>
        /// <param name="JobId">A variable that receives a job identifier for the newly submitted job. This entry is valid only if the function returns successfully.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>If the function fails, the return value is a system error code. For a list of error codes, see System Error Codes.</para>
        /// </returns>
        /// <remarks>
        /// <para>Normally only members of the local Administrators group on the computer where the schedule job is being added can successfully execute this function. If the server name passed in the string pointed to by the <paramref name="Servername"/> parameter is a remote server, then only members of the local Administrators group on the remote server can successfully execute this function. </para>
        /// <para>
        /// If the following registry value has the least significant bit set (for example, 0x00000001), then users belonging to the Server Operators group can also successfully execute this function. 
        /// <code>HKLM\System\CurrentControlSet\Control\Lsa\SubmitControl</code>
        /// </para>
        /// <para>The following are examples of how to schedule jobs using different properties supported by the <see cref="NetScheduleJobAdd"/> function.</para>
        /// <para>
        /// To schedule a job that executes once:
        /// <list type="bullet">
        /// <item>Set the <see cref="AT_INFO.DaysOfMonth"/> member of the <see cref="AT_INFO"/> structure to zero.</item>
        /// <item>Set the <see cref="AT_INFO.DaysOfWeek"/> member of the <see cref="AT_INFO"/> structure to zero.</item>
        /// <item>Set the <see cref="AT_INFO.JobTime"/> member of the <see cref="AT_INFO"/> structure to the time the job should execute.</item>
        /// </list>
        /// The job executes at the time specified by the <see cref="AT_INFO.JobTime"/> member of the <see cref="AT_INFO"/> structure pointed to by the <paramref name="Buffer"/> parameter. After the job executes, it is deleted.
        /// </para>
        /// <para>
        /// To schedule and delete a job that executes multiple times:
        /// <list type="bullet">
        /// <item>Set the appropriate bits in the <see cref="AT_INFO.DaysOfMonth"/> member of the <see cref="AT_INFO"/> structure or</item>
        /// <item>Set the appropriate bits in the <see cref="AT_INFO.DaysOfWeek"/> member of the <see cref="AT_INFO"/> structure.</item>
        /// <item>Set the <see cref="AT_INFO.JobTime"/> member of the <see cref="AT_INFO"/> structure to the time the job should execute.</item>
        /// </list>
        /// <note>You do not need to set both the <see cref="AT_INFO.DaysOfMonth"/> and the <see cref="AT_INFO.DaysOfWeek"/> members of the <see cref="AT_INFO"/> structure.</note>
        /// </para>
        /// <para>The job executes at the time specified by the <see cref="AT_INFO.JobTime"/> member of the <see cref="AT_INFO"/> structure pointed to by the <paramref name="Buffer"/> parameter, once for each day set in the <see cref="AT_INFO.DaysOfMonth"/> or <see cref="AT_INFO.DaysOfWeek"/> members of the <see cref="AT_INFO"/> structure. After each job executes, the corresponding bit is cleared. When the last bit is cleared, the job is deleted.</para>
        /// <para>
        /// To schedule a job that executes periodically:
        /// <list type="bullet">
        /// <item>Set the appropriate bits in the <see cref="AT_INFO.DaysOfMonth"/> member of the <see cref="AT_INFO"/> structure or</item>
        /// <item>Set the appropriate bits in the <see cref="AT_INFO.DaysOfWeek"/> member of the <see cref="AT_INFO"/> structure. </item>
        /// <item>Set the <see cref="AT_INFO.JobTime"/> member of the <see cref="AT_INFO"/> structure to the time the job should execute.</item>
        /// <item>Set the job submission flag <see cref="JOB_RUN_PERIODICALLY"/> in the <see cref="AT_INFO.Flags"/> member of the <see cref="AT_INFO"/> structure.</item>
        /// </list>
        /// <note>You do not need to set both the <see cref="AT_INFO.DaysOfMonth"/> and the <see cref="AT_INFO.DaysOfWeek"/> members of the <see cref="AT_INFO"/> structure.</note>
        /// </para>
        /// <para>The job will execute periodically, at the time specified by the <see cref="AT_INFO.JobTime"/> member of the <see cref="AT_INFO"/> structure pointed to by the <paramref name="Buffer"/> parameter, on each day set in the <see cref="AT_INFO.DaysOfMonth"/> or <see cref="AT_INFO.DaysOfWeek"/> member of the <see cref="AT_INFO"/> structure. The job will not be deleted as a result of the repeated executions. The only way to delete the job is by an explicit call to the <see cref="NetScheduleJobDel"/> function.</para>
        /// <para>See the <see cref="AT_INFO"/> structure for a description of the <see cref="AT_INFO.DaysOfWeek"/>, <see cref="AT_INFO.DaysOfMonth"/>, and job property bitmasks.</para>
        /// <para>On Windows 2000, the earlier AT service and the Task Scheduler were combined. The Task Scheduler service was only accurate to the minute. Therefore, the <see cref="NetScheduleJobAdd"/> function only uses hours and minutes specified in the <see cref="AT_INFO.JobTime"/> member of the <see cref="AT_INFO"/> structure when a job is scheduled to run. </para>
        /// <para>Starting with Windows Vista, the precision for the Task Scheduler was increased to the second. Therefore, the <see cref="NetScheduleJobAdd"/> function uses only the hours, minutes, and seconds specified in the <see cref="AT_INFO.JobTime"/> member of the <see cref="AT_INFO"/> structure when a job is scheduled to run. </para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows 7</para>
        /// <para><strong>End of server support</strong>: Windows Server 2008</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370614.aspx">NetScheduleJobAdd function</a></para>
        /// </remarks>
        /// <seealso cref="AT_INFO"/>
        /// <seealso cref="NetScheduleJobDel"/>
        /// <seealso cref="NetScheduleJobEnum"/>
        /// <seealso cref="NetScheduleJobGetInfo"/>
        [Obsolete("NetScheduleJobAdd is no longer available for use as of Windows 8. Instead, use the Task Scheduler 2.0 Interfaces.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetScheduleJobAdd(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string Servername,
            [In, MarshalAs(UnmanagedType.LPStruct)] AT_INFO Buffer,
            out int JobId
            );
        #endregion
        #region NetScheduleJobDel function
        /// <summary>
        /// The <see cref="NetScheduleJobDel"/> function deletes a range of jobs queued to run at a computer. This function requires that the schedule service be started at the computer to which the job deletion request is being sent. 
        /// </summary>
        /// <param name="Servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="MinJobId">The minimum job identifier. Jobs with a job identifier smaller than <paramref name="MinJobId"/> will not be deleted.</param>
        /// <param name="MaxJobId">The maximum job identifier. Jobs with a job identifier larger than <paramref name="MaxJobId"/> will not be deleted.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>If the function fails, the return value is a system error code. For a list of error codes, see System Error Codes.</para>
        /// </returns>
        /// <remarks>
        /// <para>Normally only members of the local Administrators group on the computer where the schedule job is being deleted can successfully execute this function. If the server name passed in the string pointed to by the <paramref name="Servername"/> parameter is a remote server, then only members of the local Administrators group on the server can successfully execute this function. </para>
        /// <para>
        /// If the following registry value has the least significant bit set (for example, <c>0x00000001</c>), then users belonging to the Server Operators group can also successfully execute this function. 
        /// <code>HKLM\System\CurrentControlSet\Control\Lsa\SubmitControl</code>
        /// </para>
        /// <para>Call the <see cref="NetScheduleJobEnum"/> function to retrieve the job identifier for one or more scheduled jobs.</para>
        /// <para>The <see cref="NetScheduleJobDel"/> function deletes all jobs whose job identifiers are in the range <paramref name="MinJobId"/> through <paramref name="MaxJobId"/>.</para>
        /// <para>To delete all scheduled jobs at the server, you can call <see cref="NetScheduleJobDel"/> specifying <paramref name="MinJobId"/> equal to <c>0</c> (zero) and <paramref name="MaxJobId"/> equal to <c>-1</c>. To delete one job, specify the job's identifier for both the <paramref name="MinJobId"/> parameter and the <paramref name="MaxJobId"/> parameter.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows 7</para>
        /// <para><strong>End of server support</strong>: Windows Server 2008</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370615.aspx">NetScheduleJobDel function</a></para>
        /// </remarks>
        /// <seealso cref="NetScheduleJobAdd"/>
        /// <seealso cref="NetScheduleJobEnum"/>
        /// <seealso cref="NetScheduleJobGetInfo"/>
        [Obsolete("NetScheduleJobAdd is no longer available for use as of Windows 8. Instead, use the Task Scheduler 2.0 Interfaces.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetScheduleJobDel(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string Servername,
            [In] int MinJobId,
            [In] int MaxJobId
            );
        #endregion
        #region NetScheduleJobEnum function
        /// <summary>
        /// The <see cref="NetScheduleJobEnum"/> function lists the jobs queued on a specified computer. This function requires that the schedule service be started. 
        /// </summary>
        /// <param name="Servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="PointerToBuffer">A variable that receives the data. The return information is an array of <see cref="AT_ENUM"/> structures. The buffer is allocated by the system and the returned handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="PreferredMaximumLength">A value that indicates the preferred maximum length of the returned data, in bytes. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required for the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="EntriesRead">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="TotalEntries">A variable that receives the total number of entries that could have been enumerated from the current resume position. Note that applications should consider this value only as a hint.</param>
        /// <param name="ResumeHandle">A reference to a pointer contains a resume handle which is used to continue a job enumeration. The handle should be zero on the first call and left unchanged for subsequent calls. If this parameter is omitted, then no resume handle is stored.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>If the function fails, the return value is a system error code. For a list of error codes, see System Error Codes.</para>
        /// </returns>
        /// <remarks>
        /// <para>Normally only members of the local Administrators group on the computer where the schedule job is being enumerated can successfully execute this function. If the server name passed in the string pointed to by the <paramref name="Servername"/> parameter is a remote server, then only members of the local Administrators group on the server can successfully execute this function. </para>
        /// <para>
        /// If the following registry value has the least significant bit set (for example, <c>0x00000001</c>), then users belonging to the Server Operators group can also successfully execute this function. 
        /// <code>HKLM\System\CurrentControlSet\Control\Lsa\SubmitControl</code>
        /// </para>
        /// <para>Each entry returned contains an <see cref="AT_ENUM"/> structure. The value of the <see cref="AT_ENUM.JobId"/> member can be used when calling functions that require a job identifier parameter, such as the <see cref="NetScheduleJobDel"/> function.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows 7</para>
        /// <para><strong>End of server support</strong>: Windows Server 2008</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370616.aspx">NetScheduleJobEnum function</a></para>
        /// </remarks>
        /// <seealso cref="AT_ENUM"/>
        /// <seealso cref="NetScheduleJobAdd"/>
        /// <seealso cref="NetScheduleJobDel"/>
        /// <seealso cref="NetScheduleJobGetInfo"/>
        [Obsolete("NetScheduleJobAdd is no longer available for use as of Windows 8. Instead, use the Task Scheduler 2.0 Interfaces.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetScheduleJobEnum(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string Servername,
            out AtEnumArrayNetApiNetApiBufferHandle PointerToBuffer,
            [In] int PreferredMaximumLength,
            out int EntriesRead,
            out int TotalEntries,
            [Optional] ref IntPtr ResumeHandle
            );
        #endregion
        #region NetScheduleJobGetInfo function
        /// <summary>
        /// The <see cref="NetScheduleJobGetInfo"/> function retrieves information about a particular job queued on a specified computer. This function requires that the schedule service be started. 
        /// </summary>
        /// <param name="Servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="JobId">A value that indicates the identifier of the job for which to retrieve information.</param>
        /// <param name="PointerToBuffer">A variable that receives the data. The return information is a <see cref="AT_INFO"/> structure. The buffer is allocated by the system and the returned handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>If the function fails, the return value is a system error code. For a list of error codes, see System Error Codes.</para>
        /// </returns>
        /// <remarks>
        /// <para>Normally only members of the local Administrators group on the computer where the schedule job is being enumerated can successfully execute this function. If the server name passed in the string pointed to by the <paramref name="Servername"/> parameter is a remote server, then only members of the local Administrators group on the server can successfully execute this function. </para>
        /// <para>
        /// If the following registry value has the least significant bit set (for example, <c>0x00000001</c>), then users belonging to the Server Operators group can also successfully execute this function. 
        /// <code>HKLM\System\CurrentControlSet\Control\Lsa\SubmitControl</code>
        /// </para>
        /// <para>Each entry returned contains an <see cref="AT_ENUM"/> structure. The value of the <see cref="AT_ENUM.JobId"/> member can be used when calling functions that require a job identifier parameter, such as the <see cref="NetScheduleJobDel"/> function.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para><strong>End of client support</strong>: Windows 7</para>
        /// <para><strong>End of server support</strong>: Windows Server 2008</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370617.aspx">NetScheduleJobGetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="AT_INFO"/>
        /// <seealso cref="NetScheduleJobAdd"/>
        /// <seealso cref="NetScheduleJobDel"/>
        /// <seealso cref="NetScheduleJobEnum"/>
        [Obsolete("NetScheduleJobGetInfo is no longer available for use as of Windows 8. Instead, use the Task Scheduler 2.0 Interfaces.")]
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetScheduleJobGetInfo(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string Servername,
            [In] int JobId,
            out AtIntoNetApiNetApiBufferHandle PointerToBuffer
            );
        #endregion
        #region NetServerComputerNameAdd function
        /// <summary>
        /// <para>The <see cref="NetServerComputerNameAdd"/> function enumerates the transports on which the specified server is active, and binds the emulated server name to each of the transports.</para>
        /// <para><see cref="NetServerComputerNameAdd"/> is a utility function that combines the functionality of the <see cref="NetServerTransportEnum"/> function and the <see cref="NetServerTransportAddEx"/> function.</para>
        /// </summary>
        /// <param name="ServerName">A string that specifies the name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="EmulatedDomainName">A string that contains the domain name the specified server should use when announcing its presence using the <paramref name="EmulatedServerName"/>. This parameter is optional.</param>
        /// <param name="EmulatedServerName">A string that contains the emulated name the server should begin supporting in addition to the name specified by the <paramref name="ServerName"/> parameter.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>. Note that <see cref="NetServerComputerNameAdd"/> succeeds if the emulated server name specified is added to at least one transport.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_DUP_NAME"/></term><description>A duplicate name exists on the network.</description>
        /// <term><see cref="ERROR_INVALID_DOMAINNAME"/></term><description>The domain name could not be found on the network.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>The specified parameter is invalid.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators or Server Operators local group can successfully execute the <see cref="NetServerComputerNameAdd"/> function.</para>
        /// <para>The server specified by the <paramref name="ServerName"/> parameter continues to support all names it was supporting, and additionally begins to support new names supplied by successful calls to the <see cref="NetServerComputerNameAdd"/> function.</para>
        /// <para>Name emulation that results from a call to <see cref="NetServerComputerNameAdd"/> ceases when the server reboots or restarts. To discontinue name emulation set by a previous call to <see cref="NetServerComputerNameAdd"/> without restarting or rebooting, you can call the <see cref="NetServerComputerNameDel"/> function.</para>
        /// <para>The <see cref="NetServerComputerNameAdd"/> function is typically used when a system administrator replaces a server, but wants to keep the conversion transparent to users. </para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370620.aspx">NetServerComputerNameAdd function</a></para>
        /// </remarks>
        /// <seealso cref="NetServerTransportEnum"/>
        /// <seealso cref="NetServerTransportAdd"/>
        /// <seealso cref="NetServerTransportAddEx"/>
        /// <seealso cref="NetServerComputerNameDel "/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetServerComputerNameAdd(
            [In, MarshalAs(UnmanagedType.LPWStr)] string ServerName,
            [In, MarshalAs(UnmanagedType.LPWStr)] string EmulatedDomainName,
            [In, MarshalAs(UnmanagedType.LPWStr)] string EmulatedServerName
            );
        #endregion
        #region NetServerComputerNameDel function
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ServerName">A string that specifies the name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="EmulatedServerName">A string that contains the emulated name the server should stop supporting. The server continues to support all other server names it was supporting.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>The specified parameter is invalid.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// <term><see cref="NERR_NetNameNotFound"/></term><description>The share name does not exist.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators or Server Operators local group can successfully execute the <see cref="NetServerComputerNameDel"/> function.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370621.aspx">NetServerComputerNameDel function</a></para>
        /// </remarks>
        /// <seealso cref="NetServerComputerNameAdd"/>
        /// <seealso cref="NetServerTransportEnum"/>
        /// <seealso cref="NetServerTransportAdd"/>
        /// <seealso cref="NetServerTransportAddEx"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetServerComputerNameDel(
            [In, MarshalAs(UnmanagedType.LPWStr)] string ServerName,
            [In, MarshalAs(UnmanagedType.LPWStr)] string EmulatedServerName
            );
        #endregion
        #region NetServerDiskEnum function
        /// <summary>
        /// The <see cref="NetServerDiskEnum"/> function retrieves a list of disk drives on a server. The function returns an array of three-character strings (a drive letter, a colon, and a terminating null character).
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">The level of information required. A value of zero is the only valid level. </param>
        /// <param name="bufptr">A variable that receives the data. The data is an array of three-character strings (a drive letter, a colon, and a terminating null character). This buffer is allocated by the system and must be freed by wrapping the returned handle in a <c>using</c> block. Otherwise, the application must ensure to call the <see cref="SafeHandle.Dispose()"/> method on the returned handle directly when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="prefmaxlen">
        /// The preferred maximum length of returned data, in bytes. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required for the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.
        /// <note>This parameter is currently ignored.</note>
        /// </param>
        /// <param name="entriesread">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="totalentries">A variable that receives the total number of entries that could have been enumerated from the current resume position. Note that applications should consider this value only as a hint.</param>
        /// <param name="resume_handle">A reference to a variable that contains a resume handle which is used to continue an existing server disk search. The handle should be zero on the first call and left unchanged for subsequent calls. If the <paramref name="resume_handle"/> parameter is omitted, then no resume handle is stored.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the level parameter is invalid.</description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if a remote server was specified in <paramref name="servername"/> parameter, the remote server only supports remote RPC calls using the legacy Remote Access Protocol mechanism, and this request is not supported. </description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators or Server Operators local group can successfully execute the <see cref="NetServerDiskEnum"/> function on a remote computer.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same results you can achieve by calling the network management server functions. For more information, see the <see cref="IADsComputer"/> interface reference.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370622.aspx">NetServerDiskEnum function</a></para>
        /// </remarks>
        /// <seealso cref="IADsComputer"/>
        /// <seealso cref="NetServerEnum"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetServerDiskEnum(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            out WideStringZeroTerminatedArrayNetApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries,
            [Optional] ref IntPtr resume_handle
            );
        #endregion
        #region NetServerEnum function
        /// <summary>
        /// The <see cref="NetServerEnum"/> function lists all servers of the specified type that are visible in a domain. 
        /// </summary>
        /// <param name="servername">Reserved; must be <c>null</c>.</param>
        /// <param name="level">
        /// The information level of the data requested. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>100</c></term> - <description>Return server names and platform information. The <paramref name="bufptr"/> parameter receives an array of <see cref="SERVER_INFO_100"/> structures.</description>
        /// <term><c>101</c></term> - <description>Return server names, types, and associated data. The <paramref name="bufptr"/> parameter receives an array of <see cref="SERVER_INFO_101"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">A variable that receives the data. The format of this data depends on the value of the <paramref name="level"/> parameter. This buffer is allocated by the system and must be freed by wrapping the returned handle in a <c>using</c> block. Otherwise, the application must ensure to call the <see cref="SafeHandle.Dispose()"/> method on the returned handle directly when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="prefmaxlen">The preferred maximum length of returned data, in bytes. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required for the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="entriesread">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="totalentries">A variable that receives the total number of entries that could have been enumerated from the current resume position. Note that applications should consider this value only as a hint.</param>
        /// <param name="servertype">A value that filters the server entries to return from the enumeration.</param>
        /// <param name="domain">
        /// <para>A string that specifies the name of the domain for which a list of servers is to be returned. The domain name must be a NetBIOS domain name (for example, <c>microsoft</c>). The <see cref="NetServerEnum"/> function does not support DNS-style names (for example, <c>microsoft.com</c>). </para>
        /// <para>If this parameter is <c>null</c>, the primary domain is implied.</para>
        /// </param>
        /// <param name="resume_handle">Reserved; must be set to zero.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access was denied.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>The parameter is incorrect.</description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// <term><see cref="ERROR_NO_BROWSER_SERVERS_FOUND"/></term><description>No browser servers found.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported.</description>
        /// <term><see cref="NERR_RemoteErr"/></term><description>A remote error occurred with no data returned by the server.</description>
        /// <term><see cref="NERR_ServerNotStarted"/></term><description>The server service is not started.</description>
        /// <term><see cref="NERR_ServiceNotInstalled"/></term><description>The service has not been started.</description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term><description>The Workstation service has not been started. The local workstation service is used to communicate with a downlevel remote server.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetServerEnum"/> function is used to list all servers of the specified type that are visible in a domain. For example, an application can call <see cref="NetServerEnum"/> to list all domain controllers only or all servers that run instances of SQL server only.</para>
        /// <para>An application combine the bit masks for various server types in the <paramref name="servertype"/> parameter to list several types. For example, a value of <c><see cref="SV_TYPE_WORKSTATION"/> | <see cref="SV_TYPE_SERVER"/></c> (<c>0x00000003</c>) combines the bit masks for <see cref="SV_TYPE_WORKSTATION"/> (<c>0x00000001</c>) and <see cref="SV_TYPE_SERVER"/> (<c>0x00000002</c>).</para>
        /// <para>If you require more information for a specific server, call the <see cref="WNetEnumResource"/> function.</para>
        /// <para>No special group membership is required to successfully execute the <see cref="NetServerEnum"/> function.</para>
        /// <para>If you specify the value <see cref="SV_TYPE_LOCAL_LIST_ONLY"/>, the <see cref="NetServerEnum"/> function returns the list of servers that the browser maintains internally. This has meaning only on the master browser (or on a computer that has been the master browser in the past). The master browser is the computer that currently has rights to determine which computers can be servers or workstations on the network.</para>
        /// <para>If there are no servers found that match the types specified in the <paramref name="servertype"/> parameter, the <see cref="NetServerEnum"/> function returns the <paramref name="bufptr"/> parameter as <c>null</c> and the out values referred to by the <paramref name="entriesread"/> and <paramref name="totalentries"/> parameters are set to zero.</para>
        /// <para>The <see cref="NetServerEnum"/> function depends on the browser service being installed and running. If no browser servers are found, then <see cref="NetServerEnum"/> fails with <see cref="ERROR_NO_BROWSER_SERVERS_FOUND"/>.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same results you can achieve by calling the network management server functions. For more information, see the <see cref="IADsComputer"/> interface reference.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370623.aspx">NetServerEnum function</a></para>
        /// </remarks>
        /// <seealso cref="NetServerDiskEnum"/>
        /// <seealso cref="NetQueryDisplayInformation"/>
        /// <seealso cref="SERVER_INFO_100"/>
        /// <seealso cref="SERVER_INFO_101"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetServerEnum(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            out ServerInfoArrayNetApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries,
            [In, MarshalAs(UnmanagedType.I4)] SV_TYPE_FLAGS servertype,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string domain,
            [Optional] ref IntPtr resume_handle
            );
        #endregion
        #region NetServerGetInfo function
        /// <summary>
        /// The <see cref="NetServerGetInfo"/> function retrieves current configuration information for the specified server.
        /// </summary>
        /// <param name="servername">A string that specifies the name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>100</c></term> - <description>Return server names and platform information. The <paramref name="bufptr"/> parameter receives a <see cref="SERVER_INFO_100"/> structure.</description>
        /// <term><c>101</c></term> - <description>Return server names, types, and associated software. The <paramref name="bufptr"/> parameter receives a <see cref="SERVER_INFO_101"/> structure.</description>
        /// <term><c>102</c></term> - <description>Return the server name, type, associated software, and other attributes. The <paramref name="bufptr"/> parameter receives a <see cref="SERVER_INFO_102"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">A variable that receives the data. The format of this data depends on the value of the <paramref name="level"/> parameter. This buffer is allocated by the system and must be freed by wrapping the returned handle in a <c>using</c> block. Otherwise, the application must ensure to call the <see cref="SafeHandle.Dispose()"/> method on the returned handle directly when it is no longer needed.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the <paramref name="level"/> parameter is invalid.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>The specified parameter is invalid.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only the Administrators or Server Operators local group, or those with Print or Server Operator group membership, can successfully execute the <see cref="NetServerGetInfo"/> function at level <c>102</c>. No special group membership is required for level <c>100</c> or level <c>101</c> calls.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same results you can achieve by calling the network management server functions. For more information, see the <see cref="IADsComputer"/> interface reference.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370624.aspx">NetServerGetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="NetServerSetInfo"/>
        /// <seealso cref="SERVER_INFO_100"/>
        /// <seealso cref="SERVER_INFO_101"/>
        /// <seealso cref="SERVER_INFO_102"/>
        /// <seealso cref="NetRemoteComputerSupports"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetServerGetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            out ServerInfoNetApiBufferHandle bufptr
            );
        #endregion
        #region NetServerSetInfo function
        /// <summary>
        /// The <see cref="NetServerSetInfo"/> function sets a server's operating parameters; it can set them individually or collectively. The information is stored in a way that allows it to remain in effect after the system has been reinitialized.
        /// </summary>
        /// <param name="servername">A string that specifies the name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>100</c></term> - <description>Specifies the server name, type, and associated software. The <paramref name="buf"/> specifies a <see cref="SERVER_INFO_101"/> structure.</description>
        /// <term><c>101</c></term> - <description>Specifies the server name, type, associated software, and other attributes. The <paramref name="buf"/> specifies a <see cref="SERVER_INFO_102"/> structure.</description>
        /// <term><c>402</c></term> - <description>Specifies detailed information about the server. The <paramref name="buf"/> specifies a <see cref="SERVER_INFO_402"/> structure.</description>
        /// <term><c>403</c></term> - <description>Specifies detailed information about the server. The <paramref name="buf"/> specifies a <see cref="SERVER_INFO_403"/> structure.</description>
        /// </list>
        /// <para>In addition, levels 1001-1006, 1009-1011, 1016-1018, 1021, 1022, 1028, 1029, 1037, and 1043 are valid based on the restrictions for LAN Manager systems.</para>
        /// </param>
        /// <param name="buf">An object instance containing the information to set. The format of the data depends on the <paramref name="level"/> parameter.</param>
        /// <param name="ParmError">A variable that receives the index of the first member of the server information structure that causes the <see cref="ERROR_INVALID_PARAMETER"/> error. If this parameter is omitted, the index is not returned on error.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the <paramref name="level"/> parameter is invalid.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>The specified parameter is invalid. <paramref name="ParmError"/> specifies the first parameter whose value is invalid.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators or Server Operators local group can successfully execute the <see cref="NetServerSetInfo"/> function.</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same results you can achieve by calling the network management server functions. For more information, see the <see cref="IADsComputer"/> interface reference.</para>
        /// <para>If the <see cref="NetServerSetInfo"/> function returns <see cref="ERROR_INVALID_PARAMETER"/>, you can use the <paramref name="ParmError"/> parameter to indicate the first member of the server information structure that is invalid. (A server information structure begins with <var>SERVER_INFO_</var> and its format is specified by the <paramref name="ParmError"/> parameter.) The values that can be returned in the <paramref name="ParmError"/> parameter and the corresponding structure member that is in error are specified by the <see cref="SERVER_INFO_PARMNUM"/> enumeration type.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370626.aspx">NetServerSetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="NetServerGetInfo"/>
        /// <seealso cref="SERVER_INFO_101"/>
        /// <seealso cref="SERVER_INFO_102"/>
        /// <seealso cref="SERVER_INFO_402"/>
        /// <seealso cref="SERVER_INFO_403"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetServerSetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object buf,
            [Optional] out SERVER_INFO_PARMNUM ParmError
            );
        #endregion
        #region NetServerTransportAdd function
        /// <summary>
        /// <para>The <see cref="NetServerTransportAdd"/> function binds the server to the transport protocol.</para>
        /// <para>The extended function <see cref="NetServerTransportAddEx"/> allows the calling application to specify the <see cref="SERVER_TRANSPORT_INFO_1"/>, <see cref="SERVER_TRANSPORT_INFO_2"/>, and <see cref="SERVER_TRANSPORT_INFO_3"/> information levels.</para>
        /// </summary>
        /// <param name="servername">A string that specifies the name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">Specifies the information level of the data. This parameter can be the following value. <c>0</c> (zero) - Specifies information about the transport protocol, including name, address, and location on the network. The <paramref name="bufptr"/> parameter specifies a <see cref="SERVER_TRANSPORT_INFO_0"/> structure.</param>
        /// <param name="bufptr">An object instance that contains the data.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_DUP_NAME"/></term><description>A duplicate name exists on the network.</description>
        /// <term><see cref="ERROR_INVALID_DOMAINNAME"/></term><description>The domain name could not be found on the network.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the <paramref name="level"/> parameter is invalid.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>The specified parameter is invalid. <br/>This error is returned if the <see cref="SERVER_TRANSPORT_INFO_0.svti0_transportname"/> or <see cref="SERVER_TRANSPORT_INFO_0.svti0_transportaddress"/> member in the <see cref="SERVER_TRANSPORT_INFO_0"/> structure pointed to by the <paramref name="bufptr"/> parameter is <c>null</c>. This error is also returned if the <see cref="SERVER_TRANSPORT_INFO_0.svti0_transportaddresslength"/> member in the <see cref="SERVER_TRANSPORT_INFO_0"/> structure pointed to by the <paramref name="bufptr"/> parameter is zero or larger than <c>260</c> (as defined by <strong>MAX_PATH</strong> in the Windef.h header file). <br/>This error is also returned for other invalid parameters.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators or Server Operators local group can successfully execute the <see cref="NetServerTransportAdd"/> function.</para>
        /// <para>If you add a transport protocol to a server using a call to the <see cref="NetServerTransportAdd"/> function, the connection will not remain after the server reboots or restarts.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370627.aspx">NetServerTransportAdd function</a></para>
        /// </remarks>
        /// <seealso cref="NetServerComputerNameAdd"/>
        /// <seealso cref="NetServerComputerNameDel"/>
        /// <seealso cref="NetServerTransportAddEx"/>
        /// <seealso cref="NetServerTransportDel"/>
        /// <seealso cref="NetServerTransportEnum"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_0"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_1"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_2"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_3"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetServerTransportAdd(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object bufptr
            );
        #endregion
        #region NetServerTransportAddEx function
        /// <summary>
        /// The <see cref="NetServerTransportAddEx"/> function binds the specified server to the transport protocol. This extended function allows the calling application to specify the <see cref="SERVER_TRANSPORT_INFO_0"/>, <see cref="SERVER_TRANSPORT_INFO_1"/>, <see cref="SERVER_TRANSPORT_INFO_2"/>, or <see cref="SERVER_TRANSPORT_INFO_3"/> information levels.
        /// </summary>
        /// <param name="servername">A string that specifies the name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be the following values.
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Specifies information about the transport protocol, including name, address, and location on the network. The <paramref name="bufptr"/> parameter specifies a <see cref="SERVER_TRANSPORT_INFO_0"/> structure.</description>
        /// <term><c>1</c></term> - <description>Specifies information about the transport protocol, including name, address, network location, and domain. The <paramref name="bufptr"/> parameter specifies a <see cref="SERVER_TRANSPORT_INFO_1"/> structure.</description>
        /// <term><c>2</c></term> - <description>Specifies the same information as level 1, with the addition of an <see cref="SERVER_TRANSPORT_INFO_2.svti2_flags"/> member. The <paramref name="bufptr"/> parameter specifies a <see cref="SERVER_TRANSPORT_INFO_2"/> structure.</description>
        /// <term><c>3</c></term> - <description>Specifies the same information as level 2, with the addition of credential information. The <paramref name="bufptr"/> parameter specifies a <see cref="SERVER_TRANSPORT_INFO_3"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">An object instance that contains the data. The format of this data depends on the value of the <paramref name="level"/> parameter. </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_DUP_NAME"/></term><description>A duplicate name exists on the network.</description>
        /// <term><see cref="ERROR_INVALID_DOMAINNAME"/></term><description>The domain name could not be found on the network.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the <paramref name="level"/> parameter is invalid.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>The specified parameter is invalid. <br/>This error is returned if the transport name or transport address member in the <see cref="SERVER_TRANSPORT_INFO_0"/>, <see cref="SERVER_TRANSPORT_INFO_1"/>, <see cref="SERVER_TRANSPORT_INFO_2"/>, or <see cref="SERVER_TRANSPORT_INFO_3"/> structure pointed to by the <paramref name="bufptr"/> parameter is <c>null</c>. This error is also returned if the transport address length member in the <see cref="SERVER_TRANSPORT_INFO_0"/>, <see cref="SERVER_TRANSPORT_INFO_1"/>, <see cref="SERVER_TRANSPORT_INFO_2"/>, or <see cref="SERVER_TRANSPORT_INFO_3"/> structure pointed to by the <paramref name="bufptr"/> parameter is zero or larger than <c>260</c> (as defined by <strong>MAX_PATH</strong> in the Windef.h header file). This error is also returned if the flags member of the <see cref="SERVER_TRANSPORT_INFO_2"/>, or <see cref="SERVER_TRANSPORT_INFO_3"/> structure pointed to by the <paramref name="bufptr"/> parameter contains an illegal value. <br/>This error is also returned for other invalid parameters.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators or Server Operators local group can successfully execute the <see cref="NetServerTransportAddEx"/> function.</para>
        /// <para>If you add a transport protocol to a server using a call to the <see cref="NetServerTransportAddEx"/> function, the connection will not remain after the server reboots or restarts.</para>
        /// <para>The <see cref="NetServerComputerNameAdd"/> function is a utility function. It combines the features of the <see cref="NetServerTransportEnum"/> function and the <see cref="NetServerTransportAddEx"/> function, allowing you to specify an emulated server name.</para>
        /// <para>On Windows Server 2008 and Windows Vista with Service Pack 1 (SP1), every name registered with the Windows remote file server (SRV) is designated as either a scoped name or a non-scoped name. Every share that is added to the system will then either be attached to all of the non-scoped names, or to a single scoped name. Applications that wish to use the scoping features are responsible for both registering the new name as a scoped endpoint and then creating the shares with an appropriate scope. In this way, legacy uses of the Network Management and Network Share Management functions are not affected in any way since they continue to register shares and names as non-scoped names. </para>
        /// <para>A scoped endpoint is created by calling the <see cref="NetServerTransportAddEx"/> function with the <paramref name="level"/> parameter set to <c>2</c> and the <paramref name="bufptr"/> parameter specifying a <see cref="SERVER_TRANSPORT_INFO_2"/> structure with the <see cref="SVTI2_SCOPED_NAME"/> bit value set in <see cref="SERVER_TRANSPORT_INFO_2.svti2_flags"/> member. A scoped endpoint is also created by calling the <see cref="NetServerTransportAddEx"/> function with the <paramref name="level"/> parameter set to <c>3</c> and the <paramref name="bufptr"/> parameter specifying a <see cref="SERVER_TRANSPORT_INFO_3"/> structure with the <see cref="SVTI2_SCOPED_NAME"/> bit value set in <see cref="SERVER_TRANSPORT_INFO_3.svti3_flags"/> member. </para>
        /// <para>When the <see cref="SVTI2_SCOPED_NAME"/> bit value is set for a transport, then shares can be added with a corresponding server name (the <see cref="SHARE_INFO_503.shi503_servername"/> member of the <see cref="SHARE_INFO_503"/> structure) in a scoped fashion using the <see cref="NetShareAdd"/> function. If there is no transport registered with the <see cref="SVTI2_SCOPED_NAME"/> bit value and the name provided in <see cref="SHARE_INFO_503.shi503_servername"/> member, then the share add in a scoped fashion will not succeed. </para>
        /// <para>The <see cref="NetShareAdd"/> function is used to add a scoped share on a remote server specified in the <paramref name="servername"/> parameter. The remote server specified in the <see cref="SHARE_INFO_503.shi503_servername"/> member of the <see cref="SHARE_INFO_503"/> passed in the <paramref name="bufptr"/> parameter must have been bound to a transport protocol using the <see cref="NetServerTransportAddEx"/> function as a scoped endpoint. The <see cref="SVTI2_SCOPED_NAME"/> flag must have been specified in the <see cref="SHARE_INFO_503.shi503_servername"/> member of the <see cref="SERVER_TRANSPORT_INFO_2"/> or <see cref="SERVER_TRANSPORT_INFO_3"/> structure for the transport protocol. The <see cref="NetShareDelEx"/> function is used to delete a scoped share. The <see cref="NetShareGetInfo"/> and <see cref="NetShareSetInfo"/> functions are to used to get and set information on a scoped share. </para>
        /// <para>Scoped endpoints are generally used by the cluster namespace.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370628.aspx">NetServerTransportAddEx function</a></para>
        /// </remarks>
        /// <seealso cref="NetServerComputerNameAdd"/>
        /// <seealso cref="NetServerComputerNameDel"/>
        /// <seealso cref="NetServerTransportAdd"/>
        /// <seealso cref="NetServerTransportDel"/>
        /// <seealso cref="NetServerTransportEnum"/>
        /// <seealso cref="NetShareAdd"/>
        /// <seealso cref="NetShareDelEx"/>
        /// <seealso cref="NetShareGetInfo"/>
        /// <seealso cref="NetShareSetInfo"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_0"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_1"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_2"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_3"/>
        /// <seealso cref="SHARE_INFO_503"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetServerTransportAddEx(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object bufptr
            );
        #endregion
        #region NetServerTransportDel function
        /// <summary>
        /// The <see cref="NetServerTransportDel"/> function unbinds (or disconnects) the transport protocol from the server. Effectively, the server can no longer communicate with clients using the specified transport protocol (such as TCP or XNS).
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be the following values.
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Specifies information about the transport protocol, including name, address, and location on the network. The <paramref name="bufptr"/> parameter specifies a <see cref="SERVER_TRANSPORT_INFO_0"/> structure.</description>
        /// <term><c>1</c></term> - <description>Specifies information about the transport protocol, including name, address, network location, and domain. The <paramref name="bufptr"/> parameter specifies a <see cref="SERVER_TRANSPORT_INFO_1"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">An object instance that contains the data. The format of this data depends on the value of the <paramref name="level"/> parameter. </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the <paramref name="level"/> parameter is invalid.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>The specified parameter is invalid.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// <term><see cref="NERR_NetNameNotFound"/></term><description>The share name does not exist.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// Only members of the Administrators or Server Operators local group can successfully execute the <see cref="NetServerTransportDel"/> function.
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370629.aspx">NetServerTransportDel function</a></para>
        /// </remarks>
        /// <seealso cref="NetServerTransportAdd"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_0"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_1"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetServerTransportDel(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object bufptr
            );
        #endregion
        #region NetServerTransportEnum function
        /// <summary>
        /// The <see cref="NetServerTransportEnum"/> function supplies information about transport protocols that are managed by the server.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be the following values.
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Specifies information about the transport protocol, including name, address, and location on the network. The <paramref name="bufptr"/> parameter specifies a <see cref="SERVER_TRANSPORT_INFO_0"/> structure.</description>
        /// <term><c>1</c></term> - <description>Specifies information about the transport protocol, including name, address, network location, and domain. The <paramref name="bufptr"/> parameter specifies a <see cref="SERVER_TRANSPORT_INFO_1"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable that receives a buffer containing the data. The format of this data depends on the value of the <paramref name="level"/> parameter. </para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <param name="prefmaxlen">Specifies the preferred maximum length of returned data, in bytes. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required for the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="entriesread">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="totalentries">A variable that receives the total number of entries that could have been enumerated from the current resume position. Note that applications should consider this value only as a hint.</param>
        /// <param name="resumehandle">A reference to a variable that contains a resume handle which is used to continue an existing server transport search. The handle should be zero on the first call and left unchanged for subsequent calls. If this parameter is omitted, no resume handle is stored.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The value specified for the <paramref name="level"/> parameter is invalid.</description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory is available.</description>
        /// <term><see cref="NERR_BufTooSmall"/></term><description>The supplied buffer is too small.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only Authenticated Users can successfully call this function.</para>
        /// <para><strong>Windows XP/2000:</strong> No special group membership is required to successfully execute this function.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370630.aspx">NetServerTransportEnum function</a></para>
        /// </remarks>
        /// <seealso cref="SERVER_TRANSPORT_INFO_0"/>
        /// <seealso cref="SERVER_TRANSPORT_INFO_1"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetServerTransportEnum(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            out ServerTransportInfoArrayNetApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries,
            [Optional] ref IntPtr resumehandle
            );
        #endregion
        #region NetServiceControl
        // The NetServiceControl function is obsolete.It is included for compatibility with 16-bit versions of Windows.Other applications should use the service functions ( https://msdn.microsoft.com/en-us/library/ms685942.aspx ).
        #endregion
        #region NetServiceEnum
        // The NetServiceEnum function is obsolete.It is included for compatibility with 16-bit versions of Windows.Other applications should use the service functions ( https://msdn.microsoft.com/en-us/library/ms685942.aspx ).
        #endregion
        #region NetServiceGetInfo
        // The NetServiceGetInfo function is obsolete.It is included for compatibility with 16-bit versions of Windows.Other applications should use the service functions ( https://msdn.microsoft.com/en-us/library/ms685942.aspx ).
        #endregion
        #region NetServiceInstall
        // The NetServiceInstall function is obsolete.It is included for compatibility with 16-bit versions of Windows.Other applications should use the service functions ( https://msdn.microsoft.com/en-us/library/ms685942.aspx ).
        #endregion
        #region NetSetPrimaryComputerName function
        /// <summary>
        /// The <see cref="NetSetPrimaryComputerName"/> function sets the primary computer name for the specified computer.
        /// </summary>
        /// <param name="Server">A string that specifies the name of the computer on which to execute this function. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="PrimaryName">A string that specifies the primary name to set. This name must be in the form of a fully qualified DNS name.</param>
        /// <param name="DomainAccount">
        /// <para>A string that specifies the domain account to use for accessing the machine account object for the computer specified in the <paramref name="Server"/> parameter in Active Directory. If this parameter is <c>null</c>, then the credentials of the user executing this routine are used. </para>
        /// <para>This parameter is not used if the server to execute this function is not joined to a domain. </para>
        /// </param>
        /// <param name="DomainAccountPassword">
        /// <para>A string that specifies the password matching the domain account passed in the <paramref name="DomainAccount"/> parameter. If this parameter is <c>null</c>, then the credentials of the user executing this routine are used. </para>
        /// <para>This parameter is ignored if the <paramref name="DomainAccount"/> parameter is <c>null</c>. This parameter is not used if the server to execute this function is not joined to a domain. </para>
        /// </param>
        /// <param name="Reserved">Reserved for future use. This parameter should be <c>0</c> (zero).</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>Access is denied. This error is returned if the caller was not a member of the Administrators local group on the target computer.</description>
        /// <term><see cref="ERROR_INVALID_NAME"/></term><description>A name parameter is incorrect. This error is returned if the <paramref name="PrimaryName"/> parameter does not contain valid name.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="DomainAccount"/> parameter does not contain a valid domain. This error is also returned if the <paramref name="DomainAccount"/> parameter is not <c>null</c> and the <paramref name="DomainAccountPassword"/> parameter is not <c>null</c> but does not contain a string.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Not enough memory is available to process this command.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if the target computer specified in the <paramref name="Server"/> parameter on which this function executes is running on Windows 2000 and earlier.</description>
        /// <term><see cref="NERR_WkstaNotStarted"/></term><description>The Workstation service has not been started.</description>
        /// <term><see cref="RPC_S_CALL_IN_PROGRESS"/></term><description>A remote procedure call is already in progress for this thread.</description>
        /// <term><see cref="RPC_S_PROTSEQ_NOT_SUPPORTED"/></term><description>The remote procedure call protocol sequence is not supported.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetSetPrimaryComputerName"/> function is supported on Windows XP and later. </para>
        /// <para>The <see cref="NetSetPrimaryComputerName"/> function is used as part of computer rename operations. The specified name will be removed from the alternate name list configured for the target computer and configured as the primary name. The computer account name will be changed to match the primary name. The previous primary computer name is moved to the alternate computer name list configured for the computer.</para>
        /// <para>The <see cref="NetSetPrimaryComputerName"/> function requires that the caller is a member of the Administrators local group on the target computer.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dd877216.aspx">NetSetPrimaryComputerName function</a></para>
        /// </remarks>
        /// <seealso cref="NetAddAlternateComputerName"/>
        /// <seealso cref="NetEnumerateComputerNames"/>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetRemoveAlternateComputerName"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetUnjoinDomain"/>
        /// <seealso cref="SetComputerNameEx"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetSetPrimaryComputerName(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string Server,
            [In, MarshalAs(UnmanagedType.LPWStr)] string PrimaryName,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string DomainAccount,
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string DomainAccountPassword,
            [In] int Reserved
            );
        #endregion
        #region NetUnjoinDomain function
        /// <summary>
        /// The <see cref="NetUnjoinDomain"/> function unjoins a computer from a workgroup or a domain.
        /// </summary>
        /// <param name="lpServer">A string that specifies the DNS or NetBIOS name of the computer on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="lpAccount">A string that specifies the account name to use when connecting to the domain controller. The string must specify either a domain NetBIOS name and user account (for example, <c>REDMOND\user</c>) or the user principal name (UPN) of the user in the form of an Internet-style login name (for example, <c>"someone@example.com"</c>). If this parameter is <c>null</c>, the caller's context is used.</param>
        /// <param name="lpPassword">If the <paramref name="lpAccount"/> parameter specifies an account name, this parameter must point to the password to use when connecting to the domain controller. Otherwise, this parameter must be <c>null</c>.</param>
        /// <param name="fUnjoinOptions">Specifies the unjoin options. If this parameter is <see cref="NETSETUP_ACCT_DELETE"/>, the account is disabled when the unjoin occurs. Note that this option does not delete the account. Currently, there are no other unjoin options defined.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect.</description>
        /// <term><see cref="NERR_SetupNotJoined"/></term><description>The computer is not currently joined to a domain.</description>
        /// <term><see cref="NERR_SetupDomainController"/></term><description>This computer is a domain controller and cannot be unjoined from a domain.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Unjoining (and joining) a computer to a domain or workgroup can be performed only by a member of the Administrators local group on the target computer. If you call the <see cref="NetUnjoinDomain"/> function remotely, you must supply credentials because you cannot delegate credentials under these circumstances.</para>
        /// <para>Different processes, or different threads of the same process, should not call the <see cref="NetUnjoinDomain"/> function at the same time. This situation can leave the computer in an inconsistent state.</para>
        /// <para>A system reboot is required after calling the <see cref="NetRenameMachineInDomain"/> function for the operation to complete.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370644.aspx">NetUnjoinDomain function</a></para>
        /// </remarks>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUnjoinDomain(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpServer,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpAccount,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpPassword,
            [In, MarshalAs(UnmanagedType.I4)] NETSETUP_OPTIONS fUnjoinOptions
            );
        #endregion
        #region NetUseAdd function
        /// <summary>
        /// The <see cref="NetUseAdd"/> function establishes a connection between the local computer and a remote server. You can specify a local drive letter or a printer device to connect. If you do not specify a local drive letter or printer device, the function authenticates the client with the server for future connections.
        /// </summary>
        /// <param name="UncServerName">The UNC name of the computer on which to execute this function. If this parameter is <c>null</c>, then the local computer is used. If the <paramref name="UncServerName"/> parameter specified is a remote computer, then the remote computer must support remote RPC calls using the legacy Remote Access Protocol mechanism. </param>
        /// <param name="Level">
        /// A value that specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><c>1</c></term> - <description>Specifies information about the connection between a local device and a shared resource. Information includes the connection status and type. The <paramref name="Buf"/> parameter specifies a <see cref="USE_INFO_1"/> structure.</description>
        /// <term><c>2</c></term> - <description>Specifies information about the connection between a local device and a shared resource. Information includes the connection status and type, and a user name and domain name. The <paramref name="Buf"/> parameter specifies a <see cref="USE_INFO_2"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="Buf">A object instance that specifies the data. The format of this data depends on the value of the <paramref name="Level"/> parameter.</param>
        /// <param name="ParmError">A variable that receives the index of the first member of the information structure in error when the <see cref="ERROR_INVALID_PARAMETER"/> error is returned. If this parameter is <c>null</c>, the index is not returned on error. For more information, see the following Remarks section.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>If the function fails, the return value is a system error code.</para>
        /// </returns>
        /// <remarks>
        /// <para>You can also use the <see cref="WNetAddConnection2"/> and <see cref="WNetAddConnection3"/> functions to redirect a local device to a network resource.</para>
        /// <para>No special group membership is required to call the <see cref="NetUseAdd"/> function. This function cannot be executed on a remote server except in cases of downlevel compatibility.</para>
        /// <para>This function applies only to the Server Message Block (LAN Manager Workstation) client. The <see cref="NetUseAdd"/> function does not support Distributed File System (DFS) shares. To add a share using a different network provider (WebDAV or a DFS share, for example), use the <see cref="WNetAddConnection2"/> or <see cref="WNetAddConnection3"/> function. </para>
        /// <para>If the <see cref="NetUseAdd"/> function returns <see cref="ERROR_INVALID_PARAMETER"/>, you can use the <paramref name="ParmError"/> parameter to indicate the first member of the information structure that is invalid. (The information structure begins with <strong>USE_INFO_</strong> and its format is specified by the <paramref name="Level"/> parameter.) The values that can be returned in the <paramref name="ParmError"/> parameter and the corresponding structure member that is in error is listed by the <see cref="USE_INFO_PARMNUM"/> enumeration type.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370645.aspx">NetUseAdd function</a></para>
        /// </remarks>
        /// <seealso cref="NetUseDel"/>
        /// <seealso cref="USE_INFO_1"/>
        /// <seealso cref="USE_INFO_2"/>
        /// <seealso cref="WNetAddConnection2"/>
        /// <seealso cref="WNetAddConnection3"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUseAdd(
            [In, MarshalAs(UnmanagedType.LPWStr)] string UncServerName,
            [In] int Level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object Buf,
            [Optional] out USE_INFO_PARMNUM ParmError
            );
        #endregion
        #region NetUseDel function
        /// <summary>
        /// <para>The <see cref="NetUseDel"/> function ends a connection to a shared resource.</para>
        /// <para>You can also use the <see cref="WNetCancelConnection2"/> function to terminate a network connection.</para>
        /// </summary>
        /// <param name="UncServerName">
        /// <para>The UNC name of the computer on which to execute this function. If this is parameter is <c>null</c>, then the local computer is used. </para>
        /// <para>If the <paramref name="UncServerName"/> parameter specified is a remote computer, then the remote computer must support remote RPC calls using the legacy Remote Access Protocol mechanism. </para>
        /// </param>
        /// <param name="UseName">A string that specifies the path of the connection to delete.</param>
        /// <param name="ForceCond">The level of force to use in deleting the connection.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>If the function fails, the return value is a system error code.</para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetUseDel"/> function applies only to the Server Message Block (LAN Manager Workstation) client. The <see cref="NetUseDel"/> function does not support Distributed File System (DFS) shares or other network file systems. To terminate a connection to a share using a different network provider (WebDAV or a DFS share, for example), use the <see cref="WNetCancelConnection2"/> function. </para>
        /// <para>No special group membership is required to call the <see cref="NetUseDel"/> function. This function cannot be executed on a remote server except in cases of downlevel compatibility.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370646.aspx">NetUseDel function</a></para>
        /// </remarks>
        /// <seealso cref="NetUseAdd"/>
        /// <seealso cref="WNetCancelConnection2"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUseDel(
            [In, MarshalAs(UnmanagedType.LPWStr)] string UncServerName,
            [In, MarshalAs(UnmanagedType.LPWStr)] string UseName,
            [In, MarshalAs(UnmanagedType.I4)] USE_FORCE_COND ForceCond
            );
        #endregion
        #region NetUseEnum function
        /// <summary>
        /// <para>The <see cref="NetUseEnum"/> function lists all current connections between the local computer and resources on remote servers.</para>
        /// <para>You can also use the <see cref="WNetOpenEnum"/> and the <see cref="WNetEnumResource"/> functions to enumerate network resources or connections.</para>
        /// </summary>
        /// <param name="UncServerName">The UNC name of the computer on which to execute this function. If this is parameter is <c>null</c>, then the local computer is used. If the <paramref name="UncServerName"/> parameter specified is a remote computer, then the remote computer must support remote RPC calls using the legacy Remote Access Protocol mechanism. </param>
        /// <param name="Level">
        /// The information level of the data requested. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Specifies a local device name and the share name of a remote resource. The <paramref name="BufPtr"/> parameter receives an array of <see cref="USE_INFO_0"/> structures.</description>
        /// <term><c>1</c></term> - <description>Specifies information about the connection between a local device and a shared resource, including connection status and type. The <paramref name="BufPtr"/> parameter receives an array of <see cref="USE_INFO_1"/> structures.</description>
        /// <term><c>2</c></term> - <description>Specifies information about the connection between a local device and a shared resource. Information includes the connection status, connection type, user name, and domain name. The <paramref name="BufPtr"/> parameter receives an array of <see cref="USE_INFO_2"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="BufPtr">
        /// <para>A variable for a buffer that receives the information structures. The format of this data depends on the value of the <paramref name="Level"/> parameter.</para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <param name="PreferedMaximumSize">The preferred maximum length, in bytes, of the data to return. If <see cref="MAX_PREFERRED_LENGTH"/> is specified, the function allocates the amount of memory required for the data. If another value is specified in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="EntriesRead">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="TotalEntries">A variable that receives the total number of entries that could have been enumerated from the current resume position. Note that applications should consider this value only as a hint.</param>
        /// <param name="ResumeHandle">A reference to a value that contains a resume handle which is used to continue the search. The handle should be zero on the first call and left unchanged for subsequent calls. If <paramref name="ResumeHandle"/> is omitted, then no resume handle is stored.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value is a system error code.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>An invalid parameter was passed to the function.</description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>There is more data to return. This error is returned if the buffer size is insufficient to hold all entries.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if the <paramref name="UncServerName"/> parameter was not <c>null</c> and the remote server does not support remote RPC calls using the legacy Remote Access Protocol mechanism. </description>
        /// <term>Other</term><description>Use <see cref="FormatMessage"/> to obtain the message string for the returned error.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to call the <see cref="NetUseEnum"/> function. This function cannot be executed on a remote server except in cases of downlevel compatibility using the legacy Remote Access Protocol.</para>
        /// <para>To retrieve information about one network connection, you can call the <see cref="NetUseGetInfo"/> function.</para>
        /// <para>This function applies only to the Server Message Block (LAN Manager Workstation) client. The <see cref="NetUseEnum"/> function does not support Distributed File System (DFS) shares. To enumerate shares using a different network provider (WebDAV or a DFS share, for example), use the <see cref="WNetOpenEnum"/>, <see cref="WNetEnumResource"/>, and <see cref="WNetCloseEnum"/> functions. </para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370647.aspx">NetUseEnum function</a></para>
        /// </remarks>
        /// <seealso cref="NetUseGetInfo"/>
        /// <seealso cref="USE_INFO_0"/>
        /// <seealso cref="USE_INFO_1"/>
        /// <seealso cref="USE_INFO_2"/>
        /// <seealso cref="WNetCloseEnum"/>
        /// <seealso cref="WNetEnumResource"/>
        /// <seealso cref="WNetOpenEnum"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUseEnum(
            [In, MarshalAs(UnmanagedType.LPWStr)] string UncServerName,
            [In] int Level,
            out UseInfoArrayNetApiBufferHandle BufPtr,
            [In] int PreferedMaximumSize,
            out int EntriesRead,
            out int TotalEntries,
            [Optional] ref IntPtr ResumeHandle
            );
        #endregion
        #region NetUseGetInfo function
        /// <summary>
        /// <para>The <see cref="NetUseGetInfo"/> function retrieves information about a connection to a shared resource.</para>
        /// <para>You can also use the <see cref="WNetGetConnection"/> function to retrieve the name of a network resource associated with a local device.</para>
        /// </summary>
        /// <param name="UncServerName">The UNC name of the computer on which to execute this function. If this is parameter is <c>null</c>, then the local computer is used. If the <paramref name="UncServerName"/> parameter specified is a remote computer, then the remote computer must support remote RPC calls using the legacy Remote Access Protocol mechanism. </param>
        /// <param name="UseName">A string that specifies the name of the connection for which to return information.</param>
        /// <param name="Level">
        /// The information level of the data requested. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Specifies a local device name and the share name of a remote resource. The <paramref name="BufPtr"/> parameter receives a <see cref="USE_INFO_0"/> structure.</description>
        /// <term><c>1</c></term> - <description>Specifies information about the connection between a local device and a shared resource, including connection status and type. The <paramref name="BufPtr"/> parameter receives a <see cref="USE_INFO_1"/> structure.</description>
        /// <term><c>2</c></term> - <description>Specifies information about the connection between a local device and a shared resource. Information includes the connection status, connection type, user name, and domain name. The <paramref name="BufPtr"/> parameter receives a <see cref="USE_INFO_2"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="BufPtr">
        /// <para>A variable for a buffer that receives the information structure. The format of this data depends on the value of the <paramref name="Level"/> parameter.</para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>If the function fails, the return value is a system error code.</para>
        /// </returns>
        /// <remarks>
        /// <para>No special group membership is required to call the <see cref="NetUseGetInfo"/> function. This function cannot be executed on a remote server except in cases of downlevel compatibility.</para>
        /// <para>To list all current connections between the local computer and resources on remote servers, you can call the <see cref="NetUseEnum"/> function.</para>
        /// <para>This function applies only to the Server Message Block (LAN Manager Workstation) client. The <see cref="NetUseGetInfo"/> function does not support Distributed File System (DFS) shares. To retrieve information for a share using a different network provider (WebDAV or a DFS share, for example), use the <see cref="WNetGetConnection"/> function. </para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370648.aspx">NetUseGetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="NetUseEnum"/>
        /// <seealso cref="USE_INFO_0"/>
        /// <seealso cref="USE_INFO_1"/>
        /// <seealso cref="USE_INFO_2"/>
        /// <seealso cref="WNetGetConnection"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUseGetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string UncServerName,
            [In, MarshalAs(UnmanagedType.LPWStr)] string UseName,
            [In] int Level,
            out UseInfoNetApiBufferHandle BufPtr
            );
        #endregion
        #region NetUserAdd function
        /// <summary>
        /// The <see cref="NetUserAdd"/> function adds a user account and assigns a password and privilege level.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>1</c></term> - <description>Specifies information about the user account. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1"/> structure. <br/>When you specify this level, the call initializes certain attributes to their default values. For more information, see the following Remarks section.</description>
        /// <term><c>2</c></term> - <description>Specifies level one information and additional attributes about the user account. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_2"/> structure. </description>
        /// <term><c>3</c></term> - <description>Specifies level two information and additional attributes about the user account. This level is valid only on servers. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_3"/> structure. Note that it is recommended that you use <see cref="USER_INFO_4"/> instead.</description>
        /// <term><c>4</c></term> - <description>Specifies level two information and additional attributes about the user account. This level is valid only on servers. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_4"/> structure. <br/><strong>Windows 2000:</strong> This level is not supported.</description>
        /// </list>
        /// </param>
        /// <param name="buf">An object instance that specifies the data. The format of this data depends on the value of the <paramref name="level"/> parameter.</param>
        /// <param name="parm_err">A variable that receives the index of the first member of the user information structure that causes <see cref="ERROR_INVALID_PARAMETER"/>. If this parameter is omitted, the index is not returned on error.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_GroupExists"/></term><description>The group already exists.</description>
        /// <term><see cref="NERR_UserExists"/></term><description>The user account already exists.</description>
        /// <term><see cref="NERR_PasswordTooShort"/></term><description>The password is shorter than required. (The password could also be too long, be too recent in its change history, not have enough unique characters, or not meet another password policy requirement.)</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user functions. For more information, see <see cref="IADsUser"/> and <see cref="IADsComputer"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the user container is used to perform the access check for this function. The caller must be able to create child objects of the user class.</para>
        /// <para>Server users must use a system in which the server creates a system account for the new user. The creation of this account is controlled by several parameters in the server's LanMan.ini file.</para>
        /// <para>If the newly added user already exists as a system user, the <see cref="USER_INFO_1.usri1_home_dir"/> member of the <see cref="USER_INFO_1"/> structure is ignored.</para>
        /// <para>
        /// When you call the <see cref="NetUserAdd"/> function and specify information level <c>1</c>, the call initializes the additional members in the <see cref="USER_INFO_2"/>, <see cref="USER_INFO_3"/>, and <see cref="USER_INFO_4"/> structures to their default values. You can change the default values by making subsequent calls to the <see cref="NetUserSetInfo"/> function. The default values supplied are listed following. (The prefix <var>usriX</var> indicates that the member can begin with multiple prefixes, for example, <var>usri2_</var> or <var>usri4_</var>.)
        /// <list type="table">
        /// <listheader><term>Member</term><description>Default Value</description></listheader>
        /// <term><var>usriX_auth_flags</var></term><description>None (<c>0</c> zero)</description>
        /// <term><var>usriX_full_name</var></term><description>None (<c>null</c> string)</description>
        /// <term><var>usriX_usr_comment</var></term><description>None (<c>null</c> string)</description>
        /// <term><var>usriX_parms</var></term><description>None (<c>null</c> string)</description>
        /// <term><var>usriX_workstations</var></term><description>All (<c>null</c> string)</description>
        /// <term><var>usriX_acct_expires</var></term><description>Never (<see cref="TIMEQ_FOREVER"/>)</description>
        /// <term><var>usriX_max_storage</var></term><description>Unlimited (<see cref="USER_MAXSTORAGE_UNLIMITED"/>)</description>
        /// <term><var>usriX_logon_hours</var></term><description>Logon allowed at any time (each element <c>0xFF</c>; all bits set to <c>1</c>)</description>
        /// <term><var>usriX_logon_server</var></term><description>Any domain controller (<code>\\*</code>)</description>
        /// <term><var>usriX_country_code</var></term><description>0</description>
        /// <term><var>usriX_code_page</var></term><description>0</description>
        /// </list>
        /// </para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370649.aspx">NetUserAdd function</a></para>
        /// </remarks>
        /// <seealso cref="NetUserEnum"/>
        /// <seealso cref="NetUserSetInfo"/>
        /// <seealso cref="NetUserDel"/>
        /// <seealso cref="USER_INFO_1"/>
        /// <seealso cref="USER_INFO_2"/>
        /// <seealso cref="USER_INFO_4"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserAdd(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object buf,
            [Optional] out USER_INFO_PARMNUM parm_err
            );
        #endregion
        #region NetUserChangePassword function
        /// <summary>
        /// The <see cref="NetUserChangePassword"/> function changes a user's password for a specified network server or domain.
        /// </summary>
        /// <param name="domainname">A string that specifies the DNS or NetBIOS name of a remote server or domain on which the function is to execute. If this parameter is <c>null</c>, the logon domain of the caller is used. </param>
        /// <param name="username">
        /// <para>A string that specifies a user name. The <see cref="NetUserChangePassword"/> function changes the password for the specified user.</para>
        /// <para>If this parameter is <c>null</c>, the logon name of the caller is used. For more information, see the function Remarks section.</para>
        /// </param>
        /// <param name="oldpassword">A string that specifies the user's old password.</param>
        /// <param name="newpassword">A string that specifies the user's new password.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_PASSWORD"/></term><description>The user has entered an invalid password.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user name could not be found.</description>
        /// <term><see cref="NERR_PasswordTooShort"/></term><description>The password is shorter than required. (The password could also be too long, be too recent in its change history, not have enough unique characters, or not meet another password policy requirement.)</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user functions. For more information, see <see cref="IADsUser"/> and <see cref="IADsComputer"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the User object is used to perform the access check for this function. In addition, the caller must have the "Change password" <a href="https://msdn.microsoft.com/en-us/library/ms675747.aspx">control access right</a> on the User object. This right is granted to Anonymous Logon and Everyone by default. </para>
        /// <para>Note that for the function to succeed, the oldpassword parameter must match the password as it currently exists.</para>
        /// <para>In some cases, the process that calls the <see cref="NetUserChangePassword"/> function must also have the <see cref="SE_CHANGE_NOTIFY_NAME"/> privilege enabled; otherwise, <see cref="NetUserChangePassword"/> fails and <see cref="Marshal.GetLastWin32Error"/> returns <see cref="ERROR_ACCESS_DENIED"/>. This privilege is not required for the LocalSystem account or for accounts that are members of the administrators group. By default, <see cref="SE_CHANGE_NOTIFY_NAME"/> is enabled for all users, but some administrators may disable the privilege for everyone. For more information about account privileges, see <a href="https://msdn.microsoft.com/en-us/library/aa379306.aspx">Privileges</a> and <a href="https://msdn.microsoft.com/en-us/library/aa375728.aspx">Authorization Constants</a>.</para>
        /// <para>See <a href="https://msdn.microsoft.com/en-us/library/aa370261.aspx">Forcing a User to Change the Logon Password</a> for a code sample that demonstrates how to force a user to change the logon password on the next logon using the <see cref="NetUserGetInfo"/> and <see cref="NetUserSetInfo"/> functions.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>The <see cref="NetUserChangePassword"/> function does not control how the <paramref name="domainname"/> and <paramref name="newpassword"/> parameters are secured when sent over the network to a remote server. Any encryption of these parameters is handled by the Remote Procedure Call (RPC) mechanism supported by the network redirector that provides the network transport. Encryption is also controlled by the security mechanisms supported by the local computer and the security mechanisms supported by remote network server or domain specified in the domainname parameter. For more details on security when the Microsoft network redirector is used and the remote network server is running Microsoft Windows, see the protocol documentation for <a href="http://go.microsoft.com/fwlink/p/?linkid=200126">MS-RPCE</a>, <a href="http://go.microsoft.com/fwlink/p/?linkid=200128">MS-SAMR</a>, <a href="http://go.microsoft.com/fwlink/p/?linkid=200129">MS-SPNG</a>, and <a href="http://go.microsoft.com/fwlink/p/?linkid=200130">MS-NLMP</a>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370650.aspx">NetUserChangePassword function</a></para>
        /// </remarks>
        /// <seealso cref="NetUserSetInfo"/>
        /// <seealso cref="NetUserGetInfo"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserChangePassword(
            [In, MarshalAs(UnmanagedType.LPWStr)] string domainname,
            [In, MarshalAs(UnmanagedType.LPWStr)] string username,
            [In, MarshalAs(UnmanagedType.LPWStr)] string oldpassword,
            [In, MarshalAs(UnmanagedType.LPWStr)] string newpassword
            );
        #endregion
        #region NetUserDel function
        /// <summary>
        /// The <see cref="NetUserDel"/> function deletes a user account from a server.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="username">A string that specifies the name of the user account to delete. For more information, see the function Remarks section.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user name could not be found.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user functions. For more information, see <see cref="IADsUser"/> and <see cref="IADsComputer"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits only Domain Admins and Account Operators to call this function. On a member server or workstation, only Administrators and Power Users can call this function. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the User object is used to perform the access check for this function.</para>
        /// <para>An account cannot be deleted while a user or application is accessing a server resource. If the user was added to the system with a call to the <see cref="NetUserAdd"/> function, deleting the user also deletes the user's system account.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370651.aspx">NetUserDel function</a></para>
        /// </remarks>
        /// <seealso cref="NetUserAdd"/>
        /// <seealso cref="NetUserEnum"/>
        /// <seealso cref="NetUserSetInfo"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserDel(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string username
            );
        #endregion
        #region NetUserEnum function
        /// <summary>
        /// The <see cref="NetUserEnum"/> function retrieves information about all user accounts on a server.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Return user account names. The <paramref name="bufptr"/> parameter receives an array of <see cref="USER_INFO_0"/> structures.</description>
        /// <term><c>1</c> </term> - <description>Return detailed information about user accounts. The <paramref name="bufptr"/> parameter receives an array of <see cref="USER_INFO_1"/> structures.</description>
        /// <term><c>2</c> </term> - <description>Return detailed information about user accounts, including authorization levels and logon information. The <paramref name="bufptr"/> parameter receives an array of <see cref="USER_INFO_2"/> structures.</description>
        /// <term><c>3</c> </term> - <description>Return detailed information about user accounts, including authorization levels, logon information, RIDs for the user and the primary group, and profile information. The <paramref name="bufptr"/> parameter receives an array of <see cref="USER_INFO_3"/> structures.</description>
        /// <term><c>10</c> </term> - <description>Return user and account names and comments. The <paramref name="bufptr"/> parameter receives an array of <see cref="USER_INFO_10"/> structures.</description>
        /// <term><c>11</c> </term> - <description>Return detailed information about user accounts. The <paramref name="bufptr"/> parameter receives an array of <see cref="USER_INFO_11"/> structures.</description>
        /// <term><c>20</c> </term> - <description>Return the user's name and identifier and various account attributes. The <paramref name="bufptr"/> parameter receives an array of <see cref="USER_INFO_20"/> structures. Note that on Windows XP and later, it is recommended that you use <see cref="USER_INFO_23"/> instead.</description>
        /// </list>
        /// </param>
        /// <param name="filter">A value that specifies the user account types to be included in the enumeration. A value of zero indicates that all normal user, trust data, and machine account data should be included. </param>
        /// <param name="bufptr">
        /// <para>A variable for a buffer that receives the information structures. The format of this data depends on the value of the <paramref name="level"/> parameter.</para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <param name="prefmaxlen">The preferred maximum length, in bytes, of the returned data. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the <see cref="NetUserEnum"/> function allocates the amount of memory required for the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="entriesread">A variable that receives the count of elements actually enumerated.</param>
        /// <param name="totalentries">
        /// <para>A variable that receives the total number of entries that could have been enumerated from the current resume position. Note that applications should consider this value only as a hint. If your application is communicating with a Windows 2000 or later domain controller, you should consider using the <a href="https://msdn.microsoft.com/en-us/library/aa772203.aspx">ADSI LDAP Provider</a> to retrieve this type of data more efficiently. The ADSI LDAP Provider implements a set of ADSI objects that support various ADSI interfaces. For more information, see <a href="https://msdn.microsoft.com/en-us/library/aa772235.aspx">ADSI Service Providers</a>. </para>
        /// <para><strong>LAN Manager:</strong> If the call is to a computer that is running LAN Manager 2.x, the <paramref name="totalentries"/> parameter will always reflect the total number of entries in the database no matter where it is in the resume sequence.</para>
        /// </param>
        /// <param name="resume_handle">A reference to a variable that contains a resume handle which is used to continue an existing user search. The handle should be zero on the first call and left unchanged for subsequent calls. If this parameter is omitted, then no resume handle is stored.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The system call level is not correct. This error is returned if the <paramref name="level"/> parameter is set to a value not supported. </description>
        /// <term><see cref="NERR_BufTooSmall"/></term><description>The buffer is too small to contain an entry. No information has been written to the buffer. </description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetUserEnum"/> function retrieves information about all user accounts on a specified remote server or the local computer.</para>
        /// <para>The <see cref="NetQueryDisplayInformation"/> function can be used to quickly enumerate user, computer, or global group account information for display in user interfaces .</para>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user functions. For more information, see <see cref="IADsUser"/> and <see cref="IADsComputer"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits all authenticated users and members of the "<a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">Pre-Windows 2000 compatible access</a>" group to view the information. If you call this function on a member server or workstation, all authenticated users can view the information. For information about anonymous access and restricting anonymous access on these platforms, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The <see cref="NetUserEnum"/> function only returns information to which the caller has Read access. The caller must have List Contents access to the Domain object, and Enumerate Entire SAM Domain access on the SAM Server object located in the System container. </para>
        /// <para>The <see cref="LsaEnumerateTrustedDomains"/> or <see cref="LsaEnumerateTrustedDomainsEx"/> function can be used to retrieve the names and SIDs of domains trusted by a Local Security Authority (LSA) policy object.</para>
        /// <para>The <see cref="NetUserEnum"/> function does not return all system users. It returns only those users who have been added with a call to the <see cref="NetUserAdd"/> function. There is no guarantee that the list of users will be returned in sorted order.</para>
        /// <para>If you call the <see cref="NetUserEnum"/> function and specify information level 1, 2, or 3, for the level parameter, the password member of each structure retrieved is set to <c>null</c> to maintain password security. </para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>The <see cref="NetUserEnum"/> function does not support a <paramref name="level"/> parameter of <c>4</c> and the <see cref="USER_INFO_4"/> structure. The <see cref="NetUserGetInfo"/> function supports a <paramref name="level"/> parameter of <c>4</c> and the <see cref="USER_INFO_4"/> structure.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370652.aspx">NetUserEnum function</a></para>
        /// </remarks>
        /// <seealso cref="LsaEnumerateTrustedDomains"/>
        /// <seealso cref="LsaEnumerateTrustedDomainsEx"/>
        /// <seealso cref="NetQueryDisplayInformation"/>
        /// <seealso cref="NetUserGetGroups"/>
        /// <seealso cref="NetUserGetInfo"/>
        /// <seealso cref="NetUserAdd"/>
        /// <seealso cref="USER_INFO_0"/>
        /// <seealso cref="USER_INFO_1"/>
        /// <seealso cref="USER_INFO_2"/>
        /// <seealso cref="USER_INFO_3"/>
        /// <seealso cref="USER_INFO_10"/>
        /// <seealso cref="USER_INFO_11"/>
        /// <seealso cref="USER_INFO_20"/>
        /// <seealso cref="USER_INFO_23"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserEnum(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            [In, MarshalAs(UnmanagedType.I4)] FILTER_ACCOUNT_FLAGS filter,
            out UserInfoArrayNetApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries,
            [Optional] IntPtr resume_handle
            );
        #endregion
        #region NetUserGetGroups function
        /// <summary>
        /// The <see cref="NetUserGetGroups"/> function retrieves a list of global groups to which a specified user belongs.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="username">A string that specifies the name of the user to search for in each group account. For more information, see the function Remarks section.</param>
        /// <param name="level">
        /// The information level of the data requested. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Return the names of the global groups to which the user belongs. The <paramref name="bufptr"/> parameter receives an array of <see cref="GROUP_USERS_INFO_0"/> structures.</description>
        /// <term><c>1</c> </term> - <description>Return the names of the global groups to which the user belongs with attributes. The <paramref name="bufptr"/> parameter receives an array of <see cref="GROUP_USERS_INFO_1"/> structures.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable for a buffer that receives the information structures. The format of this data depends on the value of the <paramref name="level"/> parameter.</para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <param name="prefmaxlen">The preferred maximum length, in bytes, of the returned data. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required for the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="entriesread">A variable that receives the count of elements actually retrieved.</param>
        /// <param name="totalentries">A variable that receives the total number of entries that could have been retrieved.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access rights to the requested information.</description>
        /// <term><see cref="ERROR_BAD_NETPATH"/></term><description>The network path was not found. This error is returned if the <paramref name="servername"/> parameter could not be found. </description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The system call level is not correct. This error is returned if the <paramref name="level"/> parameter is set to a value not supported. </description>
        /// <term><see cref="ERROR_INVALID_NAME"/></term><description>The name syntax is incorrect. This error is returned if the <paramref name="servername"/> parameter has leading or trailing blanks or contains an illegal character. </description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory was available to complete the operation.</description>
        /// <term><see cref="NERR_InternalError"/></term><description>An internal error occurred.</description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user could not be found. This error is returned if the <paramref name="username"/> could not be found.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user functions. For more information, see <see cref="IADsUser"/> and <see cref="IADsComputer"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits all authenticated users and members of the "<a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">Pre-Windows 2000 compatible access</a>" group to view the information. If you call this function on a member server or workstation, all authenticated users can view the information. For information about anonymous access and restricting anonymous access on these platforms, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the User object is used to perform the access check for this function.</para>
        /// <para>To retrieve a list of the local groups to which a user belongs, you can call the <see cref="NetUserGetLocalGroups"/> function. Network groups are separate and distinct from Windows NT system groups.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370653.aspx">NetUserGetGroups function</a></para>
        /// </remarks>
        /// <seealso cref="GROUP_USERS_INFO_0"/>
        /// <seealso cref="GROUP_USERS_INFO_1"/>
        /// <seealso cref="NetUserGetInfo"/>
        /// <seealso cref="NetGroupGetUsers"/>
        /// <seealso cref="NetUserGetLocalGroups"/>
        /// <seealso cref="NetQueryDisplayInformation"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserGetGroups(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string username,
            [In] int level,
            out GroupUserInfoArrayNetApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries
            );
        #endregion
        #region NetUserGetInfo function
        /// <summary>
        /// The <see cref="NetUserGetInfo"/> function retrieves information about a particular user account on a server.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="username">A string that specifies the name of the user account for which to return information. For more information, see the function Remarks section.</param>
        /// <param name="level">
        /// The information level of the data requested. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Return the user account name. The <paramref name="bufptr"/> parameter receives a <see cref="USER_INFO_0"/> structure.</description>
        /// <term><c>1</c> </term> - <description>Return detailed information about the user account. The <paramref name="bufptr"/> parameter receives a <see cref="USER_INFO_1"/> structure.</description>
        /// <term><c>2</c> </term> - <description>Return detailed information and additional attributes about the user account. The <paramref name="bufptr"/> parameter receives a <see cref="USER_INFO_2"/> structure.</description>
        /// <term><c>3</c> </term> - <description>Return detailed information and additional attributes about the user account. This level is valid only on servers. The <paramref name="bufptr"/> parameter receives a <see cref="USER_INFO_3"/> structure. Note that it is recommended that you use <see cref="USER_INFO_4"/> instead.</description>
        /// <term><c>4</c> </term> - <description>Return detailed information and additional attributes about the user account. This level is valid only on servers. The <paramref name="bufptr"/> parameter receives a <see cref="USER_INFO_4"/> structure. <br/><note>This level is supported on Windows XP and later.</note></description>
        /// <term><c>10</c> </term> - <description>Return user and account names and comments. The <paramref name="bufptr"/> parameter receives a <see cref="USER_INFO_10"/> structure.</description>
        /// <term><c>11</c> </term> - <description>Return detailed information about the user account. The <paramref name="bufptr"/> parameter receives a <see cref="USER_INFO_11"/> structure.</description>
        /// <term><c>20</c> </term> - <description>Return the user's name and identifier and various account attributes. The <paramref name="bufptr"/> parameter receives a <see cref="USER_INFO_20"/> structure. Note that on Windows XP and later, it is recommended that you use <see cref="USER_INFO_23"/> instead.</description>
        /// <term><c>23</c> </term> - <description>Return the user's name and identifier and various account attributes. The <paramref name="bufptr"/> parameter receives a <see cref="USER_INFO_23"/> structure. <br/><note>This level is supported on Windows XP and later.</note></description>
        /// <term><c>24</c> </term> - <description>Return user account information for accounts which are connected to an Internet identity. The <paramref name="bufptr"/> parameter receives a <see cref="USER_INFO_24"/> structure. <br/><note>The level is supported on Windows 8 and Windows Server 2012.</note></description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable for a buffer that receives the information structures. The format of this data depends on the value of the <paramref name="level"/> parameter.</para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access rights to the requested information.</description>
        /// <term><see cref="ERROR_BAD_NETPATH"/></term><description>The network path was not found. This error is returned if the <paramref name="servername"/> parameter could not be found. </description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The system call level is not correct. This error is returned if the <paramref name="level"/> parameter is set to a value not supported. </description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid. </description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user could not be found.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user functions. For more information, see <see cref="IADsUser"/> and <see cref="IADsComputer"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits all authenticated users and members of the "<a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">Pre-Windows 2000 compatible access</a>" group to view the information. If you call this function on a member server or workstation, all authenticated users can view the information. For information about anonymous access and restricting anonymous access on these platforms, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the User object is used to perform the access check for this function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>If the information level specified in the <paramref name="level"/> parameter is set to <c>24</c>, the <paramref name="servername"/> parameter specified must resolve to the local computer. If the <paramref name="servername"/> resolves to a remote computer or to a domain controller, the <see cref="NetUserGetInfo"/> function will fail.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370654.aspx">NetUserGetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="NetUserSetInfo"/>
        /// <seealso cref="NetUserGetGroups"/>
        /// <seealso cref="NetUserEnum"/>
        /// <seealso cref="USER_INFO_0"/>
        /// <seealso cref="USER_INFO_1"/>
        /// <seealso cref="USER_INFO_2"/>
        /// <seealso cref="USER_INFO_4"/>
        /// <seealso cref="USER_INFO_10"/>
        /// <seealso cref="USER_INFO_11"/>
        /// <seealso cref="USER_INFO_23"/>
        /// <seealso cref="USER_INFO_24"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserGetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string username,
            [In] int level,
            out UserInfoNetApiBufferHandle bufptr
            );
        #endregion
        #region NetUserGetLocalGroups function
        /// <summary>
        /// The <see cref="NetUserGetLocalGroups"/> function retrieves a list of local groups to which a specified user belongs.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="username">A string that specifies the name of the user for which to return local group membership information. If the string is of the form <c>DomainName\UserName</c> the user name is expected to be found on that domain. If the string is of the form <c>UserName</c>, the user name is expected to be found on the server specified by the <paramref name="servername"/> parameter. For more information, see the function Remarks section.</param>
        /// <param name="level">The information level of the data. This parameter can be the following value. <c>0</c> (zero) - Return the names of the local groups to which the user belongs. The <paramref name="bufptr"/> parameter points to an array of <see cref="LOCALGROUP_USERS_INFO_0"/> structures.</param>
        /// <param name="flags">A bitmask of flags that affect the operation. Currently, only the value defined is <see cref="LG_INCLUDE_INDIRECT"/>. If this bit is set, the function also returns the names of the local groups in which the user is indirectly a member (that is, the user has membership in a global group that is itself a member of one or more local groups).</param>
        /// <param name="bufptr">
        /// <para>A variable for a buffer that receives the information structures. The format of this data depends on the value of the <paramref name="level"/> parameter.</para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed. Note that you must free the buffer even if the function fails with <see cref="ERROR_MORE_DATA"/>.</para>
        /// </param>
        /// <param name="prefmaxlen">The preferred maximum length, in bytes, of the returned data. If you specify <see cref="MAX_PREFERRED_LENGTH"/>, the function allocates the amount of memory required for the data. If you specify another value in this parameter, it can restrict the number of bytes that the function returns. If the buffer size is insufficient to hold all entries, the function returns <see cref="ERROR_MORE_DATA"/>.</param>
        /// <param name="entriesread">A variable that receives the count of elements actually retrieved.</param>
        /// <param name="totalentries">A variable that receives the total number of entries that could have been retrieved.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access rights to the requested information. This error is also returned if the <paramref name="servername"/> parameter has a trailing blank.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The system call level is not correct. This error is returned if the <paramref name="level"/> parameter is set to a value not supported. </description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="flags"/> parameter contains a value other than <see cref="LG_INCLUDE_INDIRECT"/>. </description>
        /// <term><see cref="ERROR_MORE_DATA"/></term><description>More entries are available. Specify a large enough buffer to receive all entries.</description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory was available to complete the operation.</description>
        /// <term><see cref="NERR_DCNotFound"/></term><description>The domain controller could not be found. </description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user could not be found. This error is returned if the <paramref name="username"/> could not be found.</description>
        /// <term><see cref="RPC_S_SERVER_UNAVAILABLE"/></term><description>The RPC server is unavailable. This error is returned if the <paramref name="servername"/> parameter could not be found. </description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user functions. For more information, see <see cref="IADsUser"/> and <see cref="IADsComputer"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits all authenticated users and members of the "<a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">Pre-Windows 2000 compatible access</a>" group to view the information. If you call this function on a member server or workstation, all authenticated users can view the information. For information about anonymous access and restricting anonymous access on these platforms, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Domain object is used to perform the access check for this function. The caller must have Read Property permission on the Domain object.</para>
        /// <para>To retrieve a list of global groups to which a specified user belongs, you can call the <see cref="NetUserGetGroups"/> function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370655.aspx">NetUserGetLocalGroups function</a></para>
        /// </remarks>
        /// <seealso cref="NetUserGetGroups"/>
        /// <seealso cref="LOCALGROUP_USERS_INFO_0"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserGetLocalGroups(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string username,
            [In] int level,
            [In, MarshalAs(UnmanagedType.I4)] LG_INCLUDE_FLAG flags,
            out LocalGroupUsersArrayInfoNetApiBufferHandle bufptr,
            [In] int prefmaxlen,
            out int entriesread,
            out int totalentries
            );
        #endregion
        #region NetUserModalsGet function
        /// <summary>
        /// The <see cref="NetUserModalsGet"/> function retrieves global information for all users and global groups in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. For more information, see the function Remarks section. </param>
        /// <param name="level">
        /// The information level of the data requested. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Return global password parameters. The <paramref name="bufptr"/> parameter receives a <see cref="USER_MODALS_INFO_0"/> structure.</description>
        /// <term><c>1</c> </term> - <description>Return logon server and domain controller information. The <paramref name="bufptr"/> parameter receives a <see cref="USER_MODALS_INFO_1"/> structure.</description>
        /// <term><c>2</c> </term> - <description>Return domain name and identifier. The <paramref name="bufptr"/> parameter receives a <see cref="USER_MODALS_INFO_2"/> structure. For more information, see the function Remarks section.</description>
        /// <term><c>3</c> </term> - <description>Return lockout information. This level is valid only on servers. The <paramref name="bufptr"/> parameter receives a <see cref="USER_MODALS_INFO_3"/> structure. Note that it is recommended that you use <see cref="USER_INFO_4"/> instead.</description>
        /// </list>
        /// A null session logon can call <see cref="NetUserModalsGet"/> anonymously at information levels <c>0</c> and <c>3</c>.
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable for a buffer that receives the information structures. The format of this data depends on the value of the <paramref name="level"/> parameter.</para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access rights to the requested information.</description>
        /// <term><see cref="ERROR_BAD_NETPATH"/></term><description>The network path was not found. This error is returned if the <paramref name="servername"/> parameter could not be found.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The system call level is not correct. This error is returned if the <paramref name="level"/> parameter is set to a value not supported. </description>
        /// <term><see cref="ERROR_INVALID_NAME"/></term><description>The file name, directory name, or volume label syntax is incorrect. This error is returned if the <paramref name="servername"/> parameter syntax is incorrect.</description>
        /// <term><see cref="ERROR_WRONG_TARGET_NAME"/></term><description>The target account name is incorrect. This error is returned for a logon failure to a remote <paramref name="servername"/> parameter running on Windows Vista.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user modal functions. For more information, see <see cref="IADsDomain"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits all authenticated users and members of the "<a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">Pre-Windows 2000 compatible access</a>" group to view the information. If you call this function on a member server or workstation, all authenticated users can view the information. For information about anonymous access and restricting anonymous access on these platforms, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Domain object is used to perform the access check for this function.</para>
        /// <para>To retrieve the security identifier (SID) of the domain to which the computer belongs, call the <see cref="NetUserModalsGet"/> function specifying a <see cref="USER_MODALS_INFO_2"/> structure and <c>null</c> in the <paramref name="servername"/> parameter. If the computer isn't a member of a domain, the function returns a <c>null</c> buffer.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370656.aspx">NetUserModalsGet function</a></para>
        /// </remarks>
        /// <seealso cref="NetUserModalsSet"/>
        /// <seealso cref="USER_MODALS_INFO_0"/>
        /// <seealso cref="USER_MODALS_INFO_1"/>
        /// <seealso cref="USER_MODALS_INFO_2"/>
        /// <seealso cref="USER_MODALS_INFO_3"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserModalsGet(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            out UserModalsInfoNetApiBufferHandle bufptr
            );
        #endregion
        #region NetUserModalsSet function
        /// <summary>
        /// The <see cref="NetUserModalsSet"/> function sets global information for all users and global groups in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Specifies global password parameters. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_0"/> structure.</description>
        /// <term><c>1</c></term> - <description>Specifies logon server and domain controller information. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_1"/> structure.</description>
        /// <term><c>2</c></term> - <description>Specifies the domain name and identifier. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_2"/> structure.</description>
        /// <term><c>3</c></term> - <description>Specifies lockout information. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_3"/> structure.</description>
        /// <term><c>1001</c></term> - <description>Specifies the minimum allowable password length. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_1001"/> structure.</description>
        /// <term><c>1002</c></term> - <description>Specifies the maximum allowable password age. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_1002"/> structure.</description>
        /// <term><c>1003</c></term> - <description>Specifies the minimum allowable password age. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_1003"/> structure.</description>
        /// <term><c>1004</c></term> - <description>Specifies forced logoff information. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_1004"/> structure.</description>
        /// <term><c>1005</c></term> - <description>Specifies the length of the password history. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_1005"/> structure.</description>
        /// <term><c>1006</c></term> - <description>Specifies the role of the logon server. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_1006"/> structure.</description>
        /// <term><c>1007</c></term> - <description>Specifies domain controller information. The <paramref name="buf"/> parameter specifies a <see cref="USER_MODALS_INFO_1007"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="buf">An object instance that specifies the data. The format of this data depends on the value of the <paramref name="level"/> parameter.</param>
        /// <param name="parm_err">A variable that receives the index of the first member of the information structure that causes <see cref="ERROR_INVALID_PARAMETER"/>. If this parameter is omitted, the index is not returned on error.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access rights to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>The specified parameter is invalid. For more information, see the function Remarks section.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user name could not be found.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user modal functions. For more information, see <see cref="IADsDomain"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits all authenticated users and members of the "<a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">Pre-Windows 2000 compatible access</a>" group to view the information. If you call this function on a member server or workstation, all authenticated users can view the information. For information about anonymous access and restricting anonymous access on these platforms, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Domain object is used to perform the access check for this function. Typically, callers must have write access to the entire object for calls to this function to succeed.</para>
        /// <para>If the <see cref="NetUserModalsSet"/> function returns <see cref="ERROR_INVALID_PARAMETER"/>, you can use the <paramref name="parm_err"/> parameter to indicate the first member of the information structure that is invalid. (The information structure begins with <strong>USER_MODALS_INFO_</strong> and its format is specified by the <paramref name="level"/> parameter.) The values that can be returned in the <paramref name="parm_err"/> parameter and the corresponding structure member that is in error is listed in the <see cref="USER_MODALS_INFO_PARMNUM"/> enumeration type.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370657.aspx">NetUserModalsSet function</a></para>
        /// </remarks>
        /// <seealso cref="NetUserModalsSet"/>
        /// <seealso cref="USER_MODALS_INFO_0"/>
        /// <seealso cref="USER_MODALS_INFO_1"/>
        /// <seealso cref="USER_MODALS_INFO_2"/>
        /// <seealso cref="USER_MODALS_INFO_3"/>
        /// <seealso cref="USER_MODALS_INFO_1001"/>
        /// <seealso cref="USER_MODALS_INFO_1002"/>
        /// <seealso cref="USER_MODALS_INFO_1003"/>
        /// <seealso cref="USER_MODALS_INFO_1004"/>
        /// <seealso cref="USER_MODALS_INFO_1005"/>
        /// <seealso cref="USER_MODALS_INFO_1006"/>
        /// <seealso cref="USER_MODALS_INFO_1007"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserModalsSet(
            [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object buf,
            [Optional] out USER_MODALS_INFO_PARMNUM parm_err
            );
        #endregion
        #region NetUserSetGroups function
        /// <summary>
        /// The <see cref="NetUserSetGroups"/> function sets global group memberships for a specified user account.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="username">A string that specifies the name of the user for which to set global group memberships. For more information, see the function Remarks section.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>The <paramref name="buf"/> parameter specifies an array of <see cref="GROUP_USERS_INFO_0"/> structures that specifies global group names.</description>
        /// <term><c>1</c></term> - <description>The <paramref name="buf"/> parameter specifies an array of <see cref="GROUP_USERS_INFO_1"/> structures that specifies global group names with attributes.</description>
        /// </list>
        /// </param>
        /// <param name="buf">An array that specifies the data. The type of the instances in the array must comply with the information specified in the <paramref name="level"/> parameter.</param>
        /// <param name="num_entries">The number of entries contained in the array specified by the <paramref name="buf"/> parameter.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access rights to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The system call level is not correct. This error is returned if the <paramref name="level"/> parameter was specified as a value other than <c>0</c> (zero) or <c>1</c>. </description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter passed was not valid. This error is returned if the num_entries parameter was not valid. </description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Insufficient memory was available to complete the operation.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_GroupNotFound"/></term><description>The group group name specified by the <see cref="GROUP_USERS_INFO_0.grui0_name"/> in the <see cref="GROUP_USERS_INFO_0"/> structure or <see cref="GROUP_USERS_INFO_1.grui1_name"/> member in the <see cref="GROUP_USERS_INFO_1"/> structure specified by the <paramref name="buf"/> parameter does not exist.</description>
        /// <term><see cref="NERR_InternalError"/></term><description>An internal error occurred.</description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user name could not be found.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user functions. For more information, see <see cref="IADsUser"/> and <see cref="IADsComputer"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits all authenticated users and members of the "<a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">Pre-Windows 2000 compatible access</a>" group to view the information. If you call this function on a member server or workstation, all authenticated users can view the information. For information about anonymous access and restricting anonymous access on these platforms, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the User object is used to perform the access check for this function.</para>
        /// <para>To grant a user membership in one existing global group, you can call the <see cref="NetGroupAddUser"/> function.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370658.aspx">NetUserSetGroups function</a></para>
        /// </remarks>
        /// <seealso cref="NetUserGetGroups"/>
        /// <seealso cref="NetGroupAddUser"/>
        /// <seealso cref="GROUP_USERS_INFO_0"/>
        /// <seealso cref="GROUP_USERS_INFO_1"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserSetGroups(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string username,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPArray)] object[] buf,
            [In] int num_entries
            );
        #endregion
        #region NetUserSetInfo function
        /// <summary>
        /// The <see cref="NetUserSetInfo"/> function sets the parameters of a user account.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="username">A string that specifies the name of the user account for which to set information. For more information, see the function Remarks section.</param>
        /// <param name="level">
        /// The information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>0</c> (zero)</term> - <description>Specifies the user account name. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_0"/> structure. Use this structure to specify a new group name. For more information, see the function Remarks section.</description>
        /// <term><c>1</c></term> - <description>Specifies detailed information about the user account. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1"/> structure.</description>
        /// <term><c>2</c></term> - <description>Specifies level one information and additional attributes about the user account. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_2"/> structure.</description>
        /// <term><c>3</c></term> - <description>Specifies level two information and additional attributes about the user account. This level is valid only on servers. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_3"/> structure. Note that it is recommended that you use <see cref="USER_INFO_4"/> instead.</description>
        /// <term><c>4</c></term> - <description>Specifies level two information and additional attributes about the user account. This level is valid only on servers. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_4"/> structure.</description>
        /// <term><c>21</c></term> - <description>Specifies a one-way encrypted LAN Manager 2.x-compatible password. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_21"/> structure.</description>
        /// <term><c>22</c></term> - <description>Specifies detailed information about the user account. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_22"/> structure.</description>
        /// <term><c>1003</c></term> - <description>Specifies a user password. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1003"/> structure.</description>
        /// <term><c>1005</c></term> - <description>Specifies a user privilege level. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1005"/> structure.</description>
        /// <term><c>1006</c></term> - <description>Specifies the path of the home directory for the user. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1006"/> structure.</description>
        /// <term><c>1007</c></term> - <description>Specifies a comment to associate with the user account. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1007"/> structure.</description>
        /// <term><c>1008</c></term> - <description>Specifies user account attributes. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1008"/> structure.</description>
        /// <term><c>1009</c></term> - <description>Specifies the path for the user's logon script file. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1009"/> structure.</description>
        /// <term><c>1010</c></term> - <description>Specifies the user's operator privileges. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1010"/> structure.</description>
        /// <term><c>1011</c></term> - <description>Specifies the full name of the user. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1011"/> structure.</description>
        /// <term><c>1012</c></term> - <description>Specifies a comment to associate with the user. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1012"/> structure.</description>
        /// <term><c>1014</c></term> - <description>Specifies the names of workstations from which the user can log on. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1014"/> structure.</description>
        /// <term><c>1017</c></term> - <description>Specifies when the user account expires. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1017"/> structure.</description>
        /// <term><c>1020</c></term> - <description>Specifies the times during which the user can log on. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1020"/> structure.</description>
        /// <term><c>1024</c></term> - <description>Specifies the user's country/region code. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1024"/> structure.</description>
        /// <term><c>1051</c></term> - <description>Specifies the relative identifier of a global group that represents the enrolled user. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1051"/> structure.</description>
        /// <term><c>1052</c></term> - <description>Specifies the path to a network user's profile. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1052"/> structure.</description>
        /// <term><c>1053</c></term> - <description>Specifies the drive letter assigned to the user's home directory. The <paramref name="buf"/> parameter specifies a <see cref="USER_INFO_1053"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="buf">An object instance that specifies the data. The format of this data depends on the value of the <paramref name="level"/> parameter.</param>
        /// <param name="parm_err">A variable that receives the index of the first member of the user information structure that causes <see cref="ERROR_INVALID_PARAMETER"/>. If this parameter is omitted, the index is not returned on error.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access rights to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>One of the function parameters is invalid. For more information, see the function Remarks section.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The computer name is invalid.</description>
        /// <term><see cref="NERR_NotPrimary"/></term><description>The operation is allowed only on the primary domain controller of the domain.</description>
        /// <term><see cref="NERR_SpeGroupOp"/></term><description>The operation is not allowed on specified special groups, which are user groups, admin groups, local groups, or guest groups.</description>
        /// <term><see cref="NERR_LastAdmin"/></term><description>The operation is not allowed on the last administrative account.</description>
        /// <term><see cref="NERR_BadPassword"/></term><description>The share name or password is invalid.</description>
        /// <term><see cref="NERR_PasswordTooShort"/></term><description>The password is shorter than required. (The password could also be too long, be too recent in its change history, not have enough unique characters, or not meet another password policy requirement.)</description>
        /// <term><see cref="NERR_UserNotFound"/></term><description>The user name could not be found.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If you are programming for Active Directory, you may be able to call certain Active Directory Service Interface (ADSI) methods to achieve the same functionality you can achieve by calling the network management user functions. For more information, see <see cref="IADsUser"/> and <see cref="IADsComputer"/>.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits all authenticated users and members of the "<a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">Pre-Windows 2000 compatible access</a>" group to view the information. If you call this function on a member server or workstation, all authenticated users can view the information. For information about anonymous access and restricting anonymous access on these platforms, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the User object is used to perform the access check for this function.</para>
        /// <para>Only users or applications having administrative privileges can call the <see cref="NetUserSetInfo"/> function to change a user's password. When an administrator calls <see cref="NetUserSetInfo"/>, the only restriction applied is that the new password length must be consistent with system modals. A user or application that knows a user's current password can call the <see cref="NetUserChangePassword"/> function to change the password. For more information about calling functions that require administrator privileges, see <a href="https://msdn.microsoft.com/en-us/library/ms717802.aspx">Running with Special Privileges</a>.</para>
        /// <para>Members of the Administrators local group can set any modifiable user account elements. All users can set the <see cref="USER_INFO_2.usri2_country_code"/> member of the <see cref="USER_INFO_2"/> structure (and the <see cref="USER_INFO_1024.usri1024_country_code"/> member of the <see cref="USER_INFO_1024"/> structure) for their own accounts.</para>
        /// <para>A member of the Account Operator's local group cannot set details for an Administrators class account, give an existing account Administrator privilege, or change the operator privilege of any account. If you attempt to change the privilege level or disable the last account with Administrator privilege in the security database, (the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory), the <see cref="NetUserSetInfo"/> function fails and returns <see cref="NERR_LastAdmin"/>.</para>
        /// <para>
        /// To set the following user account control flags, the following <a href="https://msdn.microsoft.com/en-us/library/aa379306.aspx">privileges</a> and <a href="https://msdn.microsoft.com/en-us/library/ms675747.aspx">control access rights</a> are required.
        /// <list type="table">
        /// <listheader><term>Account control flag</term><description>Privilege or right required</description></listheader>
        /// <term><see cref="UF_TRUSTED_TO_AUTHENTICATE_FOR_DELEGATION"/></term><description><c>SeEnableDelegationPrivilege</c> privilege, which is granted to Administrators by default. </description>
        /// <term><see cref="UF_TRUSTED_FOR_DELEGATION"/></term><description><c>SeEnableDelegationPrivilege</c>.</description>
        /// <term><see cref="UF_PASSWD_NOTREQD"/></term><description>"Update password not required" control access right on the Domain object, which is granted to authenticated users by default.</description>
        /// <term><see cref="UF_DONT_EXPIRE_PASSWD"/></term><description>"Unexpire password" control access right on the Domain object, which is granted to authenticated users by default.</description>
        /// <term><see cref="UF_ENCRYPTED_TEXT_PASSWORD_ALLOWED"/></term><description>"Enable per user reversibly encrypted password" control access right on the Domain object, which is granted to authenticated users by default.</description>
        /// <term><see cref="UF_SERVER_TRUST_ACCOUNT"/></term><description>"Add/remove replica in domain" control access right on the Domain object, which is granted to Administrators by default.</description>
        /// </list>
        /// For a list of privilege constants, see <a href="https://msdn.microsoft.com/en-us/library/aa375728.aspx">Authorization Constants</a>.
        /// </para>
        /// <para>The correct way to specify the new name for an account is to call <see cref="NetUserSetInfo"/> with <see cref="USER_INFO_0"/> and to specify the new value using the <see cref="USER_INFO_0.usri0_name"/> member. If you call <see cref="NetUserSetInfo"/> with other information levels and specify a value using a <strong>usriX_name</strong> member, the value is ignored.</para>
        /// <para>Note that calls to <see cref="NetUserSetInfo"/> can change the home directory only for user accounts that the network server creates.</para>
        /// <para>If the <see cref="NetUserSetInfo"/> function returns <see cref="ERROR_INVALID_PARAMETER"/>, you can use the <paramref name="parm_err"/> parameter to indicate the first member of the user information structure that is invalid. (A user information structure begins with <strong>USER_INFO_</strong> and its format is specified by the <paramref name="level"/> parameter.) The values that can be returned in the <paramref name="parm_err"/> parameter and the corresponding structure member that is in error is listed in the <see cref="USER_INFO_PARMNUM"/> enumeration type.</para>
        /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
        /// <para>The <see cref="NetUserSetInfo"/> function does not control how the password parameters are secured when sent over the network to a remote server to change a user password. Any encryption of these parameters is handled by the Remote Procedure Call (RPC) mechanism supported by the network redirector that provides the network transport. Encryption is also controlled by the security mechanisms supported by the local computer and the security mechanisms supported by remote network server specified in the servername parameter. For more details on security when the Microsoft network redirector is used and the remote network server is running Microsoft Windows, see the protocol documentation for <a href="http://go.microsoft.com/fwlink/p/?linkid=200126">MS-RPCE</a> and <a href="http://go.microsoft.com/fwlink/p/?linkid=200128">MS-SAMR</a>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370659.aspx">NetUserSetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="NetUserGetInfo"/>
        /// <seealso cref="USER_INFO_0"/>
        /// <seealso cref="USER_INFO_1"/>
        /// <seealso cref="USER_INFO_2"/>
        /// <seealso cref="USER_INFO_4"/>
        /// <seealso cref="USER_INFO_21"/>
        /// <seealso cref="USER_INFO_22"/>
        /// <seealso cref="USER_INFO_1003"/>
        /// <seealso cref="USER_INFO_1005"/>
        /// <seealso cref="USER_INFO_1006"/>
        /// <seealso cref="USER_INFO_1007"/>
        /// <seealso cref="USER_INFO_1008"/>
        /// <seealso cref="USER_INFO_1009"/>
        /// <seealso cref="USER_INFO_1010"/>
        /// <seealso cref="USER_INFO_1011"/>
        /// <seealso cref="USER_INFO_1012"/>
        /// <seealso cref="USER_INFO_1013"/>
        /// <seealso cref="USER_INFO_1014"/>
        /// <seealso cref="USER_INFO_1017"/>
        /// <seealso cref="USER_INFO_1020"/>
        /// <seealso cref="USER_INFO_1024"/>
        /// <seealso cref="USER_INFO_1051"/>
        /// <seealso cref="USER_INFO_1052"/>
        /// <seealso cref="USER_INFO_1053"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetUserSetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In, MarshalAs(UnmanagedType.LPWStr)] string username,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object buf,
            [Optional] out USER_INFO_PARMNUM parm_err
            );
        #endregion
        #region NetValidateName function
        /// <summary>
        /// The <see cref="NetValidateName"/> function verifies that a name is valid for name type specified (computer name, workgroup name, domain name, or DNS computer name).
        /// </summary>
        /// <param name="lpServer">A string that specifies the DNS or NetBIOS name of the computer on which to call the function. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="lpName">A string that specifies the name to validate. Depending on the value specified in the <paramref name="NameType"/> parameter, the <paramref name="lpName"/> parameter can specify a computer name, workgroup name, domain name, or DNS computer name.</param>
        /// <param name="lpAccount">If the <paramref name="lpName"/> parameter is a domain name, this parameter specifies an account name to use when connecting to the domain controller. The string must specify either a domain NetBIOS name and user account (for example, <c>"REDMOND\user"</c>) or the user principal name (UPN) of the user in the form of an Internet-style login name (for example, <c>"someone@example.com"</c>). If this parameter is <c>null</c>, the caller's context is used.</param>
        /// <param name="lpPassword">If the <paramref name="lpAccount"/> parameter specifies an account name, this parameter must specify the password to use when connecting to the domain controller. Otherwise, this parameter must be <c>null</c>.</param>
        /// <param name="NameType">The type of the name passed in the <paramref name="lpName"/> parameter to validate. This parameter can be one of the values from the <see cref="NETSETUP_NAME_TYPE"/> enumeration type.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="DNS_ERROR_INVALID_NAME_CHAR"/></term><description>The DNS name contains an invalid character. This error is returned if the <paramref name="NameType"/> parameter specified is <see cref="NetSetupDnsMachine"/> and the DNS name in the <paramref name="lpName"/> parameter contains an invalid character. </description>
        /// <term><see cref="DNS_ERROR_NON_RFC_NAME"/></term><description>The DNS name does not comply with RFC specifications. This error is returned if the <paramref name="NameType"/> parameter specified is <see cref="NetSetupDnsMachine"/> and the DNS name in the <paramref name="lpName"/> parameter does not comply with RFC specifications. </description>
        /// <term><see cref="ERROR_DUP_NAME"/></term><description>A duplicate name already exists on the network.</description>
        /// <term><see cref="ERROR_INVALID_COMPUTERNAME"/></term><description>The format of the specified computer name is not valid. </description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="lpName"/> parameter is <c>null</c> or the <paramref name="NameType"/> parameter is specified as <see cref="NetSetupUnknown"/> or an unknown nametype. </description>
        /// <term><see cref="ERROR_NO_SUCH_DOMAIN"/></term><description>The specified domain does not exist.</description>
        /// <term><see cref="ERROR_NOT_SUPPORTED"/></term><description>The request is not supported. This error is returned if a remote computer was specified in the <paramref name="lpServer"/> parameter and this call is not supported on the remote computer.</description>
        /// <term><see cref="NERR_InvalidComputer"/></term><description>The specified computer name is not valid. This error is returned if the <paramref name="NameType"/> parameter specified is <see cref="NetSetupDnsMachine"/> or <see cref="NetSetupMachine"/> and the specified computer name is not valid.</description>
        /// <term><see cref="NERR_InvalidWorkgroupName"/></term><description>The specified workgroup name is not valid. This error is returned if the <paramref name="NameType"/> parameter specified is <see cref="NetSetupWorkgroup"/> and the specified workgroup name is not valid.</description>
        /// <term><see cref="RPC_S_SERVER_UNAVAILABLE"/></term><description>The RPC server is not available. This error is returned if a remote computer was specified in the <paramref name="lpServer"/> parameter and the RPC server is not available.</description>
        /// <term><see cref="RPC_E_REMOTE_DISABLED"/></term><description>Remote calls are not allowed for this process. This error is returned if a remote computer was specified in the lpServer parameter and remote calls are not allowed for this process.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetValidateName"/> function validates a name based on the nametype specified. </para>
        /// <para>If the <paramref name="NameType"/> parameter is <see cref="NetSetupMachine"/>, the name passed in the <paramref name="lpName"/> parameter must be syntactically correct as a NetBIOS name and the name must not currently be in use on the network.</para>
        /// <para>If the <paramref name="NameType"/> parameter is <see cref="NetSetupWorkgroup"/>, the name passed in the <paramref name="lpName"/> parameter must be syntactically correct as a NetBIOS name, the name must not currently be in use on the network as a unique name, and the name must be different from the computer name.</para>
        /// <para>If the <paramref name="NameType"/> parameter is <see cref="NetSetupDomain"/>, the name passed in the <paramref name="lpName"/> parameter must be syntactically correct as a NetBIOS or DNS name and the name must currently be registered as a domain name.</para>
        /// <para>If the <paramref name="NameType"/> parameter is <see cref="NetSetupNonExistentDomain"/>, the name passed in the <paramref name="lpName"/> parameter must be syntactically correct as a NetBIOS or DNS name and the name must currently not be registered as a domain name.</para>
        /// <para>If the <paramref name="NameType"/> parameter is <see cref="NetSetupDnsMachine"/>, the name passed in the <paramref name="lpName"/> parameter must be syntactically correct as a DNS name.</para>
        /// <para>NetBIOS names are limited to maximum length of 16 characters.</para>
        /// <para>No special group membership is required to successfully execute the <see cref="NetValidateName"/> function.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370660.aspx">NetValidateName function</a></para>
        /// </remarks>
        /// <seealso cref="NetGetJoinableOUs"/>
        /// <seealso cref="NetGetJoinInformation"/>
        /// <seealso cref="NetJoinDomain"/>
        /// <seealso cref="NetRenameMachineInDomain"/>
        /// <seealso cref="NetUnjoinDomain"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetValidateName(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpServer,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpName,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpAccount,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpPassword,
            [In] NETSETUP_NAME_TYPE NameType
            );
        #endregion
        #region NetValidatePasswordPolicyFree function
        /// <summary>
        /// The <see cref="NetValidatePasswordPolicyFree"/> function frees the memory that the <see cref="NetValidatePasswordPolicy"/> function allocates for the <var>OutputArg</var> parameter, which is a <see cref="NET_VALIDATE_OUTPUT_ARG"/> structure.
        /// </summary>
        /// <param name="OutputArg">Pointer to the memory allocated for the <var>OutputArg</var> parameter by a call to the <see cref="NetValidatePasswordPolicy"/> function.</param>
        /// <returns>
        /// <para>If the function frees the memory, or if there is no memory to free from a previous call to <see cref="NetValidatePasswordPolicy"/>, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>If the function fails, the return value is a system error code.</para>
        /// </returns>
        /// <remarks>
        /// No special group membership is required to successfully execute this function.
        /// <para><strong>Minimum supported client</strong>: Not Supported</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370662.aspx">NetValidatePasswordPolicyFree function</a></para>
        /// </remarks>
        /// <seealso cref="NetValidatePasswordPolicy"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetValidatePasswordPolicyFree(
            [In] IntPtr OutputArg
            );
        #endregion
        #region NetValidatePasswordPolicy function
        /// <summary>
        /// The <see cref="NetValidatePasswordPolicy"/> function allows an application to check password compliance against an application-provided account database and verify that passwords meet the complexity, aging, minimum length, and history reuse requirements of a password policy. 
        /// </summary>
        /// <param name="ServerName">A string specifying the name of the remote server on which the function is to execute. This string must begin with <c>\\</c> followed by the remote server name. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="Qualifier">Reserved for future use. This parameter must be <see cref="IntPtr.Zero"/>.</param>
        /// <param name="ValidationType">
        /// <para>The type of password validation to perform. This parameter must be one of the following enumerated constant values. </para>
        /// <para>These values have the following meanings.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><see cref="NetValidateAuthentication"/></term> - <description>The application is requesting password validation during authentication. The <paramref name="InputArg"/> parameter points to a <see cref="NET_VALIDATE_AUTHENTICATION_INPUT_ARG"/> structure. This type of validation enforces password expiration and account lockout policy.</description>
        /// <term><see cref="NetValidatePasswordChange"/></term> - <description>The application is requesting password validation during a password change operation. The <paramref name="InputArg"/> parameter points to a <see cref="NET_VALIDATE_PASSWORD_CHANGE_INPUT_ARG"/> structure.</description>
        /// <term><see cref="NetValidatePasswordReset"/></term> - <description>The application is requesting password validation during a password reset operation. The <paramref name="InputArg"/> parameter points to a <see cref="NET_VALIDATE_PASSWORD_RESET_INPUT_ARG"/> structure. You can also reset the "lockout state" of a user account by specifying this structure.</description>
        /// </list>
        /// </para>
        /// </param>
        /// <param name="InputArg">A structure that depends on the type of password validation to perform. The type of structure depends on the value of the <paramref name="ValidationType"/> parameter. For more information, see the description of the <paramref name="ValidationType"/> parameter.</param>
        /// <param name="OutputArg">
        /// <para>If the <see cref="NetValidatePasswordPolicy"/> function succeeds (the return value is <see cref="NERR_Success"/>), then the function allocates an buffer that contains the results of the operation. The <paramref name="OutputArg"/> parameter contains a pointer to a <see cref="NET_VALIDATE_OUTPUT_ARG"/> structure. The application must examine <see cref="NET_VALIDATE_OUTPUT_ARG.ValidationStatus"/> member in the <see cref="NET_VALIDATE_OUTPUT_ARG"/> structure pointed to by the <paramref name="OutputArg"/> parameter to determine the results of the password policy validation check. The <see cref="NET_VALIDATE_OUTPUT_ARG"/> structure contains a <see cref="NET_VALIDATE_PERSISTED_FIELDS"/> structure with changes to persistent password-related information, and the results of the password validation. The application must plan to persist all persisted the fields in the <see cref="NET_VALIDATE_PERSISTED_FIELDS"/> structure aside from the <see cref="NET_VALIDATE_OUTPUT_ARG.ValidationStatus"/> member as information along with the user object information and provide the required fields from the persisted information when calling this function in the future on the same user object.</para>
        /// <para>If the <see cref="NetValidatePasswordPolicy"/> function fails (the return value is nonzero), then <paramref name="OutputArg"/> parameter is set to <c>null</c> and password policy could not be examined.</para>
        /// <para>For more information, see the Return Values and Remarks sections of this function.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, and the password is authenticated, changed, or reset, the return value is <see cref="NERR_Success"/> and the function allocates an <paramref name="OutputArg"/> parameter.</para>
        /// <para>
        /// If the function fails, the <paramref name="OutputArg"/> parameter is <c>null</c> and the return value is a system error code that can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>A parameter is incorrect. This error is returned if the <paramref name="InputArg"/> or <paramref name="OutputArg"/> parameters are <c>null</c>. This error is also returned if the <paramref name="Qualifier"/> parameter is not <c>null</c> or if the <paramref name="ValidationType"/> parameter is not one of the allowed values. </description>
        /// <term><see cref="ERROR_NOT_ENOUGH_MEMORY"/></term><description>Not enough memory is available to complete the operation.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="NetValidatePasswordPolicy"/> function is designed to allow applications to validate passwords for users that are in an account database provided by the application. This function can also be used to verify that passwords meet the complexity, aging, minimum length, and history reuse requirements of a password policy. This function also provides the means for an application to implement an account-lockout mechanism.</para>
        /// <para>The <see cref="NetValidatePasswordPolicy"/> function does not validate passwords in Active Directory accounts and cannot be used for this purpose. The only policy that this function checks a password against in Active Directory accounts is the password complexity (the password strength). </para>
        /// <para>A typical scenario for the use of the <see cref="NetValidatePasswordPolicy"/> function would be enforcing the choice of strong passwords by users for web applications and applications that allow password-protected documents. Another use of this function could be checking password complexity in a situation in which a password is attached to a functional operation rather than to a user account; for example, passwords that are used with Secure Multipurpose Internet Mail Extensions (S/MIME) certificate-based public keys.</para>
        /// <para>If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the <a href="https://msdn.microsoft.com/en-us/library/aa379557.aspx">securable object</a>. The default ACL permits all authenticated users and members of the "<a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">Pre-Windows 2000 compatible access</a>" group to view the information. If you call this function on a member server or workstation, all authenticated users can view the information. For information about anonymous access and restricting anonymous access on these platforms, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para>The security descriptor of the Domain object is used to perform the access check for the <see cref="NetValidatePasswordPolicy"/> function. </para>
        /// <para>To call <see cref="NetValidatePasswordPolicy"/> in a security context that is not the default, first call the <see cref="LogonUser"/> function, specifying <see cref="LOGON32_LOGON_NEW_CREDENTIALS"/> in the <var>dwLogonType</var> parameter, and then call <see cref="NetValidatePasswordPolicy"/> under impersonation. For more information about impersonation, see <a href="https://msdn.microsoft.com/en-us/library/aa376391.aspx">Client Impersonation</a>.</para>
        /// <para>If the return code of the <see cref="NetValidatePasswordPolicy"/> function is <see cref="NERR_Success"/> then the function allocates a buffer pointed to by the <paramref name="OutputArg"/> parameter that contains a <see cref="NET_VALIDATE_OUTPUT_ARG"/> structure with the results of the operation. The application must examine <see cref="NET_VALIDATE_OUTPUT_ARG.ValidationStatus"/> member in the <see cref="NET_VALIDATE_OUTPUT_ARG"/> structure to determine the results of the password policy validation check. For more information, see <see cref="NET_VALIDATE_OUTPUT_ARG"/>.</para>
        /// <para>Note that it is the application's responsibility to save all the data in the <see cref="NET_VALIDATE_OUTPUT_ARG.ChangedPersistedFields"/> member of the <see cref="NET_VALIDATE_OUTPUT_ARG"/> structure as well as any User object information. The next time the application calls <see cref="NetValidatePasswordPolicy"/> on the same instance of the User object, the application must provide the required fields from the persistent information.</para>
        /// <para>When you call <see cref="NetValidatePasswordPolicy"/> and specify <see cref="NET_VALIDATE_PASSWORD_CHANGE_INPUT_ARG"/> or <see cref="NET_VALIDATE_PASSWORD_RESET_INPUT_ARG"/> in <paramref name="InputArg"/> parameter, the call also validates the password by passing it through the password filter DLL that the computer is configured to use. For more information about password filters, see <a href="https://msdn.microsoft.com/en-us/library/ms722496.aspx">Using Password Filters</a>.</para>
        /// <para>If the return value from the <see cref="NetValidatePasswordPolicy"/> function is nonzero then <paramref name="OutputArg"/> parameter is set to <c>null</c> and password policy could not be examined.</para>
        /// <para>The handle returned by the <paramref name="OutputArg"/> parameter should be wrapped in a <c>using</c> block so that the memory allocated for the <paramref name="OutputArg"/> parameter is freed properly once it is no longer needed. Otherwise, the application should make sure that the <see cref="SafeHandle.Dispose()"/> is called on the returned handle to manually free the allocated memory.</para>
        /// <para><strong>Minimum supported client</strong>: Not Supported</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370661.aspx">NetValidatePasswordPolicy function</a></para>
        /// </remarks>
        /// <seealso cref="LogonUser"/>
        /// <seealso cref="NET_VALIDATE_AUTHENTICATION_INPUT_ARG"/>
        /// <seealso cref="NET_VALIDATE_OUTPUT_ARG"/>
        /// <seealso cref="NET_VALIDATE_PASSWORD_CHANGE_INPUT_ARG"/>
        /// <seealso cref="NET_VALIDATE_PASSWORD_RESET_INPUT_ARG"/>
        /// <seealso cref="NET_VALIDATE_PERSISTED_FIELDS"/>
        /// <seealso cref="NetValidatePasswordPolicyFree"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetValidatePasswordPolicy(
            [In, MarshalAs(UnmanagedType.LPWStr)] string ServerName,
            [In] IntPtr Qualifier,
            [In] NET_VALIDATE_PASSWORD_TYPE ValidationType,
            [In, MarshalAs(UnmanagedType.LPStruct)] object InputArg,
            out NetValidateOutputBufferHandle OutputArg
            );
        #endregion
        #region NetWkstaGetInfo function
        /// <summary>
        /// The <see cref="NetWkstaGetInfo"/> function returns information about the configuration of a workstation.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used.</param>
        /// <param name="level">
        /// Specifies the information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>100</c></term> - <description>Return information about the workstation environment, including platform-specific information, the name of the domain and the local computer, and information concerning the operating system. The <paramref name="bufptr"/> parameter receives a <see cref="WKSTA_INFO_100"/> structure.</description>
        /// <term><c>101</c></term> - <description>In addition to level 100 information, return the path to the LANMAN directory. The <paramref name="bufptr"/> parameter receives a <see cref="WKSTA_INFO_101"/> structure.</description>
        /// <term><c>102</c></term> - <description>In addition to level 101 information, return the number of users who are logged on to the local computer. The <paramref name="bufptr"/> parameter receives a <see cref="WKSTA_INFO_102"/> structure.</description>
        /// </list>
        /// </param>
        /// <param name="bufptr">
        /// <para>A variable for a buffer that receives the information structure. The format of this data depends on the value of the <paramref name="level"/> parameter.</para>
        /// <para>The system allocates the memory for this buffer. The handle should be wrapped in a <c>using</c> block, or the application should otherwise make sure that the <see cref="SafeHandle.Dispose()"/> method is called on the returned handle when it is no longer needed.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_LEVEL"/></term><description>The <paramref name="level"/> parameter is invalid.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para><strong>Windows Server 2003 and Windows XP:</strong> If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the ACL for the securable object. To enable anonymous access, the user Anonymous must be a member of the "Pre-Windows 2000 compatible access" group. This is because anonymous tokens do not include the Everyone group SID by default. If you call this function on a member server or workstation, all authenticated users can view the information. Anonymous access is also permitted if the EveryoneIncludesAnonymous policy setting allows anonymous access. Anonymous access is always permitted for level 100. If you call this function at level 101, authenticated users can view the information. Members of the Administrators, and the Server, System and Print Operator local groups can view information at levels 102 and 502. For more information about restricting anonymous access, see <a href="https://msdn.microsoft.com/en-us/library/aa370891.aspx">Security Requirements for the Network Management Functions</a>. For more information on ACLs, ACEs, and access tokens, see <a href="https://msdn.microsoft.com/en-us/library/aa374876.aspx">Access Control Model</a>.</para>
        /// <para><strong>Windows 2000:</strong> If you call this function on a domain controller that is running Active Directory, access is allowed or denied based on the access control list (ACL) for the securable object. The default ACL permits all authenticated users and members of the " Pre-Windows 2000 compatible access" group to view the information. By default, the "<a href="https://msdn.microsoft.com/en-us/library/aa375347.aspx">Pre-Windows 2000 compatible access</a>" group includes Everyone as a member. This enables anonymous access to the information if the system allows anonymous access. If you call this function on a member server or workstation, all authenticated users can view the information. Anonymous access is also permitted if the RestrictAnonymous policy setting allows anonymous access.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370663.aspx">NetWkstaGetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="NetWkstaSetInfo"/>
        /// <seealso cref="WKSTA_INFO_100"/>
        /// <seealso cref="WKSTA_INFO_101"/>
        /// <seealso cref="WKSTA_INFO_102"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetWkstaGetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            out WkstaInfoNetApiBufferHandle bufptr
            );
        #endregion
        #region NetWkstaSetInfo function
        /// <summary>
        /// The <see cref="NetWkstaSetInfo"/> function configures a workstation with information that remains in effect after the system has been reinitialized.
        /// </summary>
        /// <param name="servername">A string that specifies the DNS or NetBIOS name of the remote server on which the function is to execute. If this parameter is <c>null</c>, the local computer is used. </param>
        /// <param name="level">
        /// The information level of the data. This parameter can be one of the following values. 
        /// <list type="table">
        /// <listheader><term>Value</term> - <description>Meaning</description></listheader>
        /// <term><c>100</c></term> - <description><strong>Windows NT:</strong> Specifies information about a workstation environment, including platform-specific information, the names of the domain and the local computer, and information concerning the operating system. The <paramref name="buffer"/> parameter specifies a <see cref="WKSTA_INFO_100"/> structure. The <see cref="WKSTA_INFO_100.wki100_computername"/> and <see cref="WKSTA_INFO_100.wki100_langroup"/> fields of this structure cannot be set by calling this function. To set these values, call <see cref="SetComputerName"/>/<see cref="SetComputerNameEx"/> or <see cref="NetJoinDomain"/>, respectively.</description>
        /// <term><c>101</c></term> - <description><strong>Windows NT:</strong> In addition to level 100 information, specifies the path to the LANMAN directory. The <paramref name="buffer"/> parameter specifies a <see cref="WKSTA_INFO_101"/> structure. The <see cref="WKSTA_INFO_101.wki101_computername"/> and <see cref="WKSTA_INFO_101.wki101_langroup"/> fields of this structure cannot be set by calling this function. To set these values, call <see cref="SetComputerName"/>/<see cref="SetComputerNameEx"/> or <see cref="NetJoinDomain"/>, respectively.</description>
        /// <term><c>102</c></term> - <description><strong>Windows NT:</strong> The <paramref name="buffer"/> parameter specifies a <see cref="WKSTA_INFO_102"/> structure. The <see cref="WKSTA_INFO_102.wki102_computername"/> and <see cref="WKSTA_INFO_102.wki102_langroup"/> fields of this structure cannot be set by calling this function. To set these values, call <see cref="SetComputerName"/>/<see cref="SetComputerNameEx"/> or <see cref="NetJoinDomain"/>, respectively.</description>
        /// <term><c>502</c></term> - <description><strong>Windows NT:</strong> The <paramref name="buffer"/> parameter specifies a <see cref="WKSTA_INFO_502"/> structure that contains information about the workstation environment..</description>
        /// </list>
        /// Do not set levels 1010-1013, 1018, 1023, 1027, 1028, 1032, 1033, 1035, or 1041-1062.
        /// </param>
        /// <param name="buffer">An object instance that specifies the data. The format of this data depends on the value of the <paramref name="level"/> parameter.</param>
        /// <param name="parm_err">A variable that receives the index of the first member of the workstation information structure that causes the <see cref="ERROR_INVALID_PARAMETER"/> error. If this parameter is omitted, the index is not returned on error.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see cref="NERR_Success"/>.</para>
        /// <para>
        /// If the function fails, the return value can be one of the following error codes.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term><description>The user does not have access to the requested information.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/></term><description>One of the function parameters is invalid. For more information, see the function Remarks section.</description>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Only members of the Administrators group can successfully execute the <see cref="NetWkstaSetInfo"/> function on a remote server.</para>
        /// <para>The <see cref="NetWkstaSetInfo"/> function calls the workstation service on the local system or a remote system. Only a limited number of members of the <see cref="WKSTA_INFO_502"/> structure can actually be changed using the <see cref="NetWkstaSetInfo"/> function. No errors are returned if a member is set that is ignored by the workstation service. The workstation service is primarily configured using settings in the registry. </para>
        /// <para>The <see cref="NetWkstaUserSetInfo"/> function can be used instead of the <see cref="NetWkstaSetInfo"/> function to set configuration information on the local system. The <see cref="NetWkstaUserSetInfo"/> function calls the Local Security Authority (LSA). </para>
        /// <para>If the <see cref="NetWkstaSetInfo"/> function returns <see cref="ERROR_INVALID_PARAMETER"/>, you can use the <paramref name="parm_err"/> parameter to indicate the first member of the workstation information structure that is invalid. (A workstation information structure begins with <strong>WKSTA_INFO_</strong> and its format is specified by the <paramref name="level"/> parameter.) The values that can be returned in the <paramref name="parm_err"/> parameter and the corresponding structure member that is in error is specified by the <see cref="WKSTA_INFO_PARMNUM"/> enumeration type.</para>
        /// <para>The workstation service parameter settings are stored in the registry, not in the LanMan.ini file used prveiously by LAN Manager. The <see cref="NetWkstaSetInfo"/> function does not change the values in the LanMan.ini file. When the workstation service is stopped and restarted, workstation parameters are reset to the default values specified in the registry (unless they are overwritten by command-line parameters). Values set by previous calls to <see cref="NetWkstaSetInfo"/> can be overwritten when workstation parameters are reset.</para>
        /// <para><strong>Minimum supported client</strong>: Windows 2000 Professional [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows 2000 Server [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370664.aspx">NetWkstaSetInfo function</a></para>
        /// </remarks>
        /// <seealso cref="NetWkstaGetInfo"/>
        /// <seealso cref="NetWkstaUserGetInfo"/>
        /// <seealso cref="NetWkstaUserSetInfo"/>
        [DllImport("Netapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern Win32ErrorCode NetWkstaSetInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)] string servername,
            [In] int level,
            [In, MarshalAs(UnmanagedType.LPStruct)] object buffer,
            [Optional] out WKSTA_INFO_PARMNUM parm_err
            );
        #endregion
    }
}
