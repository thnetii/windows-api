﻿using System;

namespace THNETII.WinApi.Native.Sspi
{
    public static class SspiConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 146
        //
        // pseudo handle value: the handle has already been deleted
        //

        public static readonly UIntPtr SEC_DELETED_HANDLE =
            new UIntPtr(unchecked((uint)-2));

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
                                                                                // if the following checks succeed
                                                                                // 1. Caller has domain auth capability or
                                                                                // 2. Target is a proxy server or
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
    }
}