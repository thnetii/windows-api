using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_21"/> structure contains a one-way encrypted LAN Manager 2.x-compatible password.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371124.aspx">USER_INFO_21 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_21
    {
        /// <summary>
        /// Specifies a one-way encrypted LAN Manager 2.x-compatible password.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = ENCRYPTED_PWLEN)]
        public byte[] usri21_password;
    }
}
