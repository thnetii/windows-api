using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1523"/> structure specifies the length of time the server retains information about incomplete search operations.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370925.aspx">SERVER_INFO_1523 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1523
    {
        /// <summary>
        /// Specifies the length of time the server retains information about incomplete search operations.
        /// </summary>
        public int sv1523_maxkeepsearch;
    }
}
