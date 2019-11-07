using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;
using Xunit;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class SysInfoApiFunctionsTest
    {
        [SkippableFact]
        public static void Call_GlobalMemoryStatusEx()
        {
            Skip.IfNot(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
            var memoryStatus = new MEMORYSTATUSEX { dwLength = MEMORYSTATUSEX.SizeOf };
            var successful = GlobalMemoryStatusEx(ref memoryStatus);
            if (!successful)
                throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());

            _ = memoryStatus.MemoryLoadPercentage;
            _ = memoryStatus.ullTotalPhys;
            _ = memoryStatus.ullAvailPhys;
            _ = memoryStatus.ullTotalPageFile;
            _ = memoryStatus.ullAvailPageFile;
            _ = memoryStatus.ullTotalVirtual;
            _ = memoryStatus.ullAvailVirtual;
        }

        [SkippableFact]
        public static void Call_GetSystemInfo()
        {
            Skip.IfNot(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
            GetSystemInfo(out var systemInfo);

            _ = systemInfo.wProcessorArchitecture;
            _ = systemInfo.dwPageSize;
            _ = systemInfo.lpMinimumApplicationAddress;
            _ = systemInfo.lpMaximumApplicationAddress;
            _ = systemInfo.dwActiveProcessorMask;
            _ = systemInfo.dwNumberOfProcessors;
            _ = systemInfo.dwAllocationGranularity;
            _ = systemInfo.wProcessorLevel;
            _ = systemInfo.wProcessorRevision;
        }

        [SkippableFact]
        public static void Call_GetSystemTime()
        {
            Skip.IfNot(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
            GetSystemTime(out var systemTime);

            _ = systemTime.wYear;
            _ = systemTime.wMonth;
            _ = systemTime.DayOfWeek;
            _ = systemTime.wDay;
            _ = systemTime.wHour;
            _ = systemTime.wMinute;
            _ = systemTime.wSecond;
            _ = systemTime.wMilliseconds;
        }

        [SkippableFact]
        public static void Call_GetSystemTimeAsFileTime()
        {
            Skip.IfNot(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
            GetSystemTimeAsFileTime(out var filetime);

            _ = filetime;
        }

        [SkippableFact]
        public static void Call_GetLocalTime()
        {
            Skip.IfNot(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
            GetLocalTime(out var localTime);

            _ = localTime.wYear;
            _ = localTime.wMonth;
            _ = localTime.DayOfWeek;
            _ = localTime.wDay;
            _ = localTime.wHour;
            _ = localTime.wMinute;
            _ = localTime.wSecond;
            _ = localTime.wMilliseconds;
        }

        [SkippableFact]
        public static void Call_GetTickCount64()
        {
            Skip.IfNot(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
            ulong ticks = GetTickCount64();

            _ = ticks;
        }

        [SkippableFact]
        public static void Call_GetSystemTimeAdjustment()
        {
            Skip.IfNot(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
            bool successful = GetSystemTimeAdjustment(
                out int adjust, out int incr, out bool disabled
                );
            if (!successful)
                throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
            if (!disabled)
            {
                _ = adjust;
                _ = incr;
            }
        }

        [SkippableFact]
        public static void Call_GetSystemTimeAdjustmentPrecise()
        {
            Skip.IfNot(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
            bool successful = GetSystemTimeAdjustmentPrecise(
                out long adjust, out long incr, out bool disabled
                );
            if (!successful)
                throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
            if (!disabled)
            {
                _ = adjust;
                _ = incr;
            }
        }
    }
}
