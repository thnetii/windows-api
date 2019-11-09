namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetNativeSystemInfo
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
            GetNativeSystemInfo(out var systemInfo);

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
    }
}
