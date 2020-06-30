using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15443
    [StructLayout(LayoutKind.Sequential)]
    public struct RESUME_PERFORMANCE
    {
        internal int PostTimeMs;
        public TimeSpan PostTime
        {
            get => TimeSpan.FromMilliseconds(PostTimeMs);
            set => PostTimeMs = (int)value.TotalMilliseconds;
        }
        public ulong TotalResumeTimeMs;
        public TimeSpan TotalResumeTime
        {
            get => TimeSpan.FromMilliseconds(TotalResumeTimeMs);
            set => TotalResumeTimeMs = (ulong)value.TotalMilliseconds;
        }
        internal long ResumeCompleteTimestampField;
        public DateTime ResumeCompleteTimestamp
        {
            get => DateTime.FromFileTime(ResumeCompleteTimestampField);
            set => ResumeCompleteTimestampField = value.ToFileTime();
        }
    }
}
