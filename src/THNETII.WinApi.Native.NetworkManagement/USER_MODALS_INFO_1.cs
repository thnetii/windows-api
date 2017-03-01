using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.UAS_ROLE;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_1"/> structure contains logon server and domain controller information.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371353.aspx">USER_MODALS_INFO_1 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsGet"/>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_1
    {
        /// <summary>
        /// Specifies the role of the logon server.
        /// <para>If the Netlogon service is not being used, the element should be set to <see cref="UAS_ROLE_STANDALONE"/>.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public UAS_ROLE usrmod1_role;
        /// <summary>
        /// A string that specifies the name of the domain controller that stores the primary copy of the database for the user account manager.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usrmod1_primary;
    }
}
