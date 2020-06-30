using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15568
    /// <summary>
    /// Contains the granularity of the battery capacity that is reported by <see cref="IOCTL_BATTERY_QUERY_STATUS"/>. A variable-length span of <see cref="BATTERY_REPORTING_SCALE"/> structures is returned from <see cref="IOCTL_BATTERY_QUERY_INFORMATION"/> when the <see cref="InformationLevel"/> is set to <see cref="BatteryGranularityInformation"/>. Multiple entries are returned when the granularity depends on the present capacity of the battery.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The total number of <see cref="BATTERY_REPORTING_SCALE"/> entries returned from <see cref="IOCTL_BATTERY_QUERY_INFORMATION"/> is indicated by the value of the <em>lpBytesReturned</em> parameter of <see cref="DeviceIoControl"/>. To determine the number of elements in the array, divide the value of <em>lpBytesReturned</em> by the size of the <see cref="BATTERY_REPORTING_SCALE"/> structure. The maximum number of array entries that can be returned is four.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-battery_reporting_scale">BATTERY_REPORTING_SCALE structure</a></para>
    /// </remarks>
    /// <seealso cref="IOCTL_BATTERY_QUERY_INFORMATION"/>
    /// <seealso cref="IOCTL_BATTERY_QUERY_STATUS"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct BATTERY_REPORTING_SCALE
    {
        internal const int SizeOf = sizeof(int) * 2;

        /// <summary>
        /// The granularity of the capacity reading returned by <see cref="IOCTL_BATTERY_QUERY_STATUS"/> in milliwatt-hours (mWh). Granularity may change over time as battery discharge and recharge lowers the range of readings.
        /// </summary>
        public int Granularity;
        /// <summary>
        /// The upper capacity limit for <see cref="Granularity"/>. The value of <see cref="Granularity"/> is valid for capacities reported by <see cref="IOCTL_BATTERY_QUERY_STATUS"/> that are less than or equal to this capacity (mWh), but greater than or equal to the capacity given in the previous array element, or zero if this is the first array element.
        /// </summary>
        public int Capacity;
    }
}
