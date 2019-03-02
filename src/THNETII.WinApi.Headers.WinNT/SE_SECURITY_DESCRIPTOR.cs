using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10451
    [StructLayout(LayoutKind.Sequential)]
    public struct SE_SECURITY_DESCRIPTOR
    {
        public int Size;
        public SE_SECURITY_DESCRIPTOR_FLAGS Flags;
        public IntPtr PSecurityDescriptor;
        public unsafe Span<byte> SecurityDescriptor => new Span<byte>(PSecurityDescriptor.ToPointer(), Size);
    }
}
