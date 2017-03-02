using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="WKSTA_USER_INFO_1101"/> structure contains information about the domains accessed by a workstation.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371410.aspx">WKSTA_USER_INFO_1101 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetWkstaUserGetInfo"/>
    /// <seealso cref="NetWkstaUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class WKSTA_USER_INFO_1101
    {
        /// <summary>
        /// Specifies the list of operating system domains browsed by the workstation. The domain names are separated by blanks.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wkui1101_oth_domains;
    }
}
