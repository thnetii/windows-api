namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// The <see cref="POLICY_NOTIFICATION_INFORMATION_CLASS"/> enumeration defines the types of policy information and policy domain information for which your application can request notification of changes.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms721909.aspx">POLICY_NOTIFICATION_INFORMATION_CLASS enumeration</a></para>
    /// </remarks>
    /// <seealso cref="LsaRegisterPolicyChangeNotification"/>
    /// <seealso cref="LsaUnregisterPolicyChangeNotification"/>
    public enum POLICY_NOTIFICATION_INFORMATION_CLASS
    {
        /// <summary>Notify when any of the audited categories are changed.</summary>
        PolicyNotifyAuditEventsInformation = 1,
        /// <summary>Notify when the account domain information changes.</summary>
        PolicyNotifyAccountDomainInformation,
        /// <summary>Notify when the LSA server changes its role from primary to backup, or vice versa.</summary>
        PolicyNotifyServerRoleInformation,
        /// <summary>Notify when the DNS domain information changes or if the primary domain information changes.</summary>
        PolicyNotifyDnsDomainInformation,
        /// <summary>Notify when the Encrypting File System (EFS) domain information changes.</summary>
        PolicyNotifyDomainEfsInformation,
        /// <summary>Notify when the Kerberos ticket for the domain changes.</summary>
        PolicyNotifyDomainKerberosTicketInformation,
        /// <summary>Notify when the machine account password changes.</summary>
        PolicyNotifyMachineAccountPasswordInformation
    }
}
