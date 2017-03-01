using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Values of the ui1_asg_type field of use_info_1 structure
    /// </summary>
    public enum USE_ASG_TYPE : int
    {
        /// <summary>Matches the type of the server's shared resources. Wildcards can be used only with the <see cref="NetUseAdd"/> function, and only when the <see cref="USE_INFO_1.ui1_local"/> member is <c>null</c>.</summary>
        USE_WILDCARD = -1,
        /// <summary>Disk device.</summary>
        USE_DISKDEV = 0,
        /// <summary>Spooled printer.</summary>
        USE_SPOOLDEV = 1,
        USE_CHARDEV = 2,
        /// <summary>Interprocess communication (IPC).</summary>
        USE_IPC = 3,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}