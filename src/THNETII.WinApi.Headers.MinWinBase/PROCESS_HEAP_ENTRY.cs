using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.MinWinBase
{
    using static PROCESS_HEAP_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 234
    /// <summary>
    /// Contains information about a heap element. The <see cref="HeapWalk"/> function uses a <see cref="PROCESS_HEAP_ENTRY"/> structure to enumerate the elements of a heap.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-process_heap_entry">PROCESS_HEAP_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="GlobalAlloc"/>
    /// <seealso cref="HeapAlloc"/>
    /// <seealso cref="HeapWalk"/>
    /// <seealso cref="VirtualAlloc"/>
    /// <seealso cref="VirtualQuery"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_HEAP_ENTRY
    {
        /// <summary>
        /// A pointer to the data portion of the heap element.
        /// <para>To initiate a <see cref="HeapWalk"/> heap enumeration, set <see cref="lpData"/> to <see cref="IntPtr.Zero"/>.</para>
        /// <para>If <see cref="PROCESS_HEAP_FLAGS.PROCESS_HEAP_REGION"/> is used in the <see cref="wFlags"/> member, <see cref="lpData"/> points to the first virtual address used by the region.</para>
        /// <para>If <see cref="PROCESS_HEAP_UNCOMMITTED_RANGE"/> is used in <see cref="wFlags"/>, <see cref="lpData"/> points to the beginning of the range of uncommitted memory.</para>
        /// </summary>
        public IntPtr lpData;
        /// <summary>
        /// The size of the data portion of the heap element, in bytes.
        /// <para>If <see cref="PROCESS_HEAP_FLAGS.PROCESS_HEAP_REGION"/> is used in <see cref="wFlags"/>, <see cref="cbData"/> specifies the total size, in bytes, of the address space that is reserved for this region.</para>
        /// <para>If <see cref="PROCESS_HEAP_UNCOMMITTED_RANGE"/> is used in <see cref="wFlags"/>, <see cref="cbData"/> specifies the size, in bytes, of the range of uncommitted memory.</para>
        /// </summary>
        public int cbData;
        /// <summary>
        /// The size of the data used by the system to maintain information about the heap element, in bytes. These overhead bytes are in addition to the <see cref="cbData"/> bytes of the data portion of the heap element.
        /// <para>If <see cref="PROCESS_HEAP_FLAGS.PROCESS_HEAP_REGION"/> is used in <see cref="wFlags"/>, <see cref="cbOverhead"/> specifies the size, in bytes, of the heap control structures that describe the region.</para>
        /// <para>If <see cref="PROCESS_HEAP_UNCOMMITTED_RANGE"/> is used in <see cref="wFlags"/>, <see cref="cbOverhead"/> specifies the size, in bytes, of the control structures that describe this uncommitted range.</para>
        /// </summary>
        public byte cbOverhead;
        /// <summary>
        /// A handle to the heap region that contains the heap element. A heap consists of one or more regions of virtual memory, each with a unique region index.
        /// <para>In the first heap entry returned for most heap regions, <see cref="HeapWalk"/> uses the <see cref="PROCESS_HEAP_FLAGS.PROCESS_HEAP_REGION"/> in the <see cref="wFlags"/> member. When this value is used, the members of the <see cref="Region"/> structure contain additional information about the region.</para>
        /// <para>The <see cref="HeapAlloc"/> function sometimes uses the <see cref="VirtualAlloc"/> function to allocate large blocks from a growable heap. The heap manager treats such a large block allocation as a separate region with a unique region index. <see cref="HeapWalk"/> does not use <see cref="PROCESS_HEAP_FLAGS.PROCESS_HEAP_REGION"/> in the heap entry returned for a large block region, so the members of the <see cref="Region"/> structure are not valid. You can use the <see cref="VirtualQuery"/> function to get additional information about a large block region.</para>
        /// </summary>
        public byte iRegionIndex;
        /// <summary>
        /// The properties of the heap element. Some values affect the meaning of other members of this <see cref="PROCESS_HEAP_ENTRY"/> data structure.
        /// </summary>
        public PROCESS_HEAP_FLAGS wFlags;

        [StructLayout(LayoutKind.Explicit)]
        internal struct DUMMYUNIONNAME
        {
            [FieldOffset(0)]
            public PROCESS_HEAP_BLOCK Block;
            [FieldOffset(0)]
            public PROCESS_HEAP_REGION Region;
        }
        internal DUMMYUNIONNAME u;
        public ref PROCESS_HEAP_BLOCK Block => ref SpanOverRef.GetSpan(ref u.Block)[0];
        public ref PROCESS_HEAP_REGION Region => ref SpanOverRef.GetSpan(ref u.Region)[0];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PROCESS_HEAP_BLOCK
    {
        /// <summary>
        /// Handle to the allocated, moveable memory block.
        /// </summary>
        public IntPtr hMem;
        internal fixed int dwReserved[3];
        /// <summary>
        /// Reserved; not used.
        /// </summary>
        public Span<int> Reserved
        {
            get
            {
                fixed (int* ptr = dwReserved)
                    return new Span<int>(ptr, 3);
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_HEAP_REGION
    {
        /// <summary>
        /// Number of bytes in the heap region that are currently committed as free memory blocks, busy memory blocks, or heap control structures.
        /// <para>This is an optional field that is set to zero if the number of committed bytes is not available.</para>
        /// </summary>
        public int dwCommittedSize;
        /// <summary>
        /// Number of bytes in the heap region that are currently uncommitted.
        /// <para>This is an optional field that is set to zero if the number of committed bytes is not available.</para>
        /// </summary>
        public int dwUnCommittedSize;
        /// <summary>
        /// Pointer to the first valid memory block in this heap region.
        /// </summary>
        public IntPtr lpFirstBlock;
        /// <summary>
        /// Pointer to the first invalid memory block in this heap region.
        /// </summary>
        public IntPtr lpLastBlock;
    }
}
