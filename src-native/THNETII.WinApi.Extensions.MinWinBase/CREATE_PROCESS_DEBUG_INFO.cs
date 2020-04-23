using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.MinWinBase
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 311
    /// <summary>
    /// Contains process creation information that can be used by a debugger.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-create_process_debug_info">CREATE_PROCESS_DEBUG_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="CREATE_THREAD_DEBUG_INFO"/>
    /// <seealso cref="DEBUG_EVENT"/>
    /// <seealso cref="DebugActiveProcess"/>
    /// <seealso cref="LOAD_DLL_DEBUG_INFO"/>
    /// <seealso cref="SetThreadContext"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_PROCESS_DEBUG_INFO
    {
        /// <summary>
        /// A handle to the process's image file. If this member is <see cref="IntPtr.Zero"/>, the handle is not valid. Otherwise, the debugger can use the member to read from and write to the image file.
        /// <para>When the debugger is finished with this file, it should close the handle using the <see cref="CloseHandle"/> function.</para>
        /// </summary>
        public IntPtr hFile;
        /// <summary>
        /// A handle to the process. If this member is <see cref="IntPtr.Zero"/>, the handle is not valid. Otherwise, the debugger can use the member to read from and write to the process's memory.
        /// </summary>
        public IntPtr hProcess;
        /// <summary>
        /// A handle to the initial thread of the process identified by the <see cref="hProcess"/> member. If <see cref="hThread"/> param is <see cref="IntPtr.Zero"/>, the handle is not valid. Otherwise, the debugger has <see cref="THREAD_GET_CONTEXT"/>, <see cref="THREAD_SET_CONTEXT"/>, and <see cref="THREAD_SUSPEND_RESUME"/> access to the thread, allowing the debugger to read from and write to the registers of the thread and to control execution of the thread.
        /// </summary>
        public IntPtr hThread;
        /// <summary>
        /// The base address of the executable image that the process is running.
        /// </summary>
        public IntPtr lpBaseOfImage;
        /// <summary>
        /// The offset to the debugging information in the file identified by the <see cref="hFile"/> member.
        /// </summary>
        public int dwDebugInfoFileOffset;
        /// <summary>
        /// The size of the debugging information in the file, in bytes. If this value is zero, there is no debugging information.
        /// </summary>
        public int nDebugInfoSize;
        /// <summary>
        /// A pointer to a block of data. At offset <c>0x2C</c> into this block is another pointer, called <c>ThreadLocalStoragePointer</c>, that points to an array of per-module thread local storage blocks. This gives a debugger access to per-thread data in the threads of the process being debugged using the same algorithms that a compiler would use.
        /// </summary>
        public IntPtr lpThreadLocalBase;
        /// <summary>
        /// A pointer to the starting address of the thread. This value may only be an approximation of the thread's starting address, because any application with appropriate access to the thread can change the thread's context by using the <see cref="SetThreadContext"/> function.
        /// </summary>
        public LPTHREAD_START_ROUTINE lpStartAddress;
        /// <summary>
        /// A pointer to the file name associated with the <see cref="hFile"/> member. This parameter may be <see cref="IntPtr"/>, or it may contain the address of a string pointer in the address space of the process being debugged. That address may, in turn, either be <see langword="null"/> or point to the actual filename. If <see cref="fUnicode"/> is <see langword="true"/>, the name string is Unicode (UTF-16); otherwise, it is ANSI.
        /// <para>
        /// This member is strictly optional. Debuggers must be prepared to handle the case where <see cref="lpImageName"/> is <see cref="IntPtr.Zero"/> or the dereferenced value (in the address space of the process being debugged) is <see langword="null"/>. Specifically, the system does not provide an image name for a create process event, and will not likely pass an image name for the first DLL event. The system also does not provide this information in the case of debug events that originate from a call to the <see cref="DebugActiveProcess"/> function.
        /// </para>
        /// </summary>
        public IntPtr lpImageName;
        internal short fUnicodeField;
        /// <summary>
        /// A value that indicates whether a file name specified by the <see cref="lpImageName"/> member is Unicode or ANSI.
        /// </summary>
        public bool fUnicode
        {
            get => fUnicodeField != 0;
            set => fUnicodeField = (short)(value ? 1 : 0);
        }
    }
}
