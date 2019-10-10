using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 332
    /// <summary>
    /// Contains the exit code for a terminating process.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-load_dll_debug_info">LOAD_DLL_DEBUG_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="CREATE_PROCESS_DEBUG_INFO"/>
    /// <seealso cref="CREATE_THREAD_DEBUG_INFO"/>
    /// <seealso cref="DEBUG_EVENT"/>
    /// <seealso cref="DebugActiveProcess"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct LOAD_DLL_DEBUG_INFO
    {
        /// <summary>
        /// A handle to the loaded DLL. If this member is <see cref="IntPtr.Zero"/>, the handle is not valid. Otherwise, the member is opened for reading and read-sharing in the context of the debugger.
        /// <para>When the debugger is finished with this file, it should close the handle using the <see cref="CloseHandle"/> function.</para>
        /// </summary>
        public IntPtr hFile;
        /// <summary>
        /// A pointer to the base address of the DLL in the address space of the process loading the DLL.
        /// </summary>
        public IntPtr lpBaseOfDll;
        /// <summary>
        /// The offset to the debugging information in the file identified by the <see cref="hFile"/> member, in bytes. The system expects the debugging information to be in CodeView 4.0 format. This format is currently a derivative of Common Object File Format (COFF).
        /// </summary>
        public int dwDebugInfoFileOffset;
        /// <summary>
        /// The size of the debugging information in the file, in bytes. If this member is zero, there is no debugging information.
        /// </summary>
        public int nDebugInfoSize;
        /// <summary>
        /// A pointer to the file name associated with <see cref="hFile"/>. This member may be <see cref="IntPtr.Zero"/>, or it may contain the address of a string pointer in the address space of the process being debugged. That address may, in turn, either be <see langword="null"/> or point to the actual filename. If <see cref="fUnicode"/> is <see langword="true"/>, the name string is Unicode; otherwise, it is ANSI.
        /// <para>This member is strictly optional. Debuggers must be prepared to handle the case where <see cref="lpImageName"/> is <see cref="IntPtr.Zero"/> or the dereferenced value (in the address space of the process being debugged) is <see langword="null"/>. Specifically, the system does not provide an image name for a create process event, and will not likely pass an image name for the first DLL event. The system also does not provide this information in the case of debug events that originate from a call to the <see cref="DebugActiveProcess"/> function.</para>
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
