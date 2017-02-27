using Microsoft.Win32.SafeHandles;
using Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement;
using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using THNETII.InteropServices.NativeMemory;
using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.ACCESS_MASK;
using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.PrivilegeConstants;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;
using static System.Security.Principal.TokenAccessLevels;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// Defines the native Windows API functions that are used with authorization applications.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375742.aspx">Authorization Functions</a></para>
    /// </remarks>
    public static class AuthorizationFunctions
    {
        #region AccessCheck function
        /// <summary>
        /// The <see cref="AccessCheck"/> function determines whether a <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_descriptor_gly">security descriptor</a></em> grants a specified set of access rights to the client identified by an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_token_gly">access token</a></em>. Typically, server applications use this function to check access to a private object.
        /// </summary>
        /// <param name="pSecurityDescriptor">A <see cref="GenericSecurityDescriptor"/> against which access is checked.</param>
        /// <param name="ClientToken">A handle to an <em><a href="https://msdn.microsoft.com/en-us/library/ms721588.aspx#_security_impersonation_token_gly">impersonation token</a></em> that represents the client that is attempting to gain access. The handle must have <see cref="TOKEN_QUERY"/> access to the token; otherwise, the function fails with <see cref="ERROR_ACCESS_DENIED"/>.</param>
        /// <param name="DesiredAccess">
        /// <para><em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">Access mask</a></em> that specifies the access rights to check. This mask must have been mapped by the <see cref="MapGenericMask"/> function to contain no generic access rights. </para>
        /// <para>If this parameter is <see cref="MAXIMUM_ALLOWED"/>, the function sets the <paramref name="GrantedAccess"/> access mask to indicate the maximum access rights the <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_descriptor_gly">security descriptor</a></em> allows the client.</para>
        /// </param>
        /// <param name="GenericMapping">A reference to the <see cref="GENERIC_MAPPING"/> structure associated with the object for which access is being checked.</param>
        /// <param name="PrivilegeSet">A reference to a <see cref="PRIVILEGE_SET"/> structure that receives the privileges used to perform the access validation. If no privileges were used, the function sets the <see cref="PRIVILEGE_SET.PrivilegeCount"/> member to zero.</param>
        /// <param name="PrivilegeSetLength">Specifies the size, in bytes, of the buffer referred to by the <paramref name="PrivilegeSet"/> parameter.</param>
        /// <param name="GrantedAccess">An <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">access mask</a></em> that receives the granted access rights. If <paramref name="AccessStatus"/> is set to <c>false</c>, the function sets the access mask to zero. If the function fails, it does not set the access mask.</param>
        /// <param name="AccessStatus">A variable that receives the results of the access check. If the security descriptor allows the requested access rights to the client identified by the access token, <paramref name="AccessStatus"/> is set to <c>true</c>. Otherwise, <paramref name="AccessStatus"/> is set to <c>false</c>, and you can call <see cref="Marshal.GetLastWin32Error"/> to get extended error information.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>. <br/>
        /// If the function fails, the return value is <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>For more information, see the <a href="https://msdn.microsoft.com/en-us/library/aa446683.aspx">How AccessCheck Works</a> overview.</para>
        /// <para>The <see cref="AccessCheck"/> function compares the specified <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_descriptor_gly">security descriptor</a></em> with the specified access token and indicates, in the <paramref name="AccessStatus"/> parameter, whether access is granted or denied. If access is granted, the requested <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">access mask</a></em> becomes the object's granted access mask.</para>
        /// <para>If the security descriptor's DACL is <c>null</c>, the <paramref name="AccessStatus"/> parameter returns <c>true</c>, which indicates that the client has the requested access.</para>
        /// <para>The <see cref="AccessCheck"/> function fails with <see cref="ERROR_INVALID_SECURITY_DESCR"/> if the security descriptor does not contain owner and group SIDs.</para>
        /// <para>The <see cref="AccessCheck"/> function does not generate an audit. If your application requires audits for access checks, use functions such as <see cref="AccessCheckAndAuditAlarm"/>, <see cref="AccessCheckByTypeAndAuditAlarm"/>, <see cref="AccessCheckByTypeResultListAndAuditAlarm"/>, or <see cref="AccessCheckByTypeResultListAndAuditAlarmByHandle"/>, instead of <see cref="AccessCheck"/>.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa374815.aspx">AccessCheck function</a></para>
        /// </remarks>
        /// <seealso cref="AccessCheckAndAuditAlarm"/>
        /// <seealso cref="AreAllAccessesGranted"/>
        /// <seealso cref="AreAnyAccessesGranted"/>
        /// <seealso cref="GENERIC_MAPPING"/>
        /// <seealso cref="MakeAbsoluteSD"/>
        /// <seealso cref="MapGenericMask"/>
        /// <seealso cref="PRIVILEGE_SET"/>
        /// <seealso cref="PrivilegeCheck"/>
        /// <seealso cref="GenericSecurityDescriptor"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheck(
            [In] GenericSecurityDescriptor pSecurityDescriptor,
            [In] SafeAccessTokenHandle ClientToken,
            [In, MarshalAs(UnmanagedType.I4)] ACCESS_MASK DesiredAccess,
            [In, MarshalAs(UnmanagedType.LPStruct)] GENERIC_MAPPING GenericMapping,
            PrivilegeSetSafeHandle PrivilegeSet,
            ref int PrivilegeSetLength,
            out ACCESS_MASK GrantedAccess,
            out bool AccessStatus
            );
        #endregion
        #region AccessCheckAndAuditAlarm function
        /// <summary>
        /// <para>The <see cref="AccessCheckAndAuditAlarm"/> function determines whether a <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_descriptor_gly">security descriptor</a></em> grants a specified set of access rights to the client being impersonated by the calling thread. If the security descriptor has a SACL with ACEs that apply to the client, the function generates any necessary audit messages in the security event log.</para>
        /// <para>Alarms are not currently supported.</para>
        /// </summary>
        /// <param name="SubsystemName">A string specifying the name of the subsystem calling the function. This string appears in any audit message that the function generates.</param>
        /// <param name="HandleId">A pointer to a unique value representing the client's handle to the object. If the access is denied, the system ignores this value.</param>
        /// <param name="ObjectTypeName">A string specifying the type of object being created or accessed. This string appears in any audit message that the function generates.</param>
        /// <param name="ObjectName">A string specifying the name of the object being created or accessed. This string appears in any audit message that the function generates.</param>
        /// <param name="SecurityDescriptor">A reference to the <see cref="GenericSecurityDescriptor"/> structure against which access is checked.</param>
        /// <param name="DesiredAccess">
        /// <para><em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">Access mask</a></em> that specifies the access rights to check. This mask must have been mapped by the <see cref="MapGenericMask"/> function to contain no generic access rights. </para>
        /// <para>If this parameter is <see cref="MAXIMUM_ALLOWED"/>, the function sets the <paramref name="GrantedAccess"/> access mask to indicate the maximum access rights the <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_descriptor_gly">security descriptor</a></em> allows the client.</para>
        /// </param>
        /// <param name="GenericMapping">A reference to the <see cref="GENERIC_MAPPING"/> structure associated with the object for which access is being checked.</param>
        /// <param name="ObjectCreation">Specifies a flag that determines whether the calling application will create a new object when access is granted. A value of <c>true</c> indicates the application will create a new object. A value of <c>false</c> indicates the application will open an existing object.</param>
        /// <param name="GrantedAccess">An <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">access mask</a></em> that receives the granted access rights. If <paramref name="AccessStatus"/> is set to <c>false</c>, the function sets the access mask to zero. If the function fails, it does not set the access mask.</param>
        /// <param name="AccessStatus">A variable that receives the results of the access check. If the security descriptor allows the requested access rights to the client identified by the access token, <paramref name="AccessStatus"/> is set to <c>true</c>. Otherwise, <paramref name="AccessStatus"/> is set to <c>false</c>, and you can call <see cref="Marshal.GetLastWin32Error"/> to get extended error information.</param>
        /// <param name="pfGenerateOnClose">A flag set by the audit-generation routine when the function returns. Pass this flag to the <see cref="ObjectCloseAuditAlarm"/> function when the object handle is closed.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>. <br/>
        /// If the function fails, the return value is <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>For more information, see the <a href="https://msdn.microsoft.com/en-us/library/aa446683.aspx">How AccessCheck Works</a> overview.</para>
        /// <para>The <see cref="AccessCheckAndAuditAlarm"/> function requires the calling <em><a href="https://msdn.microsoft.com/en-us/library/ms721603.aspx#_security_process_gly">process</a></em> to have the <see cref="SE_AUDIT_NAME"/> privilege enabled. The test for this privilege is performed against the <em><a href="https://msdn.microsoft.com/en-us/library/ms721603.aspx#_security_primary_token_gly">primary token</a></em> of the calling process, not the <em><a href="https://msdn.microsoft.com/en-us/library/ms721588.aspx#_security_impersonation_token_gly">impersonation token</a></em> of the thread.</para>
        /// <para>The <see cref="AccessCheckAndAuditAlarm"/> function fails if the calling thread is not impersonating a client.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa374823.aspx">AccessCheckAndAuditAlarm function</a></para>
        /// </remarks>
        /// <seealso cref="AccessCheck"/>
        /// <seealso cref="GENERIC_MAPPING"/>
        /// <seealso cref="MakeAbsoluteSD"/>
        /// <seealso cref="MapGenericMask"/>
        /// <seealso cref="ObjectCloseAuditAlarm"/>
        /// <seealso cref="ObjectOpenAuditAlarm"/>
        /// <seealso cref="ObjectPrivilegeAuditAlarm"/>
        /// <seealso cref="PrivilegeCheck"/>
        /// <seealso cref="PrivilegedServiceAuditAlarm"/>
        /// <seealso cref="GenericSecurityDescriptor"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckAndAuditAlarm(
            [In, MarshalAs(UnmanagedType.LPTStr)] string SubsystemName,
            [In, Optional] IntPtr HandleId,
            [In, MarshalAs(UnmanagedType.LPTStr)] string ObjectTypeName,
            [In, Optional, MarshalAs(UnmanagedType.LPTStr)] string ObjectName,
            [In] GenericSecurityDescriptor SecurityDescriptor,
            [In, MarshalAs(UnmanagedType.I4)] ACCESS_MASK DesiredAccess,
            [In, MarshalAs(UnmanagedType.LPStruct)] GENERIC_MAPPING GenericMapping,
            [In, MarshalAs(UnmanagedType.Bool)] bool ObjectCreation,
            out ACCESS_MASK GrantedAccess,
            out bool AccessStatus,
            out bool pfGenerateOnClose
            );
        #endregion
        #region AdjustTokenGroups function
        /// <summary>
        /// The <see cref="AdjustTokenGroups"/> function enables or disables groups already present in the specified access token. Access to <see cref="AdjustGroups"/> is required to enable or disable groups in an access token.
        /// </summary>
        /// <param name="TokenHandle">A handle to the access token that contains the groups to be enabled or disabled. The handle must have <see cref="AdjustGroups"/> access to the token. If the <paramref name="PreviousState"/> parameter is not <c>null</c>, the handle must also have <see cref="Query"/> access.</param>
        /// <param name="ResetToDefault">Boolean value that indicates whether the groups are to be set to their default enabled and disabled states. If this value is <c>true</c>, the groups are set to their default states and the <paramref name="NewState"/> parameter is ignored. If this value is <c>false</c>, the groups are set according to the information pointed to by the <paramref name="NewState"/> parameter.</param>
        /// <param name="NewState">A safe memory buffer containing a <see cref="TOKEN_GROUPS"/> structure that contains the groups to be enabled or disabled. If the <paramref name="ResetToDefault"/> parameter is <c>false</c>, the function sets each of the groups to the value of that group's <see cref="SE_GROUP_ATTRIBUTES.SE_GROUP_ENABLED"/> attribute in the <see cref="TOKEN_GROUPS"/> structure. If <paramref name="ResetToDefault"/> is <c>true</c>, this parameter is ignored.</param>
        /// <param name="BufferLength">The size, in bytes, of the buffer pointed to by the <paramref name="PreviousState"/> parameter. This parameter can be zero if the <paramref name="PreviousState"/> parameter is <c>null</c> or omitted.</param>
        /// <param name="PreviousState">
        /// <para>A safe memory buffer that receives a <see cref="TOKEN_GROUPS"/> structure containing the previous state of any groups the function modifies. That is, if a group has been modified by this function, the group and its previous state are contained in the <see cref="TOKEN_GROUPS"/> structure referenced by <paramref name="PreviousState"/>. If the <see cref="TOKEN_GROUPS.GroupCount"/> member of <see cref="TOKEN_GROUPS"/> is zero, then no groups have been changed by this function. This parameter can be <c>null</c> or omitted. </para>
        /// <para>If a buffer is specified but it does not contain enough space to receive the complete list of modified groups, no group states are changed and the function fails. In this case, the function sets the <paramref name="ReturnLength"/> parameter to the number of bytes required to hold the complete list of modified groups.</para>
        /// </param>
        /// <param name="ReturnLength">A variable that receives the actual number of bytes needed for the buffer pointed to by the <paramref name="PreviousState"/> parameter. This parameter can be omitted and is ignored if <paramref name="PreviousState"/> is <c>null</c>.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>. <br/>
        /// If the function fails, the return value is <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The information retrieved in the <paramref name="PreviousState"/> parameter is formatted as a <see cref="TOKEN_GROUPS"/> structure. This means a the buffer can be passed as the <paramref name="NewState"/> parameter in a subsequent call to the <see cref="AdjustTokenGroups"/> function, restoring the original state of the groups.</para>
        /// <para>The <paramref name="NewState"/> parameter can list groups to be changed that are not present in the access token. This does not affect the successful modification of the groups in the token.</para>
        /// <para>The <see cref="AdjustTokenGroups"/> function cannot disable groups with the <see cref="SE_GROUP_ATTRIBUTES.SE_GROUP_MANDATORY"/> attribute in the <see cref="TOKEN_GROUPS"/> structure. Use <see cref="CreateRestrictedToken"/> instead.</para>
        /// <para>You cannot enable a group that has the <see cref="SE_GROUP_ATTRIBUTES.SE_GROUP_USE_FOR_DENY_ONLY"/> attribute.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375199.aspx">AdjustTokenGroups function</a></para>
        /// </remarks>
        /// <seealso cref="AdjustTokenPrivileges"/>
        /// <seealso cref="CreateRestrictedToken"/>
        /// <seealso cref="GetTokenInformation"/>
        /// <seealso cref="SetTokenInformation"/>
        /// <seealso cref="TOKEN_GROUPS"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustTokenGroups(
            [In] SafeAccessTokenHandle TokenHandle,
            [In, MarshalAs(UnmanagedType.Bool)] bool ResetToDefault,
            [In, Optional] TokenGroupsSafeHandle NewState,
            [In] int BufferLength,
            [Out, Optional] TokenGroupsSafeHandle PreviousState,
            [Optional] out int ReturnLength
            );
        #endregion
        #region AdjustTokenPrivileges function
        /// <summary>
        /// The <see cref="AdjustTokenPrivileges"/> function enables or disables privileges in the specified access token. Enabling or disabling privileges in an access token requires <see cref="AdjustPrivileges"/> access.
        /// </summary>
        /// <param name="TokenHandle">A handle to the access token that contains the privileges to be modified. The handle must have <see cref="AdjustPrivileges"/> access to the token. If the <paramref name="PreviousState"/> parameter is not <c>null</c>, the handle must also have <see cref="Query"/> access.</param>
        /// <param name="DisableAllPrivileges">Specifies whether the function disables all of the token's privileges. If this value is <c>true</c>, the function disables all privileges and ignores the <paramref name="NewState"/> parameter. If it is <c>false</c>, the function modifies privileges based on the information pointed to by the <paramref name="NewState"/> parameter.</param>
        /// <param name="NewState">
        /// <para>A safe memory buffer to a <see cref="TOKEN_PRIVILEGES"/> structure that specifies an array of privileges and their attributes. If the <paramref name="DisableAllPrivileges"/> parameter is <c>false</c>, the <see cref="AdjustTokenPrivileges"/> function enables, disables, or removes these privileges for the token. The action taken by the <see cref="AdjustTokenPrivileges"/> function is based on the privilege attribute.</para>
        /// <para>If <paramref name="DisableAllPrivileges"/> is <c>true</c>, the function ignores this parameter.</para>
        /// </param>
        /// <param name="BufferLength">Specifies the size, in bytes, of the buffer pointed to by the <paramref name="PreviousState"/> parameter. This parameter can be zero if the <paramref name="PreviousState"/> parameter is <c>null</c> or omitted.</param>
        /// <param name="PreviousState">
        /// <para>A safe memory buffer that the function fills with a <see cref="TOKEN_PRIVILEGES"/> structure that contains the previous state of any privileges that the function modifies. That is, if a privilege has been modified by this function, the privilege and its previous state are contained in the <see cref="TOKEN_PRIVILEGES"/> structure referenced by <paramref name="PreviousState"/>. If the <see cref="TOKEN_PRIVILEGES.PrivilegeCount"/> member of <see cref="TOKEN_PRIVILEGES"/> is zero, then no privileges have been changed by this function. This parameter can be <c>null</c> or omitted. </para>
        /// <para>If you specify a buffer that is too small to receive the complete list of modified privileges, the function fails and does not adjust any privileges. In this case, the function sets the variable pointed to by the <paramref name="ReturnLength"/> parameter to the number of bytes required to hold the complete list of modified privileges.</para>
        /// </param>
        /// <param name="ReturnLength">A variable that receives the required size, in bytes, of the buffer pointed to by the <paramref name="PreviousState"/> parameter. This parameter can be omitted if <paramref name="PreviousState"/> is <c>null</c>.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>. To determine whether the function adjusted all of the specified privileges, call <see cref="Marshal.GetLastWin32Error"/>, which returns one of the following values when the function succeeds:
        /// <list type="table">
        /// <listheader><term>Return code</term> <description>Description</description></listheader>
        /// <term><see cref="ERROR_SUCCESS"/></term> <description>The function adjusted all specified privileges.</description>
        /// <term><see cref="ERROR_NOT_ALL_ASSIGNED"/></term> <description>The token does not have one or more of the privileges specified in the <paramref name="NewState"/> parameter. The function may succeed with this error value even if no privileges were adjusted. The <paramref name="PreviousState"/> parameter indicates the privileges that were adjusted.</description>
        /// </list>
        /// If the function fails, the return value is <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="AdjustTokenPrivileges"/> function cannot add new privileges to the access token. It can only enable or disable the token's existing privileges. To determine the token's privileges, call the <see cref="GetTokenInformation"/> function.</para>
        /// <para>The <paramref name="NewState"/> parameter can specify privileges that the token does not have, without causing the function to fail. In this case, the function adjusts the privileges that the token does have and ignores the other privileges so that the function succeeds. Call the <see cref="Marshal.GetLastWin32Error"/> function to determine whether the function adjusted all of the specified privileges. The <paramref name="PreviousState"/> parameter indicates the privileges that were adjusted.</para>
        /// <para>The <paramref name="PreviousState"/> parameter retrieves a <see cref="TOKEN_PRIVILEGES"/> structure that contains the original state of the adjusted privileges. To restore the original state, pass the <paramref name="PreviousState"/> pointer as the <paramref name="NewState"/> parameter in a subsequent call to the <see cref="AdjustTokenPrivileges"/> function.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375202.aspx">AdjustTokenPrivileges function</a></para>
        /// </remarks>
        /// <seealso cref="AdjustTokenGroups"/>
        /// <seealso cref="GetTokenInformation"/>
        /// <seealso cref="SetTokenInformation"/>
        /// <seealso cref="TOKEN_PRIVILEGES"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustTokenPrivileges(
            [In] SafeAccessTokenHandle TokenHandle,
            [In, MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges,
            [In, Optional] TokenPrivilegesSafeHandle NewState,
            [In] int BufferLength,
            [Out, Optional] TokenPrivilegesSafeHandle PreviousState,
            [Optional] out int ReturnLength
            );
        #endregion
        #region AllocateLocallyUniqueId function
        /// <summary>
        /// The <see cref="AllocateLocallyUniqueId"/> function allocates a locally unique identifier (<em><a href="https://msdn.microsoft.com/en-us/library/ms721592.aspx#_security_locally_unique_identifier_gly">LUID</a></em>).
        /// </summary>
        /// <param name="Luid">A variable that receives the allocated LUID.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>. <br/>
        /// If the function fails, the return value is <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The allocated LUID is unique to the local system only, and uniqueness is guaranteed only until the system is next restarted.</para>
        /// <para>The allocated LUID is guaranteed to be nonzero if this function succeeds.</para>
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375260.aspx">AllocateLocallyUniqueId function</a></para>
        /// </remarks>
        /// <seealso cref="LookupPrivilegeValue"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocateLocallyUniqueId(
            out ulong Luid
            );
        #endregion
        #region AreAllAccessesGranted function
        /// <summary>
        /// The <see cref="AreAllAccessesGranted"/> function checks whether a set of requested access rights has been granted. The access rights are represented as bit flags in an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">access mask</a></em>.
        /// </summary>
        /// <param name="GrantedAccess">An access mask that specifies the access rights that have been granted.</param>
        /// <param name="DesiredAccess">An access mask that specifies the access rights that have been requested. This mask must have been mapped from generic to specific and standard access rights, usually by calling the <see cref="MapGenericMask"/> function.</param>
        /// <returns>
        /// If all requested access rights have been granted, the return value is <c>true</c>.<br/>
        /// If not all requested access rights have been granted, the return value is <c>false</c>.
        /// </returns>
        /// <remarks>
        /// The <see cref="AreAllAccessesGranted"/> function is commonly used by a server application to check the access rights of a client attempting to gain access to an object. When the bits set in the DesiredAccess parameter match the bits set in the GrantedAccess parameter, all requested rights have been granted.
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375351.aspx">AreAllAccessesGranted function</a></para>
        /// </remarks>
        /// <seealso cref="AccessCheck"/>
        /// <seealso cref="AreAnyAccessesGranted"/>
        /// <seealso cref="MapGenericMask"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AreAllAccessesGranted(
            [In, MarshalAs(UnmanagedType.I4)] ACCESS_MASK GrantedAccess,
            [In, MarshalAs(UnmanagedType.I4)] ACCESS_MASK DesiredAccess
            );
        #endregion
        #region AreAnyAccessesGranted function
        /// <summary>
        /// The <see cref="AreAnyAccessesGranted"/> function checks whether any set of requested access rights has been granted. The access rights are represented as bit flags in an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">access mask</a></em>.
        /// </summary>
        /// <param name="GrantedAccess">An access mask that specifies the access rights that have been granted.</param>
        /// <param name="DesiredAccess">An access mask that specifies the access rights that have been requested. This mask must have been mapped from generic to specific and standard access rights, usually by calling the <see cref="MapGenericMask"/> function.</param>
        /// <returns>
        /// If all requested access rights have been granted, the return value is <c>true</c>.<br/>
        /// If not all requested access rights have been granted, the return value is <c>false</c>.
        /// </returns>
        /// <remarks>
        /// The <see cref="AreAnyAccessesGranted"/> function is often used by a server application to check the access rights of a client attempting to gain access to an object. When any of the bits set in the <paramref name="DesiredAccess"/> parameter match the bits set in the <paramref name="GrantedAccess"/> parameter, at least one of the requested access rights has been granted.
        /// <para><strong>Minimum supported client</strong>: Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375363.aspx">AreAnyAccessesGranted function</a></para>
        /// </remarks>
        /// <seealso cref="AccessCheck"/>
        /// <seealso cref="AreAllAccessesGranted"/>
        /// <seealso cref="MapGenericMask"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AreAnyAccessesGranted(
            [In, MarshalAs(UnmanagedType.I4)] ACCESS_MASK GrantedAccess,
            [In, MarshalAs(UnmanagedType.I4)] ACCESS_MASK DesiredAccess
            );
        #endregion
        #region AuditComputeEffectivePolicyBySid function
        /// <summary>
        /// The <see cref="AuditComputeEffectivePolicyBySid"/> function computes the effective audit policy for one or more subcategories for the specified security principal. The function computes effective audit policy by combining system audit policy with per-user policy.
        /// </summary>
        /// <param name="pSid">A <see cref="SecurityIdentifier"/> (SID) associated with the principal for which to compute effective audit policy. Per-user policy for group SIDs is not currently supported.</param>
        /// <param name="pSubCategoryGuids">An array of <see cref="Guid"/> values that specify the subcategories for which to compute effective audit policy. For a list of defined subcategories, see <see cref="AuditingConstants"/>.</param>
        /// <param name="PolicyCount">The number of elements in each of the <paramref name="pSubCategoryGuids"/> and <paramref name="ppAuditPolicy"/> arrays.</param>
        /// <param name="ppAuditPolicy">
        /// <para>A variable that receives a single array buffer containing references to <see cref="AUDIT_POLICY_INFORMATION"/> structures and the structures themselves. The <see cref="AUDIT_POLICY_INFORMATION"/> structures specify the effective audit policy for the subcategories specified by the <paramref name="pSubCategoryGuids"/> array. </para>
        /// <para>Access to the contents of the received buffer should be wrapped in a using statement, to ensure the memory is freed after you are done processing the buffer.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, it returns <c>true</c>.<br/>
        /// If the function fails, it returns <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>. <see cref="Marshal.GetLastWin32Error"/> may return one of the following error codes:
        /// <list type="table">
        /// <listheader><term>Return code/value</term> <description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/> <br/> <c></c></term> <description>The caller does not have the privilege or access rights necessary to call this function.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/> <br/> <c>87</c> (<c>0x57</c>)</term> <description>One or more parameters are not valid.</description>
        /// <term><see cref="ERROR_FILE_NOT_FOUND"/> <br/> <c>2</c> (<c>0x2</c>)</term> <description>No per-user audit policy exist for the principal specified by the <paramref name="pSid"/> parameter.</description>
        /// </list>
        /// </returns>
        /// <remarks>
        /// To successfully call this function, the caller must have <c>"SeSecurityPrivilege"</c> or have <see cref="AUDIT_QUERY_SYSTEM_POLICY"/> and <see cref="AUDIT_QUERY_USER_POLICY"/> access on the <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_audit_security_object_gly">Audit security object</a></em>.
        /// <para><strong>Minimum supported client</strong>: Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375366.aspx">AuditComputeEffectivePolicyBySid function</a></para>
        /// </remarks>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool AuditComputeEffectivePolicyBySid(
            [In, MarshalAs(44, MarshalTypeRef = typeof(SecurityIdentifierCoTaskMemCustomMarshaler))] SecurityIdentifier pSid, // MarshalAs(44) <=> MarshalAs(UnmanagedType.CustomMarshaler)
            [In, MarshalAs(UnmanagedType.LPArray)] Guid[] pSubCategoryGuids,
            [In] int PolicyCount,
            out ReferenceArrayAuditSafeHandle<AUDIT_POLICY_INFORMATION> ppAuditPolicy
            );
        #endregion
        #region AuditComputeEffectivePolicyByToken function
        /// <summary>
        /// The <see cref="AuditComputeEffectivePolicyByToken"/> function computes the effective audit policy for one or more subcategories for the security principal associated with the specified token. The function computes effective audit policy by combining system audit policy with per-user policy. 
        /// </summary>
        /// <param name="hTokenHandle">A handle to the access token associated with the principal for which to compute effective audit policy. The token must have been opened with <see cref="Query"/> access. Per-user policy for group SIDs is not currently supported.</param>
        /// <param name="pSubCategoryGuids">An array of <see cref="Guid"/> values that specify the subcategories for which to compute effective audit policy. For a list of defined subcategories, see <see cref="AuditingConstants"/>.</param>
        /// <param name="PolicyCount">The number of elements in each of the <paramref name="pSubCategoryGuids"/> and <paramref name="ppAuditPolicy"/> arrays.</param>
        /// <param name="ppAuditPolicy">
        /// <para>A variable that receives a single array buffer containing references to <see cref="AUDIT_POLICY_INFORMATION"/> structures and the structures themselves. The <see cref="AUDIT_POLICY_INFORMATION"/> structures specify the effective audit policy for the subcategories specified by the <paramref name="pSubCategoryGuids"/> array. </para>
        /// <para>Access to the contents of the received buffer should be wrapped in a using statement, to ensure the memory is freed after you are done processing the buffer.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, it returns <c>true</c>.<br/>
        /// If the function fails, it returns <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>. <see cref="Marshal.GetLastWin32Error"/> may return one of the following error codes:
        /// <list type="table">
        /// <listheader><term>Return code/value</term> <description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/> <br/> <c></c></term> <description>The caller does not have the privilege or access rights necessary to call this function.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/> <br/> <c>87</c> (<c>0x57</c>)</term> <description>One or more parameters are not valid.</description>
        /// <term><see cref="ERROR_FILE_NOT_FOUND"/> <br/> <c>2</c> (<c>0x2</c>)</term> <description>No per-user audit policy exist for the principal specified by the <paramref name="pSid"/> parameter.</description>
        /// </list>
        /// </returns>
        /// <remarks>
        /// To successfully call this function, the caller must have <c>"SeSecurityPrivilege"</c> or have <see cref="AUDIT_QUERY_SYSTEM_POLICY"/> and <see cref="AUDIT_QUERY_USER_POLICY"/> access on the <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_audit_security_object_gly">Audit security object</a></em>.
        /// <para><strong>Minimum supported client</strong>: Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375633.aspx">AuditComputeEffectivePolicyByToken function</a></para>
        /// </remarks>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool AuditComputeEffectivePolicyByToken(
            [In] SafeAccessTokenHandle hTokenHandle,
            [In, MarshalAs(UnmanagedType.LPArray)] Guid[] pSubCategoryGuids,
            [In] int PolicyCount,
            out ReferenceArrayAuditSafeHandle<AUDIT_POLICY_INFORMATION> ppAuditPolicy
            );
        #endregion
        #region AuditEnumerateCategories function
        /// <summary>
        /// The <see cref="AuditEnumerateCategories"/> function enumerates the available audit-policy categories. 
        /// </summary>
        /// <param name="ppAuditCategoriesArray">
        /// <para>A variable that receives a single buffer that contains both an array of references to <see cref="Guid"/> structures and the structures themselves. The <see cref="GUID"/> structures specify the audit-policy categories available on the computer. </para>
        /// <para>Access to the contents of the received buffer should be wrapped in a using statement, to ensure the memory is freed after you are done processing the buffer.</para>
        /// </param>
        /// <param name="pCountReturned">A variable that receives the number of elements in the <paramref name="ppAuditCategoriesArray"/> array.</param>
        /// <returns>
        /// If the function succeeds, it returns <c>true</c>.<br/>
        /// If the function fails, it returns <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para><strong>Minimum supported client</strong>: Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375636.aspx">AuditEnumerateCategories function</a></para>
        /// </remarks>
        /// <seealso cref="AuditEnumerateSubCategories"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool AuditEnumerateCategories(
            out GuidArrayAuditSafeHandle ppAuditCategoriesArray,
            out int pCountReturned
            );
        #endregion
        #region AuditEnumeratePerUserPolicy function
        /// <summary>
        /// The <see cref="AuditEnumeratePerUserPolicy"/> function enumerates users for whom per-user auditing policy is specified. 
        /// </summary>
        /// <param name="ppAuditCategoriesArray">
        /// <para>A variable that receives a single buffer that contains a <see cref="POLICY_AUDIT_SID_ARRAY"/> structure and the included <see cref="SecurityIdentifier"/> instances. The <see cref="POLICY_AUDIT_SID_ARRAY"/> structure specifies the users for whom per-user audit policy is specified. </para>
        /// <para>Access to the contents of the received buffer should be wrapped in a using statement, to ensure the memory is freed after you are done processing the buffer.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, it returns <c>true</c>.<br/>
        /// If the function fails, it returns <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>. <see cref="Marshal.GetLastWin32Error"/> may return one of the following error codes:
        /// <list type="table">
        /// <listheader><term>Return code/value</term> <description>Description</description></listheader>
        /// <term><see cref="ERROR_ACCESS_DENIED"/> <br/> <c></c></term> <description>The caller does not have the privilege or access rights necessary to call this function.</description>
        /// <term><see cref="ERROR_INVALID_PARAMETER"/> <br/> <c>87</c></term> <description>One or more parameters are not valid.</description>
        /// </list>
        /// </returns>
        /// <remarks>
        /// To successfully call this function, the caller must have <c>"SeSecurityPrivilege"</c> or have <see cref="AUDIT_ENUMERATE_USERS"/> access on the <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_audit_security_object_gly">Audit security object</a></em>.
        /// <para><strong>Minimum supported client</strong>: Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375641.aspx">AuditEnumeratePerUserPolicy function</a></para>
        /// </remarks>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool AuditEnumeratePerUserPolicy(
            out PolicyAuditSidArrayAuditSafeHandle ppAuditCategoriesArray
            );
        #endregion
        #region AuditEnumerateSubCategories function
        /// <summary>
        /// The <see cref="AuditEnumerateSubCategories"/> function enumerates the available audit-policy subcategories. 
        /// </summary>
        /// <param name="pAuditCategoryGuid">The <see cref="Guid"/> of an audit-policy category for which subcategories are enumerated. If the value of the <paramref name="bRetrieveAllSubCategories"/> parameter is <c>true</c>, this parameter is ignored.</param>
        /// <param name="bRetrieveAllSubCategories"><c>true</c> to enumerate all audit-policy subcategories; <c>false</c> to enumerate only the subcategories of the audit-policy category specified by the <paramref name="pAuditCategoryGuid"/> parameter.</param>
        /// <param name="ppAuditSubCategoriesArray">
        /// <para>A variable that receives a single buffer that contains an array of references to <see cref="Guid"/> structures and the structures themselves. The <see cref="Guid"/> structures specify the audit-policy subcategories available on the computer. </para>
        /// <para>Access to the contents of the received buffer should be wrapped in a using statement, to ensure the memory is freed after you are done processing the buffer.</para>
        /// </param>
        /// <param name="pCountReturned">A variable that receives the number of audit-policy subcategories returned in the <paramref name="ppAuditSubCategoriesArray"/> array.</param>
        /// <returns>
        /// If the function succeeds, it returns <c>true</c>.<br/>
        /// If the function fails, it returns <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para><strong>Minimum supported client</strong>: Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375648.aspx">AuditEnumerateSubCategories function</a></para>
        /// </remarks>
        /// <seealso cref="AuditEnumerateCategories"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool AuditEnumerateSubCategories(
            [In] ref Guid pAuditCategoryGuid, // MarshalAs(44) <=> MarshalAs(UnmanagedType.CustomMarshaler)
            [In, MarshalAs(UnmanagedType.U1)] bool bRetrieveAllSubCategories,
            out GuidArrayAuditSafeHandle ppAuditSubCategoriesArray,
            out int pCountReturned
            );
        #endregion
        #region AuditFree function
        /// <summary>
        /// The AuditFree function frees the memory allocated by audit functions for the specified buffer. 
        /// </summary>
        /// <param name="Buffer">A pointer to the buffer to free.</param>
        /// <remarks>
        /// <para><strong>Minimum supported client</strong>: Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375654.aspx">AuditFree function</a></para>
        /// </remarks>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern void AuditFree(
            [In] IntPtr Buffer
            );
        #endregion
        #region AuditLookupCategoryGuidFromCategoryId function
        /// <summary>
        /// The <see cref="AuditLookupCategoryGuidFromCategoryId"/> function retrieves a <see cref="Guid"/> structure that represents the specified audit-policy category. 
        /// </summary>
        /// <param name="AuditCategoryId">An element of the <see cref="POLICY_AUDIT_EVENT_TYPE"/> enumeration that specifies an audit-policy category.</param>
        /// <param name="pAuditCategoryGuid">A <see cref="Guid"/> variable that receives the audit-policy category specified by the <paramref name="AuditCategoryId"/>.</param>
        /// <returns>
        /// If the function succeeds, it returns <c>true</c>.<br/>
        /// If the function fails, it returns <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para><strong>Minimum supported client</strong>: Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375669.aspx">AuditLookupCategoryGuidFromCategoryId function</a></para>
        /// </remarks>
        /// <seealso cref="AuditLookupCategoryIdFromCategoryGuid"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool AuditLookupCategoryGuidFromCategoryId(
            [In] POLICY_AUDIT_EVENT_TYPE AuditCategoryId,
            out Guid pAuditCategoryGuid
            );
        #endregion
        #region AuditLookupCategoryIdFromCategoryGuid function
        /// <summary>
        /// The <see cref="AuditLookupCategoryIdFromCategoryGuid"/> function retrieves an element of the <see cref="POLICY_AUDIT_EVENT_TYPE"/> enumeration that represents the specified audit-policy category. 
        /// </summary>
        /// <param name="pAuditCategoryGuid">A reference to a <see cref="Guid"/> structure that specifies an audit-policy category.</param>
        /// <param name="pAuditCategoryId">A variable that receives an element of the <see cref="POLICY_AUDIT_EVENT_TYPE"/> enumeration that represents the audit-policy category specified by the <paramref name="pAuditCategoryGuid"/> parameter.</param>
        /// <returns>
        /// If the function succeeds, it returns <c>true</c>.<br/>
        /// If the function fails, it returns <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para><strong>Minimum supported client</strong>: Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375678.aspx">AuditLookupCategoryIdFromCategoryGuid function</a></para>
        /// </remarks>
        /// <seealso cref="AuditLookupCategoryGuidFromCategoryId"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool AuditLookupCategoryIdFromCategoryGuid(
            [In] ref Guid pAuditCategoryGuid,
            out POLICY_AUDIT_EVENT_TYPE pAuditCategoryId
            );
        #endregion
        #region AuditLookupCategoryName function
        /// <summary>
        /// The <see cref="AuditLookupCategoryName"/> function retrieves the display name of the specified audit-policy category. 
        /// </summary>
        /// <param name="pAuditCategoryGuid">A reference to a <see cref="Guid"/> structure that specifies an audit-policy category.</param>
        /// <param name="ppszCategoryName">
        /// <para>A variable to a buffer that receives a null-terminated string  that contains the display name of the audit-policy category specified by the <paramref name="pAuditCategoryGuid"/> parameter.</para>
        /// <para>Access to the contents of the received buffer should be wrapped in a using statement, to ensure the memory is freed after you are done processing the buffer.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, it returns <c>true</c>.<br/>
        /// If the function fails, it returns <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para><strong>Minimum supported client</strong>: Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375687.aspx">AuditLookupCategoryName function</a></para>
        /// </remarks>
        /// <seealso cref="AuditLookupSubCategoryName"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool AuditLookupCategoryName(
            [In] ref Guid pAuditCategoryGuid,
            out WideStringAuditSafeHandle ppszCategoryName
            );
        #endregion
        #region AuditLookupSubCategoryName function
        /// <summary>
        /// The <see cref="AuditLookupSubCategoryName"/> function retrieves the display name of the specified audit-policy subcategory. 
        /// </summary>
        /// <param name="pAuditSubCategoryGuid">A reference to a <see cref="Guid"/> structure that specifies an audit-policy subcategory.</param>
        /// <param name="ppszSubCategoryName">
        /// <para>A variable to a buffer that receives a null-terminated string that contains the display name of the audit-policy subcategory specified by the <paramref name="pAuditSubCategoryGuid"/> parameter.</para>
        /// <para>Access to the contents of the received buffer should be wrapped in a using statement, to ensure the memory is freed after you are done processing the buffer.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, it returns <c>true</c>.<br/>
        /// If the function fails, it returns <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para><strong>Minimum supported client</strong>: Windows Vista [desktop apps only]</para>
        /// <para><strong>Minimum supported server</strong>: Windows Server 2008 [desktop apps only]</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375693.aspx">AuditLookupSubCategoryName function</a></para>
        /// </remarks>
        /// <seealso cref="AuditLookupCategoryName"/>
        [DllImport("Advapi32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool AuditLookupSubCategoryName(
            [In] ref Guid pAuditSubCategoryGuid,
            out WideStringAuditSafeHandle ppszSubCategoryName
            );
        #endregion
        #region AuthzAccessCheckCallback callback function
        /// <summary>
        /// The <see cref="AuthzAccessCheckCallback"/> function is an application-defined function that handles callback <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entries</a></em> (ACEs) during an access check. <see cref="AuthzAccessCheckCallback"/> is a placeholder for the application-defined function name. The application registers this callback by calling <see cref="AuthzInitializeResourceManager"/>. 
        /// </summary>
        /// <param name="hAuthzClientContext">A handle to a client context.</param>
        /// <param name="pAce">A reference to a <see cref="GenericAce"/> to evaluate for inclusion in the call to the <see cref="AuthzAccessCheck"/> function.</param>
        /// <param name="pArgs">Data passed in the <em>DynamicGroupArgs</em> parameter of the call to <see cref="AuthzAccessCheck"/> or <see cref="AuthzCachedAccessCheck"/>.</param>
        /// <param name="pbAceApplicable">
        /// <para>A Boolean reference variable that receives the results of the evaluation of the logic defined by the application.</para>
        /// <para>The results are <c>true</c> if the logic determines that the ACE is applicable and will be included in the call to <see cref="AuthzAccessCheck"/>; otherwise, the results are <c>false</c>.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, the function returns <c>true</c>.<br/>
        /// If the function is unable to perform the evaluation, it returns <c>false</c>. Use <see cref="SetLastError"/> to return an error to the access check function.
        /// </returns>
        /// <remarks>
        /// <para>Security attribute variables must be present in the client context if referred to in a conditional expression, otherwise the conditional expression term referencing them will evaluate to unknown.</para>
        /// <para>For more information, see the <a href="https://msdn.microsoft.com/en-us/library/aa446683.aspx">How AccessCheck Works</a> and <a href="https://msdn.microsoft.com/en-us/library/jj662749.aspx">Centralized Authorization Policy</a> overviews.</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375794.aspx">AuthzAccessCheckCallback callback function</a></para>
        /// </remarks>
        /// <seealso cref="AuthzAccessCheck"/>
        /// <seealso cref="AuthzCachedAccessCheck"/>
        /// <seealso cref="AuthzInitializeRemoteResourceManager"/>
        /// <seealso cref="AuthzInitializeResourceManager"/>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public delegate bool AuthzAccessCheckCallback(
            [In] IntPtr hAuthzClientContext,
            [In, MarshalAs(44, MarshalTypeRef = typeof(GenericAceCustomMarshaler))] GenericAce pAce,
            [In, Optional] IntPtr pArgs,
            ref bool pbAceApplicable
            );
        #endregion
    }
}
