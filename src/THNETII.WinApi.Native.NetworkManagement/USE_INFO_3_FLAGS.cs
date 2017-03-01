using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Flags defined in the <see cref="USE_INFO_3"/> structure
    /// </summary>
    public enum USE_INFO_3_FLAGS : int
    {
        /// <summary>Do not connect to the server.</summary>
        CREATE_NO_CONNECT = 0x1,
        /// <summary>
        /// force connection to server, bypassing CSC
        /// all ops on this connection go to the server,
        /// never to the cache
        /// </summary>
        CREATE_BYPASS_CSC = 0x2,
        /// <summary>
        /// Create a connection with credentials passed in 
        /// this netuse if none exist. If connection already 
        /// exists then update credentials after issuing remote
        /// tree connection. This is needed as CSC cannot verify 
        /// credentials while offline.
        /// </summary>
        CREATE_CRED_RESET = 0x4,
        /// <summary>No explicit credentials passed to <see cref="NetUseAdd"/></summary>
        USE_DEFAULT_CREDENTIALS = 0x4,
    }
}