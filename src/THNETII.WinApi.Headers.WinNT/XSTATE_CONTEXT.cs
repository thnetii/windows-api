using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XSTATE_CONTEXT
    {
        public ulong Mask;
        public int Length;
        internal int Reserved1;
        public IntPtr Area;
        public Span<XSAVE_AREA> AreaAsSpan() =>
            new ArrayPtr<XSAVE_AREA>(Area).AsSpan(Length);
        public IntPtr Buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XSTATE_CONTEXT_X86
    {
        public ulong Mask;
        public int Length;
        internal int Reserved1;
        public IntPtr Area;
        public Span<XSAVE_AREA> AreaAsSpan() =>
            new ArrayPtr<XSAVE_AREA>(Area).AsSpan(Length);
        internal int Reserved2;
        public IntPtr Buffer;
        internal int Reserved3;
    }
}
