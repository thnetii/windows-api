using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8762
    /// <summary>
    /// Contains an exception record with a machine-independent description of an exception and a context record with a machine-dependent description of the processor context at the time of the exception.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-_exception_pointers">EXCEPTION_POINTERS structure</a></para>
    /// </remarks>
    /// <seealso cref="CONTEXT"/>
    /// <seealso cref="EXCEPTION_RECORD"/>
    /// <seealso cref="GetExceptionInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct EXCEPTION_POINTERS
    {
        /// <summary>
        /// A pointer to an <see cref="EXCEPTION_RECORD"/> structure that contains a machine-independent description of the exception.
        /// </summary>
        public EXCEPTION_RECORD* ExceptionRecord;
        /// <summary>
        /// A pointer to a <see cref="CONTEXT"/> structure that contains a processor-specific description of the state of the processor at the time of the exception.
        /// </summary>
        public CONTEXT* ContextRecord;
    }
}
