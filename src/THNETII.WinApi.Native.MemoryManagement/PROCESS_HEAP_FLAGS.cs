using System;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags]
    public enum PROCESS_HEAP_FLAGS : short
    {
        /// <summary>
        /// <para>The heap element is located at the beginning of a region of contiguous virtual memory in use by the heap.</para>
        /// </summary>
        PROCESS_HEAP_REGION = 0x0001,
        /// <summary>
        /// The heap element is located in a range of uncommitted memory within the heap region.
        /// </summary>
        PROCESS_HEAP_UNCOMMITTED_RANGE = 0x0002,
        /// <summary>
        /// The heap element is an allocated block.
        /// </summary>
        PROCESS_HEAP_ENTRY_BUSY = 0x0004,
        PROCESS_HEAP_SEG_ALLOC = 0x0008,
        /// <summary>
        /// This value must be used with <see cref="PROCESS_HEAP_ENTRY_BUSY"/>, indicating that the heap element is an allocated block.
        /// </summary>
        PROCESS_HEAP_ENTRY_MOVEABLE = 0x0010,
        /// <summary>
        /// This value must be used with <see cref="PROCESS_HEAP_ENTRY_BUSY"/>, indicating that the heap element is an allocated block.
        /// </summary>
        PROCESS_HEAP_ENTRY_DDESHARE = 0x0020,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}