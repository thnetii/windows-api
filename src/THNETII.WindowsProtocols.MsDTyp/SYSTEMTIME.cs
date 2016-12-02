using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WindowsProtocols.MsDTyp
{
    /// <summary>
    /// The SYSTEMTIME structure is a date and time, in Coordinated Universal Time (UTC), represented by using individual <see cref="short"/>-sized structure members for the month, day, year, day of week, hour, minute, second, and millisecond.
    /// </summary>
    /// <remarks>
    /// <para>This data type is also documented on the <a href="https://msdn.microsoft.com/en-us/library/ms724950.aspx">SYSTEMTIME structure</a> page. The documentation for the fields of this type has been copied from <a href="https://msdn.microsoft.com/en-us/library/ms724950.aspx">SYSTEMTIME structure</a> page.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/cc230375.aspx">SYSTEMTIME</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public class SYSTEMTIME
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public enum MONTH : short
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>The year. The valid values for this member are 1601 through 30827.</summary>
        public short wYear;
        /// <summary>The month.</summary>
        [MarshalAs(UnmanagedType.I2)]
        public MONTH wMonth;
        /// <summary>The day of the week.</summary>
        [MarshalAs(UnmanagedType.I2)]
        public DayOfWeek wDayOfWeek;
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
