using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 341
    /// <summary>
    /// Contains information about a dynamic-link library (DLL) that has just been unloaded.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-unload_dll_debug_info">UNLOAD_DLL_DEBUG_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="DEBUG_EVENT"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct UNLOAD_DLL_DEBUG_INFO
    {
        /// <summary>
        /// A pointer to the base address of the DLL in the address space of the process unloading the DLL.
        /// </summary>
        public IntPtr lpBaseOfDll;
    }
}
