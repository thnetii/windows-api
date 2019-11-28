using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 952
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_NegoKeys
    {
        public int KeyType;
        public ushort KeyLength;
        public byte* KeyValuePointer;
        public Span<byte> KeyValue => new Span<byte>(KeyValuePointer, KeyLength);
        public int VerifyKeyType;
        public ushort VerifyKeyLength;
        public byte* VerifyKeyValuePointer;
        public Span<byte> VerifyKeyValue => new Span<byte>(VerifyKeyValuePointer, VerifyKeyLength);
    }
}
