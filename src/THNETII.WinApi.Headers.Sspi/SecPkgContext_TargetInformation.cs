using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1081
    /// <summary>
    /// The <see cref="SecPkgContext_TargetInformation"/> structure returns information about the credential used for the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>. This structure is returned by the <see cref="QueryContextAttributes"/> (General) function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_targetinformation">SecPkgContext_TargetInformation structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_TargetInformation
    {
        /// <summary>
        /// Size, in bytes, of <see cref="MarshalledTargetInfo"/>.
        /// </summary>
        public int MarshalledTargetInfoLength;
        public byte* MarshalledTargetInfoPointer;
        /// <summary>
        /// Span of bytes that represent the credential, if a credential is provided by a credential manager.
        /// </summary>
        public Span<byte> MarshalledTargetInfo =>
            new Span<byte>(MarshalledTargetInfoPointer, MarshalledTargetInfoLength);
    }
}
