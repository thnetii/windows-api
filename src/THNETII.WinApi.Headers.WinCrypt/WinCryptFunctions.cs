namespace THNETII.WinApi.Native.WinCrypt
{
    public static class WinCryptFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 148
        // ALG_ID crackers
        #region GET_ALG_CLASS macro
        public static int GET_ALG_CLASS(int x) => (x & (7 << 13));
        #endregion
        #region GET_ALG_TYPE macro
        public static int GET_ALG_TYPE(int x) => (x & (15 << 9));
        #endregion
        #region GET_ALG_SID macro
        public static int GET_ALG_SID(int x) => (x & (511));
        #endregion
    }
}
