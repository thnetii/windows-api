using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10422
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ACCESS_REASONS
    {
        private fixed int DataField[32];
        private Span<int> DataFieldSpan
        {
            get
            {
                fixed(int* ptr = DataField)
                {
                    return new Span<int>(ptr, 32);
                }
            }
        }
        public Span<ACCESS_REASON> Data => MemoryMarshal.Cast<int, ACCESS_REASON>(DataFieldSpan);
    }
}
