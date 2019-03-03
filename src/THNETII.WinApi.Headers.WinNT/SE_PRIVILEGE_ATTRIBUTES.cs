using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10316
    /// <summary>
    /// Privilege attributes
    /// </summary>
    [Flags]
    public enum SE_PRIVILEGE_ATTRIBUTES
    {
        /// <summary>
        ///  The privilege is enabled by default. 
        /// </summary>
        SE_PRIVILEGE_ENABLED_BY_DEFAULT = WinNTConstants.SE_PRIVILEGE_ENABLED_BY_DEFAULT,
        /// <summary>
        /// The privilege is enabled.
        /// </summary>
        SE_PRIVILEGE_ENABLED = WinNTConstants.SE_PRIVILEGE_ENABLED,
        /// <summary>
        /// Used to remove a privilege. For details, see <see cref="AdjustTokenPrivileges"/>.
        /// </summary>
        SE_PRIVILEGE_REMOVED = WinNTConstants.SE_PRIVILEGE_REMOVED,
        /// <summary>
        /// The privilege was used to gain access to an object or service. This flag is used to identify the relevant privileges in a set passed by a client application that may contain unnecessary privileges. 
        /// </summary>
        SE_PRIVILEGE_USED_FOR_ACCESS = WinNTConstants.SE_PRIVILEGE_USED_FOR_ACCESS,

        SE_PRIVILEGE_VALID_ATTRIBUTES = WinNTConstants.SE_PRIVILEGE_VALID_ATTRIBUTES,
    }
}
