using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USE_INFO_0"/> structure contains the name of a shared resource and the local device redirected to it.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371359.aspx">USE_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUseEnum"/>
    /// <seealso cref="NetUseGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USE_INFO_0
    {
        /// <summary>
        /// A string that specifies the local device name (for example, drive E or LPT1) being redirected to the shared resource. The constant <see cref="DEVLEN"/> specifies the maximum number of characters in the string.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string ui0_local;
        /// <summary>
        /// A string that specifies the share name of the remote resource being accessed. The string is in the form: 
        /// <code>
        /// \\servername\sharename
        /// </code>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string ui0_remote;
    }
}
