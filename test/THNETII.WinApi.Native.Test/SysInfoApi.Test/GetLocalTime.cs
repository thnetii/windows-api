namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetLocalTime
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
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
    }
}
