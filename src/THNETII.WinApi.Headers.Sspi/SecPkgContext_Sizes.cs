using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 787
    /// <summary>
    /// The <see cref="SecPkgContext_Sizes"/> structure indicates the sizes of important structures used in the message support functions. The <see cref="QueryContextAttributes"/> (General) function uses this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_sizes">SecPkgContext_Sizes structure</a></para>
    /// </remarks>
    /// <seealso cref="MakeSignature"/>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_Sizes
    {
        /// <summary>
        /// Specifies the maximum size of the security token used in the authentication exchanges.
        /// </summary>
        public int cbMaxToken;
        /// <summary>
        /// Specifies the maximum size of the signature created by the <see cref="MakeSignature"/> function. This member must be zero if <a href="https://docs.microsoft.com/windows/desktop/SecGloss/i-gly">integrity</a> services are not requested or available.
        /// </summary>
        public int cbMaxSignature;
        /// <summary>
        /// Specifies the preferred integral size of the messages. For example, eight indicates that messages should be of size zero mod eight for optimal performance. Messages other than this block size can be padded.
        /// </summary>
        public int cbBlockSize;
        /// <summary>
        /// Size of the security trailer to be appended to messages. This member should be zero if the relevant services are not requested or available.
        /// </summary>
        public int cbSecurityTrailer;
    }
}
