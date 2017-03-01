using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManAccessConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_1004"/> structure contains forced logoff information for users and global groups in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371349.aspx">USER_MODALS_INFO_1004 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_1004
    {
        /// <summary>
        /// Specifies, in seconds, the amount of time between the end of the valid logon time and the time when the user is forced to log off the network. A value of <see cref="TIMEQ_FOREVER"/> indicates that the user is never forced to log off. A value of zero indicates that the user will be forced to log off immediately when the valid logon time expires.
        /// </summary>
        public int usrmod0_force_logoff;
        /// <summary>
        /// Specifies the amount of time between the end of the valid logon time and the time when the user is forced to log off the network. A value of <see cref="TimeSpan.Zero"/> indicates that the user will be forced to log off immediately when the valid logon time expires.
        /// </summary>
        public TimeSpan ForceLogoffTime
        {
            get { return TimeSpan.FromSeconds((uint)usrmod0_force_logoff); }
            set { usrmod0_force_logoff = (int)((uint)value.TotalSeconds); }
        }
    }
}
