using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1538"/> structure specifies whether several MS-DOS File Control Blocks (FCBs) are placed in a single location.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370933.aspx">SERVER_INFO_1538 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1538
    {
        /// <summary>
        /// Specifies whether several MS-DOS File Control Blocks (FCBs) are placed in a single location accessible to the server.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv1538_enablefcbopens;
    }
}
