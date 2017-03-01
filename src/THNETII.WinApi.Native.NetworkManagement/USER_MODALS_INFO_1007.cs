using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_1007"/> structure contains domain controller information.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371352.aspx">USER_MODALS_INFO_1007 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_1007
    {
        /// <summary>
        /// A string that specifies the name of the domain controller that stores the primary copy of the database for the user account manager.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string usrmod1007_primary;
    }
}
