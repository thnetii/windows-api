using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1100
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_Target
    {
        public int TargetLength;
        public byte* TargetPointer;
        public Span<byte> Target => new Span<byte>(TargetPointer, TargetLength);
    }
}
