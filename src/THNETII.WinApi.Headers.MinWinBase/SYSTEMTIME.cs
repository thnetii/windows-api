using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 86
    //
    // System time is represented with the following structure:
    //
    /// <summary>
    /// Specifies a date and time, using individual members for the month, day, year, weekday, hour, minute, second, and millisecond. The time is either in coordinated universal time (UTC) or local time, depending on the function that is being called.
    /// </summary>
    /// <remarks>
    /// <para>
    /// It is not recommended that you add and subtract values from the SYSTEMTIME structure to obtain relative times. Instead, you should
    /// <list type="number">
    /// <item>Convert the <see cref="SYSTEMTIME"/> structure to a <see cref="FILETIME"/> structure.</item>
    /// <item>Cast the resulting <see cref="FILETIME"/> structure to a <see cref="long"/> value.</item>
    /// <item>Use normal 64-bit arithmetic on the <see cref="long"/> value.</item>
    /// <item>Cast the resulting <see cref="long"/> value to a <see cref="FILETIME"/> structure.</item>
    /// <item>Convert the resulting <see cref="FILETIME"/> structure back to a <see cref="SYSTEMTIME"/> structure</item>
    /// </list>
    /// </para>
    /// <para>The system can periodically refresh the time by synchronizing with a time source. Because the system time can be adjusted either forward or backward, do not compare system time readings to determine elapsed time. Instead, use one of the methods described in <a href="https://docs.microsoft.com/windows/desktop/SysInfo/windows-time">Windows Time</a>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-systemtime">SYSTEMTIME structure</a></para>
    /// </remarks>
    /// <seealso cref="FILETIME"/>
    /// <seealso cref="FileTimeToSystemTime"/>
    /// <seealso cref="GetLocalTime"/>
    /// <seealso cref="GetSystemTime"/>
    /// <seealso cref="SetLocalTime"/>
    /// <seealso cref="SetSystemTime"/>
    /// <seealso cref="SystemTimeToFileTime"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEMTIME
    {
        /// <summary>
        /// The year. The valid values for this member are 1601 through 30827.
        /// </summary>
        public short wYear;
        /// <summary>
        /// The month. This member can be one of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>1</term><description>January</description></item>
        /// <item><term>2</term><description>February</description></item>
        /// <item><term>3</term><description>March</description></item>
        /// <item><term>4</term><description>April</description></item>
        /// <item><term>5</term><description>May</description></item>
        /// <item><term>6</term><description>June</description></item>
        /// <item><term>7</term><description>July</description></item>
        /// <item><term>8</term><description>August</description></item>
        /// <item><term>9</term><description>September</description></item>
        /// <item><term>10</term><description>October</description></item>
        /// <item><term>11</term><description>November</description></item>
        /// <item><term>12</term><description>December</description></item>
        /// </list>
        /// </summary>
        public short wMonth;
        /// <summary>
        /// The day of the week. This member can be one of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0</term><description>Sunday</description></item>
        /// <item><term>1</term><description>Monday</description></item>
        /// <item><term>2</term><description>Tuesday</description></item>
        /// <item><term>3</term><description>Wednesday</description></item>
        /// <item><term>4</term><description>Thursday</description></item>
        /// <item><term>5</term><description>Friday</description></item>
        /// <item><term>6</term><description>Saturday</description></item>
        /// </list>
        /// </summary>
        /// <seealso cref="DayOfWeek"/>
        public short wDayOfWeek;
        /// <summary>The day of the week.</summary>
        /// <seealso cref="wDayOfWeek"/>
        public DayOfWeek DayOfWeek
        {
            get => (DayOfWeek)wDayOfWeek;
            set => wDayOfWeek = (short)value;
        }
        /// <summary>The day of the month. The valid values for this member are 1 through 31.</summary>
        public short wDay;
        /// <summary>The hour. The valid values for this member are 0 through 23.</summary>
        public short wHour;
        /// <summary>The minute. The valid values for this member are 0 through 59.</summary>
        public short wMinute;
        /// <summary>The second. The valid values for this member are 0 through 59.</summary>
        public short wSecond;
        /// <summary>The millisecond. The valid values for this member are 0 through 999.</summary>
        public short wMilliseconds;
    }
}
