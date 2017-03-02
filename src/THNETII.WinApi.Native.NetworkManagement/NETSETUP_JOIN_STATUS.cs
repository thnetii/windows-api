namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum NETSETUP_JOIN_STATUS
    {
        /// <summary>The status is unknown.</summary>
        NetSetupUnknownStatus = 0,
        /// <summary>The computer is not joined.</summary>
        NetSetupUnjoined,
        /// <summary>The computer is joined to a workgroup.</summary>
        NetSetupWorkgroupName,
        /// <summary>The computer is joined to a domain.</summary>
        NetSetupDomainName
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}