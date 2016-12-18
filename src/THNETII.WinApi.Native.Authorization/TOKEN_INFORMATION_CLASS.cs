namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="TOKEN_INFORMATION_CLASS"/> enumeration contains values that specify the type of information being assigned to or retrieved from an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_token_gly">access token</a></em>.
    /// <para>The <see cref="GetTokenInformation"/> function uses these values to indicate the type of token information to retrieve.</para>
    /// <para>The <see cref="SetTokenInformation"/> function uses these values to set the token information.</para>
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379626.aspx">TOKEN_INFORMATION_CLASS enumeration</a></para>
    /// </remarks>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="System.Security.Principal.TokenImpersonationLevel"/>
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
        /// <summary>The buffer receives a <see cref="TOKEN_OWNER"/> structure that contains the default owner <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_identifier_gly">security identifier</a></em> (SID) for newly created objects.</summary>
        TokenOwner,
        /// <summary>The buffer receives a <see cref="TOKEN_PRIMARY_GROUP"/> structure that contains the default primary group SID for newly created objects.</summary>
        TokenPrimaryGroup,
        /// <summary>The buffer receives a <see cref="TOKEN_DEFAULT_DACL"/> structure that contains the default DACL for newly created objects.</summary>
        TokenDefaultDacl,
        /// <summary>The buffer receives a <see cref="TOKEN_SOURCE"/> structure that contains the source of the token. <see cref="TOKEN_QUERY_SOURCE"/> access is needed to retrieve this information.</summary>
        TokenSource,
        /// <summary>The buffer receives a <see cref="TOKEN_TYPE"/> value that indicates whether the token is a <em><a href="https://msdn.microsoft.com/en-us/library/ms721603.aspx#_security_primary_token_gly">primary</a></em> or <em><a href="https://msdn.microsoft.com/en-us/library/ms721588.aspx#_security_impersonation_token_gly">impersonation token</a></em>. </summary>
        TokenType,
        /// <summary>The buffer receives a <see cref="System.Security.Principal.TokenImpersonationLevel"/> value that indicates the impersonation level of the token. If the access token is not an <em><a href="https://msdn.microsoft.com/en-us/library/ms721588.aspx#_security_impersonation_token_gly">impersonation token</a></em>, the function fails.</summary>
        TokenImpersonationLevel,
        /// <summary>The buffer receives a <see cref="TOKEN_STATISTICS"/> structure that contains various token statistics.</summary>
        TokenStatistics,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that contains the list of restricting SIDs in a <a href="https://msdn.microsoft.com/en-us/library/aa379316.aspx">restricted token</a>.</summary>
        TokenRestrictedSids,
        /// <summary>
        /// The buffer receives an integer value that indicates the Terminal Services session identifier that is associated with the token.
        /// <para>If the token is associated with the terminal server client session, the session identifier is nonzero.</para>
        /// <para><strong>Windows Server 2003 and Windows XP:</strong> If the token is associated with the terminal server console session, the session identifier is zero.</para>
        /// <para>In a non-Terminal Services environment, the session identifier is zero.</para>
        /// <para>If <see cref="TokenSessionId"/> is set with <see cref="SetTokenInformation"/>, the application must have the <strong>Act As Part Of the Operating System</strong> privilege, and the application must be enabled to set the session ID in a token.</para>
        /// </summary>
        TokenSessionId,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS_AND_PRIVILEGES"/> structure that contains the user SID, the group accounts, the restricted SIDs, and the authentication ID associated with the token.</summary>
        TokenGroupsAndPrivileges,
        /// <summary>Reserved.</summary>
        TokenSessionReference,
        /// <summary>The buffer receives an integer value that is nonzero if the token includes the <see cref="SANDBOX_INERT"/> flag.</summary>
        TokenSandBoxInert,
        /// <summary>Reserved.</summary>
        TokenAuditPolicy,
        /// <summary>
        /// The buffer receives a <see cref="TOKEN_ORIGIN"/> value. 
        /// <para>If the token resulted from a logon that used explicit credentials, such as passing a name, domain, and password to the <see cref="LogonUser"/> function, then the <see cref="TOKEN_ORIGIN"/> structure will contain the ID of the <em><a href="https://msdn.microsoft.com/en-us/library/ms721592.aspx#_security_logon_session_gly">logon session</a></em> that created it.</para>
        /// <para>If the token resulted from network authentication, such as a call to <see cref="AcceptSecurityContext"/> or a call to <see cref="LogonUser"/> with <em>dwLogonType</em> set to <see cref="LOGON32_LOGON_NETWORK"/> or <see cref="LOGON32_LOGON_NETWORK_CLEARTEXT"/>, then this value will be zero.</para>
        /// </summary>
        TokenOrigin,
        /// <summary>The buffer receives a <see cref="TOKEN_ELEVATION_TYPE"/> value that specifies the elevation level of the token.</summary>
        TokenElevationType,
        /// <summary>The buffer receives a <see cref="TOKEN_LINKED_TOKEN"/> structure that contains a handle to another token that is linked to this token.</summary>
        TokenLinkedToken,
        /// <summary>The buffer receives a <see cref="TOKEN_ELEVATION"/> structure that specifies whether the token is elevated.</summary>
        TokenElevation,
        /// <summary>The buffer receives an integer value that is nonzero if the token has ever been filtered.</summary>
        TokenHasRestrictions,
        /// <summary>The buffer receives a <see cref="TOKEN_ACCESS_INFORMATION"/> structure that specifies security information contained in the token.</summary>
        TokenAccessInformation,
        /// <summary>The buffer receives an integer value that is nonzero if <em><a href="https://msdn.microsoft.com/en-us/library/ms721633.aspx#_security_virtualization_gly">virtualization</a></em> is allowed for the token.</summary>
        TokenVirtualizationAllowed,
        /// <summary>The buffer receives an integer value that is nonzero if <em><a href="https://msdn.microsoft.com/en-us/library/ms721633.aspx#_security_virtualization_gly">virtualization</a></em> is enabled for the token.</summary>
        TokenVirtualizationEnabled,
        /// <summary>The buffer receives a <see cref="TOKEN_MANDATORY_LABEL"/> structure that specifies the token's integrity level. </summary>
        TokenIntegrityLevel,
        /// <summary>The buffer receives an integer value that is nonzero if the token has the UIAccess flag set.</summary>
        TokenUIAccess,
        /// <summary>The buffer receives a <see cref="TOKEN_MANDATORY_POLICY"/> structure that specifies the token's mandatory integrity policy.</summary>
        TokenMandatoryPolicy,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that specifies the token's logon SID.</summary>
        TokenLogonSid,
        /// <summary>The buffer receives an integer value that is nonzero if the token is an app container token. Any callers who check the <see cref="TokenIsAppContainer"/> and have it return 0 should also verify that the caller token is not an identify level impersonation token. If the current token is not an app container but is an identity level token, you should return <see cref="AccessDenied"/>.</summary>
        TokenIsAppContainer,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that contains the capabilities associated with the token.</summary>
        TokenCapabilities,
        /// <summary>The buffer receives a <see cref="TOKEN_APPCONTAINER_INFORMATION"/> structure that contains the App Container Sid associated with the token. If the token is not associated with an app container, the <see cref="TOKEN_APPCONTAINER_INFORMATION.TokenAppContainer"/> member of the <see cref="TOKEN_APPCONTAINER_INFORMATION"/> structure points to <c>null</c>.</summary>
        TokenAppContainerSid,
        /// <summary>The buffer receives an integer value that includes the app container number for the token. For tokens that are not app container tokens, this value is zero.</summary>
        TokenAppContainerNumber,
        /// <summary>The buffer receives a <see cref="CLAIM_SECURITY_ATTRIBUTES_INFORMATION"/> structure that contains the user claims associated with the token.</summary>
        TokenUserClaimAttributes,
        /// <summary>The buffer receives a <see cref="CLAIM_SECURITY_ATTRIBUTES_INFORMATION"/> structure that contains the device claims associated with the token.</summary>
        TokenDeviceClaimAttributes,
        /// <summary>This value is reserved.</summary>
        TokenRestrictedUserClaimAttributes,
        /// <summary>This value is reserved.</summary>
        TokenRestrictedDeviceClaimAttributes,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that contains the device groups that are associated with the token.</summary>
        TokenDeviceGroups,
        /// <summary>The buffer receives a <see cref="TOKEN_GROUPS"/> structure that contains the restricted device groups that are associated with the token.</summary>
        TokenRestrictedDeviceGroups,
        /// <summary>This value is reserved.</summary>
        TokenSecurityAttributes,
        /// <summary>This value is reserved.</summary>
        TokenIsRestricted,
        /// <summary>The maximum value for this enumeration.</summary>
        MaxTokenInfoClass
    }
}
