using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_REPLICAPOINTER"/> structure is an ADSI representation of the <strong>Replica Pointer</strong> attribute syntax.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0012">__MIDL___MIDL_itf_ads_0000_0000_0012 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_REPLICAPOINTER
    {
        /// <summary>
        /// Pointer to a null-terminated Unicode string that contains the name of the name server that holds the replica.
        /// </summary>
        public IntPtr pwzServerName;

        /// <summary>
        /// Gets a span over the string that contains the name of the name server that holds the replica.
        /// </summary>
        public Span<char> ServerName => pwzServerName.AsZeroTerminatedUnicodeSpan();

        /// <summary>
        /// Type of replica: master, secondary, or read-only.
        /// </summary>
        public int ReplicaTye;

        /// <summary>
        /// Replica identification number.
        /// </summary>
        public int ReplicaNumber;

        /// <summary>
        /// The number of existing replicas.
        /// </summary>
        public int Count;

        /// <summary>
        /// Pointer to a network address that is a likely reference to a node leading to the name server.
        /// </summary>
        public IntPtr pReplicaAddressHints;

        /// <summary>
        /// A reference to a network address that is a likely reference to a node leading to the name server.
        /// </summary>
        public ref ADS_NETADDRESS ReplicaAddressHints =>
            ref pReplicaAddressHints.AsRefStruct<ADS_NETADDRESS>();
    }
}
