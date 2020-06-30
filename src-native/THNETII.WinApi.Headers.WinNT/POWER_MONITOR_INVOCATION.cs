using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15431
    /// <summary>
    /// Monitor invocation
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct POWER_MONITOR_INVOCATION
    {
        private byte ConsoleField;
        public bool Console
        {
            get => ConsoleField != 0;
            set => ConsoleField = (byte)(value ? 1 : 0);
        }
        public POWER_MONITOR_REQUEST_REASON RequestReason;
    }
}
