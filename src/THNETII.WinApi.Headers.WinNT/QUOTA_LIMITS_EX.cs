using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11473
    [StructLayout(LayoutKind.Sequential)]
    public struct QUOTA_LIMITS_EX
    {
        public UIntPtr PagedPoolLimit;
        public UIntPtr NonPagedPoolLimit;
        public UIntPtr MinimumWorkingSetSize;
        public UIntPtr MaximumWorkingSetSize;
        /// <summary>Limit expressed in pages</summary>
        public UIntPtr PagefileLimit;
        public long TimeLimit;
        /// <summary>Limit expressed in pages</summary>
        public UIntPtr WorkingSetLimit;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public UIntPtr Reserved2;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public UIntPtr Reserved3;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public UIntPtr Reserved4;
        public int Flags;
        public RATE_QUOTA_LIMIT CpuRateLimit;
    }
}
