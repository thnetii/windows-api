using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10747
    /// <summary>
    /// The <see cref="TOKEN_PRIVILEGES"/> structure contains information about a set of privileges for an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access token</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_privileges">TOKEN_PRIVILEGES structure</a></para>
    /// </remarks>
    /// <seealso cref="AdjustTokenPrivileges"/>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="LUID"/>
    /// <seealso cref="LUID_AND_ATTRIBUTES"/>
    /// <seealso cref="LookupPrivilegeName"/>
    /// <seealso cref="PRIVILEGE_SET"/>
    /// <seealso cref="PrivilegeCheck"/>
    /// <seealso cref="PrivilegedServiceAuditAlarm"/>
    /// <seealso cref="SetTokenInformation"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_TYPE"/>
    /// <seealso cref="TOKEN_USER"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_PRIVILEGES
    {
        /// <summary>
        /// This must be set to the number of entries in the <see cref="Privileges"/> array.
        /// </summary>
        public int PrivilegeCount;
        internal LUID_AND_ATTRIBUTES Privilege;
        /// <summary>
        /// Specifies an array of <see cref="LUID_AND_ATTRIBUTES"/> structures. Each structure contains the <see cref="LUID"/> and attributes of a privilege. To get the name of the privilege associated with a <see cref="LUID"/>, call the <see cref="LookupPrivilegeName"/> function, passing the address of the <see cref="LUID"/> as the value of the <em>lpLuid</em> parameter.
        /// <para>The attributes of a privilege are defined by the <see cref="SE_PRIVILEGE_ATTRIBUTES"/> enumeration.</para>
        /// </summary>
        public Span<LUID_AND_ATTRIBUTES> Privileges => SpanOverRef.GetSpan(ref Privilege, PrivilegeCount);
    }
}
