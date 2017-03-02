using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="WKSTA_USER_INFO_1"/> structure contains user information as it pertains to a specific workstation. The information includes the name of the current user and the domains accessed by the workstation.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371413.aspx">WKSTA_USER_INFO_1 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetWkstaUserAdd"/>
    /// <seealso cref="NetWkstaUserGetInfo"/>
    /// <seealso cref="NetWkstaUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class WKSTA_USER_INFO_1
    {
        /// <summary>
        /// Specifies the name of the user currently logged on to the workstation.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wkui1_username;
        /// <summary>
        /// Specifies the name of the domain in which the user is currently logged on.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wkui1_logon_domain;
        /// <summary>
        /// Specifies the list of operating system domains browsed by the workstation. The domain names are separated by blanks.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wkui1_oth_domains;
        /// <summary>
        /// Specifies the name of the server that authenticated the user.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wkui1_logon_server;
    }
}
