using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11450
    [StructLayout(LayoutKind.Sequential)]
    public struct RATE_QUOTA_LIMIT
    {
        private static readonly Bitfield32 bfRatePercent = Bitfield32.LowBits(7);

        public int RateData;
        private int dwRatePercent;
        public int RatePercent
        {
            get => bfRatePercent.Read(dwRatePercent);
            set => bfRatePercent.Write(ref dwRatePercent, value);
        }
    }
}
