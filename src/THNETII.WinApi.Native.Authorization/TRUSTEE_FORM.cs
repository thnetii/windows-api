namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="TRUSTEE_FORM"/> enumeration contains values that indicate the type of data pointed to by the <see cref="TRUSTEE.ptstrName"/> member of the <see cref="TRUSTEE"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379638.aspx">TRUSTEE_FORM enumeration</a></para>
    /// </remarks>
    /// <seealso cref="OBJECTS_AND_NAME"/>
    /// <seealso cref="OBJECTS_AND_SID"/>
    /// <seealso cref="TRUSTEE"/>
    public enum TRUSTEE_FORM
    {
        /// <summary>The <see cref="TRUSTEE.ptstrName"/> member is a pointer to a <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_identifier_gly">security identifier</a></em> (SID) that identifies the trustee.</summary>
        TRUSTEE_IS_SID,
        /// <summary>The <see cref="TRUSTEE.ptstrName"/> member is a pointer to a null-terminated string that identifies the trustee.</summary>
        TRUSTEE_IS_NAME,
        /// <summary>Indicates a trustee form that is not valid.</summary>
        TRUSTEE_BAD_FORM,
        /// <summary>The <see cref="TRUSTEE.ptstrName"/> member is a pointer to an <see cref="OBJECTS_AND_SID"/> structure that contains the SID of the trustee and the GUIDs of the object types in an object-specific <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entry</a></em> (ACE). </summary>
        TRUSTEE_IS_OBJECTS_AND_SID,
        /// <summary>The <see cref="TRUSTEE.ptstrName"/> member is a pointer to an <see cref="OBJECTS_AND_NAME"/> structure that contains the name of the trustee and the names of the object types in an object-specific <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entry</a></em> (ACE).</summary>
        TRUSTEE_IS_OBJECTS_AND_NAME
    }
}
