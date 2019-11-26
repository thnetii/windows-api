namespace THNETII.WinApi.Native.MinSchannel
{
    public static class MinSchannelConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minschannel.h, line 31
        //
        // Constants 
        //

        //
        // QueryContextAttributes/QueryCredentialsAttribute extensions
        //

        public const int SECPKG_ATTR_ISSUER_LIST = 0x50;   // (OBSOLETE) returns SecPkgContext_IssuerListInfo
        public const int SECPKG_ATTR_REMOTE_CRED = 0x51;   // (OBSOLETE) returns SecPkgContext_RemoteCredentialInfo
        public const int SECPKG_ATTR_LOCAL_CRED = 0x52;   // (OBSOLETE) returns SecPkgContext_LocalCredentialInfo
        public const int SECPKG_ATTR_REMOTE_CERT_CONTEXT = 0x53;   // returns PCCERT_CONTEXT
        public const int SECPKG_ATTR_LOCAL_CERT_CONTEXT = 0x54;   // returns PCCERT_CONTEXT
        public const int SECPKG_ATTR_ROOT_STORE = 0x55;   // returns HCERTCONTEXT to the root store
        public const int SECPKG_ATTR_SUPPORTED_ALGS = 0x56;   // returns SecPkgCred_SupportedAlgs
        public const int SECPKG_ATTR_CIPHER_STRENGTHS = 0x57;   // returns SecPkgCred_CipherStrengths
        public const int SECPKG_ATTR_SUPPORTED_PROTOCOLS = 0x58;   // returns SecPkgCred_SupportedProtocols
        public const int SECPKG_ATTR_ISSUER_LIST_EX = 0x59;   // returns SecPkgContext_IssuerListInfoEx
        public const int SECPKG_ATTR_CONNECTION_INFO = 0x5a;   // returns SecPkgContext_ConnectionInfo
        public const int SECPKG_ATTR_EAP_KEY_BLOCK = 0x5b;   // returns SecPkgContext_EapKeyBlock
        public const int SECPKG_ATTR_MAPPED_CRED_ATTR = 0x5c;   // returns SecPkgContext_MappedCredAttr
        public const int SECPKG_ATTR_SESSION_INFO = 0x5d;   // returns SecPkgContext_SessionInfo
        public const int SECPKG_ATTR_APP_DATA = 0x5e;   // sets/returns SecPkgContext_SessionAppData
        public const int SECPKG_ATTR_REMOTE_CERTIFICATES = 0x5F;   // returns SecPkgContext_Certificates
        public const int SECPKG_ATTR_CLIENT_CERT_POLICY = 0x60;   // sets    SecPkgCred_ClientCertCtlPolicy
        public const int SECPKG_ATTR_CC_POLICY_RESULT = 0x61;   // returns SecPkgContext_ClientCertPolicyResult
        public const int SECPKG_ATTR_USE_NCRYPT = 0x62;   // Sets the CRED_FLAG_USE_NCRYPT_PROVIDER FLAG on cred group
        public const int SECPKG_ATTR_LOCAL_CERT_INFO = 0x63;   // returns SecPkgContext_CertInfo
        public const int SECPKG_ATTR_CIPHER_INFO = 0x64;   // returns new CNG SecPkgContext_CipherInfo
        public const int SECPKG_ATTR_EAP_PRF_INFO = 0x65;   // sets    SecPkgContext_EapPrfInfo
        public const int SECPKG_ATTR_SUPPORTED_SIGNATURES = 0x66;   // returns SecPkgContext_SupportedSignatures
        public const int SECPKG_ATTR_REMOTE_CERT_CHAIN = 0x67;   // returns PCCERT_CONTEXT
        public const int SECPKG_ATTR_UI_INFO = 0x68;   // sets SEcPkgContext_UiInfo
        public const int SECPKG_ATTR_EARLY_START = 0x69;   // sets SecPkgContext_EarlyStart
        public const int SECPKG_ATTR_KEYING_MATERIAL_INFO = 0x6a;   // sets SecPkgContext_KeyingMaterialInfo
        public const int SECPKG_ATTR_KEYING_MATERIAL = 0x6b;   // returns SecPkgContext_KeyingMaterial
        public const int SECPKG_ATTR_SRTP_PARAMETERS = 0x6c;   // returns negotiated SRTP parameters
        public const int SECPKG_ATTR_TOKEN_BINDING = 0x6d;   // returns SecPkgContext_TokenBinding
        public const int SECPKG_ATTR_CONNECTION_INFO_EX = 0x6e;   // returns SecPkgContext_ConnectionInfoEx
        public const int SECPKG_ATTR_KEYING_MATERIAL_TOKEN_BINDING = 0x6f; // returns SecPkgContext_KeyingMaterial specific to Token Binding
    }
}
