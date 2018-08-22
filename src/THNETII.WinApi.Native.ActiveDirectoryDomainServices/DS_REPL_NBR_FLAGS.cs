using System;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Bit values for the <see cref="DS_REPL_NEIGHBORW.dwReplicaFlags"/> field of the <see cref="DS_REPL_NEIGHBORW"/> structure.
    /// Also used for the <em>ulReplicaFlags</em> argument to <see cref="DsReplicaModify"/>
    /// </summary>
    [Flags]
    public enum DS_REPL_NBR_FLAGS : int
    {
        /// <summary>
        /// The local copy of the naming context is writable.
        /// </summary>
        DS_REPL_NBR_WRITEABLE = unchecked((int)0x00000010),
        /// <summary>
        /// Replication of this naming context from this source is attempted when the destination server is booted. This normally only applies to intra-site neighbors.
        /// </summary>
        DS_REPL_NBR_SYNC_ON_STARTUP = unchecked((int)0x00000020),
        /// <summary>
        /// Perform replication on a schedule. This flag is normally set unless the schedule for this naming context and source is "never", that is, the empty schedule.
        /// </summary>
        DS_REPL_NBR_DO_SCHEDULED_SYNCS = unchecked((int)0x00000040),
        /// <summary>
        /// Perform replication indirectly through the Inter-Site Messaging Service. This flag is set only when replicating over SMTP. This flag is not set when replicating over inter-site RPC/IP.
        /// </summary>
        DS_REPL_NBR_USE_ASYNC_INTERSITE_TRANSPORT = unchecked((int)0x00000080),
        /// <summary>
        /// If set, indicates that when inbound replication is complete, the destination server must tell the source server to synchronize in the reverse direction. This feature is used in dial-up scenarios where only one of the two servers can initiate a dial-up connection. For example, this option would be used in a corporate headquarters and branch office, where the branch office connects to the corporate headquarters over the Internet by means of a dial-up ISP connection.
        /// </summary>
        DS_REPL_NBR_TWO_WAY_SYNC = unchecked((int)0x00000200),
        DS_REPL_NBR_NONGC_RO_REPLICA = unchecked((int)0x00000400),
                              /// <summary>
                              /// This neighbor is in a state where it returns parent objects before children objects. It goes into this state after it receives a child object before its parent.
                              /// </summary>
        DS_REPL_NBR_RETURN_OBJECT_PARENTS = unchecked((int)0x00000800),
        DS_REPL_NBR_SELECT_SECRETS = unchecked((int)0x00001000),
        /// <summary>
        /// The destination server is performing a full synchronization from the source server. Full synchronizations do not use vectors that create updates (<see cref="DS_REPL_CURSORS"/>) for filtering updates. Full synchronizations are not used as a part of the normal replication protocol.
        /// </summary>
        DS_REPL_NBR_FULL_SYNC_IN_PROGRESS = unchecked((int)0x00010000),
        /// <summary>
        /// The last packet from the source indicated a modification of an object that the destination server has not yet created. The next packet to be requested instructs the source server to put all attributes of the modified object into the packet.
        /// </summary>
        DS_REPL_NBR_FULL_SYNC_NEXT_PACKET = unchecked((int)0x00020000),
        DS_REPL_NBR_GCSPN = unchecked((int)0x00100000),
        /// <summary>
        /// A synchronization has never been successfully completed from this source.
        /// </summary>
        DS_REPL_NBR_NEVER_SYNCED = unchecked((int)0x00200000),
        /// <summary>
        /// The replication engine has temporarily stopped processing this neighbor in order to service another higher-priority neighbor, either for this partition or for another partition. The replication engine will resume processing this neighbor after the higher-priority work is completed.
        /// </summary>
        DS_REPL_NBR_PREEMPTED = unchecked((int)0x01000000),
        /// <summary>
        /// This neighbor is set to disable notification-based synchronization. Within a site, domain controllers synchronize with each other based on notifications when changes occur. This setting prevents this neighbor from performing a synchronization triggered by a notification. The neighbor will still do synchronization based on its schedule or in response to manually requested synchronization.
        /// </summary>
        DS_REPL_NBR_IGNORE_CHANGE_NOTIFICATIONS = unchecked((int)0x04000000),
        /// <summary>
        /// This neighbor is set to not perform synchronization based on its schedule. The only way this neighbor will perform synchronization is in response to change notifications or to manually requested synchronization.
        /// </summary>
        DS_REPL_NBR_DISABLE_SCHEDULED_SYNC = unchecked((int)0x08000000),
        /// <summary>
        /// Changes received from this source are to be compressed. This is normally set if, and only if, the source server is in a different site.
        /// </summary>
        DS_REPL_NBR_COMPRESS_CHANGES = unchecked((int)0x10000000),
        /// <summary>
        /// No change notifications should be received from this source. This is normally set if, and only if, the source server is in a different site.
        /// </summary>
        DS_REPL_NBR_NO_CHANGE_NOTIFICATIONS = unchecked((int)0x20000000),
        /// <summary>
        /// This neighbor is in a state where it is rebuilding the contents of this replica because of a change in the partial attribute set.
        /// </summary>
        DS_REPL_NBR_PARTIAL_ATTRIBUTE_SET = unchecked((int)0x40000000),

        /// <summary>
        /// This is the mask of replica flags that may be changed on the <see cref="DsReplicaModify"/>
        /// call using the <em>ulReplicaFlags</em> parameter. The other flags are protected
        /// system flags.  The previous values of the system flags must be read in
        /// advance and merged into the <em>ulReplicaFlags</em> parameter unchanged.
        /// </summary>
        DS_REPL_NBR_MODIFIABLE_MASK =
               DS_REPL_NBR_SYNC_ON_STARTUP |
               DS_REPL_NBR_DO_SCHEDULED_SYNCS |
               DS_REPL_NBR_TWO_WAY_SYNC |
               DS_REPL_NBR_IGNORE_CHANGE_NOTIFICATIONS |
               DS_REPL_NBR_DISABLE_SCHEDULED_SYNC |
               DS_REPL_NBR_COMPRESS_CHANGES |
               DS_REPL_NBR_NO_CHANGE_NOTIFICATIONS
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
