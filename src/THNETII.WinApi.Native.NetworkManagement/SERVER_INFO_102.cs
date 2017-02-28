using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManServerConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_102"/> structure contains information about the specified server, including name, platform, type of server, attributes, and associated software.
    /// </summary>
    /// <remarks>
    /// To retrieve a value that indicates whether a share is the root volume in a Dfs tree structure, you must call the <see cref="NetShareGetInfo"/> function and specify information level <c>1005</c>.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370904.aspx">SERVER_INFO_102 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    /// <seealso cref="NetServerSetInfo"/>
    /// <seealso cref="NetShareGetInfo"/>
    /// <seealso cref="SERVER_INFO_1018"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_102
    {
        /// <summary>
        /// The information level to use for platform-specific information.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public PLATFORM_ID sv102_platform_id;
        /// <summary>
        /// A string that specifies the name of the server.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv102_name;
        /// <summary>
        /// The major version number and the server type.
        /// <para>The major release version number of the operating system is specified in the least significant 4 bits. The server type is specified in the most significant 4 bits. The <see cref="MAJOR_VERSION_MASK"/> bitmask should be used by an application to obtain the major version number from this member. </para>
        /// </summary>
        public int sv102_version_major;
        /// <summary>
        /// The minor release version number of the operating system.
        /// </summary>
        public int sv102_version_minor;
        /// <summary>
        /// Gets the operating system version of the server as a <see cref="System.Version"/> instance.
        /// </summary>
        public Version Version => new Version((sv102_version_major & MAJOR_VERSION_MASK) << 4, sv102_version_minor);
        /// <summary>
        /// The type of software the computer is running. 
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public SV_TYPE_FLAGS sv102_type;
        /// <summary>
        /// A string specifying a comment describing the server. The comment can be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv102_comment;
        /// <summary>
        /// The number of users who can attempt to log on to the system server. Note that it is the license server that determines how many of these users can actually log on.
        /// </summary>
        public int sv102_users;
        /// <summary>
        /// The auto-disconnect time, in minutes. A session is disconnected if it is idle longer than the period of time specified by the <see cref="sv102_disc"/> member. If the value of <see cref="sv102_disc"/> is <see cref="SV_NODISC"/>, auto-disconnect is not enabled.
        /// </summary>
        public int sv102_disc;
        /// <summary>
        /// A value that indicates whether the server is visible to other computers in the same network domain. This member can be one of the following values defined in the <see cref="LanManServerConstants"/> class.
        /// <list type="bullet">
        /// <term><see cref="SV_VISIBLE"/></term> <description>The server is visible.</description>
        /// <term><see cref="SV_HIDDEN"/></term> <description>The server is not visible.</description>
        /// </list>
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv102_hidden;
        /// <summary>
        /// The network announce rate, in seconds. This rate determines how often the server is announced to other computers on the network. For more information about how much the announce rate can vary from the period of time specified by this member, see <see cref="SERVER_INFO_1018"/>.
        /// </summary>
        public int sv102_announce;
        /// <summary>
        /// <para>The delta value for the announce rate, in milliseconds. This value specifies how much the announce rate can vary from the period of time specified in the <see cref="sv102_announce"/> member.</para>
        /// <para>The delta value allows randomly varied announce rates. For example, if the <see cref="sv102_announce"/> member has the value <c>10</c> and the <see cref="sv102_anndelta"/> member has the value <c>1</c>, the announce rate can vary from <c>9.999</c> seconds to <c>10.001</c> seconds.</para>
        /// </summary>
        public int sv102_anndelta;
        /// <summary>
        /// The number of users per license. By default, this number is <see cref="SV_USERS_PER_LICENSE"/>.
        /// </summary>
        public int sv102_licenses;
        /// <summary>
        /// A string specifying the path to user directories.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv102_userpath;

    }
}
