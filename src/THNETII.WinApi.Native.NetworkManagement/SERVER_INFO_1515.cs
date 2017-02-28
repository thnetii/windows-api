using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1515"/> structure specifies whether the server should force a client to disconnect once the client's logon time has expired.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370920.aspx">SERVER_INFO_1515 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1515
    {
        /// <summary>
        /// Specifies whether the server should force a client to disconnect, even if the client has open files, once the client's logon time has expired.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv1515_enableforcedlogoff;
    }
}
