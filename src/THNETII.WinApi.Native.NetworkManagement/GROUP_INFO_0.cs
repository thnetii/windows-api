using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="GROUP_INFO_0"/> structure contains the name of a global group in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
    /// </summary>
    /// <remarks>
    /// User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370267.aspx">GROUP_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetGroupAdd"/>
    /// <seealso cref="NetGroupEnum"/>
    /// <seealso cref="NetGroupGetInfo"/>
    /// <seealso cref="NetGroupSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class GROUP_INFO_0
    {
        /// <summary>
        /// <para>A Unicode character string that specifies the name of the global group. For more information, see the following Remarks section. </para>
        /// <para>When you call the <see cref="NetGroupSetInfo"/> function this member specifies the new name of the global group.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string grpi0_name;
    }
}
