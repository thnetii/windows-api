namespace THNETII.WinApi.Native.WinSmcrd
{
    public static class WinSmcrdFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\winsmcrd.h, line 138
        #region SCARD_ATTR_VALUE macro
        public static int SCARD_ATTR_VALUE(int Class, int Tag) =>
            (Class << 16) | Tag;
        #endregion
    }
}
