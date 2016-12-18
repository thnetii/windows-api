using System;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The Auditing Constants represent categories and subcategories of audit-policy events.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/bb648638.aspx">Auditing Constants</a></para>
    /// </remarks>
    public static class AuditingConstants
    {
        /// <summary>Audit attempts to shut down or restart the computer. Also, audit events that affect system security or the security log.</summary>
        public static readonly Guid Audit_System = new Guid("69979848-797a-11d9-bed3-505054503030");
        /// <summary>Audit attempts to log on to or log off of the system. Also, audit attempts to make a network connection.</summary>
        public static readonly Guid Audit_Logon = new Guid("69979849-797a-11d9-bed3-505054503030");
        /// <summary>Audit attempts to access securable objects.</summary>
        public static readonly Guid Audit_ObjectAccess = new Guid("6997984a-797a-11d9-bed3-505054503030");
        /// <summary>Audit attempts to use <em><a href="https://msdn.microsoft.com/en-us/library/ms721603.aspx#_security_privilege_gly">privileges</a></em>.</summary>
        public static readonly Guid Audit_PrivilegeUse = new Guid("6997984b-797a-11d9-bed3-505054503030");
        /// <summary>Audit-specific events, such as program activation, some forms of handle duplication, indirect access to an object, and process exit.</summary>
        public static readonly Guid Audit_DetailedTracking = new Guid("6997984c-797a-11d9-bed3-505054503030");
        /// <summary>Audit attempts to change Policy object rules.</summary>
        public static readonly Guid Audit_PolicyChange = new Guid("6997984d-797a-11d9-bed3-505054503030");
        /// <summary>Audit attempts to create, delete, or change user or group accounts. Also, audit password changes.</summary>
        public static readonly Guid Audit_AccountManagement = new Guid("6997984e-797a-11d9-bed3-505054503030");
        /// <summary>Audit attempts to access the directory service.</summary>
        public static readonly Guid Audit_DirectoryServiceAccess = new Guid("6997984f-797a-11d9-bed3-505054503030");
        /// <summary>Audit logon attempts by privileged accounts that log on to the domain controller. These audit events are generated when the <em><a href="https://msdn.microsoft.com/en-us/library/ms721590.aspx#_security_key_distribution_center_gly">Kerberos Key Distribution Center</a></em> (KDC) logs on to the domain controller.</summary>
        public static readonly Guid Audit_AccountLogon = new Guid("69979850-797a-11d9-bed3-505054503030");

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly Guid Audit_System_SecurityStateChange = new Guid("0cce9210-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_System_SecuritySubsystemExtension = new Guid("0cce9211-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_System_Integrity = new Guid("0cce9212-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_System_IPSecDriverEvents = new Guid("0cce9213-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_System_Others = new Guid("0cce9214-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Logon_Logon = new Guid("0cce9215-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Logon_Logoff = new Guid("0cce9216-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Logon_AccountLockout = new Guid("0cce9217-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Logon_IPSecMainMode = new Guid("0cce9218-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Logon_IPSecQuickMode = new Guid("0cce9219-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Logon_IPSecUserMode = new Guid("0cce921a-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Logon_SpecialLogon = new Guid("0cce921b-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Logon_Others = new Guid("0cce921c-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_FileSystem = new Guid("0cce921d-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_Registry = new Guid("0cce921e-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_Kernel = new Guid("0cce921f-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_Sam = new Guid("0cce9220-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_CertificationServices = new Guid("0cce9221-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_ApplicationGenerated = new Guid("0cce9222-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_Handle = new Guid("0cce9223-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_Share = new Guid("0cce9224-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_FirewallPacketDrops = new Guid("0cce9225-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_FirewallConnection = new Guid("0cce9226-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_ObjectAccess_Other = new Guid("0cce9227-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_PrivilegeUse_Sensitive = new Guid("0cce9228-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_PrivilegeUse_NonSensitive = new Guid("0cce9229-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_PrivilegeUse_Others = new Guid("0cce922a-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_DetailedTracking_ProcessCreation = new Guid("0cce922b-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_DetailedTracking_ProcessTermination = new Guid("0cce922c-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_DetailedTracking_DpapiActivity = new Guid("0cce922d-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_DetailedTracking_RpcCall = new Guid("0cce922e-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_PolicyChange_AuditPolicy = new Guid("0cce922f-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_PolicyChange_AuthenticationPolicy = new Guid("0cce9230-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_PolicyChange_AuthorizationPolicy = new Guid("0cce9231-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_PolicyChange_MpsscvRulePolicy = new Guid("0cce9232-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_PolicyChange_WfpIPSecPolicy = new Guid("0cce9233-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_PolicyChange_Others = new Guid("0cce9234-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_AccountManagement_UserAccount = new Guid("0cce9235-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_AccountManagement_ComputerAccount = new Guid("0cce9236-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_AccountManagement_SecurityGroup = new Guid("0cce9237-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_AccountManagement_DistributionGroup = new Guid("0cce9238-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_AccountManagement_ApplicationGroup = new Guid("0cce9239-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_AccountManagement_Others = new Guid("0cce923a-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_DSAccess_DSAccess = new Guid("0cce923b-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_DsAccess_AdAuditChanges = new Guid("0cce923c-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Ds_Replication = new Guid("0cce923d-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Ds_DetailedReplication = new Guid("0cce923e-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_AccountLogon_CredentialValidation = new Guid("0cce923f-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_AccountLogon_Kerberos = new Guid("0cce9240-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_AccountLogon_Others = new Guid("0cce9241-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_AccountLogon_KerbCredentialValidation = new Guid("0cce9242-69ae-11d9-bed3-505054503030");
        public static readonly Guid Audit_Logon_NPS = new Guid("0cce9243-69ae-11d9-bed3-505054503030");
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
