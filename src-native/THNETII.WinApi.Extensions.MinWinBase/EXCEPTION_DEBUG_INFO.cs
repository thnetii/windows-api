using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 300
    /// <summary>
    /// Contains exception information that can be used by a debugger.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-exception_debug_info">EXCEPTION_DEBUG_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="DEBUG_EVENT"/>
    /// <seealso cref="EXCEPTION_RECORD"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_DEBUG_INFO
    {
        /// <summary>
        /// An <see cref="EXCEPTION_RECORD"/> structure with information specific to the exception. This includes the exception code, flags, address, a pointer to a related exception, extra parameters, and so on.
        /// </summary>
        public EXCEPTION_RECORD ExceptionRecord;
        /// <summary>
        /// A value that indicates whether the debugger has previously encountered the exception specified by the <see cref="ExceptionRecord"/> member. If the <see cref="dwFirstChance"/> member is nonzero, this is the first time the debugger has encountered the exception. Debuggers typically handle breakpoint and single-step exceptions when they are first encountered. If this member is zero, the debugger has previously encountered the exception. This occurs only if, during the search for structured exception handlers, either no handler was found or the exception was continued.
        /// </summary>
        public int dwFirstChance;
    }
}
