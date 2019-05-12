using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17861
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct IMAGE_DYNAMIC_RELOCATION_V2
    {
        public int HeaderSize;
        public int FixupInfoSize;
        public IntPtr Symbol;
        public int SymbolGroup;
        public int Flags;
        // ...     variable length header fields
        // BYTE    FixupInfo[FixupInfoSize]
        public unsafe Span<byte> FixupInfo
        {
            get
            {
                fixed (IMAGE_DYNAMIC_RELOCATION_V2* ptr = &this)
                {
                    void* pSpan = ptr + 1;
                    return new Span<byte>(pSpan, FixupInfoSize);
                }
            }
        }
    }
}
