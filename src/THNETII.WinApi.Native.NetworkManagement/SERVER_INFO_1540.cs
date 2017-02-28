using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1540"/> structure specifies whether the server allows redirected server drives to be shared.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370935.aspx">SERVER_INFO_1540 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1540
    {
        /// <summary>
        /// Specifies whether the server allows redirected server drives to be shared.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv1540_enablesharednetdrives;
    }
}
