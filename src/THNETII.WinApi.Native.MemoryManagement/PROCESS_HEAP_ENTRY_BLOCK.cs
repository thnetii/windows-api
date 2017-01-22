using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_HEAP_ENTRY_BLOCK
    {
        /// <summary>
        /// Handle to the allocated, moveable memory block.
        /// </summary>
        public IntPtr hMem;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}