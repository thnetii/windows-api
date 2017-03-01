using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_20"/> structure contains information about a user account, including the account name, the user's full name, a comment associated with the account, and the user's relative ID (RID).
    /// <para><note>The <see cref="USER_INFO_23"/> structure supersedes the <see cref="USER_INFO_20"/> structure. It is recommended that applications use the <see cref="USER_INFO_23"/> structure instead of the <see cref="USER_INFO_20"/> structure.</note></para>
    /// </summary>
    /// <remarks>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371123.aspx">USER_INFO_20 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserAdd"/>
    /// <seealso cref="NetUserEnum"/>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_20
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 00, 00, 00, DateTimeKind.Utc);

        /// <summary>
        /// A string that specifies the name of the user account. Calls to the <see cref="NetUserSetInfo"/> function ignore this member. For more information, see the type's Remarks section.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri20_name;
        /// <summary>
        /// A string that contains the full name of the user. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri20_full_name;
        /// <summary>
        /// A string that contains a comment to associate with the user account. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri20_comment;
        /// <summary>
        /// <para>Note that setting user account control flags may require certain privileges and control access rights. For more information, see the Remarks section of the <see cref="NetUserSetInfo"/> function.</para>
        /// <para>Only one account type value can be set. You cannot change the account type using the <see cref="NetUserSetInfo"/> function.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USER_FLAGS usri20_flags;
        /// <summary>
        /// The relative ID (RID) of the user. The RID is determined by the Security Account Manager (SAM) when the user is created. It uniquely defines the user account to SAM within the domain. The <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member. For more information about RIDs, see <a href="https://msdn.microsoft.com/en-us/library/aa379597.aspx">SID Components</a>.
        /// </summary>
        public int usri20_user_id;
    }
}
