using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;
using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.PRIVILEGE_ATTRIBUTES;
using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.PRIVILEGE_SET_CONTROL;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="PRIVILEGE_SET"/> structure specifies a set of privileges. It is also used to indicate which, if any, privileges are held by a user or group requesting access to an object.
    /// </summary>
    /// <remarks>
    /// A privilege is used to control access to an object or service more strictly than is typical with discretionary access control. A system manager uses privileges to control which users are able to manipulate system resources. An application uses privileges when it changes a system-wide resource, such as when it changes the system time or shuts down the system.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa446633.aspx">PRIVILEGE_SET structure</a></para>
    /// </remarks>
    /// <seealso cref="LUID_AND_ATTRIBUTES"/>
    /// <seealso cref="PrivilegeCheck"/>
    [StructLayout(LayoutKind.Sequential)]
    public class PRIVILEGE_SET
    {
        /// <summary>Specifies the number of privileges in the privilege set.</summary>
        public int PrivilegeCount;
        /// <summary>
        /// Specifies a control flag related to the privileges. The <see cref="PRIVILEGE_SET_ALL_NECESSARY"/> control flag is currently defined. It indicates that all of the specified privileges must be held by the process <em><a href="https://msdn.microsoft.com/en-us/library/ms721603.aspx#_security_process_gly">process</a></em> access. If this flag is not set, the presence of any privileges in the user's <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_token_gly">access token</a></em> grants the access.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public PRIVILEGE_SET_CONTROL Control;
        /// <summary>
        /// Specifies an array of <see cref="LUID_AND_ATTRIBUTES"/> structures describing the set's privileges.
        /// </summary>
        /// <remarks>
        /// The following attributes are defined for privileges in the <see cref="PRIVILEGE_ATTRIBUTES"/> enumeration.
        /// <list type="table">
        /// <listheader><term>Value</term> <description>Meaning</description></listheader>
        /// <term><see cref="SE_PRIVILEGE_ENABLED_BY_DEFAULT"/></term> <description>The privilege is enabled by default.</description>
        /// <term><see cref="SE_PRIVILEGE_ENABLED"/></term> <description>The privilege is enabled.</description>
        /// <term><see cref="SE_PRIVILEGE_USED_FOR_ACCESS"/></term> <description>The privilege was used to gain access to an object or service. This flag is used to identify the relevant privileges in a set passed by a client application that may contain unnecessary privileges.</description>
        /// </list>
        /// </remarks>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public LUID_AND_ATTRIBUTES[] Privilege;
    }
}