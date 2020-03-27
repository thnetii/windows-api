namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 64
    //
    // Definition: TRUSTEE_TYPE
    // This enumerated type specifies the type of trustee account for the trustee
    // returned by the API described in this document.
    // TRUSTEE_IS_UNKNOWN - The trustee is an unknown, but not necessarily invalid
    //                      type.  This field is not validated on input to the APIs
    //                      that take Trustees.
    // TRUSTEE_IS_USER      The trustee account is a user account.
    // TRUSTEE_IS_GROUP     The trustee account is a group account.
    //

    /// <summary>
    /// The <see cref="TRUSTEE_TYPE"/> enumeration contains values that indicate the type of trustee identified by a <see cref="TRUSTEE"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ne-accctrl-trustee_type">TRUSTEE_TYPE enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/access-control">Access Control Overview</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/authorization-enumerations">Authorization Enumerations</seealso>
    /// <seealso cref="TRUSTEE"/>
    public enum TRUSTEE_TYPE
    {
        /// <summary>
        /// The trustee type is unknown, but it may be valid.
        /// </summary>
        TRUSTEE_IS_UNKNOWN,
        /// <summary>
        /// Indicates a user.
        /// </summary>
        TRUSTEE_IS_USER,
        /// <summary>
        /// Indicates a group.
        /// </summary>
        TRUSTEE_IS_GROUP,
        /// <summary>
        /// Indicates a domain.
        /// </summary>
        TRUSTEE_IS_DOMAIN,
        /// <summary>
        /// Indicates an alias.
        /// </summary>
        TRUSTEE_IS_ALIAS,
        /// <summary>
        /// Indicates a
        /// <a href="https://docs.microsoft.com/windows/desktop/SecAuthZ/well-known-sids">well-known group</a>.
        /// </summary>
        TRUSTEE_IS_WELL_KNOWN_GROUP,
        /// <summary>
        /// Indicates a deleted account.
        /// </summary>
        TRUSTEE_IS_DELETED,
        /// <summary>
        /// Indicates a trustee type that is not valid.
        /// </summary>
        TRUSTEE_IS_INVALID,
        /// <summary>
        /// Indicates a computer.
        /// </summary>
        TRUSTEE_IS_COMPUTER
    }
}
