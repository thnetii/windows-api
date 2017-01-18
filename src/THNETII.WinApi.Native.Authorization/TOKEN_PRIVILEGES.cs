using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;
using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.SE_PRIVILEGE_ATTRIBUTES;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="TOKEN_PRIVILEGES"/> structure contains information about a set of privileges for an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_token_gly">access token</a></em>.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379630.aspx">TOKEN_PRIVILEGES structure</a></para>
    /// </remarks>
    /// <seealso cref="AdjustTokenPrivileges"/>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="LookupPrivilegeName"/>
    /// <seealso cref="LUID_AND_ATTRIBUTES"/>
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
    public class TOKEN_PRIVILEGES
    {
        public static readonly int SizeOf = Marshal.SizeOf<TOKEN_PRIVILEGES>();

        /// <summary>This must be set to the number of entries in the <see cref="Privileges"/> array.</summary>
        public int PrivilegeCount;
        /// <summary>
        /// Specifies an array of <see cref="LUID_AND_ATTRIBUTES"/> structures. Each structure contains the LUID and attributes of a privilege. To get the name of the privilege associated with a LUID, call the <see cref="LookupPrivilegeName"/> function, passing the address of the LUID as the value of the <em>lpLuid</em> parameter.
        /// </summary>
        /// <remarks>
        /// The attributes of a privilege can be a combination of the following values defined in the <see cref="SE_PRIVILEGE_ATTRIBUTES"/> enumeration. 
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><see cref="SE_PRIVILEGE_ENABLED"/></term> <description>The privilege is enabled.</description>
        /// <term><see cref="SE_PRIVILEGE_ENABLED_BY_DEFAULT"/></term> <description>The privilege is enabled by default.</description>
        /// <term><see cref="SE_PRIVILEGE_REMOVED"/></term> <description>Used to remove a privilege. For details, see <see cref="AdjustTokenPrivileges"/>.</description>
        /// <term><see cref="SE_PRIVILEGE_USED_FOR_ACCESS"/></term> <description>The privilege was used to gain access to an object or service. This flag is used to identify the relevant privileges in a set passed by a client application that may contain unnecessary privileges.</description>
        /// </list>
        /// </remarks>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public LUID_AND_ATTRIBUTES[] Privileges;
    }
}
