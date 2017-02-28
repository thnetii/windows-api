using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1510"/> structure specifies the maximum number of users that can be logged on to the specified server using a single virtual circuit.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370915.aspx">SERVER_INFO_1510 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1510
    {
        /// <summary>
        /// Specifies the maximum number of users that can be logged on to a server using a single virtual circuit.
        /// </summary>
        public int sv1510_sessusers;
    }
}
