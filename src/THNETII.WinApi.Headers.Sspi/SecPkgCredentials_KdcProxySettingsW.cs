using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    using static SspiConstants;

    /// <summary>
    /// Specifies the Kerberos proxy settings for the credentials.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcredentials_kdcproxysettingsw">SecPkgCredentials_KdcProxySettingsW structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgCredentials_KdcProxySettingsW
    {
        /// <summary>
        /// Version for the Kerberos proxy settings where <see cref="KDC_PROXY_SETTINGS_V1"/> is defined as <c>1</c>.
        /// </summary>
        public int Version;             // KDC_PROXY_SETTINGS_V1
        #region public KDC_PROXY_SETTINGS_FLAGS Flags;
        internal int FlagsField;               // KDC_PROXY_SETTINGS_FLAGS_*
        /// <summary>
        /// Flags for the Kerberos proxy settings.
        /// </summary>
        public KDC_PROXY_SETTINGS_FLAGS Flags
        {
            get => (KDC_PROXY_SETTINGS_FLAGS)FlagsField;
            set => FlagsField = (int)value;
        }
        #endregion
        /// <summary>
        /// The offset of the proxy server. This member is optional.
        /// </summary>
        public ushort ProxyServerOffset;   // ProxyServer, optional
        /// <summary>
        /// Length of the proxy server.
        /// </summary>
        public ushort ProxyServerLength;
        public Span<byte> ProxyServer
        {
            get
            {
                fixed (void* pThis = &this)
                {
                    void* pProxyServer = ((char*)pThis) + ProxyServerOffset;
                    return new Span<byte>(pProxyServer, ProxyServerLength);
                }
            }
        }
        /// <summary>
        /// The offset of the client credentials. This member is optional.
        /// </summary>
        public ushort ClientTlsCredOffset; // ClientTlsCred, optional
        /// <summary>
        /// Length of the client credentials.
        /// </summary>
        public ushort ClientTlsCredLength;
        public Span<byte> ClientTlsCred
        {
            get
            {
                fixed (void* pThis = &this)
                {
                    void* pClientTlsCred = ((char*)pThis) + ClientTlsCredOffset;
                    return new Span<byte>(pClientTlsCred, ClientTlsCredLength);
                }
            }
        }
    }
}
