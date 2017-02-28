using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManServerConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1010"/> structure contains the auto-disconnect time associated with the specified server.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370898.aspx">SERVER_INFO_1010 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1010
    {
        /// <summary>
        /// Specifies the auto-disconnect time, in minutes. 
        /// <para>If a session is idle longer than the period of time specified by this member, the server disconnects the session. If the value of this member is <see cref="SV_NODISC"/>, auto-disconnect is not enabled.</para>
        /// </summary>
        public int sv1010_disc;
    }
}
