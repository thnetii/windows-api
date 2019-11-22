using System;

using Xunit;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;

    public static class GetSystemTimeAsFileTime
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
            var start = DateTime.UtcNow - TimeSpan.FromSeconds(0.5);
            GetSystemTimeAsFileTime(out var filetime);
            var end = DateTime.UtcNow + TimeSpan.FromSeconds(0.5);
            var dt = DateTime.FromFileTimeUtc(filetime.QuadDateTime);

            Assert.InRange(dt, start, end);
        }
    }
}
