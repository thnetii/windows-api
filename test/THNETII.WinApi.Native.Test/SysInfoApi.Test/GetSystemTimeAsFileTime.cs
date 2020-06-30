namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetSystemTimeAsFileTime
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
            GetSystemTimeAsFileTime(out var filetime);

            _ = filetime;
        }
    }
}
