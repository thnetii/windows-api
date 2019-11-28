namespace THNETII.WinApi.Native.AuthZ
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 381
    //
    //  SID operations that can be specified for a 'set' API:
    //

    /// <summary>
    /// The <see cref="AUTHZ_SID_OPERATION"/> enumeration indicates the type of SID operations that can be made by a call to the <see cref="AuthzModifySids"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/authz/ne-winnt-authz_sid_operation">AUTHZ_SID_OPERATION Enumeration</a></para>
    /// </remarks>
    public enum AUTHZ_SID_OPERATION
    {
        //
        //  No-op
        //

        /// <summary>
        /// Do not modify anything.
        /// </summary>
        AUTHZ_SID_OPERATION_NONE = 0,

        //
        //  Delete all existing SIDs in the NT token and replace them with 
        //  the specified SIDs.
        //  If the SIDs to replace with are not specified, all existing
        //  SIDs are deleted.
        //
        //  This operation can be specified at most once and must be the
        //  only operation specified.
        //

        /// <summary>
        /// Deletes all existing SIDs and replaces them with the specified SIDs. If the replacement SIDs are not specified, all existing SIDs are deleted. This operation can be specified only once and must be the only operation specified.
        /// </summary>
        AUTHZ_SID_OPERATION_REPLACE_ALL,

        //
        //  Add a new SID.
        //  If the SID specified already exists, the call fails.
        //

        /// <summary>
        /// Adds a new SID. If the SID already exists, the call fails.
        /// </summary>
        AUTHZ_SID_OPERATION_ADD,

        //
        //  Delete the specified SID(s).
        //  If no matching SID was found, no modifications are done and 
        //  the call fails.
        //

        /// <summary>
        /// Deletes the specified SID. If no matching SID is found, no modifications are done and the call fails.
        /// </summary>
        AUTHZ_SID_OPERATION_DELETE,

        //
        //  The specified SID(s) completely replace(s) the existing SID(s). 
        //  If the SID does not already exist, it is added.
        //

        /// <summary>
        /// Replaces the existing SID with the specified SID. If the SID does not already exist, then adds the SID.
        /// </summary>
        AUTHZ_SID_OPERATION_REPLACE
    }
}
