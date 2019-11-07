using System;
using System.Runtime.InteropServices;
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
    }
}
