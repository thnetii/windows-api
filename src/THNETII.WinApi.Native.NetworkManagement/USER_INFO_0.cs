using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_0"/> structure contains a user account name.
    /// </summary>
    /// <remarks>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370961.aspx">USER_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUseDel"/>
    /// <seealso cref="NetUserEnum"/>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_0
    {
        /// <summary>
        /// A string that specifies the name of the user account. For the <see cref="NetUserSetInfo"/> function, this member specifies the name of the user.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri0_name;
    }
}
