using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15576
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_WMI_LEGACY_PERFSTATE
    {
        public int Frequency;
        public int Flags;
        private int PercentFrequencyField;
        public double PercentFrequency
        {
            get => PercentFrequencyField / 100.0;
            set => PercentFrequencyField = (int)(value * 100.0);
        }
    }
}
