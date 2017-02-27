using System;

using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.MemoryManagementFunctions;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>Global Memory Flags</summary>
    [Flags]
    public enum GMEM_FLAGS : uint
    {
        /// <summary>Fixed memory.</summary>
        GMEM_FIXED = 0x0000,
        /// <summary>
        /// Movable memory. Memory blocks are never moved in physical memory, but they can be moved within the default heap.
        /// <para>To translate a movable handle into a pointer, use the <see cref="GlobalLock"/> function.</para>
        /// <para>This value cannot be combined with <see cref="GMEM_FIXED"/>.</para>
        /// </summary>
        GMEM_MOVEABLE = 0x0002,
        [Obsolete("Value is obsolete, but is provided for compatability with 16-bit Windows.")]
        GMEM_NOCOMPACT = 0x0010,
        [Obsolete("Value is obsolete, but is provided for compatability with 16-bit Windows.")]
        GMEM_NODISCARD = 0x0020,
        /// <summary>Initializes memory contents to zero.</summary>
        GMEM_ZEROINIT = 0x0040,
        GMEM_MODIFY = 0x0080,
        [Obsolete("Value is obsolete, but is provided for compatability with 16-bit Windows.")]
        GMEM_DISCARDABLE = 0x0100,
        [Obsolete("Value is obsolete, but is provided for compatability with 16-bit Windows.")]
        GMEM_NOT_BANKED = 0x1000,
        [Obsolete("Value is obsolete, but is provided for compatability with 16-bit Windows.")]
        GMEM_SHARE = 0x2000,
        [Obsolete("Value is obsolete, but is provided for compatability with 16-bit Windows.")]
        GMEM_DDESHARE = 0x2000,
        [Obsolete("Value is obsolete, but is provided for compatability with 16-bit Windows.")]
        GMEM_NOTIFY = 0x4000,
        [Obsolete("Value is obsolete, but is provided for compatability with 16-bit Windows.")]
        GMEM_LOWER = GMEM_NOT_BANKED,
        [Obsolete("Value is obsolete, but is provided for compatability with 16-bit Windows.")]
        GMEM_VALID_FLAGS = 0x7F72,
        /// <summary>Indicates an invalid global handle.</summary>
        GMEM_INVALID_HANDLE = 0x8000,

        /// <summary>Combines <see cref="GMEM_MOVEABLE"/> and <see cref="GMEM_ZEROINIT"/>.</summary>
        GHND = (GMEM_MOVEABLE | GMEM_ZEROINIT),
        /// <summary>Combines <see cref="GMEM_FIXED"/> and <see cref="GMEM_ZEROINIT"/>.</summary>
        GPTR = (GMEM_FIXED | GMEM_ZEROINIT),

        /* Flags returned by GlobalFlags (in addition to GMEM_DISCARDABLE) */
        GMEM_DISCARDED = 0x4000,
        /// <summary>To retrieve the lock count from global handle flags return value, use the <see cref="GMEM_LOCKCOUNT"/> mask with the bitwise AND (&amp;) operator. The lock count of memory objects allocated with <see cref="GMEM_FIXED"/> is always zero.</summary>
        GMEM_LOCKCOUNT = 0x00FF,

    }

    public static class GlobalMemoryFlagsExtensions
    {
        public static int GetLockCount(this GMEM_FLAGS uFlags) => (int)(uFlags & GMEM_FLAGS.GMEM_LOCKCOUNT);
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}