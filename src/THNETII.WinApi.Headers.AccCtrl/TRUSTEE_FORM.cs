namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 89
    //
    // Definition: TRUSTEE_FORM
    // This enumerated type specifies the form the trustee identifier is in for a
    // particular trustee.
    // TRUSTEE_IS_SID       The trustee is identified with a SID rather than with a name.
    // TRUSTEE_IS_NAME      The trustee is identified with a name.
    //

    /// <summary>
    /// The <see cref="TRUSTEE_FORM"/> enumeration contains values that indicate the type of data pointed to by the <see cref="TRUSTEE.ptstrName"/> member of the <see cref="TRUSTEE"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ne-accctrl-trustee_form">TRUSTEE_FORM enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/access-control">Access Control</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/authorization-enumerations">Authorization Enumerations</seealso>
    /// <seealso cref="OBJECTS_AND_NAME"/>
    /// <seealso cref="OBJECTS_AND_SID"/>
    /// <seealso cref="TRUSTEE"/>
    public enum TRUSTEE_FORM
    {
        /// <summary>
        /// The <see cref="TRUSTEE.ptstrName"/> member is a pointer to a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security identifier</a> (SID) that identifies the trustee.
        /// </summary>
        TRUSTEE_IS_SID,
        /// <summary>
        /// The <see cref="TRUSTEE.ptstrName"/> member is a pointer to a null-terminated string that identifies the trustee.
        /// </summary>
        TRUSTEE_IS_NAME,
        /// <summary>
        /// Indicates a trustee form that is not valid.
        /// </summary>
        TRUSTEE_BAD_FORM,
        /// <summary>
        /// The <see cref="TRUSTEE.ptstrName"/> member is a pointer to an
        /// <see cref="OBJECTS_AND_SID"/> structure that contains the SID of the trustee and the GUIDs of the object types in an object-specific <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control entry</a> (ACE).
        /// </summary>
        TRUSTEE_IS_OBJECTS_AND_SID,
        /// <summary>
        /// The <see cref="TRUSTEE.ptstrName"/> member is a pointer to an
        /// <see cref="OBJECTS_AND_NAME"/> structure that contains the name of the trustee and the names of the object types in an object-specific ACE.
        /// </summary>
        TRUSTEE_IS_OBJECTS_AND_NAME
    }
}
