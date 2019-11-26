using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinCrypt
{
    using static ALG_CLASS;
    using static ALG_TYPE;

    /// <summary>
    /// The ALG_ID data type specifies an algorithm identifier. Parameters of this data type are passed to most of the functions in CryptoAPI.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/alg-id">ALG_ID</a></para>
    /// </remarks>
    /// <seealso href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/cryptography-functions">Cryptography Functions</seealso>
    /// <seealso cref="CRYPT_ALGORITHM_IDENTIFIER"/>
    /// <seealso cref="CryptFindOIDInfo"/>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + "(), nq}")]
    [StructLayout(LayoutKind.Sequential)]
    public struct ALG_ID : IEquatable<ALG_ID>, IEquatable<int>
    {
        private static readonly ALG_CLASS[] known_classes =
            (ALG_CLASS[])Enum.GetValues(typeof(ALG_CLASS));
        private static readonly ALG_TYPE[] known_types =
            (ALG_TYPE[])Enum.GetValues(typeof(ALG_TYPE));

        private static readonly Bitfield32 classbitfield = Bitfield32.FromMask(7 << 13);
        private static readonly Bitfield32 typebitfield = Bitfield32.FromMask(15 << 9);
        private static readonly Bitfield32 sidbitfield = Bitfield32.FromMask(511);

        private readonly int value;

        public ALG_ID(int alg_id) : this() => value = alg_id;
        public ALG_ID(ALG_CLASS @class, ALG_TYPE type, int sid) : this()
        {
            classbitfield.WriteMasked(ref value, (int)@class);
            typebitfield.WriteMasked(ref value, (int)type);
            sidbitfield.WriteMasked(ref value, sid);
        }

        public int Value => value;

        public ALG_CLASS Class => (ALG_CLASS)classbitfield.ReadMasked(value);
        public ALG_TYPE Type => (ALG_TYPE)typebitfield.ReadMasked(value);
        public int SubId => sidbitfield.ReadMasked(value);

        public bool Equals(ALG_ID other) => Equals(other.value);
        public bool Equals(int other) => value.Equals(other);
        public override bool Equals(object obj) => obj switch
        {
            int other_value => Equals(other_value),
            ALG_ID other_id => Equals(other_id),
            _ => false,
        };

        public override int GetHashCode() => value.GetHashCode();
        public static bool operator ==(ALG_ID left, ALG_ID right) =>
            left.Equals(right);
        public static bool operator !=(ALG_ID left, ALG_ID right) =>
            !(left == right);
        public static bool operator ==(ALG_ID left, int right) =>
            left.Equals(right);
        public static bool operator !=(ALG_ID left, int right) =>
            !(left == right);
        public static bool operator ==(int left, ALG_ID right) =>
            right.Equals(left);
        public static bool operator !=(int left, ALG_ID right) =>
            !(left == right);

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = "Constructor")]
        public static implicit operator ALG_ID(int alg_id) => new ALG_ID(alg_id);
        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(Value))]
        public static explicit operator int(ALG_ID alg_id) => alg_id.value;

        public void Deconstruct(out ALG_CLASS @class, out ALG_TYPE type,
            out int sid) => (@class, type, sid) = (Class, Type, SubId);

        internal string DebuggerDisplay()
        {
            var (@class, type, sid) = this;

            string class_string = known_classes.Contains(@class)
                ? @class.ToString()
                : $"({((uint)@class) >> 13} << 13)";
            string type_string = known_types.Contains(type)
                ? type.ToString()
                : $"({((uint)type) >> 9} << 9)";

            string sid_string =
                @class switch
                {
                    ALG_CLASS_HASH => GetEnumToStringOrNull<ALG_SID_HASH>(sid),
                    _ => null,
                }
                ?? type switch
                {
                    ALG_TYPE_ANY => GetEnumToStringOrNull<ALG_SID_ANY>(sid),
                    ALG_TYPE_THIRDPARTY => GetEnumToStringOrNull<ALG_SID_THIRDPARTY>(sid),
                    ALG_TYPE_RSA => GetEnumToStringOrNull<ALG_SID_RSA>(sid),
                    ALG_TYPE_DSS => GetEnumToStringOrNull<ALG_SID_DSS>(sid),
                    ALG_TYPE_BLOCK => GetEnumToStringOrNull<ALG_SID_BLOCK>(sid),
                    ALG_TYPE_STREAM => GetEnumToStringOrNull<ALG_SID_STREAM>(sid),
                    ALG_TYPE_DH => GetEnumToStringOrNull<ALG_SID_DH>(sid),
                    ALG_TYPE_SECURECHANNEL => GetEnumToStringOrNull<ALG_SID_SCHANNEL>(sid),
                    _ => null
                }
                ?? sid.ToString(CultureInfo.InvariantCulture);

            return $"{class_string} | {type_string} | {sid_string}";

            static string GetEnumToStringOrNull<TEnum>(int sid)
                where TEnum : unmanaged, Enum
            {
                var @enum = default(TEnum);
                unsafe
                {
                    TEnum* pEnumValue = &@enum;
                    int* pEnumInt = (int*)pEnumValue;
                    *pEnumInt = sid;
                }
                return ((TEnum[])Enum.GetValues(typeof(TEnum))).Contains(@enum)
                    ? @enum.ToString()
                    : null;
            }
        }

        // algorithm identifier definitions
        /// <summary>
        /// MD2 hashing algorithm. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-base-cryptographic-provider">Microsoft Base Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_MD2 { get; } = WinCryptConstants.CALG_MD2;
        /// <summary>
        /// MD4 hashing algorithm.
        /// </summary>
        public static ALG_ID CALG_MD4 { get; } = WinCryptConstants.CALG_MD4;
        /// <summary>
        /// MD5 hashing algorithm. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-base-cryptographic-provider">Microsoft Base Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_MD5 { get; } = WinCryptConstants.CALG_MD5;
        /// <summary>
        /// SHA hashing algorithm. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-base-cryptographic-provider">Microsoft Base Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_SHA { get; } = WinCryptConstants.CALG_SHA;
        /// <inheritdoc cref="CALG_SHA"/>
        public static ALG_ID CALG_SHA1 { get; } = WinCryptConstants.CALG_SHA1;
        /// <summary>
        /// <a href="https://docs.microsoft.com/windows/desktop/SecGloss/m-gly">MAC</a> keyed hash algorithm. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-base-cryptographic-provider">Microsoft Base Cryptographic Provider</a>.
        /// </summary>
        [Obsolete("Deprecated. Don't use.")]
        public static ALG_ID CALG_MAC { get; } = WinCryptConstants.CALG_MAC;
        /// <summary>
        /// RSA public key signature algorithm. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-base-cryptographic-provider">Microsoft Base Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_RSA_SIGN { get; } = WinCryptConstants.CALG_RSA_SIGN;
        /// <summary>
        /// DSA <a href="https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">public key</a> signature algorithm.
        /// </summary>
        public static ALG_ID CALG_DSS_SIGN { get; } = WinCryptConstants.CALG_DSS_SIGN;
        /// <summary>
        /// No signature algorithm.
        /// </summary>
        public static ALG_ID CALG_NO_SIGN { get; } = WinCryptConstants.CALG_NO_SIGN;
        /// <summary>
        /// RSA public key exchange algorithm. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-base-cryptographic-provider">Microsoft Base Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_RSA_KEYX { get; } = WinCryptConstants.CALG_RSA_KEYX;
        /// <summary>
        /// DES encryption algorithm.
        /// </summary>
        public static ALG_ID CALG_DES { get; } = WinCryptConstants.CALG_DES;
        /// <summary>
        /// Two-key <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">triple DES</a> encryption with effective key length equal to 112 bits.
        /// </summary>
        public static ALG_ID CALG_3DES_112 { get; } = WinCryptConstants.CALG_3DES_112;
        /// <summary>
        /// <a href="https://docs.microsoft.com/windows/desktop/SecGloss/t-gly">Triple DES</a> encryption algorithm.
        /// </summary>
        public static ALG_ID CALG_3DES { get; } = WinCryptConstants.CALG_3DES;
        /// <summary>
        /// DESX encryption algorithm.
        /// </summary>
        public static ALG_ID CALG_DESX { get; } = WinCryptConstants.CALG_DESX;
        /// <summary>
        /// RC2 block encryption algorithm. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-base-cryptographic-provider">Microsoft Base Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_RC2 { get; } = WinCryptConstants.CALG_RC2;
        /// <summary>
        /// RC4 stream encryption algorithm. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-base-cryptographic-provider">Microsoft Base Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_RC4 { get; } = WinCryptConstants.CALG_RC4;
        /// <summary>
        /// SEAL encryption algorithm. This algorithm is not supported.
        /// </summary>
        public static ALG_ID CALG_SEAL { get; } = WinCryptConstants.CALG_SEAL;
        /// <summary>
        /// Diffie-Hellman store and forward key exchange algorithm.
        /// </summary>
        public static ALG_ID CALG_DH_SF { get; } = WinCryptConstants.CALG_DH_SF;
        /// <summary>
        /// Diffie-Hellman ephemeral key exchange algorithm.
        /// </summary>
        public static ALG_ID CALG_DH_EPHEM { get; } = WinCryptConstants.CALG_DH_EPHEM;
        /// <summary>
        /// Temporary algorithm identifier for handles of Diffie-Hellman–agreed keys.
        /// </summary>
        public static ALG_ID CALG_AGREEDKEY_ANY { get; } = WinCryptConstants.CALG_AGREEDKEY_ANY;
        /// <summary>
        /// KEA key exchange algorithm (FORTEZZA). This algorithm is not supported.
        /// </summary>
        public static ALG_ID CALG_KEA_KEYX { get; } = WinCryptConstants.CALG_KEA_KEYX;
        /// <summary>
        /// Hughes MD5 hashing algorithm.
        /// </summary>
        public static ALG_ID CALG_HUGHES_MD5 { get; } = WinCryptConstants.CALG_HUGHES_MD5;
        /// <summary>
        /// Skipjack block encryption algorithm (FORTEZZA). This algorithm is not supported.
        /// </summary>
        public static ALG_ID CALG_SKIPJACK { get; } = WinCryptConstants.CALG_SKIPJACK;
        /// <summary>
        /// TEK (FORTEZZA). This algorithm is not supported.
        /// </summary>
        public static ALG_ID CALG_TEK { get; } = WinCryptConstants.CALG_TEK;
        /// <summary>
        /// An algorithm to create a 40-bit DES key that has parity bits and zeroed key bits to make its key length 64 bits. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-base-cryptographic-provider">Microsoft Base Cryptographic Provider</a>.
        /// </summary>
        [Obsolete("Deprecated. Do not use")]
        public static ALG_ID CALG_CYLINK_MEK { get; } = WinCryptConstants.CALG_CYLINK_MEK;
        /// <summary>
        /// Used by the Schannel.dll operations system. This <see cref="ALG_ID"/> should not be used by applications.
        /// </summary>
        public static ALG_ID CALG_SSL3_SHAMD5 { get; } = WinCryptConstants.CALG_SSL3_SHAMD5;
        /// <summary>
        /// Used by the Schannel.dll operations system. This <see cref="ALG_ID"/> should not be used by applications.
        /// </summary>
        public static ALG_ID CALG_SSL3_MASTER { get; } = WinCryptConstants.CALG_SSL3_MASTER;
        /// <summary>
        /// Used by the Schannel.dll operations system. This <see cref="ALG_ID"/> should not be used by applications.
        /// </summary>
        public static ALG_ID CALG_SCHANNEL_MASTER_HASH { get; } = WinCryptConstants.CALG_SCHANNEL_MASTER_HASH;
        /// <summary>
        /// Used by the Schannel.dll operations system. This <see cref="ALG_ID"/> should not be used by applications.
        /// </summary>
        public static ALG_ID CALG_SCHANNEL_MAC_KEY { get; } = WinCryptConstants.CALG_SCHANNEL_MAC_KEY;
        /// <summary>
        /// Used by the Schannel.dll operations system. This <see cref="ALG_ID"/> should not be used by applications.
        /// </summary>
        public static ALG_ID CALG_SCHANNEL_ENC_KEY { get; } = WinCryptConstants.CALG_SCHANNEL_ENC_KEY;
        /// <summary>
        /// Used by the Schannel.dll operations system. This <see cref="ALG_ID"/> should not be used by applications.
        /// </summary>
        public static ALG_ID CALG_PCT1_MASTER { get; } = WinCryptConstants.CALG_PCT1_MASTER;
        /// <summary>
        /// Used by the Schannel.dll operations system. This <see cref="ALG_ID"/> should not be used by applications.
        /// </summary>
        public static ALG_ID CALG_SSL2_MASTER { get; } = WinCryptConstants.CALG_SSL2_MASTER;
        /// <summary>
        /// Used by the Schannel.dll operations system. This <see cref="ALG_ID"/> should not be used by applications.
        /// </summary>
        public static ALG_ID CALG_TLS1_MASTER { get; } = WinCryptConstants.CALG_TLS1_MASTER;
        /// <summary>
        /// RC5 block encryption algorithm.
        /// </summary>
        public static ALG_ID CALG_RC5 { get; } = WinCryptConstants.CALG_RC5;
        /// <summary>
        /// HMAC keyed hash algorithm. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-base-cryptographic-provider">Microsoft Base Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_HMAC { get; } = WinCryptConstants.CALG_HMAC;
        /// <summary>
        /// Used by the Schannel.dll operations system. This <see cref="ALG_ID"/> should not be used by applications.
        /// </summary>
        public static ALG_ID CALG_TLS1PRF { get; } = WinCryptConstants.CALG_TLS1PRF;
        /// <summary>
        /// One way function hashing algorithm.
        /// </summary>
        public static ALG_ID CALG_HASH_REPLACE_OWF { get; } = WinCryptConstants.CALG_HASH_REPLACE_OWF;
        /// <summary>
        /// 128 bit AES. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-aes-cryptographic-provider">Microsoft AES Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_AES_128 { get; } = WinCryptConstants.CALG_AES_128;
        /// <summary>
        /// 192 bit AES. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-aes-cryptographic-provider">Microsoft AES Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_AES_192 { get; } = WinCryptConstants.CALG_AES_192;
        /// <summary>
        /// 256 bit AES. This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-aes-cryptographic-provider">Microsoft AES Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_AES_256 { get; } = WinCryptConstants.CALG_AES_256;
        /// <summary>
        /// Advanced Encryption Standard (AES). This algorithm is supported by the <a href="https://docs.microsoft.com/en-us/windows/win32/seccrypto/microsoft-aes-cryptographic-provider">Microsoft AES Cryptographic Provider</a>.
        /// </summary>
        public static ALG_ID CALG_AES { get; } = WinCryptConstants.CALG_AES;
        /// <summary>
        /// 256 bit SHA hashing algorithm. This algorithm is supported by Microsoft Enhanced RSA and AES Cryptographic Provider.
        /// <para><strong>Windows XP with SP3:</strong> This algorithm is supported by the Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype).</para>
        /// <para><strong>Windows XP with SP2, Windows XP with SP1 and Windows XP:</strong> This algorithm is not supported.</para>
        /// </summary>
        public static ALG_ID CALG_SHA_256 { get; } = WinCryptConstants.CALG_SHA_256;
        /// <summary>
        /// 384 bit SHA hashing algorithm. This algorithm is supported by Microsoft Enhanced RSA and AES Cryptographic Provider.
        /// <para><strong>Windows XP with SP3:</strong> This algorithm is supported by the Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype).</para>
        /// <para><strong>Windows XP with SP2, Windows XP with SP1 and Windows XP:</strong> This algorithm is not supported.</para>
        /// </summary>
        public static ALG_ID CALG_SHA_384 { get; } = WinCryptConstants.CALG_SHA_384;
        /// <summary>
        /// 512 bit SHA hashing algorithm. This algorithm is supported by Microsoft Enhanced RSA and AES Cryptographic Provider.
        /// <para><strong>Windows XP with SP3:</strong> This algorithm is supported by the Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype).</para>
        /// <para><strong>Windows XP with SP2, Windows XP with SP1 and Windows XP:</strong> This algorithm is not supported.</para>
        /// </summary>
        public static ALG_ID CALG_SHA_512 { get; } = WinCryptConstants.CALG_SHA_512;
        /// <summary>
        /// Elliptic curve Diffie-Hellman key exchange algorithm.
        /// <para><note> This algorithm is supported only through <a href="https://docs.microsoft.com/windows/desktop/SecCNG/cng-portal">Cryptography API: Next Generation</a>. </note></para>
        /// <para><strong>Windows Server 2003 and Windows XP:</strong> This algorithm is not supported.</para>
        /// </summary>
        public static ALG_ID CALG_ECDH { get; } = WinCryptConstants.CALG_ECDH;
        /// <summary>
        /// Ephemeral elliptic curve Diffie-Hellman key exchange algorithm. 
        /// <para><note> This algorithm is supported only through <a href="https://docs.microsoft.com/windows/desktop/SecCNG/cng-portal">Cryptography API: Next Generation</a>. </note></para>
        /// <para><strong>Windows Server 2003 and Windows XP:</strong> This algorithm is not supported.</para>
        /// </summary>
        public static ALG_ID CALG_ECDH_EPHEM { get; } = WinCryptConstants.CALG_ECDH_EPHEM;
        /// <summary>
        /// Elliptic curve Menezes, Qu, and Vanstone (MQV) key exchange algorithm. This algorithm is not supported.
        /// </summary>
        public static ALG_ID CALG_ECMQV { get; } = WinCryptConstants.CALG_ECMQV;
        /// <summary>
        /// Elliptic curve digital signature algorithm.
        /// <para><note> This algorithm is supported only through <a href="https://docs.microsoft.com/windows/desktop/SecCNG/cng-portal">Cryptography API: Next Generation</a>. </note></para>
        /// <para><strong>Windows Server 2003 and Windows XP:</strong> This algorithm is not supported.</para>
        /// </summary>
        public static ALG_ID CALG_ECDSA { get; } = WinCryptConstants.CALG_ECDSA;
        public static ALG_ID CALG_NULLCIPHER { get; } = WinCryptConstants.CALG_NULLCIPHER;
        public static ALG_ID CALG_THIRDPARTY_KEY_EXCHANGE { get; } = WinCryptConstants.CALG_THIRDPARTY_KEY_EXCHANGE;
        public static ALG_ID CALG_THIRDPARTY_SIGNATURE { get; } = WinCryptConstants.CALG_THIRDPARTY_SIGNATURE;
        public static ALG_ID CALG_THIRDPARTY_CIPHER { get; } = WinCryptConstants.CALG_THIRDPARTY_CIPHER;
        public static ALG_ID CALG_THIRDPARTY_HASH { get; } = WinCryptConstants.CALG_THIRDPARTY_HASH;
    }
}
