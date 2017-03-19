using System;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// bit masks for the <see cref="NetUserGetLocalGroups"/> flags
    /// </summary>
    [Flags]
    public enum LG_INCLUDE_FLAG : int
    {
        LG_INCLUDE_INDIRECT = (0x0001),
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}