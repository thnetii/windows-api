namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="AUTHZ_SID_OPERATION"/> enumeration indicates the type of SID operations that can be made by a call to the <see cref="AuthzModifySids"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/hh448467.aspx">AUTHZ_SID_OPERATION enumeration</a></para>
    /// </remarks>
    public enum AUTHZ_SID_OPERATION
    {
        /// <summary>Do not modify anything.</summary>
        AUTHZ_SID_OPERATION_NONE = 0,
        /// <summary>
        /// Deletes all existing SIDs and replaces them with the specified SIDs. If the replacement SIDs are not specified, all existing SIDs are deleted. This operation can be specified only once and must be the only operation specified.
        /// </summary>
        AUTHZ_SID_OPERATION_REPLACE_ALL = 1,
        /// <summary>Adds a new SID. If the SID already exists, the call fails.</summary>
        AUTHZ_SID_OPERATION_ADD = 2,
        /// <summary>Deletes the specified SID. If no matching SID is found, no modifications are done and the call fails.</summary>
        AUTHZ_SID_OPERATION_DELETE = 3,
        /// <summary>Replaces the existing SID with the specified SID. If the SID does not already exist, then adds the SID.</summary>
        AUTHZ_SID_OPERATION_REPLACE = 4
    }
}
