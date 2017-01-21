namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// The <see cref="POLICY_AUDIT_EVENT_TYPE"/> enumeration defines values that indicate the types of events the system can audit. The <see cref="LsaQueryInformationPolicy"/> and <see cref="LsaSetInformationPolicy"/> functions use this enumeration when their <em>InformationClass</em> parameters are set to <see cref="PolicyAuditEventsInformation"/>.
    /// </summary>
    /// <remarks>
    /// The <see cref="POLICY_AUDIT_EVENT_TYPE"/> enumeration may expand in future versions of Windows. Because of this, you should not compute the number of values in this enumeration directly. Instead, you should obtain the count of values by calling <see cref="LsaQueryInformationPolicy"/> with the <em>InformationClass</em> parameter set to <see cref="PolicyAuditEventsInformation"/> and extract the count from the <see cref="POLICY_AUDIT_EVENTS_INFO.MaximumAuditEventCount"/> member of the returned <see cref="POLICY_AUDIT_EVENTS_INFO"/> structure.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms721903.aspx">POLICY_AUDIT_EVENT_TYPE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="LsaQueryInformationPolicy"/>
    /// <seealso cref="LsaSetInformationPolicy"/>
    /// <seealso cref="POLICY_INFORMATION_CLASS"/>
    public enum POLICY_AUDIT_EVENT_TYPE
    {
        /// <summary>
        /// Determines whether the operating system must audit any of the following attempts:
        /// <list type="bullet">
        /// <item>Attempted system time change.</item> 
        /// <item>Attempted security system startup, restart, or shutdown.</item> 
        /// <item>Attempt to load extensible authentication features.</item> 
        /// <item>Loss of audited events due to auditing system failure.</item> 
        /// <item>Security log size that exceeds a configurable warning threshold level.</item>
        /// </list>
        /// </summary>
        AuditCategorySystem,
        /// <summary>
        /// Determines whether the operating system must audit each time this computer validates the credentials of an account. Account logon events are generated whenever a computer validates the credentials of one of its local accounts. The credential validation can be in support of a local logon or, in the case of an Active Directory domain account on a domain controller, can be in support of a logon to another computer. Audited events for local accounts must be logged on the local security log of the computer. Account logoff does not generate an event that can be audited.
        /// </summary>
        AuditCategoryLogon,
        /// <summary>
        /// Determines whether the operating system must audit each instance of user attempts to access a non-Active Directory object, such as a file, that has its own system access control list (SACL) specified. The type of access request, such as Write, Read, or Modify, and the account that is making the request must match the settings in the SACL.
        /// </summary>
        AuditCategoryObjectAccess,
        /// <summary>
        /// Determines whether the operating system must audit each instance of user attempts to use <em><a href="https://msdn.microsoft.com/en-us/library/ms721603.aspx#_security_privilege_gly">privileges</a></em>.
        /// </summary>
        AuditCategoryPrivilegeUse,
        /// <summary>
        /// Determines whether the operating system must audit specific events, such as program activation, some forms of handle duplication, indirect access to an object, and process exit.
        /// </summary>
        AuditCategoryDetailedTracking,
        /// <summary>
        /// Determines whether the operating system must audit attempts to change <strong><a href="https://msdn.microsoft.com/en-us/library/ms722460.aspx">Policy</a></strong> object rules, such as user rights assignment policy, audit policy, account policy, or trust policy.
        /// </summary>
        AuditCategoryPolicyChange,
        /// <summary>
        /// Determines whether the operating system must audit attempts to create, delete, or change user or group accounts. Also, audit password changes.
        /// </summary>
        AuditCategoryAccountManagement,
        /// <summary>
        /// Determines whether the operating system must audit attempts to access the directory service. The Active Directory object has its own SACL specified. The type of access request, such as Write, Read, or Modify, and the account that is making the request must match the settings in the SACL.
        /// </summary>
        AuditCategoryDirectoryServiceAccess,
        /// <summary>
        /// Determines whether the operating system must audit each instance of a user attempt to log on or log off this computer. Also audits logon attempts by privileged accounts that log on to the domain controller. These audit events are generated when the <em><a href="https://msdn.microsoft.com/en-us/library/ms721590.aspx#_security_key_distribution_center_gly"></a></em>Kerberos Key Distribution Center (KDC) logs on to the domain controller. Logoff attempts are generated whenever the logon session of a logged-on user account is terminated.
        /// </summary>
        AuditCategoryAccountLogon
    }
}
