using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManAccessConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1018"/> structure contains the maximum amount of disk space available to a network user account. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370991.aspx">USER_INFO_1018 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1018
    {
        /// <summary>
        /// <para>Specifies a value that indicates the maximum amount of disk space the user can use. The user is specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. </para>
        /// <para>You must specify <see cref="USER_MAXSTORAGE_UNLIMITED"/> to indicate that there is no restriction on disk space.</para>
        /// </summary>
        public uint usri1018_max_storage;
    }
}
