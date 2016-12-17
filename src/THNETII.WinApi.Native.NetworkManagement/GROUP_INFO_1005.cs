using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="GROUP_INFO_1005"/> structure contains the resource attributes associated with a global group.
    /// </summary>
    /// <remarks>
    /// User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370269.aspx">GROUP_INFO_1005 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetGroupSetInfo"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    [StructLayout(LayoutKind.Sequential)]
    public class GROUP_INFO_1005
    {
        /// <summary>
        /// These attributes are hard-coded to <see cref="SE_GROUP_MANDATORY"/>, <see cref="SE_GROUP_ENABLED"/>, and <see cref="SE_GROUP_ENABLED_BY_DEFAULT"/>. For more information, see <see cref="TOKEN_GROUPS"/>. 
        /// </summary>
        public int grpi1005_attributes;
    }
}
