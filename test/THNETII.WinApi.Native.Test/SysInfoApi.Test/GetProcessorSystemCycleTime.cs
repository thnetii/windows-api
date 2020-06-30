using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.WinError;
using THNETII.WinApi.Native.WinNT;

using Xunit;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;
    using static WinErrorConstants;

    public static class GetProcessorSystemCycleTime
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
            bool successful = GetProcessorSystemCycleTime(0, default,
                out int bytesRequired);
            Assert.False(successful);
            Assert.Equal(ERROR_INSUFFICIENT_BUFFER, Marshal.GetLastWin32Error());
            Span<SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION> buffer =
                new SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION[bytesRequired / SizeOf<SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION>.Bytes];
            successful = GetProcessorSystemCycleTime(0, buffer, out int bytesWritten);
            if (!successful)
                throw new Win32Exception(Marshal.GetLastWin32Error());
            Assert.Equal(bytesRequired, bytesWritten);
            foreach (ref SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION info in buffer)
            {
                _ = info.CycleTime;
            }
        }
    }
}
