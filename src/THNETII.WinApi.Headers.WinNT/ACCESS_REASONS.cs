using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10422
    [StructLayout(LayoutKind.Sequential)]
    public struct ACCESS_REASONS
    {
        public const int Length = 32;
        public ref ACCESS_REASON this[int index] => ref Data[index];
        public Span<ACCESS_REASON> Data => MemoryMarshal.Cast<ACCESS_REASONS, ACCESS_REASON>(SpanOverRef.GetSpan(ref this));
        internal ACCESS_REASON r0;
        internal ACCESS_REASON r1;
        internal ACCESS_REASON r2;
        internal ACCESS_REASON r3;
        internal ACCESS_REASON r4;
        internal ACCESS_REASON r5;
        internal ACCESS_REASON r6;
        internal ACCESS_REASON r7;
        internal ACCESS_REASON r8;
        internal ACCESS_REASON r9;
        internal ACCESS_REASON r10;
        internal ACCESS_REASON r11;
        internal ACCESS_REASON r12;
        internal ACCESS_REASON r13;
        internal ACCESS_REASON r14;
        internal ACCESS_REASON r15;
        internal ACCESS_REASON r16;
        internal ACCESS_REASON r17;
        internal ACCESS_REASON r18;
        internal ACCESS_REASON r19;
        internal ACCESS_REASON r20;
        internal ACCESS_REASON r21;
        internal ACCESS_REASON r22;
        internal ACCESS_REASON r23;
        internal ACCESS_REASON r24;
        internal ACCESS_REASON r25;
        internal ACCESS_REASON r26;
        internal ACCESS_REASON r27;
        internal ACCESS_REASON r28;
        internal ACCESS_REASON r29;
        internal ACCESS_REASON r30;
        internal ACCESS_REASON r31;
    }
}
