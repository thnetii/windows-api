using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="LOCALGROUP_MEMBERS_INFO_3"/> structure contains the account name and domain name associated with a local group member.
    /// </summary>
    /// <remarks>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370281.aspx">LOCALGROUP_MEMBERS_INFO_3 structure</a></para>
    /// </remarks>
    /// <seealso cref="LOCALGROUP_MEMBERS_INFO_0"/>
    /// <seealso cref="LOCALGROUP_MEMBERS_INFO_1"/>
    /// <seealso cref="LOCALGROUP_MEMBERS_INFO_2"/>
    /// <seealso cref="NetLocalGroupAddMembers"/>
    /// <seealso cref="NetLocalGroupDelMembers"/>
    /// <seealso cref="NetLocalGroupGetMembers"/>
    /// <seealso cref="NetLocalGroupSetMembers"/>
    [StructLayout(LayoutKind.Sequential)]
    public class LOCALGROUP_MEMBERS_INFO_3
    {
        /// <summary>
        /// A Unicode string specifying the account name of the local group member prefixed by the domain name and the "\" separator character. For example: <c>&lt;DomainName&gt;\&lt;AccountName&gt;</c>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lgrmi3_domainandname;
    }
}
