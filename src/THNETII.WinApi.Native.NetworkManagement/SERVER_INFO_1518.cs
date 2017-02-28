using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1518"/> structure specifies whether the server is visible to LAN Manager 2.x clients.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370924.aspx">SERVER_INFO_1518 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1518
    {
        /// <summary>
        /// Specifies whether the server is visible to LAN Manager 2.<var>x</var> clients.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv1518_lmannounce;
    }
}
