using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_1006"/> structure contains logon server information.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371351.aspx">USER_MODALS_INFO_1006 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_1006
    {
        /// <summary>
        /// Specifies the role of the logon server.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public UAS_ROLE usrmod1006_role;
    }
}
