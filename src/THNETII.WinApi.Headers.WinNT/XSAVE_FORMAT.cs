using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Format of data for (F)XSAVE/(F)XRSTOR instruction
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public struct XSAVE_FORMAT
    {
        public ushort ControlWord;
        public ushort StatusWord;
        public byte TagWord;
        internal byte Reserved1;
        public ushort ErrorOpcode;
        public uint ErrorOffset;
        public ushort ErrorSelector;
        internal ushort Reserved2;
        public uint DataOffset;
        public ushort DataSelector;
        internal ushort Reserved3;
        public uint MxCsr;
        public uint MxCsr_Mask;
        #region public M128A FloatRegisters[8];
        internal FloatRegistersField FloatRegistersFieldValue;
        [StructLayout(LayoutKind.Sequential, Pack = 16)]
        internal struct FloatRegistersField
        {
            public const int Length = 8;
            public ref M128A this[int index] => ref Span[index];
            public Span<M128A> Span => MemoryMarshal.Cast<FloatRegistersField, M128A>(SpanOverRef.GetSpan(ref this));
            private M128A Register0;
            private M128A Register1;
            private M128A Register2;
            private M128A Register3;
            private M128A Register4;
            private M128A Register5;
            private M128A Register6;
            private M128A Register7;
        }
        public Span<M128A> FloatRegisters => FloatRegistersFieldValue.Span;
        #endregion
        #region public M128A XmmRegisters[8];
        internal XmmRegistersField XmmRegistersFieldValue;
        [StructLayout(LayoutKind.Sequential, Pack = 16)]
        internal struct XmmRegistersField
        {
            public const int Length = 8;
            public ref M128A this[int index] => ref Span[index];
            public Span<M128A> Span => MemoryMarshal.Cast<XmmRegistersField, M128A>(SpanOverRef.GetSpan(ref this));
            private M128A Register0;
            private M128A Register1;
            private M128A Register2;
            private M128A Register3;
            private M128A Register4;
            private M128A Register5;
            private M128A Register6;
            private M128A Register7;
        }
        public Span<M128A> XmmRegisters => XmmRegistersFieldValue.Span;
        #endregion
        #region public byte Reserved4[224];
        internal Reserved4Field Reserved4FieldValue;
        [StructLayout(LayoutKind.Explicit, Pack = 16, Size = 224)]
        internal struct Reserved4Field
        {
            public const int Length = 224;
            public ref byte this[int index] => ref Span[index];
            public Span<byte> Span => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref this));
        }
        internal Span<byte> Reserved4 => Reserved4FieldValue.Span;
        #endregion
    }

    /// <summary>
    /// Format of data for (F)XSAVE/(F)XRSTOR instruction
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public struct XSAVE_FORMAT_WIN64
    {
        public ushort ControlWord;
        public ushort StatusWord;
        public byte TagWord;
        internal byte Reserved1;
        public ushort ErrorOpcode;
        public uint ErrorOffset;
        public ushort ErrorSelector;
        internal ushort Reserved2;
        public uint DataOffset;
        public ushort DataSelector;
        internal ushort Reserved3;
        public uint MxCsr;
        public uint MxCsr_Mask;
        #region public M128A FloatRegisters[8];
        internal FloatRegistersField FloatRegistersFieldValue;
        [StructLayout(LayoutKind.Sequential, Pack = 16)]
        internal struct FloatRegistersField
        {
            public const int Length = 8;
            public ref M128A this[int index] => ref Span[index];
            public Span<M128A> Span => MemoryMarshal.Cast<FloatRegistersField, M128A>(SpanOverRef.GetSpan(ref this));
            private M128A Register0;
            private M128A Register1;
            private M128A Register2;
            private M128A Register3;
            private M128A Register4;
            private M128A Register5;
            private M128A Register6;
            private M128A Register7;
        }
        public Span<M128A> FloatRegisters => FloatRegistersFieldValue.Span;
        #endregion
        #region public M128A XmmRegisters[16];
        internal XmmRegistersField XmmRegistersFieldValue;
        [StructLayout(LayoutKind.Sequential, Pack = 16)]
        internal struct XmmRegistersField
        {
            public const int Length = 16;
            public ref M128A this[int index] => ref Span[index];
            public Span<M128A> Span => MemoryMarshal.Cast<XmmRegistersField, M128A>(SpanOverRef.GetSpan(ref this));
            private M128A Register0;
            private M128A Register1;
            private M128A Register2;
            private M128A Register3;
            private M128A Register4;
            private M128A Register5;
            private M128A Register6;
            private M128A Register7;
            private M128A Register8;
            private M128A Register9;
            private M128A Register10;
            private M128A Register11;
            private M128A Register12;
            private M128A Register13;
            private M128A Register14;
            private M128A Register15;
        }
        public Span<M128A> XmmRegisters => XmmRegistersFieldValue.Span;
        #endregion
        #region public byte Reserved4[96];
        internal Reserved4Field Reserved4FieldValue;
        [StructLayout(LayoutKind.Explicit, Pack = 16, Size = 96)]
        internal struct Reserved4Field
        {
            public const int Length = 96;
            public ref byte this[int index] => ref Span[index];
            public Span<byte> Span => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref this));
        }
        internal Span<byte> Reserved4 => Reserved4FieldValue.Span;
        #endregion
    }
}
