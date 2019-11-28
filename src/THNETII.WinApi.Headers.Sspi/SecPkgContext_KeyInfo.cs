using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 846
    /// <summary>
    /// <para>The <see cref="SecPkgContext_KeyInfoA"/> structure contains information about the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">session keys</a> used in a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>. The <see cref="QueryContextAttributes"/> (General) function uses this structure.</para>
    /// <para>Applications using the Schannel <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security support provider</a> (SSP) should not use the <see cref="SecPkgContext_KeyInfoA"/> structure. Instead, use the <see cref="SecPkgContext_ConnectionInfo"/> structure.</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_keyinfoa">SecPkgContext_KeyInfoA structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SecPkgContext_KeyInfoA
    {
        /// <summary>
        /// Pointer to a null-terminated string that contains the name, if available, of the algorithm used for generating signatures, for example "MD5" or "SHA-2".
        /// </summary>
        public LPSTR sSignatureAlgorithmName;
        /// <summary>
        /// Pointer to a null-terminated string that contains the name, if available, of the algorithm used for encrypting messages. Reserved for future use.
        /// </summary>
        public LPSTR sEncryptAlgorithmName;
        /// <summary>
        /// Specifies the effective key length, in bits, for the session key. This is typically 40, 56, or 128 bits.
        /// </summary>
        public int KeySize;
        /// <summary>
        /// Specifies the algorithm identifier (ALG_ID) used for generating signatures, if available.
        /// </summary>
        public int SignatureAlgorithm;
        /// <summary>
        /// Specifies the algorithm identifier (ALG_ID) used for encrypting messages. Reserved for future use.
        /// </summary>
        public int EncryptAlgorithm;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 865
    /// <summary>
    /// <para>The <see cref="SecPkgContext_KeyInfoW"/> structure contains information about the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">session keys</a> used in a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>. The <see cref="QueryContextAttributes"/> (General) function uses this structure.</para>
    /// <para>Applications using the Schannel <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security support provider</a> (SSP) should not use the <see cref="SecPkgContext_KeyInfoW"/> structure. Instead, use the <see cref="SecPkgContext_ConnectionInfo"/> structure.</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_keyinfow">SecPkgContext_KeyInfoW structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SecPkgContext_KeyInfoW
    {
        /// <summary>
        /// Pointer to a null-terminated string that contains the name, if available, of the algorithm used for generating signatures, for example "MD5" or "SHA-2".
        /// </summary>
        public LPWSTR sSignatureAlgorithmName;
        /// <summary>
        /// Pointer to a null-terminated string that contains the name, if available, of the algorithm used for encrypting messages. Reserved for future use.
        /// </summary>
        public LPWSTR sEncryptAlgorithmName;
        /// <summary>
        /// Specifies the effective key length, in bits, for the session key. This is typically 40, 56, or 128 bits.
        /// </summary>
        public int KeySize;
        /// <summary>
        /// Specifies the algorithm identifier (ALG_ID) used for generating signatures, if available.
        /// </summary>
        public int SignatureAlgorithm;
        /// <summary>
        /// Specifies the algorithm identifier (ALG_ID) used for encrypting messages. Reserved for future use.
        /// </summary>
        public int EncryptAlgorithm;
    }
}
