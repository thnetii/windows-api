using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.Sspi;

namespace THNETII.WinApi.Native.CredSSP
{
    using static SspiConstants;

    public static class CredSSPConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\credssp.h, line 27
        public const string CREDSSP_NAME = "CREDSSP";
        public static readonly LPCSTR TS_SSP_NAME_A =
            Pointer.Create<LPCSTR>(Marshal.StringToCoTaskMemAnsi("TSSSP"));
        public const string TS_SSP_NAME = "TSSSP";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\credssp.h, line 31
        public const string szOID_TS_KP_TS_SERVER_AUTH = "1.3.6.1.4.1.311.54.1.2";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\credssp.h, line 39
        public const int CREDSSP_SERVER_AUTH_NEGOTIATE = 0x1;
        public const int CREDSSP_SERVER_AUTH_CERTIFICATE = 0x2;
        public const int CREDSSP_SERVER_AUTH_LOOPBACK = 0x4;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\credssp.h, line 43
        public const int SECPKG_ALT_ATTR = unchecked((int)0x80000000);
        public const int SECPKG_ATTR_CREDS = unchecked((int)0x80000080);
        public const int SECPKG_ATTR_NEGOTIATION_PACKAGE = unchecked((int)0x80000081);
        public const int SECPKG_ATTR_C_ACCESS_TOKEN = (SECPKG_ATTR_ACCESS_TOKEN | SECPKG_ALT_ATTR);
        public const int SECPKG_ATTR_C_FULL_ACCESS_TOKEN = unchecked((int)0x80000082);
        public const int SECPKG_ATTR_SERVER_AUTH_FLAGS = unchecked((int)0x80000083);
        public const int SECPKG_ATTR_CERT_TRUST_STATUS = unchecked((int)0x80000084);
        public const int SECPKG_ATTR_C_FULL_IDENT_TOKEN = unchecked((int)0x80000085);
        public const int SECPKG_ATTR_CREDS_2 = unchecked((int)0x80000086);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\credssp.h, line 69
        public const int CREDSSP_CRED_EX_VERSION = 0;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\credssp.h, line 83
        public const int CREDSSP_FLAG_REDIRECT = 0x00000001;
    }
}
