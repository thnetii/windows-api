using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_ATTR_META_DATA"/> structure is used with the <see cref="DsReplicaGetInfo"/> and <see cref="DsReplicaGetInfo2"/> functions to contain replication state data for an object attribute.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_attr_meta_data">DS_REPL_ATTR_META_DATA structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_OBJ_META_DATA"/>
    /// <seealso cref="DsReplicaGetInfo"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_ATTR_META_DATA
    {
        /// <summary>
        /// <see cref="string"/> that contains the LDAP display name of the attribute corresponding to this metadata.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszAttributeName;

        /// <summary>
        /// Contains the version of this attribute. Each originating modification of the attribute increases this value by one. Replication of a modification does not affect the version.
        /// </summary>
        public int dwVersion;

        /// <summary>
        /// Contains the time at which the last originating change was made to this attribute. Replication of the change does not affect this value.
        /// </summary>
        public FILETIME ftimeLastOriginatingChange;

        /// <summary>
        /// Contains the invocation identification of the server on which the last change was made to this attribute. Replication of the change does not affect this value.
        /// </summary>
        public Guid uuidLastOriginatingDsaInvocationID;

        /// <summary>
        /// Contains the update sequence number (USN) on the originating server at which the last change to this attribute was made. Replication of the change does not affect this value.
        /// </summary>
        public long usnOriginatingChange; // in the originating DSA's USN space

        /// <summary>
        /// Contains the update sequence number (USN) on the destination server (the server from which the <see cref="DsReplicaGetInfo"/> function retrieved the metadata) at which the last change to this attribute was applied. This value typically is different on all servers.
        /// </summary>
        public long usnLocalChange;       // in the local DSA's USN space
    }
}
