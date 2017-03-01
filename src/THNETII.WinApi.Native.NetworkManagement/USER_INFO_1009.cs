using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1009"/> structure contains the path for a user's logon script file. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370969.aspx">USER_INFO_1009 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1009
    {
        /// <summary>
        /// A string specifying the path for the user's logon script file. The user is specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. The script file can be a .CMD file, an .EXE file, or a .BAT file. The string can also be <c>null</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1009_script_path;
    }
}
