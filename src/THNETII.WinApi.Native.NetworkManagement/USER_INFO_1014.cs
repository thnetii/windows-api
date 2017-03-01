using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1014"/> structure contains the names of workstations from which the user can log on. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370985.aspx">USER_INFO_1014 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1014
    {
        /// <summary>
        /// <para>A string that contains the names of workstations from which the user can log on. The user is specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. </para>
        /// <para>As many as eight workstations can be specified; the names must be separated by commas. A <c>null</c> string indicates that there is no restriction.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1014_workstations;
    }
}
