using System;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Masks describing AUTOPROFILE parameters
    /// </summary>
    [Flags]
    public enum SW_AUTOPROF : int
    {
        /// <summary>The server loads the profile.</summary>
        SW_AUTOPROF_LOAD_MASK = 0x1,
        /// <summary>The server saves the profile.</summary>
        SW_AUTOPROF_SAVE_MASK = 0x2,
    }
}