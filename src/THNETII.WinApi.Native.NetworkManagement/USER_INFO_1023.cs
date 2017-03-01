using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1023"/> structure contains the name of the server to which network logon requests should be sent. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370995.aspx">USER_INFO_1023 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1023
    {
        /// <summary>
        /// <para>A string that contains the name of the server to which logon requests for the user account should be sent. The user account is specified in the username parameter to the <see cref="NetUserSetInfo"/> function. </para>
        /// <para>Server names should be preceded by two backslashes (\\). To indicate that the logon request can be handled by any logon server, specify an asterisk (\\*) for the server name. A <c>null</c> string indicates that requests should be sent to the domain controller.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1023_logon_server;
    }
}
