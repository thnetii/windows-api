using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15344
    /// <summary>
    /// Session RIT State
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct POWER_SESSION_RIT_STATE
    {
        private byte ActiveField;
        /// <value>
        /// <see langword="true"/> - RIT input received,
        /// <see langword="false"/> - RIT timeout
        /// </value>
        public bool Active
        {
            get => ActiveField != 0;
            set => ActiveField = (byte)(value ? 1 : 0);
        }
        /// <summary>
        /// last input time held for this session
        /// </summary>
        public int LastInputTime;
    }
}
