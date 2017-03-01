using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1013"/> structure contains reserved information for network accounts. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370980.aspx">USER_INFO_1013 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1013
    {
        /// <summary>
        /// <para>A string that is reserved for use by applications. The string can be a <c>null</c> string, or it can have any number of characters. Microsoft products use this member to store user configuration information. Do not modify this information. </para>
        /// <para>The system components that use this member are services for Macintosh, file and print services for NetWare, and the Remote Access Server (RAS).</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1013_parms;
    }
}
