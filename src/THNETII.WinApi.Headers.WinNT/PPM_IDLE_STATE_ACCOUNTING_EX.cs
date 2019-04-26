using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15714
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PPM_IDLE_STATE_ACCOUNTING_EX
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
        #region public fixed PPM_IDLE_STATE_BUCKET_EX IdleTimeBuckets[PROC_IDLE_BUCKET_COUNT_EX];
        internal fixed byte IdleTimeBucketsField[PPM_IDLE_STATE_BUCKET_EX.SizeOf * PROC_IDLE_BUCKET_COUNT_EX];
        public Span<PPM_IDLE_STATE_BUCKET_EX> IdleTimeBuckets
        {
            get
            {
                fixed(void* ptr = IdleTimeBucketsField)
                {
                    return new Span<PPM_IDLE_STATE_BUCKET_EX>(ptr, PROC_IDLE_BUCKET_COUNT_EX);
                }
            }
        }
        #endregion
    }
}
