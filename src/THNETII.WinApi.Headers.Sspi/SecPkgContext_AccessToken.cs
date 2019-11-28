using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinError;

namespace THNETII.WinApi.Native.Sspi
{
    using static WinErrorConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1076
    /// <summary>
    /// The <see cref="SecPkgContext_AccessToken"/> structure returns a handle to the access token for the current <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>. The returned handle can be used by the <see cref="ImpersonateLoggedOnUser"/> and <see cref="GetTokenInformation"/> functions. This structure is returned by the <see cref="QueryContextAttributes"/> (General) function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_accesstoken">SecPkgContext_AccessToken structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_AccessToken
    {
        /// <summary>
        /// <para>Pointer to a void that receives the handle to the access token that represents the authenticated user.</para>
        /// <para>The returned handle is not duplicated, so the calling process must not call <see cref="CloseHandle"/> on the returned handle.</para>
        /// <para>If the security context is for a server or is incomplete, the returned handle may be <see langword="null"/>. Depending on the security package, <see cref="QueryContextAttributes"/> (General) may return <see cref="SEC_E_NO_IMPERSONATION"/> for these cases.</para>
        /// </summary>
        public void* AccessToken;
    }
}
