using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9613
    /// <summary>
    /// Group related SID attributes
    /// </summary>
    [Flags]
    public enum SE_GROUP_ATTRIBUTES
    {
        /// <summary>
        /// The SID cannot have the <see cref="SE_GROUP_ENABLED"/> attribute cleared by a call to the <see cref="AdjustTokenGroups"/> function. However, you can use the <see cref="CreateRestrictedToken"/> function to convert a mandatory SID to a deny-only SID.
        /// </summary>
        SE_GROUP_MANDATORY = WinNTConstants.SE_GROUP_MANDATORY,
        /// <summary>
        /// The SID is enabled by default.
        /// </summary>
        SE_GROUP_ENABLED_BY_DEFAULT = WinNTConstants.SE_GROUP_ENABLED_BY_DEFAULT,
        /// <summary>
        /// <para> The <see cref="SID"/> is enabled for access checks. When the system performs an access check, it checks for access-allowed and access-denied <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access control entries</a> (ACEs) that apply to the SID.</para>
        /// <para>A SID without this attribute is ignored during an access check unless the <see cref="SE_GROUP_USE_FOR_DENY_ONLY"/> attribute is set.</para>
        /// </summary>
        SE_GROUP_ENABLED = WinNTConstants.SE_GROUP_ENABLED,
        /// <summary>
        /// The SID identifies a group account for which the user of the token is the owner of the group, or the SID can be assigned as the owner of the token or objects.
        /// </summary>
        SE_GROUP_OWNER = WinNTConstants.SE_GROUP_OWNER,
        /// <summary>
        /// The SID is a deny-only SID in a <a href="https://msdn.microsoft.com/06580ab9-ff58-4aa9-bf88-9536a2e1981d">restricted token</a>. When the system performs an access check, it checks for access-denied ACEs that apply to the SID; it ignores access-allowed ACEs for the SID.
        /// <para>If this attribute is set, <see cref="SE_GROUP_ENABLED"/> is not set, and the SID cannot be reenabled.</para>
        /// </summary>
        SE_GROUP_USE_FOR_DENY_ONLY = WinNTConstants.SE_GROUP_USE_FOR_DENY_ONLY,
        /// <summary>
        /// The SID is a mandatory integrity SID.
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP</strong>: This value is not supported.</para>
        /// </summary>
        SE_GROUP_INTEGRITY = WinNTConstants.SE_GROUP_INTEGRITY,
        /// <summary>
        /// The mandatory integrity SID is evaluated during access check.
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP</strong>: This value is not supported.</para>
        /// </summary>
        SE_GROUP_INTEGRITY_ENABLED = WinNTConstants.SE_GROUP_INTEGRITY_ENABLED,
        /// <summary>
        /// The SID is a logon SID that identifies the <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">logon session</a> associated with an access token.
        /// </summary>
        SE_GROUP_LOGON_ID = WinNTConstants.SE_GROUP_LOGON_ID,
        /// <summary>
        ///  The SID identifies a domain-local group.
        /// </summary>
        SE_GROUP_RESOURCE = WinNTConstants.SE_GROUP_RESOURCE,
        SE_GROUP_VALID_ATTRIBUTES = WinNTConstants.SE_GROUP_VALID_ATTRIBUTES,
    }
}
