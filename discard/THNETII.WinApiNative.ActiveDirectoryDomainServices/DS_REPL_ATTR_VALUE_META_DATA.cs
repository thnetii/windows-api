using System.Runtime.InteropServices;

namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPL_ATTR_VALUE_META_DATA"/> structure is used with the <see cref="DsReplicaGetInfo2"/> function to provide metadata for a collection of attribute values.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ns-ntdsapi-_ds_repl_attr_value_meta_data">_DS_REPL_ATTR_VALUE_META_DATA structure</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPL_VALUE_META_DATA"/>
    /// <seealso cref="DsReplicaGetInfo2"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DS_REPL_ATTR_VALUE_META_DATA
    {
        /// <summary>
        /// Contains the number of elements in the <see cref="rgMetaData"/> array.
        /// </summary>
        public int cNumEntries;

        /// <summary>
        /// Contains the zero-based index of the next entry to retrieve if more entries are available. This value is passed for the <em>dwEnumerationContext</em> parameter in the next call to <see cref="DsReplicaGetInfo2"/> to retrieve the next block of entries. If no more entries are available, this member contains <c>-1</c>.
        /// </summary>
        public int dwEnumerationContext;

        /// <summary />
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public DS_REPL_VALUE_META_DATA[] rgMetaData;
    }
}
