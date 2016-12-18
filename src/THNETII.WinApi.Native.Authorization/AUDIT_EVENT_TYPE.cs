namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="AUDIT_EVENT_TYPE"/> enumeration type defines values that indicate the type of object being audited. The <see cref="AccessCheckByTypeAndAuditAlarm"/> and <see cref="AccessCheckByTypeResultListAndAuditAlarm"/> functions use these values.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375718.aspx">AUDIT_EVENT_TYPE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="AccessCheckByTypeAndAuditAlarm"/>
    /// <seealso cref="AccessCheckByTypeResultListAndAuditAlarm"/>
    public enum AUDIT_EVENT_TYPE
    {
        /// <summary>
        /// Indicates an object that generates audit messages only if the system administrator has enabled auditing access to files and objects.
        /// </summary>
        AuditEventObjectAccess,
        /// <summary>
        /// Indicates a directory service object that generates audit messages only if the system administrator has enabled auditing access to directory service objects.
        /// </summary>
        AuditEventDirectoryServiceAccess
    }
}
