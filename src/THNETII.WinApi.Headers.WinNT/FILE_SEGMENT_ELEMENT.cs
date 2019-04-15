using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12990
    /// <summary>
    /// Define segement buffer structure for scatter/gather read/write.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct FILE_SEGMENT_ELEMENT
    {
        [FieldOffset(0)]
        public IntPtr Buffer;
        [FieldOffset(0)]
        public ulong Alignment;
    }
}
