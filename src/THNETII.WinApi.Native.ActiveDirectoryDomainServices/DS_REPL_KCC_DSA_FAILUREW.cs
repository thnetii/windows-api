using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_KCC_DSA_FAILUREW"/> structure contains replication state data about a specific inbound replication partner, as returned by the <see cref="DsReplicaGetInfo"/> and <see cref="DsReplicaGetInfo2"/> function. This state data is compiled and used by the Knowledge Consistency Checker (KCC) to decide when alternate replication routes must be added to account for unreachable servers.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-_ds_repl_kcc_dsa_failurew">DS_REPL_KCC_DSA_FAILUREW structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_KCC_DSA_FAILURESW"/>
    /// <seealso cref="DsReplicaGetInfo"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    /// <seealso cref="FILETIME"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_KCC_DSA_FAILUREW
    {
        /// <summary>
        /// <see cref="string"/> that contains the distinguished name of the directory system agent object in the directory that corresponds to the source server.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszDsaDN;

        /// <summary>
        /// Contains the <strong>objectGuid</strong> of the directory system agent object represented by the <see cref="pszDsaDN"/> member.
        /// </summary>
        public Guid uuidDsaObjGuid;

        /// <summary>
        /// Contains a <see cref="FILETIME"/> structure which the contents of depends on the value passed for the <em>InfoType</em> parameter when <see cref="DsReplicaGetInfo"/> or <see cref="DsReplicaGetInfo2"/> function was called.
        /// <list type="table">
        /// <item>
        /// <term><see cref="DS_REPL_INFO_KCC_DSA_CONNECT_FAILURES"/></term>
        /// <description>Contains the date and time that the first failure occurred when replicating from the source server.</description>
        /// </item>
        /// <item>
        /// <term><see cref="DS_REPL_INFO_KCC_DSA_LINK_FAILURES"/></term>
        /// <description>Contains the date and time of the last successful replication.</description>
        /// </item>
        /// </list>
        /// </summary>
        public FILETIME ftimeFirstFailure;

        /// <summary>
        /// Contains the number of consecutive failures since the last successful replication.
        /// </summary>
        public int cNumFailures;

        /// <summary>
        /// Contains the error code associated with the most recent failure, or <see cref="ERROR_SUCCESS"/> if the specific error is unavailable.
        /// </summary>
        public int dwLastResult;
    }
}
