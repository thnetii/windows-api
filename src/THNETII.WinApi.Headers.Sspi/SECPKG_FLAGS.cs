using System;

namespace THNETII.WinApi.Native.Sspi
{
    //
    //  Security Package Capabilities
    //
    [Flags]
    public enum SECPKG_FLAGS : int
    {
        /// <summary>
        ///  The security package supports the <see cref="MakeSignature"/> and <see cref="VerifySignature"/> functions. 
        /// </summary>
        SECPKG_FLAG_INTEGRITY = SspiConstants.SECPKG_FLAG_INTEGRITY,  // Supports integrity on messages
        /// <summary>
        /// The security package supports the <see cref="EncryptMessage"/> (General) and <see cref="DecryptMessage"/> (General) functions. 
        /// </summary>
        SECPKG_FLAG_PRIVACY = SspiConstants.SECPKG_FLAG_PRIVACY,  // Supports privacy (confidentiality)
        /// <summary>
        /// The package is interested only in the security-token portion of messages, and will ignore any other buffers. This is a performance-related issue. 
        /// </summary>
        SECPKG_FLAG_TOKEN_ONLY = SspiConstants.SECPKG_FLAG_TOKEN_ONLY,  // Only security token needed
        /// <summary>
        /// Supports <a href="https://docs.microsoft.com/windows/desktop/SecGloss/d-gly">datagram</a>-style authentication. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/sspi-context-semantics">SSPI Context Semantics</a>.
        /// <para><note>The <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/microsoft-kerberos">Microsoft Kerberos</a> package does not support datagram contexts in user-to-user mode.</note></para>
        /// </summary>
        SECPKG_FLAG_DATAGRAM = SspiConstants.SECPKG_FLAG_DATAGRAM,  // Datagram RPC support
        /// <summary>
        ///  Supports connection-oriented style authentication. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/sspi-context-semantics">SSPI Context Semantics</a>. 
        /// </summary>
        SECPKG_FLAG_CONNECTION = SspiConstants.SECPKG_FLAG_CONNECTION,  // Connection oriented RPC support
        /// <summary>
        ///  Multiple legs are required for authentication. 
        /// </summary>
        SECPKG_FLAG_MULTI_REQUIRED = SspiConstants.SECPKG_FLAG_MULTI_REQUIRED,  // Full 3-leg required for re-auth.
        /// <summary>
        /// Server authentication support is not provided. 
        /// </summary>
        SECPKG_FLAG_CLIENT_ONLY = SspiConstants.SECPKG_FLAG_CLIENT_ONLY,  // Server side functionality not available
        /// <summary>
        /// Supports extended error handling. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/extended-error-information">Extended Error Information</a>. 
        /// </summary>
        SECPKG_FLAG_EXTENDED_ERROR = SspiConstants.SECPKG_FLAG_EXTENDED_ERROR,  // Supports extended error msgs
        /// <summary>
        ///  Supports Windows impersonation in server contexts. 
        /// </summary>
        SECPKG_FLAG_IMPERSONATION = SspiConstants.SECPKG_FLAG_IMPERSONATION,  // Supports impersonation
        /// <summary>
        /// Understands Windows principal and target names. 
        /// </summary>
        SECPKG_FLAG_ACCEPT_WIN32_NAME = SspiConstants.SECPKG_FLAG_ACCEPT_WIN32_NAME,  // Accepts Win32 names
        /// <summary>
        /// Supports stream semantics. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/sspi-context-semantics">SSPI Context Semantics</a>. 
        /// </summary>
        SECPKG_FLAG_STREAM = SspiConstants.SECPKG_FLAG_STREAM,  // Supports stream semantics
        /// <summary>
        ///  Can be used by the <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/microsoft-negotiate">Microsoft Negotiate</a> security package. 
        /// </summary>
        SECPKG_FLAG_NEGOTIABLE = SspiConstants.SECPKG_FLAG_NEGOTIABLE,  // Can be used by the negotiate package
        /// <summary>
        ///  Supports GSS compatibility. 
        /// </summary>
        SECPKG_FLAG_GSS_COMPATIBLE = SspiConstants.SECPKG_FLAG_GSS_COMPATIBLE,  // GSS Compatibility Available
        /// <summary>
        /// Supports <see cref="LsaLogonUser"/>. 
        /// </summary>
        SECPKG_FLAG_LOGON = SspiConstants.SECPKG_FLAG_LOGON,  // Supports common LsaLogonUser
        /// <summary>
        /// Token buffers are in ASCII characters format. 
        /// </summary>
        SECPKG_FLAG_ASCII_BUFFERS = SspiConstants.SECPKG_FLAG_ASCII_BUFFERS,  // Token Buffers are in ASCII
        /// <summary>
        /// Supports separating large tokens into smaller buffers so that applications can make repeated calls to <see cref="InitializeSecurityContext"/> (General) and <see cref="AcceptSecurityContext"/> (General) with the smaller buffers to complete authentication. 
        /// </summary>
        SECPKG_FLAG_FRAGMENT = SspiConstants.SECPKG_FLAG_FRAGMENT,  // Package can fragment to fit
        /// <summary>
        /// Supports mutual authentication. 
        /// </summary>
        SECPKG_FLAG_MUTUAL_AUTH = SspiConstants.SECPKG_FLAG_MUTUAL_AUTH,  // Package can perform mutual authentication
        /// <summary>
        /// Supports delegation. 
        /// </summary>
        SECPKG_FLAG_DELEGATION = SspiConstants.SECPKG_FLAG_DELEGATION,  // Package can delegate
        /// <summary>
        /// The security package supports using a checksum instead of in-place encryption when calling the <see cref="EncryptMessage"/> function. 
        /// </summary>
        SECPKG_FLAG_READONLY_WITH_CHECKSUM = SspiConstants.SECPKG_FLAG_READONLY_WITH_CHECKSUM,  // Package can delegate
        /// <summary>
        /// Supports callers with restricted tokens. 
        /// </summary>
        SECPKG_FLAG_RESTRICTED_TOKENS = SspiConstants.SECPKG_FLAG_RESTRICTED_TOKENS,  // Package supports restricted callers
        /// <summary>
        /// The security package extends the <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/microsoft-negotiate">Microsoft Negotiate</a> security package. There can be at most one package of this type. 
        /// </summary>
        SECPKG_FLAG_NEGO_EXTENDER = SspiConstants.SECPKG_FLAG_NEGO_EXTENDER,  // this package extends SPNEGO, there is at most one
        /// <summary>
        ///  This package is negotiated by the package of type <see cref="SECPKG_FLAG_NEGO_EXTENDER"/>. 
        /// </summary>
        SECPKG_FLAG_NEGOTIABLE2 = SspiConstants.SECPKG_FLAG_NEGOTIABLE2,  // this package is negotiated under the NegoExtender
        /// <summary>
        /// This package receives all calls from app container apps. 
        /// </summary>
        SECPKG_FLAG_APPCONTAINER_PASSTHROUGH = SspiConstants.SECPKG_FLAG_APPCONTAINER_PASSTHROUGH,  // this package receives all calls from appcontainer apps
        /// <summary>
        /// This package receives calls from app container apps if one of the following checks succeeds.
        /// <list type="bullet">
        /// <item>Caller has default credentials capability.</item>
        /// <item>The target is a proxy server.</item>
        /// <item>The caller has supplied credentials.</item>
        /// </list>
        /// </summary>
        SECPKG_FLAG_APPCONTAINER_CHECKS = SspiConstants.SECPKG_FLAG_APPCONTAINER_CHECKS,  // this package receives calls from appcontainer apps
                                                                                          // if the following checks succeed
                                                                                          // 1. Caller has domain auth capability or
                                                                                          // 2. Target is a proxy server or
                                                                                          // 3. The caller has supplied creds
        /// <summary>
        /// This package is running with Credential Guard enabled.
        /// </summary>
        SECPKG_FLAG_CREDENTIAL_ISOLATION_ENABLED = SspiConstants.SECPKG_FLAG_CREDENTIAL_ISOLATION_ENABLED,
    }
}
