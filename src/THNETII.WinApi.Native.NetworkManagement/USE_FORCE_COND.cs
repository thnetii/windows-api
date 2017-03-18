using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Definition for <see cref="NetWkstaTransportDel"/> and <see cref="NetUseDel"/> deletion force levels
    /// </summary>
    public enum USE_FORCE_COND : int
    {
        /// <summary>Fail the disconnection if open files exist on the connection.</summary>
        USE_NOFORCE = 0,
        /// <summary>Do not fail the disconnection if open files exist on the connection.</summary>
        USE_FORCE = 1,
        /// <summary>Close any open files and delete the connection.</summary>
        USE_LOTS_OF_FORCE = 2,
    }
}