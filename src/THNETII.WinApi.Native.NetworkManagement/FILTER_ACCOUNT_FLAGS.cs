using System;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// bit masks for the <see cref="NetUserEnum"/> <var>filter</var> parameter.
    /// </summary>
    [Flags]
    public enum FILTER_ACCOUNT_FLAGS : int
    {
        /// <summary>Enumerates account data for users whose primary account is in another domain. This account type provides user access to this domain, but not to any domain that trusts this domain. The User Manager refers to this account type as a local user account.</summary>
        FILTER_TEMP_DUPLICATE_ACCOUNT = (0x0001),
        /// <summary>Enumerates normal user account data. This account type is associated with a typical user.</summary>
        FILTER_NORMAL_ACCOUNT = (0x0002),
        // FILTER_PROXY_ACCOUNT = (0x0004),
        /// <summary>Enumerates interdomain trust account data. This account type is associated with a trust account for a domain that trusts other domains.</summary>
        FILTER_INTERDOMAIN_TRUST_ACCOUNT = (0x0008),
        /// <summary>Enumerates workstation or member server trust account data. This account type is associated with a machine account for a computer that is a member of the domain.</summary>
        FILTER_WORKSTATION_TRUST_ACCOUNT = (0x0010),
        /// <summary>Enumerates member server machine account data. This account type is associated with a computer account for a backup domain controller that is a member of the domain.</summary>
        FILTER_SERVER_TRUST_ACCOUNT = (0x0020),
    }
}