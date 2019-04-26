using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12329
    /// <summary>
    /// Represents the number and affinity of processors in a processor group.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-processor_group_info">PROCESSOR_GROUP_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="GROUP_RELATIONSHIP"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSOR_GROUP_INFO
    {
        /// <summary>
        /// The maximum number of processors in the group.
        /// </summary>
        public byte MaximumProcessorCount;
        /// <summary>
        /// The number of active processors in the group.
        /// </summary>
        public byte ActiveProcessorCount;
        #region public byte Reserved[38];
        [StructLayout(LayoutKind.Explicit, Size = sizeof(byte) * Length)]
        private struct DUMMYSTRUCTNAME
        {
            public const int Length = 38;
            public Span<byte> Span => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref this));
            public ref byte this[int index] => ref Span[index];
        }
        private DUMMYSTRUCTNAME ReservedField;
        /// <summary>This member is reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Span<byte> Reserved => ReservedField.Span;
        #endregion
        /// <summary>
        /// A bitmap that specifies the affinity for zero or more active processors within the group.
        /// </summary>
        public UIntPtr ActiveProcessorMask;

    }
}
