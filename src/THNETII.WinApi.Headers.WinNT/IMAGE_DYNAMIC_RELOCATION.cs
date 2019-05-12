using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17861
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct IMAGE_DYNAMIC_RELOCATION
    {
        public IntPtr Symbol;
        public int BaseRelocSize;
        public unsafe Span<IMAGE_BASE_RELOCATION> BaseRelocations
        {
            get
            {
                fixed (IMAGE_DYNAMIC_RELOCATION* ptr = &this)
                {
                    void* pSpan = ptr + 1;
                    return new Span<IMAGE_BASE_RELOCATION>(pSpan, BaseRelocSize);
                }
            }
        }
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17827
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct IMAGE_DYNAMIC_RELOCATION32
    {
        public int Symbol;
        public int BaseRelocSize;
        public unsafe Span<IMAGE_BASE_RELOCATION> BaseRelocations
        {
            get
            {
                fixed (IMAGE_DYNAMIC_RELOCATION32* ptr = &this)
                {
                    void* pSpan = ptr + 1;
                    return new Span<IMAGE_BASE_RELOCATION>(pSpan, BaseRelocSize);
                }
            }
        }
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17833
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct IMAGE_DYNAMIC_RELOCATION64
    {
        public long Symbol;
        public int BaseRelocSize;
        public unsafe Span<IMAGE_BASE_RELOCATION> BaseRelocations
        {
            get
            {
                fixed (IMAGE_DYNAMIC_RELOCATION64* ptr = &this)
                {
                    void* pSpan = ptr + 1;
                    return new Span<IMAGE_BASE_RELOCATION>(pSpan, BaseRelocSize);
                }
            }
        }
    }
}
