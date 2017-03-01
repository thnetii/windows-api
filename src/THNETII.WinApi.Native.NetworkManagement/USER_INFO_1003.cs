using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1003"/> structure contains a user password. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// By convention, the length of passwords is limited to <see cref="LM20_PWLEN"/> characters.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370963.aspx">USER_INFO_1003 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1003
    {
        /// <summary>
        /// Specifies a Unicode string that contains the password for the user account specified in the <var>username</var> parameter to the <see cref="NetUserSetInfo"/> function. The length cannot exceed <see cref="PWLEN"/> bytes.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usri1003_password;
    }
}
