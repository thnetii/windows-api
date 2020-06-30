using THNETII.WinApi.Native.WinIOCtl;

namespace THNETII.WinApi.Native.WinSmcrd
{
    using static WinIOCtlConstants;
    using static WinIOCtlFunctions;

    public static class WinSmcrdFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 106
        #region SCARD_CTL_CODE macro
        public static int SCARD_CTL_CODE(int code) =>
            CTL_CODE(WinSmcrdConstants.FILE_DEVICE_SMARTCARD, code, METHOD_BUFFERED, FILE_ANY_ACCESS);
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 138
        #region SCARD_ATTR_VALUE macro
        public static int SCARD_ATTR_VALUE(int Class, int Tag) =>
            (Class << 16) | Tag;
        #endregion
    }
}
