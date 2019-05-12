using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17882
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct IMAGE_PROLOGUE_DYNAMIC_RELOCATION_HEADER
    {
        public byte PrologueByteCount;
        public Span<byte> PrologueBytes =>
            SpanAfterStruct.GetSpan<IMAGE_PROLOGUE_DYNAMIC_RELOCATION_HEADER, byte>(ref this, PrologueByteCount);
    }
}
