using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12312
    /// <summary>
    /// Describes cache attributes. This structure is used with the <see cref="GetLogicalProcessorInformationEx"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-cache_relationship">CACHE_RELATIONSHIP structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct CACHE_RELATIONSHIP
    {
        /// <summary>The cache level.</summary>
        /// <value>
        /// This member can currently be one of the following values; other values may be supported in the future.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><c>1</c></term><description>L1</description></item>
        /// <item><term><c>2</c></term><description>L2</description></item>
        /// <item><term><c>3</c></term><description>L3</description></item>
        /// </list>
        /// </value>
        public byte Level;
        /// <summary>
        /// The cache associativity. If this member is <see cref="CACHE_FULLY_ASSOCIATIVE"/> (<c>0xFF</c>), the cache is fully associative.
        /// </summary>
        public byte Associativity;
        /// <summary>
        /// The cache line size, in bytes.
        /// </summary>
        public short LineSize;
        /// <summary>
        /// The cache size, in bytes.
        /// </summary>
        public int CacheSize;
        /// <summary>
        /// The cache type. This member is a <see cref="PROCESSOR_CACHE_TYPE"/> value.
        /// </summary>
        public PROCESSOR_CACHE_TYPE Type;
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
        /// A <see cref="GROUP_AFFINITY"/> structure that specifies a group number and processor affinity within the group.
        /// </summary>
        public GROUP_AFFINITY GroupMask;
    }
}
