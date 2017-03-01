namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Privilege levels (<strong>USER_INFO_<var>X</var></strong> field <strong>usri<var>X</var>_priv</strong>.
    /// </summary>
    public enum USER_PRIVILEGE_LEVEL : int
    {
        USER_PRIV_MASK = 0x3,
        /// <summary>Guest</summary>
        USER_PRIV_GUEST = 0,
        /// <summary>User</summary>
        USER_PRIV_USER = 1,
        /// <summary>Administrator</summary>
        USER_PRIV_ADMIN = 2,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}