namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_MANGLE_FOR"/> enumeration is used to define whether a relative distinguished name is mangled (encoded) and in what form the mangling occurs.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-_ds_mangle_for">_DS_MANGLE_FOR Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DsCrackUnquotedMangledRdn"/>
    /// <seealso cref="DsIsMangledDn"/>
    /// <seealso cref="DsIsMangledRdnValue"/>
    public enum DS_MANGLE_FOR
    {
        /// <summary>
        /// Indicates that the relative distinguished name is not mangled or that the type of mangling is unknown.
        /// </summary>
        DS_MANGLE_UNKNOWN = 0,
        /// <summary>
        /// Indicates that the relative distinguished name has been mangled for deletion.
        /// </summary>
        DS_MANGLE_OBJECT_RDN_FOR_DELETION,
        /// <summary>
        /// Indicates that the relative distinguished name has been mangled due to a naming conflict.
        /// </summary>
        DS_MANGLE_OBJECT_RDN_FOR_NAME_CONFLICT,
    }
}
