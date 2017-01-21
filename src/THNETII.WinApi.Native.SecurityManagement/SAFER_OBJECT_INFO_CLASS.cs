namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// The <see cref="SAFER_OBJECT_INFO_CLASS"/> enumeration type defines the type of information requested about a Safer object.
    /// </summary>
    /// <remarks>
    /// The <see cref="SAFER_OBJECT_INFO_CLASS"/> enumeration type is used by the <see cref="SaferGetLevelInformation"/> function.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms722435.aspx">SAFER_OBJECT_INFO_CLASS enumeration</a></para>
    /// </remarks>
    public enum SAFER_OBJECT_INFO_CLASS
    {
        /// <summary>Queries for the LEVELID constant.</summary>
        SaferObjectLevelId = 1,
        /// <summary>Queries for the user or machine scope.</summary>
        SaferObjectScopeId = 2,
        /// <summary>Queries for the display name.</summary>
        SaferObjectFriendlyName = 3,
        /// <summary>Queries for the description.</summary>
        SaferObjectDescription = 4,
        /// <summary>Queries for all levels.</summary>
        SaferObjectAllIdentificationGuids = 13,
        /// <summary>Queries for a single additional rule.</summary>
        SaferObjectSingleIdentification = 14,
        /// <summary>Queries for additional error codes set during rule processing.</summary>
        SaferObjectExtendedError = 15
    }
}
