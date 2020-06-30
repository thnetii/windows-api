using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.MinWinBase
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 305
    /// <summary>
    /// Contains thread-creation information that can be used by a debugger.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-create_thread_debug_info">CREATE_THREAD_DEBUG_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="CREATE_PROCESS_DEBUG_INFO"/>
    /// <seealso cref="DEBUG_EVENT"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Debug/debugging-structures">Debugging Structures</seealso>
    /// <seealso cref="LOAD_DLL_DEBUG_INFO"/>
    /// <seealso cref="SetThreadContext"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_THREAD_DEBUG_INFO
    {
        /// <summary>
        /// A handle to the thread whose creation caused the debugging event. If this member is <see cref="IntPtr.Zero"/>, the handle is not valid. Otherwise, the debugger has <see cref="THREAD_GET_CONTEXT"/>, <see cref="THREAD_SET_CONTEXT"/>, and <see cref="THREAD_SUSPEND_RESUME"/> access to the thread, allowing the debugger to read from and write to the registers of the thread and control execution of the thread.
        /// </summary>
        public IntPtr hThread;
        /// <summary>
        /// A pointer to a block of data. At offset <c>0x2C</c> into this block is another pointer, called <c>ThreadLocalStoragePointer</c>, that points to an array of per-module thread local storage blocks. This gives a debugger access to per-thread data in the threads of the process being debugged using the same algorithms that a compiler would use.
        /// </summary>
        public IntPtr lpThreadLocalBase;
        /// <summary>
        /// A pointer to the starting address of the thread. This value may only be an approximation of the thread's starting address, because any application with appropriate access to the thread can change the thread's context by using the <see cref="SetThreadContext"/> function.
        /// </summary>
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public LPTHREAD_START_ROUTINE lpStartAddress;
    }
}
