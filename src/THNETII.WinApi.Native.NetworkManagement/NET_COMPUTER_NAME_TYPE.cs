namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum NET_COMPUTER_NAME_TYPE
    {
        /// <summary>The primary computer name.</summary>
        NetPrimaryComputerName,
        /// <summary>Alternate computer names.</summary>
        NetAlternateComputerNames,
        /// <summary>All computer names.</summary>
        NetAllComputerNames,
        /// <summary>Indicates the end of the range that specifies the possible values for the type of name to be queried.</summary>
        NetComputerNameTypeMax
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}