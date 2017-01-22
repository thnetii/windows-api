using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_HEAP_ENTRY_REGION
    {
        /// <summary>
        /// <para>Number of bytes in the heap region that are currently committed as free memory blocks, busy memory blocks, or heap control structures.</para>
        /// <para>This is an optional field that is set to zero if the number of committed bytes is not available.</para>
        /// </summary>
        public uint dwCommittedSize;
        /// <summary>
        /// <para>Number of bytes in the heap region that are currently uncommitted.</para>
        /// <para>This is an optional field that is set to zero if the number of committed bytes is not available.</para>
        /// </summary>
        public uint dwUnCommittedSize;
        /// <summary>
        /// Pointer to the first valid memory block in this heap region.
        /// </summary>
        public IntPtr lpFirstBlock;
        /// <summary>
        /// Pointer to the first invalid memory block in this heap region.
        /// </summary>
        public IntPtr lpLastBlock;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}