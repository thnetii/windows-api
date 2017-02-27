using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_100"/> structure contains information about the specified server, including the name and platform.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370897.aspx">SERVER_INFO_100 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerDiskEnum"/>
    /// <seealso cref="NetServerEnum"/>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_100
    {
        /// <summary>
        /// The information level to use for platform-specific information.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public PLATFORM_ID sv100_platform_id;
        /// <summary>
        /// A string that specifies the name of the server.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv100_name;
    }
}
