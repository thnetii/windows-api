using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_CURSOR_2"/> structure contains inbound replication state data with respect to all replicas of a given naming context, as returned by the <see cref="DsReplicaGetInfo2"/> function. This structure is an enhanced version of the <see cref="DS_REPL_CURSOR"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_cursor_2">_DS_REPL_CURSOR_2 structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_CURSOR"/>
    /// <seealso cref="DS_REPL_CURSORS_2"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    /// <seealso cref="FILETIME"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_CURSOR_2
    {
        /// <summary>
        /// Contains the invocation identifier of the originating server to which the <see cref="usnAttributeFilter"/> corresponds.
        /// </summary>
        public Guid uuidSourceDsaInvocationID;

        /// <summary>
        /// Contains the maximum update sequence number to which the destination server can indicate that it has recorded all changes originated by the given server at update sequence numbers less than, or equal to, this update sequence number. This is used to filter changes at replication source servers that the destination server has already applied.
        /// </summary>
        public long usnAttributeFilter;

        /// <summary>
        /// Contains a <see cref="FILETIME"/> structure that contains the date and time of the last successful synchronization operation.
        /// </summary>
        public FILETIME ftimeLastSyncSuccess;
    }
}
