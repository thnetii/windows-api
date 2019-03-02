using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct XSTATE_CONTEXT
    {
        public ulong Mask;
        public int Length;
        internal int Reserved1;
        public XSAVE_AREA* AreaPtr;
        public Span<XSAVE_AREA> Area => new Span<XSAVE_AREA>(AreaPtr, Length);
        public IntPtr Buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct XSTATE_CONTEXT_X86
    {
        public ulong Mask;
        public int Length;
        internal int Reserved1;
        public XSAVE_AREA* AreaPtr;
        public Span<XSAVE_AREA> Area => new Span<XSAVE_AREA>(AreaPtr, Length);
        internal int Reserved2;
        public IntPtr Buffer;
        internal int Reserved3;
    }
}
