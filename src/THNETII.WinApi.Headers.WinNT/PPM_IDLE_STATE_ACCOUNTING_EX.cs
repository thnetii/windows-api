using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15714
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_IDLE_STATE_ACCOUNTING_EX
    {
        public long TotalTime;
        public int IdleTransitions;
        public int FailedTransitions;
        public int InvalidBucketIndex;
        #region public int MinTimeUs;
        internal int MinTimeUs;
        public TimeSpan MinTime
        {
            get => TimeSpan.FromMilliseconds(MinTimeUs * 1000.0);
            set => MinTimeUs = (int)(value.TotalMilliseconds / 1000.0);
        }
        #endregion
        #region public int MaxTimeUs;
        internal int MaxTimeUs;
        public TimeSpan MaxTime
        {
            get => TimeSpan.FromMilliseconds(MaxTimeUs * 1000.0);
            set => MaxTimeUs = (int)(value.TotalMilliseconds / 1000.0);
        }
        #endregion
        public int CancelledTransitions;
        #region public PPM_IDLE_STATE_BUCKET_EX[] IdleTimeBuckets = new PPM_IDLE_STATE_BUCKET_EX[PROC_IDLE_BUCKET_COUNT_EX];
        [StructLayout(LayoutKind.Explicit, Size = PPM_IDLE_STATE_BUCKET_EX.SizeOf * PROC_IDLE_BUCKET_COUNT_EX)]
        private struct DUMMYSTRUCTNAME { }
        private DUMMYSTRUCTNAME s;
        public Span<PPM_IDLE_STATE_BUCKET_EX> IdleTimeBuckets => MemoryMarshal.Cast<DUMMYSTRUCTNAME, PPM_IDLE_STATE_BUCKET_EX>(SpanOverRef.GetSpan(ref s));
        #endregion
    }
}
