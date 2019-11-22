using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 934
    /// <summary>
    /// The <see cref="SecPkgContext_PasswordExpiry"/> structure contains information about the expiration of a password or other credential used for the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>. This structure is returned by <see cref="QueryContextAttributes"/> (General).
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_passwordexpiry">SecPkgContext_PasswordExpiry structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct SecPkgContext_PasswordExpiry
    {
        /// <summary>
        /// A timestamp variable that indicates when the credentials for the security context expire. For password-based packages, this variable indicates when the password expires. For <a href="https://docs.microsoft.com/windows/desktop/SecGloss/k-gly">Kerberos</a>, this variable indicates when the ticket expires.
        /// </summary>
        public SECURITY_INTEGER tsPasswordExpires;
    }
}
