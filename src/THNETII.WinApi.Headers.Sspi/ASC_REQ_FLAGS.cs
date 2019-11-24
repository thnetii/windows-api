using System;

namespace THNETII.WinApi.Native.Sspi
{
    [Flags]
    public enum ASC_REQ_FLAGS : int
    {
        /// <summary>
        /// The server is allowed to impersonate the client. Ignore this flag for <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">constrained delegation</a>. 
        /// </summary>
        ASC_REQ_DELEGATE = SspiConstants.ASC_REQ_DELEGATE,
        ASC_REQ_MUTUAL_AUTH = SspiConstants.ASC_REQ_MUTUAL_AUTH,
        /// <summary>
        /// Detect replayed packets. 
        /// </summary>
        ASC_REQ_REPLAY_DETECT = SspiConstants.ASC_REQ_REPLAY_DETECT,
        /// <summary>
        /// Detect messages received out of sequence. 
        /// </summary>
        ASC_REQ_SEQUENCE_DETECT = SspiConstants.ASC_REQ_SEQUENCE_DETECT,
        ASC_REQ_CONFIDENTIALITY = SspiConstants.ASC_REQ_CONFIDENTIALITY,
        ASC_REQ_USE_SESSION_KEY = SspiConstants.ASC_REQ_USE_SESSION_KEY,
        ASC_REQ_SESSION_TICKET = SspiConstants.ASC_REQ_SESSION_TICKET,
        /// <summary>
        ///  Credential Security Support Provider (CredSSP) will allocate output buffers. When you have finished using the output buffers, free them by calling the <see cref="FreeContextBuffer"/> function. 
        /// </summary>
        ASC_REQ_ALLOCATE_MEMORY = SspiConstants.ASC_REQ_ALLOCATE_MEMORY,
        ASC_REQ_USE_DCE_STYLE = SspiConstants.ASC_REQ_USE_DCE_STYLE,
        ASC_REQ_DATAGRAM = SspiConstants.ASC_REQ_DATAGRAM,
        /// <summary>
        /// The security context will not handle formatting messages. 
        /// </summary>
        ASC_REQ_CONNECTION = SspiConstants.ASC_REQ_CONNECTION,
        ASC_REQ_CALL_LEVEL = SspiConstants.ASC_REQ_CALL_LEVEL,
        ASC_REQ_FRAGMENT_SUPPLIED = SspiConstants.ASC_REQ_FRAGMENT_SUPPLIED,
        /// <summary>
        ///  When errors occur, the remote party will be notified. 
        /// </summary>
        ASC_REQ_EXTENDED_ERROR = SspiConstants.ASC_REQ_EXTENDED_ERROR,
        /// <summary>
        /// Support a stream-oriented connection. 
        /// </summary>
        ASC_REQ_STREAM = SspiConstants.ASC_REQ_STREAM,
        ASC_REQ_INTEGRITY = SspiConstants.ASC_REQ_INTEGRITY,
        ASC_REQ_LICENSING = SspiConstants.ASC_REQ_LICENSING,
        ASC_REQ_IDENTIFY = SspiConstants.ASC_REQ_IDENTIFY,
        ASC_REQ_ALLOW_NULL_SESSION = SspiConstants.ASC_REQ_ALLOW_NULL_SESSION,
        ASC_REQ_ALLOW_NON_USER_LOGONS = SspiConstants.ASC_REQ_ALLOW_NON_USER_LOGONS,
        ASC_REQ_ALLOW_CONTEXT_REPLAY = SspiConstants.ASC_REQ_ALLOW_CONTEXT_REPLAY,
        ASC_REQ_FRAGMENT_TO_FIT = SspiConstants.ASC_REQ_FRAGMENT_TO_FIT,

        ASC_REQ_NO_TOKEN = SspiConstants.ASC_REQ_NO_TOKEN,
        ASC_REQ_PROXY_BINDINGS = SspiConstants.ASC_REQ_PROXY_BINDINGS,
        //      SSP_RET_REAUTHENTICATION        0x08000000  // *INTERNAL*
        ASC_REQ_ALLOW_MISSING_BINDINGS = SspiConstants.ASC_REQ_ALLOW_MISSING_BINDINGS,
    }
}
