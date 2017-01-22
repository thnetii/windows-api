using System;
using System.Runtime.InteropServices;
using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.MemoryManagementFunctions;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    /// <summary>
    /// Specifies a range of memory. This structure is used by the <see cref="PrefetchVirtualMemory"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/hh780544.aspx">WIN32_MEMORY_RANGE_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="PrefetchVirtualMemory"/>
    [StructLayout(LayoutKind.Sequential)]
    public class WIN32_MEMORY_RANGE_ENTRY
    {
        /// <summary/>
        public IntPtr VirtualAddress;
        /// <summary/>
        [MarshalAs(UnmanagedType.SysUInt)]
        public ulong NumberOfBytes;
    }
}
