using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="GROUP_USERS_INFO_0"/> structure contains global group member information.
    /// </summary>
    /// <remarks>
    /// <para>If you are calling the <see cref="NetGroupGetUsers"/> function or the <see cref="NetGroupSetUsers"/> function, the <see cref="grui0_name"/> member contains the name of a user that is a member of the specified group.</para>
    /// <para>If you are calling the <see cref="NetUserGetGroups"/> function or the <see cref="NetUserSetGroups"/> function, the <see cref="grui0_name"/> member contains the name of a global group to which the specified user belongs. </para>
    /// <para>User account names are limited to 20 characters and group names are limited to 256 characters. In addition, account names cannot be terminated by a period and they cannot include commas or any of the following printable characters: ", /, \, [, ], :, |, &lt;, &gt;, +, =, ;, ?, *. Names also cannot include characters in the range 1-31, which are nonprintable.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370273.aspx">GROUP_USERS_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="GROUP_USERS_INFO_1"/>
    /// <seealso cref="NetGroupGetUsers"/>
    /// <seealso cref="NetGroupSetUsers"/>
    /// <seealso cref="NetUserGetGroups"/>
    /// <seealso cref="NetUserGetInfo"/>
    /// <seealso cref="NetUserSetGroups"/>
    [StructLayout(LayoutKind.Sequential)]
    public class GROUP_USERS_INFO_0
    {
        /// <summary>
        /// A string that specifies a name. For more information, see the type's Remarks section.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string grui0_name;
    }
}
