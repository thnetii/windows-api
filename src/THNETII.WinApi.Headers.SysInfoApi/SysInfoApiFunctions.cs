using System;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.WinApi.Native.MinWinBase;

#if NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.SysInfoApi
{
    using static NativeLibraryNames;

    public static class SysInfoApiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 84
        #region GlobalMemoryStatusEx function
        /// <summary>
        /// Retrieves information about the system's current usage of both physical and virtual memory.
        /// </summary>
        /// <param name="lpBuffer">A reference to a <see cref="MEMORYSTATUSEX"/> structure that receives information about current memory availability.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>You can use the <see cref="GlobalMemoryStatusEx"/> function to determine how much memory your application can allocate without severely impacting other applications.</para>
        /// <para>The information returned by the <see cref="GlobalMemoryStatusEx"/> function is volatile. There is no guarantee that two sequential calls to this function will return the same information.</para>
        /// <para>The <see cref="MEMORYSTATUSEX.ullAvailPhys"/> member of the <see cref="MEMORYSTATUSEX"/> structure at <paramref name="lpBuffer"/> includes memory for all NUMA nodes.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-globalmemorystatusex">GlobalMemoryStatusEx function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="MEMORYSTATUSEX"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Memory/memory-management-functions">Memory Management Functions</seealso>
        /// <seealso href="https://docs.microsoft.com/previous-versions/windows/desktop/legacy/aa965225">Memory Performance Information</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Memory/virtual-address-space-and-physical-storage">Virtual Address Space and Physical Storage</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalMemoryStatusEx(
            ref MEMORYSTATUSEX lpBuffer
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 92
        #region GetSystemInfo function
        /// <summary>
        /// Retrieves information about the current system.
        /// <para>To retrieve accurate information for an application running on WOW64, call the <see cref="GetNativeSystemInfo"/> function.</para>
        /// </summary>
        /// <param name="lpSystemInfo">A reference to a <see cref="SYSTEM_INFO"/> structure that receives the information.</param>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getsysteminfo">GetSystemInfo function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetNativeSystemInfo"/>
        /// <seealso cref="SYSTEM_INFO"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-information-functions">System Information Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern void GetSystemInfo(
            out SYSTEM_INFO lpSystemInfo
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 92
        #region GetSystemTime function
        /// <summary>
        /// Retrieves the current system date and time. The system time is expressed in Coordinated Universal Time (UTC).
        /// <para>To retrieve the current system date and time in local time, use the <see cref="GetLocalTime"/> function.</para>
        /// </summary>
        /// <param name="lpSystemTime">An out-reference to a <see cref="SYSTEMTIME"/> structure to receive the current system date and time.</param>
        /// <remarks>
        /// To set the current system date and time, use the <see cref="SetSystemTime"/> function.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getsystemtime">GetSystemTime function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetLocalTime"/>
        /// <seealso cref="GetSystemTimeAdjustment"/>
        /// <seealso cref="GetSystemTimeAsFileTime"/>
        /// <seealso cref="SYSTEMTIME"/>
        /// <seealso cref="SetSystemTime"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-time">System Time</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/time-functions">Time Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern void GetSystemTime(
            out SYSTEMTIME lpSystemTime
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 108
        #region GetSystemTimeAsFileTime function
        /// <summary>
        /// Retrieves the current system date and time. The information is in Coordinated Universal Time (UTC) format.
        /// </summary>
        /// <param name="lpSystemTimeAsFileTime">An out-reference to a <see cref="FILETIME"/> structure to receive the current system date and time in UTC format.</param>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getsystemtimeasfiletime">GetSystemTimeAsFileTime function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="FILETIME"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/file-times">File Times</seealso>
        /// <seealso cref="GetSystemTime"/>
        /// <seealso cref="SYSTEMTIME"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-time">System Time</seealso>
        /// <seealso cref="SystemTimeToFileTime"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/time-functions">Time Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern void GetSystemTimeAsFileTime(
            out FILETIME lpSystemTimeAsFileTime
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 116
        #region GetLocalTime function
        /// <summary>
        /// Retrieves the current local date and time.
        /// <para>To retrieve the current date and time in Coordinated Universal Time (UTC) format, use the <see cref="GetSystemTime"/> function.</para>
        /// </summary>
        /// <param name="lpSystemTime">An out-reference to a <see cref="SYSTEMTIME"/> structure to receive the current local date and time.</param>
        /// <remarks>
        /// To set the current local date and time, use the <see cref="SetLocalTime"/> function.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getlocaltime">GetLocalTime function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetSystemTime"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/local-time">Local Time</seealso>
        /// <seealso cref="SYSTEMTIME"/>
        /// <seealso cref="SetLocalTime"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/time-functions">Time Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern void GetLocalTime(
            out SYSTEMTIME lpSystemTime
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 130
        #region GetVersion function
        /// <summary>
        /// With the release of Windows 8.1, the behavior of the <see cref="GetVersion"/> API has changed in the value it will return for the operating system version. The value returned by the <see cref="GetVersion"/> function now depends on how the application is manifested.
        /// <para>Applications not manifested for Windows 8.1 or Windows 10 will return the Windows 8 OS version value (6.2). Once an application is manifested for a given operating system version, <see cref="GetVersion"/> will always return the version that the application is manifested for in future releases. To manifest your applications for Windows 8.1 or Windows 10, refer to <a href="https://docs.microsoft.com/windows/desktop/SysInfo/targeting-your-application-at-windows-8-1">Targeting your application for Windows</a>.</para>
        /// </summary>
        /// <returns>
        /// <para>If the function succeeds, the return value includes the major and minor version numbers of the operating system in the low-order word, and information about the operating system platform in the high-order word.</para>
        /// <para>For all platforms, the low-order word contains the version number of the operating system. The low-order byte of this word specifies the major version number, in hexadecimal notation. The high-order byte specifies the minor version (revision) number, in hexadecimal notation. The high-order bit is zero, the next 7 bits represent the build number, and the low-order byte is 5.</para>
        /// </returns>
        /// <remarks>
        /// The <see cref="GetVersionEx"/> function was developed because many existing applications err when examining the packed <see cref="int"/> value returned by <see cref="GetVersion"/>, transposing the major and minor version numbers. <see cref="GetVersionEx"/> forces applications to explicitly examine each element of version information. <see cref="VerifyVersionInfo"/> eliminates further potential for error by comparing the required system version with the current system version for you.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getversion">GetVersion function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetVersionEx"/>
        /// <seealso cref="OSVERSIONINFO"/>
        /// <seealso cref="OSVERSIONINFOEX"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/operating-system-version">Operating System Version</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-information-functions">System Information Functions</seealso>
        /// <seealso cref="VerifyVersionInfo"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/version-helper-apis">Version Helper functions</seealso>
        [Obsolete("GetVersion may be altered or unavailable for releases after Windows 8.1. Instead, use the Version Helper functions (https://docs.microsoft.com/windows/desktop/SysInfo/version-helper-apis)")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetVersion(
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 140
        #region SetLocalTime function
        /// <summary>
        /// Sets the current local time and date.
        /// </summary>
        /// <param name="lpSystemTime">
        /// <para>A read-only reference to a <see cref="SYSTEMTIME"/> structure that contains the new local date and time.</para>
        /// <para>The <see cref="SYSTEMTIME.wDayOfWeek"/> member of the <see cref="SYSTEMTIME"/> structure is ignored.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The calling process must have the <see cref="SE_SYSTEMTIME_NAME"/> privilege. This privilege is disabled by default. The <see cref="SetLocalTime"/> function enables the <see cref="SE_SYSTEMTIME_NAME"/> privilege before changing the local time and disables the privilege before returning. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecBP/running-with-special-privileges">Running with Special Privileges</a>.</para>
        /// <para>The system uses UTC internally. Therefore, when you call <see cref="SetLocalTime"/>, the system uses the current time zone information to perform the conversion, including the daylight saving time setting. Note that the system uses the daylight saving time setting of the current time, not the new time you are setting. Therefore, to ensure the correct result, call <see cref="SetLocalTime"/> a second time, now that the first call has updated the daylight saving time setting.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-setlocaltime">SetLocalTime function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetLocalTime"/>
        /// <seealso cref="GetSystemTime"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/local-time">Local Time</seealso>
        /// <seealso cref="SYSTEMTIME"/>
        /// <seealso cref="SetSystemTimeAdjustment"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/time-functions">Time Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLocalTime(
            in SYSTEMTIME lpSystemTime
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 155
        #region GetTickCount function
        /// <summary>
        /// Retrieves the number of milliseconds that have elapsed since the system was started, up to 49.7 days.
        /// </summary>
        /// <returns>The return value is the number of milliseconds that have elapsed since the system was started.</returns>
        /// <remarks>
        /// <para>The resolution of the <see cref="GetTickCount"/> function is limited to the resolution of the system timer, which is typically in the range of 10 milliseconds to 16 milliseconds. The resolution of the <see cref="GetTickCount"/> function is not affected by adjustments made by the <see cref="GetSystemTimeAdjustment"/> function.</para>
        /// <para>The elapsed time is stored as a 32-bit unsigned integer value. Therefore, the time will wrap around to zero if the system is run continuously for 49.7 days. To avoid this problem, use the <see cref="GetTickCount64"/> function. Otherwise, check for an overflow condition when comparing times.</para>
        /// <para>If you need a higher resolution timer, use a <a href="https://docs.microsoft.com/windows/desktop/Multimedia/multimedia-timers">multimedia timer</a> or a <a href="https://docs.microsoft.com/windows/desktop/winmsg/about-timers">high-resolution timer</a>.</para>
        /// <para>To obtain the time elapsed since the computer was started, retrieve the System Up Time counter in the performance data in the registry key <c>HKEY_PERFORMANCE_DATA</c>. The value returned is an 8-byte value. For more information, see <a href="https://docs.microsoft.com/windows/desktop/PerfCtrs/performance-counters-portal">Performance Counters</a>.</para>
        /// <para>To obtain the time the system has spent in the working state since it was started, use the <see cref="QueryUnbiasedInterruptTime"/> function.
        /// <note>The <see cref="QueryUnbiasedInterruptTime"/> function produces different results on debug ("checked") builds of Windows, because the interrupt-time count and tick count are advanced by approximately 49 days. This helps to identify bugs that might not occur until the system has been running for a long time. The checked build is available to MSDN subscribers through the <a href="https://msdn.microsoft.com/default.aspx">Microsoft Developer Network (MSDN)</a> Web site.</note>
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-gettickcount">GetTickCount function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/time-functions">Time Functions</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/windows-time">Windows Time</seealso>
        [Obsolete("GetTickCount overflows roughly every 49 days. Code that does not take that into account can loop indefinitely.  " + nameof(GetTickCount64) + " operates on 64 bit values and does not have that problem.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern uint GetTickCount(
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 166
        #region GetTickCount64 function
        /// <summary>
        /// Retrieves the number of milliseconds that have elapsed since the system was started.
        /// </summary>
        /// <returns>The number of milliseconds.</returns>
        /// <remarks>
        /// <para>The resolution of the <see cref="GetTickCount64"/> function is limited to the resolution of the system timer, which is typically in the range of 10 milliseconds to 16 milliseconds. The resolution of the <see cref="GetTickCount64"/> function is not affected by adjustments made by the <see cref="GetSystemTimeAdjustment"/> function.</para>
        /// <para>If you need a higher resolution timer, use a <a href="https://docs.microsoft.com/windows/desktop/Multimedia/multimedia-timers">multimedia timer</a> or a <a href="https://docs.microsoft.com/windows/desktop/winmsg/about-timers">high-resolution timer</a>.</para>
        /// <para>To obtain the time the system has spent in the working state since it was started, use the <see cref="QueryUnbiasedInterruptTime"/> function.
        /// <note>The <see cref="QueryUnbiasedInterruptTime"/> function produces different results on debug ("checked") builds of Windows, because the interrupt-time count and tick count are advanced by approximately 49 days. This helps to identify bugs that might not occur until the system has been running for a long time. The checked build is available to MSDN subscribers through the <a href="https://msdn.microsoft.com/default.aspx">Microsoft Developer Network (MSDN)</a> Web site.</note>
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows Vista [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2008 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-gettickcount64">GetTickCount64 function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/time-functions">Time Functions</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/windows-time">Windows Time</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern ulong GetTickCount64(
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 182
        #region GetSystemTimeAdjustment function
        /// <summary>
        /// Determines whether the system is applying periodic time adjustments to its time-of-day clock, and obtains the value and period of any such adjustments.
        /// </summary>
        /// <param name="lpTimeAdjustment">A variable that the function sets to the number of <paramref name="lpTimeIncrement"/> 100-nanosecond units added to the time-of-day clock for every period of time which actually passes as counted by the system. This value only has meaning if <paramref name="lpTimeAdjustmentDisabled"/> is <see langword="false"/>.</param>
        /// <param name="lpTimeIncrement">A variable that the function sets to the interval in 100-nanosecond units at which the system will add <paramref name="lpTimeAdjustment"/> to the time-of-day clock. This value only has meaning if <paramref name="lpTimeAdjustmentDisabled"/> is <see langword="false"/>.</param>
        /// <param name="lpTimeAdjustmentDisabled">
        /// <para>A variable that the function sets to indicate whether periodic time adjustment is in effect.</para>
        /// <para>A value of <see langword="true"/> indicates that periodic time adjustment is disabled, and the system time-of-day clock advances at the normal rate. In this mode, the system may adjust the time of day using its own internal time synchronization mechanisms. These internal time synchronization mechanisms may cause the time-of-day clock to change during the normal course of the system operation, which can include noticeable jumps in time as deemed necessary by the system.</para>
        /// <para>A value of <see langword="false"/> indicates that periodic time adjustment is being used to adjust the time-of-day clock. For each <paramref name="lpTimeIncrement"/> period of time that actually passes, <paramref name="lpTimeAdjustment"/> will be added to the time of day. If the <paramref name="lpTimeAdjustment"/> value is smaller than <paramref name="lpTimeIncrement"/>, the system time-of-day clock will advance at a rate slower than normal. If the <paramref name="lpTimeAdjustment"/> value is larger than <paramref name="lpTimeIncrement"/>, the time-of-day clock will advance at a rate faster than normal. If <paramref name="lpTimeAdjustment"/> equals <paramref name="lpTimeIncrement"/>, the time-of-day clock will advance at its normal speed. The <paramref name="lpTimeAdjustment"/> value can be set by calling <see cref="SetSystemTimeAdjustment"/>. The <paramref name="lpTimeIncrement"/> value is fixed by the system upon start, and does not change during system operation. In this mode, the system will not interfere with the time adjustment scheme, and will not attempt to synchronize time of day on its own via other techniques.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="GetSystemTimeAdjustment"/> and <see cref="SetSystemTimeAdjustment"/> functions can be used to support algorithms that want to synchronize the time-of-day clock, reported by <see cref="GetSystemTime"/> and <see cref="GetLocalTime"/>, with another time source by using a periodic time adjustment.</para>
        /// <para>The <see cref="GetSystemTimeAdjustment"/> function lets a caller determine whether periodic time adjustment is enabled, and if it is, obtain the amount of each adjustment and the time between adjustments. The <see cref="SetSystemTimeAdjustment"/> function lets a caller enable or disable periodic time adjustment, and set the value of the adjusting increment.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getsystemtimeadjustment">GetSystemTimeAdjustment function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetLocalTime"/>
        /// <seealso cref="GetSystemTime"/>
        /// <seealso cref="SetSystemTimeAdjustment"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-time">System Time</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/time-functions">Time Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemTimeAdjustment(
            out int lpTimeAdjustment,
            out int lpTimeIncrement,
            [MarshalAs(UnmanagedType.Bool)]
            out bool lpTimeAdjustmentDisabled
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 193
        #region GetSystemTimeAdjustmentPrecise function
        /// <summary>
        /// Determines whether the system is applying periodic, programmed time adjustments to its time-of-day clock, and obtains the value and period of any such adjustments.
        /// </summary>
        /// <param name="lpTimeAdjustment">Returns the adjusted clock update frequency.</param>
        /// <param name="lpTimeIncrement">Returns the clock update frequency.</param>
        /// <param name="lpTimeAdjustmentDisabled">
        /// <para>Returns an indicator which specifies whether the time adjustment is enabled.</para>
        /// <para>A value of <see langword="true"/> indicates that periodic adjustment is disabled. In this case, the system may attempt to keep the time-of-day clock in sync using its own internal mechanisms. This may cause time-of-day to periodically jump to the "correct time."</para>
        /// <para>A value of <see langword="false"/> indicates that periodic, programmed time adjustment is being used to serialize time-of-day, and the system will not interfere or attempt to synchronize time-of-day on its own.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// This function is used in algorithms that synchronize the time-of-day with another time source, using a programmed clock adjustment. To do this, the system computes the adjusted clock update frequency, and then this function allows the caller to obtain that value.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 10 [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2016 [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getsystemtimeadjustmentprecise">GetSystemTimeAdjustmentPrecise function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="SetSystemTimeAdjustmentPrecise"/>
        [DllImport(KernelBase, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemTimeAdjustmentPrecise(
            out long lpTimeAdjustment,
            out long lpTimeIncrement,
            [MarshalAs(UnmanagedType.Bool)]
            out bool lpTimeAdjustmentDisabled
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 210
        #region GetSystemDirectoryA function
        /// <inheritdoc cref="GetSystemDirectory(LPTSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetSystemDirectoryA(
            LPSTR lpBuffer,
            [In] int uSize
            );

        /// <inheritdoc cref="GetSystemDirectoryA(LPSTR, int)"/>
        public static int GetSystemDirectoryA(
            StringBuilder lpBuffer
            ) => GetSystemDirectoryA(lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetSystemDirectoryA(LPSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetSystemDirectoryA(
            [Out] StringBuilder lpBuffer,
            [In] int uSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 219
        #region GetSystemDirectoryW function
        /// <inheritdoc cref="GetSystemDirectory(LPTSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetSystemDirectoryW(
            LPWSTR lpBuffer,
            [In] int uSize
            );

        /// <inheritdoc cref="GetSystemDirectoryW(LPWSTR, int)"/>
        public static int GetSystemDirectoryW(
            StringBuilder lpBuffer
            ) => GetSystemDirectoryW(lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetSystemDirectoryW(LPWSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int GetSystemDirectoryW(
            [Out] StringBuilder lpBuffer,
            [In] int uSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 228
        #region GetSystemDirectory function
        /// <summary>
        /// Retrieves the path of the system directory. The system directory contains system files such as dynamic-link libraries and drivers.
        /// <para>This function is provided primarily for compatibility. Applications should store code in the Program Files folder and persistent data in the Application Data folder in the user's profile. For more information, see <see cref="ShGetFolderPath"/>.</para>
        /// </summary>
        /// <param name="lpBuffer">A buffer to receive the path. This path does not end with a backslash unless the system directory is the root directory. For example, if the system directory is named <c>Windows\System32</c> on drive <c>C</c>, the path of the system directory retrieved by this function is <c>C:\Windows\System32</c>.</param>
        /// <param name="uSize">The maximum size of the buffer, in characters.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is the length, in characters, of the string copied to the buffer, not including the terminating null character. If the length is greater than the size of the buffer, the return value is the size of the buffer required to hold the path, including the terminating null character.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// Applications should not create files in the system directory. If the user is running a shared version of the operating system, the application does not have write access to the system directory.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getsystemdirectoryw">GetSystemDirectory function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetCurrentDirectory"/>
        /// <seealso cref="GetWindowsDirectory"/>
        /// <seealso cref="SetCurrentDirectory"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-information-functions">System Information Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetSystemDirectory(
            LPTSTR lpBuffer,
            [In] int uSize
            );

#if !NETSTANDARD1_6
        /// <inheritdoc cref="GetSystemDirectory(LPTSTR, int)"/>
        public static int GetSystemDirectory(
            StringBuilder lpBuffer
            ) => GetSystemDirectory(lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetSystemDirectory(LPTSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetSystemDirectory(
            [Out] StringBuilder lpBuffer,
            [In] int uSize
            ); 
#endif // !NETSTANDARD1_6
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 240
        #region GetWindowsDirectoryA function
        /// <inheritdoc cref="GetWindowsDirectory(LPTSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetWindowsDirectoryA(
            LPSTR lpBuffer,
            [In] int uSize
            );

        /// <inheritdoc cref="GetWindowsDirectoryA(LPSTR, int)"/>
        public static int GetWindowsDirectoryA(
            StringBuilder lpBuffer
            ) => GetWindowsDirectoryA(lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetWindowsDirectoryA(LPSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetWindowsDirectoryA(
            [Out] StringBuilder lpBuffer,
            [In] int uSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 250
        #region GetWindowsDirectoryW function
        /// <inheritdoc cref="GetWindowsDirectory(LPTSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetWindowsDirectoryW(
            LPWSTR lpBuffer,
            [In] int uSize
            );

        /// <inheritdoc cref="GetWindowsDirectoryW(LPWSTR, int)"/>
        public static int GetWindowsDirectoryW(
            StringBuilder lpBuffer
            ) => GetWindowsDirectoryW(lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetWindowsDirectoryW(LPWSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int GetWindowsDirectoryW(
            [Out] StringBuilder lpBuffer,
            [In] int uSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 260
        #region GetWindowsDirectory function
        /// <summary>
        /// Retrieves the path of the Windows directory.
        /// <para>This function is provided primarily for compatibility with legacy applications. New applications should store code in the Program Files folder and persistent data in the Application Data folder in the user's profile. For more information, see <see cref="ShGetFolderPath"/>.</para>
        /// </summary>
        /// <param name="lpBuffer">A buffer that receives the path. This path does not end with a backslash unless the Windows directory is the root directory. For example, if the Windows directory is named <c>Windows</c> on drive <c>C</c>, the path of the Windows directory retrieved by this function is <c>C:\Windows</c>. If the system was installed in the root directory of drive <c>C</c>, the path retrieved is <c>C:</c>.</param>
        /// <param name="uSize">The maximum size of the buffer specified by the <paramref name="lpBuffer"/> parameter, in characters. This value should be set to <see cref="MAX_PATH"/>.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is the length of the string copied to the buffer, in characters, not including the terminating null character.</para>
        /// <para>If the length is greater than the size of the buffer, the return value is the size of the buffer required to hold the path.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The Windows directory is the directory where some legacy applications store initialization and help files. New applications should not store files in the Windows directory; instead, they should store system-wide data in the application's installation directory, and user-specific data in the user's profile.</para>
        /// <para>If the user is running a shared version of the system, the Windows directory is guaranteed to be private for each user.</para>
        /// <para>If an application creates other files that it wants to store on a per-user basis, it should place them in the directory specified by the <c>HOMEPATH</c> environment variable. This directory will be different for each user, if so specified by an administrator, through the User Manager administrative tool. <c>HOMEPATH</c> always specifies either the user's home directory, which is guaranteed to be private for each user, or a default directory (for example, <c>C:\USERS\DEFAULT</c>) where the user will have all access.</para>
        /// <para><strong>Terminal Services:</strong> If the application is running in a Terminal Services environment, each user has a private Windows directory. There is also a shared Windows directory for the system. If the application is Terminal-Services-aware (has the <see cref="IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE"/> flag set in the image header), this function returns the path of the system Windows directory, just as the <see cref="GetSystemWindowsDirectory"/> function does. Otherwise, it retrieves the path of the private Windows directory for the user.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getwindowsdirectoryw">GetWindowsDirectory function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetCurrentDirectory"/>
        /// <seealso cref="GetSystemDirectory"/>
        /// <seealso cref="GetSystemWindowsDirectory"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-information-functions">System Information Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetWindowsDirectory(
            LPTSTR lpBuffer,
            [In] int uSize
            );

#if !NETSTANDARD1_6
        /// <inheritdoc cref="GetWindowsDirectory(LPTSTR, int)"/>
        public static int GetWindowsDirectory(
            StringBuilder lpBuffer
            ) => GetWindowsDirectory(lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetWindowsDirectory(LPTSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowsDirectory(
            [Out] StringBuilder lpBuffer,
            [In] int uSize
            );
#endif // !NETSTANDARD1_6
        #endregion
    }
}
