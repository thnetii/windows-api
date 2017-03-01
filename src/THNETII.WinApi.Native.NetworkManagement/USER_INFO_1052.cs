using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1052"/> structure contains the path to a network user's profile. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371007.aspx">USER_INFO_1052 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1052
    {
        /// <summary>
        /// A string that contains the path to the user's profile. The user is specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. This value can be a <c>null</c> string, a local absolute path, or a UNC path.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1052_profile;
    }
}
