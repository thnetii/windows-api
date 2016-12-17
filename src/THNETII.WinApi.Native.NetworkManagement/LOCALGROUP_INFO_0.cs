using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="LOCALGROUP_INFO_0"/> structure contains a local group name.
    /// </summary>
    /// <remarks>
    /// <para>When you call the <see cref="NetLocalGroupAdd"/> function, this member specifies the name of a new local group. When you call the <see cref="NetLocalGroupSetInfo"/> function, this member specifies the new name of an existing local group.</para>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370275.aspx">LOCALGROUP_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetLocalGroupAdd"/>
    /// <seealso cref="NetLocalGroupEnum"/>
    /// <seealso cref="NetLocalGroupSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class LOCALGROUP_INFO_0
    {
        /// <summary>
        /// A Unicode string that specifies a local group name. For more information, see the Remarks section.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lgrpi0_name;
    }
}
