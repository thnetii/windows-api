using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_OPW"/> structure describes a replication task currently executing or pending execution, as returned by the <see cref="DsReplicaGetInfo"/> or <see cref="DsReplicaGetInfo2"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-_ds_repl_opw">_DS_REPL_OPW structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_OP_TYPE"/>
    /// <seealso cref="DS_REPL_PENDING_OPSW"/>
    /// <seealso cref="DsReplicaAdd"/>
    /// <seealso cref="DsReplicaDel"/>
    /// <seealso cref="DsReplicaGetInfo"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    /// <seealso cref="DsReplicaModify"/>
    /// <seealso cref="DsReplicaSync"/>
    /// <seealso cref="DsReplicaUpdateRefs"/>
    /// <seealso cref="FILETIME"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_OPW
    {
        /// <summary>
        /// Contains a <see cref="FILETIME"/> structure that contains the date and time that this operation was added to the queue.
        /// </summary>
        public FILETIME ftimeEnqueued;

        /// <summary>
        /// Contains the operation identifier. This value is unique in the startup routine of every computer. When the computer is restarted, the identifiers are no longer unique.
        /// </summary>
        public uint ulSerialNumber;

        /// <summary>
        /// Contains the priority value of this operation. Tasks with a higher priority value are executed first. The priority is calculated by the server based on the type of operation and its parameters.
        /// </summary>
        public uint ulPriority;

        /// <summary>
        /// Contains one of the <see cref="DS_REPL_OP_TYPE"/> values that indicate the type of operation that this structure represents.
        /// </summary>
        public DS_REPL_OP_TYPE OpType;

        /// <summary>
        /// Zero or more bits, the interpretation of which depends on the <see cref="OpType"/>. For <see cref="DS_REPL_OP_TYPE_SYNC"/>, the bits should be interpreted as <see cref="DS_REPSYNC_FLAGS"/>. <see cref="DS_REPL_OP_TYPE_ADD"/>, <see cref="DS_REPL_OP_TYPE_DELETE"/>, <see cref="DS_REPL_OP_TYPE_MODIFY"/>, and <see cref="DS_REPL_OP_TYPE_UPDATE_REFS"/> use <see cref="DS_REPADD_FLAGS"/>, <see cref="DS_REPDEL_FLAGS"/>, <see cref="DS_REPMOD_FLAGS"/>, and <see cref="DS_REPUPD_FLAGS"/>. For more information and descriptions of these bits, see <see cref="DsReplicaSync"/>, <see cref="DsReplicaAdd"/>, <see cref="DsReplicaDel"/>, <see cref="DsReplicaModify"/>, and <see cref="DsReplicaUpdateRefs"/>.
        /// <para>
        /// Contains a set of flags that provides additional data about the operation. The contents of this member is determined by the contents of the OpType member.
        /// </para>
        /// </summary>
        public uint ulOptions;

        /// <summary>
        /// Contains zero or a combination of one or more of the <see cref="DS_REPSYNC_FLAGS"/> values as defined for the <em>Options</em> parameter in <see cref="DsReplicaSync"/>.
        /// </summary>
        public DS_REPSYNC_FLAGS syncOptions
        {
            get => (DS_REPSYNC_FLAGS)ulOptions;
            set => ulOptions = (uint)value;
        }

        /// <summary>
        /// Contains zero or a combination of one or more of the <see cref="DS_REPADD_FLAGS"/> values as defined for the <em>Options</em> parameter in <see cref="DsReplicaAdd"/>.
        /// </summary>
        public DS_REPADD_FLAGS addOptions
        {
            get => (DS_REPADD_FLAGS)ulOptions;
            set => ulOptions = (uint)value;
        }

        /// <summary>
        /// Contains zero or a combination of one or more of the <see cref="DS_REPDEL_FLAGS"/> values as defined for the <em>Options</em> parameter in <see cref="DsReplicaDel"/>.
        /// </summary>
        public DS_REPDEL_FLAGS delOptions
        {
            get => (DS_REPDEL_FLAGS)ulOptions;
            set => ulOptions = (uint)value;
        }

        /// <summary>
        /// Contains zero or a combination of one or more of the <see cref="DS_REPMOD_FLAGS"/> values as defined for the <em>Options</em> parameter in <see cref="DsReplicaModify"/>.
        /// </summary>
        public DS_REPMOD_FLAGS modOptions
        {
            get => (DS_REPMOD_FLAGS)ulOptions;
            set => ulOptions = (uint)value;
        }

        /// <summary>
        /// Contains zero or a combination of one or more of the <see cref="DS_REPUPD_FLAGS"/> values as defined for the <em>Options</em> parameter in <see cref="DsReplicaUpdateRefs"/>.
        /// </summary>
        public DS_REPUPD_FLAGS updOptions
        {
            get => (DS_REPUPD_FLAGS)ulOptions;
            set => ulOptions = (uint)value;
        }

        /// <summary>
        /// <see cref="string"/> that contains the distinguished name of the naming context associated with this operation. For example, the naming context to be synchronized for <see cref="DS_REPL_OP_TYPE_SYNC"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszNamingContext;

        /// <summary>
        /// <see cref="string"/> that contains the distinguished name of the directory system agent object associated with the remote server corresponding to this operation. For example, the server from which to request changes for <see cref="DS_REPL_OP_TYPE_SYNC"/>. This can be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszDsaDN;

        /// <summary>
        /// <see cref="string"/> that contains the transport-specific network address of the remote server associated with this operation. For example, the DNS or SMTP address of the server from which to request changes for <see cref="DS_REPL_OP_TYPE_SYNC"/>. This can be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszDsaAddress;

        /// <summary>
        /// Contains the <strong>objectGuid</strong> of the naming context identified by <see cref="pszNamingContext"/>.
        /// </summary>
        public Guid uuidNamingContextObjGuid;

        /// <summary>
        /// Contains the <strong>objectGuid</strong> of the directory system agent object identified by <see cref="pszDsaDN"/>.
        /// </summary>
        public Guid uuidDsaObjGuid;
    }
}
