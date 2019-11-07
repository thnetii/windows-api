using System;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.MinWinBase;
using THNETII.WinApi.Native.WinError;
using THNETII.WinApi.Native.WinNT;

#if NETSTANDARD1_6
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.SysInfoApi
{
    using static COMPUTER_NAME_FORMAT;
    using static NativeLibraryNames;
    using static WinErrorConstants;
    using static WinNTConstants;

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
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 266
        #region GetSystemWindowsDirectoryA function
        /// <inheritdoc cref="GetSystemWindowsDirectory(LPTSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetSystemWindowsDirectoryA(
            LPSTR lpBuffer,
            [In] int uSize
            );

        /// <inheritdoc cref="GetSystemWindowsDirectoryA(LPSTR, int)"/>
        public static int GetSystemWindowsDirectoryA(
            StringBuilder lpBuffer
            ) => GetSystemWindowsDirectoryA(lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetSystemWindowsDirectoryA(LPSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetSystemWindowsDirectoryA(
            [Out] StringBuilder lpBuffer,
            [In] int uSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 275
        #region GetSystemWindowsDirectoryW function
        /// <inheritdoc cref="GetSystemWindowsDirectory(LPTSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetSystemWindowsDirectoryW(
            LPWSTR lpBuffer,
            [In] int uSize
            );

        /// <inheritdoc cref="GetSystemWindowsDirectoryW(LPWSTR, int)"/>
        public static int GetSystemWindowsDirectoryW(
            StringBuilder lpBuffer
            ) => GetSystemWindowsDirectoryW(lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetSystemWindowsDirectoryW(LPWSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int GetSystemWindowsDirectoryW(
            [Out] StringBuilder lpBuffer,
            [In] int uSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 284
        #region GetSystemWindowsDirectory function
        /// <summary>
        /// Retrieves the path of the shared Windows directory on a multi-user system.
        /// <para>This function is provided primarily for compatibility. Applications should store code in the Program Files folder and persistent data in the Application Data folder in the user's profile. For more information, see <see cref="ShGetFolderPath"/>.</para>
        /// </summary>
        /// <param name="lpBuffer">A buffer to receive the path. This path does not end with a backslash unless the Windows directory is the root directory. For example, if the Windows directory is named <c>Windows</c> on drive <c>C</c>, the path of the Windows directory retrieved by this function is <c>C:\Windows</c>. If the system was installed in the root directory of drive <c>C</c>, the path retrieved is <c>C:</c>.</param>
        /// <param name="uSize">The maximum size of the buffer specified by the <paramref name="lpBuffer"/> parameter, in characters.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is the length of the string copied to the buffer, in characters, not including the terminating null character.</para>
        /// <para>If the length is greater than the size of the buffer, the return value is the size of the buffer required to hold the path.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>On a system that is running Terminal Services, each user has a unique Windows directory. The system Windows directory is shared by all users, so it is the directory where an application should store initialization and help files that apply to all users.</para>
        /// <para>With Terminal Services, the <see cref="GetSystemWindowsDirectory"/> function retrieves the path of the system Windows directory, while the <see cref="GetWindowsDirectory"/> function retrieves the path of a Windows directory that is private for each user. On a single-user system, <see cref="GetSystemWindowsDirectory"/> is the same as <see cref="GetWindowsDirectory"/>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getsystemwindowsdirectoryw">GetSystemWindowsDirectory function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetWindowsDirectory"/>
        /// <seealso cref="SHGetFolderLocation"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-information-functions">System Information Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetSystemWindowsDirectory(
            LPTSTR lpBuffer,
            [In] int uSize
            );

#if !NETSTANDARD1_6
        /// <inheritdoc cref="GetSystemWindowsDirectory(LPTSTR, int)"/>
        public static int GetSystemWindowsDirectory(
            StringBuilder lpBuffer
            ) => GetSystemWindowsDirectory(lpBuffer, lpBuffer?.Capacity ?? 0);

        /// <inheritdoc cref="GetSystemWindowsDirectory(LPTSTR, int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetSystemWindowsDirectory(
            [Out] StringBuilder lpBuffer,
            [In] int uSize
            );
#endif // !NETSTANDARD1_6
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 314
        #region GetComputerNameExA function
        /// <inheritdoc cref="GetComputerNameEx(COMPUTER_NAME_FORMAT, LPTSTR, ref int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameExA(
            [In] COMPUTER_NAME_FORMAT NameType,
            LPSTR lpBuffer,
            ref int nSize
            );

        /// <inheritdoc cref="GetComputerNameExA(COMPUTER_NAME_FORMAT, LPSTR, ref int)"/>
        public static bool GetComputerNameExA(
            COMPUTER_NAME_FORMAT NameType,
            StringBuilder lpBuffer,
            out int nSize
            )
        {
            nSize = lpBuffer?.Capacity ?? 0;
            return GetComputerNameExAExtern(NameType, lpBuffer, ref nSize);
        }

        /// <inheritdoc cref="GetComputerNameExA(COMPUTER_NAME_FORMAT, LPSTR, ref int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(GetComputerNameExA), CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetComputerNameExAExtern(
            [In] COMPUTER_NAME_FORMAT NameType,
            [Out] StringBuilder lpBuffer,
            ref int nSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 324
        #region GetComputerNameExW function
        /// <inheritdoc cref="GetComputerNameEx(COMPUTER_NAME_FORMAT, LPTSTR, ref int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameExW(
            [In] COMPUTER_NAME_FORMAT NameType,
            LPWSTR lpBuffer,
            ref int nSize
            );

        /// <inheritdoc cref="GetComputerNameExW(COMPUTER_NAME_FORMAT, LPWSTR, ref int)"/>
        public static bool GetComputerNameExW(
            COMPUTER_NAME_FORMAT NameType,
            StringBuilder lpBuffer,
            out int nSize
            )
        {
            nSize = lpBuffer?.Capacity ?? 0;
            return GetComputerNameExWExtern(NameType, lpBuffer, ref nSize);
        }

        /// <inheritdoc cref="GetComputerNameExW(COMPUTER_NAME_FORMAT, LPWSTR, ref int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(GetComputerNameExW), CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetComputerNameExWExtern(
            [In] COMPUTER_NAME_FORMAT NameType,
            [Out] StringBuilder lpBuffer,
            ref int nSize
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 334
        #region GetComputerNameEx function
        /// <summary>
        /// Retrieves a NetBIOS or DNS name associated with the local computer. The names are established at system startup, when the system reads them from the registry.
        /// </summary>
        /// <param name="NameType">
        /// The type of name to be retrieved. This parameter is a value from the <see cref="COMPUTER_NAME_FORMAT"/> enumeration type. The following table provides additional information.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="ComputerNameDnsDomain"/></term><description> The name of the DNS domain assigned to the local computer. If the local computer is a node in a cluster, <paramref name="lpBuffer"/> receives the DNS domain name of the cluster virtual server.</description></item>
        /// <item><term><see cref="ComputerNameDnsFullyQualified"/></term><description>The fully qualified DNS name that uniquely identifies the local computer. This name is a combination of the DNS host name and the DNS domain name, using the form <em>HostName.DomainName</em>. If the local computer is a node in a cluster, <paramref name="lpBuffer"/> receives the fully qualified DNS name of the cluster virtual server.</description></item>
        /// <item><term><see cref="ComputerNameDnsHostname"/></term><description>The DNS host name of the local computer. If the local computer is a node in a cluster, <paramref name="lpBuffer"/> receives the DNS host name of the cluster virtual server.</description></item>
        /// <item><term><see cref="ComputerNameNetBIOS"/></term><description>The NetBIOS name of the local computer. If the local computer is a node in a cluster, <paramref name="lpBuffer"/> receives the NetBIOS name of the cluster virtual server.</description></item>
        /// <item><term><see cref="ComputerNamePhysicalDnsDomain"/></term><description>The name of the DNS domain assigned to the local computer. If the local computer is a node in a cluster, <paramref name="lpBuffer"/> receives the DNS domain name of the local computer, not the name of the cluster virtual server.</description></item>
        /// <item><term><see cref="ComputerNamePhysicalDnsFullyQualified"/></term><description><para>The fully qualified DNS name that uniquely identifies the computer. If the local computer is a node in a cluster, <paramref name="lpBuffer"/> receives the fully qualified DNS name of the local computer, not the name of the cluster virtual server.</para><para>The fully qualified DNS name is a combination of the DNS host name and the DNS domain name, using the form <em>HostName.DomainName</em>.</para></description></item>
        /// <item><term><see cref="ComputerNamePhysicalDnsHostname"/></term><description>The DNS host name of the local computer. If the local computer is a node in a cluster, <paramref name="lpBuffer"/> receives the DNS host name of the local computer, not the name of the cluster virtual server.</description></item>
        /// <item><term><see cref="ComputerNamePhysicalNetBIOS"/></term><description>The NetBIOS name of the local computer. If the local computer is a node in a cluster, <paramref name="lpBuffer"/> receives the NetBIOS name of the local computer, not the name of the cluster virtual server.</description></item>
        /// </list>
        /// </param>
        /// <param name="lpBuffer">
        /// <para>A buffer that receives the computer name or the cluster virtual server name.</para>
        /// <para>The length of the name may be greater than <see cref="F:THNETII.WinApi.Native.WinBase.WinBaseConstants.MAX_COMPUTERNAME_LENGTH"/> characters because DNS allows longer names. To ensure that this buffer is large enough, set this parameter to <see langword="null"/> and use the required buffer size returned in the <paramref name="nSize"/> parameter.</para>
        /// </param>
        /// <param name="nSize">
        /// <para>On input, specifies the size of the buffer, in characters. On output, receives the number of characters copied to the destination buffer, not including the terminating null character.</para>
        /// <para>If the buffer is too small, the function fails and <see cref="GetLastError"/> returns <see cref="ERROR_MORE_DATA"/>. This parameter receives the size of the buffer required, including the terminating null character.</para>
        /// <para>If lpBuffer is <see langword="null"/>, this parameter must be zero.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a <see langword="true"/>.</para>
        /// <para>
        /// If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="GetLastError"/>. Possible values include the following.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><see cref="ERROR_MORE_DATA"/></term><description>The <paramref name="lpBuffer"/> buffer is too small. The <paramref name="nSize"/> parameter contains the number of characters required to receive the name.</description></item>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>If group policy is not set for the local machine, the <see cref="GetComputerNameEx"/> function retrieves the NetBIOS or DNS names established at system startup. If group policy is set, the function returns the primary domain name set by group policy. Name changes made by the <see cref="SetComputerName"/> or <see cref="SetComputerNameEx"/> functions do not take effect until the user restarts the computer.</para>
        /// <para>If the local computer is not configured to use DNS names, <see cref="GetComputerNameEx"/> will not return DNS information. To configure the computer to do this, follow the steps outlined in the operating system help and change the primary DNS suffix of the computer, then restart the computer.</para>
        /// <para>The behavior of this function can be affected if the local computer is a node in a cluster. For more information, see <see cref="ResUtilGetEnvironmentWithNetName"/> and <see cref="UseNetworkName"/>.</para>
        /// <para>If you are working with environments that use different DNS layouts, where the computer's FQDN does not match the FQDN of its domain, use <see cref="LsaQueryInformationPolicy"/> instead.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getcomputernameexw">GetComputerNameEx function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="COMPUTER_NAME_FORMAT"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/computer-names">Computer Names</seealso>
        /// <seealso cref="GetComputerName"/>
        /// <seealso cref="ResUtilGetEnvironmentWithNetName"/>
        /// <seealso cref="ResUtilSetResourceServiceEnvironment"/>
        /// <seealso cref="ResUtilSetResourceServiceStartParameters"/>
        /// <seealso cref="SetComputerName"/>
        /// <seealso cref="SetComputerNameEx"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-information-functions">System Information Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameEx(
            [In] COMPUTER_NAME_FORMAT NameType,
            LPTSTR lpBuffer,
            ref int nSize
            );

#if !NETSTANDARD1_6
        /// <inheritdoc cref="GetComputerNameEx(COMPUTER_NAME_FORMAT, LPTSTR, ref int)"/>
        public static bool GetComputerNameEx(
            COMPUTER_NAME_FORMAT NameType,
            StringBuilder lpBuffer,
            out int nSize
            )
        {
            nSize = lpBuffer?.Capacity ?? 0;
            return GetComputerNameExExtern(NameType, lpBuffer, ref nSize);
        }

        /// <inheritdoc cref="GetComputerNameEx(COMPUTER_NAME_FORMAT, LPTSTR, ref int)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(GetComputerNameEx), CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetComputerNameExExtern(
            [In] COMPUTER_NAME_FORMAT NameType,
            [Out] StringBuilder lpBuffer,
            ref int nSize
            );
#endif // !NETSTANDARD1_6
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 346
        #region SetComputerNameExW function
        /// <inheritdoc cref="SetComputerNameEx(COMPUTER_NAME_FORMAT, LPCTSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameExW(
            [In] COMPUTER_NAME_FORMAT NameType,
            LPCWSTR lpBuffer
            );

        /// <inheritdoc cref="SetComputerNameExW(COMPUTER_NAME_FORMAT, LPCWSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameExW(
            [In] COMPUTER_NAME_FORMAT NameType,
            [In] string lpBuffer
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 355
        #region SetComputerNameEx function
        /// <summary>
        /// Sets a new NetBIOS or DNS name for the local computer. Name changes made by <see cref="SetComputerNameEx"/> do not take effect until the user restarts the computer.
        /// </summary>
        /// <param name="NameType">
        /// The type of name to be set. This parameter can be one of the following values from the <see cref="COMPUTER_NAME_FORMAT"/> enumeration type.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="ComputerNamePhysicalDnsDomain"/></term><description>Sets the primary DNS suffix of the computer.</description></item>
        /// <item><term><see cref="ComputerNamePhysicalDnsHostname"/></term><description>Sets the NetBIOS and the Computer Name (the first label of the full DNS name) to the name specified in <paramref name="lpBuffer"/>. If the name exceeds <see cref="F:THNETII.WinApi.Native.WinBase.WinBaseConstants.MAX_COMPUTERNAME_LENGTH"/> characters, the NetBIOS name is truncated to <see cref="F:THNETII.WinApi.Native.WinBase.WinBaseConstants.MAX_COMPUTERNAME_LENGTH"/> characters, not including the terminating null character.</description></item>
        /// <item><term><see cref="ComputerNamePhysicalNetBIOS"/></term><description><para>Sets the NetBIOS name to the name specified in <paramref name="lpBuffer"/>. The name cannot exceed <see cref="F:THNETII.WinApi.Native.WinBase.WinBaseConstants.MAX_COMPUTERNAME_LENGTH"/> characters, not including the terminating null character.</para><para><note type="warning">Using this option to set the NetBIOS name breaks the convention of interdependent NetBIOS and DNS names. Applications that use the <see cref="DnsHostnameToComputerName"/> function to derive the NetBIOS name from the first label of the DNS name will fail if this convention is broken.</note></para></description></item>
        /// </list>
        /// </param>
        /// <param name="lpBuffer">The new name. The name cannot include control characters, leading or trailing spaces, or any of the following characters: <code>&quot; / \ [ ] : | &lt; &gt; + = ; , ?</code></param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para><see cref="SetComputerNameEx"/> can set the Computer Name (the first label of the full DNS name) or the primary DNS suffix of the local computer. It cannot set a fully qualified DNS name in one call.</para>
        /// <para>If the local computer is a node in a cluster, <see cref="SetComputerNameEx"/> sets NetBIOS or DNS name of the local computer, not that of the cluster virtual server.</para>
        /// <para>The process that calls the <see cref="SetComputerNameEx"/> function must have administrator privileges on the local computer.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-setcomputernameexw">SetComputerNameEx function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="COMPUTER_NAME_FORMAT"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/computer-names">Computer Names</seealso>
        /// <seealso cref="DnsHostnameToComputerName"/>
        /// <seealso cref="GetComputerName"/>
        /// <seealso cref="GetComputerNameEx"/>
        /// <seealso cref="SetComputerName"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-information-functions">System Information Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameEx(
            [In] COMPUTER_NAME_FORMAT NameType,
            LPCTSTR lpBuffer
            );

#if !NETSTANDARD1_6
        /// <inheritdoc cref="SetComputerNameEx(COMPUTER_NAME_FORMAT, LPCTSTR)"/>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameEx(
            [In] COMPUTER_NAME_FORMAT NameType,
            [In] string lpBuffer
            );
#endif // !NETSTANDARD1_6
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 359
        #region SetSystemTime function
        /// <summary>
        /// Sets the current system time and date. The system time is expressed in Coordinated Universal Time (UTC).
        /// </summary>
        /// <param name="lpSystemTime">
        /// <para>A read-only reference to a <see cref="SYSTEMTIME"/> structure that contains the new system date and time.</para>
        /// <para>The <see cref="SYSTEMTIME.DayOfWeek"/> member of the <see cref="SYSTEMTIME"/> structure is ignored.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// The calling process must have the <see cref="SE_SYSTEMTIME_NAME"/> privilege. This privilege is disabled by default. The <see cref="SetSystemTime"/> function enables the <see cref="SE_SYSTEMTIME_NAME"/> privilege before changing the system time and disables the privilege before returning. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecBP/running-with-special-privileges">Running with Special Privileges</a>.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-setsystemtime">SetSystemTime function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetSystemTime"/>
        /// <seealso cref="SYSTEMTIME"/>
        /// <seealso cref="SetSystemTimeAdjustment"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-time">System Time</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/time-functions">Time Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemTime(
            in SYSTEMTIME lpSystemTime
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 373
        #region GetVersionExA function
        /// <inheritdoc cref="GetVersionExA(ref OSVERSIONINFOEXA)"/>
        [Obsolete("GetVersionEx may be altered or unavailable for releases after Windows 8.1. Instead, use the Version Helper functions (https://docs.microsoft.com/windows/desktop/SysInfo/version-helper-apis)")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVersionExA(
            ref OSVERSIONINFOA lpVersionInformation
            );

        /// <inheritdoc cref="GetVersionExW(ref OSVERSIONINFOEXW)"/>
        [Obsolete("GetVersionEx may be altered or unavailable for releases after Windows 8.1. Instead, use the Version Helper functions (https://docs.microsoft.com/windows/desktop/SysInfo/version-helper-apis)")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVersionExA(
            ref OSVERSIONINFOEXA lpVersionInformation
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 382
        #region GetVersionExW function
        /// <inheritdoc cref="GetVersionExW(ref OSVERSIONINFOEXW)"/>
        [Obsolete("GetVersionEx may be altered or unavailable for releases after Windows 8.1. Instead, use the Version Helper functions (https://docs.microsoft.com/windows/desktop/SysInfo/version-helper-apis)")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVersionExW(
            ref OSVERSIONINFOW lpVersionInformation
            );

        /// <summary>
        /// <para>With the release of Windows 8.1, the behavior of the <see cref="GetVersionExW"/> API has changed in the value it will return for the operating system version. The value returned by the <see cref="GetVersionExW"/> function now depends on how the application is manifested.</para>
        /// <para>Applications not manifested for Windows 8.1 or Windows 10 will return the Windows 8 OS version value (6.2). Once an application is manifested for a given operating system version, <see cref="GetVersionExW"/> will always return the version that the application is manifested for in future releases. To manifest your applications for Windows 8.1 or Windows 10, refer to <a href="https://docs.microsoft.com/windows/desktop/SysInfo/targeting-your-application-at-windows-8-1">Targeting your application for Windows</a>.</para>
        /// </summary>
        /// <param name="lpVersionInformation">
        /// <para>A reference to a <see cref="OSVERSIONINFOW"/> or <see cref="OSVERSIONINFOEXW"/> structure that receives the operating system information.</para>
        /// <para>Before calling the <see cref="GetVersionExW"/> function, set the <see cref="OSVERSIONINFOEXW.dwOSVersionInfoSize"/> member of the structure as appropriate to indicate which data structure is being passed to this function.</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is a <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="GetLastError"/>. The function fails if you specify an invalid value for the <see cref="OSVERSIONINFOEXW.dwOSVersionInfoSize"/> member of the <see cref="OSVERSIONINFOW"/> or <see cref="OSVERSIONINFOEXW"/> structure.</para>
        /// </returns>
        /// <remarks>
        /// <para>Identifying the current operating system is usually not the best way to determine whether a particular operating system feature is present. This is because the operating system may have had new features added in a redistributable DLL. Rather than using <see cref="GetVersionExW"/> to determine the operating system platform or version number, test for the presence of the feature itself. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SysInfo/operating-system-version">Operating System Version</a>.</para>
        /// <para>
        /// The <see cref="GetSystemMetrics"/> function provides additional information about the current operating system.
        /// <list type="table">
        /// <listheader><term>Product</term><description>Setting</description></listheader>
        /// <item><term>Windows XP Media Center Edition</term><description>SM_MEDIACENTER</description></item>
        /// <item><term>Windows XP Starter Edition</term><description>SM_STARTER</description></item>
        /// <item><term>Windows XP Tablet PC Edition</term><description>SM_TABLETPC</description></item>
        /// <item><term>Windows Server 2003 R2</term><description>SM_SERVERR2</description></item>
        /// </list>
        /// </para>
        /// <para>To check for specific operating systems or operating system features, use the <see cref="IsOS"/> function. The <see cref="GetProductInfo"/> function retrieves the product type.</para>
        /// <para>To retrieve information for the operating system on a remote computer, use the <see cref="NetWkstaGetInfo"/> function, the <see cref="Win32_OperatingSystem"/> WMI class, or the <see cref="IADsComputer.OperatingSystem"/> property of the <see cref="IADsComputer"/> interface.</para>
        /// <para>To compare the current system version to a required version, use the <see cref="VerifyVersionInfo"/> function instead of using <see cref="GetVersionExW"/> to perform the comparison yourself.</para>
        /// <para>If compatibility mode is in effect, the <see cref="GetVersionExW"/> function reports the operating system as it identifies itself, which may not be the operating system that is installed. For example, if compatibility mode is in effect, <see cref="GetVersionExW"/> reports the operating system that is selected for <a href="http://go.microsoft.com/fwlink/p/?linkid=115300">application compatibility</a>.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getversionexw">GetVersionExW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetVersion"/>
        /// <seealso cref="OSVERSIONINFOW"/>
        /// <seealso cref="OSVERSIONINFOEXW"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/operating-system-version">Operating System Version</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/system-information-functions">System Information Functions</seealso>
        /// <seealso cref="VerifyVersionInfo"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/version-helper-apis">Version Helper functions</seealso>
        [Obsolete("GetVersionEx may be altered or unavailable for releases after Windows 8.1. Instead, use the Version Helper functions (https://docs.microsoft.com/windows/desktop/SysInfo/version-helper-apis)")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVersionExW(
            ref OSVERSIONINFOEXW lpVersionInformation
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line: 397
        #region GetLogicalProcessorInformation function
        /// <summary>
        /// Retrieves information about logical processors and related hardware.
        /// <para>To retrieve information about logical processors and related hardware, including processor groups, use the <see cref="GetLogicalProcessorInformationEx"/> function.</para>
        /// </summary>
        /// <param name="Buffer">A writable <see cref="Span{SYSTEM_LOGICAL_PROCESSOR_INFORMATION}"/> that receives an array of <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"/> structures. If the function fails, the contents of this buffer are undefined.</param>
        /// <param name="ReturnedLength">If the buffer is large enough to contain all of the data, this function succeeds and <paramref name="ReturnedLength"/> is set to the number of bytes returned. If the buffer is not large enough to contain all of the data, the function fails, <see cref="GetLastError"/> returns <see cref="ERROR_INSUFFICIENT_BUFFER"/>, and <paramref name="ReturnedLength"/> is set to the buffer length required to contain all of the data. If the function fails with an error other than <see cref="ERROR_INSUFFICIENT_BUFFER"/>, the value of <paramref name="ReturnedLength"/> is undefined.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/> and at least one <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"/> structure is written to the output buffer.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="GetLastError"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// <see cref="GetLogicalProcessorInformation"/> can be used to get information about the relationship between logical processors in the system, including:
        /// <list type="bullet">
        /// <item>The logical processors that are part of a <a href="https://docs.microsoft.com/windows/desktop/ProcThread/numa-support">NUMA</a> node.</item>
        /// <item>The logical processors that share resources. An example of this type of resource sharing would be hyperthreading scenarios.</item>
        /// </list>
        /// </para>
        /// <para> Your application can use this information when affinitizing your threads and processes to take best advantage of the hardware properties of the platform, or to determine the number of logical and physical processors for licensing purposes. </para>
        /// <para>
        /// Each of the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"/> structures returned in the buffer contains the following:
        /// <list type="bullet">
        /// <item>A logical processor affinity mask, which indicates the logical processors that the information in the structure applies to.</item>
        /// <item>A logical processor mask of type <see cref="LOGICAL_PROCESSOR_RELATIONSHIP"/>, which indicates the relationship between the logical processors in the mask. Applications calling this function must be prepared to handle additional indicator values in the future.</item>
        /// </list>
        /// </para>
        /// <para> Note that the order in which the structures are returned in the buffer may change between calls to this function. </para>'
        /// <para>The size of the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"/> structure varies between processor architectures and versions of Windows. For this reason, applications should first call this function to obtain the required buffer size, then dynamically allocate memory for the buffer.</para>
        /// <para>On systems with more than 64 logical processors, the <see cref="GetLogicalProcessorInformation"/> function retrieves logical processor information about processors in the processor group to which the calling thread is currently assigned. Use the <see cref="GetLogicalProcessorInformationEx"/> function to retrieve information about processors in all processor groups on the system.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows Vista, Windows XP Professional x64 Edition, Windows XP with SP3 [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getlogicalprocessorinformation">GetLogicalProcessorInformation function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetLogicalProcessorInformationEx"/>
        /// <seealso cref="LOGICAL_PROCESSOR_RELATIONSHIP"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/ProcThread/process-and-thread-functions">Process and Thread Functions</seealso>
        /// <seealso cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"/>
        public static unsafe bool GetLogicalProcessorInformation(
            Span<SYSTEM_LOGICAL_PROCESSOR_INFORMATION> Buffer,
            out int ReturnedLength
            )
        {
            ReturnedLength = Buffer.Length * SizeOf<SYSTEM_LOGICAL_PROCESSOR_INFORMATION>.Bytes;
            fixed (SYSTEM_LOGICAL_PROCESSOR_INFORMATION* pBuffer = Buffer)
                return GetLogicalProcessorInformationExtern(pBuffer, ref ReturnedLength);
        }

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, EntryPoint = nameof(GetLogicalProcessorInformation), SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern unsafe bool GetLogicalProcessorInformationExtern(
            SYSTEM_LOGICAL_PROCESSOR_INFORMATION* Buffer,
            ref int ReturnedLength
            );
        #endregion
    }
}
