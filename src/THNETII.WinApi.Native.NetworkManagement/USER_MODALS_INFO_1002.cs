using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManAccessConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_1002"/> structure contains the maximum duration for passwords in the security database, which is the security accounts manager (SAM) database or, in the case of domain controllers, the Active Directory.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371347.aspx">USER_MODALS_INFO_1002 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_1002
    {
        /// <summary>
        /// Specifies, in seconds, the maximum allowable password age. A value of <see cref="TIMEQ_FOREVER"/> indicates that the password never expires. The minimum valid value for this element is <see cref="ONE_DAY"/>. The value specified must be greater than or equal to the current value for the minimum password age.
        /// </summary>
        public int usrmod1002_max_passwd_age;
        /// <summary>
        /// Specifies the maximum allowable password age as a <see cref="TimeSpan"/> value. The minimum valid value for this element is one day. The value specified must be greater than or equal to the current value for the minimum password age.
        /// </summary>
        public TimeSpan MaxPasswordAge
        {
            get { return TimeSpan.FromSeconds((uint)usrmod1002_max_passwd_age); }
            set { usrmod1002_max_passwd_age = (int)((uint)value.TotalSeconds); }
        }
    }
}
