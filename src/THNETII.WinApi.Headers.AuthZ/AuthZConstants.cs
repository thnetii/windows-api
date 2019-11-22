namespace THNETII.WinApi.Native.AuthZ
{
    public static class AuthZConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 53
        //
        // Flags which may be used at the time of client context creation using a sid.
        //

        public const int AUTHZ_SKIP_TOKEN_GROUPS = 0x2;
        public const int AUTHZ_REQUIRE_S4U_LOGON = 0x4;
        public const int AUTHZ_COMPUTE_PRIVILEGES = 0x8;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 147
        public const int AUTHZ_GENERATE_SUCCESS_AUDIT = 0x1;
        public const int AUTHZ_GENERATE_FAILURE_AUDIT = 0x2;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 275
        //
        //  Security attribute data types ...
        //

        public const int AUTHZ_SECURITY_ATTRIBUTE_TYPE_INVALID = 0x00;

        public const int AUTHZ_SECURITY_ATTRIBUTE_TYPE_INT64 = 0x01;
        public const int AUTHZ_SECURITY_ATTRIBUTE_TYPE_UINT64 = 0x02;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 281
        //
        //  Case insensitive attribute value string by default.
        //  Unless the flag AUTHZ_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE
        //  is set indicating otherwise.
        //

        public const int AUTHZ_SECURITY_ATTRIBUTE_TYPE_STRING = 0x03;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 301
        public const int AUTHZ_SECURITY_ATTRIBUTE_TYPE_FQBN = 0x04;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 304
        public const int AUTHZ_SECURITY_ATTRIBUTE_TYPE_SID = 0x05;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 306
        public const int AUTHZ_SECURITY_ATTRIBUTE_TYPE_BOOLEAN = 0x06;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 324
        public const int AUTHZ_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING = 0x10;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 510
        public const ushort AUTHZ_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1 = 1;

        public const ushort AUTHZ_SECURITY_ATTRIBUTES_INFORMATION_VERSION = AUTHZ_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1;
    }
}
