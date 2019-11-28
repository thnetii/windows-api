using System;

namespace THNETII.WinApi.Native.Sspi
{
    [Flags]
    public enum ISC_REQ_FLAGS : int
    {
        /// <summary>
        /// The server can use the context to authenticate to other servers as the client. The <see cref="ISC_REQ_MUTUAL_AUTH"/> flag must be set for this flag to work. Valid for Kerberos. Ignore this flag for <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">constrained delegation</a>. 
        /// </summary>
        ISC_REQ_DELEGATE = SspiConstants.ISC_REQ_DELEGATE,
        /// <summary>
        /// The mutual authentication policy of the service will be satisfied.
        /// <para><note type="caution">This does not necessarily mean that mutual authentication is performed, only that the authentication policy of the service is satisfied. To ensure that mutual authentication is performed, call the <see cref="QueryContextAttributes"/> (General) function.</note></para>
        /// </summary>
        ISC_REQ_MUTUAL_AUTH = SspiConstants.ISC_REQ_MUTUAL_AUTH,
        /// <summary>
        ///  Detect replayed messages that have been encoded by using the <see cref="EncryptMessage"/> or <see cref="MakeSignature"/> functions. 
        /// </summary>
        ISC_REQ_REPLAY_DETECT = SspiConstants.ISC_REQ_REPLAY_DETECT,
        /// <summary>
        /// Detect messages received out of sequence. 
        /// </summary>
        ISC_REQ_SEQUENCE_DETECT = SspiConstants.ISC_REQ_SEQUENCE_DETECT,
        /// <summary>
        /// Encrypt messages by using the <see cref="EncryptMessage"/> function. 
        /// </summary>
        ISC_REQ_CONFIDENTIALITY = SspiConstants.ISC_REQ_CONFIDENTIALITY,
        /// <summary>
        /// <para>A new <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">session key</a> must be negotiated. </para>
        /// <para>This value is supported only by the Kerberos <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security package</a>.</para>
        /// </summary>
        ISC_REQ_USE_SESSION_KEY = SspiConstants.ISC_REQ_USE_SESSION_KEY,
        ISC_REQ_PROMPT_FOR_CREDS = SspiConstants.ISC_REQ_PROMPT_FOR_CREDS,
        /// <summary>
        ///  Schannel must not attempt to supply credentials for the client automatically. 
        /// </summary>
        ISC_REQ_USE_SUPPLIED_CREDS = SspiConstants.ISC_REQ_USE_SUPPLIED_CREDS,
        /// <summary>
        /// The security package allocates output buffers for you. When you have finished using the output buffers, free them by calling the <see cref="FreeContextBuffer"/> function. 
        /// </summary>
        ISC_REQ_ALLOCATE_MEMORY = SspiConstants.ISC_REQ_ALLOCATE_MEMORY,
        ISC_REQ_USE_DCE_STYLE = SspiConstants.ISC_REQ_USE_DCE_STYLE,
        ISC_REQ_DATAGRAM = SspiConstants.ISC_REQ_DATAGRAM,
        /// <summary>
        /// The security context will not handle formatting messages. This value is the default for the Kerberos, Negotiate, and NTLM security packages. 
        /// </summary>
        ISC_REQ_CONNECTION = SspiConstants.ISC_REQ_CONNECTION,
        ISC_REQ_CALL_LEVEL = SspiConstants.ISC_REQ_CALL_LEVEL,
        ISC_REQ_FRAGMENT_SUPPLIED = SspiConstants.ISC_REQ_FRAGMENT_SUPPLIED,
        /// <summary>
        ///  When errors occur, the remote party will be notified. 
        /// </summary>
        ISC_REQ_EXTENDED_ERROR = SspiConstants.ISC_REQ_EXTENDED_ERROR,
        /// <summary>
        /// Support a stream-oriented connection. 
        /// </summary>
        ISC_REQ_STREAM = SspiConstants.ISC_REQ_STREAM,
        /// <summary>
        ///  Sign messages and verify signatures by using the <see cref="EncryptMessage"/> and <see cref="MakeSignature"/> functions. 
        /// </summary>
        ISC_REQ_INTEGRITY = SspiConstants.ISC_REQ_INTEGRITY,
        ISC_REQ_IDENTIFY = SspiConstants.ISC_REQ_IDENTIFY,
        ISC_REQ_NULL_SESSION = SspiConstants.ISC_REQ_NULL_SESSION,
        /// <summary>
        /// Schannel must not authenticate the server automatically. 
        /// </summary>
        ISC_REQ_MANUAL_CRED_VALIDATION = SspiConstants.ISC_REQ_MANUAL_CRED_VALIDATION,
        ISC_REQ_RESERVED1 = SspiConstants.ISC_REQ_RESERVED1,
        ISC_REQ_FRAGMENT_TO_FIT = SspiConstants.ISC_REQ_FRAGMENT_TO_FIT,
        // This exists only in Windows Vista and greater
        ISC_REQ_FORWARD_CREDENTIALS = SspiConstants.ISC_REQ_FORWARD_CREDENTIALS,
        /// <summary>
        /// <para> If this flag is set, the <see cref="ISC_REQ_INTEGRITY"/> flag is ignored.</para>
        /// <para>This value is supported only by the Negotiate and Kerberos <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security packages</a>.</para>
        /// </summary>
        ISC_REQ_NO_INTEGRITY = SspiConstants.ISC_REQ_NO_INTEGRITY, // honored only by SPNEGO
        ISC_REQ_USE_HTTP_STYLE = SspiConstants.ISC_REQ_USE_HTTP_STYLE,
        ISC_REQ_UNVERIFIED_TARGET_NAME = SspiConstants.ISC_REQ_UNVERIFIED_TARGET_NAME,
        ISC_REQ_CONFIDENTIALITY_ONLY = SspiConstants.ISC_REQ_CONFIDENTIALITY_ONLY, // honored by SPNEGO/Kerberos
    }
}
