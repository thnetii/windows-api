using System;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Object Manager Symbolic Link Specific Access Rights.
    /// </summary>
    [Flags]
    public enum DUPLICATE_FLAGS : int
    {
        /// <summary>
        /// Closes the source handle.
        /// </summary>
        DUPLICATE_CLOSE_SOURCE = WinNTConstants.DUPLICATE_CLOSE_SOURCE,
        /// <summary>
        /// The duplicate handle has the same access as the source handle.
        /// </summary>
        DUPLICATE_SAME_ACCESS = WinNTConstants.DUPLICATE_SAME_ACCESS,
    }
}
