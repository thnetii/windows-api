using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="WKSTA_USER_INFO_0"/> structure contains the name of the user on a specified workstation.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371409.aspx">WKSTA_USER_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetWkstaUserAdd"/>
    /// <seealso cref="NetWkstaUserGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class WKSTA_USER_INFO_0
    {
        /// <summary>
        /// Specifies the name of the user currently logged on to the workstation.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wkui0_username;
    }
}
