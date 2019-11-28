using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.CredSSP
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\credssp.h, line 33
    /// <summary>
    /// The <see cref="SecPkgContext_ClientCreds"/> structure specifies client credentials when calling the <see cref="QueryContextAttributes"/> (CredSSP) function.
    /// <para>This structure is supported only on the server.</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/credssp/ns-credssp-secpkgcontext_clientcreds">SecPkgContext_ClientCreds structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_ClientCreds
    {
        /// <summary>
        /// The size, in bytes, of the <see cref="AuthBuffer"/> buffer.
        /// </summary>
        public int AuthBufferLen;
        /// <summary>
        /// A pointer to a buffer that represents the client credentials.
        /// </summary>
        public byte* AuthBufferPtr;
        /// <summary>
        /// A span to a buffer that represents the client credentials.
        /// </summary>
        public Span<byte> AuthBuffer => new Span<byte>(AuthBufferPtr, AuthBufferLen);
    }
}
