namespace THNETII.WinApi.Native.Sspi
{
    /// <summary>
    /// Credential Use Flags
    /// </summary>
    public enum SECPKG_CRED_USE
    {
        SECPKG_CRED_INBOUND = SspiConstants.SECPKG_CRED_INBOUND,
        SECPKG_CRED_OUTBOUND = SspiConstants.SECPKG_CRED_OUTBOUND,
        SECPKG_CRED_BOTH = SspiConstants.SECPKG_CRED_BOTH,
        SECPKG_CRED_DEFAULT = SspiConstants.SECPKG_CRED_DEFAULT,
        SECPKG_CRED_RESERVED = SspiConstants.SECPKG_CRED_RESERVED,
    }
}
