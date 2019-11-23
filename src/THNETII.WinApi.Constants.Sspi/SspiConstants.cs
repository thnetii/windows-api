using System;

namespace THNETII.WinApi.Native.Sspi
{
    public static class SspiConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 268
        //
        //  Security Package Capabilities
        //
        public const int SECPKG_FLAG_INTEGRITY = 0x00000001;                    // Supports integrity on messages
        public const int SECPKG_FLAG_PRIVACY = 0x00000002;                      // Supports privacy (confidentiality)
        public const int SECPKG_FLAG_TOKEN_ONLY = 0x00000004;                   // Only security token needed
        public const int SECPKG_FLAG_DATAGRAM = 0x00000008;                     // Datagram RPC support
        public const int SECPKG_FLAG_CONNECTION = 0x00000010;                   // Connection oriented RPC support
        public const int SECPKG_FLAG_MULTI_REQUIRED = 0x00000020;               // Full 3-leg required for re-auth.
        public const int SECPKG_FLAG_CLIENT_ONLY = 0x00000040;                  // Server side functionality not available
        public const int SECPKG_FLAG_EXTENDED_ERROR = 0x00000080;               // Supports extended error msgs
        public const int SECPKG_FLAG_IMPERSONATION = 0x00000100;                // Supports impersonation
        public const int SECPKG_FLAG_ACCEPT_WIN32_NAME = 0x00000200;            // Accepts Win32 names
        public const int SECPKG_FLAG_STREAM = 0x00000400;                       // Supports stream semantics
        public const int SECPKG_FLAG_NEGOTIABLE = 0x00000800;                   // Can be used by the negotiate package
        public const int SECPKG_FLAG_GSS_COMPATIBLE = 0x00001000;               // GSS Compatibility Available
        public const int SECPKG_FLAG_LOGON = 0x00002000;                        // Supports common LsaLogonUser
        public const int SECPKG_FLAG_ASCII_BUFFERS = 0x00004000;                // Token Buffers are in ASCII
        public const int SECPKG_FLAG_FRAGMENT = 0x00008000;                     // Package can fragment to fit
        public const int SECPKG_FLAG_MUTUAL_AUTH = 0x00010000;                  // Package can perform mutual authentication
        public const int SECPKG_FLAG_DELEGATION = 0x00020000;                   // Package can delegate
        public const int SECPKG_FLAG_READONLY_WITH_CHECKSUM = 0x00040000;       // Package can delegate
        public const int SECPKG_FLAG_RESTRICTED_TOKENS = 0x00080000;            // Package supports restricted callers
        public const int SECPKG_FLAG_NEGO_EXTENDER = 0x00100000;                // this package extends SPNEGO, there is at most one
        public const int SECPKG_FLAG_NEGOTIABLE2 = 0x00200000;                  // this package is negotiated under the NegoExtender
        public const int SECPKG_FLAG_APPCONTAINER_PASSTHROUGH = 0x00400000;     // this package receives all calls from appcontainer apps
        public const int SECPKG_FLAG_APPCONTAINER_CHECKS = 0x00800000;          // this package receives calls from appcontainer apps
                                                                                // 3. The caller has supplied creds
        public const int SECPKG_FLAG_CREDENTIAL_ISOLATION_ENABLED = 0x01000000; // this package is running with Credential Guard enabled

        public const ushort SECPKG_ID_NONE = 0xFFFF;

        //
        // Extended Call Flags that currently contains
        // Appcontainer related information about the caller.
        // Packages can query for these
        // via an LsaFunction GetExtendedCallFlags
        //

        public const int SECPKG_CALLFLAGS_APPCONTAINER = 0x00000001;
        public const int SECPKG_CALLFLAGS_APPCONTAINER_AUTHCAPABLE = 0x00000002;
        public const int SECPKG_CALLFLAGS_FORCE_SUPPLIED = 0x00000004;
        public const int SECPKG_CALLFLAGS_APPCONTAINER_UPNCAPABLE = 0x00000008;

        public const int SECBUFFER_VERSION = 0;

        public const int SECBUFFER_EMPTY = 0;   // Undefined, replaced by provider
        public const int SECBUFFER_DATA = 1;   // Packet data
        public const int SECBUFFER_TOKEN = 2;   // Security token
        public const int SECBUFFER_PKG_PARAMS = 3;   // Package specific parameters
        public const int SECBUFFER_MISSING = 4;   // Missing Data indicator
        public const int SECBUFFER_EXTRA = 5;   // Extra data
        public const int SECBUFFER_STREAM_TRAILER = 6;   // Security Trailer
        public const int SECBUFFER_STREAM_HEADER = 7;   // Security Header
        public const int SECBUFFER_NEGOTIATION_INFO = 8;   // Hints from the negotiation pkg
        public const int SECBUFFER_PADDING = 9;   // non-data padding
        public const int SECBUFFER_STREAM = 10;  // whole encrypted message
        public const int SECBUFFER_MECHLIST = 11;
        public const int SECBUFFER_MECHLIST_SIGNATURE = 12;
        public const int SECBUFFER_TARGET = 13;  // obsolete
        public const int SECBUFFER_CHANNEL_BINDINGS = 14;
        public const int SECBUFFER_CHANGE_PASS_RESPONSE = 15;
        public const int SECBUFFER_TARGET_HOST = 16;
        public const int SECBUFFER_ALERT = 17;
        public const int SECBUFFER_APPLICATION_PROTOCOLS = 18;  // Lists of application protocol IDs, one per negotiation extension
        public const int SECBUFFER_SRTP_PROTECTION_PROFILES = 19;  // List of SRTP protection profiles, in descending order of preference
        public const int SECBUFFER_SRTP_MASTER_KEY_IDENTIFIER = 20;  // SRTP master key identifier
        public const int SECBUFFER_TOKEN_BINDING = 21;  // Supported Token Binding protocol version and key parameters
        public const int SECBUFFER_PRESHARED_KEY = 22;  // Preshared key
        public const int SECBUFFER_PRESHARED_KEY_IDENTITY = 23;  // Preshared key identity
        public const int SECBUFFER_DTLS_MTU = 24;  // DTLS path MTU setting


        public const int SECBUFFER_ATTRMASK = unchecked((int)0xF0000000);
        public const int SECBUFFER_READONLY = unchecked((int)0x80000000);  // Buffer is read-only, no checksum
        public const int SECBUFFER_READONLY_WITH_CHECKSUM = 0x10000000;  // Buffer is read-only, and checksummed
        public const int SECBUFFER_RESERVED = 0x60000000;  // Flags reserved to security system

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 447
        //
        //  Data Representation Constant:
        //
        public const int SECURITY_NATIVE_DREP = 0x00000010;
        public const int SECURITY_NETWORK_DREP = 0x00000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 453
        //
        //  Credential Use Flags
        //
        public const int SECPKG_CRED_INBOUND = 0x00000001;
        public const int SECPKG_CRED_OUTBOUND = 0x00000002;
        public const int SECPKG_CRED_BOTH = 0x00000003;
        public const int SECPKG_CRED_DEFAULT = 0x00000004;
        public const int SECPKG_CRED_RESERVED = unchecked((int)0xF0000000);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 462
        //
        //  SSP SHOULD prompt the user for credentials/consent, independent
        //  of whether credentials to be used are the 'logged on' credentials
        //  or retrieved from credman.
        //
        //  An SSP may choose not to prompt, however, in circumstances determined
        //  by the SSP.
        //

        public const int SECPKG_CRED_AUTOLOGON_RESTRICTED = 0x00000010;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 473
        //
        // auth will always fail, ISC() is called to process policy data only
        //

        public const int SECPKG_CRED_PROCESS_POLICY_ONLY = 0x00000020;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 480
        //
        //  InitializeSecurityContext Requirement and return flags:
        //

        public const int ISC_REQ_DELEGATE = 0x00000001;
        public const int ISC_REQ_MUTUAL_AUTH = 0x00000002;
        public const int ISC_REQ_REPLAY_DETECT = 0x00000004;
        public const int ISC_REQ_SEQUENCE_DETECT = 0x00000008;
        public const int ISC_REQ_CONFIDENTIALITY = 0x00000010;
        public const int ISC_REQ_USE_SESSION_KEY = 0x00000020;
        public const int ISC_REQ_PROMPT_FOR_CREDS = 0x00000040;
        public const int ISC_REQ_USE_SUPPLIED_CREDS = 0x00000080;
        public const int ISC_REQ_ALLOCATE_MEMORY = 0x00000100;
        public const int ISC_REQ_USE_DCE_STYLE = 0x00000200;
        public const int ISC_REQ_DATAGRAM = 0x00000400;
        public const int ISC_REQ_CONNECTION = 0x00000800;
        public const int ISC_REQ_CALL_LEVEL = 0x00001000;
        public const int ISC_REQ_FRAGMENT_SUPPLIED = 0x00002000;
        public const int ISC_REQ_EXTENDED_ERROR = 0x00004000;
        public const int ISC_REQ_STREAM = 0x00008000;
        public const int ISC_REQ_INTEGRITY = 0x00010000;
        public const int ISC_REQ_IDENTIFY = 0x00020000;
        public const int ISC_REQ_NULL_SESSION = 0x00040000;
        public const int ISC_REQ_MANUAL_CRED_VALIDATION = 0x00080000;
        public const int ISC_REQ_RESERVED1 = 0x00100000;
        public const int ISC_REQ_FRAGMENT_TO_FIT = 0x00200000;
        // This exists only in Windows Vista and greater
        public const int ISC_REQ_FORWARD_CREDENTIALS = 0x00400000;
        public const int ISC_REQ_NO_INTEGRITY = 0x00800000; // honored only by SPNEGO
        public const int ISC_REQ_USE_HTTP_STYLE = 0x01000000;
        public const int ISC_REQ_UNVERIFIED_TARGET_NAME = 0x20000000;
        public const int ISC_REQ_CONFIDENTIALITY_ONLY = 0x40000000; // honored by SPNEGO/Kerberos

        public const int ISC_RET_DELEGATE = 0x00000001;
        public const int ISC_RET_MUTUAL_AUTH = 0x00000002;
        public const int ISC_RET_REPLAY_DETECT = 0x00000004;
        public const int ISC_RET_SEQUENCE_DETECT = 0x00000008;
        public const int ISC_RET_CONFIDENTIALITY = 0x00000010;
        public const int ISC_RET_USE_SESSION_KEY = 0x00000020;
        public const int ISC_RET_USED_COLLECTED_CREDS = 0x00000040;
        public const int ISC_RET_USED_SUPPLIED_CREDS = 0x00000080;
        public const int ISC_RET_ALLOCATED_MEMORY = 0x00000100;
        public const int ISC_RET_USED_DCE_STYLE = 0x00000200;
        public const int ISC_RET_DATAGRAM = 0x00000400;
        public const int ISC_RET_CONNECTION = 0x00000800;
        public const int ISC_RET_INTERMEDIATE_RETURN = 0x00001000;
        public const int ISC_RET_CALL_LEVEL = 0x00002000;
        public const int ISC_RET_EXTENDED_ERROR = 0x00004000;
        public const int ISC_RET_STREAM = 0x00008000;
        public const int ISC_RET_INTEGRITY = 0x00010000;
        public const int ISC_RET_IDENTIFY = 0x00020000;
        public const int ISC_RET_NULL_SESSION = 0x00040000;
        public const int ISC_RET_MANUAL_CRED_VALIDATION = 0x00080000;
        public const int ISC_RET_RESERVED1 = 0x00100000;
        public const int ISC_RET_FRAGMENT_ONLY = 0x00200000;
        // This exists only in Windows Vista and greater
        public const int ISC_RET_FORWARD_CREDENTIALS = 0x00400000;

        public const int ISC_RET_USED_HTTP_STYLE = 0x01000000;
        public const int ISC_RET_NO_ADDITIONAL_TOKEN = 0x02000000; // *INTERNAL*
        public const int ISC_RET_REAUTHENTICATION = 0x08000000; // *INTERNAL*
        public const int ISC_RET_CONFIDENTIALITY_ONLY = 0x40000000; // honored by SPNEGO/Kerberos

        public const int ASC_REQ_DELEGATE = 0x00000001;
        public const int ASC_REQ_MUTUAL_AUTH = 0x00000002;
        public const int ASC_REQ_REPLAY_DETECT = 0x00000004;
        public const int ASC_REQ_SEQUENCE_DETECT = 0x00000008;
        public const int ASC_REQ_CONFIDENTIALITY = 0x00000010;
        public const int ASC_REQ_USE_SESSION_KEY = 0x00000020;
        public const int ASC_REQ_SESSION_TICKET = 0x00000040;
        public const int ASC_REQ_ALLOCATE_MEMORY = 0x00000100;
        public const int ASC_REQ_USE_DCE_STYLE = 0x00000200;
        public const int ASC_REQ_DATAGRAM = 0x00000400;
        public const int ASC_REQ_CONNECTION = 0x00000800;
        public const int ASC_REQ_CALL_LEVEL = 0x00001000;
        public const int ASC_REQ_FRAGMENT_SUPPLIED = 0x00002000;
        public const int ASC_REQ_EXTENDED_ERROR = 0x00008000;
        public const int ASC_REQ_STREAM = 0x00010000;
        public const int ASC_REQ_INTEGRITY = 0x00020000;
        public const int ASC_REQ_LICENSING = 0x00040000;
        public const int ASC_REQ_IDENTIFY = 0x00080000;
        public const int ASC_REQ_ALLOW_NULL_SESSION = 0x00100000;
        public const int ASC_REQ_ALLOW_NON_USER_LOGONS = 0x00200000;
        public const int ASC_REQ_ALLOW_CONTEXT_REPLAY = 0x00400000;
        public const int ASC_REQ_FRAGMENT_TO_FIT = 0x00800000;

        public const int ASC_REQ_NO_TOKEN = 0x01000000;
        public const int ASC_REQ_PROXY_BINDINGS = 0x04000000;
        //      SSP_RET_REAUTHENTICATION        0x08000000  // *INTERNAL*
        public const int ASC_REQ_ALLOW_MISSING_BINDINGS = 0x10000000;

        public const int ASC_RET_DELEGATE = 0x00000001;
        public const int ASC_RET_MUTUAL_AUTH = 0x00000002;
        public const int ASC_RET_REPLAY_DETECT = 0x00000004;
        public const int ASC_RET_SEQUENCE_DETECT = 0x00000008;
        public const int ASC_RET_CONFIDENTIALITY = 0x00000010;
        public const int ASC_RET_USE_SESSION_KEY = 0x00000020;
        public const int ASC_RET_SESSION_TICKET = 0x00000040;
        public const int ASC_RET_ALLOCATED_MEMORY = 0x00000100;
        public const int ASC_RET_USED_DCE_STYLE = 0x00000200;
        public const int ASC_RET_DATAGRAM = 0x00000400;
        public const int ASC_RET_CONNECTION = 0x00000800;
        public const int ASC_RET_CALL_LEVEL = 0x00002000; // skipped 1000 to be like ISC_
        public const int ASC_RET_THIRD_LEG_FAILED = 0x00004000;
        public const int ASC_RET_EXTENDED_ERROR = 0x00008000;
        public const int ASC_RET_STREAM = 0x00010000;
        public const int ASC_RET_INTEGRITY = 0x00020000;
        public const int ASC_RET_LICENSING = 0x00040000;
        public const int ASC_RET_IDENTIFY = 0x00080000;
        public const int ASC_RET_NULL_SESSION = 0x00100000;
        public const int ASC_RET_ALLOW_NON_USER_LOGONS = 0x00200000;
        public const int ASC_RET_ALLOW_CONTEXT_REPLAY = 0x00400000;  // deprecated - don't use this flag!!!
        public const int ASC_RET_FRAGMENT_ONLY = 0x00800000;
        public const int ASC_RET_NO_TOKEN = 0x01000000;
        public const int ASC_RET_NO_ADDITIONAL_TOKEN = 0x02000000;  // *INTERNAL*
        //      SSP_RET_REAUTHENTICATION        0x08000000  // *INTERNAL*

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 597
        //
        //  Security Credentials Attributes:
        //

        public const int SECPKG_CRED_ATTR_NAMES = 1;
        public const int SECPKG_CRED_ATTR_SSI_PROVIDER = 2;
        public const int SECPKG_CRED_ATTR_KDC_PROXY_SETTINGS = 3;
        public const int SECPKG_CRED_ATTR_CERT = 4;
        public const int SECPKG_CRED_ATTR_PAC_BYPASS = 5;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 664
        public const int KDC_PROXY_SETTINGS_V1 = 1;
        public const int KDC_PROXY_SETTINGS_FLAGS_FORCEPROXY = 0x1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 691
        //
        //  Security Context Attributes:
        //

        public const int SECPKG_ATTR_SIZES = 0;
        public const int SECPKG_ATTR_NAMES = 1;
        public const int SECPKG_ATTR_LIFESPAN = 2;
        public const int SECPKG_ATTR_DCE_INFO = 3;
        public const int SECPKG_ATTR_STREAM_SIZES = 4;
        public const int SECPKG_ATTR_KEY_INFO = 5;
        public const int SECPKG_ATTR_AUTHORITY = 6;
        public const int SECPKG_ATTR_PROTO_INFO = 7;
        public const int SECPKG_ATTR_PASSWORD_EXPIRY = 8;
        public const int SECPKG_ATTR_SESSION_KEY = 9;
        public const int SECPKG_ATTR_PACKAGE_INFO = 10;
        public const int SECPKG_ATTR_USER_FLAGS = 11;
        public const int SECPKG_ATTR_NEGOTIATION_INFO = 12;
        public const int SECPKG_ATTR_NATIVE_NAMES = 13;
        public const int SECPKG_ATTR_FLAGS = 14;
        // These attributes exist only in Win XP and greater
        public const int SECPKG_ATTR_USE_VALIDATED = 15;
        public const int SECPKG_ATTR_CREDENTIAL_NAME = 16;
        public const int SECPKG_ATTR_TARGET_INFORMATION = 17;
        public const int SECPKG_ATTR_ACCESS_TOKEN = 18;
        // These attributes exist only in Win2K3 and greater
        public const int SECPKG_ATTR_TARGET = 19;
        public const int SECPKG_ATTR_AUTHENTICATION_ID = 20;
        // These attributes exist only in Win2K3SP1 and greater
        public const int SECPKG_ATTR_LOGOFF_TIME = 21;
        //
        // win7 or greater
        //
        public const int SECPKG_ATTR_NEGO_KEYS = 22;
        public const int SECPKG_ATTR_PROMPTING_NEEDED = 24;
        public const int SECPKG_ATTR_UNIQUE_BINDINGS = 25;
        public const int SECPKG_ATTR_ENDPOINT_BINDINGS = 26;
        public const int SECPKG_ATTR_CLIENT_SPECIFIED_TARGET = 27;

        public const int SECPKG_ATTR_LAST_CLIENT_TOKEN_STATUS = 30;
        public const int SECPKG_ATTR_NEGO_PKG_INFO = 31; // contains nego info of packages
        public const int SECPKG_ATTR_NEGO_STATUS = 32; // contains the last error
        public const int SECPKG_ATTR_CONTEXT_DELETED = 33; // a context has been deleted

        //
        // win8 or greater
        //
        public const int SECPKG_ATTR_DTLS_MTU = 34;
        public const int SECPKG_ATTR_DATAGRAM_SIZES = SECPKG_ATTR_STREAM_SIZES;

        public const int SECPKG_ATTR_SUBJECT_SECURITY_ATTRIBUTES = 128;

        //
        // win8.1 or greater
        //
        public const int SECPKG_ATTR_APPLICATION_PROTOCOL = 35;

        //
        // win10 or greater
        //
        public const int SECPKG_ATTR_NEGOTIATED_TLS_EXTENSIONS = 36;
        public const int SECPKG_ATTR_IS_LOOPBACK = 37;  // indicates authentication to localhost

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 757
        public const int SECPKG_ATTR_NEGO_INFO_FLAG_NO_KERBEROS = 0x1;
        public const int SECPKG_ATTR_NEGO_INFO_FLAG_NO_NTLM = 0x2;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1021
        public const int SECPKG_NEGOTIATION_COMPLETE = 0;
        public const int SECPKG_NEGOTIATION_OPTIMISTIC = 1;
        public const int SECPKG_NEGOTIATION_IN_PROGRESS = 2;
        public const int SECPKG_NEGOTIATION_DIRECT = 3;
        public const int SECPKG_NEGOTIATION_TRY_MULTICRED = 4;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1121
        public const byte MAX_PROTOCOL_ID_SIZE = 0xff;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1157
        //
        // Flags for ExportSecurityContext
        //

        public const int SECPKG_CONTEXT_EXPORT_RESET_NEW = 0x00000001;      // New context is reset to initial state
        public const int SECPKG_CONTEXT_EXPORT_DELETE_OLD = 0x00000002;     // Old context is deleted during export
        // This is only valid in W2K3SP1 and greater
        public const int SECPKG_CONTEXT_EXPORT_TO_KERNEL = 0x00000004;      // Context is to be transferred to the kernel
    }
}
