using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 129
    [StructLayout(LayoutKind.Sequential)]
    public struct SecHandle
    {
        public UIntPtr dwLower;
        public UIntPtr dwUpper;
    }
}
