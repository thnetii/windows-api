using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="STD_ALERT"/> structure contains the time and date when a significant event occurred. The structure also contains an alert class and the name of the application that is raising the alert message. You must specify the <see cref="STD_ALERT"/> structure when you send an alert message using the <see cref="NetAlertRaise"/> function.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="STD_ALERT"/> structure must be followed by one <see cref="ADMIN_OTHER_INFO"/>, <see cref="ERRLOG_OTHER_INFO"/>, <see cref="PRINT_OTHER_INFO"/>, or <see cref="USER_OTHER_INFO"/> structure. These structures can optionally be followed by variable-length data. The calling application must allocate the memory for all structures and variable-length data in an alert message buffer.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370957.aspx">STD_ALERT structure</a></para>
    /// </remarks>
    /// <seealso cref="ADMIN_OTHER_INFO"/>
    /// <seealso cref="ERRLOG_OTHER_INFO"/>
    /// <seealso cref="PRINT_OTHER_INFO"/>
    /// <seealso cref="USER_OTHER_INFO"/>
    /// <seealso cref="NetAlertRaise"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public class STD_ALERT
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 00, 00, 00, DateTimeKind.Utc);

        /// <summary>
        /// The time and date of the event. This value is stored as the number of seconds that have elapsed since 00:00:00, January 1, 1970, GMT.
        /// </summary>
        public uint alrt_timestamp;
        /// <summary>
        /// The time and date of the event. This value is expressed as a <see cref="DateTime"/> value using the local time of the system.
        /// </summary>
        public DateTime AlertTimestamp
        {
            get { return epoch.AddSeconds(alrt_timestamp).ToLocalTime(); }
            set
            {
                if (value == default(DateTime))
                    alrt_timestamp = 0;
                else
                    alrt_timestamp = (uint)((value - epoch).TotalSeconds);
            }
        }
        /// <summary>
        /// A string indicating the alert class (type of event). This parameter can be one of the following predefined values, or another alert class that you have defined for network applications. (The event name for an alert can be any text string.)
        /// <list type="table">
        /// <listheader><term>Name</term> <description>Meaning</description></listheader>
        /// <term><see cref="ALERT_ADMIN_EVENT"/></term> <description>An administrator's intervention is required.</description>
        /// <term><see cref="ALERT_ERRORLOG_EVENT"/></term> <description>An entry was added to the error log.</description>
        /// <term><see cref="ALERT_MESSAGE_EVENT"/></term> <description>A user or application received a broadcast message.</description>
        /// <term><see cref="ALERT_PRINT_EVENT"/></term> <description>A print job completed or a print error occurred.</description>
        /// <term><see cref="ALERT_USER_EVENT"/></term> <description>An application or resource was used.</description>
        /// </list>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = EVLEN + 1)]
        public string alrt_eventname;
        /// <summary>
        /// A string indicating the service application that is raising the alert message.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SNLEN + 1)]
        public string alrt_servicename;
    }
}
