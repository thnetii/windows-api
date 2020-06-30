using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15991
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PROCESSOR_IDLESTATE_INFO
    {
        public int TimeCheck;
        #region public byte DemotePercent;
        internal byte DemotePercentField;
        public double DemotePercent
        {
            get => DemotePercentField / 100.0;
            set => DemotePercentField = (byte)(value * 100.0);
        }
        #endregion
        #region public byte PromotePercent;
        internal byte PromotePercentField;
        public double PromotePercent
        {
            get => PromotePercent / 100.0;
            set => PromotePercent = (byte)(value * 100.0);
        }
        #endregion
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Spare[2];
    }
}
