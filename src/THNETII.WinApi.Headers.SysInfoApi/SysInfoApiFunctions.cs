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
    }
}
