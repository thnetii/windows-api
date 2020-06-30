using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15707
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_IDLE_STATE_BUCKET_EX
    {
        internal const int SizeOf = sizeof(long) + 3 * sizeof(int);

        #region public long TotalTimeUs;
        internal long TotalTimeUs;
        public TimeSpan TotalTime
        {
            get => TimeSpan.FromMilliseconds(TotalTimeUs * 1000.0);
            set => TotalTimeUs = (long)(value.TotalMilliseconds / 1000.0);
        }
        #endregion
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
        public int Count;
    }
}
