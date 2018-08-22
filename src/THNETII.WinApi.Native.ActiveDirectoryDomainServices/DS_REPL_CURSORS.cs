using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_CURSORS"/> structure is used with the <see cref="DsReplicaGetInfo"/> and <see cref="DsReplicaGetInfo2"/> function to provide replication state data with respect to all replicas of a given naming context.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_cursors">_DS_REPL_CURSORS structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_CURSOR"/>
    /// <seealso cref="DsReplicaGetInfo"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_CURSORS
    {
        /// <summary>
        /// Contains the number of elements in the <see cref="rgCursor"/> array.
        /// </summary>
        public int cNumCursors;

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public int dwReserved;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public DS_REPL_CURSOR[] rgCursor;
    }
}
