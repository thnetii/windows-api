using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    using static LOGICAL_PROCESSOR_RELATIONSHIP;
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12255
    /// <summary>
    /// Represents information about affinity within a processor group. This structure is used with the <see cref="GetLogicalProcessorInformationEx"/> function.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="PROCESSOR_RELATIONSHIP"/> structure describes the logical processors associated with either a processor core or a processor package.</para>
    /// <para>If the <see cref="PROCESSOR_RELATIONSHIP"/> structure represents a processor core, the <see cref="GroupCount"/> member is always <c>1</c>.</para>
    /// <para>If the <see cref="PROCESSOR_RELATIONSHIP"/> structure represents a processor package, the <see cref="GroupCount"/> member is <c>1</c> only if all processors are in the same processor group. If the package contains more than one NUMA node, the system might assign different NUMA nodes to different processor groups. In this case, the <see cref="GroupCount"/> member is the number of groups to which NUMA nodes in the package are assigned.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-processor_relationship">PROCESSOR_RELATIONSHIP structure</a></para>
    /// </remarks>
    /// <seealso cref="GROUP_AFFINITY"/>
    /// <seealso cref="GetLogicalProcessorInformationEx"/>
    /// <seealso cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSOR_RELATIONSHIP
    {
        /// <summary>
        /// <para>If the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Relationship"/> member of the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"/> structure is <see cref="RelationProcessorCore"/>, this member is <see cref="LTP_PC_SMT"/> if the core has more than one logical processor, or <c>0</c> (zero) if the core has one logical processor.</para>
        /// <para>If the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Relationship"/> member of the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"/> structure is <see cref="RelationProcessorPackage"/>, this member is always <c>0</c> (zero).</para>
        /// </summary>
        public byte Flags;
        /// <summary>
        /// <para>If the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Relationship"/> member of the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"/> structure is <see cref="RelationProcessorCore"/>, <see cref="EfficiencyClass"/> specifies the intrinsic tradeoff between performance and power for the applicable core. A core with a higher value for the efficiency class has intrinsically greater performance and less efficiency than a core with a lower value for the efficiency class. <see cref="EfficiencyClass"/> is only nonzero on systems with a heterogeneous set of cores.</para>
        /// <para>If the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Relationship"/> member of the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"/> structure is <see cref="RelationProcessorPackage"/>, <see cref="EfficiencyClass"/> is always <c>0</c> (zero).</para>
        /// <para>The minimum operating system version that supports this member is Windows 10.</para>
        /// </summary>
        public byte EfficiencyClass;
        #region public byte Reserved[20];
        [StructLayout(LayoutKind.Explicit, Size = sizeof(byte) * Length)]
        private struct DUMMYSTRUCTNAME
        {
            public const int Length = 20;
            public Span<byte> Span => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref this));
            public ref byte this[int index] => ref Span[index];
        }
        private DUMMYSTRUCTNAME ReservedField;
        /// <summary>This member is reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Span<byte> Reserved => ReservedField.Span;
        #endregion
        /// <summary>
        /// This member specifies the number of entries in <see cref="GroupMask"/>. For more information, see Remarks.
        /// </summary>
        public short GroupCount;
        #region public GROUP_AFFINITY GroupMask[];
        internal GROUP_AFFINITY GroupMaskField;
        /// <summary>
        /// A span of <see cref="GROUP_AFFINITY"/> structures. The <see cref="GroupCount"/> member specifies the number of structures in the span. Each structure in the span specifies a group number and processor affinity within the group. 
        /// </summary>
        public Span<GROUP_AFFINITY> GroupMask => SpanOverRef.GetSpan(ref GroupMaskField, GroupCount);
        #endregion
    }
}
