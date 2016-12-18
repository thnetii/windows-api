namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="TOKEN_TYPE"/> enumeration contains values that differentiate between a <em><a href="https://msdn.microsoft.com/en-us/library/ms721603.aspx#_security_primary_token_gly">primary token</a></em> and an <em><a href="https://msdn.microsoft.com/en-us/library/ms721588.aspx#_security_impersonation_token_gly">impersonation token</a></em>. 
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379633.aspx">TOKEN_TYPE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_USER"/>
    public enum TOKEN_TYPE
    {
        /// <summary>Indicates a primary token.</summary>
        TokenPrimary = 1,
        /// <summary>Indicates an impersonation token.</summary>
        TokenImpersonation
    }
}
