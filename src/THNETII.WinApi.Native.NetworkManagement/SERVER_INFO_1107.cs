using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1107"/> structure specifies the number of users that can simultaneously log on to the specified server.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370906.aspx">SERVER_INFO_1107 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1107
    {
        /// <summary>
        /// Specifies the number of users who can attempt to log on to the system server. Note that it is the license server that determines how many of these users can actually log on.
        /// </summary>
        public int sv1107_users;
    }
}
