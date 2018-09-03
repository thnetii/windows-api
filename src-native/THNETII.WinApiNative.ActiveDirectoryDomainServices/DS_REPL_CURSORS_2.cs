using System.Runtime.InteropServices;

namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_CURSORS_2"/> structure is used with the <see cref="DsReplicaGetInfo2"/> function to provide replication state data with respect to all replicas of a given naming context.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_cursors_2">_DS_REPL_CURSORS_2 structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_CURSOR_2"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_CURSORS_2
    {
        /// <summary>
        /// Contains the number of elements in the <see cref="rgCursor"/> array.
        /// </summary>
        public int cNumCursors;

        /// <summary>
        /// Contains the zero-based index of the next entry to retrieve if more entries are available. This value is passed for the <em>dwEnumerationContext</em> parameter in the next call to <see cref="DsReplicaGetInfo2"/> to retrieve the next block of entries. If no more entries are available, this member contains <c>-1</c>.
        /// </summary>
        public int dwEnumerationContext;

        /// <summary />
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public DS_REPL_CURSOR_2[] rgCursor;
    }
}
