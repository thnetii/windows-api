using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace THNETII.WinApiNative.Time
{
    /// <summary>
    /// Specifies a date and time, using individual members for the month, day, year, weekday, hour, minute, second, and millisecond. The time is either in coordinated universal time (UTC) or local time, depending on the function that is being called.
    /// </summary>
    /// <remarks>
    /// It is not recommended that you add and subtract values from the SYSTEMTIME structure to obtain relative times. Instead, your should
    /// <list type="number">
    /// <item>convert the <see cref="SYSTEMTIME"/> to a <see cref="DateTime"/> value using the <see cref="AsDateTime"/> method.</item>
    /// <item>Use the <see cref="DateTime"/> arithmetic methods and operations on the converted <see cref="DateTime"/> value.</item>
    /// <item>Initialize a new <see cref="SYSTEMTIME"/> value using with the resulting <see cref="DateTime"/> value using the <see cref="SYSTEMTIME(DateTime)"/> constructor.</item>
    /// </list>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms724950.aspx">SYSTEMTIME structure</a></para>
    /// </remarks>
    /// <seealso cref="FILETIME"/>
    /// <seealso cref="FileTimeToSystemTime"/>
    /// <seealso cref="GetLocalTime"/>
    /// <seealso cref="GetSystemTime"/>
    /// <seealso cref="ULARGE_INTEGER"/>
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
        /// <para><c>1</c>: January</para>
        /// <para><c>2</c>: February</para>
        /// <para><c>3</c>: March</para>
        /// <para><c>4</c>: April</para>
        /// <para><c>5</c>: May</para>
        /// <para><c>6</c>: June</para>
        /// <para><c>7</c>: July</para>
        /// <para><c>8</c>: August</para>
        /// <para><c>9</c>: September</para>
        /// <para><c>10</c>: October</para>
        /// <para><c>11</c>: November</para>
        /// <para><c>12</c>: December</para>
        /// </summary>
        public short wMonth;
        /// <summary>
        /// The day of the week.
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DayOfWeek wDayOfWeek;
        /// <summary>
        /// The day of the month. The valid values for this member are 1 through 31.
        /// </summary>
        public short wDay;
        /// <summary>
        /// The hour. The valid values for this member are 0 through 23.
        /// </summary>
        public short wHour;
        /// <summary>
        /// The minute. The valid values for this member are 0 through 59.
        /// </summary>
        public short wMinute;
        /// <summary>
        /// The second. The valid values for this member are 0 through 59.
        /// </summary>
        public short wSecond;
        /// <summary>
        /// The millisecond. The valid values for this member are 0 through 999.
        /// </summary>
        public short wMilliseconds;

        /// <summary>
        /// Converts the current value to a standard .NET <see cref="DateTime"/>
        /// value, optionall using the specified DateTime kind.
        /// </summary>
        /// <param name="kind">The optional kind to associate with the converted <see cref="DateTime"/> value.</param>
        /// <returns>A new <see cref="DateTime"/> value that represents the same time as the <see cref="SYSTEMTIME"/> value.</returns>
        public DateTime AsDateTime(DateTimeKind kind = DateTimeKind.Unspecified) =>
            new DateTime(wYear, wMonth, wDay, wHour, wMinute, wSecond, wMilliseconds, kind);

        /// <summary>
        /// Initializes a new <see cref="SYSTEMTIME"/> value that represents the
        /// same date and time as the specified <see cref="DateTime"/> value.
        /// </summary>
        /// <param name="dt"></param>
        public SYSTEMTIME(DateTime dt)
        {
            wYear = (short)dt.Year;
            wMonth = (short)dt.Month;
            wDay = (short)dt.Day;
            wDayOfWeek = dt.DayOfWeek;
            wHour = (short)dt.Hour;
            wMinute = (short)dt.Minute;
            wSecond = (short)dt.Second;
            wMilliseconds = (short)dt.Millisecond;
        }
    }
}
