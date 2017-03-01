using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_MODALS_INFO_3"/> structure contains the Security Account Manager (SAM) domain name and identifier.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371355.aspx">USER_MODALS_INFO_3 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserModalsGet"/>
    /// <seealso cref="NetUserModalsSet"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_MODALS_INFO_3
    {
        /// <summary>Specifies, in seconds, how long a locked account remains locked before it is automatically unlocked.</summary>
        public int usrmod3_lockout_duration;
        /// <summary>
        /// Specifies how long a locked account remains locked before it is automatically unlocked.
        /// </summary>
        /// <seealso cref="usrmod3_lockout_duration"/>
        public TimeSpan LockoutDuration
        {
            get { return TimeSpan.FromSeconds((uint)usrmod3_lockout_duration); }
            set { usrmod3_lockout_duration = (int)((uint)value.TotalSeconds); }
        }
        /// <summary>
        /// Specifies the maximum time, in seconds, that can elapse between any two failed logon attempts before lockout occurs.
        /// </summary>
        public int usrmod3_lockout_observation_window;
        /// <summary>
        /// Specifies the maximum time that can elapse between any two failed logon attempts before lockout occurs.
        /// </summary>
        /// <seealso cref="usrmod3_lockout_observation_window"/>
        public TimeSpan LockoutObservationWindow
        {
            get { return TimeSpan.FromSeconds((uint)usrmod3_lockout_observation_window); }
            set { usrmod3_lockout_observation_window = (int)((uint)value.TotalSeconds); }
        }
        /// <summary>
        /// Specifies the number of invalid password authentications that can occur before an account is marked "locked out."
        /// </summary>
        public int usrmod3_lockout_threshold;
    }
}
