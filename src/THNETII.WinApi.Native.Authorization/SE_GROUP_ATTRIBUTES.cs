using System;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>Group attributes</summary>
    [Flags]
    public enum SE_GROUP_ATTRIBUTES : int
    {
        /// <summary>
        /// The SID cannot have the <see cref="SE_GROUP_ENABLED"/> attribute cleared by a call to the <see cref="AdjustTokenGroups"/> function. However, you can use the <see cref="CreateRestrictedToken"/> function to convert a mandatory SID to a deny-only SID.
        /// </summary>
        SE_GROUP_MANDATORY = (0x00000001),
        /// <summary>
        /// The SID is enabled by default.
        /// </summary>
        SE_GROUP_ENABLED_BY_DEFAULT = (0x00000002),
        /// <summary>
        /// <para>The SID is enabled for access checks. When the system performs an access check, it checks for access-allowed and access-denied <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entries</a></em> (ACEs) that apply to the SID. </para>
        /// <para>A SID without this attribute is ignored during an access check unless the <see cref="SE_GROUP_USE_FOR_DENY_ONLY"/> attribute is set.</para>
        /// </summary>
        SE_GROUP_ENABLED = (0x00000004),
        /// <summary>
        /// The SID identifies a group account for which the user of the token is the owner of the group, or the SID can be assigned as the owner of the token or objects.
        /// </summary>
        SE_GROUP_OWNER = (0x00000008),
        /// <summary>
        /// The SID is a deny-only SID in a <a href="https://msdn.microsoft.com/en-us/library/aa379316.aspx">restricted token</a>. When the system performs an access check, it checks for access-denied ACEs that apply to the SID; it ignores access-allowed ACEs for the SID. 
        /// <para>If this attribute is set, <see cref="SE_GROUP_ENABLED"/> is not set, and the SID cannot be reenabled.</para>
        /// </summary>
        SE_GROUP_USE_FOR_DENY_ONLY = (0x00000010),
        /// <summary>
        /// The SID is a mandatory integrity SID.
        /// </summary>
        SE_GROUP_INTEGRITY = (0x00000020),
        /// <summary>
        /// The SID is enabled for mandatory integrity checks.
        /// </summary>
        SE_GROUP_INTEGRITY_ENABLED = (0x00000040),
        /// <summary>
        /// The SID is a logon SID that identifies the <em><a href="https://msdn.microsoft.com/en-us/library/ms721592.aspx#_security_logon_session_gly">logon session</a></em> associated with an access token.
        /// </summary>
        SE_GROUP_LOGON_ID = unchecked((int)0xC0000000),
        /// <summary>
        /// The SID identifies a domain-local group.
        /// </summary>
        SE_GROUP_RESOURCE = (0x20000000),

        SE_GROUP_VALID_ATTRIBUTES = (SE_GROUP_MANDATORY | SE_GROUP_ENABLED_BY_DEFAULT | SE_GROUP_ENABLED | SE_GROUP_OWNER | SE_GROUP_USE_FOR_DENY_ONLY | SE_GROUP_LOGON_ID | SE_GROUP_RESOURCE | SE_GROUP_INTEGRITY | SE_GROUP_INTEGRITY_ENABLED)
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
