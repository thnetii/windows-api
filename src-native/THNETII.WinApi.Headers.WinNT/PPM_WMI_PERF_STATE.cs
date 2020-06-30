using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15614
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_WMI_PERF_STATE
    {
        /// <summary>in Mhz</summary>
        public int Frequency;            // in Mhz
        /// <summary>in Mhz</summary>
        public int Power;                // in milliwatts
        #region public byte PercentFrequency;
        internal byte PercentFrequencyField;
        public double PercentFrequency
        {
            get => PercentFrequencyField / 100.0;
            set => PercentFrequencyField = (byte)(value * 100.0);
        }
        #endregion
        /// <summary>goto higher state</summary>
        public byte IncreaseLevel; 
        /// <summary>goto lower state</summary>
        public byte DecreaseLevel;
        /// <summary>performance or throttle</summary>
        public byte Type;
        /// <summary>in tick counts</summary>
        public int IncreaseTime;
        /// <summary>in tick counts</summary>
        public int DecreaseTime;
        /// <summary>control value</summary>
        public long Control;
        /// <summary>control value</summary>
        public long Status;
        public int HitCount;
        /// <summary>reserved for future use</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved1;
        /// <summary>reserved for future use</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public long Reserved2;
        /// <summary>reserved for future use</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public long Reserved3;
    }
}
