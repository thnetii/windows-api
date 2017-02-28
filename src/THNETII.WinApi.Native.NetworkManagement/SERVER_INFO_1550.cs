using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1550"/> structure specifies the percentage of free disk space remaining before an alert message is sent.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370940.aspx">SERVER_INFO_1550 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1550
    {
        /// <summary>
        /// Specifies the percentage of free disk space remaining before an alert message is sent.
        /// </summary>
        public int sv1550_diskspacethreshold;
    }
}
