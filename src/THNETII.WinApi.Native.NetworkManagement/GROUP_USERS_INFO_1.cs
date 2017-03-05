using Microsoft.Win32.WinApi.SecurityIdentity.Authorization;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.SE_GROUP_ATTRIBUTES;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="GROUP_USERS_INFO_1"/> structure contains global group member information.
    /// </summary>
    /// <remarks>
    /// <para>If you are calling the <see cref="NetGroupGetUsers"/> function or the <see cref="NetGroupSetUsers"/> function, the <see cref="grui1_name"/> member contains the name of a user that is a member of the specified group.</para>
    /// <para>If you are calling the <see cref="NetUserGetGroups"/> function or the <see cref="NetUserSetGroups"/> function, the <see cref="grui1_name"/> member contains the name of a global group to which the specified user belongs. </para>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
    /// <para>Windows Vista and later include an addition to the access control security mechanism of Windows that labels processes and other securable objects with an integrity level. Internet-facing programs are at higher risk for exploits than other programs because they download untrustworthy content from unknown sources. Running these programs with fewer permissions, or at a lower integrity level, than other programs reduces the ability of an exploit to modify the system or harm user data files. The <see cref="SE_GROUP_INTEGRITY"/> and <see cref="SE_GROUP_INTEGRITY_ENABLED"/> attributes of the <see cref="grui1_attributes"/> member are used for this purpose.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370274.aspx">GROUP_USERS_INFO_1 structure</a></para>
    /// </remarks>
    /// <seealso cref="GROUP_USERS_INFO_1"/>
    /// <seealso cref="NetGroupGetUsers"/>
    /// <seealso cref="NetGroupSetUsers"/>
    /// <seealso cref="NetUserGetInfo"/>
    /// <seealso cref="NetUserGetGroups"/>
    /// <seealso cref="NetUserSetGroups"/>
    [StructLayout(LayoutKind.Sequential)]
    public class GROUP_USERS_INFO_1
    {
        /// <summary>
        /// A string that specifies a name. For more information, see the type's Remarks section.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string grui1_name;
        /// <summary>
        /// A set of attributes for this entry. This member can be a combination of the security group attributes defined in the <see cref="SE_GROUP_ATTRIBUTES"/> enumeration type.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public SE_GROUP_ATTRIBUTES grui1_attributes;
    }
}
