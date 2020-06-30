using System;
using System.Runtime.InteropServices;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17811
    /// <summary>
    /// Dynamic value relocation table in loadconfig
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_DYNAMIC_RELOCATION_TABLE
    {
        public int Version;
        public int Size;
        public Span<IMAGE_DYNAMIC_RELOCATION> DynamicRelocations =>
            SpanAfterStruct.GetSpan<IMAGE_DYNAMIC_RELOCATION_TABLE, IMAGE_DYNAMIC_RELOCATION>(ref this, Size);
    }
}
