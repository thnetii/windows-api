using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1511"/> structure specifies the maximum number of tree connections that users can make with a single virtual circuit.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370916.aspx">SERVER_INFO_1511 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1511
    {
        /// <summary>
        /// Specifies the maximum number of tree connections that users can make with a single virtual circuit.
        /// </summary>
        public int sv1511_sessconns;
    }
}
