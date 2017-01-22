using System;
using System.Runtime.InteropServices;
using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.MemoryManagementFunctions;
using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.PROCESS_HEAP_FLAGS;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    /// <summary>
    /// Contains information about a heap element. The <see cref="HeapWalk"/> function uses a <see cref="PROCESS_HEAP_ENTRY"/> structure to enumerate the elements of a heap.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366798.aspx">PROCESS_HEAP_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="GlobalAlloc"/>
    /// <seealso cref="HeapAlloc"/>
    /// <seealso cref="HeapWalk"/>
    /// <seealso cref="VirtualAlloc"/>
    /// <seealso cref="VirtualQuery"/>
    [StructLayout(LayoutKind.Sequential)]
    public class PROCESS_HEAP_ENTRY
    {
        /// <summary>
        /// <para>A pointer to the data portion of the heap element.</para>
        /// <para>To initiate a <see cref="HeapWalk"/> heap enumeration, set <see cref="lpData"/> to <see cref="IntPtr.Zero"/>.</para>
        /// <para>If <see cref="PROCESS_HEAP_REGION"/> is used in the <see cref="wFlags"/> member, <see cref="lpData"/> points to the first virtual address used by the region.</para>
        /// <para>If <see cref="PROCESS_HEAP_UNCOMMITTED_RANGE"/> is used in <see cref="wFlags"/>, <see cref="lpData"/> points to the beginning of the range of uncommitted memory.</para>
        /// </summary>
        public IntPtr lpData;
        /// <summary>
        /// <para>The size of the data portion of the heap element, in bytes.</para>
        /// <para>If <see cref="PROCESS_HEAP_REGION"/> is used in <see cref="wFlags"/>, <see cref="cbData"/> specifies the total size, in bytes, of the address space that is reserved for this region.</para>
        /// <para>If <see cref="PROCESS_HEAP_UNCOMMITTED_RANGE"/> is used in <see cref="wFlags"/>, <see cref="cbData"/> specifies the size, in bytes, of the range of uncommitted memory.</para>
        /// </summary>
        public uint cbData;
        /// <summary>
        /// <para>The size of the data used by the system to maintain information about the heap element, in bytes. These overhead bytes are in addition to the <see cref="cbData"/> bytes of the data portion of the heap element.</para>
        /// <para>If <see cref="PROCESS_HEAP_REGION"/> is used in <see cref="wFlags"/>, <see cref="cbOverhead"/> specifies the size, in bytes, of the heap control structures that describe the region.</para>
        /// <para>If <see cref="PROCESS_HEAP_UNCOMMITTED_RANGE"/> is used in <see cref="wFlags"/>, <see cref="cbOverhead"/> specifies the size, in bytes, of the control structures that describe this uncommitted range.</para>
        /// </summary>
        public byte cbOverhead;
        /// <summary>
        /// <para>A handle to the heap region that contains the heap element. A heap consists of one or more regions of virtual memory, each with a unique region index.</para>
        /// <para>In the first heap entry returned for most heap regions, <see cref="HeapWalk"/> uses the <see cref="PROCESS_HEAP_REGION"/> in the <see cref="wFlags"/> member. When this value is used, the members of the <see cref="Region"/> structure contain additional information about the region.</para>
        /// <para>The <see cref="HeapAlloc"/> function sometimes uses the <see cref="VirtualAlloc"/> function to allocate large blocks from a growable heap. The heap manager treats such a large block allocation as a separate region with a unique region index. <see cref="HeapWalk"/> does not use <see cref="PROCESS_HEAP_REGION"/> in the heap entry returned for a large block region, so the members of the <see cref="Region"/> structure are not valid. You can use the <see cref="VirtualQuery"/> function to get additional information about a large block region.</para>
        /// </summary>
        public byte iRegionIndex;
        /// <summary>
        /// The properties of the heap element. Some values affect the meaning of other members of this <see cref="PROCESS_HEAP_ENTRY"/> data structure.
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public PROCESS_HEAP_FLAGS wFlags;
        [StructLayout(LayoutKind.Explicit)]
        private struct PROCESS_HEAP_ENTRY_UNION
        {
            [FieldOffset(0)]
            public PROCESS_HEAP_ENTRY_BLOCK Block;
            [FieldOffset(0)]
            public PROCESS_HEAP_ENTRY_REGION Region;
        }
        private PROCESS_HEAP_ENTRY_UNION Union;
        /// <summary>
        /// This structure is valid only if both the <see cref="PROCESS_HEAP_ENTRY_BUSY"/> and <see cref="PROCESS_HEAP_ENTRY_MOVEABLE"/> are specified in <see cref="wFlags"/>.
        /// </summary>
        public PROCESS_HEAP_ENTRY_BLOCK Block
        {
            get { return Union.Block; }
            set { Union.Block = value; }
        }
        /// <summary>
        /// This structure is valid only if the <see cref="wFlags"/> member specifies <see cref="PROCESS_HEAP_REGION"/>.
        /// </summary>
        public PROCESS_HEAP_ENTRY_REGION Region
        {
            get { return Union.Region; }
            set { Union.Region = value; }
        }
    }
}
