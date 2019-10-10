namespace THNETII.WinApi.Native.MinWinBase
{
    using static LMEM_FLAGS;

    public enum PROCESS_HEAP_FLAGS : short
    {
        /// <summary>
        /// The heap element is located at the beginning of a region of contiguous virtual memory in use by the heap.<br/>
        /// The <see cref="PROCESS_HEAP_ENTRY.lpData"/> member of the <see cref="PROCESS_HEAP_ENTRY"/> structure points to the first virtual address used by the region; the <see cref="PROCESS_HEAP_ENTRY.cbData"/> member specifies the total size, in bytes, of the address space that is reserved for this region; and the <see cref="PROCESS_HEAP_ENTRY.cbOverhead"/> member specifies the size, in bytes, of the heap control structures that describe the region.
        /// <para>
        /// The <see cref="PROCESS_HEAP_ENTRY.Region"/> structure becomes valid. Its members contain additional information about the region.
        /// </para>
        /// </summary>
        PROCESS_HEAP_REGION = MinWinBaseConstants.PROCESS_HEAP_REGION,
        /// <summary>
        /// The heap element is located in a range of uncommitted memory within the heap region.<br/>
        /// The <see cref="PROCESS_HEAP_ENTRY.lpData"/> member points to the beginning of the range of uncommitted memory; the <see cref="PROCESS_HEAP_ENTRY.cbData"/> member specifies the size, in bytes, of the range of uncommitted memory; and the <see cref="PROCESS_HEAP_ENTRY.cbOverhead"/> member specifies the size, in bytes, of the control structures that describe this uncommitted range.
        /// </summary>
        PROCESS_HEAP_UNCOMMITTED_RANGE = MinWinBaseConstants.PROCESS_HEAP_UNCOMMITTED_RANGE,
        /// <summary>
        /// The heap element is an allocated block.<br/>
        /// If <see cref="PROCESS_HEAP_ENTRY_MOVEABLE"/> is also specified, the <see cref="PROCESS_HEAP_ENTRY.Block"/> structure becomes valid. The <see cref="PROCESS_HEAP_BLOCK.hMem"/> member of the <see cref="PROCESS_HEAP_ENTRY.Block"/> structure contains a handle to the allocated, moveable memory block.
        /// </summary>
        PROCESS_HEAP_ENTRY_BUSY = MinWinBaseConstants.PROCESS_HEAP_ENTRY_BUSY,
        PROCESS_HEAP_SEG_ALLOC = MinWinBaseConstants.PROCESS_HEAP_SEG_ALLOC,
        /// <summary>
        /// This value must be used with <see cref="PROCESS_HEAP_ENTRY_BUSY"/>, indicating that the heap element is an allocated block.
        /// <para>The block was allocated with <see cref="LMEM_MOVEABLE"/> or <see cref="F:THNETII.WinApi.Native.WinBase.GMEM_FLAGS.GMEM_MOVEABLE"/>, and the <see cref="PROCESS_HEAP_ENTRY.Block"/> structure becomes valid. The <see cref="PROCESS_HEAP_BLOCK.hMem"/> member of the <see cref="PROCESS_HEAP_ENTRY.Block"/> structure contains a handle to the allocated, moveable memory block.</para>
        /// </summary>
        PROCESS_HEAP_ENTRY_MOVEABLE = MinWinBaseConstants.PROCESS_HEAP_ENTRY_MOVEABLE,
        /// <summary>
        /// This value must be used with <see cref="PROCESS_HEAP_ENTRY_BUSY"/>, indicating that the heap element is an allocated block. 
        /// </summary>
        PROCESS_HEAP_ENTRY_DDESHARE = MinWinBaseConstants.PROCESS_HEAP_ENTRY_DDESHARE,
    }
}
