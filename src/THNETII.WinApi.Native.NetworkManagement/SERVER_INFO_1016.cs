using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManServerConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_1016"/> structure contains information about whether the server is visible to other computers in the same network domain.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370899.aspx">SERVER_INFO_1016 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_1016
    {
        /// <summary>
        /// Specifies whether the server is visible to other computers in the same network domain. This member can be one of the following values. 
        /// <list type="bullet">
        /// <term><see cref="SV_VISIBLE"/></term> - <description>The server is visible.</description>
        /// <term><see cref="SV_HIDDEN"/></term> - <description>The server is not visible.</description>
        /// </list>
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv1016_hidden;
    }
}
