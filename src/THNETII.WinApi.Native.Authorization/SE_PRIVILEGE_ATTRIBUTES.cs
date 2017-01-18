using System;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Privilege attributes
    /// </summary>
    [Flags]
    public enum SE_PRIVILEGE_ATTRIBUTES
    {
        /// <summary>The privilege is enabled by default.</summary>
        SE_PRIVILEGE_ENABLED_BY_DEFAULT = (0x00000001),
        /// <summary>The privilege is enabled.</summary>
        SE_PRIVILEGE_ENABLED = (0x00000002),
        /// <summary>Used to remove a privilege. For details, see <see cref="AdjustTokenPrivileges"/>.</summary>
        SE_PRIVILEGE_REMOVED = (0X00000004),
        /// <summary>The privilege was used to gain access to an object or service. This flag is used to identify the relevant privileges in a set passed by a client application that may contain unnecessary privileges.</summary>
        SE_PRIVILEGE_USED_FOR_ACCESS = unchecked((int)0x80000000),

        SE_PRIVILEGE_VALID_ATTRIBUTES = (SE_PRIVILEGE_ENABLED_BY_DEFAULT | SE_PRIVILEGE_ENABLED | SE_PRIVILEGE_REMOVED | SE_PRIVILEGE_USED_FOR_ACCESS)
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
