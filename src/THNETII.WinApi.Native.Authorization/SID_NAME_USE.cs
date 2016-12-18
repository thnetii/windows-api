namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="SID_NAME_USE"/> enumeration contains values that specify the type of a <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_identifier_gly">security identifier</a></em> (SID).
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379601.aspx">SID_NAME_USE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="LookupAccountName"/>
    /// <seealso cref="LookupAccountSid"/>
    public enum SID_NAME_USE
    {
        /// <summary>A user SID.</summary>
        SidTypeUser = 1,
        /// <summary>A group SID.</summary>
        SidTypeGroup,
        /// <summary>A domain SID.</summary>
        SidTypeDomain,
        /// <summary>An alias SID.</summary>
        SidTypeAlias,
        /// <summary>A SID for a well-known group.</summary>
        SidTypeWellKnownGroup,
        /// <summary>A SID for a deleted account.</summary>
        SidTypeDeletedAccount,
        /// <summary>A SID that is not valid.</summary>
        SidTypeInvalid,
        /// <summary>A SID of unknown type.</summary>
        SidTypeUnknown,
        /// <summary>A SID for a computer.</summary>
        SidTypeComputer,
        /// <summary>A mandatory integrity label SID.</summary>
        SidTypeLabel
    }
}
