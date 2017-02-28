using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USE_INFO_1"/> structure contains information about the connection between a local device and a shared resource. The information includes connection status and connection type.
    /// </summary>
    /// <remarks>
    /// Specifying a <see cref="ui1_local"/> member that is <c>null</c> requests authentication with the server without redirecting a drive letter or a device. Future redirections involving the server while the same connection is in effect use the password specified by the <see cref="ui1_password"/> member in the initial call to the <see cref="NetUseAdd"/> function.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371360.aspx">USE_INFO_1 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUseEnum"/>
    /// <seealso cref="NetUseGetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USE_INFO_1
    {
        /// <summary>
        /// A string that specifies the local device name (for example, drive E or LPT1) being redirected to the shared resource. The constant <see cref="DEVLEN"/> specifies the maximum number of characters in the string. This member can be <c>null</c>. For more information, see the following Remarks section.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string ui1_local;
        /// <summary>
        /// A string that specifies the share name of the remote resource being accessed. The string is in the form: 
        /// <code>
        /// \\servername\sharename
        /// </code>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string ui1_remote;
        /// <summary>
        /// A string that contains the password needed to establish a session between a specific workstation and a server.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string ui1_password;
        /// <summary>
        /// The status of the connection. This element is not used by the <see cref="NetUseAdd"/> function.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USE_STATUS ui1_status;
        /// <summary>
        /// The type of remote resource being accessed.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public USE_ASG_TYPE ui1_asg_type;
        /// <summary>
        /// The number of files, directories, and other processes that are open on the remote resource. This element is not used by the <see cref="NetUseAdd"/> function.
        /// </summary>
        public int ui1_refcount;
        /// <summary>
        /// The number of explicit connections (redirection with a local device name) or implicit UNC connections (redirection without a local device name) that are established with the resource.
        /// </summary>
        public int ui1_usecount;
    }
}
