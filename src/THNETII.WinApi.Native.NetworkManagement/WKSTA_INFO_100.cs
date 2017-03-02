using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="WKSTA_INFO_100"/> structure contains information about a workstation environment, including platform-specific information, the names of the domain and the local computer, and information concerning the operating system.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371402.aspx">WKSTA_INFO_100 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetWkstaGetInfo"/>
    /// <seealso cref="NetWkstaSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class WKSTA_INFO_100
    {
        /// <summary>
        /// The information level to use to retrieve platform-specific information. 
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public PLATFORM_ID wki100_platform_id;
        /// <summary>
        /// A string specifying the name of the local computer.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wki100_computername;
        /// <summary>
        /// A string specifying the name of the domain to which the computer belongs.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wki100_langroup;
        /// <summary>
        /// The major version number of the operating system running on the computer.
        /// </summary>
        public int wki100_ver_major;
        /// <summary>
        /// The minor version number of the operating system running on the computer.
        /// </summary>
        public int wki100_ver_minor;
    }
}
