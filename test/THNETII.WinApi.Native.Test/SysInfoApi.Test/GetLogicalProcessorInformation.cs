using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.WinError;
using THNETII.WinApi.Native.WinNT;

using Xunit;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;
    using static WinErrorConstants;

    public static class GetLogicalProcessorInformation
    {
        [FactWindowsOS]
        public static void Can_call_extern_function()
        {
            bool successful = GetLogicalProcessorInformation(default, out int bytesRequired);
            Assert.False(successful);
            int error_code = Marshal.GetLastWin32Error();
            Assert.Equal(ERROR_INSUFFICIENT_BUFFER, error_code);
            int length = Math.DivRem(
                bytesRequired,
                SizeOf<SYSTEM_LOGICAL_PROCESSOR_INFORMATION>.Bytes,
                out int remainder);
            Assert.Equal(0, remainder);
            Assert.NotEqual(0, length);
            var buffer = new SYSTEM_LOGICAL_PROCESSOR_INFORMATION[length];
            successful = GetLogicalProcessorInformation(buffer, out int bytesWritten);
            if (!successful)
                throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
            Assert.Equal(bytesRequired, bytesWritten);
            foreach (ref SYSTEM_LOGICAL_PROCESSOR_INFORMATION item in buffer.AsSpan())
            {
                _ = item.ProcessorMask;
                switch (item.Relationship)
                {
                    case LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorCore:
                    case LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorPackage:
                        ref SYSTEM_LOGICAL_PROCESSOR_CORE_INFORMATION proc =
                            ref item.Content.ProcessorCore;
                        _ = proc.Flags;
                        break;
                    case LOGICAL_PROCESSOR_RELATIONSHIP.RelationNumaNode:
                        ref SYSTEM_LOGICAL_PROCESSOR_NUMA_NODE_INFORMATION numa =
                            ref item.Content.NumaNode;
                        _ = numa.NodeNumber;
                        break;
                    case LOGICAL_PROCESSOR_RELATIONSHIP.RelationCache:
                        ref CACHE_DESCRIPTOR cache = ref item.Content.Cache;
                        _ = cache.Level;
                        _ = cache.Associativity;
                        _ = cache.LineSize;
                        _ = cache.Size;
                        _ = cache.Type;
                        break;
                }
            }
        }
    }
}
