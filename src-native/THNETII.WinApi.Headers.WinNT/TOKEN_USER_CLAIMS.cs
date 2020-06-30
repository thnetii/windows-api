using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10770
    /// <summary>
    /// The <see cref="TOKEN_USER_CLAIMS"/> structure defines the user claims for the token.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_user_claims">TOKEN_USER_CLAIMS structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_USER_CLAIMS
    {
        /// <summary>
        /// The user claims for the token.
        /// </summary>
        public IntPtr UserClaims;
    }
}
