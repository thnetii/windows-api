namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 814
    /// <summary>
    /// Indicates whether the token from the most recent call to the <see cref="InitializeSecurityContext"/> function is the last token from the client.
    /// <para>This enumeration is used in the <see cref="SecPkgContext_LastClientTokenStatus"/> structure.</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ne-sspi-secpkg_attr_lct_status">SECPKG_ATTR_LCT_STATUS Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="SecPkgContext_LastClientTokenStatus"/>
    public enum SECPKG_ATTR_LCT_STATUS
    {
        /// <summary>
        /// The token is the last token from the client.
        /// </summary>
        SecPkgAttrLastClientTokenYes,
        /// <summary>
        /// The token is not the last token from the client.
        /// </summary>
        SecPkgAttrLastClientTokenNo,
        /// <summary>
        /// It is not known whether the token is the last token from the client.
        /// </summary>
        SecPkgAttrLastClientTokenMaybe
    }
}
