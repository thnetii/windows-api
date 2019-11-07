using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.WinError;
using THNETII.WinApi.Native.WinNT;

using Xunit;

namespace THNETII.WinApi.Native.SysInfoApi.Test
{
    using static SysInfoApiFunctions;
    using static WinErrorConstants;

    public static class GetLogicalProcessorInformationEx
    {
        public static IEnumerable<object[]> Get_LOGICAL_PROCESSOR_RELATIONSHIP()
        {
            return Enum.GetValues(typeof(LOGICAL_PROCESSOR_RELATIONSHIP))
                .Cast<LOGICAL_PROCESSOR_RELATIONSHIP>()
                .Where(v => (int)v < (int)LOGICAL_PROCESSOR_RELATIONSHIP.RelationAll)
                .Select(v => new object[] { v });
        }

        [TheoryWindowsOS]
        [MemberData(nameof(Get_LOGICAL_PROCESSOR_RELATIONSHIP))]
        public static unsafe void Can_call_extern_function(LOGICAL_PROCESSOR_RELATIONSHIP relType)
        {
            bool successful = GetLogicalProcessorInformationEx(
                relType, default, out int bytesRequired);
            Assert.False(successful);
            int error_code = Marshal.GetLastWin32Error();
            Assert.Equal(ERROR_INSUFFICIENT_BUFFER, error_code);
            var buffer = new byte[bytesRequired];
            successful = GetLogicalProcessorInformationEx(
                relType, buffer, out int bytesWritten);
            if (!successful)
                throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
            Assert.Equal(bytesRequired, bytesWritten);
            fixed (byte* buffer_ptr = buffer)
            {
                for (int offset = 0, advance; offset < bytesWritten; offset += advance)
                {
                    ref SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX item =
                        ref Unsafe.AsRef<SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX>(
                            buffer_ptr + offset);
                    advance = item.Size;

                    switch (item.Relationship)
                    {
                        case LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorCore:
                        case LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorPackage:
                            ref PROCESSOR_RELATIONSHIP proc = ref item.Processor;
                            _ = proc.Flags;
                            _ = proc.EfficiencyClass;
                            foreach (ref GROUP_AFFINITY gi in proc.GroupMask)
                            {
                                _ = gi.Mask;
                                _ = gi.Group;
                            }
                            break;
                        case LOGICAL_PROCESSOR_RELATIONSHIP.RelationNumaNode:
                            ref NUMA_NODE_RELATIONSHIP numa = ref item.NumaNode;
                            _ = numa.NodeNumber;
                            ref GROUP_AFFINITY ngi = ref numa.GroupMask;
                            _ = ngi.Mask;
                            _ = ngi.Group;
                            break;
                        case LOGICAL_PROCESSOR_RELATIONSHIP.RelationCache:
                            ref CACHE_RELATIONSHIP cache = ref item.Cache;
                            _ = cache.Level;
                            _ = cache.Associativity;
                            _ = cache.LineSize;
                            _ = cache.Type;
                            ref GROUP_AFFINITY cgi = ref cache.GroupMask;
                            _ = cgi.Mask;
                            _ = cgi.Group;
                            break;
                        case LOGICAL_PROCESSOR_RELATIONSHIP.RelationGroup:
                            ref GROUP_RELATIONSHIP group = ref item.Group;
                            _ = group.MaximumGroupCount;
                            _ = group.ActiveGroupCount;
                            foreach (ref PROCESSOR_GROUP_INFO gi in group.GroupInfo)
                            {
                                _ = gi.MaximumProcessorCount;
                                _ = gi.ActiveProcessorCount;
                                _ = gi.ActiveProcessorMask;
                            }
                            break;
                    }
                }
            }
        }
    }
}
