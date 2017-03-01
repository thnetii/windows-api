using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManAccessConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="USER_INFO_1017"/> structure contains expiration information for network user accounts. This information level is valid only when you call the <see cref="NetUserSetInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370989.aspx">USER_INFO_1017 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetUserSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class USER_INFO_1017
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 00, 00, 00, DateTimeKind.Utc);
 
        /// <summary>
        /// The date and time when the account expires. This value is stored as the number of seconds elapsed since 00:00:00, January 1, 1970, GMT. A value of <see cref="TIMEQ_FOREVER"/> indicates that the account never expires.
        /// </summary>
        public int usri1017_acct_expires;
        /// <summary>
        /// The date and time when the account expires, expressed as a <see cref="DateTime"/> value using the local time of the system.
        /// <para>A value of <see cref="DateTime.MaxValue"/> indicates that the account never expires.</para>
        /// </summary>
        public DateTime AccountExpires
        {
            get { return usri1017_acct_expires == TIMEQ_FOREVER ? DateTime.MaxValue : epoch.AddSeconds((uint)usri1017_acct_expires).ToLocalTime(); }
            set
            {
                if (value == default(DateTime))
                    usri1017_acct_expires = 0;
                else if (value == DateTime.MaxValue)
                    usri1017_acct_expires = TIMEQ_FOREVER;
                else
                    usri1017_acct_expires = (int)((uint)(value - epoch).TotalSeconds);
            }
        }
    }
}
