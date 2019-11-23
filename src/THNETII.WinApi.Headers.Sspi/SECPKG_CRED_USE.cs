using THNETII.WinApi.Native.WinError;

namespace THNETII.WinApi.Native.Sspi
{
    using static WinErrorConstants;

    /// <summary>
    /// Credential Use Flags
    /// </summary>
    public enum SECPKG_CRED_USE
    {
        /// <summary>
        /// Validate an incoming server credential. Inbound credentials might be validated by using an authenticating authority when <see cref="InitializeSecurityContext"/> (General) or <see cref="AcceptSecurityContext"/> (General) is called. If such an authority is not available, the function will fail and return <see cref="SEC_E_NO_AUTHENTICATING_AUTHORITY"/>. Validation is package specific.
        /// </summary>
        SECPKG_CRED_INBOUND = SspiConstants.SECPKG_CRED_INBOUND,
        /// <summary>
        /// Allow a local client credential to prepare an outgoing token.
        /// </summary>
        SECPKG_CRED_OUTBOUND = SspiConstants.SECPKG_CRED_OUTBOUND,
        /// <summary>
        /// Validate an incoming credential or use a local credential to prepare an outgoing token. This flag enables both other flags. This flag is not valid with the Digest and Schannel SSPs.
        /// </summary>
        SECPKG_CRED_BOTH = SspiConstants.SECPKG_CRED_BOTH,
        SECPKG_CRED_DEFAULT = SspiConstants.SECPKG_CRED_DEFAULT,
        SECPKG_CRED_RESERVED = SspiConstants.SECPKG_CRED_RESERVED,

        //
        //  SSP SHOULD prompt the user for credentials/consent, independent
        //  of whether credentials to be used are the 'logged on' credentials
        //  or retrieved from credman.
        //
        //  An SSP may choose not to prompt, however, in circumstances determined
        //  by the SSP.
        //

        /// <summary>
        /// The security does not use default logon credentials or credentials from <a href="https://docs.microsoft.com/en-us/windows/win32/secauthn/credential-manager">Credential Manager</a>.<br/>
        /// This value is supported only by the Negotiate <em><a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a></em>.
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP</strong>: This value is not supported.</para>
        /// </summary>
        SECPKG_CRED_AUTOLOGON_RESTRICTED = SspiConstants.SECPKG_CRED_AUTOLOGON_RESTRICTED,

        //
        // auth will always fail, ISC() is called to process policy data only
        //

        /// <summary>
        /// The function processes server policy and returns <see cref="SEC_E_NO_CREDENTIALS"/>, indicating that the application should prompt for credentials.<br/>
        /// This value is supported only by the Negotiate <em><a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a></em>.
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        SECPKG_CRED_PROCESS_POLICY_ONLY = SspiConstants.SECPKG_CRED_PROCESS_POLICY_ONLY,
    }
}
