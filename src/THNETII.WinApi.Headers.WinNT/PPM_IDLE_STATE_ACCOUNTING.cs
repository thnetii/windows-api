using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15685
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_IDLE_STATE_ACCOUNTING
    {
        public int IdleTransitions;
        public int FailedTransitions;
        public int InvalidBucketIndex;
        #region public long TotalTime;
        internal long TotalTimeTicks;
        public TimeSpan TotalTime
        {
            get => TimeSpan.FromTicks(TotalTimeTicks);
            set => TotalTimeTicks = value.Ticks;
        }
        #endregion
        #region public int[] IdleTimeBuckets = new int[PROC_IDLE_BUCKET_COUNT];
        [StructLayout(LayoutKind.Explicit, Size = sizeof(int) * PROC_IDLE_BUCKET_COUNT)]
        private struct DUMMYSTRUCTNAME { }
        private DUMMYSTRUCTNAME s;
        public Span<int> IdleTimeBuckets => MemoryMarshal.Cast<DUMMYSTRUCTNAME, int>(SpanOverRef.GetSpan(ref s));
        #endregion
    }
}
