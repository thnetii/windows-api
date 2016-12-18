namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="AUDIT_PARAM_TYPE"/> enumeration defines the type of audit parameters that are available.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/hh448450.aspx">AUDIT_PARAM_TYPE enumeration</a></para>
    /// </remarks>
    public enum AUDIT_PARAM_TYPE
    {
        /// <summary>No audit options.</summary>
        APT_None = 1,
        /// <summary>A string that terminates with null-terminating character.</summary>
        APT_String,
        /// <summary>An unsigned long.</summary>
        APT_Ulong,
        /// <summary>A pointer that is used to specify handles and pointers. These are 32-bit on 32-bit systems and 64-bit on 64-bit systems. Use this option when you are interested in the absolute value of the pointer. The memory to which the pointer points is not marshaled when using this type.</summary>
        APT_Pointer,
        /// <summary>The <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_identifier_gly">security identifier</a></em> (SID).</summary>
        APT_Sid,
        /// <summary>
        /// The logon identifier (LUID) that results in three output parameters:
        /// <list type="bullet">
        /// <item>Account name, </item>
        /// <item>Authority name, </item>
        /// <item>LogonID.</item>
        /// </list>
        /// </summary>
        APT_LogonId,
        /// <summary>Object type list.</summary>
        APT_ObjectTypeList,
        /// <summary>LUID that is not translated to LogonId.</summary>
        APT_Luid,
        /// <summary>GUID.</summary>
        APT_Guid,
        /// <summary>Time as FILETIME.</summary>
        APT_Time,
        /// <summary>ULONGLONG.</summary>
        APT_Int64,
        /// <summary>IP Address (IPv4 and IPv6). This logs the address as the first parameter and the port as the second parameter. You must ensure that two entries are added in the event message file. You should ensure that the buffer size is 128 bytes.</summary>
        APT_IpAddress,
        /// <summary>
        /// Logon ID with SID that results in four output parameters:
        /// <list type="bullet">
        /// <item>SID, </item>
        /// <item>Account name, </item>
        /// <item>Authority name, </item>
        /// <item>LogonID.</item>
        /// </list>
        /// </summary>
        APT_LogonIdWithSid
    }
}
