using Microsoft.Win32.WinApi.Networking.NetworkManagement;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.USER_PRIVILEGE_LEVEL;

namespace THNETII.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>User Privilege levels.</summary>
    public enum NetUserPrivilegeLevel : int
    {
        Guest = USER_PRIV_GUEST,
        User = USER_PRIV_USER,
        Administrator = USER_PRIV_ADMIN
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    internal static class NetUserPrivilegeLevelExtensions
    {
        public static USER_PRIVILEGE_LEVEL AsNative(this NetUserPrivilegeLevel value) => (USER_PRIVILEGE_LEVEL)value;
        public static NetUserPrivilegeLevel AsManaged(this USER_PRIVILEGE_LEVEL value) => (NetUserPrivilegeLevel)value;
    }
}