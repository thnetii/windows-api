using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1005"/> structure contains a privilege level to assign to a user network account. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370965.aspx">USER_INFO_1005 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1005
    {
        /// <summary>
        /// Specifies a value that indicates the level of privilege to assign for the user account specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. For more information about user and group account rights, see <a href="https://msdn.microsoft.com/en-us/library/aa379306.aspx">Privileges</a>. 
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USER_PRIVILEGE_LEVEL usri1005_priv;
    }
}
