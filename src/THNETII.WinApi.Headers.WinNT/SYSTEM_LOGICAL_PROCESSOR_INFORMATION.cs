using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    using static LOGICAL_PROCESSOR_RELATIONSHIP;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12283
    /// <summary>
    /// Describes the relationship between the specified processor set. This structure is used with the <see cref="GetLogicalProcessorInformation"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-system_logical_processor_information">SYSTEM_LOGICAL_PROCESSOR_INFORMATION structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION
    {
        /// <summary>
        /// <para>The processor mask identifying the processors described by this structure. A processor mask is a bit vector in which each set bit represents an active processor in the relationship. At least one bit will be set.</para>
        /// <para>On a system with more than 64 processors, the processor mask identifies processors in a single <a href="https://msdn.microsoft.com/c627ac0f-96e8-48b5-9103-4316f487e173">processor group</a>.</para>
        /// </summary>
        public UIntPtr ProcessorMask;
        /// <summary>
        /// The relationship between the processors identified by the value of the ProcessorMask member.
        /// </summary>
        /// <value>
        /// This member can be one of the following <see cref="LOGICAL_PROCESSOR_RELATIONSHIP"/> values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="RelationCache"/></term><description><para>The specified logical processors share a cache. The <see cref="Cache"/> member contains additional information.</para><para><strong>Windows Server 2003:</strong> This value is not supported until Windows Server 2003 with SP1 and Windows XP Professional x64 Edition.</para></description></item>
        /// <item><term><see cref="RelationNumaNode"/></term><description>The specified logical processors are part of the same NUMA node. The <see cref="NumaNode"/> member contains additional information.</description></item>
        /// <item><term><see cref="RelationProcessorCore"/></term><description>The specified logical processors share a single processor core. The <see cref="ProcessorCore"/> member contains additional information.</description></item>
        /// <item><term><see cref="RelationProcessorPackage"/></term><description><para>The specified logical processors share a physical package. There is no additional information available.</para><para><strong>Windows Server 2003 and Windows XP Professional x64 Edition:</strong> This value is not supported until Windows Server 2003 with SP1 and Windows XP with SP3.</para></description></item>
        /// </list>
        /// Future versions of Windows may support additional values for the <see cref="Relationship"/> member.
        /// </value>
        public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;
        public SYSTEM_LOGICAL_PROCESSOR_UNIFIED_INFORMATION Content;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct SYSTEM_LOGICAL_PROCESSOR_UNIFIED_INFORMATION
    {
        [FieldOffset(0)]
        public SYSTEM_LOGICAL_PROCESSOR_CORE_INFORMATION ProcessorCore;
        [FieldOffset(0)]
        public SYSTEM_LOGICAL_PROCESSOR_NUMA_NODE_INFORMATION NumaNode;
        /// <summary>
        /// <para>A <see cref="CACHE_DESCRIPTOR"/> structure that identifies the characteristics of a particular cache. There is one record returned for each cache reported. Some or all caches may not be reported, depending on the mechanism used by the processor to identify its caches. Therefore, do not assume the absence of any particular caches. Caches are not necessarily shared among logical processors.</para>
        /// <para>This structure contains valid data only if the <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION.Relationship"/> member is <see cref="RelationCache"/>.</para>
        /// <para><strong>Windows Server 2003:</strong> This member is not supported until Windows Server 2003 with SP1 and Windows XP Professional x64 Edition.</para>
        /// </summary>
        [FieldOffset(0)]
        public CACHE_DESCRIPTOR Cache;
        #region public fixed ulong Reserved[2];
        [FieldOffset(0)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal fixed ulong ReservedField[2];
        /// <summary>Reserved. Do not use.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public unsafe Span<ulong> Reserved
        {
            get
            {
                fixed (ulong* ptr = ReservedField)
                {
                    return new Span<ulong>(ptr, 2);
                }
            }
        }
        #endregion
    }

    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-system_logical_processor_information">SYSTEM_LOGICAL_PROCESSOR_INFORMATION structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_LOGICAL_PROCESSOR_CORE_INFORMATION
    {
        /// <summary>
        /// <para>If the value of this member is <c>1</c>, the logical processors identified by the value of the <see cref="ProcessorMask"/> member share functional units, as in Hyperthreading or SMT. Otherwise, the identified logical processors do not share functional units.</para>
        /// <para><strong>Windows Server 2003 and Windows XP Professional x64 Edition:</strong> This member is also 1 for cores that share a physical package. Therefore, to determine whether the processor supports multiple cores or hyperthreading on systems prior to Windows Vista, use the CPUID instruction.</para>
        /// </summary>
        public byte Flags;
    }

    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-system_logical_processor_information">SYSTEM_LOGICAL_PROCESSOR_INFORMATION structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_LOGICAL_PROCESSOR_NUMA_NODE_INFORMATION
    {
        /// <summary>
        /// Identifies the <a href="https://msdn.microsoft.com/a1263968-2b26-45cc-bdd7-6aa354821a5a">NUMA</a> node. The valid values of this parameter are 0 to the highest NUMA node number inclusive. A non-NUMA multiprocessor system will report that all processors belong to one NUMA node.
        /// </summary>
        public int NodeNumber;
    }
}
