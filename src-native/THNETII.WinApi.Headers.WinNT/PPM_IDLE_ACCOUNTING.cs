using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15693
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_IDLE_ACCOUNTING
    {
        public int StateCount;
        public int TotalTransitions;
        public int ResetCount;
        public long StartTime;
        #region public PPM_IDLE_STATE_ACCOUNTING[] State = new PPM_IDLE_STATE_ACCOUNTING[StateCount];
        internal PPM_IDLE_STATE_ACCOUNTING StateField;
        public Span<PPM_IDLE_STATE_ACCOUNTING> State => SpanOverRef.GetSpan(ref StateField, StateCount);
        #endregion
    }
}
