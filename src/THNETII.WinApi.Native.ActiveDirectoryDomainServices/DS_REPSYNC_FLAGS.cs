using System;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// Replica Sync flags
    /// <para>
    /// These flag values are used both as input to <see cref="DsReplicaSync"/> and
    /// as output from <see cref="DsReplicaGetInfo"/>, <see cref="DS_REPL_PENDING_OPSW"/>, <see cref="DS_REPL_OPW.syncOptions"/>
    /// </para>
    /// </summary>
    [Flags]
    public enum DS_REPSYNC_FLAGS : uint
    {
        /// <summary>
        /// Perform this operation asynchronously.
        /// </summary>
        DS_REPSYNC_ASYNCHRONOUS_OPERATION = unchecked(0x00000001),

        /// <summary>
        /// Writeable replica.  Otherwise, read-only.
        /// </summary>
        DS_REPSYNC_WRITEABLE = unchecked(0x00000002),

        /// <summary>
        /// This is a periodic sync request as scheduled by the admin.
        /// </summary>
        DS_REPSYNC_PERIODIC = unchecked(0x00000004),

        /// <summary>
        /// Use inter-site messaging
        /// </summary>
        DS_REPSYNC_INTERSITE_MESSAGING = unchecked(0x00000008),

        /// <summary>
        /// Sync starting from scratch (i.e., at the first USN).
        /// </summary>
        DS_REPSYNC_FULL = unchecked(0x00000020),

        /// <summary>
        /// This is a notification of an update that was marked urgent.
        /// </summary>
        DS_REPSYNC_URGENT = unchecked(0x00000040),

        /// <summary>
        /// Don't discard this synchronization request, even if a similar
        /// sync is pending.
        /// </summary>
        DS_REPSYNC_NO_DISCARD = unchecked(0x00000080),

        /// <summary>
        /// Sync even if link is currently disabled.
        /// </summary>
        DS_REPSYNC_FORCE = unchecked(0x00000100),

        /// <summary>
        /// Causes the source DSA to check if a reps-to is present for the local DSA
        /// (aka the destination). If not, one is added.  This ensures that
        /// source sends change notifications.
        /// </summary>
        DS_REPSYNC_ADD_REFERENCE = unchecked(0x00000200),

        /// <summary>
        /// A sync from this source has never completed (e.g., a new source).
        /// </summary>
        DS_REPSYNC_NEVER_COMPLETED = unchecked(0x00000400),

        /// <summary>
        /// When this sync is complete, requests a sync in the opposite direction.
        /// </summary>
        DS_REPSYNC_TWO_WAY = unchecked(0x00000800),

        /// <summary>
        /// Do not request change notifications from this source.
        /// </summary>
        DS_REPSYNC_NEVER_NOTIFY = unchecked(0x00001000),

        /// <summary>
        /// Sync the NC from this source when the DSA is started.
        /// </summary>
        DS_REPSYNC_INITIAL = unchecked(0x00002000),

        /// <summary>
        /// Use compression when replicating.  Saves message size (e.g., network
        /// bandwidth) at the expense of extra CPU overhead at both the source and
        /// destination servers.
        /// </summary>
        DS_REPSYNC_USE_COMPRESSION = unchecked(0x00004000),

        /// <summary>
        /// Sync was abandoned for lack of updates (W2K, W2K3)
        /// </summary>
        DS_REPSYNC_ABANDONED = unchecked(0x00008000),

        /// <summary>
        /// Special secret processing
        /// </summary>
        DS_REPSYNC_SELECT_SECRETS = unchecked(0x00008000),

        /// <summary>
        /// Initial sync in progress
        /// </summary>
        DS_REPSYNC_INITIAL_IN_PROGRESS = unchecked(0x00010000),

        /// <summary>
        /// Partial Attribute Set sync in progress
        /// </summary>
        DS_REPSYNC_PARTIAL_ATTRIBUTE_SET = unchecked(0x00020000),

        /// <summary>
        /// Sync is being retried
        /// </summary>
        DS_REPSYNC_REQUEUE = unchecked(0x00040000),

        /// <summary>
        /// Sync is a notification request from a source
        /// </summary>
        DS_REPSYNC_NOTIFICATION = unchecked(0x00080000),

        /// <summary>
        /// Sync is a special form which requests to establish contact
        /// now and do the rest of the sync later
        /// </summary>
        DS_REPSYNC_ASYNCHRONOUS_REPLICA = unchecked(0x00100000),

        /// <summary>
        /// Request critical objects only
        /// </summary>
        DS_REPSYNC_CRITICAL = unchecked(0x00200000),

        /// <summary>
        /// A full synchronization is in progress
        /// </summary>
        DS_REPSYNC_FULL_IN_PROGRESS = unchecked(0x00400000),

        /// <summary>
        /// Synchronization request was previously preempted
        /// </summary>
        DS_REPSYNC_PREEMPTED = unchecked(0x00800000),

        /// <summary>
        /// Non GC readonly replica
        /// </summary>
        DS_REPSYNC_NONGC_RO_REPLICA = unchecked(0x01000000),
    }
}
