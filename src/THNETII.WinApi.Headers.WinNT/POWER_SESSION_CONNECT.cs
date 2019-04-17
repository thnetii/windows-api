using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15331
    /// <summary>
    /// Session Connect/Disconnect
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct POWER_SESSION_CONNECT
    {
        private byte ConnectedField;
        public bool Connected
        {
            get => ConnectedField != 0;
            set => ConnectedField = (byte)(value ? 1 : 0);
        }
        private byte ConsoleField;
        public bool Console
        {
            get => ConsoleField != 0;
            set => ConsoleField = (byte)(value ? 1 : 0);
        }
    }
}
