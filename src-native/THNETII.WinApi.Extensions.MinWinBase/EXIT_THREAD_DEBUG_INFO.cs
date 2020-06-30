using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 324
    /// <summary>
    /// Contains the exit code for a terminating thread.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-exit_thread_debug_info">EXIT_THREAD_DEBUG_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="DEBUG_EVENT"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct EXIT_THREAD_DEBUG_INFO
    {
        /// <summary>The exit code for the thread.</summary>
        public int dwExitCode;
    }
}
