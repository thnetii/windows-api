using System;

using THNETII.WinApi.Native.CredSSP;
using THNETII.WinApi.Native.MinSchannel;

namespace THNETII.WinApi.Native.Sspi
{
    public enum SECPKG_ATTR_TYPE
    {
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_Sizes"/> structure.
        /// <para>Queries the sizes of the structures used in the per-message functions.</para>
        /// </summary>
        SECPKG_ATTR_SIZES = SspiConstants.SECPKG_ATTR_SIZES,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_Names"/> structure.
        /// <para>Queries the name associated with the context.</para>
        /// </summary>
        SECPKG_ATTR_NAMES = SspiConstants.SECPKG_ATTR_NAMES,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_Lifespan"/> structure.
        /// <para>Queries the life span of the context.</para>
        /// </summary>
        SECPKG_ATTR_LIFESPAN = SspiConstants.SECPKG_ATTR_LIFESPAN,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_DceInfo"/> structure.
        /// <para>Queries for authorization data used by DCE services.</para>
        /// </summary>
        SECPKG_ATTR_DCE_INFO = SspiConstants.SECPKG_ATTR_DCE_INFO,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_StreamSizes"/> structure.
        /// <para>Queries the sizes of the various parts of a stream used in the per-message functions.</para>
        /// <para>This attribute is supported only by the Schannel <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>.</para>
        /// </summary>
        SECPKG_ATTR_STREAM_SIZES = SspiConstants.SECPKG_ATTR_STREAM_SIZES,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_KeyInfo"/> structure.
        /// <para>Queries information about the keys used in a <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">security context</a>.</para>
        /// </summary>
        SECPKG_ATTR_KEY_INFO = SspiConstants.SECPKG_ATTR_KEY_INFO,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_Authority"/> structure.
        /// <para>Queries the name of the authenticating authority.</para>
        /// </summary>
        SECPKG_ATTR_AUTHORITY = SspiConstants.SECPKG_ATTR_AUTHORITY,
        SECPKG_ATTR_PROTO_INFO = SspiConstants.SECPKG_ATTR_PROTO_INFO,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_PasswordExpiry"/> structure.
        /// <para>Returns password expiration information.</para>
        /// </summary>
        SECPKG_ATTR_PASSWORD_EXPIRY = SspiConstants.SECPKG_ATTR_PASSWORD_EXPIRY,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_SessionKey"/> structure.
        /// <para>Returns information about the <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">session key</a>s.</para>
        /// </summary>
        SECPKG_ATTR_SESSION_KEY = SspiConstants.SECPKG_ATTR_SESSION_KEY,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_PackageInfo"/> structure.
        /// <para>Returns information on the SSP in use.</para>
        /// </summary>
        SECPKG_ATTR_PACKAGE_INFO = SspiConstants.SECPKG_ATTR_PACKAGE_INFO,
        SECPKG_ATTR_USER_FLAGS = SspiConstants.SECPKG_ATTR_USER_FLAGS,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_NegotiationInfo"/> structure.
        /// <para>Returns information about the <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">security package</a> to be used with the negotiation process and the current state of the negotiation for the use of that package.</para>
        /// </summary>
        SECPKG_ATTR_NEGOTIATION_INFO = SspiConstants.SECPKG_ATTR_NEGOTIATION_INFO,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_NativeNames"/> structure.
        /// <para>Returns the principal name (CNAME) from the outbound ticket.</para>
        /// </summary>
        SECPKG_ATTR_NATIVE_NAMES = SspiConstants.SECPKG_ATTR_NATIVE_NAMES,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_Flags"/> structure.
        /// <para>Returns information about the negotiated context flags.</para>
        /// </summary>
        SECPKG_ATTR_FLAGS = SspiConstants.SECPKG_ATTR_FLAGS,
        // These attributes exist only in Win XP and greater
        SECPKG_ATTR_USE_VALIDATED = SspiConstants.SECPKG_ATTR_USE_VALIDATED,
        SECPKG_ATTR_CREDENTIAL_NAME = SspiConstants.SECPKG_ATTR_CREDENTIAL_NAME,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_TargetInformation"/> structure.
        /// <para>Returns information about the name of the remote server.</para>
        /// </summary>
        SECPKG_ATTR_TARGET_INFORMATION = SspiConstants.SECPKG_ATTR_TARGET_INFORMATION,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_AccessToken"/> structure.
        /// <para>Returns a handle to the access token.</para>
        /// </summary>
        SECPKG_ATTR_ACCESS_TOKEN = SspiConstants.SECPKG_ATTR_ACCESS_TOKEN,
        // These attributes exist only in Win2K3 and greater
        SECPKG_ATTR_TARGET = SspiConstants.SECPKG_ATTR_TARGET,
        SECPKG_ATTR_AUTHENTICATION_ID = SspiConstants.SECPKG_ATTR_AUTHENTICATION_ID,
        // These attributes exist only in Win2K3SP1 and greater
        SECPKG_ATTR_LOGOFF_TIME = SspiConstants.SECPKG_ATTR_LOGOFF_TIME,
        //
        // win7 or greater
        //
        SECPKG_ATTR_NEGO_KEYS = SspiConstants.SECPKG_ATTR_NEGO_KEYS,
        SECPKG_ATTR_PROMPTING_NEEDED = SspiConstants.SECPKG_ATTR_PROMPTING_NEEDED,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_Bindings"/> structure that specifies channel binding information.
        /// <para>This value is supported only by the Schannel <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        SECPKG_ATTR_UNIQUE_BINDINGS = SspiConstants.SECPKG_ATTR_UNIQUE_BINDINGS,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_Bindings"/> structure that specifies channel binding information.
        /// <para>This attribute is supported only by the Schannel constrained delegation.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        SECPKG_ATTR_ENDPOINT_BINDINGS = SspiConstants.SECPKG_ATTR_ENDPOINT_BINDINGS,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a SecPkgContext_ClientSpecifiedTarget structure that represents the service principal name (SPN) of the initial target supplied by the client.
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        SECPKG_ATTR_CLIENT_SPECIFIED_TARGET = SspiConstants.SECPKG_ATTR_CLIENT_SPECIFIED_TARGET,

        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_LastClientTokenStatus"/> structure that specifies whether the token from the most recent call to the <see cref="InitializeSecurityContext"/> function is the last token from the client.
        /// <para>This value is supported only by the Negotiate, Kerberos, and NTLM <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>s.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        SECPKG_ATTR_LAST_CLIENT_TOKEN_STATUS = SspiConstants.SECPKG_ATTR_LAST_CLIENT_TOKEN_STATUS,
        SECPKG_ATTR_NEGO_PKG_INFO = SspiConstants.SECPKG_ATTR_NEGO_PKG_INFO, // contains nego info of packages
        SECPKG_ATTR_NEGO_STATUS = SspiConstants.SECPKG_ATTR_NEGO_STATUS, // contains the last error
        SECPKG_ATTR_CONTEXT_DELETED = SspiConstants.SECPKG_ATTR_CONTEXT_DELETED, // a context has been deleted

        //
        // win8 or greater
        //
        /// <summary>
        /// Sets and retrieves the MTU (maximum transmission unit) value for use with DTLS. If DTLS is not enabled in a security context, this attribute is not supported.
        /// <para>Valid values are between 200 bytes and 64 kilobytes. The default DTLS MTU value in Schannel is 1096 bytes.</para>
        /// </summary>
        SECPKG_ATTR_DTLS_MTU = SspiConstants.SECPKG_ATTR_DTLS_MTU,
        SECPKG_ATTR_DATAGRAM_SIZES = SspiConstants.SECPKG_ATTR_DATAGRAM_SIZES,

        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_SubjectAttributes"/> structure.
        /// <para>This value returns information about the security attributes for the connection.</para>
        /// <para>This value is supported only on the CredSSP server.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        SECPKG_ATTR_SUBJECT_SECURITY_ATTRIBUTES = SspiConstants.SECPKG_ATTR_SUBJECT_SECURITY_ATTRIBUTES,

        //
        // win8.1 or greater
        //
        SECPKG_ATTR_APPLICATION_PROTOCOL = SspiConstants.SECPKG_ATTR_APPLICATION_PROTOCOL,

        //
        // win10 or greater
        //
        SECPKG_ATTR_NEGOTIATED_TLS_EXTENSIONS = SspiConstants.SECPKG_ATTR_NEGOTIATED_TLS_EXTENSIONS,
        SECPKG_ATTR_IS_LOOPBACK = SspiConstants.SECPKG_ATTR_IS_LOOPBACK,  // indicates authentication to localhost

        // from minschannel.h
        SECPKG_ATTR_ISSUER_LIST = MinSchannelConstants.SECPKG_ATTR_ISSUER_LIST,
        SECPKG_ATTR_REMOTE_CRED = MinSchannelConstants.SECPKG_ATTR_REMOTE_CRED,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_LocalCredentialInfo"/> structure. (obsolete)
        /// <para>Superseded by <see cref="SECPKG_ATTR_LOCAL_CERT_CONTEXT"/>.</para>
        /// </summary>
        [Obsolete("Superseded by SECPKG_ATTR_LOCAL_CERT_CONTEXT.")]
        SECPKG_ATTR_LOCAL_CRED = MinSchannelConstants.SECPKG_ATTR_LOCAL_CRED,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a pointer to a <see cref="CERT_CONTEXT"/> structure.
        /// <para>Finds a certificate context that contains the end certificate supplied by the server.</para>
        /// <para>This attribute is supported only by the Schannel <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>.</para>
        /// </summary>
        SECPKG_ATTR_REMOTE_CERT_CONTEXT = MinSchannelConstants.SECPKG_ATTR_REMOTE_CERT_CONTEXT,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a pointer to a <see cref="CCERT_CONTEXT"/> structure.
        /// <para>Finds a certificate context that contains a local end certificate.</para>
        /// <para>This attribute is supported only by the Schannel <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>.</para>
        /// </summary>
        SECPKG_ATTR_LOCAL_CERT_CONTEXT = MinSchannelConstants.SECPKG_ATTR_LOCAL_CERT_CONTEXT,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="HCERTCONTEXT"/>. Finds a certificate context that contains a certificate supplied by the Root store.
        /// </summary>
        SECPKG_ATTR_ROOT_STORE = MinSchannelConstants.SECPKG_ATTR_ROOT_STORE,
        /// <summary>
        /// Returns the supported algorithms in a pbuffer of type <see cref="SecPkgCred_SupportedAlgs"/>. All supported algorithms are included, regardless of whether they are supported by the provided certificate or enabled on the local computer.
        /// <para>This attribute is supported only by Schannel.</para>
        /// </summary>
        SECPKG_ATTR_SUPPORTED_ALGS = MinSchannelConstants.SECPKG_ATTR_SUPPORTED_ALGS,
        /// <summary>
        /// Returns the cipher strengths in a pbuffer of type <see cref="SecPkgCred_CipherStrengths"/>.
        /// <para>This attribute is supported only by Schannel.</para>
        /// </summary>
        SECPKG_ATTR_CIPHER_STRENGTHS = MinSchannelConstants.SECPKG_ATTR_CIPHER_STRENGTHS,
        /// <summary>
        /// Returns the supported algorithms in a pbuffer of type <see cref="SecPkgCred_SupportedProtocols"/>. All supported protocols are included, regardless of whether they are supported by the provided certificate or enabled on the local computer.
        /// <para>This attribute is supported only by Schannel.</para>
        /// </summary>
        SECPKG_ATTR_SUPPORTED_PROTOCOLS = MinSchannelConstants.SECPKG_ATTR_SUPPORTED_PROTOCOLS,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_IssuerListInfoEx"/> structure.
        /// <para>Returns a list of certificate issuers that are accepted by the server.</para>
        /// <para>This attribute is supported only by the Schannel <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>.</para>
        /// </summary>
        SECPKG_ATTR_ISSUER_LIST_EX = MinSchannelConstants.SECPKG_ATTR_ISSUER_LIST_EX,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a SecPkgContext_ConnectionInfo structure.
        /// <para>Returns detailed information on the established connection.</para>
        /// <para>This attribute is supported only by the Schannel <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>.</para>
        /// </summary>
        SECPKG_ATTR_CONNECTION_INFO = MinSchannelConstants.SECPKG_ATTR_CONNECTION_INFO,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_EapKeyBlock"/> structure.
        /// <para>Queries for key data used by the EAP TLS protocol.</para>
        /// <para>This attribute is supported only by the Schannel <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>.</para>
        /// </summary>
        SECPKG_ATTR_EAP_KEY_BLOCK = MinSchannelConstants.SECPKG_ATTR_EAP_KEY_BLOCK,
        SECPKG_ATTR_MAPPED_CRED_ATTR = MinSchannelConstants.SECPKG_ATTR_MAPPED_CRED_ATTR,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_SessionInfo"/> structure.
        /// <para>Returns information about the session.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// <para>This attribute is supported only by the Schannel <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>.</para>
        /// </summary>
        SECPKG_ATTR_SESSION_INFO = MinSchannelConstants.SECPKG_ATTR_SESSION_INFO,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_SessionAppData"/> structure.
        /// <para>Returns or specifies application data for the session.</para>
        /// <para>This attribute is supported only by the Schannel <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>.</para>
        /// </summary>
        SECPKG_ATTR_APP_DATA = MinSchannelConstants.SECPKG_ATTR_APP_DATA,
        SECPKG_ATTR_REMOTE_CERTIFICATES = MinSchannelConstants.SECPKG_ATTR_REMOTE_CERTIFICATES,
        SECPKG_ATTR_CLIENT_CERT_POLICY = MinSchannelConstants.SECPKG_ATTR_CLIENT_CERT_POLICY,
        SECPKG_ATTR_CC_POLICY_RESULT = MinSchannelConstants.SECPKG_ATTR_CC_POLICY_RESULT,
        SECPKG_ATTR_USE_NCRYPT = MinSchannelConstants.SECPKG_ATTR_USE_NCRYPT,
        SECPKG_ATTR_LOCAL_CERT_INFO = MinSchannelConstants.SECPKG_ATTR_LOCAL_CERT_INFO,
        SECPKG_ATTR_CIPHER_INFO = MinSchannelConstants.SECPKG_ATTR_CIPHER_INFO,
        /// <summary>
        ///  The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_EapPrfInfo"/> structure.
        ///  <para>Sets the pseudo-random function (PRF) used by the Extensible Authentication Protocol (EAP). This is the value that is returned by a call to the <see cref="QueryContextAttributes"/> (Schannel) function when <see cref="SECPKG_ATTR_EAP_KEY_BLOCK"/> is passed as the value of the <em>ulAttribute</em> parameter.</para>
        ///  <para>This attribute is supported only by the Schannel security package.</para>
        /// </summary>
        SECPKG_ATTR_EAP_PRF_INFO = MinSchannelConstants.SECPKG_ATTR_EAP_PRF_INFO,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_SupportedSignatures"/> structure.
        /// <para>This value returns information about the signature types that are supported for the connection.</para>
        /// <para>This value is supported only by the Schannel <a href="https://docs.microsoft.com/en-us/windows/win32/secgloss/s-gly">constrained delegation</a>.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        SECPKG_ATTR_SUPPORTED_SIGNATURES = MinSchannelConstants.SECPKG_ATTR_SUPPORTED_SIGNATURES,
        SECPKG_ATTR_REMOTE_CERT_CHAIN = MinSchannelConstants.SECPKG_ATTR_REMOTE_CERT_CHAIN,
        SECPKG_ATTR_UI_INFO = MinSchannelConstants.SECPKG_ATTR_UI_INFO,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_EarlyStart"/> structure.
        /// <para>Sets the False Start feature. See the <a href="https://docs.microsoft.com/windows/desktop/winmsg/windows">Building a faster and more secure web</a> blog post for information on this feature.</para>
        /// </summary>
        SECPKG_ATTR_EARLY_START = MinSchannelConstants.SECPKG_ATTR_EARLY_START,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_KeyingMaterialInfo"/> structure. The keying material export feature follows the <a href="https://tools.ietf.org/html/rfc5705">RFC 5705 standard</a>.
        /// <para>This attribute is supported only by the Schannel security package in Windows 10 and Windows Server 2016 or later versions.</para>
        /// </summary>
        SECPKG_ATTR_KEYING_MATERIAL_INFO = MinSchannelConstants.SECPKG_ATTR_KEYING_MATERIAL_INFO,
        SECPKG_ATTR_KEYING_MATERIAL = MinSchannelConstants.SECPKG_ATTR_KEYING_MATERIAL,
        SECPKG_ATTR_SRTP_PARAMETERS = MinSchannelConstants.SECPKG_ATTR_SRTP_PARAMETERS,
        SECPKG_ATTR_TOKEN_BINDING = MinSchannelConstants.SECPKG_ATTR_TOKEN_BINDING,
        SECPKG_ATTR_CONNECTION_INFO_EX = MinSchannelConstants.SECPKG_ATTR_CONNECTION_INFO_EX,
        SECPKG_ATTR_KEYING_MATERIAL_TOKEN_BINDING = MinSchannelConstants.SECPKG_ATTR_KEYING_MATERIAL_TOKEN_BINDING,

        // from credssp.h
        SECPKG_ALT_ATTR = CredSSPConstants.SECPKG_ALT_ATTR,
        SECPKG_ATTR_CREDS = CredSSPConstants.SECPKG_ATTR_CREDS,
        SECPKG_ATTR_NEGOTIATION_PACKAGE = CredSSPConstants.SECPKG_ATTR_NEGOTIATION_PACKAGE,
        SECPKG_ATTR_C_ACCESS_TOKEN = CredSSPConstants.SECPKG_ATTR_C_ACCESS_TOKEN,
        SECPKG_ATTR_C_FULL_ACCESS_TOKEN = CredSSPConstants.SECPKG_ATTR_C_FULL_ACCESS_TOKEN,
        SECPKG_ATTR_SERVER_AUTH_FLAGS = CredSSPConstants.SECPKG_ATTR_SERVER_AUTH_FLAGS,
        SECPKG_ATTR_CERT_TRUST_STATUS = CredSSPConstants.SECPKG_ATTR_CERT_TRUST_STATUS,
        SECPKG_ATTR_C_FULL_IDENT_TOKEN = CredSSPConstants.SECPKG_ATTR_C_FULL_IDENT_TOKEN,
        /// <summary>
        /// The pBuffer parameter contains a pointer to a <see cref="SecPkgContext_ClientCreds"/> structure that specifies client credentials.
        /// <para>If the client credential is user name and password, the buffer is a packed <see cref="KERB_INTERACTIVE_LOGON"/> structure.</para>
        /// <para>If the client credential is user name and smart card PIN, the buffer is a packed <see cref="KERB_CERTIFICATE_LOGON"/> structure.</para>
        /// <para>If the client credential is an online identity credential, the buffer is a marshaled <see cref="SEC_WINNT_AUTH_IDENTITY_EX2"/> structure.</para>
        /// <para>This attribute is supported only on the CredSSP server.</para>
        /// <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported.</para>
        /// </summary>
        SECPKG_ATTR_CREDS_2 = CredSSPConstants.SECPKG_ATTR_CREDS_2,

        //
        //  Security Credentials Attributes:
        //

        /// <summary>
        /// Returns the name of a credential in a pbuffer of type <see cref="SecPkgCredentials_Names"/>.
        /// <para>This attribute is not supported by Schannel in WOW64 mode.</para>
        /// </summary>
        SECPKG_CRED_ATTR_NAMES = SspiConstants.SECPKG_CRED_ATTR_NAMES,
        SECPKG_CRED_ATTR_SSI_PROVIDER = SspiConstants.SECPKG_CRED_ATTR_SSI_PROVIDER,
        /// <summary>
        /// Sets the Kerberos proxy setting in a pBuffer parameter of type <see cref="SecPkgCredentials_KdcProxySettings"/>.
        /// <para>This attribute is only supported by Kerberos.</para>
        /// </summary>
        SECPKG_CRED_ATTR_KDC_PROXY_SETTINGS = SspiConstants.SECPKG_CRED_ATTR_KDC_PROXY_SETTINGS,
        /// <summary>
        ///  Returns the certificate thumbprint in a pbuffer of type <see cref="SecPkgCredentials_Cert"/>.
        ///  <para>This attribute is only supported by Kerberos.</para>
        ///  <para><strong>Windows Server 2008 R2, Windows 7, Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This attribute is not available.</para>
        /// </summary>
        SECPKG_CRED_ATTR_CERT = SspiConstants.SECPKG_CRED_ATTR_CERT,
        SECPKG_CRED_ATTR_PAC_BYPASS = SspiConstants.SECPKG_CRED_ATTR_PAC_BYPASS,
    }
}
