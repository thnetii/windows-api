using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15631
    [StructLayout(LayoutKind.Sequential)]
    public struct PPM_WMI_PERF_STATES_EX
    {
        public int Count;
        public int MaxFrequency;
        /// <summary>
        /// current state
        /// </summary>
        public int CurrentState;
        /// <summary>
        /// fastest state considering policy restrictions
        /// </summary>
        public int MaxPerfState;
        /// <summary>
        /// slowest state considering policy restrictions
        /// </summary>
        public int MinPerfState;
        /// <summary>
        /// slowest perf state, fixed, aka the "knee"
        /// </summary>
        public int LowestPerfState;
        public int ThermalConstraint;
        public byte BusyAdjThreshold;
        /// <summary>
        /// domain coordination
        /// </summary>
        public byte PolicyType;
        public byte Type;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte Reserved;
        public int TimerInterval;
        /// <summary>
        /// domain affinity
        /// </summary>
        public long TargetProcessors;
        public int PStateHandler;
        public int PStateContext;
        public int TStateHandler;
        public int TStateContext;
        public int FeedbackHandler;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved1;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public long Reserved2;
        #region public PPM_WMI_PERF_STATE[] State = new PPM_WMI_PERF_STATE[Count];
        internal PPM_WMI_PERF_STATE StateField;
        public Span<PPM_WMI_PERF_STATE> State => SpanOverRef.GetSpan(ref StateField, Count);
        #endregion
    }
}
