using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_1003"/> structure contains the minimum duration for passwords in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371348.aspx">USER_MODALS_INFO_1003 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_1003
    {
        /// <summary>
        /// Specifies the minimum number of seconds that can elapse between the time a password changes and when it can be changed again. A value of zero indicates that no delay is required between password updates. The value specified must be less than or equal to the current value for the maximum password age.
        /// </summary>
        public int usrmod1003_min_passwd_age;
        /// <summary>
        /// Specifies the minimum time that can elapse between the time a password changes and when it can be changed again. A value of <see cref="TimeSpan.Zero"/> indicates that no delay is required between password updates. The value specified must be less than or equal to the current value for the maximum password age.
        /// </summary>
        public TimeSpan MinPasswordAge
        {
            get { return TimeSpan.FromSeconds((uint)usrmod1003_min_passwd_age); }
            set { usrmod1003_min_passwd_age = (int)((uint)value.TotalSeconds); }
        }
    }
}
