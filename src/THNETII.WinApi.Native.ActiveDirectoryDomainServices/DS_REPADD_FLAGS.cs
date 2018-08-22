using System;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// Replica Add flags
    /// </summary>
    [Flags]
    public enum DS_REPADD_FLAGS : uint
    {
        /// <summary>Perform this operation asynchronously.</summary>
        DS_REPADD_ASYNCHRONOUS_OPERATION = unchecked(0x00000001),

        /// <summary>Create a writeable replica.  Otherwise, read-only.</summary>
        DS_REPADD_WRITEABLE = unchecked(0x00000002),

        /// <summary>Sync the NC from this source when the DSA is started.</summary>
        DS_REPADD_INITIAL = unchecked(0x00000004),

        /// <summary>
        /// Sync the NC from this source periodically, as defined by the
        /// schedule passed in the preptimesSync argument.
        /// </summary>
        DS_REPADD_PERIODIC = unchecked(0x00000008),

        /// <summary>
        /// Sync from the source DSA via an Intersite Messaging Service (ISM) transport
        /// (e.g., SMTP) rather than native DS RPC.
        /// </summary>
        DS_REPADD_INTERSITE_MESSAGING = unchecked(0x00000010),

        /// <summary>
        /// Don't replicate the NC now -- just save enough state such that we
        /// know to replicate it later.
        /// </summary>
        DS_REPADD_ASYNCHRONOUS_REPLICA = unchecked(0x00000020),

        /// <summary>
        /// Disable notification-based synchronization for the NC from this source.
        /// This is expected to be a temporary state; the similar flag
        /// DS_REPADD_NEVER_NOTIFY should be used if the disable is to be more permanent.
        /// </summary>
        DS_REPADD_DISABLE_NOTIFICATION = unchecked(0x00000040),

        /// <summary>Disable periodic synchronization for the NC from this source</summary>
        DS_REPADD_DISABLE_PERIODIC = unchecked(0x00000080),

        /// <summary>
        /// Use compression when replicating.  Saves message size (e.g., network
        /// bandwidth) at the expense of extra CPU overhead at both the source and
        /// destination servers.
        /// </summary>
        DS_REPADD_USE_COMPRESSION = unchecked(0x00000100),

        /// <summary>
        /// Do not request change notifications from this source.  When this flag is
        /// set, the source will not notify the destination when changes occur.
        /// Recommended for all intersite replication, which may occur over WAN links.
        /// This is expected to be a more or less permanent state; the similar flag
        /// DS_REPADD_DISABLE_NOTIFICATION should be used if notifications are to be
        /// disabled only temporarily.
        /// </summary>
        DS_REPADD_NEVER_NOTIFY = unchecked(0x00000200),

        /// <summary>When this sync is complete, requests a sync in the opposite direction.</summary>
        DS_REPADD_TWO_WAY = unchecked(0x00000400),

        /// <summary>
        /// Request critical objects only
        /// Critical only is only allowed while installing
        /// A critical only sync does not bring all objects in the partition. It
        /// replicates just the ones necessary for minimal directory operation.
        /// A normal, non-critical sync must be performed before the partition
        /// can be considered fully synchronized.
        /// </summary>
        DS_REPADD_CRITICAL = unchecked(0x00000800),

        /// <summary>Special secret processing</summary>
        DS_REPADD_SELECT_SECRETS = unchecked(0x00001000),

        /// <summary>Non GC RO Replica</summary>
        DS_REPADD_NONGC_RO_REPLICA = unchecked(0x01000000),
    }
}
