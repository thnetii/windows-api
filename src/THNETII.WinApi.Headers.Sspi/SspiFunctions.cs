using System;

namespace THNETII.WinApi.Native.Sspi
{
    public static class SspiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 139
        #region SecInvalidateHandle macro
        public static void SecInvalidateHandle(ref SecHandle x)
        {
            x.dwLower = new UIntPtr(unchecked((uint)-1));
            x.dwUpper = new UIntPtr(unchecked((uint)-1));
        }
        #endregion
        #region SecIsValidHandle macro
        public static bool SecIsValidHandle(in SecHandle x)
        {
            return x.dwLower != new UIntPtr(unchecked((uint)-1)) &&
                x.dwUpper != new UIntPtr(unchecked((uint)-1));
        }
        #endregion
    }
}
