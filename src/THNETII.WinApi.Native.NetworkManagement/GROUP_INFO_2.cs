using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="GROUP_INFO_2"/> structure contains information about a global group, including name, identifier, and resource attributes.
    /// <para>It is recommended that you use the <see cref="GROUP_INFO_3"/> structure instead.</para>
    /// </summary>
    /// <remarks>
    /// User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370271.aspx">GROUP_INFO_2 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetGroupAdd"/>
    /// <seealso cref="NetGroupEnum"/>
    /// <seealso cref="NetGroupGetInfo"/>
    /// <seealso cref="NetGroupSetInfo"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    [StructLayout(LayoutKind.Sequential)]
    public class GROUP_INFO_2
    {
        /// <summary>
        /// <para>A Unicode character string that specifies the name of the global group. For more information, see the following Remarks section. </para>
        /// <para>When you call the <see cref="NetGroupSetInfo"/> function this member is ignored.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string grpi2_name;
        /// <summary>
        /// A Unicode character string that specifies a remark associated with the global group. This member can be a null string. The comment can contain <see cref="MAXCOMMENTSZ"/> characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string grpi2_comment;
        /// <summary>
        /// The relative identifier (RID) of the global group. The <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member. For more information about RIDs, see <a href="https://msdn.microsoft.com/en-us/library/aa379597.aspx">SID Components</a>.
        /// </summary>
        public int grpi2_group_id;
        /// <summary>
        /// These attributes are hard-coded to <see cref="SE_GROUP_MANDATORY"/>, <see cref="SE_GROUP_ENABLED"/>, and <see cref="SE_GROUP_ENABLED_BY_DEFAULT"/>. For more information, see <see cref="TOKEN_GROUPS"/>. 
        /// </summary>
        public int grpi2_attributes;
    }
}
