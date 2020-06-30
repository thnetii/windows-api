using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15361
    /// <summary>
    /// Idle resiliency
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct POWER_IDLE_RESILIENCY
    {
        public int CoalescingTimeout;
        public int IdleResiliencyPeriod;
    }
}
