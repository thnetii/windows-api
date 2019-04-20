using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15582
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_WMI_IDLE_STATE
    {
        public int Latency;
        public int Power;
        public int TimeCheck;
        #region public byte PromotePercent;
        internal byte PromotePercentField;
        public double PromotePercent
        {
            get => PromotePercentField / 100.0;
            set => PromotePercentField = (byte)(value * 100.0);
        }
        #endregion
        #region public byte DemotePercent;
        internal byte DemotePercentField;
        public double DemotePercent
        {
            get => DemotePercentField / 100.0;
            set => DemotePercentField = (byte)(value * 100.0);
        }
        #endregion
        #region public byte StateType;
        internal byte StateTypeField;
        public double StateType
        {
            get => StateTypeField / 100.0;
            set => StateTypeField = (byte)(value * 100.0);
        }
        #endregion
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte Reserved;
        public int StateFlags;
        public int Context;
        public int IdleHandler;
        /// <summary>reserved for future use</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved1;
    }
}
