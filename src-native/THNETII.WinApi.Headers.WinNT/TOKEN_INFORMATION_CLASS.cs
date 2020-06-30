using System.ComponentModel;
using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10661
    /// <summary>
    /// <para>The <see cref="TOKEN_INFORMATION_CLASS"/> enumeration contains values that specify the type of information being assigned to or retrieved from an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access token</a>.</para>
    /// <para>The <see cref="GetTokenInformation"/> function uses these values to indicate the type of token information to retrieve.</para>
    /// <para>The <see cref="SetTokenInformation"/> function uses these values to set the token information.</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ne-winnt-token_information_class">TOKEN_INFORMATION_CLASS enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://msdn.microsoft.com/d9ce4ec5-5c09-4b33-93a1-39638a925986">Access Control</seealso>
    /// <seealso href="https://msdn.microsoft.com/e2f22838-102e-432c-9c82-06a3e0741374">Authorization Enumerations</seealso>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="SECURITY_IMPERSONATION_LEVEL"/>
    /// <seealso cref="SetTokenInformation"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_DEVICE_CLAIMS"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_GROUPS_AND_PRIVILEGES"/>
    /// <seealso cref="TOKEN_ORIGIN"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_TYPE"/>
    /// <seealso cref="TOKEN_USER"/>
    /// <seealso cref="TOKEN_USER_CLAIMS"/>
    public enum TOKEN_INFORMATION_CLASS
    {
        /// <summary>The buffer receives a <see cref="TOKEN_USER"/> structure that contains the user account of the token.</summary>
        TokenUser = 1,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that contains the group accounts associated with the token.</summary>
        TokenGroups,
        /// <summary>The buffer receives a <see cref="TOKEN_PRIVILEGES"/> structure that contains the privileges of the token.</summary>
        TokenPrivileges,
        /// <summary>The buffer receives a <see cref="TOKEN_OWNER"/> structure that contains the default owner security identifier (SID) for newly created objects.</summary>
        TokenOwner,
        /// <summary>The buffer receives a <see cref="TOKEN_PRIMARY_GROUP"/> structure that contains the default primary group SID for newly created objects.</summary>
        TokenPrimaryGroup,
        /// <summary>The buffer receives a <see cref="TOKEN_DEFAULT_DACL"/> structure that contains the default DACL for newly created objects.</summary>
        TokenDefaultDacl,
        /// <summary>The buffer receives a <see cref="TOKEN_SOURCE"/> structure that contains the source of the token. <see cref="TOKEN_QUERY_SOURCE"/> access is needed to retrieve this information.</summary>
        TokenSource,
        /// <summary>The buffer receives a <see cref="TOKEN_TYPE"/> value that indicates whether the token is a <a href="https://msdn.microsoft.com/2fe6cfd3-8a2e-4dbe-9fb8-332633daa97a">primary</a> or <a href="https://msdn.microsoft.com/af511aed-88f5-4b12-ad44-317925297f70">impersonation token</a>.</summary>
        TokenType,
        /// <summary>The buffer receives a <see cref="System.Security.Principal.TokenImpersonationLevel"/> value that indicates the impersonation level of the token. If the access token is not an <a href="https://msdn.microsoft.com/af511aed-88f5-4b12-ad44-317925297f70">impersonation token</a>, the function fails.</summary>
        TokenImpersonationLevel,
        /// <summary>The buffer receives a <see cref="TOKEN_STATISTICS"/> structure that contains various token statistics.</summary>
        TokenStatistics,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that contains the list of restricting SIDs in a <a href="https://msdn.microsoft.com/06580ab9-ff58-4aa9-bf88-9536a2e1981d">restricted token</a>.</summary>
        TokenRestrictedSids,
        /// <summary>
        /// <para>The buffer receives an <see cref="int"/> value that indicates the Terminal Services session identifier that is associated with the token.</para>
        /// <para>If the token is associated with the terminal server client session, the session identifier is nonzero.</para>
        /// <para><strong>Windows Server 2003 and Windows XP</strong>: If the token is associated with the terminal server console session, the session identifier is zero.</para>
        /// <para>In a non-Terminal Services environment, the session identifier is zero.</para>
        /// <para>If <see cref="TokenSessionId"/> is set with <see cref="SetTokenInformation"/>, the application must have the <strong>Act As Part Of the Operating System</strong> privilege, and the application must be enabled to set the session ID in a token.</para>
        /// </summary>
        TokenSessionId,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS_AND_PRIVILEGES"/> structure that contains the user SID, the group accounts, the restricted SIDs, and the authentication ID associated with the token.</summary>
        TokenGroupsAndPrivileges,
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        TokenSessionReference,
        /// <summary>The buffer receives an <see cref="int"/> value that is nonzero if the token includes the <see cref="SANDBOX_INERT"/> flag.</summary>
        TokenSandBoxInert,
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        TokenAuditPolicy,
        /// <summary>
        /// <para>The buffer receives a <see cref="TOKEN_ORIGIN"/> value.</para>
        /// <para>If the token resulted from a logon that used explicit credentials, such as passing a name, domain, and password to the <see cref="LogonUser"/> function, then the <see cref="TOKEN_ORIGIN"/> structure will contain the ID of the <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f"></a>logon session that created it.</para>
        /// <para>If the token resulted from network authentication, such as a call to <see cref="AcceptSecurityContext"/> or a call to <see cref="LogonUser"/> with <em>dwLogonType</em> set to <see cref="LOGON32_LOGON_NETWORK"/> or <see cref="LOGON32_LOGON_NETWORK_CLEARTEXT"/>, then this value will be zero.</para>
        /// </summary>
        TokenOrigin,
        /// <summary>The buffer receives a <see cref="TOKEN_ELEVATION_TYPE"/> value that specifies the elevation level of the token.</summary>
        TokenElevationType,
        /// <summary>The buffer receives a <see cref="TOKEN_LINKED_TOKEN"/> structure that contains a handle to another token that is linked to this token.</summary>
        TokenLinkedToken,
        /// <summary>The buffer receives a <see cref="TOKEN_ELEVATION"/> structure that specifies whether the token is elevated.</summary>
        TokenElevation,
        /// <summary>The buffer receives a <see cref="int"/> value that is nonzero if the token has ever been filtered.</summary>
        TokenHasRestrictions,
        /// <summary>The buffer receives a <see cref="TOKEN_ACCESS_INFORMATION"/> structure that specifies security information contained in the token.</summary>
        TokenAccessInformation,
        /// <summary>The buffer receives an <see cref="int"/> value that is nonzero if <a href="https://msdn.microsoft.com/412796ce-2ad5-429b-a2a6-8d286b19ae30">virtualization</a> is allowed for the token.</summary>
        TokenVirtualizationAllowed,
        /// <summary>The buffer receives an <see cref="int"/> value that is nonzero if <a href="https://msdn.microsoft.com/412796ce-2ad5-429b-a2a6-8d286b19ae30">virtualization</a> is enabled for the token.</summary>
        TokenVirtualizationEnabled,
        /// <summary>The buffer receives a <see cref="TOKEN_MANDATORY_LABEL"/> structure that specifies the token's integrity level.</summary>
        TokenIntegrityLevel,
        /// <summary>The buffer receives an <see cref="int"/> value that is nonzero if the token has the <strong>UIAccess</strong> flag set.</summary>
        TokenUIAccess,
        /// <summary>The buffer receives a <see cref="TOKEN_MANDATORY_POLICY"/> structure that specifies the token's mandatory integrity policy.</summary>
        TokenMandatoryPolicy,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that specifies the token's logon SID.</summary>
        TokenLogonSid,
        /// <summary>The buffer receives an <see cref="int"/> value that is nonzero if the token is an app container token. Any callers who check the <see cref="TokenIsAppContainer"/> and have it return <c>0</c> (zero) should also verify that the caller token is not an identify level impersonation token. If the current token is not an app container but is an identity level token, you should return <see cref="AccessDenied"/>.</summary>
        TokenIsAppContainer,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that contains the capabilities associated with the token.</summary>
        TokenCapabilities,
        /// <summary>The buffer receives a <see cref="TOKEN_APPCONTAINER_INFORMATION"/> structure that contains the <see cref="TOKEN_APPCONTAINER_INFORMATION.AppContainerSid"/> associated with the token. If the token is not associated with an app container, the <see cref="TOKEN_APPCONTAINER_INFORMATION.TokenAppContainer"/> member of the <see cref="TOKEN_APPCONTAINER_INFORMATION"/> structure points to <see langword="null"/>.</summary>
        TokenAppContainerSid,
        /// <summary>The buffer receives an <see cref="int"/> value that includes the app container number for the token. For tokens that are not app container tokens, this value is zero.</summary>
        TokenAppContainerNumber,
        /// <summary>The buffer receives a <see cref="CLAIM_SECURITY_ATTRIBUTES_INFORMATION"/> structure that contains the user claims associated with the token.</summary>
        TokenUserClaimAttributes,
        /// <summary>The buffer receives a <see cref="CLAIM_SECURITY_ATTRIBUTES_INFORMATION"/> structure that contains the device claims associated with the token.</summary>
        TokenDeviceClaimAttributes,
        /// <summary>This value is reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        TokenRestrictedUserClaimAttributes,
        /// <summary>This value is reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        TokenRestrictedDeviceClaimAttributes,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that contains the device groups that are associated with the token.</summary>
        TokenDeviceGroups,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that contains the restricted device groups that are associated with the token.</summary>
        TokenRestrictedDeviceGroups,
        /// <summary>This value is reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        TokenSecurityAttributes,
        /// <summary>This value is reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        TokenIsRestricted,
        /// <summary/>
        TokenProcessTrustLevel,
        /// <summary/>
        TokenPrivateNameSpace,
        /// <summary/>
        TokenSingletonAttributes,
        /// <summary/>
        TokenBnoIsolation,
        /// <summary/>
        TokenChildProcessFlags,
        /// <summary>The maximum value for this enumeration.</summary>
        MaxTokenInfoClass  // MaxTokenInfoClass should always be the last enum
    }
}
