using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15714
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_IDLE_ACCOUNTING_EX
    {
        public int StateCount;
        public int TotalTransitions;
        public int ResetCount;
        public int AbortCount;
        public long StartTime;
        #region public PPM_IDLE_STATE_ACCOUNTING_EX[] State = new PPM_IDLE_STATE_ACCOUNTING_EX[StateCount];
        internal PPM_IDLE_STATE_ACCOUNTING_EX StateField;
        public Span<PPM_IDLE_STATE_ACCOUNTING_EX> State => SpanOverRef.GetSpan(ref StateField, StateCount);
        #endregion
    }
}
