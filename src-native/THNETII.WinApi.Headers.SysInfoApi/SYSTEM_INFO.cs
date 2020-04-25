using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.SysInfoApi
{
    using static LOGICAL_PROCESSOR_RELATIONSHIP;
    using static PROCESSOR_ARCHITECTURE;
    using static SysInfoApiFunctions;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line 47
    /// <summary>
    /// Contains information about the current computer system. This includes the architecture and type of the processor, the number of processors in the system, the page size, and other such information.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/ns-sysinfoapi-system_info">SYSTEM_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="GetNativeSystemInfo"/>
    /// <seealso cref="GetSystemInfo"/>
    /// <seealso cref="MapViewOfFile"/>
    /// <seealso cref="MapViewOfFileEx"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO
    {
        [StructLayout(LayoutKind.Explicit)]
        private struct DUMMYUNIONNAME
        {
            [FieldOffset(0)]
            [Obsolete("Obsolete field...do not use")]
            public int dwOemId;
            [FieldOffset(0), MarshalAs(UnmanagedType.U2)]
            public PROCESSOR_ARCHITECTURE wProcessorArchitecture;
            [FieldOffset(sizeof(short))]
            public short wReserved;
        }

        private DUMMYUNIONNAME u;

        /// <summary>
        /// An obsolete member that is retained for compatibility. Applications should use the <see cref="wProcessorArchitecture"/> member.
        /// </summary>
        [Obsolete("Obsolete member that is retained for compatibility. Applications should use the " + nameof(wProcessorArchitecture) + " member.")]
        public int dwOemId
        {
            get => u.dwOemId;
            set => u.dwOemId = value;
        }

        /// <summary>
        /// The processor architecture of the installed operating system.
        /// </summary>
        public PROCESSOR_ARCHITECTURE wProcessorArchitecture
        {
            get => u.wProcessorArchitecture;
            set => u.wProcessorArchitecture = value;
        }

        /// <summary>
        /// This member is reserved for future use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public short wReserved
        {
            get => u.wReserved;
            set => u.wReserved = value;
        }

        /// <summary>
        /// The page size and the granularity of page protection and commitment. This is the page size used by the <see cref="VirtualAlloc"/> function.
        /// </summary>
        public int dwPageSize;
        /// <summary>
        /// A pointer to the lowest memory address accessible to applications and dynamic-link libraries (DLLs).
        /// </summary>
        public IntPtr lpMinimumApplicationAddress;
        /// <summary>
        /// A pointer to the highest memory address accessible to applications and DLLs.
        /// </summary>
        public IntPtr lpMaximumApplicationAddress;
        /// <summary>
        /// A mask representing the set of processors configured into the system. Bit 0 is processor 0; bit 31 is processor 31.
        /// </summary>
        public int dwActiveProcessorMask;
        /// <summary>
        /// The number of logical processors in the current group. To retrieve this value, use the <see cref="GetLogicalProcessorInformation"/> function.
        /// <para><note>For information about the physical processors shared by logical processors, call <see cref="GetLogicalProcessorInformationEx"/> with the <em>RelationshipType</em> parameter set to <see cref="RelationProcessorPackage"/> (3).</note></para>
        /// </summary>
        public int dwNumberOfProcessors;
        /// <summary>
        /// An obsolete member that is retained for compatibility. Use the <see cref="wProcessorArchitecture"/>, <see cref="wProcessorLevel"/>, and <see cref="wProcessorRevision"/> members to determine the type of processor.
        /// </summary>
        [Obsolete("Obsolete member that is retained for compatibility. Use the " + nameof(wProcessorArchitecture) + ", " + nameof(wProcessorLevel) + ", and " + nameof(wProcessorRevision) + " members to determine the type of processor.")]
        [MarshalAs(UnmanagedType.I4)]
        public PROCESSOR_MODEL dwProcessorType;
        /// <summary>
        /// The granularity for the starting address at which virtual memory can be allocated. For more information, see <see cref="VirtualAlloc"/>.
        /// </summary>
        public int dwAllocationGranularity;
        /// <summary>
        /// The architecture-dependent processor level. It should be used only for display purposes. To determine the feature set of a processor, use the <see cref="IsProcessorFeaturePresent"/> function.
        /// <para>If <see cref="wProcessorArchitecture"/> is <see cref="PROCESSOR_ARCHITECTURE_INTEL"/>, <see cref="wProcessorLevel"/> is defined by the CPU vendor.</para>
        /// <para>If <see cref="wProcessorArchitecture"/> is <see cref="PROCESSOR_ARCHITECTURE_IA64"/>, <see cref="wProcessorLevel"/> is set to 1.</para>
        /// </summary>
        public short wProcessorLevel;
        /// <summary>
        /// The architecture-dependent processor revision. The following table shows how the revision value is assembled for each type of processor architecture.
        /// <list type="table">
        /// <listheader><term>Processor</term><description>Value</description></listheader>
        /// <item><term>Intel Pentium, Cyrix, or NextGen 586</term><description>The high byte is the model and the low byte is the stepping. For example, if the value is <em>xxyy</em>, the model number and stepping can be displayed as follows: <code>Model <em>xx</em>, Stepping <em>yy</em></code></description></item>
        /// <item><term>Intel 80386 or 80486</term><description>A value of the form <em>xxyz</em>.<br/>If <em>xx</em> is equal to <c>0xFF</c>, <c><em>y</em> - 0xA</c> is the model number, and <em>z</em> is the stepping identifier.<br/>If <em>xx</em> is not equal to <c>0xFF</c>, <c><em>xx</em> + 'A'</c> is the stepping letter and <em>yz</em> is the minor stepping.</description></item>
        /// <item><term>ARM</term><description>Reserved.</description></item>
        /// </list>
        /// </summary>
        public short wProcessorRevision;
    }
}
