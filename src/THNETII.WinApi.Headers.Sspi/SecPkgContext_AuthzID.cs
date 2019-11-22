using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1088
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_AuthzID
    {
        public int AuthzIDLength;
        public byte* AuthzIDPointer;
        public Span<byte> AuthzID => new Span<byte>(AuthzIDPointer, AuthzIDLength);
    }
}
