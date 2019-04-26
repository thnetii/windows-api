using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    using static LOGICAL_PROCESSOR_RELATIONSHIP;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12336
    /// <summary>
    /// Contains information about the relationships of logical processors and related hardware. The <see cref="GetLogicalProcessorInformationEx"/> function uses this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-system_logical_processor_information_ex">SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX structure</a></para>
    /// </remarks>
    /// <seealso cref="CACHE_RELATIONSHIP"/>
    /// <seealso cref="GROUP_RELATIONSHIP"/>
    /// <seealso cref="NUMA_NODE_RELATIONSHIP"/>
    /// <seealso cref="PROCESSOR_RELATIONSHIP"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX
    {
        public static int SizeOf { get; } = SizeOf<SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX>.Bytes;

        /// <summary>
        /// The type of relationship between the logical processors.
        /// </summary>
        /// <value>
        /// This parameter can be one of the following <see cref="LOGICAL_PROCESSOR_RELATIONSHIP"/> values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="RelationCache"/></term><description>The specified logical processors share a cache. The <see cref="Cache"/> member contains additional information.</description></item>
        /// <item><term><see cref="RelationGroup"/></term><description>The specified logical processors share a processor group. The <see cref="Group"/> member contains additional information.</description></item>
        /// <item><term><see cref="RelationNumaNode"/></term><description>The specified logical processors are part of the same NUMA node. The <see cref="NumaNode"/> member contains additional information.</description></item>
        /// <item><term><see cref="RelationProcessorCore"/></term><description>The specified logical processors share a single processor core. The <see cref="Processor"/> member contains additional information.</description></item>
        /// <item><term><see cref="RelationProcessorPackage"/></term><description>The specified logical processors share a physical package. The <see cref="Processor"/> member contains additional information. </description></item>
        /// </list>
        /// </value>
        public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;
        /// <summary>
        /// The size of the structure.
        /// </summary>
        public int Size;
        #region public DUMMYUNIONNAME u;
        [StructLayout(LayoutKind.Explicit)]
        private struct DUMMYUNIONNAME
        {
            [FieldOffset(0)]
            public PROCESSOR_RELATIONSHIP Processor;
            [FieldOffset(0)]
            public NUMA_NODE_RELATIONSHIP NumaNode;
            [FieldOffset(0)]
            public CACHE_RELATIONSHIP Cache;
            [FieldOffset(0)]
            public GROUP_RELATIONSHIP Group;
        }
        private DUMMYUNIONNAME u;
        /// <summary>
        /// A <see cref="PROCESSOR_RELATIONSHIP"/> structure that describes processor affinity. This structure contains valid data only if the <see cref="Relationship"/> member is <see cref="RelationProcessorCore"/> or <see cref="RelationProcessorPackage"/>.
        /// </summary>
        public PROCESSOR_RELATIONSHIP Processor
        {
            get => u.Processor;
            set => u.Processor = value;
        }
        /// <summary>
        /// A <see cref="NUMA_NODE_RELATIONSHIP"/> structure that describes a NUMA node. This structure contains valid data only if the <see cref="Relationship"/> member is <see cref="RelationNumaNode"/>.
        /// </summary>
        public NUMA_NODE_RELATIONSHIP NumaNode
        {
            get => u.NumaNode;
            set => u.NumaNode = value;
        }
        /// <summary>
        /// A <see cref="CACHE_RELATIONSHIP"/> structure that describes cache attributes. This structure contains valid data only if the <see cref="Relationship"/> member is <see cref="RelationCache"/>.
        /// </summary>
        public CACHE_RELATIONSHIP Cache
        {
            get => u.Cache;
            set => u.Cache = value;
        }
        /// <summary>
        /// A <see cref="GROUP_RELATIONSHIP"/> structure that contains information about the processor groups. This structure contains valid data only if the <see cref="Relationship"/> member is <see cref="RelationGroup"/>.
        /// </summary>
        public GROUP_RELATIONSHIP Group
        {
            get => u.Group;
            set => u.Group = value;
        }
        #endregion
    }
}
