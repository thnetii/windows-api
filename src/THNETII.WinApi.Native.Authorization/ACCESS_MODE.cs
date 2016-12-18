namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="ACCESS_MODE"/> enumeration contains values that indicate how the access rights in an <see cref="EXPLICIT_ACCESS"/> structure apply to the trustee. Functions such as <see cref="SetEntriesInAcl"/> and <see cref="GetExplicitEntriesFromAcl"/> use these values to set or retrieve information in an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entry</a></em> (ACE).
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa374899.aspx">ACCESS_MODE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="ACCESS_ALLOWED_ACE"/>
    /// <seealso cref="ACCESS_DENIED_ACE"/>
    /// <seealso cref="ACE"/>
    /// <seealso cref="EXPLICIT_ACCESS"/>
    /// <seealso cref="GetExplicitEntriesFromAcl"/>
    /// <seealso cref="SetEntriesInAcl"/>
    /// <seealso cref="SYSTEM_AUDIT_ACE"/>
    public enum ACCESS_MODE
    {
        /// <summary>Value not used.</summary>
        NOT_USED_ACCESS = 0,
        /// <summary>
        /// Indicates an ACCESS_ALLOWED_ACE structure. The new ACE combines the specified rights with any existing allowed or denied rights of the trustee.
        /// </summary>
        GRANT_ACCESS,
        /// <summary>
        /// <para>Indicates an ACCESS_ALLOWED_ACE structure that allows the specified rights. </para>
        /// <para>On input, this value discards any existing access control information for the trustee.</para>
        /// </summary>
        SET_ACCESS,
        /// <summary>
        /// <para>Indicates an ACCESS_DENIED_ACE structure that denies the specified rights. </para>
        /// <para>On input, this value denies the specified rights in addition to any currently denied rights of the trustee.</para>
        /// </summary>
        DENY_ACCESS,
        /// <summary>Indicates that all existing ACCESS_ALLOWED_ACE or SYSTEM_AUDIT_ACE structures for the specified trustee are removed.</summary>
        REVOKE_ACCESS,
        /// <summary>
        /// <para>Indicates a SYSTEM_AUDIT_ACE structure that generates audit messages for successful attempts to use the specified access rights. </para>
        /// <para>On input, this value combines the specified rights with any existing audited access rights for the trustee.</para>
        /// </summary>
        SET_AUDIT_SUCCESS,
        /// <summary>
        /// <para>Indicates a SYSTEM_AUDIT_ACE structure that generates audit messages for failed attempts to use the specified access rights. </para>
        /// <para>On input, this value combines the specified rights with any existing audited access rights for the trustee.</para>
        /// </summary>
        SET_AUDIT_FAILURE
    }
}
