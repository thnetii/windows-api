using System;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Special Values and Constants - User
    /// </summary>
    [Flags]
    public enum USER_FLAGS : int
    {
        //
        //  Bit masks for field usriX_flags of USER_INFO_X (X = 0/1).
        //

        /// <summary>The logon script executed. This value must be set.</summary>
        UF_SCRIPT = 0x0001,
        /// <summary>The user's account is disabled.</summary>
        UF_ACCOUNTDISABLE = 0x0002,
        UF_HOMEDIR_REQUIRED = 0x0008,
        /// <summary>
        /// The account is currently locked out (blocked). For the <see cref="NetUserSetInfo"/> function, this value can be cleared to unlock a previously locked account. This value cannot be used to lock a previously unlocked account.
        /// </summary>
        UF_LOCKOUT = 0x0010,
        /// <summary>No password is required.</summary>
        UF_PASSWD_NOTREQD = 0x0020,
        /// <summary>The user cannot change the password.</summary>
        UF_PASSWD_CANT_CHANGE = 0x0040,
        /// <summary>The user's password is stored under reversible encryption in the Active Directory.</summary>
        UF_ENCRYPTED_TEXT_PASSWORD_ALLOWED = 0x0080,

        //
        // Account type bits as part of usri_flags.
        //

        /// <summary>
        /// An account for users whose primary account is in another domain. This account provides user access to this domain, but not to any domain that trusts this domain. The User Manager refers to this account type as a local user account.
        /// </summary>
        UF_TEMP_DUPLICATE_ACCOUNT = 0x0100,
        /// <summary>A default account type that represents a typical user.</summary>
        UF_NORMAL_ACCOUNT = 0x0200,
        /// <summary>A permit to trust account for a domain that trusts other domains.</summary>
        UF_INTERDOMAIN_TRUST_ACCOUNT = 0x0800,
        /// <summary>A computer account for a workstation or a server that is a member of this domain.</summary>
        UF_WORKSTATION_TRUST_ACCOUNT = 0x1000,
        /// <summary>A computer account for a backup domain controller that is a member of this domain.</summary>
        UF_SERVER_TRUST_ACCOUNT = 0x2000,

        UF_MACHINE_ACCOUNT_MASK = (UF_INTERDOMAIN_TRUST_ACCOUNT | UF_WORKSTATION_TRUST_ACCOUNT | UF_SERVER_TRUST_ACCOUNT),

        UF_ACCOUNT_TYPE_MASK = (UF_TEMP_DUPLICATE_ACCOUNT | UF_NORMAL_ACCOUNT | UF_INTERDOMAIN_TRUST_ACCOUNT | UF_WORKSTATION_TRUST_ACCOUNT | UF_SERVER_TRUST_ACCOUNT),

        /// <summary>Represents the password, which will never expire on the account.</summary>
        UF_DONT_EXPIRE_PASSWD = 0x10000,
        UF_MNS_LOGON_ACCOUNT = 0x20000,
        /// <summary>
        /// Requires the user to log on to the user account with a smart card.
        /// </summary>
        UF_SMARTCARD_REQUIRED = 0x40000,
        /// <summary>
        /// The account is enabled for delegation. This is a security-sensitive setting; accounts with this option enabled should be tightly controlled. This setting allows a service running under the account to assume a client's identity and authenticate as that user to other remote servers on the network.
        /// </summary>
        UF_TRUSTED_FOR_DELEGATION = 0x80000,
        /// <summary>
        /// Marks the account as "sensitive"; other users cannot act as delegates of this user account.
        /// </summary>
        UF_NOT_DELEGATED = 0x100000,
        /// <summary>
        /// Restrict this principal to use only Data Encryption Standard (DES) encryption types for keys.
        /// </summary>
        UF_USE_DES_KEY_ONLY = 0x200000,
        /// <summary>
        /// This account does not require Kerberos preauthentication for logon.
        /// </summary>
        UF_DONT_REQUIRE_PREAUTH = 0x400000,
        /// <summary>
        /// The user's password has expired.
        /// <para><strong>Windows 2000:</strong> This value is not supported.</para>
        /// </summary>
        UF_PASSWORD_EXPIRED = 0x800000,
        /// <summary>
        /// The account is trusted to authenticate a user outside of the Kerberos security package and delegate that user through constrained delegation. This is a security-sensitive setting; accounts with this option enabled should be tightly controlled. This setting allows a service running under the account to assert a client's identity and authenticate as that user to specifically configured services on the network.
        /// <para><strong>Windows XP/2000:</strong> This value is not supported.</para>
        /// </summary>
        UF_TRUSTED_TO_AUTHENTICATE_FOR_DELEGATION = 0x1000000,
        UF_NO_AUTH_DATA_REQUIRED = 0x2000000,
        UF_PARTIAL_SECRETS_ACCOUNT = 0x4000000,
        UF_USE_AES_KEYS = 0x8000000,

        UF_SETTABLE_BITS = (UF_SCRIPT | UF_ACCOUNTDISABLE | UF_LOCKOUT | UF_HOMEDIR_REQUIRED | UF_PASSWD_NOTREQD | UF_PASSWD_CANT_CHANGE | UF_ACCOUNT_TYPE_MASK | UF_DONT_EXPIRE_PASSWD | UF_MNS_LOGON_ACCOUNT | UF_ENCRYPTED_TEXT_PASSWORD_ALLOWED | UF_SMARTCARD_REQUIRED | UF_TRUSTED_FOR_DELEGATION | UF_NOT_DELEGATED | UF_USE_DES_KEY_ONLY | UF_DONT_REQUIRE_PREAUTH | UF_PASSWORD_EXPIRED | UF_TRUSTED_TO_AUTHENTICATE_FOR_DELEGATION | UF_NO_AUTH_DATA_REQUIRED | UF_USE_AES_KEYS | UF_PARTIAL_SECRETS_ACCOUNT),

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
