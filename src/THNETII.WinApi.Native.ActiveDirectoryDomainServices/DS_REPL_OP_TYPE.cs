namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_OP_TYPE"/> enumeration type is used to indicate the type of replication operation that a given entry in the replication queue represents.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-_ds_repl_op_type">_DS_REPL_OP_TYPE Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DsReplicaGetInfo"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    public enum DS_REPL_OP_TYPE
    {
        /// <summary>
        /// Indicates an inbound replication over an existing replication agreement from a direct replication partner.
        /// </summary>
        DS_REPL_OP_TYPE_SYNC = 0,
        /// <summary>
        /// Indicates the addition of a replication agreement for a new direct replication partner.
        /// </summary>
        DS_REPL_OP_TYPE_ADD,
        /// <summary>
        /// Indicates the removal of a replication agreement for an existing direct replication partner.
        /// </summary>
        DS_REPL_OP_TYPE_DELETE,
        /// <summary>
        /// Indicates the modification of a replication agreement for an existing direct replication partner.
        /// </summary>
        DS_REPL_OP_TYPE_MODIFY,
        /// <summary>
        /// Indicates the addition, deletion, or update of outbound change notification data for a direct replication partner.
        /// </summary>
        DS_REPL_OP_TYPE_UPDATE_REFS
    }
}
