using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManAccessConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_1005"/> structure contains password history information for users and global groups in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371350.aspx">USER_MODALS_INFO_1005 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_1005
    {
        /// <summary>
        /// Specifies the length of password history that the system maintains. A new password cannot match any of the previous <see cref="usrmod1005_password_hist_len"/> passwords. Valid values for this element are zero through <see cref="DEF_MAX_PWHIST"/>.
        /// </summary>
        public int usrmod1005_password_hist_len;
    }
}
