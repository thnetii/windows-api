namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 760
    //
    // types of credentials, used by SECPKG_ATTR_PROMPTING_NEEDED
    //

    /// <summary>
    /// Indicates the type of credential used in a client context. The <see cref="SECPKG_CRED_CLASS"/> enumeration is used in the <see cref="SecPkgContext_CredInfo"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ne-sspi-secpkg_cred_class">SECPKG_CRED_CLASS Enumeration</a></para>
    /// </remarks>
    public enum SECPKG_CRED_CLASS
    {
        /// <summary>
        /// No credentials are supplied.
        /// </summary>
        SecPkgCredClass_None = 0,  // no creds
        /// <summary>
        /// Indicates the credentials used to log on to the system.
        /// </summary>
        SecPkgCredClass_Ephemeral = 10,  // logon creds
        /// <summary>
        /// Indicates saved credentials that are not target specific.
        /// </summary>
        SecPkgCredClass_PersistedGeneric = 20, // saved creds, not target specific
        /// <summary>
        /// Indicates saved credentials that are target specific.
        /// </summary>
        SecPkgCredClass_PersistedSpecific = 30, // saved creds, target specific
        SecPkgCredClass_Explicit = 40, // explicitly supplied creds
    }
}
