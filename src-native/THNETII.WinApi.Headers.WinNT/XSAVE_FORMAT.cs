using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2531
    /// <summary>
    /// Format of data for (F)XSAVE/(F)XRSTOR instruction
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public unsafe struct XSAVE_FORMAT
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
        #region public fixed M128A FloatRegisters[8];
        internal fixed byte FloatRegistersField[8 * M128A.SizeOf];
        public Span<M128A> FloatRegisters
        {
            get
            {
                fixed (void* ptr = FloatRegistersField)
                {
                    return new Span<M128A>(ptr, 8);
                }
            }
        }
        #endregion
        #region public M128A XmmRegisters[8];
        internal fixed byte XmmRegistersField[8 * M128A.SizeOf];
        public Span<M128A> XmmRegisters
        {
            get
            {
                fixed (void* ptr = XmmRegistersField)
                {
                    return new Span<M128A>(ptr, 8);
                }
            }
        }
        #endregion
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Reserved4[224];
    }

    /// <summary>
    /// Format of data for (F)XSAVE/(F)XRSTOR instruction
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public unsafe struct XSAVE_FORMAT_WIN64
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
        #region public fixed M128A FloatRegisters[8];
        internal fixed byte FloatRegistersField[8 * M128A.SizeOf];
        public Span<M128A> FloatRegisters
        {
            get
            {
                fixed (void* ptr = FloatRegistersField)
                {
                    return new Span<M128A>(ptr, 8);
                }
            }
        }
        #endregion
        #region public M128A XmmRegisters[16];
        internal fixed byte XmmRegistersField[16 * M128A.SizeOf];
        public Span<M128A> XmmRegisters
        {
            get
            {
                fixed (void* ptr = XmmRegistersField)
                {
                    return new Span<M128A>(ptr, 8);
                }
            }
        }
        #endregion
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Reserved4[96];
    }
}
