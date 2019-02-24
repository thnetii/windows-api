using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct XSAVE_AREA_HEADER
    {
        public ulong Mask;
        public ulong CompactionMask;
        #region public ulong Reserved2[6];
        internal Reserved2Field Reserved2FieldValue;
        [StructLayout(LayoutKind.Explicit, Pack = 8, Size = 6 * sizeof(ulong))]
        internal struct Reserved2Field
        {
            public const int Length = 6;
            public ref ulong this[int index] => ref Span[index];
            public Span<ulong> Span => MemoryMarshal.Cast<Reserved2Field, ulong>(SpanOverRef.GetSpan(ref this));
        }
        internal Span<ulong> Reserved2 => Reserved2FieldValue.Span;
        #endregion
    }
}
