namespace THNETII.WinApi.Native.Sspi
{
    public enum SECBUFFER_TYPE
    {
        /// <summary>
        /// This is a placeholder in the buffer array. The caller can supply several such entries in the array, and the security package can return information in them. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SecAuthN/sspi-context-semantics">SSPI Context Semantics</a>.
        /// </summary>
        SECBUFFER_EMPTY = SspiConstants.SECBUFFER_EMPTY,   // Undefined, replaced by provider
        /// <summary>
        /// The buffer contains common data. The security package can read and write this data, for example, to encrypt some or all of it. 
        /// </summary>
        SECBUFFER_DATA = SspiConstants.SECBUFFER_DATA,   // Packet data
        SECBUFFER_TOKEN = SspiConstants.SECBUFFER_TOKEN,   // Security token
        /// <summary>
        /// These are transport-to-package–specific parameters. For example, the NetWare redirector may supply the server <a href="https://docs.microsoft.com/windows/desktop/SecGloss/o-gly">object identifier</a>, while DCE RPC can supply an association <strong>UUID</strong>, and so on.
        /// </summary>
        SECBUFFER_PKG_PARAMS = SspiConstants.SECBUFFER_PKG_PARAMS,   // Package specific parameters
        /// <summary>
        /// The security package uses this value to indicate the number of missing bytes in a particular message. The <see cref="Buffer"/> member is ignored in this type.
        /// </summary>
        SECBUFFER_MISSING = SspiConstants.SECBUFFER_MISSING,   // Missing Data indicator
        /// <summary>
        /// The security package uses this value to indicate the number of extra or unprocessed bytes in a message.
        /// </summary>
        SECBUFFER_EXTRA = SspiConstants.SECBUFFER_EXTRA,   // Extra data
        SECBUFFER_STREAM_TRAILER = SspiConstants.SECBUFFER_STREAM_TRAILER,   // Security Trailer
        SECBUFFER_STREAM_HEADER = SspiConstants.SECBUFFER_STREAM_HEADER,   // Security Header
        SECBUFFER_NEGOTIATION_INFO = SspiConstants.SECBUFFER_NEGOTIATION_INFO,   // Hints from the negotiation pkg
        SECBUFFER_PADDING = SspiConstants.SECBUFFER_PADDING,   // non-data padding
        SECBUFFER_STREAM = SspiConstants.SECBUFFER_STREAM,  // whole encrypted message
        /// <summary>
        /// The buffer contains a protocol-specific list of object identifiers (OIDs). It is not usually of interest to callers.
        /// </summary>
        SECBUFFER_MECHLIST = SspiConstants.SECBUFFER_MECHLIST,
        /// <summary>
        /// The buffer contains a signature of a <see cref="SECBUFFER_MECHLIST"/> buffer. It is not usually of interest to callers.
        /// </summary>
        SECBUFFER_MECHLIST_SIGNATURE = SspiConstants.SECBUFFER_MECHLIST_SIGNATURE,
        SECBUFFER_TARGET = SspiConstants.SECBUFFER_TARGET,  // obsolete
        /// <summary>
        /// The buffer contains channel binding information. 
        /// </summary>
        SECBUFFER_CHANNEL_BINDINGS = SspiConstants.SECBUFFER_CHANNEL_BINDINGS,
        /// <summary>
        /// The buffer contains a <see cref="DOMAIN_PASSWORD_INFORMATION"/> structure. 
        /// </summary>
        SECBUFFER_CHANGE_PASS_RESPONSE = SspiConstants.SECBUFFER_CHANGE_PASS_RESPONSE,
        SECBUFFER_TARGET_HOST = SspiConstants.SECBUFFER_TARGET_HOST,
        /// <summary>
        ///  The buffer contains an alert message. 
        /// </summary>
        SECBUFFER_ALERT = SspiConstants.SECBUFFER_ALERT,
        SECBUFFER_APPLICATION_PROTOCOLS = SspiConstants.SECBUFFER_APPLICATION_PROTOCOLS,  // Lists of application protocol IDs, one per negotiation extension
        /// <summary>
        /// The buffer contains the list of SRTP protection profiles, in descending order of preference.
        /// </summary>
        SECBUFFER_SRTP_PROTECTION_PROFILES = SspiConstants.SECBUFFER_SRTP_PROTECTION_PROFILES,  // List of SRTP protection profiles, in descending order of preference
        /// <summary>
        /// The buffer contains the SRTP master key identifier.
        /// </summary>
        SECBUFFER_SRTP_MASTER_KEY_IDENTIFIER = SspiConstants.SECBUFFER_SRTP_MASTER_KEY_IDENTIFIER,  // SRTP master key identifier
        SECBUFFER_TOKEN_BINDING = SspiConstants.SECBUFFER_TOKEN_BINDING,  // Supported Token Binding protocol version and key parameters
        /// <summary>
        ///  The buffer contains the preshared key. The maximum allowed PSK buffer size is 256 bytes. 
        /// </summary>
        SECBUFFER_PRESHARED_KEY = SspiConstants.SECBUFFER_PRESHARED_KEY,  // Preshared key
        /// <summary>
        /// The buffer contains the preshared key identity. 
        /// </summary>
        SECBUFFER_PRESHARED_KEY_IDENTITY = SspiConstants.SECBUFFER_PRESHARED_KEY_IDENTITY,  // Preshared key identity
        /// <summary>
        ///  The buffer contains the setting for the maximum transmission unit (MTU) size for DTLS only. The default value is 1096 and the valid configurable range is between 200 and 64*1024. 
        /// </summary>
        SECBUFFER_DTLS_MTU = SspiConstants.SECBUFFER_DTLS_MTU,  // DTLS path MTU setting


        SECBUFFER_ATTRMASK = SspiConstants.SECBUFFER_ATTRMASK,
        SECBUFFER_READONLY = SspiConstants.SECBUFFER_READONLY,  // Buffer is read-only, no checksum
        SECBUFFER_READONLY_WITH_CHECKSUM = SspiConstants.SECBUFFER_READONLY_WITH_CHECKSUM,  // Buffer is read-only, and checksummed
        SECBUFFER_RESERVED = SspiConstants.SECBUFFER_RESERVED,  // Flags reserved to security system
    }
}
