using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.ACCESS_MASK;
using static Microsoft.Win32.WindowsProtocols.MsErrRef.Win32ErrorCode;

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
        /// If the function succeeds, the return value is nonzero. <br/>
        /// If the function fails, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
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
            [In] GENERIC_MAPPING GenericMapping,
            PrivilegeSetSafeHandle PrivilegeSet,
            ref int PrivilegeSetLength,
            out ACCESS_MASK GrantedAccess,
            out bool AccessStatus
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
