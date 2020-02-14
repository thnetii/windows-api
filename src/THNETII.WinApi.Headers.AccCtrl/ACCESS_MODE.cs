namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 229
    //
    // Definition: ACCESS_MODE
    // This enumerated type specifies how permissions are (requested)/to be applied
    //  for the trustee by the access control entry.  On input this field can by any
    //  of the values, although it is not meaningful to mix access control and audit
    //  control entries.  On output this field will be either SET_ACCESS, DENY_ACCESS,
    // SET_AUDIT_SUCCESS, SET_AUDIT_FAILURE.
    // The following descriptions define how this type effects an explicit access
    // request to apply access permissions to an object.
    // GRANT_ACCESS - The trustee will have at least the requested permissions upon
    //                successful completion of the command. (If the trustee has
    //                additional permissions they will not be removed).
    // SET_ACCESS - The trustee will have exactly the requested permissions upon
    //              successful completion of the command.
    // DENY_ACCESS - The trustee will be denied the specified permissions.
    // REVOKE_ACCESS - Any explicit access rights the trustee has will be revoked.
    // SET_AUDIT_SUCCESS - The trustee will be audited for successful opens of the
    //                     object using the requested permissions.
    // SET_AUDIT_FAILURE - The trustee will be audited for failed opens of the object
    //                     using the requested permissions.
    //

    /// <summary>
    /// The <see cref="ACCESS_MODE"/> enumeration contains values that indicate how the access rights in an <see cref="EXPLICIT_ACCESS"/> structure apply to the trustee. Functions such as <see cref="SetEntriesInAcl"/> and <see cref="GetExplicitEntriesFromAcl"/> use these values to set or retrieve information in an <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control entry</a> (ACE).
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ne-accctrl-access_mode">ACCESS_MODE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="ACCESS_ALLOWED_ACE"/>
    /// <seealso cref="ACCESS_DENIED_ACE"/>
    /// <seealso cref="ACE"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/access-control">Access Control</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/authorization-enumerations">Authorization Enumerations</seealso>
    /// <seealso cref="EXPLICIT_ACCESS"/>
    /// <seealso cref="GetExplicitEntriesFromAcl"/>
    /// <seealso cref="SYSTEM_AUDIT_ACE"/>
    /// <seealso cref="SetEntriesInAcl"/>
    public enum ACCESS_MODE
    {
        /// <summary>
        /// Value not used.
        /// </summary>
        NOT_USED_ACCESS = 0,
        /// <summary>
        /// Indicates an
        /// <see cref="ACCESS_ALLOWED_ACE"/> structure. The new ACE combines the specified rights with any existing allowed or denied rights of the trustee.
        /// </summary>
        GRANT_ACCESS,
        /// <summary>
        /// Indicates an <see cref="ACCESS_ALLOWED_ACE"/> structure that allows the specified rights.
        /// <para>On input, this value discards any existing access control information for the trustee.</para>
        /// </summary>
        SET_ACCESS,
        /// <summary>
        /// Indicates an
        /// <see cref="ACCESS_DENIED_ACE"/> structure that denies the specified rights.
        /// <para>On input, this value denies the specified rights in addition to any currently denied rights of the trustee.</para>
        /// </summary>
        DENY_ACCESS,
        /// <summary>
        /// Indicates that all existing <see cref="ACCESS_ALLOWED_ACE"/> or
        /// <see cref="SYSTEM_AUDIT_ACE"/> structures for the specified trustee are removed.
        /// </summary>
        REVOKE_ACCESS,
        /// <summary>
        /// Indicates a <see cref="SYSTEM_AUDIT_ACE"/> structure that generates audit messages for successful attempts to use the specified access rights.
        /// <para>On input, this value combines the specified rights with any existing audited access rights for the trustee.</para>
        /// </summary>
        SET_AUDIT_SUCCESS,
        /// <summary>
        /// Indicates a
        /// <see cref="SYSTEM_AUDIT_ACE"/> structure that generates audit messages for failed attempts to use the specified access rights.
        /// <para>On input, this value combines the specified rights with any existing audited access rights for the trustee.</para>
        /// </summary>
        SET_AUDIT_FAILURE
    }
}
