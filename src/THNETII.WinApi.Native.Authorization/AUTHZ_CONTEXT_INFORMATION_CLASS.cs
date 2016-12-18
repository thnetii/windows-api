namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="AUTHZ_CONTEXT_INFORMATION_CLASS"/> enumeration specifies the type of information to be retrieved from an existing AuthzClientContext. This enumeration is used by the <see cref="AuthzGetInformationFromContext"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa376323.aspx">AUTHZ_CONTEXT_INFORMATION_CLASS enumeration</a></para>
    /// </remarks>
    /// <seealso cref="AuthzGetInformationFromContext"/>
    /// <seealso cref="SECURITY_CAPABILITIES"/>
    /// <seealso cref="TOKEN_APPCONTAINER_INFORMATION"/>
    /// <seealso cref="TOKEN_DEVICE_CLAIMS"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_USER"/>
    /// <seealso cref="TOKEN_USER_CLAIMS"/>
    public enum AUTHZ_CONTEXT_INFORMATION_CLASS
    {
        /// <summary>Retrieves a <see cref="TOKEN_USER"/> structure that contains a user <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_identifier_gly">security identifier</a></em> (SID) and its attribute.</summary>
        AuthzContextInfoUserSid = 1,
        /// <summary>Retrieves a <see cref="TOKEN_GROUPS"/> structure that contains the group SIDs to which the user belongs and their attributes.</summary>
        AuthzContextInfoGroupsSids,
        /// <summary>Retrieves a <see cref="TOKEN_GROUPS"/> structure that contains the restricted group SIDs in the context and their attributes.</summary>
        AuthzContextInfoRestrictedSids,
        /// <summary>Retrieves a <see cref="TOKEN_PRIVILEGES"/> structure that contains the privileges held by the user.</summary>
        AuthzContextInfoPrivileges,
        /// <summary>Retrieves the expiration time set on the context.</summary>
        AuthzContextInfoExpirationTime,
        /// <summary>This constant is reserved. Do not use it.</summary>
        AuthzContextInfoServerContext,
        /// <summary>Retrieves a LUID value used by the resource manager to identify the context.</summary>
        AuthzContextInfoIdentifier,
        /// <summary>This constant is reserved. Do not use it.</summary>
        AuthzContextInfoSource,
        /// <summary>This constant is reserved. Do not use it.</summary>
        AuthzContextInfoAll,
        /// <summary>This constant is reserved. Do not use it.</summary>
        AuthzContextInfoAuthenticationId,
        /// <summary>
        /// <para>Retrieves an <see cref="AUTHZ_SECURITY_ATTRIBUTES_INFORMATION"/> structure that contains security attributes.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        AuthzContextInfoSecurityAttributes,
        /// <summary>
        /// <para>Retrieves a <see cref="TOKEN_GROUPS"/> structure that contains device SIDs and their attributes.</para>
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        AuthzContextInfoDeviceSids,
        /// <summary>
        /// <para>Retrieves a <see cref="AUTHZ_SECURITY_ATTRIBUTES_INFORMATION"/> structure that contains user claims.</para>
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        AuthzContextInfoUserClaims,
        /// <summary>
        /// <para>Retrieves a <see cref="AUTHZ_SECURITY_ATTRIBUTES_INFORMATION"/> structure that contains device claims.</para>
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        AuthzContextInfoDeviceClaims,
        /// <summary>
        /// <para>Retrieves a <see cref="TOKEN_APPCONTAINER_INFORMATION"/> structure that contains the app container SID.</para>
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        AuthzContextInfoAppContainerSid,
        /// <summary>
        /// <para>Retrieves a <see cref="TOKEN_GROUPS"/> structure that contains capability SIDs.</para>
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        AuthzContextInfoCapabilitySids
    }
}
