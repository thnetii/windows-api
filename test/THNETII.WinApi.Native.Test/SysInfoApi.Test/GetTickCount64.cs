namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetTickCount64
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
            ulong ticks = GetTickCount64();

            _ = ticks;
        }
    }
}
