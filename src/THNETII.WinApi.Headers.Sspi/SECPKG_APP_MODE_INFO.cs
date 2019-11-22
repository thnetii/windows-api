using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1137
    [StructLayout(LayoutKind.Sequential)]
    public struct SECPKG_APP_MODE_INFO
    {
        public int UserFunction;
        public IntPtr Argument1;
        public IntPtr Argument2;
        public SecBuffer UserData;
        #region public bool ReturnToLsa;
        internal byte ReturnToLsaField;
        public bool ReturnToLsa
        {
            get => ReturnToLsaField != 0;
            set => ReturnToLsaField = (byte)(value ? 1 : 0);
        }
        #endregion
    }
}
