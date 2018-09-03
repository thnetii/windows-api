using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_OBJ_META_DATA_2"/> structure contains an array of <see cref="DS_REPL_ATTR_META_DATA_2"/> structures, which in turn contain replication state data for the attributes (past and present) for a given object, as returned by the <see cref="DsReplicaGetInfo2"/> function. This structure is an enhanced version of the <see cref="DS_REPL_OBJ_META_DATA"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_obj_meta_data_2">_DS_REPL_OBJ_META_DATA_2 structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_ATTR_META_DATA_2"/>
    /// <seealso cref="DS_REPL_OBJ_META_DATA"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_OBJ_META_DATA_2
    {
        /// <summary>
        /// Contains the number of elements in the <see cref="rgMetaData"/> array.
        /// </summary>
        public int cNumEntries;

        /// <summary>
        /// Not used.
        /// </summary>
        public int dwReserved;

        /// <summary/>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public DS_REPL_ATTR_META_DATA_2[] rgMetaData;
    }
}
