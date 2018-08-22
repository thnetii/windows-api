using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_VALUE_META_DATA_2"/> structure is used with the <see cref="DS_REPL_ATTR_VALUE_META_DATA_2"/> structure to contain attribute value replication metadata.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_value_meta_data_2">_DS_REPL_VALUE_META_DATA_2 structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_ATTR_VALUE_META_DATA_2"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_VALUE_META_DATA_2
    {
        /// <summary>
        /// <see cref="string"/> that contains the LDAP display name of the attribute that corresponds to this metadata.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszAttributeName;

        /// <summary>
        /// <see cref="string"/> that contains the distinguished name of the object that this attribute belongs to.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszObjectDn;

        /// <summary>
        /// Contains the number of bytes in the memory location referred to by <see cref="pbData"/> and the <see cref="Span{T}.Length"/> of <see cref="spanData"/>.
        /// </summary>
        public int cbData;

        /// <summary />
        public IntPtr pbData;

        /// <summary />
        public Span<byte> spanData
        {
            get
            {
                if (pbData == IntPtr.Zero || cbData < 1)
                    return Span<byte>.Empty;
                unsafe { return new Span<byte>(pbData.ToPointer(), cbData); }
            }
        }

        /// <summary>
        /// Contains a <see cref="FILETIME"/> structure that contains the time this attribute was deleted.
        /// </summary>
        public FILETIME ftimeDeleted;

        /// <summary>
        /// Contains a <see cref="FILETIME"/> structure that contains the time this attribute was created.
        /// </summary>
        public FILETIME ftimeCreated;

        /// <summary>
        /// Contains the version of this attribute. Each originating modification of the attribute increases this value by one. Replication of a modification does not affect the version.
        /// </summary>
        public int dwVersion;

        /// <summary>
        /// Contains a <see cref="FILETIME"/> structure that contains the time at which the last originating change was made to this attribute. Replication of the change does not affect this value.
        /// </summary>
        public FILETIME ftimeLastOriginatingChange;

        /// <summary>
        /// Contains the invocation identifier of the server on which the last change was made to this attribute. Replication of the change does not affect this value.
        /// </summary>
        public Guid uuidLastOriginatingDsaInvocationID;

        /// <summary>
        /// Contains the update sequence number (USN) on the originating server at which the last change to this attribute was made. Replication of the change does not affect this value.
        /// </summary>
        public long usnOriginatingChange;

        /// <summary>
        /// Contains the update sequence number (USN) on the destination server, that is, the server from which the <see cref="DsReplicaGetInfo2"/> function retrieved the metadata, at which the last change to this attribute was applied. This value is typically different on all servers.
        /// </summary>
        public long usnLocalChange;

        /// <summary>
        /// <see cref="string"/> that contains the distinguished name of the directory system agent server that originated the last replication.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszLastOriginatingDsaDN;
    }
}
