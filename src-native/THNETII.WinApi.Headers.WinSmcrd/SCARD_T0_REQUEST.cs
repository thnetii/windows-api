using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinSmcrd
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 290
    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_T0_REQUEST
    {
        public SCARD_IO_REQUEST ioRequest;
        public byte bSw1;
        public byte bSw2;           // Return codes from the instruction
        public SCARD_T0_COMMAND CmdBytes;
        public Span<byte> rgbHeader => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref CmdBytes));
    }
}
