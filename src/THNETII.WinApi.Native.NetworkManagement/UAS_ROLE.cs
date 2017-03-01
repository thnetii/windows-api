namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// UAS role manifests under NETLOGON
    /// </summary>
    public enum UAS_ROLE : int
    {
        /// <summary>The logon server is a stand-alone server.</summary>
        UAS_ROLE_STANDALONE = 0,
        /// <summary>The logon server is a member.</summary>
        UAS_ROLE_MEMBER = 1,
        /// <summary>The logon server is a backup.</summary>
        UAS_ROLE_BACKUP = 2,
        /// <summary>The logon server is a domain controller.</summary>
        UAS_ROLE_PRIMARY = 3,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}