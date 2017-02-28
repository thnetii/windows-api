using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManServerConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_101"/> structure contains information about the specified server, including the name, platform, type of server, and associated software.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370903.aspx">SERVER_INFO_101 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerEnum"/>
    /// <seealso cref="NetServerGetInfo"/>
    /// <seealso cref="NetServerSetInfo"/>
    /// <seealso cref="NetShareGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_101
    {
        /// <summary>
        /// The information level to use for platform-specific information.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public PLATFORM_ID sv101_platform_id;
        /// <summary>
        /// A string that specifies the name of the server.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv101_name;
        /// <summary>
        /// The major version number and the server type.
        /// <para>The major release version number of the operating system is specified in the least significant 4 bits. The server type is specified in the most significant 4 bits. The <see cref="MAJOR_VERSION_MASK"/> bitmask should be used by an application to obtain the major version number from this member. </para>
        /// </summary>
        public int sv101_version_major;
        /// <summary>
        /// The minor release version number of the operating system.
        /// </summary>
        public int sv101_version_minor;
        /// <summary>
        /// Gets the operating system version of the server as a <see cref="System.Version"/> instance.
        /// </summary>
        public Version Version => new Version((sv101_version_major & MAJOR_VERSION_MASK) << 4, sv101_version_minor);
        /// <summary>
        /// The type of software the computer is running. 
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SV_TYPE_FLAGS sv101_type;
        /// <summary>
        /// A string specifying a comment describing the server. The comment can be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv101_comment;
    }
}
