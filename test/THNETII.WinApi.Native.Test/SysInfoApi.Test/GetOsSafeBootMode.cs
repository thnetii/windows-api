namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetOsSafeBootMode
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
            GetOsSafeBootMode(out var safebootmode);

            _ = safebootmode;
        }
    }
}
