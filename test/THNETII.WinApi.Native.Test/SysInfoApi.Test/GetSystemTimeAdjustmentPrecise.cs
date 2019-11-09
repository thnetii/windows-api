using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetSystemTimeAdjustmentPrecise
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
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
