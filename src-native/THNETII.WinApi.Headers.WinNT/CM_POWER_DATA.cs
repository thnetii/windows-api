using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15203
    [StructLayout(LayoutKind.Sequential)]
    public struct CM_POWER_DATA
    {
        public int PD_Size;
        public DEVICE_POWER_STATE PD_MostRecentPowerState;
        public int PD_Capabilities;
        public int PD_D1Latency;
        public int PD_D2Latency;
        public int PD_D3Latency;
        #region public DEVICE_POWER_STATE[] PD_PowerStateMapping = new DEVICE_POWER_STATE[POWER_SYSTEM_MAXIMUM];
        [StructLayout(LayoutKind.Explicit, Size = POWER_SYSTEM_MAXIMUM * sizeof(DEVICE_POWER_STATE))]
        private struct DUMMYSTRUCTNAME { }
        private DUMMYSTRUCTNAME s;
        public Span<DEVICE_POWER_STATE> PD_PowerStateMapping => MemoryMarshal.Cast<DUMMYSTRUCTNAME, DEVICE_POWER_STATE>(SpanOverRef.GetSpan(ref s));
        #endregion
        public SYSTEM_POWER_STATE PD_DeepestSystemWake;
    }
}
