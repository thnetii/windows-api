using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManAccessConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_0"/> structure contains global password information for users and global groups in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371342.aspx">USER_MODALS_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsGet"/>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_0
    {
        /// <summary>
        /// Specifies the minimum allowable password length. Valid values for this element are zero through <see cref="PWLEN"/>.
        /// </summary>
        public int usrmod0_min_passwd_len;
        /// <summary>
        /// Specifies, in seconds, the maximum allowable password age. A value of <see cref="TIMEQ_FOREVER"/> indicates that the password never expires. The minimum valid value for this element is <see cref="ONE_DAY"/>. The value specified must be greater than or equal to the value for the <see cref="usrmod0_min_passwd_age"/> member.
        /// </summary>
        public int usrmod0_max_passwd_age;
        /// <summary>
        /// Specifies the maximum allowable password age. The minimum valid value for this element is one day. The value specified must be greater than or equal to the value for the <see cref="MinPasswordAge"/> member.
        /// </summary>
        /// <seealso cref="usrmod0_max_passwd_age"/>
        public TimeSpan MaxPasswordAge
        {
            get { return TimeSpan.FromSeconds((uint)usrmod0_max_passwd_age); }
            set { usrmod0_max_passwd_age = (int)((uint)value.TotalSeconds); }
        }
        /// <summary>
        /// Specifies the minimum number of seconds that can elapse between the time a password changes and when it can be changed again. A value of zero indicates that no delay is required between password updates. The value specified must be less than or equal to the value for the <see cref="usrmod0_max_passwd_age"/> member.
        /// </summary>
        public int usrmod0_min_passwd_age;
        /// <summary>
        /// Specifies the minimum time that can elapse between the time a password changes and when it can be changed again. The value specified must be less than or equal to the value for the <see cref="MaxPasswordAge"/> member.
        /// </summary>
        /// <seealso cref="usrmod0_min_passwd_age"/>
        public TimeSpan MinPasswordAge
        {
            get { return TimeSpan.FromSeconds((uint)usrmod0_min_passwd_age); }
            set { usrmod0_min_passwd_age = (int)((uint)value.TotalSeconds); }
        }
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
        /// <summary>
        /// Specifies the length of password history maintained. A new password cannot match any of the previous <see cref="usrmod0_password_hist_len"/> passwords. Valid values for this element are zero through <see cref="DEF_MAX_PWHIST"/>.
        /// </summary>
        public int usrmod0_password_hist_len;
    }
}
