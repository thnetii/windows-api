using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 328
    /// <summary>
    /// Contains the exit code for a terminating process.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-exit_process_debug_info">EXIT_PROCESS_DEBUG_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="DEBUG_EVENT"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct EXIT_PROCESS_DEBUG_INFO
    {
        /// <summary>The exit code for the process.</summary>
        public int dwExitCode;
    }
}
