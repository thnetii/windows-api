namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Values appearing in the <see cref="USE_INFO_1.ui1_status"/> field of <see cref="USE_INFO_1"/> structure.
    /// Note that <see cref="USE_SESSLOST"/> and <see cref="USE_DISCONN"/> are synonyms.
    /// </summary>
    public enum USE_STATUS : int
    {
        /// <summary>The connection is valid.</summary>
        USE_OK = 0,
        /// <summary>Paused by local workstation.</summary>
        USE_PAUSED = 1,
        /// <summary>Disconnected.</summary>
        USE_SESSLOST = 2,
        /// <summary>An error occurred.</summary>
        USE_DISCONN = 2,
        /// <summary>A network error occurred.</summary>
        USE_NETERR = 3,
        /// <summary>The connection is being made.</summary>
        USE_CONN = 4,
        /// <summary>The connection is being made.</summary>
        USE_RECONN = 5,
    }
}