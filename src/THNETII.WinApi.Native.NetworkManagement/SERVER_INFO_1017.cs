using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1017"/> structure contains the network announce rate associated with the specified server.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370900.aspx">SERVER_INFO_1017 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    /// <seealso cref="SERVER_INFO_1018"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1017
    {
        /// <summary>
        /// Specifies the network announce rate, in seconds. This rate determines how often the server is announced to other computers on the network. 
        /// <para>For more information about how much the announce rate can vary from the period of time specified by this member, see <see cref="SERVER_INFO_1018"/>.</para>
        /// </summary>
        public int sv1017_announce;
    }
}
