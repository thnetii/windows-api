using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1530"/> structure specifies the minimum number of available receive work items the server requires to begin processing a server message block.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370929.aspx">SERVER_INFO_1530 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1530
    {
        /// <summary>
        /// Specifies the minimum number of available receive work items that the server requires to begin processing a server message block. A larger value for this member ensures that work items are available more frequently for nonblocking requests, but it also increases the likelihood that blocking requests will be rejected.
        /// </summary>
        public int sv1530_minfreeworkitems;
    }
}
