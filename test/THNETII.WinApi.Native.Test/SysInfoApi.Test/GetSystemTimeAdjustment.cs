using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetSystemTimeAdjustment
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
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
    }
}
