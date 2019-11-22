using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 946
    /// <summary>
    /// The <see cref="SecPkgContext_SessionKey"/> structure contains information about the session key used for the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>. This structure is returned by the <see cref="QueryContextAttributes"/> (General) function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_sessionkey">SecPkgContext_SessionKey structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_SessionKey
    {
        /// <summary>
        /// Size, in bytes, of the session key.
        /// </summary>
        public int SessionKeyLength;
        public byte* SessionKeyPointer;
        /// <summary>
        /// The session key for the security context.
        /// </summary>
        public Span<byte> SessionKey => new Span<byte>(SessionKeyPointer, SessionKeyLength);
    }
}
