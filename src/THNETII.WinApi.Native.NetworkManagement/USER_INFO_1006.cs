using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1006"/> structure contains the user's home directory path. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370966.aspx">USER_INFO_1006 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1006
    {
        /// <summary>
        /// A string specifying the path of the home directory for the user account specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. The string can be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1006_home_dir;
    }
}
