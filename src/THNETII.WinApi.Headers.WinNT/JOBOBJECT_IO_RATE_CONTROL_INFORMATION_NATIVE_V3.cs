using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11966
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3
    {
        public long MaxIops;
        public long MaxBandwidth;
        public long ReservationIops;
        public PWSTR VolumeNamePtr;
        public int BaseIoSize;
        public JOB_OBJECT_IO_RATE_CONTROL_FLAGS ControlFlags;
        public short VolumeNameLength;
        public Span<char> VolumeName => VolumeNamePtr.AsSpan(VolumeNameLength);
        public long CriticalReservationIops;
        public long ReservationBandwidth;
        public long CriticalReservationBandwidth;
        public long MaxTimePercent;
        public long ReservationTimePercent;
        public long CriticalReservationTimePercent;
        public long SoftMaxIops;
        public long SoftMaxBandwidth;
        public long SoftMaxTimePercent;
        public long LimitExcessNotifyIops;
        public long LimitExcessNotifyBandwidth;
        public long LimitExcessNotifyTimePercent;
    }
}
