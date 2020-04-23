using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.InteropServices.Memory;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12353
    /// <summary>
    /// <para>This structure is returned by <see cref="GetSystemCpuSetInformation"/>. It is used to enumerate the CPU Sets on the system and determine their current state.</para>
    /// <para>This is a variable-sized structure designed for future expansion. When iterating over this structure, use the size field to determine the offset to the next structure.</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-system_cpu_set_information">SYSTEM_CPU_SET_INFORMATION structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_CPU_SET_INFORMATION
    {
        public static int SizeOf { get; } = SizeOf<SYSTEM_CPU_SET_INFORMATION>.Bytes;

        /// <summary>
        /// This is the size, in bytes, of this information structure.
        /// </summary>
        public int Size;
        /// <summary>
        /// This is the type of information in the structure. Applications should skip any structures with unrecognized types.
        /// </summary>
        public CPU_SET_INFORMATION_TYPE Type;
        /// <summary>
        /// The ID of the specified CPU Set. This identifier can be used with <see cref="SetProcessDefaultCpuSets"/> or <see cref="SetThreadSelectedCpuSets"/> when specifying a list of CPU Sets to affinitize to.
        /// </summary>
        public int Id;
        /// <summary>
        /// Specifies the Processor Group of the CPU Set. All other values in the structure are relative to the processor group.
        /// </summary>
        public short Group;
        /// <summary>
        /// Specifies the group-relative index of the home processor of the CPU Set. Unless the CPU Set is parked for thermal or power management reasons or assigned for exclusive use to another application, threads will run on the home processor of one of their CPU Sets. The <see cref="Group"/> and <see cref="LogicalProcessorIndex"/> fields are the same as the ones found in the <see cref="PROCESSOR_NUMBER"/> structure and they correspond to the <see cref="GROUP_AFFINITY.Group"/> field and <see cref="GROUP_AFFINITY.Mask"/> field of the <see cref="GROUP_AFFINITY"/> structure.
        /// </summary>
        public byte LogicalProcessorIndex;
        /// <summary>
        /// A group-relative value indicating which "Core" has the home processor of the CPU Set. This number is the same for all CPU Sets in the same group that share significant execution resources with each other, such as different hardware threads on a single core that supports simultaneous multi-threading.
        /// </summary>
        public byte CoreIndex;
        /// <summary>
        /// A group-relative value indicating which CPU Sets share at least one level of cache with each other. This value is the same for all CPU Sets in a group that are on processors that share cache with each other.
        /// </summary>
        public byte LastLevelCacheIndex;
        /// <summary>
        /// A group-relative value indicating which NUMA node a CPU Set is on. All CPU Sets in a given group that are on the same NUMA node will have the same value for this field.
        /// </summary>
        public byte NumaNodeIndex;
        /// <summary>
        /// A value indicating the intrinsic energy efficiency of a processor for systems that support heterogeneous processors (such as ARM big.LITTLE systems). CPU Sets with higher numerical values of this field have home processors that are faster but less power-efficient than ones with lower values.
        /// </summary>
        public byte EfficiencyClass;
        private static readonly Bitfield8 bfParked = Bitfield8.Bit(0);
        private static readonly Bitfield8 bfAllocated = Bitfield8.Bit(1);
        private static readonly Bitfield8 bfAllocatedToTargetProcess = Bitfield8.Bit(2);
        private static readonly Bitfield8 bfRealTime = Bitfield8.Bit(3);
        private static readonly Bitfield8 bfReservedFlags = Bitfield8.RemainingBits(4);
        public byte AllFlags;
        public bool Parked
        {
            get => bfParked.ReadBool(AllFlags);
            set => bfParked.WriteBool(ref AllFlags, value);
        }
        public bool Allocated
        {
            get => bfAllocated.ReadBool(AllFlags);
            set => bfAllocated.WriteBool(ref AllFlags, value);
        }
        public bool AllocatedToTargetProcess
        {
            get => bfAllocatedToTargetProcess.ReadBool(AllFlags);
            set => bfAllocatedToTargetProcess.WriteBool(ref AllFlags, value);
        }
        public bool RealTime
        {
            get => bfRealTime.ReadBool(AllFlags);
            set => bfRealTime.WriteBool(ref AllFlags, value);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal byte ReservedFlags
        {
            get => bfReservedFlags.Read(AllFlags);
            set => bfReservedFlags.Write(ref AllFlags, value);
        }
        [StructLayout(LayoutKind.Explicit)]
        private struct DUMMYUNIONNAME3
        {
            [FieldOffset(0)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            internal int Reserved;
            [FieldOffset(0)]
            public byte SchedulingClass;
        }
        private DUMMYUNIONNAME3 u3;
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal int Reserved
        {
            get => u3.Reserved;
            set => u3.Reserved = value;
        }
        public byte SchedulingClass
        {
            get => u3.SchedulingClass;
            set => u3.SchedulingClass = value;
        }
        /// <summary>
        /// Specifies a tag used by Core Allocation to communicate a given allocated CPU Set between threads in different components.
        /// </summary>
        public long AllocationTag;
    }
}
