using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_INFO_TYPE"/> enumeration is used with the <see cref="DsReplicaGetInfo"/> and <see cref="DsReplicaGetInfo2"/> functions to specify the type of replication data to retrieve.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-_ds_repl_info_type">DS_REPL_INFO_TYPE Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_ATTR_VALUE_META_DATA"/>
    /// <seealso cref="DS_REPL_ATTR_VALUE_META_DATA_2"/>
    /// <seealso cref="DS_REPL_CURSORS"/>
    /// <seealso cref="DS_REPL_CURSORS_2"/>
    /// <seealso cref="DS_REPL_CURSORS_3W"/>
    /// <seealso cref="DS_REPL_KCC_DSA_FAILURES"/>
    /// <seealso cref="DS_REPL_NEIGHBORS"/>
    /// <seealso cref="DS_REPL_OBJ_META_DATA"/>
    /// <seealso cref="DS_REPL_OBJ_META_DATA_2"/>
    /// <seealso cref="DS_REPL_PENDING_OPS"/>
    /// <seealso cref="DsReplicaGetInfo"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    public enum DS_REPL_INFO_TYPE
    {
        /// <summary>
        /// Requests replication state data for naming context and source server pairs. Returns a reference to a <see cref="DS_REPL_NEIGHBORS"/> structure.
        /// </summary>
        DS_REPL_INFO_NEIGHBORS = 0,
        /// <summary>
        /// Requests replication state data with respect to all replicas of a given naming context. Returns a reference to a <see cref="DS_REPL_CURSORS"/> structure.
        /// </summary>
        DS_REPL_INFO_CURSORS_FOR_NC = 1,
        /// <summary>
        /// Requests replication state data for the attributes for the given object. Returns a reference to a <see cref="DS_REPL_OBJ_META_DATA"/> structure.
        /// </summary>
        DS_REPL_INFO_METADATA_FOR_OBJ = 2,
        /// <summary>
        /// Requests replication state data with respect to connection failures between inbound replication partners. Returns a reference to a <see cref="DS_REPL_KCC_DSA_FAILURES"/> structure.
        /// </summary>
        DS_REPL_INFO_KCC_DSA_CONNECT_FAILURES = 3,
        /// <summary>
        /// Requests replication state data with respect to link failures between inbound replication partners. Returns a reference to a <see cref="DS_REPL_KCC_DSA_FAILURES"/> structure.
        /// </summary>
        DS_REPL_INFO_KCC_DSA_LINK_FAILURES = 4,
        /// <summary>
        /// Requests the replication tasks currently executing or queued to execute. Returns a reference to a <see cref="DS_REPL_PENDING_OPS"/> structure.
        /// </summary>
        DS_REPL_INFO_PENDING_OPS = 5,

        ////////////////////////////////////////////////////////////////////////////
        //
        //  The following info types are not supported by Windows 2000.  Calling
        //  DsReplicaGetInfo() with one of the types on a Windows 2000 client or
        //  where hDS is bound to a Windows 2000 DC will fail with
        //  ERROR_NOT_SUPPORTED.
        //

        /// <summary>
        /// Requests replication state data for a specific attribute for the given object. Returns a reference to a <see cref="DS_REPL_ATTR_VALUE_META_DATA"/> structure.
        /// </summary>
        DS_REPL_INFO_METADATA_FOR_ATTR_VALUE = 6,
        /// <summary>
        /// Requests replication state data with respect to all replicas of a given naming context. Returns a reference to a <see cref="DS_REPL_CURSORS_2"/> structure.
        /// </summary>
        DS_REPL_INFO_CURSORS_2_FOR_NC = 7,
        /// <summary>
        /// Requests replication state data with respect to all replicas of a given naming context. Returns a reference to a <see cref="DS_REPL_CURSORS_3W"/> structure.
        /// </summary>
        DS_REPL_INFO_CURSORS_3_FOR_NC = 8,
        /// <summary>
        /// Requests replication state data for the attributes for the given object. Returns a reference to a <see cref="DS_REPL_OBJ_META_DATA_2"/> structure.
        /// </summary>
        DS_REPL_INFO_METADATA_2_FOR_OBJ = 9,
        /// <summary>
        /// Requests replication state data for a specific attribute for the given object. Returns a reference to a <see cref="DS_REPL_ATTR_VALUE_META_DATA_2"/> structure.
        /// </summary>
        DS_REPL_INFO_METADATA_2_FOR_ATTR_VALUE = 10,

        /// <summary />
        DS_REPL_INFO_METADATA_EXT_FOR_ATTR_VALUE = 11,
        // <- insert new DS_REPL_INFO_* types here.
        /// <summary />
        DS_REPL_INFO_TYPE_MAX
    }
}
