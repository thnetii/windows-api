using System.Runtime.InteropServices;

namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_OBJ_META_DATA"/> structure contains an array of <see cref="DS_REPL_ATTR_META_DATA"/> structures. These structures contain replication state data for past and present attributes for a given object. The replication state data is returned from the <see cref="DsReplicaGetInfo"/> and <see cref="DsReplicaGetInfo2"/> functions. The metadata records data about the last modification of a given object attribute.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_obj_meta_data">_DS_REPL_OBJ_META_DATA structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_ATTR_META_DATA"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_OBJ_META_DATA
    {
        /// <summary>Contains the number of elements in the <see cref="rgMetaData"/> array.</summary>
        public int cNumEntries;

        /// <summary />
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public DS_REPL_ATTR_META_DATA[] rgMetaData;
    }
}
