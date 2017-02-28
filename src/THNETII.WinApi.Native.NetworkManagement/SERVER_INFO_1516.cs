using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1516"/> structure specifies whether the server is a reliable time source.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370922.aspx">SERVER_INFO_1516 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1516
    {
        /// <summary>
        /// Specifies whether the server is a reliable time source.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv1516_timesource;
    }
}
