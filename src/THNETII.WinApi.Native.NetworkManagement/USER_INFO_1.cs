using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.USER_PRIVILEGE_LEVEL;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1"/> structure contains information about a user account, including account name, password data, privilege level, and the path to the user's home directory.
    /// </summary>
    /// <remarks>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: &quot;, /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371109.aspx">USER_INFO_1 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserAdd"/>
    /// <seealso cref="NetUserEnum"/>
    /// <seealso cref="NetUserSetInfo"/>
    /// <seealso cref="NetUserGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1
    {
        /// <summary>
        /// A string that specifies the name of the user account. For the <see cref="NetUserSetInfo"/> function, this member is ignored. For more information, see the type's Remarks section.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1_name;
        /// <summary>
        /// A string that specifies the password of the user indicated by the <see cref="usri1_name"/> member. The length cannot exceed <see cref="PWLEN"/> bytes. The <see cref="NetUserEnum"/> and <see cref="NetUserGetInfo"/> functions return <c>null</c> to maintain password security. 
        /// <para>By convention, the length of passwords is limited to <see cref="LM20_PWLEN"/> characters.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1_password;
        /// <summary>
        /// The number of seconds that have elapsed since the <see cref="usri1_password"/> member was last changed. The <see cref="NetUserAdd"/> and <see cref="NetUserSetInfo"/> functions ignore this member.
        /// </summary>
        public int usri1_password_age;
        /// <summary>
        /// The level of privilege assigned to the <see cref="usri1_name"/> member. When you call the <see cref="NetUserAdd"/> function, this member must be <see cref="USER_PRIV_USER"/>. When you call the <see cref="NetUserSetInfo"/> function, this member must be the value returned by the <see cref="NetUserGetInfo"/> function or the <see cref="NetUserEnum"/> function. For more information about user and group account rights, see <a href="https://msdn.microsoft.com/en-us/library/aa379306.aspx">Privileges</a>. 
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USER_PRIVILEGE_LEVEL usri1_priv;
        /// <summary>
        /// A string specifying the path of the home directory for the user specified in the <see cref="usri1_name"/> member. The string can be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1_home_dir;
        /// <summary>
        /// A string that contains a comment to associate with the user account. This string can be a <c>null</c> string, or it can have any number of characters.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1_comment;
        /// <summary>
        /// <para>Note that setting user account control flags may require certain privileges and control access rights. For more information, see the Remarks section of the <see cref="NetUserSetInfo"/> function.</para>
        /// <para>Only one account type value can be set. You cannot change the account type using the <see cref="NetUserSetInfo"/> function.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USER_FLAGS usri1_flags;
        /// <summary>
        /// A string specifying the path for the user's logon script file. The script file can be a .CMD file, an .EXE file, or a .BAT file. The string can also be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1_script_path;
    }
}
