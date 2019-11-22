using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 637
    /// <summary>
    /// The <see cref="SecPkgCredentials_SSIProviderW"/> structure holds the SSI provider information associated with a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">context</a>. The <see cref="QueryCredentialsAttributes"/> function uses this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcredentials_ssiproviderw">SecPkgCredentials_SSIProviderW structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgCredentials_SSIProviderW
    {
        #region public Span<char> ProviderName;
        internal char* sProviderName;
        /// <summary>
        /// A string that contains the name of the provider represented by the credential.
        /// </summary>
        public Span<char> GetProviderName =>
            new IntPtr(sProviderName).ToZeroTerminatedUnicodeSpan();
        #endregion
        /// <summary>
        /// Length of the provider information.
        /// </summary>
        public int ProviderInfoLength;
        #region public Span<byte> ProviderInfo;
        internal byte* ProviderInfoPtr;
        /// <summary>
        /// The provider information.
        /// </summary>
        public Span<byte> ProviderInfo => new Span<byte>(ProviderInfoPtr, ProviderInfoLength);
        #endregion
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 647
    /// <summary>
    /// The <see cref="SecPkgCredentials_SSIProviderA"/> structure holds the SSI provider information associated with a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">context</a>. The <see cref="QueryCredentialsAttributes"/> function uses this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcredentials_ssiprovidera">SecPkgCredentials_SSIProviderA structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgCredentials_SSIProviderA
    {
        #region public Span<byte> ProviderName;
        internal byte* sProviderName;
        /// <summary>
        /// A string that contains the name of the provider represented by the credential.
        /// </summary>
        public Span<byte> GetProviderName =>
            new IntPtr(sProviderName).ToZeroTerminatedByteSpan();
        #endregion
        /// <summary>
        /// Length of the provider information.
        /// </summary>
        public int ProviderInfoLength;
        #region public Span<byte> ProviderInfo;
        internal byte* ProviderInfoPtr;
        /// <summary>
        /// The provider information.
        /// </summary>
        public Span<byte> ProviderInfo => new Span<byte>(ProviderInfoPtr, ProviderInfoLength);
        #endregion
    }
}
