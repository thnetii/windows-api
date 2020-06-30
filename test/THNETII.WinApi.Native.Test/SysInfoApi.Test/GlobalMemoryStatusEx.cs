using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GlobalMemoryStatusEx
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
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
    }
}
