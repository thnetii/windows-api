namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetSystemTimePreciseAsFileTime
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
            GetSystemTimePreciseAsFileTime(out var filetime);

            _ = filetime;
        }
    }
}
