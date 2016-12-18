namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="TRUSTEE_TYPE"/> enumeration contains values that indicate the type of trustee identified by a <see cref="TRUSTEE"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379639.aspx">TRUSTEE_TYPE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="TRUSTEE"/>
    public enum TRUSTEE_TYPE
    {
        /// <summary>The trustee type is unknown, but it may be valid.</summary>
        TRUSTEE_IS_UNKNOWN,
        /// <summary>Indicates a user.</summary>
        TRUSTEE_IS_USER,
        /// <summary>Indicates a group.</summary>
        TRUSTEE_IS_GROUP,
        /// <summary>Indicates a domain.</summary>
        TRUSTEE_IS_DOMAIN,
        /// <summary>Indicates an alias.</summary>
        TRUSTEE_IS_ALIAS,
        /// <summary>Indicates a <a href="https://msdn.microsoft.com/en-us/library/aa379649.aspx">well-known group</a>.</summary>
        TRUSTEE_IS_WELL_KNOWN_GROUP,
        /// <summary>Indicates a deleted account.</summary>
        TRUSTEE_IS_DELETED,
        /// <summary>Indicates a trustee type that is not valid.</summary>
        TRUSTEE_IS_INVALID,
        /// <summary>Indicates a computer.</summary>
        TRUSTEE_IS_COMPUTER
    }
}
