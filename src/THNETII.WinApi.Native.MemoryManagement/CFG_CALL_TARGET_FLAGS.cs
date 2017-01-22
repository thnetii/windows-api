using System;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Define flags for setting process CFG valid call target entries.
    /// </summary>
    [Flags]
    public enum CFG_CALL_TARGET_FLAGS : uint
    {
        /// <summary>
        /// Call target should be made valid.  If not set, the call target is made
        /// invalid.  Input flag.
        /// </summary>
        CFG_CALL_TARGET_VALID = (0x00000001),

        /// <summary>
        /// Call target has been successfully processed.  Used to report to the caller
        /// how much progress has been made.  Output flag.
        /// </summary>
        CFG_CALL_TARGET_PROCESSED = (0x00000002),
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}