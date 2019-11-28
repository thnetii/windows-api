using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 884
    /// <summary>
    /// The <see cref="SecPkgContext_AuthorityA"/> structure contains the name of the authenticating authority if one is available. It can be a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">certification authority</a> (CA) or the name of a server or domain that authenticated the connection. The <see cref="QueryContextAttributes"/> (General) function uses this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_authoritya">SecPkgContext_AuthorityA structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SecPkgContext_AuthorityA
    {
        /// <summary>
        /// Pointer to a null-terminated string containing the name of the authenticating authority, if available.
        /// </summary>
        public LPSTR sAuthorityName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 891
    /// <summary>
    /// The <see cref="SecPkgContext_AuthorityW"/> structure contains the name of the authenticating authority if one is available. It can be a <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">certification authority</a> (CA) or the name of a server or domain that authenticated the connection. The <see cref="QueryContextAttributes"/> (General) function uses this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_authorityw">SecPkgContext_AuthorityW structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SecPkgContext_AuthorityW
    {
        /// <summary>
        /// Pointer to a null-terminated string containing the name of the authenticating authority, if available.
        /// </summary>
        public LPWSTR sAuthorityName;
    }
}
