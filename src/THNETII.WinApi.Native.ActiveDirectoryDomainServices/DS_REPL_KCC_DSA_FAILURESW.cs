using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_KCC_DSA_FAILURESW"/> structure contains an array of <see cref="DS_REPL_KCC_DSA_FAILUREW"/> structures, which in turn contain replication state data with respect to inbound replication partners, as returned by the <see cref="DsReplicaGetInfo"/> and <see cref="DsReplicaGetInfo2"/> functions.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_kcc_dsa_failuresw">DS_REPL_KCC_DSA_FAILURESW structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_KCC_DSA_FAILUREW"/>
    /// <seealso cref="DsReplicaGetInfo"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_KCC_DSA_FAILURESW
    {
        /// <summary>
        /// Contains the number of elements in the <see cref="rgMetaData"/> array.
        /// </summary>
        public int cNumEntries;

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public int dwReserved;

        /// <summary />
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public DS_REPL_KCC_DSA_FAILUREW[] rgDsaFailure;
    }
}
