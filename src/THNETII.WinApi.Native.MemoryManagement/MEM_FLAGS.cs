using System;
using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.SEC_FLAGS;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags]
    public enum MEM_FLAGS : int
    {
        /// <summary>
        /// Indicates committed pages for which physical storage has been allocated, either in memory or in the paging file on disk.
        /// </summary>
        MEM_COMMIT = 0x00001000,
        /// <summary>
        /// Indicates reserved pages where a range of the process's virtual address space is reserved without any physical storage being allocated.
        /// </summary>
        MEM_RESERVE = 0x00002000,
        MEM_DECOMMIT = 0x00004000,
        MEM_RELEASE = 0x00008000,
        /// <summary>
        /// Indicates free pages not accessible to the calling process and available to be allocated.
        /// </summary>
        MEM_FREE = 0x00010000,
        /// <summary>Indicates that the memory pages within the region are private (that is, not shared by other processes).</summary>
        MEM_PRIVATE = 0x00020000,
        /// <summary>Indicates that the memory pages within the region are mapped into the view of a section.</summary>
        MEM_MAPPED = 0x00040000,
        MEM_RESET = 0x00080000,
        MEM_TOP_DOWN = 0x00100000,
        MEM_WRITE_WATCH = 0x00200000,
        MEM_PHYSICAL = 0x00400000,
        MEM_ROTATE = 0x00800000,
        MEM_DIFFERENT_IMAGE_BASE_OK = 0x00800000,
        MEM_RESET_UNDO = 0x01000000,
        MEM_LARGE_PAGES = 0x20000000,
        MEM_4MB_PAGES = unchecked((int)0x80000000),
        MEM_64K_PAGES = (MEM_LARGE_PAGES | MEM_PHYSICAL),
        /// <summary>Indicates that the memory pages within the region are mapped into the view of an image section.</summary>
        MEM_IMAGE = SEC_IMAGE,
        MEM_UNMAP_WITH_TRANSIENT_BOOST = 0x01
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}