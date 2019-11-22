using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 821
    /// <summary>
    /// Specifies whether the token from the most recent call to the <see cref="InitializeSecurityContext"/> function is the last token from the client.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_lastclienttokenstatus">SecPkgContext_LastClientTokenStatus structure</a></para>
    /// </remarks>
    /// <seealso cref="SECPKG_ATTR_LCT_STATUS"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_LastClientTokenStatus
    {
        /// <summary>
        /// A value of the <see cref="SECPKG_ATTR_LCT_STATUS"/> enumeration that indicates the status of the token returned by the most recent call to <see cref="InitializeSecurityContext"/>.
        /// </summary>
        public SECPKG_ATTR_LCT_STATUS LastClientTokenStatus;
    }
}
