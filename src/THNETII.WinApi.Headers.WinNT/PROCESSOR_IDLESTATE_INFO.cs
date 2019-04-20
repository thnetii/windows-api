using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15991
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSOR_IDLESTATE_INFO
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
        #region public byte[] Spare = new byte[2];
        internal short SpareField;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Span<byte> Spare => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref SpareField));
        #endregion
    }
}
