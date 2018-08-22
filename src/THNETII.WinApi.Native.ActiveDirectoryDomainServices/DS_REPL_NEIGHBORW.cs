using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_NEIGHBORW"/> structure contains inbound replication state data for a particular naming context and source server pair, as returned by the <see cref="DsReplicaGetInfo"/> and <see cref="DsReplicaGetInfo2"/> functions.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_neighborw">_DS_REPL_NEIGHBORW structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_NEIGHBORSW"/>
    /// <seealso cref="DsReplicaGetInfo"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    /// <seealso cref="FILETIME"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_NEIGHBORW
    {
        /// <summary>
        /// <see cref="string"/> that contains the naming context to which this replication state data pertains. Each naming context is replicated independently and has different associated neighbor data, even if the naming contexts are replicated from the same source server.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszNamingContext;

        /// <summary>
        /// <see cref="string"/> that contains the distinguished name of the directory service agent corresponding to the source server to which this replication state data pertains. Each source server has different associated neighbor data.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszSourceDsaDN;

        /// <summary>
        /// <see cref="string"/> that contains the transport-specific network address of the source server. That is, a directory name service name for RPC/IP replication, or an SMTP address for an SMTP replication.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszSourceDsaAddress;

        /// <summary>
        /// <see cref="string"/> that contains the distinguished name of the <strong>interSiteTransport</strong> object that corresponds to the transport over which replication is performed. This member contains <c>null</c> for RPC/IP replication.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszAsyncIntersiteTransportDN;

        /// <summary>
        /// Contains a set of flags that specify attributes and options for the replication data. This can be zero or a combination of one or more of the flag values defined in the <see cref="DS_REPL_NBR_FLAGS"/> type.
        /// </summary>
        public DS_REPL_NBR_FLAGS dwReplicaFlags;

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public int dwReserved;

        /// <summary>
        /// Contains the <strong>objectGuid</strong> of the naming context corresponding to <see cref="pszNamingContext"/>.
        /// </summary>
        public Guid uuidNamingContextObjGuid;

        /// <summary>
        /// Contains the <strong>objectGuid</strong> of the <strong>nTDSDSA</strong> object corresponding to <see cref="pszSourceDsaDN"/>.
        /// </summary>
        public Guid uuidSourceDsaObjGuid;

        /// <summary>
        /// Contains the invocation identifier used by the source server as of the last replication attempt.
        /// </summary>
        public Guid uuidSourceDsaInvocationID;

        /// <summary>
        /// Contains the <strong>objectGuid</strong> of the inter-site transport object corresponding to <see cref="pszAsyncIntersiteTransportDN"/>.
        /// </summary>
        public Guid uuidAsyncIntersiteTransportObjGuid;

        /// <summary>
        /// Contains the update sequence number of the last object update received.
        /// </summary>
        public long usnLastObjChangeSynced;

        /// <summary>
        /// Contains the <see cref="usnLastObjChangeSynced"/> value at the end of the last complete, successful replication cycle, or <c>0</c> (zero) if none. Attributes at the source last updated at a update sequence number less than or equal to this value have already been received and applied by the destination.
        /// </summary>
        public long usnAttributeFilter;

        /// <summary>
        /// Contains a <see cref="FILETIME"/> structure that contains the date and time the last successful replication cycle was completed from this source. All members of this structure are zero if the replication cycle has never been completed.
        /// </summary>
        public FILETIME ftimeLastSyncSuccess;

        /// <summary>
        /// Contains a <see cref="FILETIME"/> structure that contains the date and time of the last replication attempt from this source. All members of this structure are zero if the replication has never been attempted.
        /// </summary>
        public FILETIME ftimeLastSyncAttempt;

        /// <summary>
        /// Contains an error code associated with the last replication attempt from this source. Contains <see cref="ERROR_SUCCESS"/> if the last attempt succeeded.
        /// </summary>
        public int dwLastSyncResult;

        /// <summary>
        /// Contains the number of failed replication attempts from this source since the last successful replication attempt - or since the source was added as a neighbor, if no previous attempt was successful.
        /// </summary>
        public int cNumConsecutiveSyncFailures;
    }
}
