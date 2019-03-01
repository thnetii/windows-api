namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10292
    /// <summary>
    /// The <see cref="AUDIT_EVENT_TYPE"/> enumeration type defines values that indicate the type of object being audited. The <see cref="AccessCheckByTypeAndAuditAlarm"/> and <see cref="AccessCheckByTypeResultListAndAuditAlarm"/> functions use these values.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ne-winnt-audit_event_type">AUDIT_EVENT_TYPE Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="AccessCheckByTypeAndAuditAlarm"/>
    /// <seealso cref="AccessCheckByTypeResultListAndAuditAlarm"/>
    /// <seealso href="https://msdn.microsoft.com/e2f22838-102e-432c-9c82-06a3e0741374">Authorization Enumerations</seealso>
    /// <seealso href="https://msdn.microsoft.com/8301ed4f-9458-410b-af19-4f055656005a">Client/Server Access Control Overview</seealso>
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
