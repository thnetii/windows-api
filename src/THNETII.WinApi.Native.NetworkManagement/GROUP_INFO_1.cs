using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="GROUP_INFO_1"/> structure contains a global group name and a comment to associate with the group.
    /// </summary>
    /// <remarks>
    /// User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370270.aspx">GROUP_INFO_1 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetGroupAdd"/>
    /// <seealso cref="NetGroupEnum"/>
    /// <seealso cref="NetGroupGetInfo"/>
    /// <seealso cref="NetGroupSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class GROUP_INFO_1
    {
        /// <summary>Multipurpose comment length</summary>
        public const int MAXCOMMENTSZ = 256;

        /// <summary>
        /// <para>A Unicode character string that specifies the name of the global group. For more information, see the following Remarks section. </para>
        /// <para>When you call the <see cref="NetGroupSetInfo"/> function this member is ignored.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string grpi1_name;
        /// <summary>
        /// A Unicode character string that specifies a remark associated with the global group. This member can be a null string. The comment can contain <see cref="MAXCOMMENTSZ"/> characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string grpi1_comment;
    }
}
