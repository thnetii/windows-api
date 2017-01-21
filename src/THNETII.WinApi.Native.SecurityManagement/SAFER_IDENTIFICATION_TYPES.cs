namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// The <see cref="SAFER_IDENTIFICATION_TYPES"/> enumeration type defines the possible types of identification rule structures that can be identified by the <see cref="SAFER_IDENTIFICATION_HEADER"/> structure.
    /// </summary>
    /// <remarks>
    /// The <see cref="SAFER_IDENTIFICATION_TYPES"/> enumeration type is used by the <see cref="SAFER_IDENTIFICATION_HEADER"/> structure.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms722434.aspx">SAFER_IDENTIFICATION_TYPES enumeration</a></para>
    /// </remarks>
    public enum SAFER_IDENTIFICATION_TYPES
    {
        /// <summary>The header is for a default level structure.</summary>
        SaferIdentityDefault = 0,
        /// <summary>The header is for a <see cref="SAFER_PATHNAME_IDENTIFICATION"/> structure.</summary>
        SaferIdentityTypeImageName = 1,
        /// <summary>The header is for a <see cref="SAFER_HASH_IDENTIFICATION"/> structure.</summary>
        SaferIdentityTypeImageHash = 2,
        /// <summary>The header is for a <see cref="SAFER_URLZONE_IDENTIFICATION"/> structure.</summary>
        SaferIdentityTypeUrlZone = 3,
        /// <summary>The header is for a <see cref="SAFER_PATHNAME_IDENTIFICATION"/> structure.</summary>
        SaferIdentityTypeCertificate = 4
    }
}
