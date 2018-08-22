using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_PENDING_OPSW"/> structure contains an array of <see cref="DS_REPL_OPW"/> structures, which in turn describe the replication tasks currently executing and queued to execute, as returned by the <see cref="DsReplicaGetInfo"/> and <see cref="DsReplicaGetInfo2"/> functions. The entries in the queue are processed in priority order, and the first entry is the one currently being executed.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_pending_opsw">DS_REPL_PENDING_OPSW structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_OPW"/>
    /// <seealso cref="DsReplicaGetInfo"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_PENDING_OPSW
    {
        /// <summary>
        /// Contains a <see cref="FILETIME"/> structure that contains the date and time at which the first operation in the queue began executing.
        /// </summary>
        public FILETIME ftimeCurrentOpStarted;

        /// <summary>
        /// Contains the number of elements in the <see cref="rgPendingOp"/> array.
        /// </summary>
        public int cNumPendingOps;

        /// <summary />
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public DS_REPL_OPW[] rgPendingOp;
    }
}
