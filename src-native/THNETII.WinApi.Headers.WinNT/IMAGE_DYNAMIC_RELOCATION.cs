using System;
using System.Runtime.InteropServices;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17861
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct IMAGE_DYNAMIC_RELOCATION
    {
        public IntPtr Symbol;
        public int BaseRelocSize;
        public Span<IMAGE_BASE_RELOCATION> BaseRelocations =>
            SpanAfterStruct.GetSpan<IMAGE_DYNAMIC_RELOCATION, IMAGE_BASE_RELOCATION>(ref this, BaseRelocSize);
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17827
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct IMAGE_DYNAMIC_RELOCATION32
    {
        public int Symbol;
        public int BaseRelocSize;
        public Span<IMAGE_BASE_RELOCATION> BaseRelocations =>
            SpanAfterStruct.GetSpan<IMAGE_DYNAMIC_RELOCATION32, IMAGE_BASE_RELOCATION>(ref this, BaseRelocSize);
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17833
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct IMAGE_DYNAMIC_RELOCATION64
    {
        public long Symbol;
        public int BaseRelocSize;
        public Span<IMAGE_BASE_RELOCATION> BaseRelocations =>
            SpanAfterStruct.GetSpan<IMAGE_DYNAMIC_RELOCATION64, IMAGE_BASE_RELOCATION>(ref this, BaseRelocSize);
    }
}
