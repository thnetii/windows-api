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
        SE_GROUP_MANDATORY = WinNTConstants.SE_GROUP_MANDATORY,
        SE_GROUP_ENABLED_BY_DEFAULT = WinNTConstants.SE_GROUP_ENABLED_BY_DEFAULT,
        SE_GROUP_ENABLED = WinNTConstants.SE_GROUP_ENABLED,
        SE_GROUP_OWNER = WinNTConstants.SE_GROUP_OWNER,
        SE_GROUP_USE_FOR_DENY_ONLY = WinNTConstants.SE_GROUP_USE_FOR_DENY_ONLY,
        SE_GROUP_INTEGRITY = WinNTConstants.SE_GROUP_INTEGRITY,
        SE_GROUP_INTEGRITY_ENABLED = WinNTConstants.SE_GROUP_INTEGRITY_ENABLED,
        SE_GROUP_LOGON_ID = WinNTConstants.SE_GROUP_LOGON_ID,
        SE_GROUP_RESOURCE = WinNTConstants.SE_GROUP_RESOURCE,
        SE_GROUP_VALID_ATTRIBUTES = WinNTConstants.SE_GROUP_VALID_ATTRIBUTES,
    }
}
