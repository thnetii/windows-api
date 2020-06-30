namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetSystemTime
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
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
    }
}
