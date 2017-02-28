using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="TIME_OF_DAY_INFO"/> structure contains information about the time of day from a remote server.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370959.aspx">TIME_OF_DAY_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="NetRemoteTOD"/>
    [StructLayout(LayoutKind.Sequential)]
    public class TIME_OF_DAY_INFO
    {
        /// <summary>
        /// The number of seconds since 00:00:00, January 1, 1970, GMT.
        /// </summary>
        public int tod_elapsedt;
        /// <summary>
        /// <para>The number of milliseconds from an arbitrary starting point (system reset). </para>
        /// <para>Typically, this member is read twice, once when the process begins and again at the end. To determine the elapsed time between the process's start and finish, you can subtract the first value from the second.</para>
        /// </summary>
        public int tod_msecs;
        /// <summary>
        /// The current hour. Valid values are 0 through 23.
        /// </summary>
        public int tod_hours;
        /// <summary>
        /// The current minute. Valid values are 0 through 59.
        /// </summary>
        public int tod_mins;
        /// <summary>
        /// The current second. Valid values are 0 through 59.
        /// </summary>
        public int tod_secs;
        /// <summary>
        /// The current hundredth second (0.01 second). Valid values are 0 through 99.
        /// </summary>
        public int tod_hunds;
        /// <summary>
        /// The time zone of the server. This value is calculated, in minutes, from Greenwich Mean Time (GMT). For time zones west of Greenwich, the value is positive; for time zones east of Greenwich, the value is negative. A value of <c>–1</c> indicates that the time zone is undefined.
        /// </summary>
        public int tod_timezone;
        /// <summary>
        /// The time interval for each tick of the clock. Each integral integer represents one ten-thousandth second (0.0001 second).
        /// </summary>
        public int tod_tinterval;
        /// <summary>
        /// The day of the month. Valid values are 1 through 31.
        /// </summary>
        public int tod_day;
        /// <summary>
        /// The month of the year. Valid values are 1 through 12.
        /// </summary>
        public int tod_month;
        /// <summary>
        /// The year.
        /// </summary>
        public int tod_year;
        /// <summary>
        /// The day of the week.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public DayOfWeek tod_weekday;
    }
}
