using System;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Flags to determine the behavior of the join/unjoin APIs
    /// </summary>
    [Flags]
    public enum NETSETUP_OPTIONS : int
    {
        /// <summary>If not present, workgroup is joined</summary>
        NETSETUP_JOIN_DOMAIN = 0x00000001,
        /// <summary>Do the server side account creation/rename</summary>
        NETSETUP_ACCT_CREATE = 0x00000002,
        /// <summary>Delete the account when a domain is left</summary>
        NETSETUP_ACCT_DELETE = 0x00000004,
        /// <summary>
        /// Invoked during upgrade of Windows 9x to
        /// Windows NT
        /// </summary>
        NETSETUP_WIN9X_UPGRADE = 0x00000010,
        /// <summary>
        /// Allow the client to join a new domain
        /// even if it is already joined to a domain
        /// </summary>
        NETSETUP_DOMAIN_JOIN_IF_JOINED = 0x00000020,
        /// <summary>Performs an unsecure join</summary>
        NETSETUP_JOIN_UNSECURE = 0x00000040,
        /// <summary>Indicates that the machine (not user) password is passed. Valid only for unsecure joins</summary>
        NETSETUP_MACHINE_PWD_PASSED = 0x00000080,
        /// <summary>Specifies that writting SPN and DnsHostName attributes on the computer object should be defered until rename that will follow join</summary>
        NETSETUP_DEFER_SPN_SET = 0x00000100,

        /// <summary>Allow join if existing account is a DC</summary>
        NETSETUP_JOIN_DC_ACCOUNT = 0x00000200,
        /// <summary>Check for computer name change</summary>
        NETSETUP_JOIN_WITH_NEW_NAME = 0x00000400,
        /// <summary>Perform join using a pre-created account w/o requiring a writable DC</summary>
        NETSETUP_JOIN_READONLY = 0x00000800,
        /// <summary>When performing machine rename only update DNS based names</summary>
        NETSETUP_DNS_NAME_CHANGES_ONLY = 0x00001000,

        /// <summary>The APIs were invoked during install</summary>
        NETSETUP_INSTALL_INVOCATION = 0x00040000,

        /// <summary>When joining the domain don't try to set the preferred DC in the registry.</summary>
        NETSETUP_AMBIGUOUS_DC = 0x00001000,
        /// <summary>Don't create the netlogon cache</summary>
        NETSETUP_NO_NETLOGON_CACHE = 0x00002000,
        /// <summary>Don't force netlogon to start</summary>
        NETSETUP_DONT_CONTROL_SERVICES = 0x00004000,
        /// <summary>For offline join only, set target machine hostname and NB name.</summary>
        NETSETUP_SET_MACHINE_NAME = 0x00008000,
        /// <summary>Override other settings during domain join and attempt to set the SPN.</summary>
        NETSETUP_FORCE_SPN_SET = 0x00010000,
        /// <summary>Do not reuse an existing account</summary>
        NETSETUP_NO_ACCT_REUSE = 0x00020000,
        /// <summary>do not use OEM code page to derive the netbios\samAccountName</summary>
        NETSETUP_ALT_SAMACCOUNTNAME = 0x00020000,

        /// <summary>If this bit is set, unrecognized flags will be ignored by the NetJoin API and the API will behave as if the flags were not set.</summary>
        NETSETUP_IGNORE_UNSUPPORTED_FLAGS = 0x10000000,

        NETSETUP_VALID_UNJOIN_FLAGS = (NETSETUP_ACCT_DELETE | NETSETUP_IGNORE_UNSUPPORTED_FLAGS | NETSETUP_JOIN_DC_ACCOUNT),

        /// <summary>
        /// The following flags are used when the system is processing information left from a prior offline
        /// join.  We want to force DC discovery and we don't want to create the netlogon cache.  We also
        /// don't want to immediately force netlogon to start, let it start on its own.
        /// </summary>
        NETSETUP_PROCESS_OFFLINE_FLAGS = (NETSETUP_JOIN_DOMAIN | NETSETUP_DOMAIN_JOIN_IF_JOINED | NETSETUP_JOIN_WITH_NEW_NAME | NETSETUP_DONT_CONTROL_SERVICES | NETSETUP_MACHINE_PWD_PASSED),

        //
        // 0x80000000 is reserved for internal use only
        //
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}