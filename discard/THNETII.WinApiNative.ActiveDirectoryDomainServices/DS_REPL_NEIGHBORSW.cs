using System.Runtime.InteropServices;

namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_NEIGHBORSW"/> structure is used with the <see cref="DsReplicaGetInfo"/> and <see cref="DsReplicaGetInfo2"/> functions to provide inbound replication state data for naming context and source server pairs.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_neighborsw">_DS_REPL_NEIGHBORSW structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_NEIGHBORW"/>
    /// <seealso cref="DsReplicaGetInfo"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_NEIGHBORSW
    {
        /// <summary>
        /// Contains the number of elements in the <see cref="rgNeighbor"/> array.
        /// </summary>
        public int cNumNeighbors;

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public int dwReserved;

        /// <summary/>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public DS_REPL_NEIGHBORW[] rgNeighbor;
    }
}
