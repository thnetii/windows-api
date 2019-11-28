namespace THNETII.WinApi.Native.WinCrypt
{
    public static class WinCryptConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 144
        //
        // Algorithm IDs and Flags
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 153
        // Algorithm classes
        // certenrolld_begin -- ALG_CLASS_*
        public const int ALG_CLASS_ANY = 0;
        public const int ALG_CLASS_SIGNATURE = 1 << 13;
        public const int ALG_CLASS_MSG_ENCRYPT = 2 << 13;
        public const int ALG_CLASS_DATA_ENCRYPT = 3 << 13;
        public const int ALG_CLASS_HASH = 4 << 13;
        public const int ALG_CLASS_KEY_EXCHANGE = 5 << 13;
        public const int ALG_CLASS_ALL = 7 << 13;
        // certenrolld_end

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 164
        // Algorithm types
        public const int ALG_TYPE_ANY = 0;
        public const int ALG_TYPE_DSS = 1 << 9;
        public const int ALG_TYPE_RSA = 2 << 9;
        public const int ALG_TYPE_BLOCK = 3 << 9;
        public const int ALG_TYPE_STREAM = 4 << 9;
        public const int ALG_TYPE_DH = 5 << 9;
        public const int ALG_TYPE_SECURECHANNEL = 6 << 9;
        public const int ALG_TYPE_ECDH = 7 << 9;
        public const int ALG_TYPE_THIRDPARTY = 8 << 9;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 179
        // Generic sub-ids
        public const int ALG_SID_ANY = 0;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 182
        // Generic ThirdParty sub-ids
        public const int ALG_SID_THIRDPARTY_ANY = 0;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 187
        // Some RSA sub-ids
        public const int ALG_SID_RSA_ANY = 0;
        public const int ALG_SID_RSA_PKCS = 1;
        public const int ALG_SID_RSA_MSATWORK = 2;
        public const int ALG_SID_RSA_ENTRUST = 3;
        public const int ALG_SID_RSA_PGP = 4;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 194
        // Some DSS sub-ids
        //
        public const int ALG_SID_DSS_ANY = 0;
        public const int ALG_SID_DSS_PKCS = 1;
        public const int ALG_SID_DSS_DMS = 2;
        public const int ALG_SID_ECDSA = 3;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 203
        // Block cipher sub ids
        // DES sub_ids
        public const int ALG_SID_DES = 1;
        public const int ALG_SID_3DES = 3;
        public const int ALG_SID_DESX = 4;
        public const int ALG_SID_IDEA = 5;
        public const int ALG_SID_CAST = 6;
        public const int ALG_SID_SAFERSK64 = 7;
        public const int ALG_SID_SAFERSK128 = 8;
        public const int ALG_SID_3DES_112 = 9;
        public const int ALG_SID_CYLINK_MEK = 12;
        public const int ALG_SID_RC5 = 13;
        public const int ALG_SID_AES_128 = 14;
        public const int ALG_SID_AES_192 = 15;
        public const int ALG_SID_AES_256 = 16;
        public const int ALG_SID_AES = 17;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 222
        // Fortezza sub-ids
        public const int ALG_SID_SKIPJACK = 10;
        public const int ALG_SID_TEK = 11;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 226
        // KP_MODE
        public const int CRYPT_MODE_CBCI = 6;// ANSI CBC Interleaved
        public const int CRYPT_MODE_CFBP = 7;// ANSI CFB Pipelined
        public const int CRYPT_MODE_OFBP = 8;// ANSI OFB Pipelined
        public const int CRYPT_MODE_CBCOFM = 9;// ANSI CBC + OF Masking
        public const int CRYPT_MODE_CBCOFMI = 10;// ANSI CBC + OFM Interleaved

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 233
        // RC2 sub-ids
        public const int ALG_SID_RC2 = 2;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 236
        // Stream cipher sub-ids
        public const int ALG_SID_RC4 = 1;
        public const int ALG_SID_SEAL = 2;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 240
        // Diffie-Hellman sub-ids
        public const int ALG_SID_DH_SANDF = 1;
        public const int ALG_SID_DH_EPHEM = 2;
        public const int ALG_SID_AGREED_KEY_ANY = 3;
        public const int ALG_SID_KEA = 4;
        public const int ALG_SID_ECDH = 5;
        public const int ALG_SID_ECDH_EPHEM = 6;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 250
        // Hash sub ids
        public const int ALG_SID_MD2 = 1;
        public const int ALG_SID_MD4 = 2;
        public const int ALG_SID_MD5 = 3;
        public const int ALG_SID_SHA = 4;
        public const int ALG_SID_SHA1 = 4;
        public const int ALG_SID_MAC = 5;
        public const int ALG_SID_RIPEMD = 6;
        public const int ALG_SID_RIPEMD160 = 7;
        public const int ALG_SID_SSL3SHAMD5 = 8;
        public const int ALG_SID_HMAC = 9;
        public const int ALG_SID_TLS1PRF = 10;
        public const int ALG_SID_HASH_REPLACE_OWF = 11;
        public const int ALG_SID_SHA_256 = 12;
        public const int ALG_SID_SHA_384 = 13;
        public const int ALG_SID_SHA_512 = 14;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 271
        // secure channel sub ids
        public const int ALG_SID_SSL3_MASTER = 1;
        public const int ALG_SID_SCHANNEL_MASTER_HASH = 2;
        public const int ALG_SID_SCHANNEL_MAC_KEY = 3;
        public const int ALG_SID_PCT1_MASTER = 4;
        public const int ALG_SID_SSL2_MASTER = 5;
        public const int ALG_SID_TLS1_MASTER = 6;
        public const int ALG_SID_SCHANNEL_ENC_KEY = 7;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 281
        // misc ECC sub ids
        public const int ALG_SID_ECMQV = 1;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 285
        // Our silly example sub-id
        public const int ALG_SID_EXAMPLE = 80;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\wincrypt.h, line 295
        // algorithm identifier definitions
        public const int CALG_MD2 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD2;
        public const int CALG_MD4 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD4;
        public const int CALG_MD5 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD5;
        public const int CALG_SHA = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA;
        public const int CALG_SHA1 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA1;
        public const int CALG_MAC = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MAC;// Deprecated. Don't use.
        public const int CALG_RSA_SIGN = ALG_CLASS_SIGNATURE | ALG_TYPE_RSA | ALG_SID_RSA_ANY;
        public const int CALG_DSS_SIGN = ALG_CLASS_SIGNATURE | ALG_TYPE_DSS | ALG_SID_DSS_ANY;
        public const int CALG_NO_SIGN = ALG_CLASS_SIGNATURE | ALG_TYPE_ANY | ALG_SID_ANY;
        public const int CALG_RSA_KEYX = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_RSA | ALG_SID_RSA_ANY;
        public const int CALG_DES = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_DES;
        public const int CALG_3DES_112 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_3DES_112;
        public const int CALG_3DES = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_3DES;
        public const int CALG_DESX = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_DESX;
        public const int CALG_RC2 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_RC2;
        public const int CALG_RC4 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_STREAM | ALG_SID_RC4;
        public const int CALG_SEAL = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_STREAM | ALG_SID_SEAL;
        public const int CALG_DH_SF = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_DH_SANDF;
        public const int CALG_DH_EPHEM = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_DH_EPHEM;
        public const int CALG_AGREEDKEY_ANY = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_AGREED_KEY_ANY;
        public const int CALG_KEA_KEYX = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_KEA;
        public const int CALG_HUGHES_MD5 = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_ANY | ALG_SID_MD5;
        public const int CALG_SKIPJACK = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_SKIPJACK;
        public const int CALG_TEK = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_TEK;
        public const int CALG_CYLINK_MEK = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_CYLINK_MEK;// Deprecated. Do not use
        public const int CALG_SSL3_SHAMD5 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SSL3SHAMD5;
        public const int CALG_SSL3_MASTER = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_SSL3_MASTER;
        public const int CALG_SCHANNEL_MASTER_HASH = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_SCHANNEL_MASTER_HASH;
        public const int CALG_SCHANNEL_MAC_KEY = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_SCHANNEL_MAC_KEY;
        public const int CALG_SCHANNEL_ENC_KEY = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_SCHANNEL_ENC_KEY;
        public const int CALG_PCT1_MASTER = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_PCT1_MASTER;
        public const int CALG_SSL2_MASTER = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_SSL2_MASTER;
        public const int CALG_TLS1_MASTER = ALG_CLASS_MSG_ENCRYPT | ALG_TYPE_SECURECHANNEL | ALG_SID_TLS1_MASTER;
        public const int CALG_RC5 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_RC5;
        public const int CALG_HMAC = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_HMAC;
        public const int CALG_TLS1PRF = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_TLS1PRF;
        public const int CALG_HASH_REPLACE_OWF = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_HASH_REPLACE_OWF;
        public const int CALG_AES_128 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_AES_128;
        public const int CALG_AES_192 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_AES_192;
        public const int CALG_AES_256 = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_AES_256;
        public const int CALG_AES = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_AES;
        public const int CALG_SHA_256 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_256;
        public const int CALG_SHA_384 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_384;
        public const int CALG_SHA_512 = ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_512;
        public const int CALG_ECDH = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_ECDH;
        public const int CALG_ECDH_EPHEM = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_ECDH | ALG_SID_ECDH_EPHEM;
        public const int CALG_ECMQV = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_ANY | ALG_SID_ECMQV;
        public const int CALG_ECDSA = ALG_CLASS_SIGNATURE | ALG_TYPE_DSS | ALG_SID_ECDSA;
        public const int CALG_NULLCIPHER = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_ANY | 0;
        public const int CALG_THIRDPARTY_KEY_EXCHANGE = ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY;
        public const int CALG_THIRDPARTY_SIGNATURE = ALG_CLASS_SIGNATURE | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY;
        public const int CALG_THIRDPARTY_CIPHER = ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY;
        public const int CALG_THIRDPARTY_HASH = ALG_CLASS_HASH | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY;
    }
}
