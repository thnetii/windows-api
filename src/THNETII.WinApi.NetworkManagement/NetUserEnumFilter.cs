using Microsoft.Win32.WinApi.Networking.NetworkManagement;
using System;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.FILTER_ACCOUNT_FLAGS;

namespace THNETII.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Filtering options for NetUser enumeration.
    /// </summary>
    [Flags]
    public enum NetUserEnumFilter : int
    {
        /// <summary>
        /// Enumerates all normal user, trust data, and machine account data.
        /// </summary>
        NoFilter = 0,
        /// <summary>Enumerates account data for users whose primary account is in another domain. This account type provides user access to this domain, but not to any domain that trusts this domain. The User Manager refers to this account type as a local user account.</summary>
        TemporaryDuplicateAccount = FILTER_TEMP_DUPLICATE_ACCOUNT,
        /// <summary>Enumerates normal user account data. This account type is associated with a typical user.</summary>
        NormalAccount = FILTER_NORMAL_ACCOUNT,
        /// <summary>Enumerates interdomain trust account data. This account type is associated with a trust account for a domain that trusts other domains.</summary>
        InterdomainTrustAccount = FILTER_INTERDOMAIN_TRUST_ACCOUNT,
        /// <summary>Enumerates workstation or member server trust account data. This account type is associated with a machine account for a computer that is a member of the domain.</summary>
        WorkstationTrustAccount = FILTER_WORKSTATION_TRUST_ACCOUNT,
        /// <summary>Enumerates member server machine account data. This account type is associated with a computer account for a backup domain controller that is a member of the domain.</summary>
        ServerTrustAccount = FILTER_SERVER_TRUST_ACCOUNT
    }

    internal static class NetUserEnumFilterExtensions
    {
        public static FILTER_ACCOUNT_FLAGS AsNative(this NetUserEnumFilter value) => (FILTER_ACCOUNT_FLAGS)value;
        public static NetUserEnumFilter AsManaged(this FILTER_ACCOUNT_FLAGS value) => (NetUserEnumFilter)value;
    }
}
