using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="AUDIT_POLICY_INFORMATION"/> structure specifies a security event type and when to audit that type.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa965467.aspx">AUDIT_POLICY_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="AuditComputeEffectivePolicyBySid"/>
    /// <seealso cref="AuditComputeEffectivePolicyByToken"/>
    /// <seealso cref="AuditQueryPerUserPolicy"/>
    /// <seealso cref="AuditQuerySystemPolicy"/>
    /// <seealso cref="AuditSetPerUserPolicy"/>
    /// <seealso cref="AuditSetSystemPolicy"/>
    [StructLayout(LayoutKind.Sequential)]
    public class AUDIT_POLICY_INFORMATION
    {
        /// <summary>
        /// A <see cref="Guid"/> structure that specifies an audit subcategory.
        /// </summary>
        public Guid AuditSubCategoryGuid;
        /// <summary>
        /// A set of bit flags that specify the conditions under which the security event type specified by the AuditSubCategoryGuid and AuditCategoryGuid members are audited.
        /// <para><note type="important">Note that the meaning of these values differs depending on which function is using this structure.</note></para>
        /// </summary>
        public int AuditingInformation;
        /// <summary>
        /// A set of bit flags that specify the conditions under which the security event type specified by the AuditSubCategoryGuid and AuditCategoryGuid members are audited.
        /// <para><note type="important">Note that these values are only valid for System-level audits. For Per-User Audits, use the <see cref="PerUserAuditingInformation"/> member instead.</note></para>
        /// </summary>
        public AuditFlags SystemAuditingInformation
        {
            get { return (AuditFlags)AuditingInformation; }
            set { AuditingInformation = (int)value; }
        }
        /// <summary>
        /// A set of bit flags that specify the conditions under which the security event type specified by the AuditSubCategoryGuid and AuditCategoryGuid members are audited.
        /// <para><note type="important">Note that these values are only valid for Per-Users audits. For System Audits, use the <see cref="SystemAuditingInformation"/> member instead.</note></para>
        /// </summary>
        public PER_USER_AUDIT_FLAGS PerUserAuditingInformation
        {
            get { return (PER_USER_AUDIT_FLAGS)AuditingInformation; }
            set { AuditingInformation = (int)value; }
        }
        /// <summary>
        /// A <see cref="Guid"/> structure that specifies an audit-policy category.
        /// </summary>
        public Guid AuditCategoryGuid;
    }
}
