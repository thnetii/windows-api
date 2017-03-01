using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1053"/> structure 
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371009.aspx">USER_INFO_1053 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1053
    {
        /// <summary>
        /// Specifies the drive letter to assign to the user's home directory for logon purposes. The user is specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1053_home_dir_drive;
    }
}
