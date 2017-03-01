using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_1001"/> structure contains the minimum length for passwords in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371346.aspx">USER_MODALS_INFO_1001 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_1001
    {
        /// <summary>Specifies the minimum allowable password length. Valid values for this element are zero through <see cref="PWLEN"/>.</summary>
        public int usrmod1001_min_passwd_len;
    }
}
