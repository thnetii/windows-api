namespace THNETII.WinApi.Native.WinSock2
{
    public static class WinSock2Macros
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinSock2.h, line 78
        #region MAKEWORD macro
        /// <inheritdoc cref="M:THNETII.WinApi.Native.MinWinDef.MinWinDefMacros.MAKEWORD(System.Byte,System.Byte)"/>
        public static ushort MAKEWORD(byte low, byte high) =>
            (ushort)(low | ((uint)high << 8));
        #endregion
    }
}
