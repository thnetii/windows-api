using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 681
    /// <summary>
    /// Specifies the certificate credentials. The <see cref="QueryCredentialsAttributes"/> function uses this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcredentials_cert">SecPkgCredentials_Cert structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgCredentials_Cert
    {
        /// <summary>
        /// Size of the encoded certificate.
        /// </summary>
        public int EncodedCertSize;
        #region public Span<byte> EncodedCert;
        internal byte* EncodedCertPtr;
        /// <summary>
        /// The encoded certificate.
        /// </summary>
        public Span<byte> EncodedCert => new Span<byte>(EncodedCertPtr, EncodedCertSize);
        #endregion
    }
}
