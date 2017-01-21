using System;

namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// The <see cref="POLICY_INFORMATION_CLASS"/> enumeration defines values that indicate the type of information to set or query in a <strong><a href="https://msdn.microsoft.com/en-us/library/ms721912.aspx">Policy</a></strong> object.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms721905.aspx">POLICY_INFORMATION_CLASS enumeration</a></para>
    /// </remarks>
    /// <seealso cref="LsaQueryInformationPolicy"/>
    /// <seealso cref="LsaSetInformationPolicy"/>
    /// <seealso cref="POLICY_ACCOUNT_DOMAIN_INFO"/>
    /// <seealso cref="POLICY_AUDIT_EVENTS_INFO"/>
    /// <seealso cref="POLICY_DNS_DOMAIN_INFO"/>
    /// <seealso cref="POLICY_LSA_SERVER_ROLE_INFO"/>
    /// <seealso cref="POLICY_MODIFICATION_INFO"/>
    /// <seealso cref="POLICY_PRIMARY_DOMAIN_INFO"/>
    public enum POLICY_INFORMATION_CLASS
    {
        /// <summary>This value is obsolete.</summary>
        [Obsolete("This value is obsolete.")]
        PolicyAuditLogInformation = 1,
        /// <summary>
        /// Query or set the auditing rules of the system. You can enable or disable auditing and specify the types of events that are audited. Use the <see cref="POLICY_AUDIT_EVENTS_INFO"/> structure.
        /// </summary>
        PolicyAuditEventsInformation,
        /// <summary>This value is obsolete. Use the <see cref="PolicyDnsDomainInformation"/> value instead.</summary>
        [Obsolete("This value is obsolete. Use the PolicyDnsDomainInformation value instead.")]
        PolicyPrimaryDomainInformation,
        /// <summary>This value is obsolete.</summary>
        [Obsolete("This value is obsolete.")]
        PolicyPdAccountInformation,
        /// <summary>
        /// Query or set the name and SID of the account domain of the system. Use the <see cref="POLICY_ACCOUNT_DOMAIN_INFO"/> structure.
        /// </summary>
        PolicyAccountDomainInformation,
        /// <summary>
        /// Query or set the role of an LSA server. Use the <see cref="POLICY_LSA_SERVER_ROLE_INFO"/> structure.
        /// </summary>
        PolicyLsaServerRoleInformation,
        /// <summary>This value is obsolete.</summary>
        [Obsolete("This value is obsolete.")]
        PolicyReplicaSourceInformation,
        /// <summary>This value is obsolete.</summary>
        [Obsolete("This value is obsolete.")]
        PolicyDefaultQuotaInformation,
        /// <summary>
        /// Query or set information about the creation time and last modification of the LSA database. Use the <see cref="POLICY_MODIFICATION_INFO"/> structure.
        /// </summary>
        PolicyModificationInformation,
        /// <summary>This value is obsolete.</summary>
        [Obsolete("This value is obsolete.")]
        PolicyAuditFullSetInformation,
        /// <summary>This value is obsolete.</summary>
        [Obsolete("This value is obsolete.")]
        PolicyAuditFullQueryInformation,
        /// <summary>
        /// Query or set Domain Name System (DNS) information about the account domain associated with a Policy object. Use the <see cref="POLICY_DNS_DOMAIN_INFO"/> structure. 
        /// </summary>
        PolicyDnsDomainInformation
    }
}
