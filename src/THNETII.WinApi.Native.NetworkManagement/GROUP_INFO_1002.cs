using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="GROUP_INFO_1002"/> structure contains a comment to associate with a global group.
    /// </summary>
    /// <remarks>
    /// User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370268.aspx">GROUP_INFO_1002 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetGroupSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class GROUP_INFO_1002
    {
        /// <summary>
        /// A Unicode character string that specifies a remark associated with the global group. This member can be a null string. The comment can contain <see cref="MAXCOMMENTSZ"/> characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string grpi1002_comment;
    }
}
