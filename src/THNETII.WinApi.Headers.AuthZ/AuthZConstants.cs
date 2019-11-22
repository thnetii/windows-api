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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 510
        public const ushort AUTHZ_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1 = 1;

        public const ushort AUTHZ_SECURITY_ATTRIBUTES_INFORMATION_VERSION = AUTHZ_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1;
    }
}
