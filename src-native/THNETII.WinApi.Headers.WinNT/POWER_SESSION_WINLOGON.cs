using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15352
    /// <summary>
    /// Winlogon notifications
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct POWER_SESSION_WINLOGON
    {
        /// <summary>
        /// the Win32k session identifier
        /// </summary>
        public int SessionId;
        private byte ConsoleField;
        /// <value>
        /// <see langword="true"/> - for console session,
        /// <see langword="false"/> - for remote session
        /// </value>
        public bool Console
        {
            get => ConsoleField != 0;
            set => ConsoleField = (byte)(value ? 1 : 0);
        }
        private byte LockedField;
        public bool Locked
        {
            get => LockedField != 0;
            set => LockedField = (byte)(value ? 1 : 0);
        }
    }
}
