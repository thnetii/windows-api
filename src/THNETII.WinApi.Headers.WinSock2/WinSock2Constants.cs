namespace THNETII.WinApi.Native.WinSock2
{
    using static WinSock2Macros;

    public static class WinSock2Constants
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinSock2.h, line 83
        /// <summary>
        /// Define the current Winsock version. To build an earlier Winsock version
        /// application redefine this value prior to including Winsock2.h.
        /// </summary>
        public static readonly ushort WINSOCK_VERSION = MAKEWORD(2, 2);
    }
}
