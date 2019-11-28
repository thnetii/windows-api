using System;

using Xunit;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetSystemTimePreciseAsFileTime
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
            var start = DateTime.UtcNow;
            GetSystemTimePreciseAsFileTime(out var filetime);
            var dt = DateTime.FromFileTimeUtc(filetime.QuadDateTime);
            var end = DateTime.UtcNow;

            Assert.InRange(dt, start, end);
        }
    }
}
