using System;
using System.Runtime.InteropServices;
using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.MemoryManagementFunctions;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    /// <summary>
    /// Contains information about a range of pages in the virtual address space of a process. The <see cref="VirtualQuery"/> and <see cref="VirtualQueryEx"/> functions use this structure.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa366775.aspx">MEMORY_BASIC_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="VirtualAlloc"/>
    /// <seealso cref="VirtualQuery"/>
    /// <seealso cref="VirtualQueryEx"/>
    [StructLayout(LayoutKind.Sequential)]
    public class MEMORY_BASIC_INFORMATION
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        [MarshalAs(UnmanagedType.I4)]
        public PAGE_ACCESS_FLAGS AllocationProtect;
        [MarshalAs(UnmanagedType.SysUInt)]
        public ulong RegionSize;
        [MarshalAs(UnmanagedType.I4)]
        public MEM_FLAGS State;
        [MarshalAs(UnmanagedType.I4)]
        public PAGE_ACCESS_FLAGS Protect;
        [MarshalAs(UnmanagedType.I4)]
        public MEM_FLAGS Type;
    }
}
