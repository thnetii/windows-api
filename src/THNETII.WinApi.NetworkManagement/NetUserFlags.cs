using Microsoft.Win32.WinApi.Networking.NetworkManagement;
using System;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.USER_FLAGS;

namespace THNETII.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// User Flags
    /// </summary>
    [Flags]
    public enum NetUserFlags : int
    {
        /// <summary>The logon script executed. This value must be set.</summary>
        Script = UF_SCRIPT,
        /// <summary>The user's account is disabled.</summary>
        AccountDisable = UF_ACCOUNTDISABLE,
        HomeDirRequested = UF_HOMEDIR_REQUIRED,
        /// <summary>
        /// The account is currently locked out (blocked). This value can be cleared to unlock a previously locked account. This value cannot be used to lock a previously unlocked account.
        /// </summary>
        Lockout = UF_LOCKOUT,
        /// <summary>No password is required.</summary>
        PasswordNotRequired = UF_PASSWD_NOTREQD,
        /// <summary>The user cannot change the password.</summary>
        PasswordCannotChange = UF_PASSWD_CANT_CHANGE,
        /// <summary>The user's password is stored under reversible encryption in the Active Directory.</summary>
        ReversibleEncryptedPasswordAllowed = UF_ENCRYPTED_TEXT_PASSWORD_ALLOWED,

        //
        // Account type bits as part of usri_flags.
        //

        /// <summary>
        /// An account for users whose primary account is in another domain. This account provides user access to this domain, but not to any domain that trusts this domain. The User Manager refers to this account type as a local user account.
        /// </summary>
        TemporaryDuplicateAccount = UF_TEMP_DUPLICATE_ACCOUNT,
        /// <summary>A default account type that represents a typical user.</summary>
        NormalAccount = UF_NORMAL_ACCOUNT,
        /// <summary>A permit to trust account for a domain that trusts other domains.</summary>
        InterdomainTrustAccount = UF_INTERDOMAIN_TRUST_ACCOUNT,
        /// <summary>A computer account for a workstation or a server that is a member of this domain.</summary>
        WorkstationTrustAccount = UF_WORKSTATION_TRUST_ACCOUNT,
        /// <summary>A computer account for a backup domain controller that is a member of this domain.</summary>
        ServerTrustAccount = UF_SERVER_TRUST_ACCOUNT,

        MachineAccountMask = UF_MACHINE_ACCOUNT_MASK,

        AccountTypeMask = UF_ACCOUNT_TYPE_MASK,

        /// <summary>Represents the password, which will never expire on the account.</summary>
        PasswordDoesNotExpire = UF_DONT_EXPIRE_PASSWD,
        MnsLogonAccount = UF_MNS_LOGON_ACCOUNT,
        /// <summary>
        /// Requires the user to log on to the user account with a smart card.
        /// </summary>
        SmartcardRequired = UF_SMARTCARD_REQUIRED,
        /// <summary>
        /// The account is enabled for delegation. This is a security-sensitive setting; accounts with this option enabled should be tightly controlled. This setting allows a service running under the account to assume a client's identity and authenticate as that user to other remote servers on the network.
        /// </summary>
        TrustedForDelegation = UF_TRUSTED_FOR_DELEGATION,
        /// <summary>
        /// Marks the account as "sensitive"; other users cannot act as delegates of this user account.
        /// </summary>
        NotDelegated = UF_NOT_DELEGATED,
        /// <summary>
        /// Restrict this principal to use only Data Encryption Standard (DES) encryption types for keys.
        /// </summary>
        UseDesKeyOnly = UF_USE_DES_KEY_ONLY,
        /// <summary>
        /// This account does not require Kerberos preauthentication for logon.
        /// </summary>
        DoNotRequirePreAuth = UF_DONT_REQUIRE_PREAUTH,
        /// <summary>
        /// The user's password has expired.
        /// <para><strong>Windows 2000:</strong> This value is not supported.</para>
        /// </summary>
        PasswordExpired = UF_PASSWORD_EXPIRED,
        /// <summary>
        /// The account is trusted to authenticate a user outside of the Kerberos security package and delegate that user through constrained delegation. This is a security-sensitive setting; accounts with this option enabled should be tightly controlled. This setting allows a service running under the account to assert a client's identity and authenticate as that user to specifically configured services on the network.
        /// <para><strong>Windows XP/2000:</strong> This value is not supported.</para>
        /// </summary>
        TruestedToAuthenticateForDelegation = UF_TRUSTED_TO_AUTHENTICATE_FOR_DELEGATION,
        NoAuthDataRequired = UF_NO_AUTH_DATA_REQUIRED,
        PartialSecretsAccount = UF_PARTIAL_SECRETS_ACCOUNT,
        UseAesKeys = UF_USE_AES_KEYS,

        SettableBits = UF_SETTABLE_BITS,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    internal static class NetUserFlagsExtensions
    {
        public static NetUserFlags AsManaged(this USER_FLAGS value) => (NetUserFlags)value;
        public static USER_FLAGS AsNative(this NetUserFlags value) => (USER_FLAGS)value;
    }
}