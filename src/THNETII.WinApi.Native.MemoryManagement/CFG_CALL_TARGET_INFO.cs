using System;
using System.Runtime.InteropServices;
using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.CFG_CALL_TARGET_FLAGS;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    /// <summary>
    /// Represents information about call targets for Control Flow Guard (CFG).
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/mt219054.aspx">CFG_CALL_TARGET_INFO structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public class CFG_CALL_TARGET_INFO
    {
        /// <summary>Offset relative to a provided (start) virtual address. This offset should be 16 byte aligned.</summary>
        public UIntPtr Offset;
        /// <summary>
        /// Flags describing the operation to be performed on the address. If <see cref="CFG_CALL_TARGET_VALID"/> is set, then the address will be marked valid for CFG. Otherwise, it will be marked an invalid call target. 
        /// </summary>
        [MarshalAs(UnmanagedType.SysUInt)]
        public CFG_CALL_TARGET_FLAGS Flags;
    }
}
