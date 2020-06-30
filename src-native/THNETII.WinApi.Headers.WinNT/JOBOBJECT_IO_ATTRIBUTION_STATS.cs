using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11996
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_IO_ATTRIBUTION_STATS
    {
        public UIntPtr IoCount;
        public ulong TotalNonOverlappedQueueTime;
        public ulong TotalNonOverlappedServiceTime;
        public ulong TotalSize;
    }
}
